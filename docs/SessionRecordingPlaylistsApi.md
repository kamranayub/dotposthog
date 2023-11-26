# DotPostHog.Api.SessionRecordingPlaylistsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SessionRecordingPlaylistsCreate**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistscreate) | **POST** /api/projects/{project_id}/session_recording_playlists/ |  |
| [**SessionRecordingPlaylistsDestroy**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsdestroy) | **DELETE** /api/projects/{project_id}/session_recording_playlists/{short_id}/ |  |
| [**SessionRecordingPlaylistsList**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistslist) | **GET** /api/projects/{project_id}/session_recording_playlists/ |  |
| [**SessionRecordingPlaylistsPartialUpdate**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistspartialupdate) | **PATCH** /api/projects/{project_id}/session_recording_playlists/{short_id}/ |  |
| [**SessionRecordingPlaylistsRecordingsCreate**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsrecordingscreate) | **POST** /api/projects/{project_id}/session_recording_playlists/{short_id}/recordings/{session_recording_id}/ |  |
| [**SessionRecordingPlaylistsRecordingsDestroy**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsrecordingsdestroy) | **DELETE** /api/projects/{project_id}/session_recording_playlists/{short_id}/recordings/{session_recording_id}/ |  |
| [**SessionRecordingPlaylistsRecordingsRetrieve**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsrecordingsretrieve) | **GET** /api/projects/{project_id}/session_recording_playlists/{short_id}/recordings/ |  |
| [**SessionRecordingPlaylistsRetrieve**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsretrieve) | **GET** /api/projects/{project_id}/session_recording_playlists/{short_id}/ |  |
| [**SessionRecordingPlaylistsUpdate**](SessionRecordingPlaylistsApi.md#sessionrecordingplaylistsupdate) | **PUT** /api/projects/{project_id}/session_recording_playlists/{short_id}/ |  |

<a id="sessionrecordingplaylistscreate"></a>
# **SessionRecordingPlaylistsCreate**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsCreate (string projectId, PostHogSessionRecordingPlaylist postHogSessionRecordingPlaylist = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogSessionRecordingPlaylist = new PostHogSessionRecordingPlaylist(); // PostHogSessionRecordingPlaylist |  (optional) 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsCreate(projectId, postHogSessionRecordingPlaylist);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsCreateWithHttpInfo(projectId, postHogSessionRecordingPlaylist);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogSessionRecordingPlaylist** | [**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md) |  | [optional]  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingplaylistsdestroy"></a>
# **SessionRecordingPlaylistsDestroy**
> void SessionRecordingPlaylistsDestroy (string projectId, string shortId)



Hard delete of this model is not allowed. Use a patch API call to set \"deleted\" to true

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var shortId = "shortId_example";  // string | 

            try
            {
                apiInstance.SessionRecordingPlaylistsDestroy(projectId, shortId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SessionRecordingPlaylistsDestroyWithHttpInfo(projectId, shortId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **shortId** | **string** |  |  |

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
| **405** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionrecordingplaylistslist"></a>
# **SessionRecordingPlaylistsList**
> PostHogPaginatedSessionRecordingPlaylistList SessionRecordingPlaylistsList (string projectId, int? createdBy = null, int? limit = null, int? offset = null, string shortId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var createdBy = 56;  // int? |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var shortId = "shortId_example";  // string |  (optional) 

            try
            {
                PostHogPaginatedSessionRecordingPlaylistList result = apiInstance.SessionRecordingPlaylistsList(projectId, createdBy, limit, offset, shortId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedSessionRecordingPlaylistList> response = apiInstance.SessionRecordingPlaylistsListWithHttpInfo(projectId, createdBy, limit, offset, shortId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **createdBy** | **int?** |  | [optional]  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |
| **shortId** | **string** |  | [optional]  |

### Return type

[**PostHogPaginatedSessionRecordingPlaylistList**](PostHogPaginatedSessionRecordingPlaylistList.md)

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

<a id="sessionrecordingplaylistspartialupdate"></a>
# **SessionRecordingPlaylistsPartialUpdate**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsPartialUpdate (string projectId, string shortId, PostHogPatchedSessionRecordingPlaylist postHogPatchedSessionRecordingPlaylist = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var shortId = "shortId_example";  // string | 
            var postHogPatchedSessionRecordingPlaylist = new PostHogPatchedSessionRecordingPlaylist(); // PostHogPatchedSessionRecordingPlaylist |  (optional) 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsPartialUpdate(projectId, shortId, postHogPatchedSessionRecordingPlaylist);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsPartialUpdateWithHttpInfo(projectId, shortId, postHogPatchedSessionRecordingPlaylist);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **shortId** | **string** |  |  |
| **postHogPatchedSessionRecordingPlaylist** | [**PostHogPatchedSessionRecordingPlaylist**](PostHogPatchedSessionRecordingPlaylist.md) |  | [optional]  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

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

<a id="sessionrecordingplaylistsrecordingscreate"></a>
# **SessionRecordingPlaylistsRecordingsCreate**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsRecordingsCreate (string projectId, string sessionRecordingId, string shortId, PostHogSessionRecordingPlaylist postHogSessionRecordingPlaylist = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsRecordingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var sessionRecordingId = "sessionRecordingId_example";  // string | 
            var shortId = "shortId_example";  // string | 
            var postHogSessionRecordingPlaylist = new PostHogSessionRecordingPlaylist(); // PostHogSessionRecordingPlaylist |  (optional) 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsRecordingsCreate(projectId, sessionRecordingId, shortId, postHogSessionRecordingPlaylist);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsRecordingsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsRecordingsCreateWithHttpInfo(projectId, sessionRecordingId, shortId, postHogSessionRecordingPlaylist);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **sessionRecordingId** | **string** |  |  |
| **shortId** | **string** |  |  |
| **postHogSessionRecordingPlaylist** | [**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md) |  | [optional]  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

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

<a id="sessionrecordingplaylistsrecordingsdestroy"></a>
# **SessionRecordingPlaylistsRecordingsDestroy**
> void SessionRecordingPlaylistsRecordingsDestroy (string projectId, string sessionRecordingId, string shortId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsRecordingsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var sessionRecordingId = "sessionRecordingId_example";  // string | 
            var shortId = "shortId_example";  // string | 

            try
            {
                apiInstance.SessionRecordingPlaylistsRecordingsDestroy(projectId, sessionRecordingId, shortId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsRecordingsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SessionRecordingPlaylistsRecordingsDestroyWithHttpInfo(projectId, sessionRecordingId, shortId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **sessionRecordingId** | **string** |  |  |
| **shortId** | **string** |  |  |

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

<a id="sessionrecordingplaylistsrecordingsretrieve"></a>
# **SessionRecordingPlaylistsRecordingsRetrieve**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsRecordingsRetrieve (string projectId, string shortId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsRecordingsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var shortId = "shortId_example";  // string | 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsRecordingsRetrieve(projectId, shortId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsRecordingsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsRecordingsRetrieveWithHttpInfo(projectId, shortId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRecordingsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **shortId** | **string** |  |  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

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

<a id="sessionrecordingplaylistsretrieve"></a>
# **SessionRecordingPlaylistsRetrieve**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsRetrieve (string projectId, string shortId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var shortId = "shortId_example";  // string | 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsRetrieve(projectId, shortId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsRetrieveWithHttpInfo(projectId, shortId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **shortId** | **string** |  |  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

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

<a id="sessionrecordingplaylistsupdate"></a>
# **SessionRecordingPlaylistsUpdate**
> PostHogSessionRecordingPlaylist SessionRecordingPlaylistsUpdate (string projectId, string shortId, PostHogSessionRecordingPlaylist postHogSessionRecordingPlaylist = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class SessionRecordingPlaylistsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SessionRecordingPlaylistsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var shortId = "shortId_example";  // string | 
            var postHogSessionRecordingPlaylist = new PostHogSessionRecordingPlaylist(); // PostHogSessionRecordingPlaylist |  (optional) 

            try
            {
                PostHogSessionRecordingPlaylist result = apiInstance.SessionRecordingPlaylistsUpdate(projectId, shortId, postHogSessionRecordingPlaylist);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionRecordingPlaylistsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogSessionRecordingPlaylist> response = apiInstance.SessionRecordingPlaylistsUpdateWithHttpInfo(projectId, shortId, postHogSessionRecordingPlaylist);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionRecordingPlaylistsApi.SessionRecordingPlaylistsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **shortId** | **string** |  |  |
| **postHogSessionRecordingPlaylist** | [**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md) |  | [optional]  |

### Return type

[**PostHogSessionRecordingPlaylist**](PostHogSessionRecordingPlaylist.md)

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

