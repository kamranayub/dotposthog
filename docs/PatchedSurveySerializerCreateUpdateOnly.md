# DotPostHog.Model.PatchedSurveySerializerCreateUpdateOnly

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**LinkedFlag** | [**MinimalFeatureFlag**](MinimalFeatureFlag.md) |  | [optional] [readonly] 
**LinkedFlagId** | **int?** |  | [optional] 
**TargetingFlagId** | **int** |  | [optional] 
**TargetingFlag** | [**MinimalFeatureFlag**](MinimalFeatureFlag.md) |  | [optional] [readonly] 
**TargetingFlagFilters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoveTargetingFlag** | **bool?** |  | [optional] 
**Questions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Conditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Appearance** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [optional] [readonly] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**Archived** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

