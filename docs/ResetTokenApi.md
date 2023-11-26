# DotPostHog.Api.ResetTokenApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResetTokenPartialUpdate**](ResetTokenApi.md#resettokenpartialupdate) | **PATCH** /api/projects/{id}/reset_token/ |  |

<a id="resettokenpartialupdate"></a>
# **ResetTokenPartialUpdate**
> PostHogTeam ResetTokenPartialUpdate (int id, PostHogPatchedTeam postHogPatchedTeam = null)



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
    public class ResetTokenPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ResetTokenApi(config);
            var id = 56;  // int | A unique integer value identifying this team.
            var postHogPatchedTeam = new PostHogPatchedTeam(); // PostHogPatchedTeam |  (optional) 

            try
            {
                PostHogTeam result = apiInstance.ResetTokenPartialUpdate(id, postHogPatchedTeam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResetTokenApi.ResetTokenPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetTokenPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogTeam> response = apiInstance.ResetTokenPartialUpdateWithHttpInfo(id, postHogPatchedTeam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResetTokenApi.ResetTokenPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | A unique integer value identifying this team. |  |
| **postHogPatchedTeam** | [**PostHogPatchedTeam**](PostHogPatchedTeam.md) |  | [optional]  |

### Return type

[**PostHogTeam**](PostHogTeam.md)

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

