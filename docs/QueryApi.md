# DotPostHog.Api.QueryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QueryCreate**](QueryApi.md#querycreate) | **POST** /api/projects/{project_id}/query/ |  |
| [**QueryDestroy**](QueryApi.md#querydestroy) | **DELETE** /api/projects/{project_id}/query/{id}/ |  |
| [**QueryDraftSqlRetrieve**](QueryApi.md#querydraftsqlretrieve) | **GET** /api/projects/{project_id}/query/draft_sql/ |  |
| [**QueryRetrieve**](QueryApi.md#queryretrieve) | **GET** /api/projects/{project_id}/query/{id}/ |  |

<a id="querycreate"></a>
# **QueryCreate**
> void QueryCreate (string projectId, bool? async = null, string clientQueryId = null, string query = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class QueryCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var async = true;  // bool? | (Experimental) Whether to run the query asynchronously. Defaults to False. If True, the `id` of the query can be used to check the status and to cancel it. (optional) 
            var clientQueryId = "clientQueryId_example";  // string | Client provided query ID. Can be used to retrieve the status or cancel the query. (optional) 
            var query = "query_example";  // string | Submit a JSON string representing a query for PostHog data analysis, for example a HogQL query.  Example payload: ``` {\"query\": {\"kind\": \"HogQLQuery\", \"query\": \"select * from events limit 100\"}} ```  For more details on HogQL queries, see the [PostHog HogQL documentation](/docs/hogql#api-access).  (optional) 

            try
            {
                apiInstance.QueryCreate(projectId, async, clientQueryId, query);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryApi.QueryCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.QueryCreateWithHttpInfo(projectId, async, clientQueryId, query);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryApi.QueryCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **async** | **bool?** | (Experimental) Whether to run the query asynchronously. Defaults to False. If True, the &#x60;id&#x60; of the query can be used to check the status and to cancel it. | [optional]  |
| **clientQueryId** | **string** | Client provided query ID. Can be used to retrieve the status or cancel the query. | [optional]  |
| **query** | **string** | Submit a JSON string representing a query for PostHog data analysis, for example a HogQL query.  Example payload: &#x60;&#x60;&#x60; {\&quot;query\&quot;: {\&quot;kind\&quot;: \&quot;HogQLQuery\&quot;, \&quot;query\&quot;: \&quot;select * from events limit 100\&quot;}} &#x60;&#x60;&#x60;  For more details on HogQL queries, see the [PostHog HogQL documentation](/docs/hogql#api-access).  | [optional]  |

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
| **200** | Query results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="querydestroy"></a>
# **QueryDestroy**
> void QueryDestroy (string id, string projectId)



(Experimental)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class QueryDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.QueryDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryApi.QueryDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.QueryDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryApi.QueryDestroyWithHttpInfo: " + e.Message);
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

<a id="querydraftsqlretrieve"></a>
# **QueryDraftSqlRetrieve**
> void QueryDraftSqlRetrieve (string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class QueryDraftSqlRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.QueryDraftSqlRetrieve(projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryApi.QueryDraftSqlRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryDraftSqlRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.QueryDraftSqlRetrieveWithHttpInfo(projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryApi.QueryDraftSqlRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="queryretrieve"></a>
# **QueryRetrieve**
> void QueryRetrieve (string id, string projectId)



(Experimental)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class QueryRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryApi(config);
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.QueryRetrieve(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryApi.QueryRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.QueryRetrieveWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryApi.QueryRetrieveWithHttpInfo: " + e.Message);
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
| **200** | Query status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

