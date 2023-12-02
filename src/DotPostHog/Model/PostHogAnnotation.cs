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
    /// PostHogAnnotation
    /// </summary>
    [DataContract(Name = "Annotation")]
    public partial class PostHogAnnotation : IEquatable<PostHogAnnotation>, IValidatableObject
    {
        /// <summary>
        /// Defines CreationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreationTypeEnum
        {
            /// <summary>
            /// Enum USR for value: USR
            /// </summary>
            [EnumMember(Value = "USR")]
            USR = 1,

            /// <summary>
            /// Enum GIT for value: GIT
            /// </summary>
            [EnumMember(Value = "GIT")]
            GIT = 2
        }


        /// <summary>
        /// Gets or Sets CreationType
        /// </summary>
        [DataMember(Name = "creation_type", EmitDefaultValue = false)]
        public CreationTypeEnum? CreationType { get; set; }
        /// <summary>
        /// Defines Scope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Enum DashboardItem for value: dashboard_item
            /// </summary>
            [EnumMember(Value = "dashboard_item")]
            DashboardItem = 1,

            /// <summary>
            /// Enum Project for value: project
            /// </summary>
            [EnumMember(Value = "project")]
            Project = 2,

            /// <summary>
            /// Enum Organization for value: organization
            /// </summary>
            [EnumMember(Value = "organization")]
            Organization = 3
        }


        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogAnnotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogAnnotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogAnnotation" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="dateMarker">dateMarker.</param>
        /// <param name="creationType">creationType.</param>
        /// <param name="dashboardItem">dashboardItem.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="scope">scope.</param>
        public PostHogAnnotation(string content = default(string), DateTime? dateMarker = default(DateTime?), CreationTypeEnum? creationType = default(CreationTypeEnum?), int? dashboardItem = default(int?), bool deleted = default(bool), ScopeEnum? scope = default(ScopeEnum?))
        {
            this.Content = content;
            this.DateMarker = dateMarker;
            this.CreationType = creationType;
            this.DashboardItem = dashboardItem;
            this.Deleted = deleted;
            this.Scope = scope;
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
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets DateMarker
        /// </summary>
        [DataMember(Name = "date_marker", EmitDefaultValue = true)]
        public DateTime? DateMarker { get; set; }

        /// <summary>
        /// Gets or Sets DashboardItem
        /// </summary>
        [DataMember(Name = "dashboard_item", EmitDefaultValue = true)]
        public int? DashboardItem { get; set; }

        /// <summary>
        /// Gets or Sets InsightShortId
        /// </summary>
        [DataMember(Name = "insight_short_id", IsRequired = true, EmitDefaultValue = true)]
        public string InsightShortId { get; private set; }

        /// <summary>
        /// Returns false as InsightShortId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInsightShortId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets InsightName
        /// </summary>
        [DataMember(Name = "insight_name", IsRequired = true, EmitDefaultValue = true)]
        public string InsightName { get; private set; }

        /// <summary>
        /// Returns false as InsightName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInsightName()
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
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogAnnotation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DateMarker: ").Append(DateMarker).Append("\n");
            sb.Append("  CreationType: ").Append(CreationType).Append("\n");
            sb.Append("  DashboardItem: ").Append(DashboardItem).Append("\n");
            sb.Append("  InsightShortId: ").Append(InsightShortId).Append("\n");
            sb.Append("  InsightName: ").Append(InsightName).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as PostHogAnnotation);
        }

        /// <summary>
        /// Returns true if PostHogAnnotation instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogAnnotation input)
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
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.DateMarker == input.DateMarker ||
                    (this.DateMarker != null &&
                    this.DateMarker.Equals(input.DateMarker))
                ) && 
                (
                    this.CreationType == input.CreationType ||
                    this.CreationType.Equals(input.CreationType)
                ) && 
                (
                    this.DashboardItem == input.DashboardItem ||
                    (this.DashboardItem != null &&
                    this.DashboardItem.Equals(input.DashboardItem))
                ) && 
                (
                    this.InsightShortId == input.InsightShortId ||
                    (this.InsightShortId != null &&
                    this.InsightShortId.Equals(input.InsightShortId))
                ) && 
                (
                    this.InsightName == input.InsightName ||
                    (this.InsightName != null &&
                    this.InsightName.Equals(input.InsightName))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.DateMarker != null)
                {
                    hashCode = (hashCode * 59) + this.DateMarker.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreationType.GetHashCode();
                if (this.DashboardItem != null)
                {
                    hashCode = (hashCode * 59) + this.DashboardItem.GetHashCode();
                }
                if (this.InsightShortId != null)
                {
                    hashCode = (hashCode * 59) + this.InsightShortId.GetHashCode();
                }
                if (this.InsightName != null)
                {
                    hashCode = (hashCode * 59) + this.InsightName.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
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
            // Content (string) maxLength
            if (this.Content != null && this.Content.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be less than 400.", new [] { "Content" });
            }

            yield break;
        }
    }

}