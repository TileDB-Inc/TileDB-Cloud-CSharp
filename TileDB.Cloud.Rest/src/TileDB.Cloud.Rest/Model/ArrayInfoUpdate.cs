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
    /// metadata of an array
    /// </summary>
    [DataContract]
    public partial class ArrayInfoUpdate :  IEquatable<ArrayInfoUpdate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name="file_type", EmitDefaultValue=false)]
        public FileType? FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayInfoUpdate" /> class.
        /// </summary>
        /// <param name="description">description of array.</param>
        /// <param name="name">description of array.</param>
        /// <param name="uri">uri of array.</param>
        /// <param name="fileType">fileType.</param>
        /// <param name="fileProperties">map of file properties created for this array.</param>
        /// <param name="accessCredentialsName">the name of the access credentials to use. if unset, the default credentials will be used.</param>
        /// <param name="logo">logo (base64 encoded) for the array. Optional.</param>
        /// <param name="tags">optional tags for array.</param>
        /// <param name="licenseId">License identifier from SPDX License List or Custom.</param>
        /// <param name="licenseText">License text.</param>
        /// <param name="readOnly">Suggests if the array is in read_only mode.</param>
        public ArrayInfoUpdate(string description = default(string), string name = default(string), string uri = default(string), FileType? fileType = default(FileType?), Dictionary<string, string> fileProperties = default(Dictionary<string, string>), string accessCredentialsName = default(string), string logo = default(string), List<string> tags = default(List<string>), string licenseId = default(string), string licenseText = default(string), bool readOnly = default(bool))
        {
            this.Description = description;
            this.Description = description;
            this.Name = name;
            this.Uri = uri;
            this.FileType = fileType;
            this.FileProperties = fileProperties;
            this.AccessCredentialsName = accessCredentialsName;
            this.Logo = logo;
            this.Tags = tags;
            this.LicenseId = licenseId;
            this.LicenseText = licenseText;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// description of array
        /// </summary>
        /// <value>description of array</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// description of array
        /// </summary>
        /// <value>description of array</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// uri of array
        /// </summary>
        /// <value>uri of array</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }


        /// <summary>
        /// map of file properties created for this array
        /// </summary>
        /// <value>map of file properties created for this array</value>
        [DataMember(Name="file_properties", EmitDefaultValue=false)]
        public Dictionary<string, string> FileProperties { get; set; }

        /// <summary>
        /// the name of the access credentials to use. if unset, the default credentials will be used
        /// </summary>
        /// <value>the name of the access credentials to use. if unset, the default credentials will be used</value>
        [DataMember(Name="access_credentials_name", EmitDefaultValue=false)]
        public string AccessCredentialsName { get; set; }

        /// <summary>
        /// logo (base64 encoded) for the array. Optional
        /// </summary>
        /// <value>logo (base64 encoded) for the array. Optional</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// optional tags for array
        /// </summary>
        /// <value>optional tags for array</value>
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
        /// Suggests if the array is in read_only mode
        /// </summary>
        /// <value>Suggests if the array is in read_only mode</value>
        [DataMember(Name="read_only", EmitDefaultValue=false)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayInfoUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  FileProperties: ").Append(FileProperties).Append("\n");
            sb.Append("  AccessCredentialsName: ").Append(AccessCredentialsName).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  LicenseText: ").Append(LicenseText).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as ArrayInfoUpdate);
        }

        /// <summary>
        /// Returns true if ArrayInfoUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayInfoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayInfoUpdate input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.FileProperties == input.FileProperties ||
                    this.FileProperties != null &&
                    input.FileProperties != null &&
                    this.FileProperties.SequenceEqual(input.FileProperties)
                ) && 
                (
                    this.AccessCredentialsName == input.AccessCredentialsName ||
                    (this.AccessCredentialsName != null &&
                    this.AccessCredentialsName.Equals(input.AccessCredentialsName))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
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
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FileProperties != null)
                    hashCode = hashCode * 59 + this.FileProperties.GetHashCode();
                if (this.AccessCredentialsName != null)
                    hashCode = hashCode * 59 + this.AccessCredentialsName.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LicenseId != null)
                    hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.LicenseText != null)
                    hashCode = hashCode * 59 + this.LicenseText.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
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
