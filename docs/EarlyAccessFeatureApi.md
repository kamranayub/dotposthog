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
> EarlyAccessFeatureSerializerCreateOnly EarlyAccessFeatureCreate (string projectId, EarlyAccessFeatureSerializerCreateOnly earlyAccessFeatureSerializerCreateOnly)



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
            var earlyAccessFeatureSerializerCreateOnly = new EarlyAccessFeatureSerializerCreateOnly(); // EarlyAccessFeatureSerializerCreateOnly | 

            try
            {
                EarlyAccessFeatureSerializerCreateOnly result = apiInstance.EarlyAccessFeatureCreate(projectId, earlyAccessFeatureSerializerCreateOnly);
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
    ApiResponse<EarlyAccessFeatureSerializerCreateOnly> response = apiInstance.EarlyAccessFeatureCreateWithHttpInfo(projectId, earlyAccessFeatureSerializerCreateOnly);
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
| **earlyAccessFeatureSerializerCreateOnly** | [**EarlyAccessFeatureSerializerCreateOnly**](EarlyAccessFeatureSerializerCreateOnly.md) |  |  |

### Return type

[**EarlyAccessFeatureSerializerCreateOnly**](EarlyAccessFeatureSerializerCreateOnly.md)

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
> PaginatedEarlyAccessFeatureList EarlyAccessFeatureList (string projectId, int? limit = null, int? offset = null)



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
                PaginatedEarlyAccessFeatureList result = apiInstance.EarlyAccessFeatureList(projectId, limit, offset);
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
    ApiResponse<PaginatedEarlyAccessFeatureList> response = apiInstance.EarlyAccessFeatureListWithHttpInfo(projectId, limit, offset);
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

[**PaginatedEarlyAccessFeatureList**](PaginatedEarlyAccessFeatureList.md)

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
> EarlyAccessFeature EarlyAccessFeaturePartialUpdate (Guid id, string projectId, PatchedEarlyAccessFeature patchedEarlyAccessFeature = null)



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
            var patchedEarlyAccessFeature = new PatchedEarlyAccessFeature(); // PatchedEarlyAccessFeature |  (optional) 

            try
            {
                EarlyAccessFeature result = apiInstance.EarlyAccessFeaturePartialUpdate(id, projectId, patchedEarlyAccessFeature);
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
    ApiResponse<EarlyAccessFeature> response = apiInstance.EarlyAccessFeaturePartialUpdateWithHttpInfo(id, projectId, patchedEarlyAccessFeature);
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
| **patchedEarlyAccessFeature** | [**PatchedEarlyAccessFeature**](PatchedEarlyAccessFeature.md) |  | [optional]  |

### Return type

[**EarlyAccessFeature**](EarlyAccessFeature.md)

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
> EarlyAccessFeature EarlyAccessFeatureRetrieve (Guid id, string projectId)



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
                EarlyAccessFeature result = apiInstance.EarlyAccessFeatureRetrieve(id, projectId);
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
    ApiResponse<EarlyAccessFeature> response = apiInstance.EarlyAccessFeatureRetrieveWithHttpInfo(id, projectId);
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

[**EarlyAccessFeature**](EarlyAccessFeature.md)

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
> EarlyAccessFeature EarlyAccessFeatureUpdate (Guid id, string projectId, EarlyAccessFeature earlyAccessFeature)



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
            var earlyAccessFeature = new EarlyAccessFeature(); // EarlyAccessFeature | 

            try
            {
                EarlyAccessFeature result = apiInstance.EarlyAccessFeatureUpdate(id, projectId, earlyAccessFeature);
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
    ApiResponse<EarlyAccessFeature> response = apiInstance.EarlyAccessFeatureUpdateWithHttpInfo(id, projectId, earlyAccessFeature);
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
| **earlyAccessFeature** | [**EarlyAccessFeature**](EarlyAccessFeature.md) |  |  |

### Return type

[**EarlyAccessFeature**](EarlyAccessFeature.md)

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

