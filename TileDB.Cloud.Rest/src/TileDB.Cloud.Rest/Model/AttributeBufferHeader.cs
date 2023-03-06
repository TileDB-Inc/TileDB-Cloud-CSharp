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
    /// Represents an attribute buffer header information
    /// </summary>
    [DataContract(Name = "AttributeBufferHeader")]
    public partial class AttributeBufferHeader : IEquatable<AttributeBufferHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeBufferHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttributeBufferHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeBufferHeader" /> class.
        /// </summary>
        /// <param name="name">Attribute name (required).</param>
        /// <param name="fixedLenBufferSizeInBytes">Number of bytes in the fixed-length attribute data buffer (offsets for var-len attributes) (required).</param>
        /// <param name="varLenBufferSizeInBytes">Number of bytes in the var-length attribute data buffer (required).</param>
        public AttributeBufferHeader(string name = default(string), int fixedLenBufferSizeInBytes = default(int), int varLenBufferSizeInBytes = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AttributeBufferHeader and cannot be null");
            }
            this.Name = name;
            this.FixedLenBufferSizeInBytes = fixedLenBufferSizeInBytes;
            this.VarLenBufferSizeInBytes = varLenBufferSizeInBytes;
        }

        /// <summary>
        /// Attribute name
        /// </summary>
        /// <value>Attribute name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Number of bytes in the fixed-length attribute data buffer (offsets for var-len attributes)
        /// </summary>
        /// <value>Number of bytes in the fixed-length attribute data buffer (offsets for var-len attributes)</value>
        [DataMember(Name = "fixedLenBufferSizeInBytes", IsRequired = true, EmitDefaultValue = false)]
        public int FixedLenBufferSizeInBytes { get; set; }

        /// <summary>
        /// Number of bytes in the var-length attribute data buffer
        /// </summary>
        /// <value>Number of bytes in the var-length attribute data buffer</value>
        [DataMember(Name = "varLenBufferSizeInBytes", IsRequired = true, EmitDefaultValue = false)]
        public int VarLenBufferSizeInBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttributeBufferHeader {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FixedLenBufferSizeInBytes: ").Append(FixedLenBufferSizeInBytes).Append("\n");
            sb.Append("  VarLenBufferSizeInBytes: ").Append(VarLenBufferSizeInBytes).Append("\n");
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
            return this.Equals(input as AttributeBufferHeader);
        }

        /// <summary>
        /// Returns true if AttributeBufferHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeBufferHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeBufferHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FixedLenBufferSizeInBytes == input.FixedLenBufferSizeInBytes ||
                    this.FixedLenBufferSizeInBytes.Equals(input.FixedLenBufferSizeInBytes)
                ) && 
                (
                    this.VarLenBufferSizeInBytes == input.VarLenBufferSizeInBytes ||
                    this.VarLenBufferSizeInBytes.Equals(input.VarLenBufferSizeInBytes)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FixedLenBufferSizeInBytes.GetHashCode();
                hashCode = (hashCode * 59) + this.VarLenBufferSizeInBytes.GetHashCode();
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
