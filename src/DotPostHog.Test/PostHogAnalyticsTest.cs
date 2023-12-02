using System.Collections;
using System.Collections.Generic;
using DotPostHog.Api;
using DotPostHog.Model;
using Moq;
using Xunit;

namespace DotPostHog.Test
{
  public class PostHogAnalyticsTest
  {

    private IPostHogAnalytics _instance;
    private Mock<ICaptureApi> _mockCaptureApi;
    private IPostHogRequestContext _requestContext;

    public PostHogAnalyticsTest()
    {
      _mockCaptureApi = new Mock<ICaptureApi>();
      _requestContext = new TestRequestContext()
      {
        Ip = "127.0.0.1"
      };
      _instance = PostHogAnalytics.CreateCustom("test", _requestContext, _mockCaptureApi.Object);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEvent()
    {
      _instance.Capture("test");
      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => x.VarEvent == "test"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithProperties()
    {
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"prop1", "test"}
      });

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["prop1"] == "test"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithSuperProperties()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Capture("test");

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super"] == "test"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToCaptureEventWithSuperPropertiesOnce()
    {
      _instance.RegisterOnce(new PostHogEventProperties()
      {
        {"super_once", "test"}
      });
      _instance.Capture("test");

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super_once"] == "test"), 0), Times.Once);
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

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super"] == "good"), 0), Times.Once);
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

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super"] == "good"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUser()
    {
      _instance.Identify("user1");

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => x.VarEvent == "$identify" && x.DistinctId == "user1"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSetProps()
    {
      _instance.Identify("user1", new PostHogEventProperties()
      {
        {"email", "test@user.com"}
      });

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)((Dictionary<string, object>)x.Properties["$set"])["email"] == "test@user.com"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSetOnceProps()
    {
      _instance.Identify("user1", null, new PostHogEventProperties()
      {
        {"initial_url", "/landing-page"}
      });

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)((Dictionary<string, object>)x.Properties["$set_once"])["initial_url"] == "/landing-page"), 0), Times.Once);
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

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)((Dictionary<string, object>)x.Properties["$set"])["email"] == "test@user.com" && (string)((Dictionary<string, object>)x.Properties["$set_once"])["initial_url"] == "/landing-page"), 0), Times.Once);
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

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)((Dictionary<string, object>)x.Properties["$set"])["email"] == "test@user.com" && (string)((Dictionary<string, object>)x.Properties["$set_once"])["initial_url"] == "/landing-page"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSuperProps()
    {
      _instance.Register(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Identify("user1");

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super"] == "test"), 0), Times.Once);
    }

    [Fact]
    public void ShouldBeAbleToIdentifyUserWithSuperOnceProps()
    {
      _instance.RegisterOnce(new PostHogEventProperties()
      {
        {"super", "test"}
      });
      _instance.Identify("user1");

      _mockCaptureApi.Verify(x => x.CaptureSend(_requestContext.Ip, null,
        It.Is<PostHogEvent>(x => (string)x.Properties["super"] == "test"), 0), Times.Once);
    }
  }

  public class TestRequestContext : IPostHogRequestContext
  {
    public string Ip { get; set; }
  }
}