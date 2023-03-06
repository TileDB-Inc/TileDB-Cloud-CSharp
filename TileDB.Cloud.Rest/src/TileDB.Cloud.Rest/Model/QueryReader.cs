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
    /// Read struct (can&#39;t be called reader due to class name conflict)
    /// </summary>
    [DataContract(Name = "QueryReader")]
    public partial class QueryReader : IEquatable<QueryReader>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false)]
        public Layout? Layout { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryReader" /> class.
        /// </summary>
        /// <param name="layout">layout.</param>
        /// <param name="subarray">subarray.</param>
        /// <param name="readState">readState.</param>
        /// <param name="varOffsetsMode">The offsets format (bytes or elements) to be used..</param>
        /// <param name="varOffsetsAddExtraElement">True if an extra element will be added to the end of the offsets buffer..</param>
        /// <param name="varOffsetsBitsize">The offsets bitsize (32 or 64) to be used..</param>
        public QueryReader(Layout? layout = default(Layout?), Subarray subarray = default(Subarray), ReadState readState = default(ReadState), string varOffsetsMode = default(string), bool varOffsetsAddExtraElement = default(bool), int varOffsetsBitsize = default(int))
        {
            this.Layout = layout;
            this.Subarray = subarray;
            this.ReadState = readState;
            this.VarOffsetsMode = varOffsetsMode;
            this.VarOffsetsAddExtraElement = varOffsetsAddExtraElement;
            this.VarOffsetsBitsize = varOffsetsBitsize;
        }

        /// <summary>
        /// Gets or Sets Subarray
        /// </summary>
        [DataMember(Name = "subarray", EmitDefaultValue = false)]
        public Subarray Subarray { get; set; }

        /// <summary>
        /// Gets or Sets ReadState
        /// </summary>
        [DataMember(Name = "readState", EmitDefaultValue = false)]
        public ReadState ReadState { get; set; }

        /// <summary>
        /// The offsets format (bytes or elements) to be used.
        /// </summary>
        /// <value>The offsets format (bytes or elements) to be used.</value>
        [DataMember(Name = "varOffsetsMode", EmitDefaultValue = false)]
        public string VarOffsetsMode { get; set; }

        /// <summary>
        /// True if an extra element will be added to the end of the offsets buffer.
        /// </summary>
        /// <value>True if an extra element will be added to the end of the offsets buffer.</value>
        [DataMember(Name = "varOffsetsAddExtraElement", EmitDefaultValue = true)]
        public bool VarOffsetsAddExtraElement { get; set; }

        /// <summary>
        /// The offsets bitsize (32 or 64) to be used.
        /// </summary>
        /// <value>The offsets bitsize (32 or 64) to be used.</value>
        [DataMember(Name = "varOffsetsBitsize", EmitDefaultValue = false)]
        public int VarOffsetsBitsize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryReader {\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Subarray: ").Append(Subarray).Append("\n");
            sb.Append("  ReadState: ").Append(ReadState).Append("\n");
            sb.Append("  VarOffsetsMode: ").Append(VarOffsetsMode).Append("\n");
            sb.Append("  VarOffsetsAddExtraElement: ").Append(VarOffsetsAddExtraElement).Append("\n");
            sb.Append("  VarOffsetsBitsize: ").Append(VarOffsetsBitsize).Append("\n");
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
            return this.Equals(input as QueryReader);
        }

        /// <summary>
        /// Returns true if QueryReader instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryReader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryReader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Layout == input.Layout ||
                    this.Layout.Equals(input.Layout)
                ) && 
                (
                    this.Subarray == input.Subarray ||
                    (this.Subarray != null &&
                    this.Subarray.Equals(input.Subarray))
                ) && 
                (
                    this.ReadState == input.ReadState ||
                    (this.ReadState != null &&
                    this.ReadState.Equals(input.ReadState))
                ) && 
                (
                    this.VarOffsetsMode == input.VarOffsetsMode ||
                    (this.VarOffsetsMode != null &&
                    this.VarOffsetsMode.Equals(input.VarOffsetsMode))
                ) && 
                (
                    this.VarOffsetsAddExtraElement == input.VarOffsetsAddExtraElement ||
                    this.VarOffsetsAddExtraElement.Equals(input.VarOffsetsAddExtraElement)
                ) && 
                (
                    this.VarOffsetsBitsize == input.VarOffsetsBitsize ||
                    this.VarOffsetsBitsize.Equals(input.VarOffsetsBitsize)
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
                if (this.Subarray != null)
                {
                    hashCode = (hashCode * 59) + this.Subarray.GetHashCode();
                }
                if (this.ReadState != null)
                {
                    hashCode = (hashCode * 59) + this.ReadState.GetHashCode();
                }
                if (this.VarOffsetsMode != null)
                {
                    hashCode = (hashCode * 59) + this.VarOffsetsMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarOffsetsAddExtraElement.GetHashCode();
                hashCode = (hashCode * 59) + this.VarOffsetsBitsize.GetHashCode();
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
