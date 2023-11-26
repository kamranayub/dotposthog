# DotPostHog.Api.WarehouseSavedQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WarehouseSavedQueriesCreate**](WarehouseSavedQueriesApi.md#warehousesavedqueriescreate) | **POST** /api/projects/{project_id}/warehouse_saved_queries/ |  |
| [**WarehouseSavedQueriesDestroy**](WarehouseSavedQueriesApi.md#warehousesavedqueriesdestroy) | **DELETE** /api/projects/{project_id}/warehouse_saved_queries/{id}/ |  |
| [**WarehouseSavedQueriesList**](WarehouseSavedQueriesApi.md#warehousesavedquerieslist) | **GET** /api/projects/{project_id}/warehouse_saved_queries/ |  |
| [**WarehouseSavedQueriesPartialUpdate**](WarehouseSavedQueriesApi.md#warehousesavedqueriespartialupdate) | **PATCH** /api/projects/{project_id}/warehouse_saved_queries/{id}/ |  |
| [**WarehouseSavedQueriesRetrieve**](WarehouseSavedQueriesApi.md#warehousesavedqueriesretrieve) | **GET** /api/projects/{project_id}/warehouse_saved_queries/{id}/ |  |
| [**WarehouseSavedQueriesUpdate**](WarehouseSavedQueriesApi.md#warehousesavedqueriesupdate) | **PUT** /api/projects/{project_id}/warehouse_saved_queries/{id}/ |  |

<a id="warehousesavedqueriescreate"></a>
# **WarehouseSavedQueriesCreate**
> DataWarehouseSavedQuery WarehouseSavedQueriesCreate (string projectId, DataWarehouseSavedQuery dataWarehouseSavedQuery)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var dataWarehouseSavedQuery = new DataWarehouseSavedQuery(); // DataWarehouseSavedQuery | 

            try
            {
                DataWarehouseSavedQuery result = apiInstance.WarehouseSavedQueriesCreate(projectId, dataWarehouseSavedQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataWarehouseSavedQuery> response = apiInstance.WarehouseSavedQueriesCreateWithHttpInfo(projectId, dataWarehouseSavedQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **dataWarehouseSavedQuery** | [**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md) |  |  |

### Return type

[**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md)

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

<a id="warehousesavedqueriesdestroy"></a>
# **WarehouseSavedQueriesDestroy**
> void WarehouseSavedQueriesDestroy (Guid id, string projectId)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse saved query.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.WarehouseSavedQueriesDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WarehouseSavedQueriesDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse saved query. |  |
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

<a id="warehousesavedquerieslist"></a>
# **WarehouseSavedQueriesList**
> PaginatedDataWarehouseSavedQueryList WarehouseSavedQueriesList (string projectId, int? limit = null, int? offset = null, string search = null)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var search = "search_example";  // string | A search term. (optional) 

            try
            {
                PaginatedDataWarehouseSavedQueryList result = apiInstance.WarehouseSavedQueriesList(projectId, limit, offset, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedDataWarehouseSavedQueryList> response = apiInstance.WarehouseSavedQueriesListWithHttpInfo(projectId, limit, offset, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesListWithHttpInfo: " + e.Message);
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

[**PaginatedDataWarehouseSavedQueryList**](PaginatedDataWarehouseSavedQueryList.md)

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

<a id="warehousesavedqueriespartialupdate"></a>
# **WarehouseSavedQueriesPartialUpdate**
> DataWarehouseSavedQuery WarehouseSavedQueriesPartialUpdate (Guid id, string projectId, PatchedDataWarehouseSavedQuery patchedDataWarehouseSavedQuery = null)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse saved query.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedDataWarehouseSavedQuery = new PatchedDataWarehouseSavedQuery(); // PatchedDataWarehouseSavedQuery |  (optional) 

            try
            {
                DataWarehouseSavedQuery result = apiInstance.WarehouseSavedQueriesPartialUpdate(id, projectId, patchedDataWarehouseSavedQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataWarehouseSavedQuery> response = apiInstance.WarehouseSavedQueriesPartialUpdateWithHttpInfo(id, projectId, patchedDataWarehouseSavedQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse saved query. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedDataWarehouseSavedQuery** | [**PatchedDataWarehouseSavedQuery**](PatchedDataWarehouseSavedQuery.md) |  | [optional]  |

### Return type

[**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md)

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

<a id="warehousesavedqueriesretrieve"></a>
# **WarehouseSavedQueriesRetrieve**
> DataWarehouseSavedQuery WarehouseSavedQueriesRetrieve (Guid id, string projectId)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse saved query.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                DataWarehouseSavedQuery result = apiInstance.WarehouseSavedQueriesRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataWarehouseSavedQuery> response = apiInstance.WarehouseSavedQueriesRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse saved query. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md)

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

<a id="warehousesavedqueriesupdate"></a>
# **WarehouseSavedQueriesUpdate**
> DataWarehouseSavedQuery WarehouseSavedQueriesUpdate (Guid id, string projectId, DataWarehouseSavedQuery dataWarehouseSavedQuery)



Create, Read, Update and Delete Warehouse Tables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class WarehouseSavedQueriesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WarehouseSavedQueriesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this data warehouse saved query.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var dataWarehouseSavedQuery = new DataWarehouseSavedQuery(); // DataWarehouseSavedQuery | 

            try
            {
                DataWarehouseSavedQuery result = apiInstance.WarehouseSavedQueriesUpdate(id, projectId, dataWarehouseSavedQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarehouseSavedQueriesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataWarehouseSavedQuery> response = apiInstance.WarehouseSavedQueriesUpdateWithHttpInfo(id, projectId, dataWarehouseSavedQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WarehouseSavedQueriesApi.WarehouseSavedQueriesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this data warehouse saved query. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **dataWarehouseSavedQuery** | [**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md) |  |  |

### Return type

[**DataWarehouseSavedQuery**](DataWarehouseSavedQuery.md)

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

