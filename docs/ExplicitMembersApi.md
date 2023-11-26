# DotPostHog.Api.ExplicitMembersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExplicitMembersCreate**](ExplicitMembersApi.md#explicitmemberscreate) | **POST** /api/projects/{project_id}/explicit_members/ |  |
| [**ExplicitMembersDestroy**](ExplicitMembersApi.md#explicitmembersdestroy) | **DELETE** /api/projects/{project_id}/explicit_members/{parent_membership__user__uuid}/ |  |
| [**ExplicitMembersList**](ExplicitMembersApi.md#explicitmemberslist) | **GET** /api/projects/{project_id}/explicit_members/ |  |
| [**ExplicitMembersPartialUpdate**](ExplicitMembersApi.md#explicitmemberspartialupdate) | **PATCH** /api/projects/{project_id}/explicit_members/{parent_membership__user__uuid}/ |  |
| [**ExplicitMembersRetrieve**](ExplicitMembersApi.md#explicitmembersretrieve) | **GET** /api/projects/{project_id}/explicit_members/{parent_membership__user__uuid}/ |  |
| [**ExplicitMembersUpdate**](ExplicitMembersApi.md#explicitmembersupdate) | **PUT** /api/projects/{project_id}/explicit_members/{parent_membership__user__uuid}/ |  |

<a id="explicitmemberscreate"></a>
# **ExplicitMembersCreate**
> ExplicitTeamMember ExplicitMembersCreate (string projectId, ExplicitTeamMember explicitTeamMember)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var explicitTeamMember = new ExplicitTeamMember(); // ExplicitTeamMember | 

            try
            {
                ExplicitTeamMember result = apiInstance.ExplicitMembersCreate(projectId, explicitTeamMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExplicitTeamMember> response = apiInstance.ExplicitMembersCreateWithHttpInfo(projectId, explicitTeamMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **explicitTeamMember** | [**ExplicitTeamMember**](ExplicitTeamMember.md) |  |  |

### Return type

[**ExplicitTeamMember**](ExplicitTeamMember.md)

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

<a id="explicitmembersdestroy"></a>
# **ExplicitMembersDestroy**
> void ExplicitMembersDestroy (Guid parentMembershipUserUuid, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var parentMembershipUserUuid = "parentMembershipUserUuid_example";  // Guid | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.ExplicitMembersDestroy(parentMembershipUserUuid, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ExplicitMembersDestroyWithHttpInfo(parentMembershipUserUuid, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentMembershipUserUuid** | **Guid** |  |  |
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

<a id="explicitmemberslist"></a>
# **ExplicitMembersList**
> List&lt;ExplicitTeamMember&gt; ExplicitMembersList (string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                List<ExplicitTeamMember> result = apiInstance.ExplicitMembersList(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ExplicitTeamMember>> response = apiInstance.ExplicitMembersListWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**List&lt;ExplicitTeamMember&gt;**](ExplicitTeamMember.md)

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

<a id="explicitmemberspartialupdate"></a>
# **ExplicitMembersPartialUpdate**
> ExplicitTeamMember ExplicitMembersPartialUpdate (Guid parentMembershipUserUuid, string projectId, PatchedExplicitTeamMember patchedExplicitTeamMember = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var parentMembershipUserUuid = "parentMembershipUserUuid_example";  // Guid | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedExplicitTeamMember = new PatchedExplicitTeamMember(); // PatchedExplicitTeamMember |  (optional) 

            try
            {
                ExplicitTeamMember result = apiInstance.ExplicitMembersPartialUpdate(parentMembershipUserUuid, projectId, patchedExplicitTeamMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExplicitTeamMember> response = apiInstance.ExplicitMembersPartialUpdateWithHttpInfo(parentMembershipUserUuid, projectId, patchedExplicitTeamMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentMembershipUserUuid** | **Guid** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedExplicitTeamMember** | [**PatchedExplicitTeamMember**](PatchedExplicitTeamMember.md) |  | [optional]  |

### Return type

[**ExplicitTeamMember**](ExplicitTeamMember.md)

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

<a id="explicitmembersretrieve"></a>
# **ExplicitMembersRetrieve**
> ExplicitTeamMember ExplicitMembersRetrieve (Guid parentMembershipUserUuid, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var parentMembershipUserUuid = "parentMembershipUserUuid_example";  // Guid | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                ExplicitTeamMember result = apiInstance.ExplicitMembersRetrieve(parentMembershipUserUuid, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExplicitTeamMember> response = apiInstance.ExplicitMembersRetrieveWithHttpInfo(parentMembershipUserUuid, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentMembershipUserUuid** | **Guid** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**ExplicitTeamMember**](ExplicitTeamMember.md)

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

<a id="explicitmembersupdate"></a>
# **ExplicitMembersUpdate**
> ExplicitTeamMember ExplicitMembersUpdate (Guid parentMembershipUserUuid, string projectId, ExplicitTeamMember explicitTeamMember)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExplicitMembersUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExplicitMembersApi(config);
            var parentMembershipUserUuid = "parentMembershipUserUuid_example";  // Guid | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var explicitTeamMember = new ExplicitTeamMember(); // ExplicitTeamMember | 

            try
            {
                ExplicitTeamMember result = apiInstance.ExplicitMembersUpdate(parentMembershipUserUuid, projectId, explicitTeamMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplicitMembersUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExplicitTeamMember> response = apiInstance.ExplicitMembersUpdateWithHttpInfo(parentMembershipUserUuid, projectId, explicitTeamMember);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExplicitMembersApi.ExplicitMembersUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentMembershipUserUuid** | **Guid** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **explicitTeamMember** | [**ExplicitTeamMember**](ExplicitTeamMember.md) |  |  |

### Return type

[**ExplicitTeamMember**](ExplicitTeamMember.md)

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

