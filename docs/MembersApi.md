# DotPostHog.Api.MembersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MembersDestroy**](MembersApi.md#membersdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |
| [**MembersList**](MembersApi.md#memberslist) | **GET** /api/organizations/{parent_lookup_organization_id}/members/ |  |
| [**MembersPartialUpdate**](MembersApi.md#memberspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |
| [**MembersUpdate**](MembersApi.md#membersupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |

<a id="membersdestroy"></a>
# **MembersDestroy**
> void MembersDestroy (string parentLookupOrganizationId, Guid userUuid)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class MembersDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MembersApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 

            try
            {
                apiInstance.MembersDestroy(parentLookupOrganizationId, userUuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.MembersDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MembersDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MembersDestroyWithHttpInfo(parentLookupOrganizationId, userUuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.MembersDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **userUuid** | **Guid** |  |  |

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

<a id="memberslist"></a>
# **MembersList**
> PaginatedOrganizationMemberList MembersList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class MembersListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MembersApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedOrganizationMemberList result = apiInstance.MembersList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.MembersList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MembersListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedOrganizationMemberList> response = apiInstance.MembersListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.MembersListWithHttpInfo: " + e.Message);
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

[**PaginatedOrganizationMemberList**](PaginatedOrganizationMemberList.md)

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

<a id="memberspartialupdate"></a>
# **MembersPartialUpdate**
> OrganizationMember MembersPartialUpdate (string parentLookupOrganizationId, Guid userUuid, PatchedOrganizationMember patchedOrganizationMember = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class MembersPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MembersApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 
            var patchedOrganizationMember = new PatchedOrganizationMember(); // PatchedOrganizationMember |  (optional) 

            try
            {
                OrganizationMember result = apiInstance.MembersPartialUpdate(parentLookupOrganizationId, userUuid, patchedOrganizationMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.MembersPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MembersPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationMember> response = apiInstance.MembersPartialUpdateWithHttpInfo(parentLookupOrganizationId, userUuid, patchedOrganizationMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.MembersPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **userUuid** | **Guid** |  |  |
| **patchedOrganizationMember** | [**PatchedOrganizationMember**](PatchedOrganizationMember.md) |  | [optional]  |

### Return type

[**OrganizationMember**](OrganizationMember.md)

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

<a id="membersupdate"></a>
# **MembersUpdate**
> OrganizationMember MembersUpdate (string parentLookupOrganizationId, Guid userUuid, OrganizationMember organizationMember = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class MembersUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MembersApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 
            var organizationMember = new OrganizationMember(); // OrganizationMember |  (optional) 

            try
            {
                OrganizationMember result = apiInstance.MembersUpdate(parentLookupOrganizationId, userUuid, organizationMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.MembersUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MembersUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationMember> response = apiInstance.MembersUpdateWithHttpInfo(parentLookupOrganizationId, userUuid, organizationMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.MembersUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **userUuid** | **Guid** |  |  |
| **organizationMember** | [**OrganizationMember**](OrganizationMember.md) |  | [optional]  |

### Return type

[**OrganizationMember**](OrganizationMember.md)

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

