# DotPostHog.Api.RolesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RolesCreate**](RolesApi.md#rolescreate) | **POST** /api/organizations/{parent_lookup_organization_id}/roles/ |  |
| [**RolesDestroy**](RolesApi.md#rolesdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesList**](RolesApi.md#roleslist) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/ |  |
| [**RolesPartialUpdate**](RolesApi.md#rolespartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesRetrieve**](RolesApi.md#rolesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesRoleMembershipsCreate**](RolesApi.md#rolesrolemembershipscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/ |  |
| [**RolesRoleMembershipsDestroy**](RolesApi.md#rolesrolemembershipsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/{id}/ |  |
| [**RolesRoleMembershipsList**](RolesApi.md#rolesrolemembershipslist) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/ |  |
| [**RolesUpdate**](RolesApi.md#rolesupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |

<a id="rolescreate"></a>
# **RolesCreate**
> PostHogRole RolesCreate (string parentLookupOrganizationId, PostHogRole postHogRole)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogRole = new PostHogRole(); // PostHogRole | 

            try
            {
                PostHogRole result = apiInstance.RolesCreate(parentLookupOrganizationId, postHogRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogRole> response = apiInstance.RolesCreateWithHttpInfo(parentLookupOrganizationId, postHogRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogRole** | [**PostHogRole**](PostHogRole.md) |  |  |

### Return type

[**PostHogRole**](PostHogRole.md)

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

<a id="rolesdestroy"></a>
# **RolesDestroy**
> void RolesDestroy (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.RolesDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.RolesDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this role. |  |
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

<a id="roleslist"></a>
# **RolesList**
> PostHogPaginatedRoleList RolesList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedRoleList result = apiInstance.RolesList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedRoleList> response = apiInstance.RolesListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedRoleList**](PostHogPaginatedRoleList.md)

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

<a id="rolespartialupdate"></a>
# **RolesPartialUpdate**
> PostHogRole RolesPartialUpdate (Guid id, string parentLookupOrganizationId, PostHogPatchedRole postHogPatchedRole = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedRole = new PostHogPatchedRole(); // PostHogPatchedRole |  (optional) 

            try
            {
                PostHogRole result = apiInstance.RolesPartialUpdate(id, parentLookupOrganizationId, postHogPatchedRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogRole> response = apiInstance.RolesPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this role. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedRole** | [**PostHogPatchedRole**](PostHogPatchedRole.md) |  | [optional]  |

### Return type

[**PostHogRole**](PostHogRole.md)

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

<a id="rolesretrieve"></a>
# **RolesRetrieve**
> PostHogRole RolesRetrieve (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogRole result = apiInstance.RolesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogRole> response = apiInstance.RolesRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this role. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogRole**](PostHogRole.md)

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

<a id="rolesrolemembershipscreate"></a>
# **RolesRoleMembershipsCreate**
> PostHogRoleMembership RolesRoleMembershipsCreate (string parentLookupOrganizationId, string parentLookupRoleId, PostHogRoleMembership postHogRoleMembership)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesRoleMembershipsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var parentLookupRoleId = "parentLookupRoleId_example";  // string | 
            var postHogRoleMembership = new PostHogRoleMembership(); // PostHogRoleMembership | 

            try
            {
                PostHogRoleMembership result = apiInstance.RolesRoleMembershipsCreate(parentLookupOrganizationId, parentLookupRoleId, postHogRoleMembership);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesRoleMembershipsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogRoleMembership> response = apiInstance.RolesRoleMembershipsCreateWithHttpInfo(parentLookupOrganizationId, parentLookupRoleId, postHogRoleMembership);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **parentLookupRoleId** | **string** |  |  |
| **postHogRoleMembership** | [**PostHogRoleMembership**](PostHogRoleMembership.md) |  |  |

### Return type

[**PostHogRoleMembership**](PostHogRoleMembership.md)

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

<a id="rolesrolemembershipsdestroy"></a>
# **RolesRoleMembershipsDestroy**
> void RolesRoleMembershipsDestroy (Guid id, string parentLookupOrganizationId, string parentLookupRoleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesRoleMembershipsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role membership.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var parentLookupRoleId = "parentLookupRoleId_example";  // string | 

            try
            {
                apiInstance.RolesRoleMembershipsDestroy(id, parentLookupOrganizationId, parentLookupRoleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesRoleMembershipsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.RolesRoleMembershipsDestroyWithHttpInfo(id, parentLookupOrganizationId, parentLookupRoleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this role membership. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **parentLookupRoleId** | **string** |  |  |

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

<a id="rolesrolemembershipslist"></a>
# **RolesRoleMembershipsList**
> PostHogPaginatedRoleMembershipList RolesRoleMembershipsList (string parentLookupOrganizationId, string parentLookupRoleId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesRoleMembershipsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var parentLookupRoleId = "parentLookupRoleId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedRoleMembershipList result = apiInstance.RolesRoleMembershipsList(parentLookupOrganizationId, parentLookupRoleId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesRoleMembershipsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedRoleMembershipList> response = apiInstance.RolesRoleMembershipsListWithHttpInfo(parentLookupOrganizationId, parentLookupRoleId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesRoleMembershipsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **parentLookupRoleId** | **string** |  |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PostHogPaginatedRoleMembershipList**](PostHogPaginatedRoleMembershipList.md)

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

<a id="rolesupdate"></a>
# **RolesUpdate**
> PostHogRole RolesUpdate (Guid id, string parentLookupOrganizationId, PostHogRole postHogRole)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class RolesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RolesApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogRole = new PostHogRole(); // PostHogRole | 

            try
            {
                PostHogRole result = apiInstance.RolesUpdate(id, parentLookupOrganizationId, postHogRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RolesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RolesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogRole> response = apiInstance.RolesUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.RolesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this role. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogRole** | [**PostHogRole**](PostHogRole.md) |  |  |

### Return type

[**PostHogRole**](PostHogRole.md)

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

