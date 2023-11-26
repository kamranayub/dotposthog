# DotPostHog.Api.UploadedMediaApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UploadedMediaCreate**](UploadedMediaApi.md#uploadedmediacreate) | **POST** /api/projects/{project_id}/uploaded_media/ |  |

<a id="uploadedmediacreate"></a>
# **UploadedMediaCreate**
> void UploadedMediaCreate (string projectId)



     When object storage is available this API allows upload of media which can be used, for example, in text cards on dashboards.      Uploaded media must have a content type beginning with 'image/' and be less than 4MB.     

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class UploadedMediaCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UploadedMediaApi(config);
            var projectId = "projectId_example";  // string | Project ID of the project you're trying to access. To find the ID of the project, make a call to /api/projects/.

            try
            {
                apiInstance.UploadedMediaCreate(projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadedMediaApi.UploadedMediaCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadedMediaCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UploadedMediaCreateWithHttpInfo(projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UploadedMediaApi.UploadedMediaCreateWithHttpInfo: " + e.Message);
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
| **201** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

