# DotPostHog.Model.PostHogDashboardBasic
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | [readonly] 
**Description** | **string** |  | [readonly] 
**Pinned** | **bool** |  | [readonly] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [readonly] 
**IsShared** | **bool** |  | [readonly] 
**Deleted** | **bool** |  | [readonly] 
**CreationMode** | **string** |  | [readonly] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**RestrictionLevel** | **int** |  | [readonly] 
**EffectiveRestrictionLevel** | **int** |  | [readonly] 
**EffectivePrivilegeLevel** | **int** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

