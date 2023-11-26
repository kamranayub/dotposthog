# DotPostHog.Model.PatchedAction
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**PostToSlack** | **bool** |  | [optional] 
**SlackMessageFormat** | **string** |  | [optional] 
**Steps** | [**List&lt;ActionStep&gt;**](ActionStep.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [optional] [readonly] 
**Deleted** | **bool** |  | [optional] 
**IsCalculating** | **bool** |  | [optional] [readonly] 
**LastCalculatedAt** | **DateTime** |  | [optional] 
**TeamId** | **int** |  | [optional] [readonly] 
**IsAction** | **bool** |  | [optional] [readonly] [default to true]
**BytecodeError** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

