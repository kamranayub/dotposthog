# DotPostHog.Api.PipelineTransformationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PipelineTransformationsActivityRetrieve**](PipelineTransformationsApi.md#pipelinetransformationsactivityretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/activity/ |  |
| [**PipelineTransformationsCheckForUpdatesRetrieve**](PipelineTransformationsApi.md#pipelinetransformationscheckforupdatesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/check_for_updates/ |  |
| [**PipelineTransformationsCreate**](PipelineTransformationsApi.md#pipelinetransformationscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/ |  |
| [**PipelineTransformationsDestroy**](PipelineTransformationsApi.md#pipelinetransformationsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsList**](PipelineTransformationsApi.md#pipelinetransformationslist) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/ |  |
| [**PipelineTransformationsPartialUpdate**](PipelineTransformationsApi.md#pipelinetransformationspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsRepositoryRetrieve**](PipelineTransformationsApi.md#pipelinetransformationsrepositoryretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/repository/ |  |
| [**PipelineTransformationsRetrieve**](PipelineTransformationsApi.md#pipelinetransformationsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsSourceRetrieve**](PipelineTransformationsApi.md#pipelinetransformationssourceretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/source/ |  |
| [**PipelineTransformationsUnusedRetrieve**](PipelineTransformationsApi.md#pipelinetransformationsunusedretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/unused/ |  |
| [**PipelineTransformationsUpdate**](PipelineTransformationsApi.md#pipelinetransformationsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsUpdateSourcePartialUpdate**](PipelineTransformationsApi.md#pipelinetransformationsupdatesourcepartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/update_source/ |  |
| [**PipelineTransformationsUpgradeCreate**](PipelineTransformationsApi.md#pipelinetransformationsupgradecreate) | **POST** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/upgrade/ |  |

<a id="pipelinetransformationsactivityretrieve"></a>
# **PipelineTransformationsActivityRetrieve**
> Plugin PipelineTransformationsActivityRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsActivityRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsActivityRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsActivityRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsActivityRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsActivityRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsActivityRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationscheckforupdatesretrieve"></a>
# **PipelineTransformationsCheckForUpdatesRetrieve**
> Plugin PipelineTransformationsCheckForUpdatesRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsCheckForUpdatesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsCheckForUpdatesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsCheckForUpdatesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsCheckForUpdatesRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsCheckForUpdatesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationscreate"></a>
# **PipelineTransformationsCreate**
> Plugin PipelineTransformationsCreate (string parentLookupOrganizationId, Plugin plugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var plugin = new Plugin(); // Plugin |  (optional) 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsCreate(parentLookupOrganizationId, plugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsCreateWithHttpInfo(parentLookupOrganizationId, plugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **plugin** | [**Plugin**](Plugin.md) |  | [optional]  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsdestroy"></a>
# **PipelineTransformationsDestroy**
> void PipelineTransformationsDestroy (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.PipelineTransformationsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PipelineTransformationsDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |

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

<a id="pipelinetransformationslist"></a>
# **PipelineTransformationsList**
> PaginatedPluginList PipelineTransformationsList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedPluginList result = apiInstance.PipelineTransformationsList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedPluginList> response = apiInstance.PipelineTransformationsListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PaginatedPluginList**](PaginatedPluginList.md)

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

<a id="pipelinetransformationspartialupdate"></a>
# **PipelineTransformationsPartialUpdate**
> Plugin PipelineTransformationsPartialUpdate (int id, string parentLookupOrganizationId, PatchedPlugin patchedPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var patchedPlugin = new PatchedPlugin(); // PatchedPlugin |  (optional) 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsPartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, patchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **patchedPlugin** | [**PatchedPlugin**](PatchedPlugin.md) |  | [optional]  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsrepositoryretrieve"></a>
# **PipelineTransformationsRepositoryRetrieve**
> Plugin PipelineTransformationsRepositoryRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsRepositoryRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsRepositoryRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsRepositoryRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsRepositoryRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsRepositoryRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsRepositoryRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsretrieve"></a>
# **PipelineTransformationsRetrieve**
> Plugin PipelineTransformationsRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationssourceretrieve"></a>
# **PipelineTransformationsSourceRetrieve**
> Plugin PipelineTransformationsSourceRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsSourceRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsSourceRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsSourceRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsSourceRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsSourceRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsSourceRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsunusedretrieve"></a>
# **PipelineTransformationsUnusedRetrieve**
> Plugin PipelineTransformationsUnusedRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsUnusedRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsUnusedRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUnusedRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsUnusedRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsUnusedRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUnusedRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsupdate"></a>
# **PipelineTransformationsUpdate**
> Plugin PipelineTransformationsUpdate (int id, string parentLookupOrganizationId, Plugin plugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var plugin = new Plugin(); // Plugin |  (optional) 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsUpdate(id, parentLookupOrganizationId, plugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsUpdateWithHttpInfo(id, parentLookupOrganizationId, plugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **plugin** | [**Plugin**](Plugin.md) |  | [optional]  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsupdatesourcepartialupdate"></a>
# **PipelineTransformationsUpdateSourcePartialUpdate**
> Plugin PipelineTransformationsUpdateSourcePartialUpdate (int id, string parentLookupOrganizationId, PatchedPlugin patchedPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsUpdateSourcePartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var patchedPlugin = new PatchedPlugin(); // PatchedPlugin |  (optional) 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsUpdateSourcePartialUpdate(id, parentLookupOrganizationId, patchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpdateSourcePartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsUpdateSourcePartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsUpdateSourcePartialUpdateWithHttpInfo(id, parentLookupOrganizationId, patchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpdateSourcePartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **patchedPlugin** | [**PatchedPlugin**](PatchedPlugin.md) |  | [optional]  |

### Return type

[**Plugin**](Plugin.md)

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

<a id="pipelinetransformationsupgradecreate"></a>
# **PipelineTransformationsUpgradeCreate**
> Plugin PipelineTransformationsUpgradeCreate (int id, string parentLookupOrganizationId, Plugin plugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsUpgradeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var plugin = new Plugin(); // Plugin |  (optional) 

            try
            {
                Plugin result = apiInstance.PipelineTransformationsUpgradeCreate(id, parentLookupOrganizationId, plugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpgradeCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsUpgradeCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Plugin> response = apiInstance.PipelineTransformationsUpgradeCreateWithHttpInfo(id, parentLookupOrganizationId, plugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsApi.PipelineTransformationsUpgradeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **plugin** | [**Plugin**](Plugin.md) |  | [optional]  |

### Return type

[**Plugin**](Plugin.md)

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

