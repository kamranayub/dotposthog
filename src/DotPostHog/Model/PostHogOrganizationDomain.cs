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
    /// PostHogOrganizationDomain
    /// </summary>
    [DataContract(Name = "OrganizationDomain")]
    public partial class PostHogOrganizationDomain : IEquatable<PostHogOrganizationDomain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogOrganizationDomain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogOrganizationDomain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogOrganizationDomain" /> class.
        /// </summary>
        /// <param name="domain">domain (required).</param>
        /// <param name="jitProvisioningEnabled">jitProvisioningEnabled.</param>
        /// <param name="ssoEnforcement">ssoEnforcement.</param>
        /// <param name="samlEntityId">samlEntityId.</param>
        /// <param name="samlAcsUrl">samlAcsUrl.</param>
        /// <param name="samlX509Cert">samlX509Cert.</param>
        public PostHogOrganizationDomain(string domain = default(string), bool jitProvisioningEnabled = default(bool), string ssoEnforcement = default(string), string samlEntityId = default(string), string samlAcsUrl = default(string), string samlX509Cert = default(string))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for PostHogOrganizationDomain and cannot be null");
            }
            this.Domain = domain;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.SsoEnforcement = ssoEnforcement;
            this.SamlEntityId = samlEntityId;
            this.SamlAcsUrl = samlAcsUrl;
            this.SamlX509Cert = samlX509Cert;
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
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name = "is_verified", IsRequired = true, EmitDefaultValue = true)]
        public bool IsVerified { get; private set; }

        /// <summary>
        /// Returns false as IsVerified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsVerified()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VerifiedAt
        /// </summary>
        [DataMember(Name = "verified_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? VerifiedAt { get; private set; }

        /// <summary>
        /// Returns false as VerifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerifiedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VerificationChallenge
        /// </summary>
        [DataMember(Name = "verification_challenge", IsRequired = true, EmitDefaultValue = true)]
        public string VerificationChallenge { get; private set; }

        /// <summary>
        /// Returns false as VerificationChallenge should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerificationChallenge()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets JitProvisioningEnabled
        /// </summary>
        [DataMember(Name = "jit_provisioning_enabled", EmitDefaultValue = true)]
        public bool JitProvisioningEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SsoEnforcement
        /// </summary>
        [DataMember(Name = "sso_enforcement", EmitDefaultValue = false)]
        public string SsoEnforcement { get; set; }

        /// <summary>
        /// Gets or Sets HasSaml
        /// </summary>
        [DataMember(Name = "has_saml", IsRequired = true, EmitDefaultValue = true)]
        public bool HasSaml { get; private set; }

        /// <summary>
        /// Returns false as HasSaml should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasSaml()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SamlEntityId
        /// </summary>
        [DataMember(Name = "saml_entity_id", EmitDefaultValue = true)]
        public string SamlEntityId { get; set; }

        /// <summary>
        /// Gets or Sets SamlAcsUrl
        /// </summary>
        [DataMember(Name = "saml_acs_url", EmitDefaultValue = true)]
        public string SamlAcsUrl { get; set; }

        /// <summary>
        /// Gets or Sets SamlX509Cert
        /// </summary>
        [DataMember(Name = "saml_x509_cert", EmitDefaultValue = true)]
        public string SamlX509Cert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogOrganizationDomain {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  VerifiedAt: ").Append(VerifiedAt).Append("\n");
            sb.Append("  VerificationChallenge: ").Append(VerificationChallenge).Append("\n");
            sb.Append("  JitProvisioningEnabled: ").Append(JitProvisioningEnabled).Append("\n");
            sb.Append("  SsoEnforcement: ").Append(SsoEnforcement).Append("\n");
            sb.Append("  HasSaml: ").Append(HasSaml).Append("\n");
            sb.Append("  SamlEntityId: ").Append(SamlEntityId).Append("\n");
            sb.Append("  SamlAcsUrl: ").Append(SamlAcsUrl).Append("\n");
            sb.Append("  SamlX509Cert: ").Append(SamlX509Cert).Append("\n");
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
            return this.Equals(input as PostHogOrganizationDomain);
        }

        /// <summary>
        /// Returns true if PostHogOrganizationDomain instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogOrganizationDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogOrganizationDomain input)
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
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    this.IsVerified.Equals(input.IsVerified)
                ) && 
                (
                    this.VerifiedAt == input.VerifiedAt ||
                    (this.VerifiedAt != null &&
                    this.VerifiedAt.Equals(input.VerifiedAt))
                ) && 
                (
                    this.VerificationChallenge == input.VerificationChallenge ||
                    (this.VerificationChallenge != null &&
                    this.VerificationChallenge.Equals(input.VerificationChallenge))
                ) && 
                (
                    this.JitProvisioningEnabled == input.JitProvisioningEnabled ||
                    this.JitProvisioningEnabled.Equals(input.JitProvisioningEnabled)
                ) && 
                (
                    this.SsoEnforcement == input.SsoEnforcement ||
                    (this.SsoEnforcement != null &&
                    this.SsoEnforcement.Equals(input.SsoEnforcement))
                ) && 
                (
                    this.HasSaml == input.HasSaml ||
                    this.HasSaml.Equals(input.HasSaml)
                ) && 
                (
                    this.SamlEntityId == input.SamlEntityId ||
                    (this.SamlEntityId != null &&
                    this.SamlEntityId.Equals(input.SamlEntityId))
                ) && 
                (
                    this.SamlAcsUrl == input.SamlAcsUrl ||
                    (this.SamlAcsUrl != null &&
                    this.SamlAcsUrl.Equals(input.SamlAcsUrl))
                ) && 
                (
                    this.SamlX509Cert == input.SamlX509Cert ||
                    (this.SamlX509Cert != null &&
                    this.SamlX509Cert.Equals(input.SamlX509Cert))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsVerified.GetHashCode();
                if (this.VerifiedAt != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiedAt.GetHashCode();
                }
                if (this.VerificationChallenge != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationChallenge.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JitProvisioningEnabled.GetHashCode();
                if (this.SsoEnforcement != null)
                {
                    hashCode = (hashCode * 59) + this.SsoEnforcement.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasSaml.GetHashCode();
                if (this.SamlEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.SamlEntityId.GetHashCode();
                }
                if (this.SamlAcsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SamlAcsUrl.GetHashCode();
                }
                if (this.SamlX509Cert != null)
                {
                    hashCode = (hashCode * 59) + this.SamlX509Cert.GetHashCode();
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
            // Domain (string) maxLength
            if (this.Domain != null && this.Domain.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Domain, length must be less than 128.", new [] { "Domain" });
            }

            // SsoEnforcement (string) maxLength
            if (this.SsoEnforcement != null && this.SsoEnforcement.Length > 28)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SsoEnforcement, length must be less than 28.", new [] { "SsoEnforcement" });
            }

            // SamlEntityId (string) maxLength
            if (this.SamlEntityId != null && this.SamlEntityId.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SamlEntityId, length must be less than 512.", new [] { "SamlEntityId" });
            }

            // SamlAcsUrl (string) maxLength
            if (this.SamlAcsUrl != null && this.SamlAcsUrl.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SamlAcsUrl, length must be less than 512.", new [] { "SamlAcsUrl" });
            }

            yield break;
        }
    }

}
