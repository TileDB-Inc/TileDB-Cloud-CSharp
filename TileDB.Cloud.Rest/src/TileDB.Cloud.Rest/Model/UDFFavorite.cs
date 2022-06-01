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
    /// A user-favorite UDF item
    /// </summary>
    [DataContract]
    public partial class UDFFavorite :  IEquatable<UDFFavorite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UDFFavorite" /> class.
        /// </summary>
        /// <param name="udfUuid">unique UUID of the UDF.</param>
        /// <param name="_namespace">the namespace of the UDF.</param>
        /// <param name="name">the name of the UDF.</param>
        public UDFFavorite(string udfUuid = default(string), string _namespace = default(string), string name = default(string))
        {
            this.UdfUuid = udfUuid;
            this.Namespace = _namespace;
            this.Name = name;
        }

        /// <summary>
        /// unique UUID of the UDF
        /// </summary>
        /// <value>unique UUID of the UDF</value>
        [DataMember(Name="udf_uuid", EmitDefaultValue=false)]
        public string UdfUuid { get; set; }

        /// <summary>
        /// the namespace of the UDF
        /// </summary>
        /// <value>the namespace of the UDF</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// the name of the UDF
        /// </summary>
        /// <value>the name of the UDF</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UDFFavorite {\n");
            sb.Append("  UdfUuid: ").Append(UdfUuid).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UDFFavorite);
        }

        /// <summary>
        /// Returns true if UDFFavorite instances are equal
        /// </summary>
        /// <param name="input">Instance of UDFFavorite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UDFFavorite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UdfUuid == input.UdfUuid ||
                    (this.UdfUuid != null &&
                    this.UdfUuid.Equals(input.UdfUuid))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.UdfUuid != null)
                    hashCode = hashCode * 59 + this.UdfUuid.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
