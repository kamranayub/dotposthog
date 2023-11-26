# DotPostHog.Model.PostHogPatchedSurveySerializerCreateUpdateOnly

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**LinkedFlag** | [**PostHogMinimalFeatureFlag**](PostHogMinimalFeatureFlag.md) |  | [optional] [readonly] 
**LinkedFlagId** | **int?** |  | [optional] 
**TargetingFlagId** | **int** |  | [optional] 
**TargetingFlag** | [**PostHogMinimalFeatureFlag**](PostHogMinimalFeatureFlag.md) |  | [optional] [readonly] 
**TargetingFlagFilters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoveTargetingFlag** | **bool?** |  | [optional] 
**Questions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Conditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Appearance** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**Archived** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

