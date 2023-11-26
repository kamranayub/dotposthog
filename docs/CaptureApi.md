# DotPostHog.Api.CaptureApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CaptureSend**](CaptureApi.md#capturesend) | **POST** /capture/ | Sending an event |
| [**CaptureSendBatch**](CaptureApi.md#capturesendbatch) | **POST** /batch/ | Sending multiple events |

<a id="capturesend"></a>
# **CaptureSend**
> PostHogEventsCaptureResponse CaptureSend (string ip = null, string compression = null, PostHogEvent body = null)

Sending an event

> Note: Timestamp is optional. If not set, it'll automatically be set to the current time.  Capture an event. Events are the core of PostHog, and are what you use to track user behavior, and then analyze and visualize in PostHog. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CaptureSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CaptureApi(config);
            var ip = "ip_example";  // string |  (optional) 
            var compression = "gzip-js";  // string | The compression method used to compress the request body.  (optional) 
            var body = {"api_key":"<ph_project_api_key>","event":"[event name]","properties":{"distinct_id":"[your users' distinct id]","key1":"value1","key2":"value2"},"timestamp":"[optional timestamp in ISO 8601 format]"};  // PostHogEvent | Provides a method to capture events. Events are the core of PostHog, and are what you use to track user behavior, and then analyze and visualize in PostHog.  (optional) 

            try
            {
                // Sending an event
                PostHogEventsCaptureResponse result = apiInstance.CaptureSend(ip, compression, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureApi.CaptureSend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureSendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sending an event
    ApiResponse<PostHogEventsCaptureResponse> response = apiInstance.CaptureSendWithHttpInfo(ip, compression, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureApi.CaptureSendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ip** | **string** |  | [optional]  |
| **compression** | **string** | The compression method used to compress the request body.  | [optional]  |
| **body** | **PostHogEvent** | Provides a method to capture events. Events are the core of PostHog, and are what you use to track user behavior, and then analyze and visualize in PostHog.  | [optional]  |

### Return type

[**PostHogEventsCaptureResponse**](PostHogEventsCaptureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | On successful capture of an event or events, we notify you with a 200 response. A 200 response guarantees that the event was persisted by PostHog, but does not guarantee that it will be processed successfully.  |  -  |
| **401** | If you send an invalid API key, we will return a 401 response.  |  -  |
| **400** | If you send an invalid request, we will return a 400 response. This can happen if you send an invalid JSON payload among other things.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="capturesendbatch"></a>
# **CaptureSendBatch**
> PostHogEventsCaptureResponse CaptureSendBatch (string ip = null, string compression = null, PostHogEventsCaptureRequest postHogEventsCaptureRequest = null)

Sending multiple events

You can send multiple events in one go with the Batch API.  There is no limit on the number of events you can send in a batch, but the entire request body must be less than 20MB by default (see API overview).  > Note: Timestamp is optional. If not set, it'll automatically be set to the current time. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CaptureSendBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CaptureApi(config);
            var ip = "ip_example";  // string |  (optional) 
            var compression = "gzip-js";  // string | The compression method used to compress the request body.  (optional) 
            var postHogEventsCaptureRequest = new PostHogEventsCaptureRequest(); // PostHogEventsCaptureRequest | Provides a method to capture events. Events are the core of PostHog, and are what you use to track user behavior, and then analyze and visualize in PostHog.  (optional) 

            try
            {
                // Sending multiple events
                PostHogEventsCaptureResponse result = apiInstance.CaptureSendBatch(ip, compression, postHogEventsCaptureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptureApi.CaptureSendBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureSendBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sending multiple events
    ApiResponse<PostHogEventsCaptureResponse> response = apiInstance.CaptureSendBatchWithHttpInfo(ip, compression, postHogEventsCaptureRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CaptureApi.CaptureSendBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ip** | **string** |  | [optional]  |
| **compression** | **string** | The compression method used to compress the request body.  | [optional]  |
| **postHogEventsCaptureRequest** | [**PostHogEventsCaptureRequest**](PostHogEventsCaptureRequest.md) | Provides a method to capture events. Events are the core of PostHog, and are what you use to track user behavior, and then analyze and visualize in PostHog.  | [optional]  |

### Return type

[**PostHogEventsCaptureResponse**](PostHogEventsCaptureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | On successful capture of an event or events, we notify you with a 200 response. A 200 response guarantees that the event was persisted by PostHog, but does not guarantee that it will be processed successfully.  |  -  |
| **401** | If you send an invalid API key, we will return a 401 response.  |  -  |
| **400** | If you send an invalid request, we will return a 400 response. This can happen if you send an invalid JSON payload among other things.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

