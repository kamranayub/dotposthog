# DotPostHog.Api.DomainsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DomainsCreate**](DomainsApi.md#domainscreate) | **POST** /api/organizations/{parent_lookup_organization_id}/domains/ |  |
| [**DomainsDestroy**](DomainsApi.md#domainsdestroy) | **DELETE** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsList**](DomainsApi.md#domainslist) | **GET** /api/organizations/{parent_lookup_organization_id}/domains/ |  |
| [**DomainsPartialUpdate**](DomainsApi.md#domainspartialupdate) | **PATCH** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsRetrieve**](DomainsApi.md#domainsretrieve) | **GET** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsUpdate**](DomainsApi.md#domainsupdate) | **PUT** /api/organizations/{parent_lookup_organization_id}/domains/{id}/ |  |
| [**DomainsVerifyCreate**](DomainsApi.md#domainsverifycreate) | **POST** /api/organizations/{parent_lookup_organization_id}/domains/{id}/verify/ |  |

<a id="domainscreate"></a>
# **DomainsCreate**
> PostHogOrganizationDomain DomainsCreate (string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsCreate(parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsCreateWithHttpInfo(parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsdestroy"></a>
# **DomainsDestroy**
> void DomainsDestroy (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                apiInstance.DomainsDestroy(id, parentLookupOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DomainsDestroyWithHttpInfo(id, parentLookupOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
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

<a id="domainslist"></a>
# **DomainsList**
> PostHogPaginatedOrganizationDomainList DomainsList (string parentLookupOrganizationId, int? limit = null, int? offset = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                PostHogPaginatedOrganizationDomainList result = apiInstance.DomainsList(parentLookupOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogPaginatedOrganizationDomainList> response = apiInstance.DomainsListWithHttpInfo(parentLookupOrganizationId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsListWithHttpInfo: " + e.Message);
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

[**PostHogPaginatedOrganizationDomainList**](PostHogPaginatedOrganizationDomainList.md)

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

<a id="domainspartialupdate"></a>
# **DomainsPartialUpdate**
> PostHogOrganizationDomain DomainsPartialUpdate (Guid id, string parentLookupOrganizationId, PostHogPatchedOrganizationDomain postHogPatchedOrganizationDomain = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogPatchedOrganizationDomain = new PostHogPatchedOrganizationDomain(); // PostHogPatchedOrganizationDomain |  (optional) 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsPartialUpdate(id, parentLookupOrganizationId, postHogPatchedOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsPartialUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogPatchedOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogPatchedOrganizationDomain** | [**PostHogPatchedOrganizationDomain**](PostHogPatchedOrganizationDomain.md) |  | [optional]  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsretrieve"></a>
# **DomainsRetrieve**
> PostHogOrganizationDomain DomainsRetrieve (Guid id, string parentLookupOrganizationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsRetrieve(id, parentLookupOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsRetrieveWithHttpInfo(id, parentLookupOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsupdate"></a>
# **DomainsUpdate**
> PostHogOrganizationDomain DomainsUpdate (Guid id, string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsUpdate(id, parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsUpdateWithHttpInfo(id, parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

<a id="domainsverifycreate"></a>
# **DomainsVerifyCreate**
> PostHogOrganizationDomain DomainsVerifyCreate (Guid id, string parentLookupOrganizationId, PostHogOrganizationDomain postHogOrganizationDomain)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DotPostHog.Api;
using DotPostHog.Client;
using DotPostHog.Model;

namespace Example
{
    public class DomainsVerifyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // Guid | A UUID string identifying this domain.
            var parentLookupOrganizationId = "parentLookupOrganizationId_example";  // string | 
            var postHogOrganizationDomain = new PostHogOrganizationDomain(); // PostHogOrganizationDomain | 

            try
            {
                PostHogOrganizationDomain result = apiInstance.DomainsVerifyCreate(id, parentLookupOrganizationId, postHogOrganizationDomain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DomainsVerifyCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DomainsVerifyCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostHogOrganizationDomain> response = apiInstance.DomainsVerifyCreateWithHttpInfo(id, parentLookupOrganizationId, postHogOrganizationDomain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DomainsVerifyCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | A UUID string identifying this domain. |  |
| **parentLookupOrganizationId** | **string** |  |  |
| **postHogOrganizationDomain** | [**PostHogOrganizationDomain**](PostHogOrganizationDomain.md) |  |  |

### Return type

[**PostHogOrganizationDomain**](PostHogOrganizationDomain.md)

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

