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
    /// PostHogFeatureFlagRoleAccess
    /// </summary>
    [DataContract(Name = "FeatureFlagRoleAccess")]
    public partial class PostHogFeatureFlagRoleAccess : IEquatable<PostHogFeatureFlagRoleAccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogFeatureFlagRoleAccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogFeatureFlagRoleAccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogFeatureFlagRoleAccess" /> class.
        /// </summary>
        /// <param name="roleId">roleId (required).</param>
        public PostHogFeatureFlagRoleAccess(Guid roleId = default(Guid))
        {
            this.RoleId = roleId;
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
        /// Gets or Sets FeatureFlag
        /// </summary>
        [DataMember(Name = "feature_flag", IsRequired = true, EmitDefaultValue = true)]
        public PostHogFeatureFlag FeatureFlag { get; private set; }

        /// <summary>
        /// Returns false as FeatureFlag should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFeatureFlag()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public PostHogRole Role { get; private set; }

        /// <summary>
        /// Returns false as Role should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRole()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name = "role_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or Sets AddedAt
        /// </summary>
        [DataMember(Name = "added_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AddedAt { get; private set; }

        /// <summary>
        /// Returns false as AddedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddedAt()
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogFeatureFlagRoleAccess {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FeatureFlag: ").Append(FeatureFlag).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
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
            return this.Equals(input as PostHogFeatureFlagRoleAccess);
        }

        /// <summary>
        /// Returns true if PostHogFeatureFlagRoleAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogFeatureFlagRoleAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogFeatureFlagRoleAccess input)
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
                    this.FeatureFlag == input.FeatureFlag ||
                    (this.FeatureFlag != null &&
                    this.FeatureFlag.Equals(input.FeatureFlag))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.AddedAt == input.AddedAt ||
                    (this.AddedAt != null &&
                    this.AddedAt.Equals(input.AddedAt))
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
                if (this.FeatureFlag != null)
                {
                    hashCode = (hashCode * 59) + this.FeatureFlag.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.RoleId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleId.GetHashCode();
                }
                if (this.AddedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AddedAt.GetHashCode();
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
            yield break;
        }
    }

}
