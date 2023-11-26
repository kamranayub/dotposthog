# DotPostHog.Api.ExperimentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExperimentsCreate**](ExperimentsApi.md#experimentscreate) | **POST** /api/projects/{project_id}/experiments/ |  |
| [**ExperimentsDestroy**](ExperimentsApi.md#experimentsdestroy) | **DELETE** /api/projects/{project_id}/experiments/{id}/ |  |
| [**ExperimentsList**](ExperimentsApi.md#experimentslist) | **GET** /api/projects/{project_id}/experiments/ |  |
| [**ExperimentsPartialUpdate**](ExperimentsApi.md#experimentspartialupdate) | **PATCH** /api/projects/{project_id}/experiments/{id}/ |  |
| [**ExperimentsRequiresFlagImplementationRetrieve**](ExperimentsApi.md#experimentsrequiresflagimplementationretrieve) | **GET** /api/projects/{project_id}/experiments/requires_flag_implementation/ |  |
| [**ExperimentsResultsRetrieve**](ExperimentsApi.md#experimentsresultsretrieve) | **GET** /api/projects/{project_id}/experiments/{id}/results/ |  |
| [**ExperimentsRetrieve**](ExperimentsApi.md#experimentsretrieve) | **GET** /api/projects/{project_id}/experiments/{id}/ |  |
| [**ExperimentsSecondaryResultsRetrieve**](ExperimentsApi.md#experimentssecondaryresultsretrieve) | **GET** /api/projects/{project_id}/experiments/{id}/secondary_results/ |  |
| [**ExperimentsUpdate**](ExperimentsApi.md#experimentsupdate) | **PUT** /api/projects/{project_id}/experiments/{id}/ |  |

<a id="experimentscreate"></a>
# **ExperimentsCreate**
> Experiment ExperimentsCreate (string projectId, Experiment experiment)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var experiment = new Experiment(); // Experiment | 

            try
            {
                Experiment result = apiInstance.ExperimentsCreate(projectId, experiment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsCreateWithHttpInfo(projectId, experiment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **experiment** | [**Experiment**](Experiment.md) |  |  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentsdestroy"></a>
# **ExperimentsDestroy**
> void ExperimentsDestroy (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.ExperimentsDestroy(id, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ExperimentsDestroyWithHttpInfo(id, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
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

<a id="experimentslist"></a>
# **ExperimentsList**
> PaginatedExperimentList ExperimentsList (string projectId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PaginatedExperimentList result = apiInstance.ExperimentsList(projectId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginatedExperimentList> response = apiInstance.ExperimentsListWithHttpInfo(projectId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsListWithHttpInfo: " + e.Message);
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

[**PaginatedExperimentList**](PaginatedExperimentList.md)

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

<a id="experimentspartialupdate"></a>
# **ExperimentsPartialUpdate**
> Experiment ExperimentsPartialUpdate (int id, string projectId, PatchedExperiment patchedExperiment = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var patchedExperiment = new PatchedExperiment(); // PatchedExperiment |  (optional) 

            try
            {
                Experiment result = apiInstance.ExperimentsPartialUpdate(id, projectId, patchedExperiment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsPartialUpdateWithHttpInfo(id, projectId, patchedExperiment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **patchedExperiment** | [**PatchedExperiment**](PatchedExperiment.md) |  | [optional]  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentsrequiresflagimplementationretrieve"></a>
# **ExperimentsRequiresFlagImplementationRetrieve**
> Experiment ExperimentsRequiresFlagImplementationRetrieve (string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsRequiresFlagImplementationRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Experiment result = apiInstance.ExperimentsRequiresFlagImplementationRetrieve(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsRequiresFlagImplementationRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsRequiresFlagImplementationRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsRequiresFlagImplementationRetrieveWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsRequiresFlagImplementationRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentsresultsretrieve"></a>
# **ExperimentsResultsRetrieve**
> Experiment ExperimentsResultsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsResultsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Experiment result = apiInstance.ExperimentsResultsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsResultsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsResultsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsResultsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsResultsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentsretrieve"></a>
# **ExperimentsRetrieve**
> Experiment ExperimentsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Experiment result = apiInstance.ExperimentsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentssecondaryresultsretrieve"></a>
# **ExperimentsSecondaryResultsRetrieve**
> Experiment ExperimentsSecondaryResultsRetrieve (int id, string projectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsSecondaryResultsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                Experiment result = apiInstance.ExperimentsSecondaryResultsRetrieve(id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsSecondaryResultsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsSecondaryResultsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsSecondaryResultsRetrieveWithHttpInfo(id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsSecondaryResultsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |

### Return type

[**Experiment**](Experiment.md)

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

<a id="experimentsupdate"></a>
# **ExperimentsUpdate**
> Experiment ExperimentsUpdate (int id, string projectId, Experiment experiment)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class ExperimentsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExperimentsApi(config);
            var id = 56;  // int | A unique integer value identifying this experiment.
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.
            var experiment = new Experiment(); // Experiment | 

            try
            {
                Experiment result = apiInstance.ExperimentsUpdate(id, projectId, experiment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExperimentsApi.ExperimentsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExperimentsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Experiment> response = apiInstance.ExperimentsUpdateWithHttpInfo(id, projectId, experiment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExperimentsApi.ExperimentsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this experiment. |  |
| **projectId** | **string** | Project ID of the project you&#39;re trying to access. To find the ID of the project, make a call to /api/projects/. |  |
| **experiment** | [**Experiment**](Experiment.md) |  |  |

### Return type

[**Experiment**](Experiment.md)

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

