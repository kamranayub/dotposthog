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
    /// PostHogTrendResult
    /// </summary>
    [DataContract(Name = "TrendResult")]
    public partial class PostHogTrendResult : IEquatable<PostHogTrendResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogTrendResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogTrendResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogTrendResult" /> class.
        /// </summary>
        /// <param name="data">The requested counts. (required).</param>
        /// <param name="days">The dates corresponding to the data field above. (required).</param>
        /// <param name="labels">The dates corresponding to the data field above. (required).</param>
        /// <param name="filter">filter (required).</param>
        /// <param name="label">A label describing this result. Will include - The event or action - Breakdown value - If &#x60;compare:true&#x60;, whether it&#39;s &#x60;current&#x60; or &#x60;previous&#x60; (required).</param>
        public PostHogTrendResult(List<int> data = default(List<int>), List<DateTime> days = default(List<DateTime>), List<string> labels = default(List<string>), PostHogGenericInsights filter = default(PostHogGenericInsights), string label = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for PostHogTrendResult and cannot be null");
            }
            this.Data = data;
            // to ensure "days" is required (not null)
            if (days == null)
            {
                throw new ArgumentNullException("days is a required property for PostHogTrendResult and cannot be null");
            }
            this.Days = days;
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new ArgumentNullException("labels is a required property for PostHogTrendResult and cannot be null");
            }
            this.Labels = labels;
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for PostHogTrendResult and cannot be null");
            }
            this.Filter = filter;
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for PostHogTrendResult and cannot be null");
            }
            this.Label = label;
        }

        /// <summary>
        /// The requested counts.
        /// </summary>
        /// <value>The requested counts.</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Data { get; set; }

        /// <summary>
        /// The dates corresponding to the data field above.
        /// </summary>
        /// <value>The dates corresponding to the data field above.</value>
        [DataMember(Name = "days", IsRequired = true, EmitDefaultValue = true)]
        public List<DateTime> Days { get; set; }

        /// <summary>
        /// The dates corresponding to the data field above.
        /// </summary>
        /// <value>The dates corresponding to the data field above.</value>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public PostHogGenericInsights Filter { get; set; }

        /// <summary>
        /// A label describing this result. Will include - The event or action - Breakdown value - If &#x60;compare:true&#x60;, whether it&#39;s &#x60;current&#x60; or &#x60;previous&#x60;
        /// </summary>
        /// <value>A label describing this result. Will include - The event or action - Breakdown value - If &#x60;compare:true&#x60;, whether it&#39;s &#x60;current&#x60; or &#x60;previous&#x60;</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogTrendResult {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as PostHogTrendResult);
        }

        /// <summary>
        /// Returns true if PostHogTrendResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogTrendResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogTrendResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    input.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Days != null)
                {
                    hashCode = (hashCode * 59) + this.Days.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
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