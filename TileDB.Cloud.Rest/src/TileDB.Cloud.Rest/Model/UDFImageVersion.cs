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
    /// Defines an image that belongs to a set of images having a version
    /// </summary>
    [DataContract]
    public partial class UDFImageVersion :  IEquatable<UDFImageVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UDFImageVersion" /> class.
        /// </summary>
        /// <param name="id">Unique ID of a versioned image.</param>
        /// <param name="name">name of UDFImageVersion.</param>
        /// <param name="udfImageUuid">Unique ID of the UDF image set.</param>
        /// <param name="dockerImage">Uri of docker image related to current entry.</param>
        /// <param name="version">Image-specific version.</param>
        /// <param name="_default">If current image is default version.</param>
        /// <param name="latest">If current image is latest version.</param>
        public UDFImageVersion(string id = default(string), string name = default(string), string udfImageUuid = default(string), string dockerImage = default(string), decimal version = default(decimal), bool _default = default(bool), bool latest = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.UdfImageUuid = udfImageUuid;
            this.DockerImage = dockerImage;
            this._Version = version;
            this.Default = _default;
            this.Latest = latest;
        }

        /// <summary>
        /// Unique ID of a versioned image
        /// </summary>
        /// <value>Unique ID of a versioned image</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// name of UDFImageVersion
        /// </summary>
        /// <value>name of UDFImageVersion</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of the UDF image set
        /// </summary>
        /// <value>Unique ID of the UDF image set</value>
        [DataMember(Name="udf_image_uuid", EmitDefaultValue=false)]
        public string UdfImageUuid { get; set; }

        /// <summary>
        /// Uri of docker image related to current entry
        /// </summary>
        /// <value>Uri of docker image related to current entry</value>
        [DataMember(Name="docker_image", EmitDefaultValue=false)]
        public string DockerImage { get; set; }

        /// <summary>
        /// Image-specific version
        /// </summary>
        /// <value>Image-specific version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal _Version { get; set; }

        /// <summary>
        /// If current image is default version
        /// </summary>
        /// <value>If current image is default version</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool Default { get; set; }

        /// <summary>
        /// If current image is latest version
        /// </summary>
        /// <value>If current image is latest version</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        public bool Latest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UDFImageVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UdfImageUuid: ").Append(UdfImageUuid).Append("\n");
            sb.Append("  DockerImage: ").Append(DockerImage).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
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
            return this.Equals(input as UDFImageVersion);
        }

        /// <summary>
        /// Returns true if UDFImageVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of UDFImageVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UDFImageVersion input)
        {
            if (input == null)
                return false;

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
                    this.UdfImageUuid == input.UdfImageUuid ||
                    (this.UdfImageUuid != null &&
                    this.UdfImageUuid.Equals(input.UdfImageUuid))
                ) && 
                (
                    this.DockerImage == input.DockerImage ||
                    (this.DockerImage != null &&
                    this.DockerImage.Equals(input.DockerImage))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Latest == input.Latest ||
                    (this.Latest != null &&
                    this.Latest.Equals(input.Latest))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UdfImageUuid != null)
                    hashCode = hashCode * 59 + this.UdfImageUuid.GetHashCode();
                if (this.DockerImage != null)
                    hashCode = hashCode * 59 + this.DockerImage.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Latest != null)
                    hashCode = hashCode * 59 + this.Latest.GetHashCode();
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
