# DotPostHog.Api.PersonsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PersonsActivityRetrieve**](PersonsApi.md#personsactivityretrieve) | **GET** /api/projects/{project_id}/persons/activity/ |  |
| [**PersonsActivityRetrieve2**](PersonsApi.md#personsactivityretrieve2) | **GET** /api/projects/{project_id}/persons/{id}/activity/ |  |
| [**PersonsCohortsRetrieve**](PersonsApi.md#personscohortsretrieve) | **GET** /api/projects/{project_id}/persons/cohorts/ |  |
| [**PersonsDeletePropertyCreate**](PersonsApi.md#personsdeletepropertycreate) | **POST** /api/projects/{project_id}/persons/{id}/delete_property/ |  |
| [**PersonsDestroy**](PersonsApi.md#personsdestroy) | **DELETE** /api/projects/{project_id}/persons/{id}/ |  |
| [**PersonsFunnelCorrelationCreate**](PersonsApi.md#personsfunnelcorrelationcreate) | **POST** /api/projects/{project_id}/persons/funnel/correlation/ |  |
| [**PersonsFunnelCorrelationRetrieve**](PersonsApi.md#personsfunnelcorrelationretrieve) | **GET** /api/projects/{project_id}/persons/funnel/correlation/ |  |
| [**PersonsFunnelCreate**](PersonsApi.md#personsfunnelcreate) | **POST** /api/projects/{project_id}/persons/funnel/ |  |
| [**PersonsFunnelRetrieve**](PersonsApi.md#personsfunnelretrieve) | **GET** /api/projects/{project_id}/persons/funnel/ |  |
| [**PersonsLifecycleRetrieve**](PersonsApi.md#personslifecycleretrieve) | **GET** /api/projects/{project_id}/persons/lifecycle/ |  |
| [**PersonsList**](PersonsApi.md#personslist) | **GET** /api/projects/{project_id}/persons/ |  |
| [**PersonsPartialUpdate**](PersonsApi.md#personspartialupdate) | **PATCH** /api/projects/{project_id}/persons/{id}/ |  |
| [**PersonsPathCreate**](PersonsApi.md#personspathcreate) | **POST** /api/projects/{project_id}/persons/path/ |  |
| [**PersonsPathRetrieve**](PersonsApi.md#personspathretrieve) | **GET** /api/projects/{project_id}/persons/path/ |  |
| [**PersonsPropertiesTimelineRetrieve**](PersonsApi.md#personspropertiestimelineretrieve) | **GET** /api/projects/{project_id}/persons/{id}/properties_timeline/ |  |
| [**PersonsRetentionRetrieve**](PersonsApi.md#personsretentionretrieve) | **GET** /api/projects/{project_id}/persons/retention/ |  |
| [**PersonsRetrieve**](PersonsApi.md#personsretrieve) | **GET** /api/projects/{project_id}/persons/{id}/ |  |
| [**PersonsSplitCreate**](PersonsApi.md#personssplitcreate) | **POST** /api/projects/{project_id}/persons/{id}/split/ |  |
| [**PersonsStickinessRetrieve**](PersonsApi.md#personsstickinessretrieve) | **GET** /api/projects/{project_id}/persons/stickiness/ |  |
| [**PersonsTrendsRetrieve**](PersonsApi.md#personstrendsretrieve) | **GET** /api/projects/{project_id}/persons/trends/ |  |
| [**PersonsUpdate**](PersonsApi.md#personsupdate) | **PUT** /api/projects/{project_id}/persons/{id}/ |  |
| [**PersonsUpdatePropertyCreate**](PersonsApi.md#personsupdatepropertycreate) | **POST** /api/projects/{project_id}/persons/{id}/update_property/ |  |
| [**PersonsValuesRetrieve**](PersonsApi.md#personsvaluesretrieve) | **GET** /api/projects/{project_id}/persons/values/ |  |

<a id="personsactivityretrieve"></a>
# **PersonsActivityRetrieve**
> Person PersonsActivityRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsActivityRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsActivityRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsActivityRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsActivityRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsActivityRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsActivityRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsactivityretrieve2"></a>
# **PersonsActivityRetrieve2**
> Person PersonsActivityRetrieve2 (int id, string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsActivityRetrieve2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsActivityRetrieve2(id, projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsActivityRetrieve2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsActivityRetrieve2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsActivityRetrieve2WithHttpInfo(id, projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsActivityRetrieve2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personscohortsretrieve"></a>
# **PersonsCohortsRetrieve**
> Person PersonsCohortsRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsCohortsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsCohortsRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsCohortsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsCohortsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsCohortsRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsCohortsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsdeletepropertycreate"></a>
# **PersonsDeletePropertyCreate**
> Person PersonsDeletePropertyCreate (string unset, int id, string projectId, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsDeletePropertyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var unset = "unset_example";  // string | Specify the property key to delete
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsDeletePropertyCreate(unset, id, projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsDeletePropertyCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsDeletePropertyCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsDeletePropertyCreateWithHttpInfo(unset, id, projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsDeletePropertyCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unset** | **string** | Specify the property key to delete |  |
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsdestroy"></a>
# **PersonsDestroy**
> void PersonsDestroy (int id, string projectId, bool? deleteEvents = null, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var deleteEvents = false;  // bool? | If true, a task to delete all events associated with this person will be created and queued. The task does not run immediately and instead is batched together and at 5AM UTC every Sunday (controlled by environment variable CLEAR_CLICKHOUSE_REMOVED_DATA_SCHEDULE_CRON) (optional)  (default to false)
            var format = "csv";  // string |  (optional) 

            try
            {
                apiInstance.PersonsDestroy(id, projectId, deleteEvents, format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PersonsDestroyWithHttpInfo(id, projectId, deleteEvents, format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **deleteEvents** | **bool?** | If true, a task to delete all events associated with this person will be created and queued. The task does not run immediately and instead is batched together and at 5AM UTC every Sunday (controlled by environment variable CLEAR_CLICKHOUSE_REMOVED_DATA_SCHEDULE_CRON) | [optional] [default to false] |
| **format** | **string** |  | [optional]  |

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

<a id="personsfunnelcorrelationcreate"></a>
# **PersonsFunnelCorrelationCreate**
> Person PersonsFunnelCorrelationCreate (string projectId, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsFunnelCorrelationCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsFunnelCorrelationCreate(projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsFunnelCorrelationCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsFunnelCorrelationCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsFunnelCorrelationCreateWithHttpInfo(projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsFunnelCorrelationCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsfunnelcorrelationretrieve"></a>
# **PersonsFunnelCorrelationRetrieve**
> Person PersonsFunnelCorrelationRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsFunnelCorrelationRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsFunnelCorrelationRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsFunnelCorrelationRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsFunnelCorrelationRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsFunnelCorrelationRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsFunnelCorrelationRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsfunnelcreate"></a>
# **PersonsFunnelCreate**
> Person PersonsFunnelCreate (string projectId, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsFunnelCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsFunnelCreate(projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsFunnelCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsFunnelCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsFunnelCreateWithHttpInfo(projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsFunnelCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsfunnelretrieve"></a>
# **PersonsFunnelRetrieve**
> Person PersonsFunnelRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsFunnelRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsFunnelRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsFunnelRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsFunnelRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsFunnelRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsFunnelRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personslifecycleretrieve"></a>
# **PersonsLifecycleRetrieve**
> Person PersonsLifecycleRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsLifecycleRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsLifecycleRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsLifecycleRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsLifecycleRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsLifecycleRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsLifecycleRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personslist"></a>
# **PersonsList**
> PaginatedPersonList PersonsList (string projectId, string distinctId = null, string email = null, string format = null, int? limit = null, int? offset = null, List<Property> properties = null, string search = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var distinctId = "distinctId_example";  // string | Filter list by distinct id. (optional) 
            var email = test@test.com;  // string | Filter persons by email (exact match) (optional) 
            var format = "csv";  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var properties = new List<Property>(); // List<Property> | Filter Persons by person properties. (optional) 
            var search = "search_example";  // string | Search persons, either by email (full text search) or distinct_id (exact match). (optional) 

            try
            {
                PaginatedPersonList result = apiInstance.PersonsList(projectId, distinctId, email, format, limit, offset, properties, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedPersonList> response = apiInstance.PersonsListWithHttpInfo(projectId, distinctId, email, format, limit, offset, properties, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **distinctId** | **string** | Filter list by distinct id. | [optional]  |
| **email** | **string** | Filter persons by email (exact match) | [optional]  |
| **format** | **string** |  | [optional]  |
| **limit** | **int?** | Number of results to return per page. | [optional]  |
| **offset** | **int?** | The initial index from which to return the results. | [optional]  |
| **properties** | [**List&lt;Property&gt;**](Property.md) | Filter Persons by person properties. | [optional]  |
| **search** | **string** | Search persons, either by email (full text search) or distinct_id (exact match). | [optional]  |

### Return type

[**PaginatedPersonList**](PaginatedPersonList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personspartialupdate"></a>
# **PersonsPartialUpdate**
> Person PersonsPartialUpdate (int id, string projectId, string format = null, PatchedPerson patchedPerson = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var patchedPerson = new PatchedPerson(); // PatchedPerson |  (optional) 

            try
            {
                Person result = apiInstance.PersonsPartialUpdate(id, projectId, format, patchedPerson);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsPartialUpdateWithHttpInfo(id, projectId, format, patchedPerson);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **patchedPerson** | [**PatchedPerson**](PatchedPerson.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personspathcreate"></a>
# **PersonsPathCreate**
> Person PersonsPathCreate (string projectId, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsPathCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsPathCreate(projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsPathCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsPathCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsPathCreateWithHttpInfo(projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsPathCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personspathretrieve"></a>
# **PersonsPathRetrieve**
> Person PersonsPathRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsPathRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsPathRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsPathRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsPathRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsPathRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsPathRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personspropertiestimelineretrieve"></a>
# **PersonsPropertiesTimelineRetrieve**
> Person PersonsPropertiesTimelineRetrieve (int id, string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsPropertiesTimelineRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsPropertiesTimelineRetrieve(id, projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsPropertiesTimelineRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsPropertiesTimelineRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsPropertiesTimelineRetrieveWithHttpInfo(id, projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsPropertiesTimelineRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsretentionretrieve"></a>
# **PersonsRetentionRetrieve**
> Person PersonsRetentionRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsRetentionRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsRetentionRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsRetentionRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsRetentionRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsRetentionRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsRetentionRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsretrieve"></a>
# **PersonsRetrieve**
> Person PersonsRetrieve (int id, string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsRetrieve(id, projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsRetrieveWithHttpInfo(id, projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personssplitcreate"></a>
# **PersonsSplitCreate**
> Person PersonsSplitCreate (int id, string projectId, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsSplitCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsSplitCreate(id, projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsSplitCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsSplitCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsSplitCreateWithHttpInfo(id, projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsSplitCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsstickinessretrieve"></a>
# **PersonsStickinessRetrieve**
> Person PersonsStickinessRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsStickinessRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsStickinessRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsStickinessRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsStickinessRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsStickinessRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsStickinessRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personstrendsretrieve"></a>
# **PersonsTrendsRetrieve**
> Person PersonsTrendsRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsTrendsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsTrendsRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsTrendsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsTrendsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsTrendsRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsTrendsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsupdate"></a>
# **PersonsUpdate**
> Person PersonsUpdate (int id, string projectId, string format = null, Person person = null)



Only for setting properties on the person. \"properties\" from the request data will be updated via a \"$set\" event. This means that only the properties listed will be updated, but other properties won't be removed nor updated. If you would like to remove a property use the `delete_property` endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsUpdate(id, projectId, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsUpdateWithHttpInfo(id, projectId, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsupdatepropertycreate"></a>
# **PersonsUpdatePropertyCreate**
> Person PersonsUpdatePropertyCreate (int id, string key, string projectId, Object value, string format = null, Person person = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsUpdatePropertyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var id = 56;  // int | A unique integer value identifying this person.
            var key = "key_example";  // string | Specify the property key
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var value = new Object(); // Object | Specify the property value
            var format = "csv";  // string |  (optional) 
            var person = new Person(); // Person |  (optional) 

            try
            {
                Person result = apiInstance.PersonsUpdatePropertyCreate(id, key, projectId, value, format, person);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsUpdatePropertyCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsUpdatePropertyCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsUpdatePropertyCreateWithHttpInfo(id, key, projectId, value, format, person);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsUpdatePropertyCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this person. |  |
| **key** | **string** | Specify the property key |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **value** | [**Object**](Object.md) | Specify the property value |  |
| **format** | **string** |  | [optional]  |
| **person** | [**Person**](Person.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personsvaluesretrieve"></a>
# **PersonsValuesRetrieve**
> Person PersonsValuesRetrieve (string projectId, string format = null)



To create or update persons, use a PostHog library of your choice and [use an identify call](/docs/integrate/identifying-users). This API endpoint is only for reading and deleting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PersonsValuesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PersonsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Person result = apiInstance.PersonsValuesRetrieve(projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PersonsValuesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonsValuesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Person> response = apiInstance.PersonsValuesRetrieveWithHttpInfo(projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonsApi.PersonsValuesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

