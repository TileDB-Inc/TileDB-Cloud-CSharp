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
    /// Parameterizable version of &#x60;QueryRanges&#x60;.
    /// </summary>
    [DataContract(Name = "TGQueryRanges")]
    public partial class TGQueryRanges : IEquatable<TGQueryRanges>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false)]
        public Layout? Layout { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TGQueryRanges" /> class.
        /// </summary>
        /// <param name="layout">layout.</param>
        public TGQueryRanges(Layout? layout = default(Layout?))
        {
            this.Layout = layout;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TGQueryRanges {\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
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
            return this.Equals(input as TGQueryRanges);
        }

        /// <summary>
        /// Returns true if TGQueryRanges instances are equal
        /// </summary>
        /// <param name="input">Instance of TGQueryRanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TGQueryRanges input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Layout == input.Layout ||
                    this.Layout.Equals(input.Layout)
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
                hashCode = (hashCode * 59) + this.Layout.GetHashCode();
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
