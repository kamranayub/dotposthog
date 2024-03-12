using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DotPostHog.Api;
using DotPostHog.Model;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace DotPostHog.Test
{
  public class PostHogAnalyticsTest
  {

    private readonly IPostHogAnalytics _instance;
    private Mock<ICaptureApi> _mockCaptureApi;

    public PostHogAnalyticsTest()
    {
      _mockCaptureApi = new Mock<ICaptureApi>();
      _instance = PostHogAnalytics.CreateCustom("test", _mockCaptureApi.Object);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEvent()
    {
      _instance.Capture("test");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          x.GetPostHogEventsCaptureRequestAnyOf().Batch.Count == 1), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureABatchOfEvents()
    {
      _instance.Capture("test1");
      _instance.Capture("test2");
      _instance.Capture("test3");
      _instance.Capture("test4");
      _instance.Capture("test5");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          x.GetPostHogEventsCaptureRequestAnyOf().Batch.Count == 5), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToFlushABatchOfEvents()
    {
      _instance.Capture("test1");
      _instance.Capture("test2");
      _instance.Capture("test3");
      _instance.Capture("test4");
      _instance.Capture("test5");
      _instance.Flush();

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          x.GetPostHogEventsCaptureRequestAnyOf().Batch.Count == 5), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldFlushBatchWhenDisposed()
    {
      _instance.Capture("test1");
      _instance.Capture("test2");
      _instance.Capture("test3");
      _instance.Capture("test4");
      _instance.Capture("test5");
      ((PostHogAnalytics)_instance).Dispose();

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          x.GetPostHogEventsCaptureRequestAnyOf().Batch.Count == 5), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithProperties()
    {
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"prop1", "test"}
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x => (string)
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["prop1"] == "test"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithSuperProperties()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Capture("test");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x => (string)
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super"] == "test"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithSuperPropertiesOnce()
    {
      _instance.RegisterOnce(new PostHogEventProperties()
      {
        {"super_once", "test"}
      });
      _instance.Capture("test");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x => (string)
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super_once"] == "test"), 0, default), Times.Once);
    }

    [Fact]
    public void PropertiesRegisteredOnceShouldOverrideOtherSuperProperties()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "bad"}
      });
      _instance.RegisterOnce(new PostHogEventProperties()
      {
        {"super", "good"}
      });
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "bad"}
      });
      _instance.Capture("test");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x => (string)
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super"] == "good"), 0, default), Times.Once);
    }

    [Fact]
    public void EventPropertiesOverrideSuperProperties()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "bad"}
      });
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"super", "good"}
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x => (string)
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super"] == "good"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithSetProps()
    {
      _instance.Capture("signup", new PostHogEventProperties()
      {
        SysSet = new Dictionary<string, object>() {
          {"email", "test@user.com"}
        }
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties.SysSet["email"] == "test@user.com"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUser()
    {
      _instance.Identify("user1");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].VarEvent == "$identify" && x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].DistinctId == "user1"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSetProps()
    {
      _instance.Identify("user1", new PostHogEventProperties()
      {
        {"email", "test@user.com"}
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set"])["email"] == "test@user.com"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSetOnceProps()
    {
      _instance.Identify("user1", null, new PostHogEventProperties()
      {
        {"initial_url", "/landing-page"}
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set_once"])["initial_url"] == "/landing-page"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithBothSetProps()
    {
      _instance.Identify("user1", new PostHogEventProperties()
      {
        {"email", "test@user.com"}
      },
      new PostHogEventProperties()
      {
        {"initial_url", "/landing-page"}
      });

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set"])["email"] == "test@user.com" &&
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set_once"])["initial_url"] == "/landing-page"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithPreviouslySetUserProperties()
    {
      _instance.SetPersonProperties(
        new PostHogEventProperties()
        {
          {"email", "test@user.com"}
        },
        new PostHogEventProperties()
        {
          {"initial_url", "/landing-page"}
        }
      );

      _instance.Identify("user1");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set"])["email"] == "test@user.com" &&
          (string)((Dictionary<string, object>)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["$set_once"])["initial_url"] == "/landing-page"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSuperProps()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Identify("user1");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super"] == "test"), 0, default), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSuperOnceProps()
    {
      _instance.RegisterOnce(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Identify("user1");

      DangerouslyWaitForInitialFlush();

      _mockCaptureApi.Verify(x => x.CaptureSendBatchAsync(null, null,
        It.Is<PostHogEventsCaptureRequest>(x =>
          (string)x.GetPostHogEventsCaptureRequestAnyOf().Batch[0].Properties["super"] == "test"), 0, default), Times.Once);
    }

    /// <summary>
    /// Due to the internal implementation of Periodic Batching, we need to wait for the initial flush to complete
    /// but there's no easy way to do this without exposing internal state. This is a hack to wait for the initial flush.
    /// </summary>
    private void DangerouslyWaitForInitialFlush()
    {
      Task.Delay(25).Wait();
    }
  }
}