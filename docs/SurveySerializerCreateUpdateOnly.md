# DotPostHog.Model.SurveySerializerCreateUpdateOnly

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**Type** | **string** |  | 
**LinkedFlag** | [**MinimalFeatureFlag**](MinimalFeatureFlag.md) |  | [readonly] 
**LinkedFlagId** | **int?** |  | [optional] 
**TargetingFlagId** | **int** |  | [optional] 
**TargetingFlag** | [**MinimalFeatureFlag**](MinimalFeatureFlag.md) |  | [readonly] 
**TargetingFlagFilters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**RemoveTargetingFlag** | **bool?** |  | [optional] 
**Questions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Conditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Appearance** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**Archived** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

