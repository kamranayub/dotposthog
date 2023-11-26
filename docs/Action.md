# DotPostHog.Model.Action
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**PostToSlack** | **bool** |  | [optional] 
**SlackMessageFormat** | **string** |  | [optional] 
**Steps** | [**List&lt;ActionStep&gt;**](ActionStep.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**Deleted** | **bool** |  | [optional] 
**IsCalculating** | **bool** |  | [readonly] 
**LastCalculatedAt** | **DateTime** |  | [optional] 
**TeamId** | **int** |  | [readonly] 
**IsAction** | **bool** |  | [readonly] [default to true]
**BytecodeError** | **string** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

