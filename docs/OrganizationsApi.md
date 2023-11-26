# DotPostHog.Api.OrganizationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DomainsCreate**](OrganizationsApi.md#domainscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/domains/ |  |
| [**DomainsDestroy**](OrganizationsApi.md#domainsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsList**](OrganizationsApi.md#domainslist) | **GET** /api/organizations/{parent_lookup_organization_id}/domains/ |  |
| [**DomainsPartialUpdate**](OrganizationsApi.md#domainspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsRetrieve**](OrganizationsApi.md#domainsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsUpdate**](OrganizationsApi.md#domainsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsVerifyCreate**](OrganizationsApi.md#domainsverifycreate) | **POST** /api/organizations/{parent_lookup_organization_id}/domains/{id}/verify/ |  |
| [**FeatureFlagsCopyFlagsCreate**](OrganizationsApi.md#featureflagscopyflagscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/feature_flags/copy_flags/ |  |
| [**FeatureFlagsRetrieve**](OrganizationsApi.md#featureflagsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/feature_flags/{feature_flag_key}/ |  |
| [**InvitesBulkCreate**](OrganizationsApi.md#invitesbulkcreate) | **POST** /api/organizations/{parent_lookup_organization_id}/invites/bulk/ |  |
| [**InvitesCreate**](OrganizationsApi.md#invitescreate) | **POST** /api/organizations/{parent_lookup_organization_id}/invites/ |  |
| [**InvitesDestroy**](OrganizationsApi.md#invitesdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/invites/{id}/ |  |
| [**InvitesList**](OrganizationsApi.md#inviteslist) | **GET** /api/organizations/{parent_lookup_organization_id}/invites/ |  |
| [**MembersDestroy**](OrganizationsApi.md#membersdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |
| [**MembersList**](OrganizationsApi.md#memberslist) | **GET** /api/organizations/{parent_lookup_organization_id}/members/ |  |
| [**MembersPartialUpdate**](OrganizationsApi.md#memberspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |
| [**MembersUpdate**](OrganizationsApi.md#membersupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/members/{user__uuid}/ |  |
| [**PipelineTransformationsActivityRetrieve**](OrganizationsApi.md#pipelinetransformationsactivityretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/activity/ |  |
| [**PipelineTransformationsCheckForUpdatesRetrieve**](OrganizationsApi.md#pipelinetransformationscheckforupdatesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/check_for_updates/ |  |
| [**PipelineTransformationsCreate**](OrganizationsApi.md#pipelinetransformationscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/ |  |
| [**PipelineTransformationsDestroy**](OrganizationsApi.md#pipelinetransformationsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsList**](OrganizationsApi.md#pipelinetransformationslist) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/ |  |
| [**PipelineTransformationsPartialUpdate**](OrganizationsApi.md#pipelinetransformationspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsRepositoryRetrieve**](OrganizationsApi.md#pipelinetransformationsrepositoryretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/repository/ |  |
| [**PipelineTransformationsRetrieve**](OrganizationsApi.md#pipelinetransformationsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsSourceRetrieve**](OrganizationsApi.md#pipelinetransformationssourceretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/source/ |  |
| [**PipelineTransformationsUnusedRetrieve**](OrganizationsApi.md#pipelinetransformationsunusedretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/unused/ |  |
| [**PipelineTransformationsUpdate**](OrganizationsApi.md#pipelinetransformationsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/ |  |
| [**PipelineTransformationsUpdateSourcePartialUpdate**](OrganizationsApi.md#pipelinetransformationsupdatesourcepartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/update_source/ |  |
| [**PipelineTransformationsUpgradeCreate**](OrganizationsApi.md#pipelinetransformationsupgradecreate) | **POST** /api/organizations/{parent_lookup_organization_id}/pipeline_transformations/{id}/upgrade/ |  |
| [**PluginsActivityRetrieve**](OrganizationsApi.md#pluginsactivityretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/activity/ |  |
| [**PluginsCheckForUpdatesRetrieve**](OrganizationsApi.md#pluginscheckforupdatesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/check_for_updates/ |  |
| [**PluginsCreate**](OrganizationsApi.md#pluginscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/plugins/ |  |
| [**PluginsDestroy**](OrganizationsApi.md#pluginsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsList**](OrganizationsApi.md#pluginslist) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/ |  |
| [**PluginsPartialUpdate**](OrganizationsApi.md#pluginspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsRepositoryRetrieve**](OrganizationsApi.md#pluginsrepositoryretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/repository/ |  |
| [**PluginsRetrieve**](OrganizationsApi.md#pluginsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsSourceRetrieve**](OrganizationsApi.md#pluginssourceretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/source/ |  |
| [**PluginsUnusedRetrieve**](OrganizationsApi.md#pluginsunusedretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/unused/ |  |
| [**PluginsUpdate**](OrganizationsApi.md#pluginsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsUpdateSourcePartialUpdate**](OrganizationsApi.md#pluginsupdatesourcepartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/update_source/ |  |
| [**PluginsUpgradeCreate**](OrganizationsApi.md#pluginsupgradecreate) | **POST** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/upgrade/ |  |
| [**ResourceAccessCreate**](OrganizationsApi.md#resourceaccesscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/resource_access/ |  |
| [**ResourceAccessDestroy**](OrganizationsApi.md#resourceaccessdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessList**](OrganizationsApi.md#resourceaccesslist) | **GET** /api/organizations/{parent_lookup_organization_id}/resource_access/ |  |
| [**ResourceAccessPartialUpdate**](OrganizationsApi.md#resourceaccesspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessRetrieve**](OrganizationsApi.md#resourceaccessretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**ResourceAccessUpdate**](OrganizationsApi.md#resourceaccessupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/resource_access/{id}/ |  |
| [**RolesCreate**](OrganizationsApi.md#rolescreate) | **POST** /api/organizations/{parent_lookup_organization_id}/roles/ |  |
| [**RolesDestroy**](OrganizationsApi.md#rolesdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesList**](OrganizationsApi.md#roleslist) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/ |  |
| [**RolesPartialUpdate**](OrganizationsApi.md#rolespartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesRetrieve**](OrganizationsApi.md#rolesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |
| [**RolesRoleMembershipsCreate**](OrganizationsApi.md#rolesrolemembershipscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/ |  |
| [**RolesRoleMembershipsDestroy**](OrganizationsApi.md#rolesrolemembershipsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/{id}/ |  |
| [**RolesRoleMembershipsList**](OrganizationsApi.md#rolesrolemembershipslist) | **GET** /api/organizations/{parent_lookup_organization_id}/roles/{parent_lookup_role_id}/role_memberships/ |  |
| [**RolesUpdate**](OrganizationsApi.md#rolesupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/roles/{id}/ |  |

<a id="domainscreate"></a>
# **DomainsCreate**
> PostHogOrganizationDomain DomainsCreate (string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsCreate(parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsCreateWithHttpInfo(parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsdestroy"></a>
# **DomainsDestroy**
> void DomainsDestroy (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.DomainsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DomainsDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
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

<a id="domainslist"></a>
# **DomainsList**
> PostHogPaginatedOrganizationDomainList DomainsList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedOrganizationDomainList result = apiInstance.DomainsList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedOrganizationDomainList> response = apiInstance.DomainsListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedOrganizationDomainList**](PostHogPaginatedOrganizationDomainList.md)

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

<a id="domainspartialupdate"></a>
# **DomainsPartialUpdate**
> PostHogOrganizationDomain DomainsPartialUpdate (Guid id, string parentLookupOrganizationId, PostHogPatchedOrganizationDomain postHogPatchedOrganizationDomain = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedOrganizationDomain = new PostHogPatchedOrganizationDomain(); // PostHogPatchedOrganizationDomain |  (optional) 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsPartialUpdate(id, parentLookupOrganizationId, postHogPatchedOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedOrganizationDomain** | [**PostHogPatchedOrganizationDomain**](PostHogPatchedOrganizationDomain.md) |  | [optional]  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsretrieve"></a>
# **DomainsRetrieve**
> PostHogOrganizationDomain DomainsRetrieve (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsupdate"></a>
# **DomainsUpdate**
> PostHogOrganizationDomain DomainsUpdate (Guid id, string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsUpdate(id, parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsverifycreate"></a>
# **DomainsVerifyCreate**
> PostHogOrganizationDomain DomainsVerifyCreate (Guid id, string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsVerifyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsVerifyCreate(id, parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DomainsVerifyCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsVerifyCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsVerifyCreateWithHttpInfo(id, parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DomainsVerifyCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="featureflagscopyflagscreate"></a>
# **FeatureFlagsCopyFlagsCreate**
> void FeatureFlagsCopyFlagsCreate (string parentLookupOrganizationId)



Retrieves all feature flags for a given organization and key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsCopyFlagsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.FeatureFlagsCopyFlagsCreate(parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FeatureFlagsCopyFlagsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsCopyFlagsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.FeatureFlagsCopyFlagsCreateWithHttpInfo(parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.FeatureFlagsCopyFlagsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="featureflagsretrieve"></a>
# **FeatureFlagsRetrieve**
> void FeatureFlagsRetrieve (string featureFlagKey, string parentLookupOrganizationId)



Retrieves all feature flags for a given organization and key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var featureFlagKey = "featureFlagKey_example";  // string | 
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.FeatureFlagsRetrieve(featureFlagKey, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FeatureFlagsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.FeatureFlagsRetrieveWithHttpInfo(featureFlagKey, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.FeatureFlagsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featureFlagKey** | **string** |  |  |
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invitesbulkcreate"></a>
# **InvitesBulkCreate**
> PostHogOrganizationInvite InvitesBulkCreate (string parentLookupOrganizationId, PostHogOrganizationInvite postHogOrganizationInvite)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class InvitesBulkCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationInvite = new PostHogOrganizationInvite(); // PostHogOrganizationInvite | 

            try
            {
                PostHogOrganizationInvite result = apiInstance.InvitesBulkCreate(parentLookupOrganizationId, postHogOrganizationInvite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InvitesBulkCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvitesBulkCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationInvite> response = apiInstance.InvitesBulkCreateWithHttpInfo(parentLookupOrganizationId, postHogOrganizationInvite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.InvitesBulkCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationInvite** | [**PostHogOrganizationInvite**](PostHogOrganizationInvite.md) |  |  |

### Return type

[**PostHogOrganizationInvite**](PostHogOrganizationInvite.md)

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

<a id="invitescreate"></a>
# **InvitesCreate**
> PostHogOrganizationInvite InvitesCreate (string parentLookupOrganizationId, PostHogOrganizationInvite postHogOrganizationInvite)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class InvitesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationInvite = new PostHogOrganizationInvite(); // PostHogOrganizationInvite | 

            try
            {
                PostHogOrganizationInvite result = apiInstance.InvitesCreate(parentLookupOrganizationId, postHogOrganizationInvite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InvitesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvitesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationInvite> response = apiInstance.InvitesCreateWithHttpInfo(parentLookupOrganizationId, postHogOrganizationInvite);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.InvitesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationInvite** | [**PostHogOrganizationInvite**](PostHogOrganizationInvite.md) |  |  |

### Return type

[**PostHogOrganizationInvite**](PostHogOrganizationInvite.md)

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

<a id="invitesdestroy"></a>
# **InvitesDestroy**
> void InvitesDestroy (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class InvitesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this organization invite.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.InvitesDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InvitesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvitesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InvitesDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.InvitesDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this organization invite. |  |
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

<a id="inviteslist"></a>
# **InvitesList**
> PostHogPaginatedOrganizationInviteList InvitesList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class InvitesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedOrganizationInviteList result = apiInstance.InvitesList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InvitesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvitesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedOrganizationInviteList> response = apiInstance.InvitesListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.InvitesListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedOrganizationInviteList**](PostHogPaginatedOrganizationInviteList.md)

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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 

            try
            {
                apiInstance.MembersDestroy(parentLookupOrganizationId, userUuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.MembersDestroy: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.MembersDestroyWithHttpInfo: " + e.Message);
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
> PostHogPaginatedOrganizationMemberList MembersList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedOrganizationMemberList result = apiInstance.MembersList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.MembersList: " + e.Message);
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
    ApiResponse<PostHogPaginatedOrganizationMemberList> response = apiInstance.MembersListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.MembersListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedOrganizationMemberList**](PostHogPaginatedOrganizationMemberList.md)

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
> PostHogOrganizationMember MembersPartialUpdate (string parentLookupOrganizationId, Guid userUuid, PostHogPatchedOrganizationMember postHogPatchedOrganizationMember = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 
            var postHogPatchedOrganizationMember = new PostHogPatchedOrganizationMember(); // PostHogPatchedOrganizationMember |  (optional) 

            try
            {
                PostHogOrganizationMember result = apiInstance.MembersPartialUpdate(parentLookupOrganizationId, userUuid, postHogPatchedOrganizationMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.MembersPartialUpdate: " + e.Message);
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
    ApiResponse<PostHogOrganizationMember> response = apiInstance.MembersPartialUpdateWithHttpInfo(parentLookupOrganizationId, userUuid, postHogPatchedOrganizationMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.MembersPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **userUuid** | **Guid** |  |  |
| **postHogPatchedOrganizationMember** | [**PostHogPatchedOrganizationMember**](PostHogPatchedOrganizationMember.md) |  | [optional]  |

### Return type

[**PostHogOrganizationMember**](PostHogOrganizationMember.md)

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
> PostHogOrganizationMember MembersUpdate (string parentLookupOrganizationId, Guid userUuid, PostHogOrganizationMember postHogOrganizationMember = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var userUuid = "userUuid_example";  // Guid | 
            var postHogOrganizationMember = new PostHogOrganizationMember(); // PostHogOrganizationMember |  (optional) 

            try
            {
                PostHogOrganizationMember result = apiInstance.MembersUpdate(parentLookupOrganizationId, userUuid, postHogOrganizationMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.MembersUpdate: " + e.Message);
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
    ApiResponse<PostHogOrganizationMember> response = apiInstance.MembersUpdateWithHttpInfo(parentLookupOrganizationId, userUuid, postHogOrganizationMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.MembersUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **userUuid** | **Guid** |  |  |
| **postHogOrganizationMember** | [**PostHogOrganizationMember**](PostHogOrganizationMember.md) |  | [optional]  |

### Return type

[**PostHogOrganizationMember**](PostHogOrganizationMember.md)

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

<a id="pipelinetransformationsactivityretrieve"></a>
# **PipelineTransformationsActivityRetrieve**
> PostHogPlugin PipelineTransformationsActivityRetrieve (string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsActivityRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsActivityRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsActivityRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsActivityRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsCheckForUpdatesRetrieve (int id, string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsCheckForUpdatesRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsCheckForUpdatesRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsCheckForUpdatesRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsCreate (string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsCreate(parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsCreate: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsCreateWithHttpInfo(parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.PipelineTransformationsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsDestroy: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsDestroyWithHttpInfo: " + e.Message);
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
> PostHogPaginatedPluginList PipelineTransformationsList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedPluginList result = apiInstance.PipelineTransformationsList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsList: " + e.Message);
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
    ApiResponse<PostHogPaginatedPluginList> response = apiInstance.PipelineTransformationsListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedPluginList**](PostHogPaginatedPluginList.md)

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
> PostHogPlugin PipelineTransformationsPartialUpdate (int id, string parentLookupOrganizationId, PostHogPatchedPlugin postHogPatchedPlugin = null)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedPlugin = new PostHogPatchedPlugin(); // PostHogPatchedPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsPartialUpdate(id, parentLookupOrganizationId, postHogPatchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsPartialUpdate: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedPlugin** | [**PostHogPatchedPlugin**](PostHogPatchedPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsRepositoryRetrieve (string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsRepositoryRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsRepositoryRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsRepositoryRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsRepositoryRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsRetrieve (int id, string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsSourceRetrieve (int id, string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsSourceRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsSourceRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsSourceRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsSourceRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsUnusedRetrieve (string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsUnusedRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUnusedRetrieve: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsUnusedRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUnusedRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsUpdate (int id, string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsUpdate(id, parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpdate: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsUpdateSourcePartialUpdate (int id, string parentLookupOrganizationId, PostHogPatchedPlugin postHogPatchedPlugin = null)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedPlugin = new PostHogPatchedPlugin(); // PostHogPatchedPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsUpdateSourcePartialUpdate(id, parentLookupOrganizationId, postHogPatchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpdateSourcePartialUpdate: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsUpdateSourcePartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpdateSourcePartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedPlugin** | [**PostHogPatchedPlugin**](PostHogPatchedPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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
> PostHogPlugin PipelineTransformationsUpgradeCreate (int id, string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PipelineTransformationsUpgradeCreate(id, parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpgradeCreate: " + e.Message);
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
    ApiResponse<PostHogPlugin> response = apiInstance.PipelineTransformationsUpgradeCreateWithHttpInfo(id, parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PipelineTransformationsUpgradeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsactivityretrieve"></a>
# **PluginsActivityRetrieve**
> PostHogPlugin PluginsActivityRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsActivityRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsActivityRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsActivityRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsActivityRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsActivityRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsActivityRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginscheckforupdatesretrieve"></a>
# **PluginsCheckForUpdatesRetrieve**
> PostHogPlugin PluginsCheckForUpdatesRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsCheckForUpdatesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsCheckForUpdatesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsCheckForUpdatesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsCheckForUpdatesRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsCheckForUpdatesRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginscreate"></a>
# **PluginsCreate**
> PostHogPlugin PluginsCreate (string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsCreate(parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsCreateWithHttpInfo(parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsdestroy"></a>
# **PluginsDestroy**
> void PluginsDestroy (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.PluginsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PluginsDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsDestroyWithHttpInfo: " + e.Message);
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

<a id="pluginslist"></a>
# **PluginsList**
> PostHogPaginatedPluginList PluginsList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedPluginList result = apiInstance.PluginsList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedPluginList> response = apiInstance.PluginsListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedPluginList**](PostHogPaginatedPluginList.md)

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

<a id="pluginspartialupdate"></a>
# **PluginsPartialUpdate**
> PostHogPlugin PluginsPartialUpdate (int id, string parentLookupOrganizationId, PostHogPatchedPlugin postHogPatchedPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedPlugin = new PostHogPatchedPlugin(); // PostHogPatchedPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsPartialUpdate(id, parentLookupOrganizationId, postHogPatchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedPlugin** | [**PostHogPatchedPlugin**](PostHogPatchedPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsrepositoryretrieve"></a>
# **PluginsRepositoryRetrieve**
> PostHogPlugin PluginsRepositoryRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsRepositoryRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsRepositoryRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsRepositoryRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsRepositoryRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsRepositoryRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsRepositoryRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsretrieve"></a>
# **PluginsRetrieve**
> PostHogPlugin PluginsRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginssourceretrieve"></a>
# **PluginsSourceRetrieve**
> PostHogPlugin PluginsSourceRetrieve (int id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsSourceRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsSourceRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsSourceRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsSourceRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsSourceRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsSourceRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsunusedretrieve"></a>
# **PluginsUnusedRetrieve**
> PostHogPlugin PluginsUnusedRetrieve (string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsUnusedRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsUnusedRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsUnusedRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsUnusedRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsUnusedRetrieveWithHttpInfo(parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsUnusedRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsupdate"></a>
# **PluginsUpdate**
> PostHogPlugin PluginsUpdate (int id, string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsUpdate(id, parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsupdatesourcepartialupdate"></a>
# **PluginsUpdateSourcePartialUpdate**
> PostHogPlugin PluginsUpdateSourcePartialUpdate (int id, string parentLookupOrganizationId, PostHogPatchedPlugin postHogPatchedPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsUpdateSourcePartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedPlugin = new PostHogPatchedPlugin(); // PostHogPatchedPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsUpdateSourcePartialUpdate(id, parentLookupOrganizationId, postHogPatchedPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsUpdateSourcePartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsUpdateSourcePartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsUpdateSourcePartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsUpdateSourcePartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedPlugin** | [**PostHogPatchedPlugin**](PostHogPatchedPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="pluginsupgradecreate"></a>
# **PluginsUpgradeCreate**
> PostHogPlugin PluginsUpgradeCreate (int id, string parentLookupOrganizationId, PostHogPlugin postHogPlugin = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PluginsUpgradeCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsUpgradeCreate(id, parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.PluginsUpgradeCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PluginsUpgradeCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPlugin> response = apiInstance.PluginsUpgradeCreateWithHttpInfo(id, parentLookupOrganizationId, postHogPlugin);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.PluginsUpgradeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this plugin. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPlugin** | [**PostHogPlugin**](PostHogPlugin.md) |  | [optional]  |

### Return type

[**PostHogPlugin**](PostHogPlugin.md)

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

<a id="resourceaccesscreate"></a>
# **ResourceAccessCreate**
> PostHogOrganizationResourceAccess ResourceAccessCreate (string parentLookupOrganizationId, PostHogOrganizationResourceAccess postHogOrganizationResourceAccess)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationResourceAccess = new PostHogOrganizationResourceAccess(); // PostHogOrganizationResourceAccess | 

            try
            {
                PostHogOrganizationResourceAccess result = apiInstance.ResourceAccessCreate(parentLookupOrganizationId, postHogOrganizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessCreate: " + e.Message);
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
    ApiResponse<PostHogOrganizationResourceAccess> response = apiInstance.ResourceAccessCreateWithHttpInfo(parentLookupOrganizationId, postHogOrganizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationResourceAccess** | [**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md) |  |  |

### Return type

[**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md)

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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.ResourceAccessDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessDestroy: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessDestroyWithHttpInfo: " + e.Message);
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
> PostHogPaginatedOrganizationResourceAccessList ResourceAccessList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedOrganizationResourceAccessList result = apiInstance.ResourceAccessList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessList: " + e.Message);
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
    ApiResponse<PostHogPaginatedOrganizationResourceAccessList> response = apiInstance.ResourceAccessListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedOrganizationResourceAccessList**](PostHogPaginatedOrganizationResourceAccessList.md)

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
> PostHogOrganizationResourceAccess ResourceAccessPartialUpdate (int id, string parentLookupOrganizationId, PostHogPatchedOrganizationResourceAccess postHogPatchedOrganizationResourceAccess = null)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedOrganizationResourceAccess = new PostHogPatchedOrganizationResourceAccess(); // PostHogPatchedOrganizationResourceAccess |  (optional) 

            try
            {
                PostHogOrganizationResourceAccess result = apiInstance.ResourceAccessPartialUpdate(id, parentLookupOrganizationId, postHogPatchedOrganizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessPartialUpdate: " + e.Message);
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
    ApiResponse<PostHogOrganizationResourceAccess> response = apiInstance.ResourceAccessPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedOrganizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedOrganizationResourceAccess** | [**PostHogPatchedOrganizationResourceAccess**](PostHogPatchedOrganizationResourceAccess.md) |  | [optional]  |

### Return type

[**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md)

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
> PostHogOrganizationResourceAccess ResourceAccessRetrieve (int id, string parentLookupOrganizationId)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogOrganizationResourceAccess result = apiInstance.ResourceAccessRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessRetrieve: " + e.Message);
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
    ApiResponse<PostHogOrganizationResourceAccess> response = apiInstance.ResourceAccessRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessRetrieveWithHttpInfo: " + e.Message);
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

[**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md)

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
> PostHogOrganizationResourceAccess ResourceAccessUpdate (int id, string parentLookupOrganizationId, PostHogOrganizationResourceAccess postHogOrganizationResourceAccess)



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
            var apiInstance = new OrganizationsApi(config);
            var id = 56;  // int | A unique integer value identifying this organization resource access.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationResourceAccess = new PostHogOrganizationResourceAccess(); // PostHogOrganizationResourceAccess | 

            try
            {
                PostHogOrganizationResourceAccess result = apiInstance.ResourceAccessUpdate(id, parentLookupOrganizationId, postHogOrganizationResourceAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ResourceAccessUpdate: " + e.Message);
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
    ApiResponse<PostHogOrganizationResourceAccess> response = apiInstance.ResourceAccessUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogOrganizationResourceAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ResourceAccessUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this organization resource access. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationResourceAccess** | [**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md) |  |  |

### Return type

[**PostHogOrganizationResourceAccess**](PostHogOrganizationResourceAccess.md)

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
            var apiInstance = new OrganizationsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogRole = new PostHogRole(); // PostHogRole | 

            try
            {
                PostHogRole result = apiInstance.RolesCreate(parentLookupOrganizationId, postHogRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RolesCreate: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesCreateWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.RolesDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RolesDestroy: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesDestroyWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
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
                Debug.Print("Exception when calling OrganizationsApi.RolesList: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesListWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
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
                Debug.Print("Exception when calling OrganizationsApi.RolesPartialUpdate: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesPartialUpdateWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogRole result = apiInstance.RolesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RolesRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
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
                Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsCreate: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsCreateWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this role membership.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var parentLookupRoleId = "parentLookupRoleId_example";  // string | 

            try
            {
                apiInstance.RolesRoleMembershipsDestroy(id, parentLookupOrganizationId, parentLookupRoleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsDestroy: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsDestroyWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
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
                Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsList: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesRoleMembershipsListWithHttpInfo: " + e.Message);
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
            var apiInstance = new OrganizationsApi(config);
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
                Debug.Print("Exception when calling OrganizationsApi.RolesUpdate: " + e.Message);
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
    Debug.Print("Exception when calling OrganizationsApi.RolesUpdateWithHttpInfo: " + e.Message);
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

