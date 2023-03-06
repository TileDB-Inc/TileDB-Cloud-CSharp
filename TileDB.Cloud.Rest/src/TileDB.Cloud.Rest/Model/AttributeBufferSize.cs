/*
 * TileDB Storage Platform API
 *
 * TileDB Storage Platform REST API
 *
 * The version of the OpenAPI document: 2.2.19
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
using OpenAPIDateConverter = TileDB.Cloud.Rest.Client.OpenAPIDateConverter;

namespace TileDB.Cloud.Rest.Model
{
    /// <summary>
    /// object representing buffer size of an attribute
    /// </summary>
    [DataContract(Name = "AttributeBufferSize")]
    public partial class AttributeBufferSize : IEquatable<AttributeBufferSize>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeBufferSize" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttributeBufferSize() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeBufferSize" /> class.
        /// </summary>
        /// <param name="attribute">name of attribute (required).</param>
        /// <param name="offsetBytes">buffer size (in bytes) of offset buffer (required).</param>
        /// <param name="dataBytes">buffer size (in bytes) of data buffer (required).</param>
        public AttributeBufferSize(string attribute = default(string), int offsetBytes = default(int), int dataBytes = default(int))
        {
            // to ensure "attribute" is required (not null)
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute is a required property for AttributeBufferSize and cannot be null");
            }
            this.Attribute = attribute;
            this.OffsetBytes = offsetBytes;
            this.DataBytes = dataBytes;
        }

        /// <summary>
        /// name of attribute
        /// </summary>
        /// <value>name of attribute</value>
        [DataMember(Name = "attribute", IsRequired = true, EmitDefaultValue = false)]
        public string Attribute { get; set; }

        /// <summary>
        /// buffer size (in bytes) of offset buffer
        /// </summary>
        /// <value>buffer size (in bytes) of offset buffer</value>
        [DataMember(Name = "offsetBytes", IsRequired = true, EmitDefaultValue = false)]
        public int OffsetBytes { get; set; }

        /// <summary>
        /// buffer size (in bytes) of data buffer
        /// </summary>
        /// <value>buffer size (in bytes) of data buffer</value>
        [DataMember(Name = "dataBytes", IsRequired = true, EmitDefaultValue = false)]
        public int DataBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttributeBufferSize {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  OffsetBytes: ").Append(OffsetBytes).Append("\n");
            sb.Append("  DataBytes: ").Append(DataBytes).Append("\n");
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
            return this.Equals(input as AttributeBufferSize);
        }

        /// <summary>
        /// Returns true if AttributeBufferSize instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeBufferSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeBufferSize input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attribute == input.Attribute ||
                    (this.Attribute != null &&
                    this.Attribute.Equals(input.Attribute))
                ) && 
                (
                    this.OffsetBytes == input.OffsetBytes ||
                    this.OffsetBytes.Equals(input.OffsetBytes)
                ) && 
                (
                    this.DataBytes == input.DataBytes ||
                    this.DataBytes.Equals(input.DataBytes)
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
                if (this.Attribute != null)
                {
                    hashCode = (hashCode * 59) + this.Attribute.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OffsetBytes.GetHashCode();
                hashCode = (hashCode * 59) + this.DataBytes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
