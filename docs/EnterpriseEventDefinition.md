# DotPostHog.Model.EnterpriseEventDefinition
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Name** | **string** |  | [readonly] 
**Owner** | **int?** |  | [optional] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [readonly] 
**UpdatedAt** | **DateTime** |  | [readonly] 
**UpdatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**LastSeenAt** | **DateTime?** |  | [readonly] 
**LastUpdatedAt** | **DateTime** |  | [readonly] 
**Verified** | **bool** |  | [optional] 
**VerifiedAt** | **DateTime?** |  | [readonly] 
**VerifiedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**IsAction** | **string** |  | [readonly] 
**ActionId** | **int** |  | [readonly] 
**IsCalculating** | **bool** |  | [readonly] 
**LastCalculatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**PostToSlack** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

