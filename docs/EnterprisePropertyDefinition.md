# DotPostHog.Model.EnterprisePropertyDefinition
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Name** | **string** |  | [readonly] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**IsNumerical** | **bool** |  | [readonly] 
**UpdatedAt** | **DateTime** |  | [readonly] 
**UpdatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**IsSeenOnFilteredEvents** | **string** |  | [readonly] 
**PropertyType** | **string** |  | [optional] 
**Verified** | **bool** |  | [optional] 
**VerifiedAt** | **DateTime?** |  | [readonly] 
**VerifiedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

