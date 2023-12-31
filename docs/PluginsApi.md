# DotPostHog.Api.PluginsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PluginsActivityRetrieve**](PluginsApi.md#pluginsactivityretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/activity/ |  |
| [**PluginsCheckForUpdatesRetrieve**](PluginsApi.md#pluginscheckforupdatesretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/check_for_updates/ |  |
| [**PluginsCreate**](PluginsApi.md#pluginscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/plugins/ |  |
| [**PluginsDestroy**](PluginsApi.md#pluginsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsList**](PluginsApi.md#pluginslist) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/ |  |
| [**PluginsPartialUpdate**](PluginsApi.md#pluginspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsRepositoryRetrieve**](PluginsApi.md#pluginsrepositoryretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/repository/ |  |
| [**PluginsRetrieve**](PluginsApi.md#pluginsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsSourceRetrieve**](PluginsApi.md#pluginssourceretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/source/ |  |
| [**PluginsUnusedRetrieve**](PluginsApi.md#pluginsunusedretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/plugins/unused/ |  |
| [**PluginsUpdate**](PluginsApi.md#pluginsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/ |  |
| [**PluginsUpdateSourcePartialUpdate**](PluginsApi.md#pluginsupdatesourcepartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/update_source/ |  |
| [**PluginsUpgradeCreate**](PluginsApi.md#pluginsupgradecreate) | **POST** /api/organizations/{parent_lookup_organization_id}/plugins/{id}/upgrade/ |  |

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
            var apiInstance = new PluginsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsActivityRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsActivityRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsActivityRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsCheckForUpdatesRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsCheckForUpdatesRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsCheckForUpdatesRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPlugin = new PostHogPlugin(); // PostHogPlugin |  (optional) 

            try
            {
                PostHogPlugin result = apiInstance.PluginsCreate(parentLookupOrganizationId, postHogPlugin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsCreate: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsCreateWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.PluginsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsDestroy: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsDestroyWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
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
                Debug.Print("Exception when calling PluginsApi.PluginsList: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsListWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
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
                Debug.Print("Exception when calling PluginsApi.PluginsPartialUpdate: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsPartialUpdateWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsRepositoryRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsRepositoryRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsRepositoryRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var id = 56;  // int | A unique integer value identifying this plugin.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsSourceRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsSourceRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsSourceRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogPlugin result = apiInstance.PluginsUnusedRetrieve(parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsUnusedRetrieve: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsUnusedRetrieveWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
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
                Debug.Print("Exception when calling PluginsApi.PluginsUpdate: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsUpdateWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
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
                Debug.Print("Exception when calling PluginsApi.PluginsUpdateSourcePartialUpdate: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsUpdateSourcePartialUpdateWithHttpInfo: " + e.Message);
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
            var apiInstance = new PluginsApi(config);
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
                Debug.Print("Exception when calling PluginsApi.PluginsUpgradeCreate: " + e.Message);
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
    Debug.Print("Exception when calling PluginsApi.PluginsUpgradeCreateWithHttpInfo: " + e.Message);
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

