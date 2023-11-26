# DotPostHog.Api.AppMetricsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppMetricsErrorDetailsRetrieve**](AppMetricsApi.md#appmetricserrordetailsretrieve) | **GET** /api/projects/{project_id}/app_metrics/{id}/error_details/ |  |
| [**AppMetricsHistoricalExportsRetrieve**](AppMetricsApi.md#appmetricshistoricalexportsretrieve) | **GET** /api/projects/{project_id}/app_metrics/{parent_lookup_plugin_config_id}/historical_exports/ |  |
| [**AppMetricsHistoricalExportsRetrieve2**](AppMetricsApi.md#appmetricshistoricalexportsretrieve2) | **GET** /api/projects/{project_id}/app_metrics/{parent_lookup_plugin_config_id}/historical_exports/{id}/ |  |
| [**AppMetricsRetrieve**](AppMetricsApi.md#appmetricsretrieve) | **GET** /api/projects/{project_id}/app_metrics/{id}/ |  |

<a id="appmetricserrordetailsretrieve"></a>
# **AppMetricsErrorDetailsRetrieve**
> void AppMetricsErrorDetailsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class AppMetricsErrorDetailsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AppMetricsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.AppMetricsErrorDetailsRetrieve(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppMetricsApi.AppMetricsErrorDetailsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppMetricsErrorDetailsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppMetricsErrorDetailsRetrieveWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppMetricsApi.AppMetricsErrorDetailsRetrieveWithHttpInfo: " + e.Message);
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appmetricshistoricalexportsretrieve"></a>
# **AppMetricsHistoricalExportsRetrieve**
> void AppMetricsHistoricalExportsRetrieve (string parentLookupPluginConfigId, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class AppMetricsHistoricalExportsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AppMetricsApi(config);
            var parentLookupPluginConfigId = "parentLookupPluginConfigId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.AppMetricsHistoricalExportsRetrieve(parentLookupPluginConfigId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppMetricsApi.AppMetricsHistoricalExportsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppMetricsHistoricalExportsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppMetricsHistoricalExportsRetrieveWithHttpInfo(parentLookupPluginConfigId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppMetricsApi.AppMetricsHistoricalExportsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupPluginConfigId** | **string** |  |  |
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appmetricshistoricalexportsretrieve2"></a>
# **AppMetricsHistoricalExportsRetrieve2**
> void AppMetricsHistoricalExportsRetrieve2 (string id, string parentLookupPluginConfigId, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class AppMetricsHistoricalExportsRetrieve2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AppMetricsApi(config);
            var id = "id_example";  // string | 
            var parentLookupPluginConfigId = "parentLookupPluginConfigId_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.AppMetricsHistoricalExportsRetrieve2(id, parentLookupPluginConfigId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppMetricsApi.AppMetricsHistoricalExportsRetrieve2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppMetricsHistoricalExportsRetrieve2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppMetricsHistoricalExportsRetrieve2WithHttpInfo(id, parentLookupPluginConfigId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppMetricsApi.AppMetricsHistoricalExportsRetrieve2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **parentLookupPluginConfigId** | **string** |  |  |
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appmetricsretrieve"></a>
# **AppMetricsRetrieve**
> void AppMetricsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class AppMetricsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AppMetricsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin config.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.AppMetricsRetrieve(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppMetricsApi.AppMetricsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppMetricsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppMetricsRetrieveWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppMetricsApi.AppMetricsRetrieveWithHttpInfo: " + e.Message);
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
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

