/*
 * PostHog API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DotPostHog.Client.OpenAPIDateConverter;

namespace DotPostHog.Model
{
    /// <summary>
    /// PostHogGenericInsights
    /// </summary>
    [DataContract(Name = "GenericInsights")]
    public partial class PostHogGenericInsights : IEquatable<PostHogGenericInsights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogGenericInsights" /> class.
        /// </summary>
        /// <param name="events">Events to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required..</param>
        /// <param name="actions">Actions to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required..</param>
        /// <param name="properties">properties.</param>
        /// <param name="filterTestAccounts">Whether to filter out internal and test accounts. See \&quot;project settings\&quot; in your PostHog account for the filters. (default to false).</param>
        /// <param name="dateFrom">What date to filter the results from. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. (default to &quot;-7d&quot;).</param>
        /// <param name="dateTo">What date to filter the results to. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. (default to &quot;-7d&quot;).</param>
        public PostHogGenericInsights(List<PostHogFilterEvent> events = default(List<PostHogFilterEvent>), List<PostHogFilterAction> actions = default(List<PostHogFilterAction>), PostHogProperty properties = default(PostHogProperty), bool filterTestAccounts = false, string dateFrom = @"-7d", string dateTo = @"-7d")
        {
            this.Events = events;
            this.Actions = actions;
            this.Properties = properties;
            this.FilterTestAccounts = filterTestAccounts;
            // use default value if no "dateFrom" provided
            this.DateFrom = dateFrom ?? @"-7d";
            // use default value if no "dateTo" provided
            this.DateTo = dateTo ?? @"-7d";
        }

        /// <summary>
        /// Events to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required.
        /// </summary>
        /// <value>Events to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required.</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<PostHogFilterEvent> Events { get; set; }

        /// <summary>
        /// Actions to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required.
        /// </summary>
        /// <value>Actions to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required.</value>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public List<PostHogFilterAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public PostHogProperty Properties { get; set; }

        /// <summary>
        /// Whether to filter out internal and test accounts. See \&quot;project settings\&quot; in your PostHog account for the filters.
        /// </summary>
        /// <value>Whether to filter out internal and test accounts. See \&quot;project settings\&quot; in your PostHog account for the filters.</value>
        [DataMember(Name = "filter_test_accounts", EmitDefaultValue = true)]
        public bool FilterTestAccounts { get; set; }

        /// <summary>
        /// What date to filter the results from. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year.
        /// </summary>
        /// <value>What date to filter the results from. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year.</value>
        [DataMember(Name = "date_from", EmitDefaultValue = false)]
        public string DateFrom { get; set; }

        /// <summary>
        /// What date to filter the results to. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year.
        /// </summary>
        /// <value>What date to filter the results to. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year.</value>
        [DataMember(Name = "date_to", EmitDefaultValue = false)]
        public string DateTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogGenericInsights {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  FilterTestAccounts: ").Append(FilterTestAccounts).Append("\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostHogGenericInsights);
        }

        /// <summary>
        /// Returns true if PostHogGenericInsights instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogGenericInsights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogGenericInsights input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.FilterTestAccounts == input.FilterTestAccounts ||
                    this.FilterTestAccounts.Equals(input.FilterTestAccounts)
                ) && 
                (
                    this.DateFrom == input.DateFrom ||
                    (this.DateFrom != null &&
                    this.DateFrom.Equals(input.DateFrom))
                ) && 
                (
                    this.DateTo == input.DateTo ||
                    (this.DateTo != null &&
                    this.DateTo.Equals(input.DateTo))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FilterTestAccounts.GetHashCode();
                if (this.DateFrom != null)
                {
                    hashCode = (hashCode * 59) + this.DateFrom.GetHashCode();
                }
                if (this.DateTo != null)
                {
                    hashCode = (hashCode * 59) + this.DateTo.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
