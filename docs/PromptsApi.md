# DotPostHog.Api.PromptsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PromptsMyPromptsPartialUpdate**](PromptsApi.md#promptsmypromptspartialupdate) | **PATCH** /api/prompts/my_prompts/ |  |
| [**PromptsMyPromptsPartialUpdate_0**](PromptsApi.md#promptsmypromptspartialupdate_0) | **PATCH** /api/prompts/my_prompts/ |  |

<a id="promptsmypromptspartialupdate"></a>
# **PromptsMyPromptsPartialUpdate**
> void PromptsMyPromptsPartialUpdate ()



Create, read, update and delete prompt sequences state for a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PromptsMyPromptsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PromptsApi(config);

            try
            {
                apiInstance.PromptsMyPromptsPartialUpdate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromptsApi.PromptsMyPromptsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromptsMyPromptsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PromptsMyPromptsPartialUpdateWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromptsApi.PromptsMyPromptsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="promptsmypromptspartialupdate_0"></a>
# **PromptsMyPromptsPartialUpdate_0**
> void PromptsMyPromptsPartialUpdate_0 ()



Create, read, update and delete prompt sequences state for a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class PromptsMyPromptsPartialUpdate_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PromptsApi(config);

            try
            {
                apiInstance.PromptsMyPromptsPartialUpdate_0();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromptsApi.PromptsMyPromptsPartialUpdate_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromptsMyPromptsPartialUpdate_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PromptsMyPromptsPartialUpdate_0WithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromptsApi.PromptsMyPromptsPartialUpdate_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

