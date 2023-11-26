# DotPostHog.Model.PostHogPatchedExperiment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**FeatureFlagKey** | **string** |  | [optional] 
**FeatureFlag** | [**PostHogMinimalFeatureFlag**](PostHogMinimalFeatureFlag.md) |  | [optional] [readonly] 
**Parameters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**SecondaryMetrics** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Archived** | **bool** |  | [optional] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

