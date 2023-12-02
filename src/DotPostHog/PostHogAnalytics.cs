using System.Collections;
using System.Collections.Generic;
using DotPostHog.Api;
using DotPostHog.Model;

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
    PostHogEventsCaptureResponse Identify(string distinctId, IDictionary<string, object> sysSet = null, IDictionary<string, object> sysSetOnce = null);

    /// <summary>
    /// Captures an event in PostHog
    /// </summary>
    /// <returns></returns>
    PostHogEventsCaptureResponse Capture(string eventName, PostHogEventProperties properties = null);

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

  public interface IPostHogRequestContext
  {
    string Ip { get; }
  }

  public class PostHogAnalytics : IPostHogAnalytics
  {
    private readonly Dictionary<string, object> _superProperties;
    private readonly Dictionary<string, object> _superPropertiesOnce;
    private readonly Dictionary<string, object> _personSysSetProperties;
    private readonly Dictionary<string, object> _personSysSetPropertiesOnce;
    private readonly string _publicApiKey;
    private readonly ICaptureApi _captureApi;
    private readonly IPostHogRequestContext _requestContext;

    /// <summary>
    /// Creates a new instance of PostHogAnalytics
    /// </summary>
    /// <param name="publicApiKey">Your PostHog public API key</param>
    /// <param name="requestContext">An implementation of IPostHogRequestContext that provides access to request properties</param> 
    /// <param name="host">The PostHog host to send events to. Defaults to https://app.posthog.com</param>
    public static IPostHogAnalytics Create(string publicApiKey, IPostHogRequestContext requestContext, string host = "https://app.posthog.com")
    {
      var config = new Client.Configuration()
      {
        BasePath = host
      };

      return new PostHogAnalytics(publicApiKey, new CaptureApi(config), requestContext);
    }

    /// <summary>
    /// Bring your own implementation of ICaptureApi. Used mainly for testing.
    /// </summary>
    /// <param name="publicApiKey"></param>
    /// <param name="requestContext"></param>
    /// <param name="customCaptureApi"></param>
    /// <returns></returns>
    public static IPostHogAnalytics CreateCustom(string publicApiKey, IPostHogRequestContext requestContext, ICaptureApi customCaptureApi)
    {
      return new PostHogAnalytics(publicApiKey, customCaptureApi, requestContext);
    }

    private PostHogAnalytics(string publicApiKey, ICaptureApi captureApi, IPostHogRequestContext requestContext)
    {
      _publicApiKey = publicApiKey;
      _requestContext = requestContext;
      _captureApi = captureApi;

      _superProperties = new Dictionary<string, object>();
      _superPropertiesOnce = new Dictionary<string, object>();
      _personSysSetProperties = new Dictionary<string, object>();
      _personSysSetPropertiesOnce = new Dictionary<string, object>();
    }

    public PostHogEventsCaptureResponse Capture(string eventName, PostHogEventProperties properties = null)
    {
      var ip = _requestContext.Ip;
      var props = MergeSuperProperties(properties);
      var userProps = MergeUserProperties(null, null);

      props.Merge(userProps);

      var body = new PostHogEvent()
      {
        VarEvent = eventName,
        ApiKey = _publicApiKey,
        Properties = props
      };
      return _captureApi.CaptureSend(ip, null, body);
    }

    public PostHogEventsCaptureResponse Identify(string distinctId, IDictionary<string, object> sysSet = null, IDictionary<string, object> sysSetOnce = null)
    {
      var ip = _requestContext.Ip;
      var props = MergeSuperProperties(null);
      var userProps = MergeUserProperties(sysSet, sysSetOnce);

      props.Merge(userProps);

      var body = new PostHogEvent()
      {
        VarEvent = "$identify",
        ApiKey = _publicApiKey,
        DistinctId = distinctId,
        Properties = props
      };
      return _captureApi.CaptureSend(ip, null, body);
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
  }
}

