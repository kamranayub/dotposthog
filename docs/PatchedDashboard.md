# DotPostHog.Model.PatchedDashboard
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Pinned** | **bool** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [optional] [readonly] 
**IsShared** | **bool** |  | [optional] [readonly] 
**Deleted** | **bool** |  | [optional] 
**CreationMode** | **string** |  | [optional] [readonly] 
**UseTemplate** | **string** |  | [optional] 
**UseDashboard** | **int?** |  | [optional] 
**DeleteInsights** | **bool** |  | [optional] [default to false]
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**Tiles** | **string** |  | [optional] [readonly] 
**RestrictionLevel** | **int** |  | [optional] 
**EffectiveRestrictionLevel** | **int** |  | [optional] [readonly] 
**EffectivePrivilegeLevel** | **int** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

