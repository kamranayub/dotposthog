using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotPostHog.Api;
using DotPostHog.Model;
using PeriodicBatching;
using PeriodicBatching.Interfaces;
using PeriodicBatching.Models;

namespace DotPostHog
{

  /// <summary>
  /// PostHog public API endpoints. Modeled after posthog-js API surface.
  /// </summary>
  /// <remarks>
  /// It's recommended to use a request-scoped lifetime for an Analytics instance, that
  /// way Super Properties and clean up happens without having to reset. 
  /// </remarks>
  public interface IPostHogAnalytics
  {

    /// <summary>
    /// Identifies a user in PostHog
    /// </summary>
    /// <returns></returns>
    void Identify(string distinctId, IDictionary<string, object> sysSet = null, IDictionary<string, object> sysSetOnce = null);

    /// <summary>
    /// Aliases a user in PostHog. Alias ID should not match any existing distinct ID.
    /// </summary>
    /// <param name="distinctId">New distinct ID</param>
    /// <param name="aliasId">Old distinct ID</param>
    /// <returns></returns>
    void Alias(string distinctId, string aliasId);

    /// <summary>
    /// Captures an event in PostHog
    /// </summary>
    /// <returns></returns>
    void Capture(string eventName, PostHogEventProperties properties = null);

    /// <summary>
    /// Immediately flushes the event queue to PostHog. This is automatically called when the instance is disposed.
    /// </summary>
    /// <returns></returns>
    void Flush();

    /// <summary>
    /// Sets a user's properties as its own event
    /// </summary>
    /// <param name="sysSet"></param>
    /// <param name="sysSetOnce"></param>
    /// <returns></returns>
    void SetPersonProperties(IDictionary<string, object> sysSet, IDictionary<string, object> sysSetOnce = null);

    /// <summary>
    /// Registers Super Properties that will persist for the lifetime of the instance
    /// </summary> 
    void Register(IDictionary<string, object> properties);

    /// <summary>
    /// Registers Super Properties that will only be set once for the lifetime of the instance,
    /// and will not be overwritten by subsequent calls to Register 
    /// </summary> 
    void RegisterOnce(IDictionary<string, object> properties);

    /// <summary>
    /// Removes a stored Super Property
    /// </summary> 
    void Unregister(string property);
  }

  public class BatchingCaptureAdapter : IDisposable
  {
    private static IPeriodicBatching<PostHogEvent> _batcher;
    private readonly string _publicApiKey;
    private readonly ICaptureApi _captureApi;

    public BatchingCaptureAdapter(string publicApiKey, ICaptureApi captureApi)
    {
      _publicApiKey = publicApiKey;
      _captureApi = captureApi;

      var batchingConfig = new PeriodicBatchingConfiguration<PostHogEvent>
      {
        // PostHog limits batch content length to 20MB,
        // and we don't exactly know how big that will be based on 
        // number of events
        BatchSizeLimit = 500,
        BatchingFunc = PostEventBatch
      };
      _batcher = new PeriodicBatching<PostHogEvent>(batchingConfig);
    }

    private async Task PostEventBatch(List<PostHogEvent> events)
    {
      if (events.Count <= 0)
      {
        return;
      }

      var body = new PostHogEventsCaptureRequest(
        new PostHogEventsCaptureRequestAnyOf(_publicApiKey, events.ToList()));

      await _captureApi.CaptureSendBatchAsync(null, null, body);
    }

    public void Enqueue(PostHogEvent body)
    {
      _batcher.Add(body);
    }

    public void Flush()
    {
      _batcher.Flush();
    }

    bool _disposed;

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    ~BatchingCaptureAdapter()
    {
      Dispose(false);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (_disposed)
        return;

      if (disposing)
      {
        _batcher.Dispose();
      }

      _disposed = true;
    }
  }

  public class PostHogAnalytics : IPostHogAnalytics, IDisposable
  {
    private readonly Dictionary<string, object> _superProperties;
    private readonly Dictionary<string, object> _superPropertiesOnce;
    private readonly Dictionary<string, object> _personSysSetProperties;
    private readonly Dictionary<string, object> _personSysSetPropertiesOnce;
    private readonly BatchingCaptureAdapter _batcher;

    /// <summary>
    /// Creates a new instance of PostHogAnalytics
    /// </summary>
    /// <param name="publicApiKey">Your PostHog public API key</param>
    /// <param name="host">The PostHog host to send events to. Defaults to https://app.posthog.com</param>
    public static IPostHogAnalytics Create(string publicApiKey, string host = "https://app.posthog.com")
    {
      var config = new Client.Configuration()
      {
        BasePath = host
      };

      return new PostHogAnalytics(publicApiKey, new CaptureApi(config));
    }

    /// <summary>
    /// Bring your own implementation of ICaptureApi. Used mainly for testing.
    /// </summary>
    /// <param name="publicApiKey"></param>
    /// <param name="customCaptureApi"></param>
    /// <returns></returns>
    public static IPostHogAnalytics CreateCustom(string publicApiKey, ICaptureApi customCaptureApi)
    {
      return new PostHogAnalytics(publicApiKey, customCaptureApi);
    }

    private PostHogAnalytics(string publicApiKey, ICaptureApi captureApi)
    {
      _batcher = new BatchingCaptureAdapter(publicApiKey, captureApi);

      _superProperties = new Dictionary<string, object>() {
        { "$lib", "DotPostHog" },
        { "$lib_version", GetAssemblyVersion() },
        { "$geoip_disable", true } // Otherwise it will grab the server IP. This matches Node.js SDK behavior.
      };
      _superPropertiesOnce = new Dictionary<string, object>();
      _personSysSetProperties = new Dictionary<string, object>();
      _personSysSetPropertiesOnce = new Dictionary<string, object>();
    }

    public void Capture(string eventName, PostHogEventProperties properties = null)
    {
      var props = MergeSuperProperties(properties);
      var userProps = MergeUserProperties(null, null);

      props.Merge(userProps);

      var body = new PostHogEvent()
      {
        VarEvent = eventName,
        Properties = props
      };
      _batcher.Enqueue(body);
    }

    public void Identify(string distinctId, IDictionary<string, object> sysSet = null, IDictionary<string, object> sysSetOnce = null)
    {
      var props = MergeSuperProperties(null);
      var userProps = MergeUserProperties(sysSet, sysSetOnce);

      props.Merge(userProps);

      if (props.ContainsKey("distinct_id"))
      {
        props["distinct_id"] = distinctId;
      }

      var body = new PostHogEvent()
      {
        VarEvent = "$identify",
        DistinctId = distinctId,
        Properties = props
      };
      _batcher.Enqueue(body);
    }

    public void Alias(string distinctId, string aliasId)
    {
      var body = new PostHogEvent()
      {
        VarEvent = "$create_alias",
        DistinctId = distinctId,
        Properties = new PostHogEventProperties() {
          { "alias", aliasId }
        }
      };
      _batcher.Enqueue(body);
    }

    public void Flush()
    {
      _batcher.Flush();
    }

    private bool _disposed = false;

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    ~PostHogAnalytics()
    {
      Dispose(false);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (_disposed)
        return;

      if (disposing)
      {
        // This will close and flush the batcher
        _batcher.Dispose();
      }

      _disposed = true;
    }

    public void Register(IDictionary<string, object> properties)
    {
      _superProperties.Merge(properties);
    }

    public void RegisterOnce(IDictionary<string, object> properties)
    {
      _superPropertiesOnce.Merge(properties);
    }

    public void SetPersonProperties(IDictionary<string, object> sysSet, IDictionary<string, object> sysSetOnce = null)
    {
      _personSysSetProperties.Merge(sysSet);
      _personSysSetPropertiesOnce.Merge(sysSetOnce);
    }

    public void Unregister(string property)
    {
      if (_superProperties.ContainsKey(property))
      {
        _superProperties.Remove(property);
      }
      if (_superPropertiesOnce.ContainsKey(property))
      {
        _superPropertiesOnce.Remove(property);
      }
    }

    private PostHogEventProperties MergeSuperProperties(PostHogEventProperties properties)
    {
      var mergedProperties = new PostHogEventProperties();

      mergedProperties.Merge(_superProperties);

      // Once properties should always override any new super properties
      mergedProperties.Merge(_superPropertiesOnce);

      if (properties != null)
      {
        mergedProperties.Merge(properties);
      }

      return mergedProperties;
    }

    private PostHogEventProperties MergeUserProperties(IDictionary<string, object> sysSet = null, IDictionary<string, object> sysSetOnce = null)
    {
      var mergedProperties = new PostHogEventProperties() {
        { "$set", new Dictionary<string, object>() },
        { "$set_once", new Dictionary<string, object>() }
      };

      foreach (var item in _personSysSetProperties)
      {
        var mergedSysSet = (IDictionary<string, object>)mergedProperties["$set"];
        mergedSysSet[item.Key] = item.Value;
      }
      foreach (var item in _personSysSetPropertiesOnce)
      {
        var mergedSysSetOnce = (IDictionary<string, object>)mergedProperties["$set_once"];
        mergedSysSetOnce[item.Key] = item.Value;
      }

      if (sysSet != null)
      {
        foreach (var item in sysSet)
        {
          var mergedSysSet = (IDictionary<string, object>)mergedProperties["$set"];
          mergedSysSet[item.Key] = item.Value;
        }
      }

      if (sysSetOnce != null)
      {
        foreach (var item in sysSetOnce)
        {
          var mergedSysSetOnce = (IDictionary<string, object>)mergedProperties["$set_once"];
          mergedSysSetOnce[item.Key] = item.Value;
        }
      }

      return mergedProperties;
    }

    private string GetAssemblyVersion()
    {
      var assembly = typeof(PostHogAnalytics).Assembly;
      var assemblyName = assembly.GetName();
      return assemblyName.Version.ToString();
    }
  }
}

