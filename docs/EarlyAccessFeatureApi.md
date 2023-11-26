# DotPostHog.Api.EarlyAccessFeatureApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EarlyAccessFeatureCreate**](EarlyAccessFeatureApi.md#earlyaccessfeaturecreate) | **POST** /api/projects/{project_id}/early_access_feature/ |  |
| [**EarlyAccessFeatureDestroy**](EarlyAccessFeatureApi.md#earlyaccessfeaturedestroy) | **DELETE** /api/projects/{project_id}/early_access_feature/{id}/ |  |
| [**EarlyAccessFeatureList**](EarlyAccessFeatureApi.md#earlyaccessfeaturelist) | **GET** /api/projects/{project_id}/early_access_feature/ |  |
| [**EarlyAccessFeaturePartialUpdate**](EarlyAccessFeatureApi.md#earlyaccessfeaturepartialupdate) | **PATCH** /api/projects/{project_id}/early_access_feature/{id}/ |  |
| [**EarlyAccessFeatureRetrieve**](EarlyAccessFeatureApi.md#earlyaccessfeatureretrieve) | **GET** /api/projects/{project_id}/early_access_feature/{id}/ |  |
| [**EarlyAccessFeatureUpdate**](EarlyAccessFeatureApi.md#earlyaccessfeatureupdate) | **PUT** /api/projects/{project_id}/early_access_feature/{id}/ |  |

<a id="earlyaccessfeaturecreate"></a>
# **EarlyAccessFeatureCreate**
> PostHogEarlyAccessFeatureSerializerCreateOnly EarlyAccessFeatureCreate (string projectId, PostHogEarlyAccessFeatureSerializerCreateOnly postHogEarlyAccessFeatureSerializerCreateOnly)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeatureCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogEarlyAccessFeatureSerializerCreateOnly = new PostHogEarlyAccessFeatureSerializerCreateOnly(); // PostHogEarlyAccessFeatureSerializerCreateOnly | 

            try
            {
                PostHogEarlyAccessFeatureSerializerCreateOnly result = apiInstance.EarlyAccessFeatureCreate(projectId, postHogEarlyAccessFeatureSerializerCreateOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeatureCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogEarlyAccessFeatureSerializerCreateOnly> response = apiInstance.EarlyAccessFeatureCreateWithHttpInfo(projectId, postHogEarlyAccessFeatureSerializerCreateOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogEarlyAccessFeatureSerializerCreateOnly** | [**PostHogEarlyAccessFeatureSerializerCreateOnly**](PostHogEarlyAccessFeatureSerializerCreateOnly.md) |  |  |

### Return type

[**PostHogEarlyAccessFeatureSerializerCreateOnly**](PostHogEarlyAccessFeatureSerializerCreateOnly.md)

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

<a id="earlyaccessfeaturedestroy"></a>
# **EarlyAccessFeatureDestroy**
> void EarlyAccessFeatureDestroy (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeatureDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this early access feature.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.EarlyAccessFeatureDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeatureDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.EarlyAccessFeatureDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this early access feature. |  |
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

<a id="earlyaccessfeaturelist"></a>
# **EarlyAccessFeatureList**
> PostHogPaginatedEarlyAccessFeatureList EarlyAccessFeatureList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeatureListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedEarlyAccessFeatureList result = apiInstance.EarlyAccessFeatureList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeatureListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedEarlyAccessFeatureList> response = apiInstance.EarlyAccessFeatureListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedEarlyAccessFeatureList**](PostHogPaginatedEarlyAccessFeatureList.md)

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

<a id="earlyaccessfeaturepartialupdate"></a>
# **EarlyAccessFeaturePartialUpdate**
> PostHogEarlyAccessFeature EarlyAccessFeaturePartialUpdate (Guid id, string projectId, PostHogPatchedEarlyAccessFeature postHogPatchedEarlyAccessFeature = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeaturePartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this early access feature.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogPatchedEarlyAccessFeature = new PostHogPatchedEarlyAccessFeature(); // PostHogPatchedEarlyAccessFeature |  (optional) 

            try
            {
                PostHogEarlyAccessFeature result = apiInstance.EarlyAccessFeaturePartialUpdate(id, projectId, postHogPatchedEarlyAccessFeature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeaturePartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeaturePartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogEarlyAccessFeature> response = apiInstance.EarlyAccessFeaturePartialUpdateWithHttpInfo(id, projectId, postHogPatchedEarlyAccessFeature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeaturePartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this early access feature. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogPatchedEarlyAccessFeature** | [**PostHogPatchedEarlyAccessFeature**](PostHogPatchedEarlyAccessFeature.md) |  | [optional]  |

### Return type

[**PostHogEarlyAccessFeature**](PostHogEarlyAccessFeature.md)

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

<a id="earlyaccessfeatureretrieve"></a>
# **EarlyAccessFeatureRetrieve**
> PostHogEarlyAccessFeature EarlyAccessFeatureRetrieve (Guid id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeatureRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this early access feature.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                PostHogEarlyAccessFeature result = apiInstance.EarlyAccessFeatureRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeatureRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogEarlyAccessFeature> response = apiInstance.EarlyAccessFeatureRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this early access feature. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**PostHogEarlyAccessFeature**](PostHogEarlyAccessFeature.md)

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

<a id="earlyaccessfeatureupdate"></a>
# **EarlyAccessFeatureUpdate**
> PostHogEarlyAccessFeature EarlyAccessFeatureUpdate (Guid id, string projectId, PostHogEarlyAccessFeature postHogEarlyAccessFeature)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class EarlyAccessFeatureUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EarlyAccessFeatureApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this early access feature.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var postHogEarlyAccessFeature = new PostHogEarlyAccessFeature(); // PostHogEarlyAccessFeature | 

            try
            {
                PostHogEarlyAccessFeature result = apiInstance.EarlyAccessFeatureUpdate(id, projectId, postHogEarlyAccessFeature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EarlyAccessFeatureUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogEarlyAccessFeature> response = apiInstance.EarlyAccessFeatureUpdateWithHttpInfo(id, projectId, postHogEarlyAccessFeature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EarlyAccessFeatureApi.EarlyAccessFeatureUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this early access feature. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **postHogEarlyAccessFeature** | [**PostHogEarlyAccessFeature**](PostHogEarlyAccessFeature.md) |  |  |

### Return type

[**PostHogEarlyAccessFeature**](PostHogEarlyAccessFeature.md)

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

