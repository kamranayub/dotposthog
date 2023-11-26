# DotPostHog.Api.ResourceAccessApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResourceAccessCreate**](ResourceAccessApi.md#resourceaccesscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/resource_access/ |  |
| [**ResourceAccessDestroy**](ResourceAccessApi.md#resourceaccessdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessList**](ResourceAccessApi.md#resourceaccesslist) | **GET** /api/organizations/{parent_lookup_organization_id}/resource_access/ |  |
| [**ResourceAccessPartialUpdate**](ResourceAccessApi.md#resourceaccesspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessRetrieve**](ResourceAccessApi.md#resourceaccessretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessUpdate**](ResourceAccessApi.md#resourceaccessupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |

<a id="resourceaccesscreate"></a>
# **ResourceAccessCreate**
> OrganizationResourceAccess ResourceAccessCreate (string parentLookupOrganizationId, OrganizationResourceAccess organizationResourceAccess)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var organizationResourceAccess = new OrganizationResourceAccess(); // OrganizationResourceAccess | 

            try
            {
                OrganizationResourceAccess result = apiInstance.ResourceAccessCreate(parentLookupOrganizationId, organizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationResourceAccess> response = apiInstance.ResourceAccessCreateWithHttpInfo(parentLookupOrganizationId, organizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **organizationResourceAccess** | [**OrganizationResourceAccess**](OrganizationResourceAccess.md) |  |  |

### Return type

[**OrganizationResourceAccess**](OrganizationResourceAccess.md)

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

<a id="resourceaccessdestroy"></a>
# **ResourceAccessDestroy**
> void ResourceAccessDestroy (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.ResourceAccessDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ResourceAccessDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
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

<a id="resourceaccesslist"></a>
# **ResourceAccessList**
> PaginatedOrganizationResourceAccessList ResourceAccessList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedOrganizationResourceAccessList result = apiInstance.ResourceAccessList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedOrganizationResourceAccessList> response = apiInstance.ResourceAccessListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessListWithHttpInfo: " + e.Message);
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

[**PaginatedOrganizationResourceAccessList**](PaginatedOrganizationResourceAccessList.md)

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

<a id="resourceaccesspartialupdate"></a>
# **ResourceAccessPartialUpdate**
> OrganizationResourceAccess ResourceAccessPartialUpdate (int id, string parentLookupOrganizationId, PatchedOrganizationResourceAccess patchedOrganizationResourceAccess = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var patchedOrganizationResourceAccess = new PatchedOrganizationResourceAccess(); // PatchedOrganizationResourceAccess |  (optional) 

            try
            {
                OrganizationResourceAccess result = apiInstance.ResourceAccessPartialUpdate(id, parentLookupOrganizationId, patchedOrganizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationResourceAccess> response = apiInstance.ResourceAccessPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, patchedOrganizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **patchedOrganizationResourceAccess** | [**PatchedOrganizationResourceAccess**](PatchedOrganizationResourceAccess.md) |  | [optional]  |

### Return type

[**OrganizationResourceAccess**](OrganizationResourceAccess.md)

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

<a id="resourceaccessretrieve"></a>
# **ResourceAccessRetrieve**
> OrganizationResourceAccess ResourceAccessRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                OrganizationResourceAccess result = apiInstance.ResourceAccessRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationResourceAccess> response = apiInstance.ResourceAccessRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**OrganizationResourceAccess**](OrganizationResourceAccess.md)

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

<a id="resourceaccessupdate"></a>
# **ResourceAccessUpdate**
> OrganizationResourceAccess ResourceAccessUpdate (int id, string parentLookupOrganizationId, OrganizationResourceAccess organizationResourceAccess)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ResourceAccessUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResourceAccessApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var organizationResourceAccess = new OrganizationResourceAccess(); // OrganizationResourceAccess | 

            try
            {
                OrganizationResourceAccess result = apiInstance.ResourceAccessUpdate(id, parentLookupOrganizationId, organizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceAccessUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationResourceAccess> response = apiInstance.ResourceAccessUpdateWithHttpInfo(id, parentLookupOrganizationId, organizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceAccessApi.ResourceAccessUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **organizationResourceAccess** | [**OrganizationResourceAccess**](OrganizationResourceAccess.md) |  |  |

### Return type

[**OrganizationResourceAccess**](OrganizationResourceAccess.md)

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

