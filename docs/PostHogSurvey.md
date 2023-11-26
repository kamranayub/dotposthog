# DotPostHog.Model.PostHogSurvey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**Type** | **string** |  | 
**LinkedFlag** | [**PostHogMinimalFeatureFlag**](PostHogMinimalFeatureFlag.md) |  | [readonly] 
**LinkedFlagId** | **int?** |  | [optional] 
**TargetingFlag** | [**PostHogMinimalFeatureFlag**](PostHogMinimalFeatureFlag.md) |  | [readonly] 
**Questions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Conditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Appearance** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [readonly] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**Archived** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

