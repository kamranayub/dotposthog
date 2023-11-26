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
    /// Standard Subscription serializer.
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class PostHogSubscription : IEquatable<PostHogSubscription>, IValidatableObject
    {
        /// <summary>
        /// Defines TargetType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetTypeEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Slack for value: slack
            /// </summary>
            [EnumMember(Value = "slack")]
            Slack = 2,

            /// <summary>
            /// Enum Webhook for value: webhook
            /// </summary>
            [EnumMember(Value = "webhook")]
            Webhook = 3
        }


        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>
        [DataMember(Name = "target_type", IsRequired = true, EmitDefaultValue = true)]
        public TargetTypeEnum TargetType { get; set; }
        /// <summary>
        /// Defines Frequency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 4
        }


        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public FrequencyEnum Frequency { get; set; }
        /// <summary>
        /// Defines Byweekday
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ByweekdayEnum
        {
            /// <summary>
            /// Enum Monday for value: monday
            /// </summary>
            [EnumMember(Value = "monday")]
            Monday = 1,

            /// <summary>
            /// Enum Tuesday for value: tuesday
            /// </summary>
            [EnumMember(Value = "tuesday")]
            Tuesday = 2,

            /// <summary>
            /// Enum Wednesday for value: wednesday
            /// </summary>
            [EnumMember(Value = "wednesday")]
            Wednesday = 3,

            /// <summary>
            /// Enum Thursday for value: thursday
            /// </summary>
            [EnumMember(Value = "thursday")]
            Thursday = 4,

            /// <summary>
            /// Enum Friday for value: friday
            /// </summary>
            [EnumMember(Value = "friday")]
            Friday = 5,

            /// <summary>
            /// Enum Saturday for value: saturday
            /// </summary>
            [EnumMember(Value = "saturday")]
            Saturday = 6,

            /// <summary>
            /// Enum Sunday for value: sunday
            /// </summary>
            [EnumMember(Value = "sunday")]
            Sunday = 7
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogSubscription" /> class.
        /// </summary>
        /// <param name="dashboard">dashboard.</param>
        /// <param name="insight">insight.</param>
        /// <param name="targetType">targetType (required).</param>
        /// <param name="targetValue">targetValue (required).</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="interval">interval.</param>
        /// <param name="byweekday">byweekday.</param>
        /// <param name="bysetpos">bysetpos.</param>
        /// <param name="count">count.</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="untilDate">untilDate.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="title">title.</param>
        /// <param name="inviteMessage">inviteMessage.</param>
        public PostHogSubscription(int? dashboard = default(int?), int? insight = default(int?), TargetTypeEnum targetType = default(TargetTypeEnum), string targetValue = default(string), FrequencyEnum frequency = default(FrequencyEnum), int interval = default(int), List<ByweekdayEnum> byweekday = default(List<ByweekdayEnum>), int? bysetpos = default(int?), int? count = default(int?), DateTime startDate = default(DateTime), DateTime? untilDate = default(DateTime?), bool deleted = default(bool), string title = default(string), string inviteMessage = default(string))
        {
            this.TargetType = targetType;
            // to ensure "targetValue" is required (not null)
            if (targetValue == null)
            {
                throw new ArgumentNullException("targetValue is a required property for PostHogSubscription and cannot be null");
            }
            this.TargetValue = targetValue;
            this.Frequency = frequency;
            this.StartDate = startDate;
            this.Dashboard = dashboard;
            this.Insight = insight;
            this.Interval = interval;
            this.Byweekday = byweekday;
            this.Bysetpos = bysetpos;
            this.Count = count;
            this.UntilDate = untilDate;
            this.Deleted = deleted;
            this.Title = title;
            this.InviteMessage = inviteMessage;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Dashboard
        /// </summary>
        [DataMember(Name = "dashboard", EmitDefaultValue = true)]
        public int? Dashboard { get; set; }

        /// <summary>
        /// Gets or Sets Insight
        /// </summary>
        [DataMember(Name = "insight", EmitDefaultValue = true)]
        public int? Insight { get; set; }

        /// <summary>
        /// Gets or Sets TargetValue
        /// </summary>
        [DataMember(Name = "target_value", IsRequired = true, EmitDefaultValue = true)]
        public string TargetValue { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or Sets Byweekday
        /// </summary>
        [DataMember(Name = "byweekday", EmitDefaultValue = true)]
        public List<PostHogSubscription.ByweekdayEnum> Byweekday { get; set; }

        /// <summary>
        /// Gets or Sets Bysetpos
        /// </summary>
        [DataMember(Name = "bysetpos", EmitDefaultValue = true)]
        public int? Bysetpos { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets UntilDate
        /// </summary>
        [DataMember(Name = "until_date", EmitDefaultValue = true)]
        public DateTime? UntilDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
        public PostHogUserBasic CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = true)]
        public string Summary { get; private set; }

        /// <summary>
        /// Returns false as Summary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSummary()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NextDeliveryDate
        /// </summary>
        [DataMember(Name = "next_delivery_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? NextDeliveryDate { get; private set; }

        /// <summary>
        /// Returns false as NextDeliveryDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextDeliveryDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets InviteMessage
        /// </summary>
        [DataMember(Name = "invite_message", EmitDefaultValue = true)]
        public string InviteMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Dashboard: ").Append(Dashboard).Append("\n");
            sb.Append("  Insight: ").Append(Insight).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  TargetValue: ").Append(TargetValue).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Byweekday: ").Append(Byweekday).Append("\n");
            sb.Append("  Bysetpos: ").Append(Bysetpos).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  UntilDate: ").Append(UntilDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  NextDeliveryDate: ").Append(NextDeliveryDate).Append("\n");
            sb.Append("  InviteMessage: ").Append(InviteMessage).Append("\n");
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
            return this.Equals(input as PostHogSubscription);
        }

        /// <summary>
        /// Returns true if PostHogSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Dashboard == input.Dashboard ||
                    (this.Dashboard != null &&
                    this.Dashboard.Equals(input.Dashboard))
                ) && 
                (
                    this.Insight == input.Insight ||
                    (this.Insight != null &&
                    this.Insight.Equals(input.Insight))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    this.TargetType.Equals(input.TargetType)
                ) && 
                (
                    this.TargetValue == input.TargetValue ||
                    (this.TargetValue != null &&
                    this.TargetValue.Equals(input.TargetValue))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.Byweekday == input.Byweekday ||
                    this.Byweekday != null &&
                    input.Byweekday != null &&
                    this.Byweekday.SequenceEqual(input.Byweekday)
                ) && 
                (
                    this.Bysetpos == input.Bysetpos ||
                    (this.Bysetpos != null &&
                    this.Bysetpos.Equals(input.Bysetpos))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.UntilDate == input.UntilDate ||
                    (this.UntilDate != null &&
                    this.UntilDate.Equals(input.UntilDate))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.NextDeliveryDate == input.NextDeliveryDate ||
                    (this.NextDeliveryDate != null &&
                    this.NextDeliveryDate.Equals(input.NextDeliveryDate))
                ) && 
                (
                    this.InviteMessage == input.InviteMessage ||
                    (this.InviteMessage != null &&
                    this.InviteMessage.Equals(input.InviteMessage))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Dashboard != null)
                {
                    hashCode = (hashCode * 59) + this.Dashboard.GetHashCode();
                }
                if (this.Insight != null)
                {
                    hashCode = (hashCode * 59) + this.Insight.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                if (this.TargetValue != null)
                {
                    hashCode = (hashCode * 59) + this.TargetValue.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.Byweekday != null)
                {
                    hashCode = (hashCode * 59) + this.Byweekday.GetHashCode();
                }
                if (this.Bysetpos != null)
                {
                    hashCode = (hashCode * 59) + this.Bysetpos.GetHashCode();
                }
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.UntilDate != null)
                {
                    hashCode = (hashCode * 59) + this.UntilDate.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.NextDeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.NextDeliveryDate.GetHashCode();
                }
                if (this.InviteMessage != null)
                {
                    hashCode = (hashCode * 59) + this.InviteMessage.GetHashCode();
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
            // Interval (int) maximum
            if (this.Interval > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value less than or equal to 2147483647.", new [] { "Interval" });
            }

            // Interval (int) minimum
            if (this.Interval < (int)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value greater than or equal to -2147483648.", new [] { "Interval" });
            }

            // Bysetpos (int?) maximum
            if (this.Bysetpos > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bysetpos, must be a value less than or equal to 2147483647.", new [] { "Bysetpos" });
            }

            // Bysetpos (int?) minimum
            if (this.Bysetpos < (int?)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bysetpos, must be a value greater than or equal to -2147483648.", new [] { "Bysetpos" });
            }

            // Count (int?) maximum
            if (this.Count > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 2147483647.", new [] { "Count" });
            }

            // Count (int?) minimum
            if (this.Count < (int?)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to -2147483648.", new [] { "Count" });
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 100.", new [] { "Title" });
            }

            yield break;
        }
    }

}
