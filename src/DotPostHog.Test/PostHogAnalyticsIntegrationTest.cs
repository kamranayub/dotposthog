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

namespace DotPostHog.Test
{
  public class PostHogAnalyticsIntegrationTest
  {

    private readonly IPostHogAnalytics _instance;
    private readonly Mock<CaptureApi> _mockCaptureApi;

    public PostHogAnalyticsIntegrationTest()
    {
      var apiKey = Environment.GetEnvironmentVariable("POSTHOG_API_KEY");

      if (apiKey == null)
      {
        throw new Exception("POSTHOG_API_KEY environment variable must be set");
      }

      var config = new Client.Configuration()
      {
        BasePath = "https://app.posthog.com"
      };
      _mockCaptureApi = new Mock<CaptureApi>(MockBehavior.Default, config);
      _instance = PostHogAnalytics.CreateCustom(apiKey, _mockCaptureApi.Object);
    }

    [Fact(Skip = "For local integration testing")]
    public void ShouldBeAbleToCaptureEvent()
    {
      _instance.Capture("test");

      DangerouslyWaitForInitialFlush();
    }

    [Fact(Skip = "For local integration testing")]
    public void ShouldBeAbleToCaptureABatchOfEvents()
    {
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"test_op", 1}
      });
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"test_op", 2}
      });
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"test_op", 3}
      });
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"test_op", 4}
      });
      _instance.Capture("test", new PostHogEventProperties()
      {
        {"test_op", 5}
      });

      DangerouslyWaitForInitialFlush();
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