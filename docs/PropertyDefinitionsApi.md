# DotPostHog.Api.PropertyDefinitionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PropertyDefinitionsDestroy**](PropertyDefinitionsApi.md#propertydefinitionsdestroy) | **DELETE** /api/projects/{project_id}/property_definitions/{id}/ |  |
| [**PropertyDefinitionsList**](PropertyDefinitionsApi.md#propertydefinitionslist) | **GET** /api/projects/{project_id}/property_definitions/ |  |
| [**PropertyDefinitionsPartialUpdate**](PropertyDefinitionsApi.md#propertydefinitionspartialupdate) | **PATCH** /api/projects/{project_id}/property_definitions/{id}/ |  |
| [**PropertyDefinitionsRetrieve**](PropertyDefinitionsApi.md#propertydefinitionsretrieve) | **GET** /api/projects/{project_id}/property_definitions/{id}/ |  |
| [**PropertyDefinitionsSeenTogetherRetrieve**](PropertyDefinitionsApi.md#propertydefinitionsseentogetherretrieve) | **GET** /api/projects/{project_id}/property_definitions/seen_together/ |  |
| [**PropertyDefinitionsUpdate**](PropertyDefinitionsApi.md#propertydefinitionsupdate) | **PUT** /api/projects/{project_id}/property_definitions/{id}/ |  |

<a id="propertydefinitionsdestroy"></a>
# **PropertyDefinitionsDestroy**
> void PropertyDefinitionsDestroy (string id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.PropertyDefinitionsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PropertyDefinitionsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
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

<a id="propertydefinitionslist"></a>
# **PropertyDefinitionsList**
> PaginatedEnterprisePropertyDefinitionList PropertyDefinitionsList (string projectId, string eventNames = null, string excludedProperties = null, bool? filterByEventNames = null, int? groupTypeIndex = null, bool? isFeatureFlag = null, bool? isNumerical = null, int? limit = null, int? offset = null, string properties = null, string search = null, string type = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var eventNames = "eventNames_example";  // string | If sent, response value will have `is_seen_on_filtered_events` populated. JSON-encoded (optional) 
            var excludedProperties = "excludedProperties_example";  // string | JSON-encoded list of excluded properties (optional) 
            var filterByEventNames = true;  // bool? | Whether to return only properties for events in `event_names` (optional) 
            var groupTypeIndex = 56;  // int? | What group type is the property for. Only should be set if `type=group` (optional) 
            var isFeatureFlag = true;  // bool? | Whether to return only (or excluding) feature flag properties (optional) 
            var isNumerical = true;  // bool? | Whether to return only (or excluding) numerical property definitions (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var properties = "properties_example";  // string | Comma-separated list of properties to filter (optional) 
            var search = "search_example";  // string | Searches properties by name (optional) 
            var type = "event";  // string | What property definitions to return (optional)  (default to event)

            try
            {
                PaginatedEnterprisePropertyDefinitionList result = apiInstance.PropertyDefinitionsList(projectId, eventNames, excludedProperties, filterByEventNames, groupTypeIndex, isFeatureFlag, isNumerical, limit, offset, properties, search, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedEnterprisePropertyDefinitionList> response = apiInstance.PropertyDefinitionsListWithHttpInfo(projectId, eventNames, excludedProperties, filterByEventNames, groupTypeIndex, isFeatureFlag, isNumerical, limit, offset, properties, search, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **eventNames** | **string** | If sent, response value will have &#x60;is_seen_on_filtered_events&#x60; populated. JSON-encoded | [optional]  |
| **excludedProperties** | **string** | JSON-encoded list of excluded properties | [optional]  |
| **filterByEventNames** | **bool?** | Whether to return only properties for events in &#x60;event_names&#x60; | [optional]  |
| **groupTypeIndex** | **int?** | What group type is the property for. Only should be set if &#x60;type&#x3D;group&#x60; | [optional]  |
| **isFeatureFlag** | **bool?** | Whether to return only (or excluding) feature flag properties | [optional]  |
| **isNumerical** | **bool?** | Whether to return only (or excluding) numerical property definitions | [optional]  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |
| **properties** | **string** | Comma-separated list of properties to filter | [optional]  |
| **search** | **string** | Searches properties by name | [optional]  |
| **type** | **string** | What property definitions to return | [optional] [default to event] |

### Return type

[**PaginatedEnterprisePropertyDefinitionList**](PaginatedEnterprisePropertyDefinitionList.md)

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

<a id="propertydefinitionspartialupdate"></a>
# **PropertyDefinitionsPartialUpdate**
> EnterprisePropertyDefinition PropertyDefinitionsPartialUpdate (string id, string projectId, PatchedEnterprisePropertyDefinition patchedEnterprisePropertyDefinition = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedEnterprisePropertyDefinition = new PatchedEnterprisePropertyDefinition(); // PatchedEnterprisePropertyDefinition |  (optional) 

            try
            {
                EnterprisePropertyDefinition result = apiInstance.PropertyDefinitionsPartialUpdate(id, projectId, patchedEnterprisePropertyDefinition);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EnterprisePropertyDefinition> response = apiInstance.PropertyDefinitionsPartialUpdateWithHttpInfo(id, projectId, patchedEnterprisePropertyDefinition);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedEnterprisePropertyDefinition** | [**PatchedEnterprisePropertyDefinition**](PatchedEnterprisePropertyDefinition.md) |  | [optional]  |

### Return type

[**EnterprisePropertyDefinition**](EnterprisePropertyDefinition.md)

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

<a id="propertydefinitionsretrieve"></a>
# **PropertyDefinitionsRetrieve**
> EnterprisePropertyDefinition PropertyDefinitionsRetrieve (string id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                EnterprisePropertyDefinition result = apiInstance.PropertyDefinitionsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EnterprisePropertyDefinition> response = apiInstance.PropertyDefinitionsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**EnterprisePropertyDefinition**](EnterprisePropertyDefinition.md)

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

<a id="propertydefinitionsseentogetherretrieve"></a>
# **PropertyDefinitionsSeenTogetherRetrieve**
> EnterprisePropertyDefinition PropertyDefinitionsSeenTogetherRetrieve (string projectId)



Allows a caller to provide a list of event names and a single property name Returns a map of the event names to a boolean representing whether that property has ever been seen with that event_name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsSeenTogetherRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                EnterprisePropertyDefinition result = apiInstance.PropertyDefinitionsSeenTogetherRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsSeenTogetherRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsSeenTogetherRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EnterprisePropertyDefinition> response = apiInstance.PropertyDefinitionsSeenTogetherRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsSeenTogetherRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**EnterprisePropertyDefinition**](EnterprisePropertyDefinition.md)

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

<a id="propertydefinitionsupdate"></a>
# **PropertyDefinitionsUpdate**
> EnterprisePropertyDefinition PropertyDefinitionsUpdate (string id, string projectId, EnterprisePropertyDefinition enterprisePropertyDefinition = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PropertyDefinitionsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PropertyDefinitionsApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var enterprisePropertyDefinition = new EnterprisePropertyDefinition(); // EnterprisePropertyDefinition |  (optional) 

            try
            {
                EnterprisePropertyDefinition result = apiInstance.PropertyDefinitionsUpdate(id, projectId, enterprisePropertyDefinition);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PropertyDefinitionsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EnterprisePropertyDefinition> response = apiInstance.PropertyDefinitionsUpdateWithHttpInfo(id, projectId, enterprisePropertyDefinition);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyDefinitionsApi.PropertyDefinitionsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **enterprisePropertyDefinition** | [**EnterprisePropertyDefinition**](EnterprisePropertyDefinition.md) |  | [optional]  |

### Return type

[**EnterprisePropertyDefinition**](EnterprisePropertyDefinition.md)

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

