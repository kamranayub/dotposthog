# DotPostHog.Api.IsGeneratingDemoDataApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IsGeneratingDemoDataRetrieve**](IsGeneratingDemoDataApi.md#isgeneratingdemodataretrieve) | **GET** /api/projects/{id}/is_generating_demo_data/ |  |

<a id="isgeneratingdemodataretrieve"></a>
# **IsGeneratingDemoDataRetrieve**
> PostHogTeam IsGeneratingDemoDataRetrieve (int id)



Projects for the current organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class IsGeneratingDemoDataRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IsGeneratingDemoDataApi(config);
            var id = 56;  // int | A unique integer value identifying this team.

            try
            {
                PostHogTeam result = apiInstance.IsGeneratingDemoDataRetrieve(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IsGeneratingDemoDataApi.IsGeneratingDemoDataRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsGeneratingDemoDataRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogTeam> response = apiInstance.IsGeneratingDemoDataRetrieveWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IsGeneratingDemoDataApi.IsGeneratingDemoDataRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this team. |  |

### Return type

[**PostHogTeam**](PostHogTeam.md)

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

