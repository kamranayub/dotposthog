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
    /// PostHogPatchedExperiment
    /// </summary>
    [DataContract(Name = "PatchedExperiment")]
    public partial class PostHogPatchedExperiment : IEquatable<PostHogPatchedExperiment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogPatchedExperiment" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="featureFlagKey">featureFlagKey.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="secondaryMetrics">secondaryMetrics.</param>
        /// <param name="filters">filters.</param>
        /// <param name="archived">archived.</param>
        public PostHogPatchedExperiment(string name = default(string), string description = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string featureFlagKey = default(string), Dictionary<string, Object> parameters = default(Dictionary<string, Object>), Dictionary<string, Object> secondaryMetrics = default(Dictionary<string, Object>), Dictionary<string, Object> filters = default(Dictionary<string, Object>), bool archived = default(bool))
        {
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FeatureFlagKey = featureFlagKey;
            this.Parameters = parameters;
            this.SecondaryMetrics = secondaryMetrics;
            this.Filters = filters;
            this.Archived = archived;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets FeatureFlagKey
        /// </summary>
        [DataMember(Name = "feature_flag_key", EmitDefaultValue = false)]
        public string FeatureFlagKey { get; set; }

        /// <summary>
        /// Gets or Sets FeatureFlag
        /// </summary>
        [DataMember(Name = "feature_flag", EmitDefaultValue = false)]
        public PostHogMinimalFeatureFlag FeatureFlag { get; private set; }

        /// <summary>
        /// Returns false as FeatureFlag should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFeatureFlag()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, Object> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryMetrics
        /// </summary>
        [DataMember(Name = "secondary_metrics", EmitDefaultValue = true)]
        public Dictionary<string, Object> SecondaryMetrics { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public Dictionary<string, Object> Filters { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
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
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
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
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogPatchedExperiment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FeatureFlagKey: ").Append(FeatureFlagKey).Append("\n");
            sb.Append("  FeatureFlag: ").Append(FeatureFlag).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  SecondaryMetrics: ").Append(SecondaryMetrics).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as PostHogPatchedExperiment);
        }

        /// <summary>
        /// Returns true if PostHogPatchedExperiment instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogPatchedExperiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogPatchedExperiment input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FeatureFlagKey == input.FeatureFlagKey ||
                    (this.FeatureFlagKey != null &&
                    this.FeatureFlagKey.Equals(input.FeatureFlagKey))
                ) && 
                (
                    this.FeatureFlag == input.FeatureFlag ||
                    (this.FeatureFlag != null &&
                    this.FeatureFlag.Equals(input.FeatureFlag))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.SecondaryMetrics == input.SecondaryMetrics ||
                    this.SecondaryMetrics != null &&
                    input.SecondaryMetrics != null &&
                    this.SecondaryMetrics.SequenceEqual(input.SecondaryMetrics)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.FeatureFlagKey != null)
                {
                    hashCode = (hashCode * 59) + this.FeatureFlagKey.GetHashCode();
                }
                if (this.FeatureFlag != null)
                {
                    hashCode = (hashCode * 59) + this.FeatureFlag.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.SecondaryMetrics != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryMetrics.GetHashCode();
                }
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 400.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 400.", new [] { "Description" });
            }

            yield break;
        }
    }

}
