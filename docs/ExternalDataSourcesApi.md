# DotPostHog.Api.ExternalDataSourcesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExternalDataSourcesCreate**](ExternalDataSourcesApi.md#externaldatasourcescreate) | **POST** /api/projects/{project_id}/external_data_sources/ |  |
| [**ExternalDataSourcesDestroy**](ExternalDataSourcesApi.md#externaldatasourcesdestroy) | **DELETE** /api/projects/{project_id}/external_data_sources/{id}/ |  |
| [**ExternalDataSourcesList**](ExternalDataSourcesApi.md#externaldatasourceslist) | **GET** /api/projects/{project_id}/external_data_sources/ |  |
| [**ExternalDataSourcesPartialUpdate**](ExternalDataSourcesApi.md#externaldatasourcespartialupdate) | **PATCH** /api/projects/{project_id}/external_data_sources/{id}/ |  |
| [**ExternalDataSourcesReloadCreate**](ExternalDataSourcesApi.md#externaldatasourcesreloadcreate) | **POST** /api/projects/{project_id}/external_data_sources/{id}/reload/ |  |
| [**ExternalDataSourcesRetrieve**](ExternalDataSourcesApi.md#externaldatasourcesretrieve) | **GET** /api/projects/{project_id}/external_data_sources/{id}/ |  |
| [**ExternalDataSourcesUpdate**](ExternalDataSourcesApi.md#externaldatasourcesupdate) | **PUT** /api/projects/{project_id}/external_data_sources/{id}/ |  |

<a id="externaldatasourcescreate"></a>
# **ExternalDataSourcesCreate**
> ExternalDataSourceSerializers ExternalDataSourcesCreate (string projectId, ExternalDataSourceSerializers externalDataSourceSerializers)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var externalDataSourceSerializers = new ExternalDataSourceSerializers(); // ExternalDataSourceSerializers | 

            try
            {
                ExternalDataSourceSerializers result = apiInstance.ExternalDataSourcesCreate(projectId, externalDataSourceSerializers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalDataSourceSerializers> response = apiInstance.ExternalDataSourcesCreateWithHttpInfo(projectId, externalDataSourceSerializers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **externalDataSourceSerializers** | [**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md) |  |  |

### Return type

[**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md)

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

<a id="externaldatasourcesdestroy"></a>
# **ExternalDataSourcesDestroy**
> void ExternalDataSourcesDestroy (Guid id, string projectId)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this external data source.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.ExternalDataSourcesDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ExternalDataSourcesDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this external data source. |  |
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

<a id="externaldatasourceslist"></a>
# **ExternalDataSourcesList**
> PaginatedExternalDataSourceSerializersList ExternalDataSourcesList (string projectId, int? limit = null, int? offset = null, string search = null)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var search = "search_example";  // string | A search term. (optional) 

            try
            {
                PaginatedExternalDataSourceSerializersList result = apiInstance.ExternalDataSourcesList(projectId, limit, offset, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedExternalDataSourceSerializersList> response = apiInstance.ExternalDataSourcesListWithHttpInfo(projectId, limit, offset, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesListWithHttpInfo: " + e.Message);
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

[**PaginatedExternalDataSourceSerializersList**](PaginatedExternalDataSourceSerializersList.md)

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

<a id="externaldatasourcespartialupdate"></a>
# **ExternalDataSourcesPartialUpdate**
> ExternalDataSourceSerializers ExternalDataSourcesPartialUpdate (Guid id, string projectId, PatchedExternalDataSourceSerializers patchedExternalDataSourceSerializers = null)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this external data source.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedExternalDataSourceSerializers = new PatchedExternalDataSourceSerializers(); // PatchedExternalDataSourceSerializers |  (optional) 

            try
            {
                ExternalDataSourceSerializers result = apiInstance.ExternalDataSourcesPartialUpdate(id, projectId, patchedExternalDataSourceSerializers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalDataSourceSerializers> response = apiInstance.ExternalDataSourcesPartialUpdateWithHttpInfo(id, projectId, patchedExternalDataSourceSerializers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this external data source. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedExternalDataSourceSerializers** | [**PatchedExternalDataSourceSerializers**](PatchedExternalDataSourceSerializers.md) |  | [optional]  |

### Return type

[**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md)

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

<a id="externaldatasourcesreloadcreate"></a>
# **ExternalDataSourcesReloadCreate**
> ExternalDataSourceSerializers ExternalDataSourcesReloadCreate (Guid id, string projectId, ExternalDataSourceSerializers externalDataSourceSerializers)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesReloadCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this external data source.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var externalDataSourceSerializers = new ExternalDataSourceSerializers(); // ExternalDataSourceSerializers | 

            try
            {
                ExternalDataSourceSerializers result = apiInstance.ExternalDataSourcesReloadCreate(id, projectId, externalDataSourceSerializers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesReloadCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesReloadCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalDataSourceSerializers> response = apiInstance.ExternalDataSourcesReloadCreateWithHttpInfo(id, projectId, externalDataSourceSerializers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesReloadCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this external data source. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **externalDataSourceSerializers** | [**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md) |  |  |

### Return type

[**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md)

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

<a id="externaldatasourcesretrieve"></a>
# **ExternalDataSourcesRetrieve**
> ExternalDataSourceSerializers ExternalDataSourcesRetrieve (Guid id, string projectId)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this external data source.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                ExternalDataSourceSerializers result = apiInstance.ExternalDataSourcesRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalDataSourceSerializers> response = apiInstance.ExternalDataSourcesRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this external data source. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md)

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

<a id="externaldatasourcesupdate"></a>
# **ExternalDataSourcesUpdate**
> ExternalDataSourceSerializers ExternalDataSourcesUpdate (Guid id, string projectId, ExternalDataSourceSerializers externalDataSourceSerializers)



Create, Read, Update and Delete External data Sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExternalDataSourcesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExternalDataSourcesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this external data source.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var externalDataSourceSerializers = new ExternalDataSourceSerializers(); // ExternalDataSourceSerializers | 

            try
            {
                ExternalDataSourceSerializers result = apiInstance.ExternalDataSourcesUpdate(id, projectId, externalDataSourceSerializers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalDataSourcesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalDataSourceSerializers> response = apiInstance.ExternalDataSourcesUpdateWithHttpInfo(id, projectId, externalDataSourceSerializers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalDataSourcesApi.ExternalDataSourcesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this external data source. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **externalDataSourceSerializers** | [**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md) |  |  |

### Return type

[**ExternalDataSourceSerializers**](ExternalDataSourceSerializers.md)

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

