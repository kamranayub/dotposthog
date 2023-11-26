# DotPostHog.Api.PipelineTransformationsConfigsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PipelineTransformationsConfigsCreate**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigscreate) | **POST** /api/projects/{project_id}/pipeline_transformations_configs/ |  |
| [**PipelineTransformationsConfigsDestroy**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsdestroy) | **DELETE** /api/projects/{project_id}/pipeline_transformations_configs/{id}/ |  |
| [**PipelineTransformationsConfigsFrontendRetrieve**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsfrontendretrieve) | **GET** /api/projects/{project_id}/pipeline_transformations_configs/{id}/frontend/ |  |
| [**PipelineTransformationsConfigsJobCreate**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsjobcreate) | **POST** /api/projects/{project_id}/pipeline_transformations_configs/{id}/job/ |  |
| [**PipelineTransformationsConfigsList**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigslist) | **GET** /api/projects/{project_id}/pipeline_transformations_configs/ |  |
| [**PipelineTransformationsConfigsPartialUpdate**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigspartialupdate) | **PATCH** /api/projects/{project_id}/pipeline_transformations_configs/{id}/ |  |
| [**PipelineTransformationsConfigsRearrangePartialUpdate**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsrearrangepartialupdate) | **PATCH** /api/projects/{project_id}/pipeline_transformations_configs/rearrange/ |  |
| [**PipelineTransformationsConfigsRetrieve**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsretrieve) | **GET** /api/projects/{project_id}/pipeline_transformations_configs/{id}/ |  |
| [**PipelineTransformationsConfigsUpdate**](PipelineTransformationsConfigsApi.md#pipelinetransformationsconfigsupdate) | **PUT** /api/projects/{project_id}/pipeline_transformations_configs/{id}/ |  |

<a id="pipelinetransformationsconfigscreate"></a>
# **PipelineTransformationsConfigsCreate**
> PostHogPluginConfig PipelineTransformationsConfigsCreate (string projectId, PostHogPluginConfig postHogPluginConfig)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPluginConfig = new PostHogPluginConfig(); // PostHogPluginConfig | 

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsCreate(projectId, postHogPluginConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsCreateWithHttpInfo(projectId, postHogPluginConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPluginConfig** | [**PostHogPluginConfig**](PostHogPluginConfig.md) |  |  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigsdestroy"></a>
# **PipelineTransformationsConfigsDestroy**
> void PipelineTransformationsConfigsDestroy (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.PipelineTransformationsConfigsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PipelineTransformationsConfigsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
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

<a id="pipelinetransformationsconfigsfrontendretrieve"></a>
# **PipelineTransformationsConfigsFrontendRetrieve**
> PostHogPluginConfig PipelineTransformationsConfigsFrontendRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsFrontendRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsFrontendRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsFrontendRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsFrontendRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsFrontendRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsFrontendRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigsjobcreate"></a>
# **PipelineTransformationsConfigsJobCreate**
> PostHogPluginConfig PipelineTransformationsConfigsJobCreate (int id, string projectId, PostHogPluginConfig postHogPluginConfig)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsJobCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPluginConfig = new PostHogPluginConfig(); // PostHogPluginConfig | 

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsJobCreate(id, projectId, postHogPluginConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsJobCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsJobCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsJobCreateWithHttpInfo(id, projectId, postHogPluginConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsJobCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPluginConfig** | [**PostHogPluginConfig**](PostHogPluginConfig.md) |  |  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigslist"></a>
# **PipelineTransformationsConfigsList**
> PostHogPaginatedPluginConfigList PipelineTransformationsConfigsList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedPluginConfigList result = apiInstance.PipelineTransformationsConfigsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedPluginConfigList> response = apiInstance.PipelineTransformationsConfigsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedPluginConfigList**](PostHogPaginatedPluginConfigList.md)

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

<a id="pipelinetransformationsconfigspartialupdate"></a>
# **PipelineTransformationsConfigsPartialUpdate**
> PostHogPluginConfig PipelineTransformationsConfigsPartialUpdate (int id, string projectId, PostHogPatchedPluginConfig postHogPatchedPluginConfig = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPatchedPluginConfig = new PostHogPatchedPluginConfig(); // PostHogPatchedPluginConfig |  (optional) 

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsPartialUpdate(id, projectId, postHogPatchedPluginConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsPartialUpdateWithHttpInfo(id, projectId, postHogPatchedPluginConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPatchedPluginConfig** | [**PostHogPatchedPluginConfig**](PostHogPatchedPluginConfig.md) |  | [optional]  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigsrearrangepartialupdate"></a>
# **PipelineTransformationsConfigsRearrangePartialUpdate**
> PostHogPluginConfig PipelineTransformationsConfigsRearrangePartialUpdate (string projectId, PostHogPatchedPluginConfig postHogPatchedPluginConfig = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsRearrangePartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPatchedPluginConfig = new PostHogPatchedPluginConfig(); // PostHogPatchedPluginConfig |  (optional) 

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsRearrangePartialUpdate(projectId, postHogPatchedPluginConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsRearrangePartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsRearrangePartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsRearrangePartialUpdateWithHttpInfo(projectId, postHogPatchedPluginConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsRearrangePartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPatchedPluginConfig** | [**PostHogPatchedPluginConfig**](PostHogPatchedPluginConfig.md) |  | [optional]  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigsretrieve"></a>
# **PipelineTransformationsConfigsRetrieve**
> PostHogPluginConfig PipelineTransformationsConfigsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

<a id="pipelinetransformationsconfigsupdate"></a>
# **PipelineTransformationsConfigsUpdate**
> PostHogPluginConfig PipelineTransformationsConfigsUpdate (int id, string projectId, PostHogPluginConfig postHogPluginConfig)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PipelineTransformationsConfigsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PipelineTransformationsConfigsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPluginConfig = new PostHogPluginConfig(); // PostHogPluginConfig | 

            try
            {
                PostHogPluginConfig result = apiInstance.PipelineTransformationsConfigsUpdate(id, projectId, postHogPluginConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PipelineTransformationsConfigsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPluginConfig> response = apiInstance.PipelineTransformationsConfigsUpdateWithHttpInfo(id, projectId, postHogPluginConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PipelineTransformationsConfigsApi.PipelineTransformationsConfigsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin config. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPluginConfig** | [**PostHogPluginConfig**](PostHogPluginConfig.md) |  |  |

### Return type

[**PostHogPluginConfig**](PostHogPluginConfig.md)

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

