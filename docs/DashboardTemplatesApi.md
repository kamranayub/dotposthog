# DotPostHog.Api.DashboardTemplatesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DashboardTemplatesCreate**](DashboardTemplatesApi.md#dashboardtemplatescreate) | **POST** /api/projects/{project_id}/dashboard_templates/ |  |
| [**DashboardTemplatesDestroy**](DashboardTemplatesApi.md#dashboardtemplatesdestroy) | **DELETE** /api/projects/{project_id}/dashboard_templates/{id}/ |  |
| [**DashboardTemplatesJsonSchemaRetrieve**](DashboardTemplatesApi.md#dashboardtemplatesjsonschemaretrieve) | **GET** /api/projects/{project_id}/dashboard_templates/json_schema/ |  |
| [**DashboardTemplatesList**](DashboardTemplatesApi.md#dashboardtemplateslist) | **GET** /api/projects/{project_id}/dashboard_templates/ |  |
| [**DashboardTemplatesPartialUpdate**](DashboardTemplatesApi.md#dashboardtemplatespartialupdate) | **PATCH** /api/projects/{project_id}/dashboard_templates/{id}/ |  |
| [**DashboardTemplatesRetrieve**](DashboardTemplatesApi.md#dashboardtemplatesretrieve) | **GET** /api/projects/{project_id}/dashboard_templates/{id}/ |  |
| [**DashboardTemplatesUpdate**](DashboardTemplatesApi.md#dashboardtemplatesupdate) | **PUT** /api/projects/{project_id}/dashboard_templates/{id}/ |  |

<a id="dashboardtemplatescreate"></a>
# **DashboardTemplatesCreate**
> DashboardTemplate DashboardTemplatesCreate (string projectId, DashboardTemplate dashboardTemplate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var dashboardTemplate = new DashboardTemplate(); // DashboardTemplate |  (optional) 

            try
            {
                DashboardTemplate result = apiInstance.DashboardTemplatesCreate(projectId, dashboardTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardTemplate> response = apiInstance.DashboardTemplatesCreateWithHttpInfo(projectId, dashboardTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **dashboardTemplate** | [**DashboardTemplate**](DashboardTemplate.md) |  | [optional]  |

### Return type

[**DashboardTemplate**](DashboardTemplate.md)

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

<a id="dashboardtemplatesdestroy"></a>
# **DashboardTemplatesDestroy**
> void DashboardTemplatesDestroy (string id, string projectId)



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
    public class DashboardTemplatesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.DashboardTemplatesDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DashboardTemplatesDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
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
| **405** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardtemplatesjsonschemaretrieve"></a>
# **DashboardTemplatesJsonSchemaRetrieve**
> DashboardTemplate DashboardTemplatesJsonSchemaRetrieve (string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesJsonSchemaRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                DashboardTemplate result = apiInstance.DashboardTemplatesJsonSchemaRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesJsonSchemaRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesJsonSchemaRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardTemplate> response = apiInstance.DashboardTemplatesJsonSchemaRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesJsonSchemaRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**DashboardTemplate**](DashboardTemplate.md)

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

<a id="dashboardtemplateslist"></a>
# **DashboardTemplatesList**
> PaginatedDashboardTemplateList DashboardTemplatesList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedDashboardTemplateList result = apiInstance.DashboardTemplatesList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedDashboardTemplateList> response = apiInstance.DashboardTemplatesListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesListWithHttpInfo: " + e.Message);
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

[**PaginatedDashboardTemplateList**](PaginatedDashboardTemplateList.md)

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

<a id="dashboardtemplatespartialupdate"></a>
# **DashboardTemplatesPartialUpdate**
> DashboardTemplate DashboardTemplatesPartialUpdate (string id, string projectId, PatchedDashboardTemplate patchedDashboardTemplate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedDashboardTemplate = new PatchedDashboardTemplate(); // PatchedDashboardTemplate |  (optional) 

            try
            {
                DashboardTemplate result = apiInstance.DashboardTemplatesPartialUpdate(id, projectId, patchedDashboardTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardTemplate> response = apiInstance.DashboardTemplatesPartialUpdateWithHttpInfo(id, projectId, patchedDashboardTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedDashboardTemplate** | [**PatchedDashboardTemplate**](PatchedDashboardTemplate.md) |  | [optional]  |

### Return type

[**DashboardTemplate**](DashboardTemplate.md)

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

<a id="dashboardtemplatesretrieve"></a>
# **DashboardTemplatesRetrieve**
> DashboardTemplate DashboardTemplatesRetrieve (string id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                DashboardTemplate result = apiInstance.DashboardTemplatesRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardTemplate> response = apiInstance.DashboardTemplatesRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**DashboardTemplate**](DashboardTemplate.md)

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

<a id="dashboardtemplatesupdate"></a>
# **DashboardTemplatesUpdate**
> DashboardTemplate DashboardTemplatesUpdate (string id, string projectId, DashboardTemplate dashboardTemplate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DashboardTemplatesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DashboardTemplatesApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var dashboardTemplate = new DashboardTemplate(); // DashboardTemplate |  (optional) 

            try
            {
                DashboardTemplate result = apiInstance.DashboardTemplatesUpdate(id, projectId, dashboardTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardTemplatesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardTemplate> response = apiInstance.DashboardTemplatesUpdateWithHttpInfo(id, projectId, dashboardTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardTemplatesApi.DashboardTemplatesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **dashboardTemplate** | [**DashboardTemplate**](DashboardTemplate.md) |  | [optional]  |

### Return type

[**DashboardTemplate**](DashboardTemplate.md)

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

