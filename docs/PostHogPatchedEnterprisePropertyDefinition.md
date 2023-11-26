# DotPostHog.Model.PostHogPatchedEnterprisePropertyDefinition
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] [readonly] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**IsNumerical** | **bool** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**IsSeenOnFilteredEvents** | **string** |  | [optional] [readonly] 
**PropertyType** | **string** |  | [optional] 
**Verified** | **bool** |  | [optional] 
**VerifiedAt** | **DateTime?** |  | [optional] [readonly] 
**VerifiedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

