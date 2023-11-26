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
    /// PatchedOrganizationResourceAccess
    /// </summary>
    [DataContract(Name = "PatchedOrganizationResourceAccess")]
    public partial class PatchedOrganizationResourceAccess : IEquatable<PatchedOrganizationResourceAccess>, IValidatableObject
    {
        /// <summary>
        /// Defines Resource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceEnum
        {
            /// <summary>
            /// Enum FeatureFlags for value: feature flags
            /// </summary>
            [EnumMember(Value = "feature flags")]
            FeatureFlags = 1,

            /// <summary>
            /// Enum Experiments for value: experiments
            /// </summary>
            [EnumMember(Value = "experiments")]
            Experiments = 2,

            /// <summary>
            /// Enum Cohorts for value: cohorts
            /// </summary>
            [EnumMember(Value = "cohorts")]
            Cohorts = 3,

            /// <summary>
            /// Enum DataManagement for value: data management
            /// </summary>
            [EnumMember(Value = "data management")]
            DataManagement = 4,

            /// <summary>
            /// Enum SessionRecordings for value: session recordings
            /// </summary>
            [EnumMember(Value = "session recordings")]
            SessionRecordings = 5,

            /// <summary>
            /// Enum Insights for value: insights
            /// </summary>
            [EnumMember(Value = "insights")]
            Insights = 6,

            /// <summary>
            /// Enum Dashboards for value: dashboards
            /// </summary>
            [EnumMember(Value = "dashboards")]
            Dashboards = 7
        }


        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public ResourceEnum? Resource { get; set; }
        /// <summary>
        /// Defines AccessLevel
        /// </summary>
        public enum AccessLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_21 for value: 21
            /// </summary>
            NUMBER_21 = 21,

            /// <summary>
            /// Enum NUMBER_37 for value: 37
            /// </summary>
            NUMBER_37 = 37
        }


        /// <summary>
        /// Gets or Sets AccessLevel
        /// </summary>
        [DataMember(Name = "access_level", EmitDefaultValue = false)]
        public AccessLevelEnum? AccessLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationResourceAccess" /> class.
        /// </summary>
        /// <param name="resource">resource.</param>
        /// <param name="accessLevel">accessLevel.</param>
        public PatchedOrganizationResourceAccess(ResourceEnum? resource = default(ResourceEnum?), AccessLevelEnum? accessLevel = default(AccessLevelEnum?))
        {
            this.Resource = resource;
            this.AccessLevel = accessLevel;
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
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public Guid Organization { get; private set; }

        /// <summary>
        /// Returns false as Organization should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrganization()
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
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public int? CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
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
            sb.Append("class PatchedOrganizationResourceAccess {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as PatchedOrganizationResourceAccess);
        }

        /// <summary>
        /// Returns true if PatchedOrganizationResourceAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedOrganizationResourceAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedOrganizationResourceAccess input)
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
                    this.Resource == input.Resource ||
                    this.Resource.Equals(input.Resource)
                ) && 
                (
                    this.AccessLevel == input.AccessLevel ||
                    this.AccessLevel.Equals(input.AccessLevel)
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
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
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                hashCode = (hashCode * 59) + this.AccessLevel.GetHashCode();
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
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
