# DotPostHog.Model.Subscription
Standard Subscription serializer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Dashboard** | **int?** |  | [optional] 
**Insight** | **int?** |  | [optional] 
**TargetType** | **string** |  | 
**TargetValue** | **string** |  | 
**Frequency** | **string** |  | 
**Interval** | **int** |  | [optional] 
**Byweekday** | **List&lt;Subscription.ByweekdayEnum&gt;** |  | [optional] 
**Bysetpos** | **int?** |  | [optional] 
**Count** | **int?** |  | [optional] 
**StartDate** | **DateTime** |  | 
**UntilDate** | **DateTime?** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**Deleted** | **bool** |  | [optional] 
**Title** | **string** |  | [optional] 
**Summary** | **string** |  | [readonly] 
**NextDeliveryDate** | **DateTime?** |  | [readonly] 
**InviteMessage** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

