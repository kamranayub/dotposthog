# DotPostHog.Api.EventsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EventsList**](EventsApi.md#eventslist) | **GET** /api/projects/{project_id}/events/ |  |
| [**EventsRetrieve**](EventsApi.md#eventsretrieve) | **GET** /api/projects/{project_id}/events/{id}/ |  |
| [**EventsValuesRetrieve**](EventsApi.md#eventsvaluesretrieve) | **GET** /api/projects/{project_id}/events/values/ |  |

<a id="eventslist"></a>
# **EventsList**
> PostHogPaginatedClickhouseEventList EventsList (string projectId, DateTime? after = null, DateTime? before = null, int? distinctId = null, string varEvent = null, string format = null, int? limit = null, int? offset = null, int? personId = null, List<PostHogProperty> properties = null, List<string> select = null, List<string> where = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EventsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return events with a timestamp after this time. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return events with a timestamp before this time. (optional) 
            var distinctId = 56;  // int? | Filter list by distinct id. (optional) 
            var varEvent = "varEvent_example";  // string | Filter list by event. For example `user sign up` or `$pageview`. (optional) 
            var format = "csv";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of results to return (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var personId = 56;  // int? | Filter list by person id. (optional) 
            var properties = new List<PostHogProperty>(); // List<PostHogProperty> | Filter events by event property, person property, cohort, groups and more. (optional) 
            var select = new List<string>(); // List<string> | (Experimental) JSON-serialized array of HogQL expressions to return (optional) 
            var where = new List<string>(); // List<string> | (Experimental) JSON-serialized array of HogQL expressions that must pass (optional) 

            try
            {
                PostHogPaginatedClickhouseEventList result = apiInstance.EventsList(projectId, after, before, distinctId, varEvent, format, limit, offset, personId, properties, select, where);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedClickhouseEventList> response = apiInstance.EventsListWithHttpInfo(projectId, after, before, distinctId, varEvent, format, limit, offset, personId, properties, select, where);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **after** | **DateTime?** | Only return events with a timestamp after this time. | [optional]  |
| **before** | **DateTime?** | Only return events with a timestamp before this time. | [optional]  |
| **distinctId** | **int?** | Filter list by distinct id. | [optional]  |
| **varEvent** | **string** | Filter list by event. For example &#x60;user sign up&#x60; or &#x60;$pageview&#x60;. | [optional]  |
| **format** | **string** |  | [optional]  |
| **limit** | **int?** | The maximum number of results to return | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |
| **personId** | **int?** | Filter list by person id. | [optional]  |
| **properties** | [**List&lt;PostHogProperty&gt;**](PostHogProperty.md) | Filter events by event property, person property, cohort, groups and more. | [optional]  |
| **select** | [**List&lt;string&gt;**](string.md) | (Experimental) JSON-serialized array of HogQL expressions to return | [optional]  |
| **where** | [**List&lt;string&gt;**](string.md) | (Experimental) JSON-serialized array of HogQL expressions that must pass | [optional]  |

### Return type

[**PostHogPaginatedClickhouseEventList**](PostHogPaginatedClickhouseEventList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="eventsretrieve"></a>
# **EventsRetrieve**
> PostHogClickhouseEvent EventsRetrieve (string id, string projectId, string format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EventsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventsApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                PostHogClickhouseEvent result = apiInstance.EventsRetrieve(id, projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogClickhouseEvent> response = apiInstance.EventsRetrieveWithHttpInfo(id, projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**PostHogClickhouseEvent**](PostHogClickhouseEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="eventsvaluesretrieve"></a>
# **EventsValuesRetrieve**
> PostHogClickhouseEvent EventsValuesRetrieve (string projectId, string format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EventsValuesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                PostHogClickhouseEvent result = apiInstance.EventsValuesRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.EventsValuesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EventsValuesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogClickhouseEvent> response = apiInstance.EventsValuesRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.EventsValuesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**PostHogClickhouseEvent**](PostHogClickhouseEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

