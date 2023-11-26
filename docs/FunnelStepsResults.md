# DotPostHog.Model.FunnelStepsResults

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsCached** | **bool** | Whether the result is cached. To force a refresh, pass ?refresh&#x3D;true | 
**LastRefresh** | **DateTime** | If the result is cached, when it was last refreshed. | 
**Timezone** | **string** | Timezone the chart is displayed in | [optional] [default to TimezoneEnum.UTC]
**Result** | [**List&lt;FunnelStepsResult&gt;**](FunnelStepsResult.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

