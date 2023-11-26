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
    /// Serializer for a BatchExport model.
    /// </summary>
    [DataContract(Name = "PatchedBatchExport")]
    public partial class PatchedBatchExport : IEquatable<PatchedBatchExport>, IValidatableObject
    {
        /// <summary>
        /// Defines Interval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            /// <summary>
            /// Enum Hour for value: hour
            /// </summary>
            [EnumMember(Value = "hour")]
            Hour = 1,

            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 2,

            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 3,

            /// <summary>
            /// Enum Every5Minutes for value: every 5 minutes
            /// </summary>
            [EnumMember(Value = "every 5 minutes")]
            Every5Minutes = 4
        }


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedBatchExport" /> class.
        /// </summary>
        /// <param name="name">A human-readable name for this BatchExport..</param>
        /// <param name="destination">destination.</param>
        /// <param name="interval">interval.</param>
        /// <param name="paused">Whether this BatchExport is paused or not..</param>
        /// <param name="lastPausedAt">The timestamp at which this BatchExport was last paused..</param>
        /// <param name="startAt">Time before which any Batch Export runs won&#39;t be triggered..</param>
        /// <param name="endAt">Time after which any Batch Export runs won&#39;t be triggered..</param>
        public PatchedBatchExport(string name = default(string), BatchExportDestination destination = default(BatchExportDestination), IntervalEnum? interval = default(IntervalEnum?), bool paused = default(bool), DateTime? lastPausedAt = default(DateTime?), DateTime? startAt = default(DateTime?), DateTime? endAt = default(DateTime?))
        {
            this.Name = name;
            this.Destination = destination;
            this.Interval = interval;
            this.Paused = paused;
            this.LastPausedAt = lastPausedAt;
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// A human-readable name for this BatchExport.
        /// </summary>
        /// <value>A human-readable name for this BatchExport.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public BatchExportDestination Destination { get; set; }

        /// <summary>
        /// Whether this BatchExport is paused or not.
        /// </summary>
        /// <value>Whether this BatchExport is paused or not.</value>
        [DataMember(Name = "paused", EmitDefaultValue = true)]
        public bool Paused { get; set; }

        /// <summary>
        /// The timestamp at which this BatchExport was created.
        /// </summary>
        /// <value>The timestamp at which this BatchExport was created.</value>
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
        /// The timestamp at which this BatchExport was last updated.
        /// </summary>
        /// <value>The timestamp at which this BatchExport was last updated.</value>
        [DataMember(Name = "last_updated_at", EmitDefaultValue = false)]
        public DateTime LastUpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as LastUpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The timestamp at which this BatchExport was last paused.
        /// </summary>
        /// <value>The timestamp at which this BatchExport was last paused.</value>
        [DataMember(Name = "last_paused_at", EmitDefaultValue = true)]
        public DateTime? LastPausedAt { get; set; }

        /// <summary>
        /// Time before which any Batch Export runs won&#39;t be triggered.
        /// </summary>
        /// <value>Time before which any Batch Export runs won&#39;t be triggered.</value>
        [DataMember(Name = "start_at", EmitDefaultValue = true)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Time after which any Batch Export runs won&#39;t be triggered.
        /// </summary>
        /// <value>Time after which any Batch Export runs won&#39;t be triggered.</value>
        [DataMember(Name = "end_at", EmitDefaultValue = true)]
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Gets or Sets LatestRuns
        /// </summary>
        [DataMember(Name = "latest_runs", EmitDefaultValue = false)]
        public List<BatchExportRun> LatestRuns { get; private set; }

        /// <summary>
        /// Returns false as LatestRuns should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLatestRuns()
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
            sb.Append("class PatchedBatchExport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
            sb.Append("  LastPausedAt: ").Append(LastPausedAt).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  LatestRuns: ").Append(LatestRuns).Append("\n");
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
            return this.Equals(input as PatchedBatchExport);
        }

        /// <summary>
        /// Returns true if PatchedBatchExport instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedBatchExport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedBatchExport input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.Paused == input.Paused ||
                    this.Paused.Equals(input.Paused)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
                ) && 
                (
                    this.LastPausedAt == input.LastPausedAt ||
                    (this.LastPausedAt != null &&
                    this.LastPausedAt.Equals(input.LastPausedAt))
                ) && 
                (
                    this.StartAt == input.StartAt ||
                    (this.StartAt != null &&
                    this.StartAt.Equals(input.StartAt))
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    (this.EndAt != null &&
                    this.EndAt.Equals(input.EndAt))
                ) && 
                (
                    this.LatestRuns == input.LatestRuns ||
                    this.LatestRuns != null &&
                    input.LatestRuns != null &&
                    this.LatestRuns.SequenceEqual(input.LatestRuns)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                hashCode = (hashCode * 59) + this.Paused.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.LastUpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedAt.GetHashCode();
                }
                if (this.LastPausedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastPausedAt.GetHashCode();
                }
                if (this.StartAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartAt.GetHashCode();
                }
                if (this.EndAt != null)
                {
                    hashCode = (hashCode * 59) + this.EndAt.GetHashCode();
                }
                if (this.LatestRuns != null)
                {
                    hashCode = (hashCode * 59) + this.LatestRuns.GetHashCode();
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
