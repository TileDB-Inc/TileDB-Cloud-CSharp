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
    /// a list of max buffer sizes, one per attribute
    /// </summary>
    [DataContract(Name = "MaxBufferSizes")]
    public partial class MaxBufferSizes : IEquatable<MaxBufferSizes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxBufferSizes" /> class.
        /// </summary>
        /// <param name="maxBufferSizes">maxBufferSizes.</param>
        public MaxBufferSizes(List<AttributeBufferSize> maxBufferSizes = default(List<AttributeBufferSize>))
        {
            this._MaxBufferSizes = maxBufferSizes;
        }

        /// <summary>
        /// Gets or Sets _MaxBufferSizes
        /// </summary>
        [DataMember(Name = "maxBufferSizes", EmitDefaultValue = false)]
        public List<AttributeBufferSize> _MaxBufferSizes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MaxBufferSizes {\n");
            sb.Append("  _MaxBufferSizes: ").Append(_MaxBufferSizes).Append("\n");
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
            return this.Equals(input as MaxBufferSizes);
        }

        /// <summary>
        /// Returns true if MaxBufferSizes instances are equal
        /// </summary>
        /// <param name="input">Instance of MaxBufferSizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaxBufferSizes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._MaxBufferSizes == input._MaxBufferSizes ||
                    this._MaxBufferSizes != null &&
                    input._MaxBufferSizes != null &&
                    this._MaxBufferSizes.SequenceEqual(input._MaxBufferSizes)
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
                if (this._MaxBufferSizes != null)
                {
                    hashCode = (hashCode * 59) + this._MaxBufferSizes.GetHashCode();
                }
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
