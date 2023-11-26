# DotPostHog.Model.PostHogPatchedInsight
Simplified serializer to speed response times when loading large amounts of objects.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**ShortId** | **string** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**DerivedName** | **string** |  | [optional] 
**Filters** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Query** | **Dictionary&lt;string, Object&gt;** | Query node JSON string | [optional] 
**Order** | **int?** |  | [optional] 
**Deleted** | **bool** |  | [optional] 
**Dashboards** | **List&lt;int&gt;** |          DEPRECATED. Will be removed in a future release. Use dashboard_tiles instead.         A dashboard ID for each of the dashboards that this insight is displayed on.          | [optional] 
**DashboardTiles** | [**List&lt;PostHogDashboardTileBasic&gt;**](PostHogDashboardTileBasic.md) |      A dashboard tile ID and dashboard_id for each of the dashboards that this insight is displayed on.      | [optional] [readonly] 
**LastRefresh** | **string** |      The datetime this insight&#39;s results were generated.     If added to one or more dashboards the insight can be refreshed separately on each.     Returns the appropriate last_refresh datetime for the context the insight is viewed in     (see from_dashboard query parameter).      | [optional] [readonly] 
**NextAllowedClientRefresh** | **string** |      The earliest possible datetime at which we&#39;ll allow the cached results for this insight to be refreshed     by querying the database.      | [optional] [readonly] 
**Result** | **string** |  | [optional] [readonly] 
**CreatedAt** | **DateTime?** |  | [optional] [readonly] 
**CreatedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**Description** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Tags** | **List&lt;Object&gt;** |  | [optional] 
**Favorited** | **bool** |  | [optional] 
**Saved** | **bool** |  | [optional] 
**LastModifiedAt** | **DateTime** |  | [optional] [readonly] 
**LastModifiedBy** | [**PostHogUserBasic**](PostHogUserBasic.md) |  | [optional] [readonly] 
**IsSample** | **bool** |  | [optional] [readonly] 
**EffectiveRestrictionLevel** | **int** |  | [optional] [readonly] 
**EffectivePrivilegeLevel** | **int** |  | [optional] [readonly] 
**Timezone** | **string** | The timezone this chart is displayed in. | [optional] [readonly] 
**IsCached** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

