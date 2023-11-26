# DotPostHog.Model.FeatureFlag
Serializer mixin that resolves appropriate response for tags depending on license.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [readonly] 
**Name** | **string** | contains the description for the flag (field name &#x60;name&#x60; is kept for backwards-compatibility) | [optional] 
**Key** | **string** |  | 
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Deleted** | **bool** |  | [optional] 
**Active** | **bool** |  | [optional] 
**CreatedBy** | [**UserBasic**](UserBasic.md) |  | [readonly] 
**CreatedAt** | **DateTime** |  | [optional] 
**IsSimpleFlag** | **bool** |  | [readonly] 
**RolloutPercentage** | **int?** |  | [readonly] 
**EnsureExperienceContinuity** | **bool?** |  | [optional] 
**ExperimentSet** | **List&lt;int&gt;** |  | [readonly] 
**Surveys** | **Dictionary&lt;string, Object&gt;** |  | [readonly] 
**Features** | **Dictionary&lt;string, Object&gt;** |  | [readonly] 
**RollbackConditions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**PerformedRollback** | **bool?** |  | [optional] 
**CanEdit** | **bool** |  | [readonly] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**UsageDashboard** | **int** |  | [readonly] 
**AnalyticsDashboards** | **List&lt;int&gt;** |  | [optional] 
**HasEnrichedAnalytics** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

