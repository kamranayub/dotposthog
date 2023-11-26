# DotPostHog.Model.PostHogPatchedFeatureFlag
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Name** | **string** | contains the description for the flag (field name &#x60;name&#x60; is kept for backwards-compatibility) | [optional] 
**Key** | **string** |  | [optional] 
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Deleted** | **bool** |  | [optional] 
**Active** | **bool** |  | [optional] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] 
**IsSimpleFlag** | **bool** |  | [optional] [readonly] 
**RolloutPercentage** | **int?** |  | [optional] [readonly] 
**EnsureExperienceContinuity** | **bool?** |  | [optional] 
**ExperimentSet** | **List&lt;int&gt;** |  | [optional] [readonly] 
**Surveys** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**Features** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**RollbackConditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**PerformedRollback** | **bool?** |  | [optional] 
**CanEdit** | **bool** |  | [optional] [readonly] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**UsageDashboard** | **int** |  | [optional] [readonly] 
**AnalyticsDashboards** | **List&lt;int&gt;** |  | [optional] 
**HasEnrichedAnalytics** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

