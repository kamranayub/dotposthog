# DotPostHog.Api.SessionRecordingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SessionRecordingsDestroy**](SessionRecordingsApi.md#sessionrecordingsdestroy) | **DELETE** /api/projects/{project_id}/session_recordings/{id}/ |  |
| [**SessionRecordingsList**](SessionRecordingsApi.md#sessionrecordingslist) | **GET** /api/projects/{project_id}/session_recordings/ |  |
| [**SessionRecordingsMatchingEventsRetrieve**](SessionRecordingsApi.md#sessionrecordingsmatchingeventsretrieve) | **GET** /api/projects/{project_id}/session_recordings/matching_events/ |  |
| [**SessionRecordingsPersistCreate**](SessionRecordingsApi.md#sessionrecordingspersistcreate) | **POST** /api/projects/{project_id}/session_recordings/{id}/persist/ |  |
| [**SessionRecordingsPropertiesRetrieve**](SessionRecordingsApi.md#sessionrecordingspropertiesretrieve) | **GET** /api/projects/{project_id}/session_recordings/properties/ |  |
| [**SessionRecordingsRetrieve**](SessionRecordingsApi.md#sessionrecordingsretrieve) | **GET** /api/projects/{project_id}/session_recordings/{id}/ |  |
| [**SessionRecordingsSnapshotsRetrieve**](SessionRecordingsApi.md#sessionrecordingssnapshotsretrieve) | **GET** /api/projects/{project_id}/session_recordings/{id}/snapshots/ |  |

<a id="sessionrecordingsdestroy"></a>
# **SessionRecordingsDestroy**
> void SessionRecordingsDestroy (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this session recording.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.SessionRecordingsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SessionRecordingsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this session recording. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingslist"></a>
# **SessionRecordingsList**
> PaginatedSessionRecordingList SessionRecordingsList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedSessionRecordingList result = apiInstance.SessionRecordingsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedSessionRecordingList> response = apiInstance.SessionRecordingsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PaginatedSessionRecordingList**](PaginatedSessionRecordingList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingsmatchingeventsretrieve"></a>
# **SessionRecordingsMatchingEventsRetrieve**
> SessionRecording SessionRecordingsMatchingEventsRetrieve (string projectId)



         Gets a list of event ids that match the given session recording filter.         The filter must include a single session ID.         And must include at least one event or action filter.         This API is intended for internal use and might have unannounced breaking changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsMatchingEventsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                SessionRecording result = apiInstance.SessionRecordingsMatchingEventsRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsMatchingEventsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsMatchingEventsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SessionRecording> response = apiInstance.SessionRecordingsMatchingEventsRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsMatchingEventsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**SessionRecording**](SessionRecording.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingspersistcreate"></a>
# **SessionRecordingsPersistCreate**
> SessionRecording SessionRecordingsPersistCreate (Guid id, string projectId, SessionRecording sessionRecording = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsPersistCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this session recording.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var sessionRecording = new SessionRecording(); // SessionRecording |  (optional) 

            try
            {
                SessionRecording result = apiInstance.SessionRecordingsPersistCreate(id, projectId, sessionRecording);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsPersistCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsPersistCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SessionRecording> response = apiInstance.SessionRecordingsPersistCreateWithHttpInfo(id, projectId, sessionRecording);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsPersistCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this session recording. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **sessionRecording** | [**SessionRecording**](SessionRecording.md) |  | [optional]  |

### Return type

[**SessionRecording**](SessionRecording.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingspropertiesretrieve"></a>
# **SessionRecordingsPropertiesRetrieve**
> SessionRecording SessionRecordingsPropertiesRetrieve (string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsPropertiesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                SessionRecording result = apiInstance.SessionRecordingsPropertiesRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsPropertiesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsPropertiesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SessionRecording> response = apiInstance.SessionRecordingsPropertiesRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsPropertiesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**SessionRecording**](SessionRecording.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingsretrieve"></a>
# **SessionRecordingsRetrieve**
> SessionRecording SessionRecordingsRetrieve (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this session recording.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                SessionRecording result = apiInstance.SessionRecordingsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SessionRecording> response = apiInstance.SessionRecordingsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this session recording. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**SessionRecording**](SessionRecording.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingssnapshotsretrieve"></a>
# **SessionRecordingsSnapshotsRetrieve**
> SessionRecording SessionRecordingsSnapshotsRetrieve (Guid id, string projectId)



Snapshots can be loaded from multiple places: 1. From S3 if the session is older than our ingestion limit. This will be multiple files that can be streamed to the client 2. or from Redis if the session is newer than our ingestion limit.  Clients need to call this API twice. First without a source parameter to get a list of sources supported by the given session. And then once for each source in the returned list to get the actual snapshots.  NB version 1 of this API has been deprecated and ClickHouse stored snapshots are no longer supported.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingsSnapshotsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this session recording.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                SessionRecording result = apiInstance.SessionRecordingsSnapshotsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsSnapshotsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingsSnapshotsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SessionRecording> response = apiInstance.SessionRecordingsSnapshotsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingsApi.SessionRecordingsSnapshotsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this session recording. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**SessionRecording**](SessionRecording.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

