# DotPostHog.Model.Dashboard
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Pinned** | **bool** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**IsShared** | **bool** |  | [readonly] 
**Deleted** | **bool** |  | [optional] 
**CreationMode** | **string** |  | [readonly] 
**UseTemplate** | **string** |  | [optional] 
**UseDashboard** | **int?** |  | [optional] 
**DeleteInsights** | **bool** |  | [optional] [default to false]
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**Tiles** | **string** |  | [readonly] 
**RestrictionLevel** | **int** |  | [optional] 
**EffectiveRestrictionLevel** | **int** |  | [readonly] 
**EffectivePrivilegeLevel** | **int** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

