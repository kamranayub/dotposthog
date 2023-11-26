# DotPostHog.Api.WarehouseViewLinkApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WarehouseViewLinkCreate**](WarehouseViewLinkApi.md#warehouseviewlinkcreate) | **POST** /api/projects/{project_id}/warehouse_view_link/ |  |
| [**WarehouseViewLinkDestroy**](WarehouseViewLinkApi.md#warehouseviewlinkdestroy) | **DELETE** /api/projects/{project_id}/warehouse_view_link/{id}/ |  |
| [**WarehouseViewLinkList**](WarehouseViewLinkApi.md#warehouseviewlinklist) | **GET** /api/projects/{project_id}/warehouse_view_link/ |  |
| [**WarehouseViewLinkPartialUpdate**](WarehouseViewLinkApi.md#warehouseviewlinkpartialupdate) | **PATCH** /api/projects/{project_id}/warehouse_view_link/{id}/ |  |
| [**WarehouseViewLinkRetrieve**](WarehouseViewLinkApi.md#warehouseviewlinkretrieve) | **GET** /api/projects/{project_id}/warehouse_view_link/{id}/ |  |
| [**WarehouseViewLinkUpdate**](WarehouseViewLinkApi.md#warehouseviewlinkupdate) | **PUT** /api/projects/{project_id}/warehouse_view_link/{id}/ |  |

<a id="warehouseviewlinkcreate"></a>
# **WarehouseViewLinkCreate**
> ViewLink WarehouseViewLinkCreate (string projectId, ViewLink viewLink)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var viewLink = new ViewLink(); // ViewLink | 

            try
            {
                ViewLink result = apiInstance.WarehouseViewLinkCreate(projectId, viewLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ViewLink> response = apiInstance.WarehouseViewLinkCreateWithHttpInfo(projectId, viewLink);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **viewLink** | [**ViewLink**](ViewLink.md) |  |  |

### Return type

[**ViewLink**](ViewLink.md)

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

<a id="warehouseviewlinkdestroy"></a>
# **WarehouseViewLinkDestroy**
> void WarehouseViewLinkDestroy (Guid id, string projectId)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse view link.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.WarehouseViewLinkDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WarehouseViewLinkDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse view link. |  |
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

<a id="warehouseviewlinklist"></a>
# **WarehouseViewLinkList**
> PaginatedViewLinkList WarehouseViewLinkList (string projectId, int? limit = null, int? offset = null, string search = null)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var search = "search_example";  // string | A search term. (optional) 

            try
            {
                PaginatedViewLinkList result = apiInstance.WarehouseViewLinkList(projectId, limit, offset, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedViewLinkList> response = apiInstance.WarehouseViewLinkListWithHttpInfo(projectId, limit, offset, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkListWithHttpInfo: " + e.Message);
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
| **search** | **string** | A search term. | [optional]  |

### Return type

[**PaginatedViewLinkList**](PaginatedViewLinkList.md)

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

<a id="warehouseviewlinkpartialupdate"></a>
# **WarehouseViewLinkPartialUpdate**
> ViewLink WarehouseViewLinkPartialUpdate (Guid id, string projectId, PatchedViewLink patchedViewLink = null)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse view link.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedViewLink = new PatchedViewLink(); // PatchedViewLink |  (optional) 

            try
            {
                ViewLink result = apiInstance.WarehouseViewLinkPartialUpdate(id, projectId, patchedViewLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ViewLink> response = apiInstance.WarehouseViewLinkPartialUpdateWithHttpInfo(id, projectId, patchedViewLink);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse view link. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedViewLink** | [**PatchedViewLink**](PatchedViewLink.md) |  | [optional]  |

### Return type

[**ViewLink**](ViewLink.md)

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

<a id="warehouseviewlinkretrieve"></a>
# **WarehouseViewLinkRetrieve**
> ViewLink WarehouseViewLinkRetrieve (Guid id, string projectId)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse view link.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                ViewLink result = apiInstance.WarehouseViewLinkRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ViewLink> response = apiInstance.WarehouseViewLinkRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse view link. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**ViewLink**](ViewLink.md)

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

<a id="warehouseviewlinkupdate"></a>
# **WarehouseViewLinkUpdate**
> ViewLink WarehouseViewLinkUpdate (Guid id, string projectId, ViewLink viewLink)



Create, Read, Update and Delete View Columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseViewLinkUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseViewLinkApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse view link.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var viewLink = new ViewLink(); // ViewLink | 

            try
            {
                ViewLink result = apiInstance.WarehouseViewLinkUpdate(id, projectId, viewLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseViewLinkUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ViewLink> response = apiInstance.WarehouseViewLinkUpdateWithHttpInfo(id, projectId, viewLink);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseViewLinkApi.WarehouseViewLinkUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse view link. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **viewLink** | [**ViewLink**](ViewLink.md) |  |  |

### Return type

[**ViewLink**](ViewLink.md)

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

