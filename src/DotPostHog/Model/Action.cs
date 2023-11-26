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
    /// Serializer mixin that resolves appropriate response for tags depending on license.
    /// </summary>
    [DataContract(Name = "Action")]
    public partial class Action : IEquatable<Action>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Action() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="tags">tags.</param>
        /// <param name="postToSlack">postToSlack.</param>
        /// <param name="slackMessageFormat">slackMessageFormat.</param>
        /// <param name="steps">steps.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="lastCalculatedAt">lastCalculatedAt.</param>
        public Action(string name = default(string), string description = default(string), List<Object> tags = default(List<Object>), bool postToSlack = default(bool), string slackMessageFormat = default(string), List<ActionStep> steps = default(List<ActionStep>), bool deleted = default(bool), DateTime lastCalculatedAt = default(DateTime))
        {
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.PostToSlack = postToSlack;
            this.SlackMessageFormat = slackMessageFormat;
            this.Steps = steps;
            this.Deleted = deleted;
            this.LastCalculatedAt = lastCalculatedAt;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Gets or Sets PostToSlack
        /// </summary>
        [DataMember(Name = "post_to_slack", EmitDefaultValue = true)]
        public bool PostToSlack { get; set; }

        /// <summary>
        /// Gets or Sets SlackMessageFormat
        /// </summary>
        [DataMember(Name = "slack_message_format", EmitDefaultValue = false)]
        public string SlackMessageFormat { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<ActionStep> Steps { get; set; }

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
        public UserBasic CreatedBy { get; private set; }

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
        /// Gets or Sets IsCalculating
        /// </summary>
        [DataMember(Name = "is_calculating", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCalculating { get; private set; }

        /// <summary>
        /// Returns false as IsCalculating should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsCalculating()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastCalculatedAt
        /// </summary>
        [DataMember(Name = "last_calculated_at", EmitDefaultValue = false)]
        public DateTime LastCalculatedAt { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "team_id", IsRequired = true, EmitDefaultValue = true)]
        public int TeamId { get; private set; }

        /// <summary>
        /// Returns false as TeamId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTeamId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsAction
        /// </summary>
        [DataMember(Name = "is_action", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAction { get; private set; }

        /// <summary>
        /// Returns false as IsAction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsAction()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BytecodeError
        /// </summary>
        [DataMember(Name = "bytecode_error", IsRequired = true, EmitDefaultValue = true)]
        public string BytecodeError { get; private set; }

        /// <summary>
        /// Returns false as BytecodeError should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBytecodeError()
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
            sb.Append("class Action {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  PostToSlack: ").Append(PostToSlack).Append("\n");
            sb.Append("  SlackMessageFormat: ").Append(SlackMessageFormat).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  IsCalculating: ").Append(IsCalculating).Append("\n");
            sb.Append("  LastCalculatedAt: ").Append(LastCalculatedAt).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  IsAction: ").Append(IsAction).Append("\n");
            sb.Append("  BytecodeError: ").Append(BytecodeError).Append("\n");
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
            return this.Equals(input as Action);
        }

        /// <summary>
        /// Returns true if Action instances are equal
        /// </summary>
        /// <param name="input">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action input)
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.PostToSlack == input.PostToSlack ||
                    this.PostToSlack.Equals(input.PostToSlack)
                ) && 
                (
                    this.SlackMessageFormat == input.SlackMessageFormat ||
                    (this.SlackMessageFormat != null &&
                    this.SlackMessageFormat.Equals(input.SlackMessageFormat))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                    this.IsCalculating == input.IsCalculating ||
                    this.IsCalculating.Equals(input.IsCalculating)
                ) && 
                (
                    this.LastCalculatedAt == input.LastCalculatedAt ||
                    (this.LastCalculatedAt != null &&
                    this.LastCalculatedAt.Equals(input.LastCalculatedAt))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    this.TeamId.Equals(input.TeamId)
                ) && 
                (
                    this.IsAction == input.IsAction ||
                    this.IsAction.Equals(input.IsAction)
                ) && 
                (
                    this.BytecodeError == input.BytecodeError ||
                    (this.BytecodeError != null &&
                    this.BytecodeError.Equals(input.BytecodeError))
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
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PostToSlack.GetHashCode();
                if (this.SlackMessageFormat != null)
                {
                    hashCode = (hashCode * 59) + this.SlackMessageFormat.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
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
                hashCode = (hashCode * 59) + this.IsCalculating.GetHashCode();
                if (this.LastCalculatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastCalculatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TeamId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAction.GetHashCode();
                if (this.BytecodeError != null)
                {
                    hashCode = (hashCode * 59) + this.BytecodeError.GetHashCode();
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

            // SlackMessageFormat (string) maxLength
            if (this.SlackMessageFormat != null && this.SlackMessageFormat.Length > 600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SlackMessageFormat, length must be less than 600.", new [] { "SlackMessageFormat" });
            }

            yield break;
        }
    }

}