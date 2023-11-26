# DotPostHog.Model.Experiment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**FeatureFlagKey** | **string** |  | 
**FeatureFlag** | [**MinimalFeatureFlag**](MinimalFeatureFlag.md) |  | [readonly] 
**Parameters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**SecondaryMetrics** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Archived** | **bool** |  | [optional] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**CreatedAt** | **DateTime** |  | [readonly] 
**UpdatedAt** | **DateTime** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

