# DotPostHog.Model.BatchExport
Serializer for a BatchExport model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Name** | **string** | A human-readable name for this BatchExport. | 
**Destination** | [**BatchExportDestination**](BatchExportDestination.md) |  | 
**Interval** | **string** |  | 
**Paused** | **bool** | Whether this BatchExport is paused or not. | [optional] 
**CreatedAt** | **DateTime** | The timestamp at which this BatchExport was created. | [readonly] 
**LastUpdatedAt** | **DateTime** | The timestamp at which this BatchExport was last updated. | [readonly] 
**LastPausedAt** | **DateTime?** | The timestamp at which this BatchExport was last paused. | [optional] 
**StartAt** | **DateTime?** | Time before which any Batch Export runs won&#39;t be triggered. | [optional] 
**EndAt** | **DateTime?** | Time after which any Batch Export runs won&#39;t be triggered. | [optional] 
**LatestRuns** | [**List&lt;BatchExportRun&gt;**](BatchExportRun.md) |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

