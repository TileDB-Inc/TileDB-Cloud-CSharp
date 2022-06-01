/*
 * TileDB Storage Platform API
 *
 * TileDB Storage Platform REST API
 *
 * The version of the OpenAPI document: 2.2.19
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TileDB.Cloud.Rest.Client.OpenAPIDateConverter;

namespace TileDB.Cloud.Rest.Model
{
    /// <summary>
    /// Updates for a group. New values for the attributes.
    /// </summary>
    [DataContract]
    public partial class GroupUpdate :  IEquatable<GroupUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdate" /> class.
        /// </summary>
        /// <param name="description">A human readable description of the content of the group.</param>
        /// <param name="name">The name of the group. If must be unique within the group..</param>
        /// <param name="logo">logo (base64 encoded) for the group. Optional.</param>
        /// <param name="accessCredentialsName">the name of the access credentials to use. if unset, the default credentials will be used.</param>
        /// <param name="tags">optional tags for groups.</param>
        /// <param name="licenseId">License identifier from SPDX License List or Custom.</param>
        /// <param name="licenseText">License text.</param>
        public GroupUpdate(string description = default(string), string name = default(string), string logo = default(string), string accessCredentialsName = default(string), List<string> tags = default(List<string>), string licenseId = default(string), string licenseText = default(string))
        {
            this.Description = description;
            this.Name = name;
            this.Logo = logo;
            this.AccessCredentialsName = accessCredentialsName;
            this.Tags = tags;
            this.LicenseId = licenseId;
            this.LicenseText = licenseText;
        }

        /// <summary>
        /// A human readable description of the content of the group
        /// </summary>
        /// <value>A human readable description of the content of the group</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the group. If must be unique within the group.
        /// </summary>
        /// <value>The name of the group. If must be unique within the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// logo (base64 encoded) for the group. Optional
        /// </summary>
        /// <value>logo (base64 encoded) for the group. Optional</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// the name of the access credentials to use. if unset, the default credentials will be used
        /// </summary>
        /// <value>the name of the access credentials to use. if unset, the default credentials will be used</value>
        [DataMember(Name="access_credentials_name", EmitDefaultValue=false)]
        public string AccessCredentialsName { get; set; }

        /// <summary>
        /// optional tags for groups
        /// </summary>
        /// <value>optional tags for groups</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// License identifier from SPDX License List or Custom
        /// </summary>
        /// <value>License identifier from SPDX License List or Custom</value>
        [DataMember(Name="license_id", EmitDefaultValue=false)]
        public string LicenseId { get; set; }

        /// <summary>
        /// License text
        /// </summary>
        /// <value>License text</value>
        [DataMember(Name="license_text", EmitDefaultValue=false)]
        public string LicenseText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AccessCredentialsName: ").Append(AccessCredentialsName).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  LicenseText: ").Append(LicenseText).Append("\n");
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
            return this.Equals(input as GroupUpdate);
        }

        /// <summary>
        /// Returns true if GroupUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.AccessCredentialsName == input.AccessCredentialsName ||
                    (this.AccessCredentialsName != null &&
                    this.AccessCredentialsName.Equals(input.AccessCredentialsName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.LicenseId == input.LicenseId ||
                    (this.LicenseId != null &&
                    this.LicenseId.Equals(input.LicenseId))
                ) && 
                (
                    this.LicenseText == input.LicenseText ||
                    (this.LicenseText != null &&
                    this.LicenseText.Equals(input.LicenseText))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.AccessCredentialsName != null)
                    hashCode = hashCode * 59 + this.AccessCredentialsName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LicenseId != null)
                    hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.LicenseText != null)
                    hashCode = hashCode * 59 + this.LicenseText.GetHashCode();
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
