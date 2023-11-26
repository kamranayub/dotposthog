# DotPostHog.Model.PostHogPatchedSubscription
Standard Subscription serializer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Dashboard** | **int?** |  | [optional] 
**Insight** | **int?** |  | [optional] 
**TargetType** | **string** |  | [optional] 
**TargetValue** | **string** |  | [optional] 
**Frequency** | **string** |  | [optional] 
**Interval** | **int** |  | [optional] 
**Byweekday** | **List&lt;PostHogPatchedSubscription.ByweekdayEnum&gt;** |  | [optional] 
**Bysetpos** | **int?** |  | [optional] 
**Count** | **int?** |  | [optional] 
**StartDate** | **DateTime** |  | [optional] 
**UntilDate** | **DateTime?** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**Deleted** | **bool** |  | [optional] 
**Title** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] [readonly] 
**NextDeliveryDate** | **DateTime?** |  | [optional] [readonly] 
**InviteMessage** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

