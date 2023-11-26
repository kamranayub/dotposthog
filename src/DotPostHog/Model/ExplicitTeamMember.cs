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
    /// ExplicitTeamMember
    /// </summary>
    [DataContract(Name = "ExplicitTeamMember")]
    public partial class ExplicitTeamMember : IEquatable<ExplicitTeamMember>, IValidatableObject
    {
        /// <summary>
        /// Defines Level
        /// </summary>
        public enum LevelEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8
        }


        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Defines EffectiveLevel
        /// </summary>
        public enum EffectiveLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8,

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            NUMBER_15 = 15
        }


        /// <summary>
        /// Gets or Sets EffectiveLevel
        /// </summary>
        [DataMember(Name = "effective_level", IsRequired = true, EmitDefaultValue = true)]
        public EffectiveLevelEnum EffectiveLevel { get; set; }

        /// <summary>
        /// Returns false as EffectiveLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEffectiveLevel()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitTeamMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExplicitTeamMember() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExplicitTeamMember" /> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="userUuid">userUuid (required).</param>
        public ExplicitTeamMember(LevelEnum? level = default(LevelEnum?), Guid userUuid = default(Guid))
        {
            this.UserUuid = userUuid;
            this.Level = level;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ParentLevel
        /// </summary>
        [DataMember(Name = "parent_level", IsRequired = true, EmitDefaultValue = true)]
        public int ParentLevel { get; private set; }

        /// <summary>
        /// Returns false as ParentLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentLevel()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ParentMembershipId
        /// </summary>
        [DataMember(Name = "parent_membership_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid ParentMembershipId { get; private set; }

        /// <summary>
        /// Returns false as ParentMembershipId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentMembershipId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets JoinedAt
        /// </summary>
        [DataMember(Name = "joined_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime JoinedAt { get; private set; }

        /// <summary>
        /// Returns false as JoinedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJoinedAt()
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public UserBasic User { get; private set; }

        /// <summary>
        /// Returns false as User should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUser()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UserUuid
        /// </summary>
        [DataMember(Name = "user_uuid", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExplicitTeamMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  ParentLevel: ").Append(ParentLevel).Append("\n");
            sb.Append("  ParentMembershipId: ").Append(ParentMembershipId).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
            sb.Append("  EffectiveLevel: ").Append(EffectiveLevel).Append("\n");
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
            return this.Equals(input as ExplicitTeamMember);
        }

        /// <summary>
        /// Returns true if ExplicitTeamMember instances are equal
        /// </summary>
        /// <param name="input">Instance of ExplicitTeamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExplicitTeamMember input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.ParentLevel == input.ParentLevel ||
                    this.ParentLevel.Equals(input.ParentLevel)
                ) && 
                (
                    this.ParentMembershipId == input.ParentMembershipId ||
                    (this.ParentMembershipId != null &&
                    this.ParentMembershipId.Equals(input.ParentMembershipId))
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserUuid == input.UserUuid ||
                    (this.UserUuid != null &&
                    this.UserUuid.Equals(input.UserUuid))
                ) && 
                (
                    this.EffectiveLevel == input.EffectiveLevel ||
                    this.EffectiveLevel.Equals(input.EffectiveLevel)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                hashCode = (hashCode * 59) + this.ParentLevel.GetHashCode();
                if (this.ParentMembershipId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentMembershipId.GetHashCode();
                }
                if (this.JoinedAt != null)
                {
                    hashCode = (hashCode * 59) + this.JoinedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.UserUuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserUuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EffectiveLevel.GetHashCode();
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
