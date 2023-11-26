# DotPostHog.Model.PostHogPatchedBatchExport
Serializer for a BatchExport model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Name** | **string** | A human-readable name for this BatchExport. | [optional] 
**Destination** | [**PostHogBatchExportDestination**](PostHogBatchExportDestination.md) |  | [optional] 
**Interval** | **string** |  | [optional] 
**Paused** | **bool** | Whether this BatchExport is paused or not. | [optional] 
**CreatedAt** | **DateTime** | The timestamp at which this BatchExport was created. | [optional] [readonly] 
**LastUpdatedAt** | **DateTime** | The timestamp at which this BatchExport was last updated. | [optional] [readonly] 
**LastPausedAt** | **DateTime?** | The timestamp at which this BatchExport was last paused. | [optional] 
**StartAt** | **DateTime?** | Time before which any Batch Export runs won&#39;t be triggered. | [optional] 
**EndAt** | **DateTime?** | Time after which any Batch Export runs won&#39;t be triggered. | [optional] 
**LatestRuns** | [**List&lt;PostHogBatchExportRun&gt;**](PostHogBatchExportRun.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

