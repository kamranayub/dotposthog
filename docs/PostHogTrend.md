# DotPostHog.Model.PostHogTrend

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
**Display** | **string** | How to display the data. Will change how the data is returned. | [optional] [default to DisplayEnum.ActionsLineGraph]
**Formula** | **string** | Combine the result of events or actions into a single number. For example &#x60;A + B&#x60; or &#x60;(A-B)/B&#x60;. The letters correspond to the order of the &#x60;events&#x60; or &#x60;actions&#x60; lists. | [optional] 
**Compare** | **bool** | For each returned result show the current period and the previous period. The result will contain &#x60;compare:true&#x60; and a &#x60;compare_label&#x60; with either &#x60;current&#x60; or &#x60;previous&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

