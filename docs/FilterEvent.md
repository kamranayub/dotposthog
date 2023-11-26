# DotPostHog.Model.FilterEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Name of the event to filter on. For example &#x60;$pageview&#x60; or &#x60;user sign up&#x60;. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) |  | [optional] 
**Math** | **string** | How to aggregate results, shown as \&quot;counted by\&quot; in the interface. - &#x60;total&#x60; (default): no aggregation, count by events - &#x60;dau&#x60;: count by unique users. Despite the name, if you select the &#x60;interval&#x60; to be weekly or monthly, this will show weekly or monthly active users respectively - &#x60;weekly_active&#x60;: rolling average of users of the last 7 days. - &#x60;monthly_active&#x60;: rolling average of users of the last month. - &#x60;unique_group&#x60;: count by group. Requires &#x60;math_group_type_index&#x60; to be sent. You can get the index by hitting &#x60;/api/projects/@current/groups_types/&#x60;.  All of the below are property aggregations, and require &#x60;math_property&#x60; to be sent with an event property. - &#x60;sum&#x60;: sum of a numeric property. - &#x60;min&#x60;: min of a numeric property. - &#x60;max&#x60;: max of a numeric property. - &#x60;median&#x60;: median of a numeric property. - &#x60;p90&#x60;: 90th percentile of a numeric property. - &#x60;p95&#x60; 95th percentile of a numeric property. - &#x60;p99&#x60;: 99th percentile of a numeric property.  | [optional] [default to MathEnum.Total]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

