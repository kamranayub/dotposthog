# DotPostHog.Model.PostHogFunnel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;PostHogFilterEvent&gt;**](PostHogFilterEvent.md) | Events to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required. | [optional] 
**Actions** | [**List&lt;PostHogFilterAction&gt;**](PostHogFilterAction.md) | Actions to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required. | [optional] 
**Properties** | [**PostHogProperty**](PostHogProperty.md) |  | [optional] 
**FilterTestAccounts** | **bool** | Whether to filter out internal and test accounts. See \&quot;project settings\&quot; in your PostHog account for the filters. | [optional] [default to false]
**DateFrom** | **string** | What date to filter the results from. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. | [optional] [default to "-7d"]
**DateTo** | **string** | What date to filter the results to. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. | [optional] [default to "-7d"]
**Breakdown** | **string** | A property or cohort to break down on. You can select the type of the property with breakdown_type. - &#x60;event&#x60; (default): a property key - &#x60;person&#x60;: a person property key - &#x60;cohort&#x60;: an array of cohort IDs (ie &#x60;[9581,5812]&#x60;) | [optional] 
**BreakdownType** | **string** | Type of property to break down on. | [optional] [default to BreakdownTypeEnum.Event]
**FunnelWindowInterval** | **int** | Funnel window size. Set in combination with funnel_window_interval, so defaults to &#39;days&#39;. | [optional] [default to 14]
**FunnelWindowIntervalType** | **string** | The type of interval. Used in combination with &#x60;funnel_window_intervals&#x60;. | [optional] [default to FunnelWindowIntervalTypeEnum.DAY]
**FunnelVizType** | **string** | The visualisation type. - &#x60;steps&#x60; Track instances progress between steps of the funnel - &#x60;trends&#x60; Track how this funnel&#39;s conversion rate is trending over time. - &#x60;time_to_convert&#x60; Track how long it takes for instances to convert | [optional] [default to FunnelVizTypeEnum.Steps]
**FunnelOrderType** | **string** | - &#x60;ordered&#x60; - Step B must happen after Step A, but any number events can happen between A and B. - &#x60;strict&#x60; - Step B must happen directly after Step A without any events in between. - &#x60;unordered&#x60; - Steps can be completed in any sequence. | [optional] [default to FunnelOrderTypeEnum.Ordered]
**Exclusions** | [**List&lt;PostHogFunnelExclusion&gt;**](PostHogFunnelExclusion.md) | Exclude users/groups that completed the specified event between two specific steps. Note that these users/groups will be completely excluded from the entire funnel. | [optional] 
**AggregationGroupTypeIndex** | **int** | Aggregate by users or by groups. &#x60;0&#x60; means user, &#x60;&gt;0&#x60; means a group. See interface for the corresponding ID of the group. | [optional] [default to 0]
**BreakdownLimit** | **int** |  | [optional] [default to 10]
**FunnelWindowDays** | **int** | (DEPRECATED) Funnel window size in days. Use &#x60;funnel_window_interval&#x60; and &#x60;funnel_window_interval_type&#x60; | [optional] [default to 14]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

