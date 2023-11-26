# DotPostHog.Api.FeatureFlagsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FeatureFlagsActivityRetrieve**](FeatureFlagsApi.md#featureflagsactivityretrieve) | **GET** /api/projects/{project_id}/feature_flags/activity/ |  |
| [**FeatureFlagsActivityRetrieve2**](FeatureFlagsApi.md#featureflagsactivityretrieve2) | **GET** /api/projects/{project_id}/feature_flags/{id}/activity/ |  |
| [**FeatureFlagsCopyFlagsCreate**](FeatureFlagsApi.md#featureflagscopyflagscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/feature_flags/copy_flags/ |  |
| [**FeatureFlagsCreate**](FeatureFlagsApi.md#featureflagscreate) | **POST** /api/projects/{project_id}/feature_flags/ |  |
| [**FeatureFlagsCreateStaticCohortForFlagCreate**](FeatureFlagsApi.md#featureflagscreatestaticcohortforflagcreate) | **POST** /api/projects/{project_id}/feature_flags/{id}/create_static_cohort_for_flag/ |  |
| [**FeatureFlagsDashboardCreate**](FeatureFlagsApi.md#featureflagsdashboardcreate) | **POST** /api/projects/{project_id}/feature_flags/{id}/dashboard/ |  |
| [**FeatureFlagsDestroy**](FeatureFlagsApi.md#featureflagsdestroy) | **DELETE** /api/projects/{project_id}/feature_flags/{id}/ |  |
| [**FeatureFlagsEnrichUsageDashboardCreate**](FeatureFlagsApi.md#featureflagsenrichusagedashboardcreate) | **POST** /api/projects/{project_id}/feature_flags/{id}/enrich_usage_dashboard/ |  |
| [**FeatureFlagsEvaluationReasonsRetrieve**](FeatureFlagsApi.md#featureflagsevaluationreasonsretrieve) | **GET** /api/projects/{project_id}/feature_flags/evaluation_reasons/ |  |
| [**FeatureFlagsList**](FeatureFlagsApi.md#featureflagslist) | **GET** /api/projects/{project_id}/feature_flags/ |  |
| [**FeatureFlagsLocalEvaluationRetrieve**](FeatureFlagsApi.md#featureflagslocalevaluationretrieve) | **GET** /api/projects/{project_id}/feature_flags/local_evaluation/ |  |
| [**FeatureFlagsMyFlagsRetrieve**](FeatureFlagsApi.md#featureflagsmyflagsretrieve) | **GET** /api/projects/{project_id}/feature_flags/my_flags/ |  |
| [**FeatureFlagsPartialUpdate**](FeatureFlagsApi.md#featureflagspartialupdate) | **PATCH** /api/projects/{project_id}/feature_flags/{id}/ |  |
| [**FeatureFlagsRetrieve**](FeatureFlagsApi.md#featureflagsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/feature_flags/{feature_flag_key}/ |  |
| [**FeatureFlagsRetrieve2**](FeatureFlagsApi.md#featureflagsretrieve2) | **GET** /api/projects/{project_id}/feature_flags/{id}/ |  |
| [**FeatureFlagsRoleAccessCreate**](FeatureFlagsApi.md#featureflagsroleaccesscreate) | **POST** /api/projects/{project_id}/feature_flags/{parent_lookup_feature_flag_id}/role_access/ |  |
| [**FeatureFlagsRoleAccessDestroy**](FeatureFlagsApi.md#featureflagsroleaccessdestroy) | **DELETE** /api/projects/{project_id}/feature_flags/{parent_lookup_feature_flag_id}/role_access/{id}/ |  |
| [**FeatureFlagsRoleAccessList**](FeatureFlagsApi.md#featureflagsroleaccesslist) | **GET** /api/projects/{project_id}/feature_flags/{parent_lookup_feature_flag_id}/role_access/ |  |
| [**FeatureFlagsRoleAccessRetrieve**](FeatureFlagsApi.md#featureflagsroleaccessretrieve) | **GET** /api/projects/{project_id}/feature_flags/{parent_lookup_feature_flag_id}/role_access/{id}/ |  |
| [**FeatureFlagsUpdate**](FeatureFlagsApi.md#featureflagsupdate) | **PUT** /api/projects/{project_id}/feature_flags/{id}/ |  |
| [**FeatureFlagsUserBlastRadiusCreate**](FeatureFlagsApi.md#featureflagsuserblastradiuscreate) | **POST** /api/projects/{project_id}/feature_flags/user_blast_radius/ |  |

<a id="featureflagsactivityretrieve"></a>
# **FeatureFlagsActivityRetrieve**
> FeatureFlag FeatureFlagsActivityRetrieve (string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsActivityRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsActivityRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsActivityRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsActivityRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsActivityRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsActivityRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsactivityretrieve2"></a>
# **FeatureFlagsActivityRetrieve2**
> FeatureFlag FeatureFlagsActivityRetrieve2 (int id, string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsActivityRetrieve2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsActivityRetrieve2(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsActivityRetrieve2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsActivityRetrieve2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsActivityRetrieve2WithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsActivityRetrieve2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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
            var apiInstance = new FeatureFlagsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.FeatureFlagsCopyFlagsCreate(parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCopyFlagsCreate: " + e.Message);
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
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCopyFlagsCreateWithHttpInfo: " + e.Message);
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

<a id="featureflagscreate"></a>
# **FeatureFlagsCreate**
> FeatureFlag FeatureFlagsCreate (string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsCreate(projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsCreateWithHttpInfo(projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagscreatestaticcohortforflagcreate"></a>
# **FeatureFlagsCreateStaticCohortForFlagCreate**
> FeatureFlag FeatureFlagsCreateStaticCohortForFlagCreate (int id, string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsCreateStaticCohortForFlagCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsCreateStaticCohortForFlagCreate(id, projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCreateStaticCohortForFlagCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsCreateStaticCohortForFlagCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsCreateStaticCohortForFlagCreateWithHttpInfo(id, projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsCreateStaticCohortForFlagCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsdashboardcreate"></a>
# **FeatureFlagsDashboardCreate**
> FeatureFlag FeatureFlagsDashboardCreate (int id, string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsDashboardCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsDashboardCreate(id, projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsDashboardCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsDashboardCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsDashboardCreateWithHttpInfo(id, projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsDashboardCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsdestroy"></a>
# **FeatureFlagsDestroy**
> void FeatureFlagsDestroy (int id, string projectId)



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
    public class FeatureFlagsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.FeatureFlagsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.FeatureFlagsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
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

<a id="featureflagsenrichusagedashboardcreate"></a>
# **FeatureFlagsEnrichUsageDashboardCreate**
> FeatureFlag FeatureFlagsEnrichUsageDashboardCreate (int id, string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsEnrichUsageDashboardCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsEnrichUsageDashboardCreate(id, projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsEnrichUsageDashboardCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsEnrichUsageDashboardCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsEnrichUsageDashboardCreateWithHttpInfo(id, projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsEnrichUsageDashboardCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsevaluationreasonsretrieve"></a>
# **FeatureFlagsEvaluationReasonsRetrieve**
> FeatureFlag FeatureFlagsEvaluationReasonsRetrieve (string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsEvaluationReasonsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsEvaluationReasonsRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsEvaluationReasonsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsEvaluationReasonsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsEvaluationReasonsRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsEvaluationReasonsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagslist"></a>
# **FeatureFlagsList**
> PaginatedFeatureFlagList FeatureFlagsList (string projectId, int? limit = null, int? offset = null)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedFeatureFlagList result = apiInstance.FeatureFlagsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedFeatureFlagList> response = apiInstance.FeatureFlagsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsListWithHttpInfo: " + e.Message);
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

[**PaginatedFeatureFlagList**](PaginatedFeatureFlagList.md)

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

<a id="featureflagslocalevaluationretrieve"></a>
# **FeatureFlagsLocalEvaluationRetrieve**
> FeatureFlag FeatureFlagsLocalEvaluationRetrieve (string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsLocalEvaluationRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsLocalEvaluationRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsLocalEvaluationRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsLocalEvaluationRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsLocalEvaluationRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsLocalEvaluationRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsmyflagsretrieve"></a>
# **FeatureFlagsMyFlagsRetrieve**
> FeatureFlag FeatureFlagsMyFlagsRetrieve (string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsMyFlagsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsMyFlagsRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsMyFlagsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsMyFlagsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsMyFlagsRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsMyFlagsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagspartialupdate"></a>
# **FeatureFlagsPartialUpdate**
> FeatureFlag FeatureFlagsPartialUpdate (int id, string projectId, PatchedFeatureFlag patchedFeatureFlag = null)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedFeatureFlag = new PatchedFeatureFlag(); // PatchedFeatureFlag |  (optional) 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsPartialUpdate(id, projectId, patchedFeatureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsPartialUpdateWithHttpInfo(id, projectId, patchedFeatureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedFeatureFlag** | [**PatchedFeatureFlag**](PatchedFeatureFlag.md) |  | [optional]  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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
            var apiInstance = new FeatureFlagsApi(config);
            var featureFlagKey = "featureFlagKey_example";  // string | 
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.FeatureFlagsRetrieve(featureFlagKey, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRetrieveWithHttpInfo: " + e.Message);
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

<a id="featureflagsretrieve2"></a>
# **FeatureFlagsRetrieve2**
> FeatureFlag FeatureFlagsRetrieve2 (int id, string projectId)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRetrieve2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsRetrieve2(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRetrieve2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRetrieve2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsRetrieve2WithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRetrieve2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsroleaccesscreate"></a>
# **FeatureFlagsRoleAccessCreate**
> FeatureFlagRoleAccess FeatureFlagsRoleAccessCreate (string parentLookupFeatureFlagId, string projectId, FeatureFlagRoleAccess featureFlagRoleAccess)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRoleAccessCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var parentLookupFeatureFlagId = "parentLookupFeatureFlagId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlagRoleAccess = new FeatureFlagRoleAccess(); // FeatureFlagRoleAccess | 

            try
            {
                FeatureFlagRoleAccess result = apiInstance.FeatureFlagsRoleAccessCreate(parentLookupFeatureFlagId, projectId, featureFlagRoleAccess);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRoleAccessCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlagRoleAccess> response = apiInstance.FeatureFlagsRoleAccessCreateWithHttpInfo(parentLookupFeatureFlagId, projectId, featureFlagRoleAccess);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupFeatureFlagId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlagRoleAccess** | [**FeatureFlagRoleAccess**](FeatureFlagRoleAccess.md) |  |  |

### Return type

[**FeatureFlagRoleAccess**](FeatureFlagRoleAccess.md)

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

<a id="featureflagsroleaccessdestroy"></a>
# **FeatureFlagsRoleAccessDestroy**
> void FeatureFlagsRoleAccessDestroy (int id, string parentLookupFeatureFlagId, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRoleAccessDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag role access.
            var parentLookupFeatureFlagId = "parentLookupFeatureFlagId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.FeatureFlagsRoleAccessDestroy(id, parentLookupFeatureFlagId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRoleAccessDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.FeatureFlagsRoleAccessDestroyWithHttpInfo(id, parentLookupFeatureFlagId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag role access. |  |
| **parentLookupFeatureFlagId** | **string** |  |  |
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

<a id="featureflagsroleaccesslist"></a>
# **FeatureFlagsRoleAccessList**
> PaginatedFeatureFlagRoleAccessList FeatureFlagsRoleAccessList (string parentLookupFeatureFlagId, string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRoleAccessListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var parentLookupFeatureFlagId = "parentLookupFeatureFlagId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedFeatureFlagRoleAccessList result = apiInstance.FeatureFlagsRoleAccessList(parentLookupFeatureFlagId, projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRoleAccessListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedFeatureFlagRoleAccessList> response = apiInstance.FeatureFlagsRoleAccessListWithHttpInfo(parentLookupFeatureFlagId, projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupFeatureFlagId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |

### Return type

[**PaginatedFeatureFlagRoleAccessList**](PaginatedFeatureFlagRoleAccessList.md)

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

<a id="featureflagsroleaccessretrieve"></a>
# **FeatureFlagsRoleAccessRetrieve**
> FeatureFlagRoleAccess FeatureFlagsRoleAccessRetrieve (int id, string parentLookupFeatureFlagId, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsRoleAccessRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag role access.
            var parentLookupFeatureFlagId = "parentLookupFeatureFlagId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                FeatureFlagRoleAccess result = apiInstance.FeatureFlagsRoleAccessRetrieve(id, parentLookupFeatureFlagId, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsRoleAccessRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlagRoleAccess> response = apiInstance.FeatureFlagsRoleAccessRetrieveWithHttpInfo(id, parentLookupFeatureFlagId, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsRoleAccessRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag role access. |  |
| **parentLookupFeatureFlagId** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**FeatureFlagRoleAccess**](FeatureFlagRoleAccess.md)

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

<a id="featureflagsupdate"></a>
# **FeatureFlagsUpdate**
> FeatureFlag FeatureFlagsUpdate (int id, string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var id = 56;  // int | A unique integer value identifying this feature flag.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsUpdate(id, projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsUpdateWithHttpInfo(id, projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this feature flag. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

<a id="featureflagsuserblastradiuscreate"></a>
# **FeatureFlagsUserBlastRadiusCreate**
> FeatureFlag FeatureFlagsUserBlastRadiusCreate (string projectId, FeatureFlag featureFlag)



Create, read, update and delete feature flags. [See docs](https://posthog.com/docs/user-guides/feature-flags) for more information on feature flags.  If you're looking to use feature flags on your application, you can either use our JavaScript Library or our dedicated endpoint to check if feature flags are enabled for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class FeatureFlagsUserBlastRadiusCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var featureFlag = new FeatureFlag(); // FeatureFlag | 

            try
            {
                FeatureFlag result = apiInstance.FeatureFlagsUserBlastRadiusCreate(projectId, featureFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsUserBlastRadiusCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeatureFlagsUserBlastRadiusCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlag> response = apiInstance.FeatureFlagsUserBlastRadiusCreateWithHttpInfo(projectId, featureFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.FeatureFlagsUserBlastRadiusCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **featureFlag** | [**FeatureFlag**](FeatureFlag.md) |  |  |

### Return type

[**FeatureFlag**](FeatureFlag.md)

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

