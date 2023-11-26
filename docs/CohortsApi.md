# DotPostHog.Api.CohortsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CohortsCreate**](CohortsApi.md#cohortscreate) | **POST** /api/projects/{project_id}/cohorts/ |  |
| [**CohortsDestroy**](CohortsApi.md#cohortsdestroy) | **DELETE** /api/projects/{project_id}/cohorts/{id}/ |  |
| [**CohortsDuplicateAsStaticCohortRetrieve**](CohortsApi.md#cohortsduplicateasstaticcohortretrieve) | **GET** /api/projects/{project_id}/cohorts/{id}/duplicate_as_static_cohort/ |  |
| [**CohortsList**](CohortsApi.md#cohortslist) | **GET** /api/projects/{project_id}/cohorts/ |  |
| [**CohortsPartialUpdate**](CohortsApi.md#cohortspartialupdate) | **PATCH** /api/projects/{project_id}/cohorts/{id}/ |  |
| [**CohortsPersonsRetrieve**](CohortsApi.md#cohortspersonsretrieve) | **GET** /api/projects/{project_id}/cohorts/{id}/persons/ |  |
| [**CohortsRetrieve**](CohortsApi.md#cohortsretrieve) | **GET** /api/projects/{project_id}/cohorts/{id}/ |  |
| [**CohortsUpdate**](CohortsApi.md#cohortsupdate) | **PUT** /api/projects/{project_id}/cohorts/{id}/ |  |

<a id="cohortscreate"></a>
# **CohortsCreate**
> Cohort CohortsCreate (string projectId, Cohort cohort = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var cohort = new Cohort(); // Cohort |  (optional) 

            try
            {
                Cohort result = apiInstance.CohortsCreate(projectId, cohort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsCreateWithHttpInfo(projectId, cohort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **cohort** | [**Cohort**](Cohort.md) |  | [optional]  |

### Return type

[**Cohort**](Cohort.md)

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

<a id="cohortsdestroy"></a>
# **CohortsDestroy**
> void CohortsDestroy (int id, string projectId)



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
    public class CohortsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.CohortsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CohortsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
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

<a id="cohortsduplicateasstaticcohortretrieve"></a>
# **CohortsDuplicateAsStaticCohortRetrieve**
> Cohort CohortsDuplicateAsStaticCohortRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsDuplicateAsStaticCohortRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Cohort result = apiInstance.CohortsDuplicateAsStaticCohortRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsDuplicateAsStaticCohortRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsDuplicateAsStaticCohortRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsDuplicateAsStaticCohortRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsDuplicateAsStaticCohortRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Cohort**](Cohort.md)

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

<a id="cohortslist"></a>
# **CohortsList**
> PaginatedCohortList CohortsList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedCohortList result = apiInstance.CohortsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedCohortList> response = apiInstance.CohortsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsListWithHttpInfo: " + e.Message);
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

[**PaginatedCohortList**](PaginatedCohortList.md)

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

<a id="cohortspartialupdate"></a>
# **CohortsPartialUpdate**
> Cohort CohortsPartialUpdate (int id, string projectId, PatchedCohort patchedCohort = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedCohort = new PatchedCohort(); // PatchedCohort |  (optional) 

            try
            {
                Cohort result = apiInstance.CohortsPartialUpdate(id, projectId, patchedCohort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsPartialUpdateWithHttpInfo(id, projectId, patchedCohort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedCohort** | [**PatchedCohort**](PatchedCohort.md) |  | [optional]  |

### Return type

[**Cohort**](Cohort.md)

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

<a id="cohortspersonsretrieve"></a>
# **CohortsPersonsRetrieve**
> Cohort CohortsPersonsRetrieve (int id, string projectId, string format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsPersonsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var format = "csv";  // string |  (optional) 

            try
            {
                Cohort result = apiInstance.CohortsPersonsRetrieve(id, projectId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsPersonsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsPersonsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsPersonsRetrieveWithHttpInfo(id, projectId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsPersonsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **format** | **string** |  | [optional]  |

### Return type

[**Cohort**](Cohort.md)

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

<a id="cohortsretrieve"></a>
# **CohortsRetrieve**
> Cohort CohortsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Cohort result = apiInstance.CohortsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Cohort**](Cohort.md)

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

<a id="cohortsupdate"></a>
# **CohortsUpdate**
> Cohort CohortsUpdate (int id, string projectId, Cohort cohort = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class CohortsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CohortsApi(config);
            var id = 56;  // int | A unique integer value identifying this cohort.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var cohort = new Cohort(); // Cohort |  (optional) 

            try
            {
                Cohort result = apiInstance.CohortsUpdate(id, projectId, cohort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CohortsApi.CohortsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CohortsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Cohort> response = apiInstance.CohortsUpdateWithHttpInfo(id, projectId, cohort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CohortsApi.CohortsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this cohort. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **cohort** | [**Cohort**](Cohort.md) |  | [optional]  |

### Return type

[**Cohort**](Cohort.md)

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

