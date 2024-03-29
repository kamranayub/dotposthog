/*
 * PostHog API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using DotPostHog.Client;
using DotPostHog.Api;
using DotPostHog.Model;

namespace DotPostHog.Test.Api
{
  /// <summary>
  ///  Class for testing CaptureApi
  /// </summary>
  /// <remarks>
  /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
  /// Please update the test case below to test the API endpoint.
  /// </remarks>
  public class CaptureApiTests : IDisposable
  {
    private CaptureApi instance;
    private string apiKey;

    public CaptureApiTests()
    {
      instance = new CaptureApi("https://app.posthog.com");
      apiKey = Environment.GetEnvironmentVariable("POSTHOG_API_KEY");

    }

    public void Dispose()
    {
      // Cleanup when everything is done.
    }

    /// <summary>
    /// Test an instance of CaptureApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
      Assert.IsType<CaptureApi>(instance);
    }

    /// <summary>
    /// Test CaptureSend
    /// </summary>
    [Fact(Skip = "For local integration testing")]
    public void CaptureIdentifyTest()
    {
      if (apiKey == null)
      {
        throw new Exception("POSTHOG_API_KEY environment variable must be set");
      }

      string ip = null;
      string compression = null;
      PostHogEvent body = new PostHogEvent()
      {
        VarEvent = "$identify",
        ApiKey = apiKey,
        DistinctId = "DotPostHogTest",
        Properties = new PostHogEventProperties()
        {
          { "username", "dotposthog" }
        }
      };
      var response = instance.CaptureSend(ip, compression, body);
      Assert.IsType<PostHogEventsCaptureResponse>(response);
    }

    /// <summary>
    /// Test CaptureSendBatch
    /// </summary>
    [Fact]
    public void CaptureSendBatchTest()
    {
      // TODO uncomment below to test the method and replace null with proper value
      //string ip = null;
      //string compression = null;
      //PostHogEventsCaptureRequest postHogEventsCaptureRequest = null;
      //var response = instance.CaptureSendBatch(ip, compression, postHogEventsCaptureRequest);
      //Assert.IsType<PostHogEventsCaptureResponse>(response);
    }
  }
}
