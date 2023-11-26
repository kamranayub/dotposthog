# DotPostHog.Model.PostHogPatchedEnterpriseEventDefinition
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] [readonly] 
**Owner** | **int?** |  | [optional] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**LastSeenAt** | **DateTime?** |  | [optional] [readonly] 
**LastUpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Verified** | **bool** |  | [optional] 
**VerifiedAt** | **DateTime?** |  | [optional] [readonly] 
**VerifiedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**IsAction** | **string** |  | [optional] [readonly] 
**ActionId** | **int** |  | [optional] [readonly] 
**IsCalculating** | **bool** |  | [optional] [readonly] 
**LastCalculatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**PostToSlack** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

