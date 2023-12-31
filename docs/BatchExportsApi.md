# DotPostHog.Api.BatchExportsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchExportsBackfillCreate**](BatchExportsApi.md#batchexportsbackfillcreate) | **POST** /api/projects/{project_id}/batch_exports/{id}/backfill/ |  |
| [**BatchExportsCreate**](BatchExportsApi.md#batchexportscreate) | **POST** /api/projects/{project_id}/batch_exports/ |  |
| [**BatchExportsDestroy**](BatchExportsApi.md#batchexportsdestroy) | **DELETE** /api/projects/{project_id}/batch_exports/{id}/ |  |
| [**BatchExportsList**](BatchExportsApi.md#batchexportslist) | **GET** /api/projects/{project_id}/batch_exports/ |  |
| [**BatchExportsLogsList**](BatchExportsApi.md#batchexportslogslist) | **GET** /api/projects/{project_id}/batch_exports/{parent_lookup_batch_export_id}/logs/ |  |
| [**BatchExportsPartialUpdate**](BatchExportsApi.md#batchexportspartialupdate) | **PATCH** /api/projects/{project_id}/batch_exports/{id}/ |  |
| [**BatchExportsPauseCreate**](BatchExportsApi.md#batchexportspausecreate) | **POST** /api/projects/{project_id}/batch_exports/{id}/pause/ |  |
| [**BatchExportsRetrieve**](BatchExportsApi.md#batchexportsretrieve) | **GET** /api/projects/{project_id}/batch_exports/{id}/ |  |
| [**BatchExportsRunsList**](BatchExportsApi.md#batchexportsrunslist) | **GET** /api/projects/{project_id}/batch_exports/{parent_lookup_batch_export_id}/runs/ |  |
| [**BatchExportsRunsLogsList**](BatchExportsApi.md#batchexportsrunslogslist) | **GET** /api/projects/{project_id}/batch_exports/{parent_lookup_batch_export_id}/runs/{parent_lookup_run_id}/logs/ |  |
| [**BatchExportsRunsRetrieve**](BatchExportsApi.md#batchexportsrunsretrieve) | **GET** /api/projects/{project_id}/batch_exports/{parent_lookup_batch_export_id}/runs/{id}/ |  |
| [**BatchExportsUnpauseCreate**](BatchExportsApi.md#batchexportsunpausecreate) | **POST** /api/projects/{project_id}/batch_exports/{id}/unpause/ |  |
| [**BatchExportsUpdate**](BatchExportsApi.md#batchexportsupdate) | **PUT** /api/projects/{project_id}/batch_exports/{id}/ |  |

<a id="batchexportsbackfillcreate"></a>
# **BatchExportsBackfillCreate**
> PostHogBatchExport BatchExportsBackfillCreate (Guid id, string projectId, PostHogBatchExport postHogBatchExport)



Trigger a backfill for a BatchExport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsBackfillCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogBatchExport = new PostHogBatchExport(); // PostHogBatchExport | 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsBackfillCreate(id, projectId, postHogBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsBackfillCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsBackfillCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsBackfillCreateWithHttpInfo(id, projectId, postHogBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsBackfillCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogBatchExport** | [**PostHogBatchExport**](PostHogBatchExport.md) |  |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportscreate"></a>
# **BatchExportsCreate**
> PostHogBatchExport BatchExportsCreate (string projectId, PostHogBatchExport postHogBatchExport)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogBatchExport = new PostHogBatchExport(); // PostHogBatchExport | 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsCreate(projectId, postHogBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsCreateWithHttpInfo(projectId, postHogBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogBatchExport** | [**PostHogBatchExport**](PostHogBatchExport.md) |  |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportsdestroy"></a>
# **BatchExportsDestroy**
> void BatchExportsDestroy (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.BatchExportsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BatchExportsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
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

<a id="batchexportslist"></a>
# **BatchExportsList**
> PostHogPaginatedBatchExportList BatchExportsList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedBatchExportList result = apiInstance.BatchExportsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedBatchExportList> response = apiInstance.BatchExportsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedBatchExportList**](PostHogPaginatedBatchExportList.md)

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

<a id="batchexportslogslist"></a>
# **BatchExportsLogsList**
> PostHogPaginatedBatchExportLogEntryList BatchExportsLogsList (string parentLookupBatchExportId, string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsLogsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var parentLookupBatchExportId = "parentLookupBatchExportId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedBatchExportLogEntryList result = apiInstance.BatchExportsLogsList(parentLookupBatchExportId, projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsLogsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsLogsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedBatchExportLogEntryList> response = apiInstance.BatchExportsLogsListWithHttpInfo(parentLookupBatchExportId, projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsLogsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupBatchExportId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PostHogPaginatedBatchExportLogEntryList**](PostHogPaginatedBatchExportLogEntryList.md)

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

<a id="batchexportspartialupdate"></a>
# **BatchExportsPartialUpdate**
> PostHogBatchExport BatchExportsPartialUpdate (Guid id, string projectId, PostHogPatchedBatchExport postHogPatchedBatchExport = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPatchedBatchExport = new PostHogPatchedBatchExport(); // PostHogPatchedBatchExport |  (optional) 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsPartialUpdate(id, projectId, postHogPatchedBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsPartialUpdateWithHttpInfo(id, projectId, postHogPatchedBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPatchedBatchExport** | [**PostHogPatchedBatchExport**](PostHogPatchedBatchExport.md) |  | [optional]  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportspausecreate"></a>
# **BatchExportsPauseCreate**
> PostHogBatchExport BatchExportsPauseCreate (Guid id, string projectId, PostHogBatchExport postHogBatchExport)



Pause a BatchExport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsPauseCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogBatchExport = new PostHogBatchExport(); // PostHogBatchExport | 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsPauseCreate(id, projectId, postHogBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsPauseCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsPauseCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsPauseCreateWithHttpInfo(id, projectId, postHogBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsPauseCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogBatchExport** | [**PostHogBatchExport**](PostHogBatchExport.md) |  |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportsretrieve"></a>
# **BatchExportsRetrieve**
> PostHogBatchExport BatchExportsRetrieve (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportsrunslist"></a>
# **BatchExportsRunsList**
> PostHogPaginatedBatchExportRunList BatchExportsRunsList (string parentLookupBatchExportId, string projectId, string cursor = null)



Get all BatchExportRuns for a BatchExport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsRunsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var parentLookupBatchExportId = "parentLookupBatchExportId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var cursor = "cursor_example";  // string | The pagination cursor value. (optional) 

            try
            {
                PostHogPaginatedBatchExportRunList result = apiInstance.BatchExportsRunsList(parentLookupBatchExportId, projectId, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsRunsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedBatchExportRunList> response = apiInstance.BatchExportsRunsListWithHttpInfo(parentLookupBatchExportId, projectId, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupBatchExportId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **cursor** | **string** | The pagination cursor value. | [optional]  |

### Return type

[**PostHogPaginatedBatchExportRunList**](PostHogPaginatedBatchExportRunList.md)

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

<a id="batchexportsrunslogslist"></a>
# **BatchExportsRunsLogsList**
> PostHogPaginatedBatchExportLogEntryList BatchExportsRunsLogsList (string parentLookupBatchExportId, string parentLookupRunId, string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsRunsLogsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var parentLookupBatchExportId = "parentLookupBatchExportId_example";  // string | 
            var parentLookupRunId = "parentLookupRunId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedBatchExportLogEntryList result = apiInstance.BatchExportsRunsLogsList(parentLookupBatchExportId, parentLookupRunId, projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsLogsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsRunsLogsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedBatchExportLogEntryList> response = apiInstance.BatchExportsRunsLogsListWithHttpInfo(parentLookupBatchExportId, parentLookupRunId, projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsLogsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupBatchExportId** | **string** |  |  |
| **parentLookupRunId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PostHogPaginatedBatchExportLogEntryList**](PostHogPaginatedBatchExportLogEntryList.md)

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

<a id="batchexportsrunsretrieve"></a>
# **BatchExportsRunsRetrieve**
> PostHogBatchExportRun BatchExportsRunsRetrieve (Guid id, string parentLookupBatchExportId, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsRunsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export run.
            var parentLookupBatchExportId = "parentLookupBatchExportId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                PostHogBatchExportRun result = apiInstance.BatchExportsRunsRetrieve(id, parentLookupBatchExportId, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsRunsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExportRun> response = apiInstance.BatchExportsRunsRetrieveWithHttpInfo(id, parentLookupBatchExportId, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsRunsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export run. |  |
| **parentLookupBatchExportId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**PostHogBatchExportRun**](PostHogBatchExportRun.md)

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

<a id="batchexportsunpausecreate"></a>
# **BatchExportsUnpauseCreate**
> PostHogBatchExport BatchExportsUnpauseCreate (Guid id, string projectId, PostHogBatchExport postHogBatchExport)



Unpause a BatchExport.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsUnpauseCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogBatchExport = new PostHogBatchExport(); // PostHogBatchExport | 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsUnpauseCreate(id, projectId, postHogBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsUnpauseCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsUnpauseCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsUnpauseCreateWithHttpInfo(id, projectId, postHogBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsUnpauseCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogBatchExport** | [**PostHogBatchExport**](PostHogBatchExport.md) |  |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

<a id="batchexportsupdate"></a>
# **BatchExportsUpdate**
> PostHogBatchExport BatchExportsUpdate (Guid id, string projectId, PostHogBatchExport postHogBatchExport)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class BatchExportsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BatchExportsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this batch export.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogBatchExport = new PostHogBatchExport(); // PostHogBatchExport | 

            try
            {
                PostHogBatchExport result = apiInstance.BatchExportsUpdate(id, projectId, postHogBatchExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchExportsApi.BatchExportsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchExportsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogBatchExport> response = apiInstance.BatchExportsUpdateWithHttpInfo(id, projectId, postHogBatchExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchExportsApi.BatchExportsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this batch export. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogBatchExport** | [**PostHogBatchExport**](PostHogBatchExport.md) |  |  |

### Return type

[**PostHogBatchExport**](PostHogBatchExport.md)

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

