# DotPostHog.Model.PostHogBatchExportRun
Serializer for a BatchExportRun model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [readonly] 
**Status** | **string** | The status of this run. | 
**RecordsCompleted** | **int?** | The number of records that have been exported. | [optional] 
**LatestError** | **string** | The latest error that occurred during this run. | [optional] 
**DataIntervalStart** | **DateTime** | The start of the data interval. | 
**DataIntervalEnd** | **DateTime** | The end of the data interval. | 
**Cursor** | **string** | An opaque cursor that may be used to resume. | [optional] 
**CreatedAt** | **DateTime** | The timestamp at which this BatchExportRun was created. | [readonly] 
**FinishedAt** | **DateTime?** | The timestamp at which this BatchExportRun finished, successfully or not. | [optional] 
**LastUpdatedAt** | **DateTime** | The timestamp at which this BatchExportRun was last updated. | [readonly] 
**BatchExport** | **Guid** | The BatchExport this run belongs to. | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

