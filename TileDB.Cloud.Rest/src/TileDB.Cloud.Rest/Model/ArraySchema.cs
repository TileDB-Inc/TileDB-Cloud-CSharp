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
    /// ArraySchema during creation or retrieval
    /// </summary>
    [DataContract]
    public partial class ArraySchema :  IEquatable<ArraySchema>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ArrayType
        /// </summary>
        [DataMember(Name="arrayType", EmitDefaultValue=true)]
        public ArrayType ArrayType { get; set; }
        /// <summary>
        /// Gets or Sets TileOrder
        /// </summary>
        [DataMember(Name="tileOrder", EmitDefaultValue=true)]
        public Layout TileOrder { get; set; }
        /// <summary>
        /// Gets or Sets CellOrder
        /// </summary>
        [DataMember(Name="cellOrder", EmitDefaultValue=true)]
        public Layout CellOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArraySchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArraySchema" /> class.
        /// </summary>
        /// <param name="uri">URI of schema.</param>
        /// <param name="version">file format version (required).</param>
        /// <param name="arrayType">arrayType (required).</param>
        /// <param name="tileOrder">tileOrder (required).</param>
        /// <param name="cellOrder">cellOrder (required).</param>
        /// <param name="capacity">Capacity of array (required).</param>
        /// <param name="coordsFilterPipeline">coordsFilterPipeline (required).</param>
        /// <param name="offsetFilterPipeline">offsetFilterPipeline (required).</param>
        /// <param name="domain">domain (required).</param>
        /// <param name="attributes">Attributes of array (required).</param>
        /// <param name="allowsDuplicates">True if the array allows coordinate duplicates. Applicable only to sparse arrays..</param>
        public ArraySchema(string uri = default(string), List<int> version = default(List<int>), ArrayType arrayType = default(ArrayType), Layout tileOrder = default(Layout), Layout cellOrder = default(Layout), int capacity = default(int), FilterPipeline coordsFilterPipeline = default(FilterPipeline), FilterPipeline offsetFilterPipeline = default(FilterPipeline), Domain domain = default(Domain), List<Attribute> attributes = default(List<Attribute>), bool allowsDuplicates = default(bool))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "arrayType" is required (not null)
            if (arrayType == null)
            {
                throw new InvalidDataException("arrayType is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.ArrayType = arrayType;
            }

            // to ensure "tileOrder" is required (not null)
            if (tileOrder == null)
            {
                throw new InvalidDataException("tileOrder is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.TileOrder = tileOrder;
            }

            // to ensure "cellOrder" is required (not null)
            if (cellOrder == null)
            {
                throw new InvalidDataException("cellOrder is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.CellOrder = cellOrder;
            }

            // to ensure "capacity" is required (not null)
            if (capacity == null)
            {
                throw new InvalidDataException("capacity is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.Capacity = capacity;
            }

            // to ensure "coordsFilterPipeline" is required (not null)
            if (coordsFilterPipeline == null)
            {
                throw new InvalidDataException("coordsFilterPipeline is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.CoordsFilterPipeline = coordsFilterPipeline;
            }

            // to ensure "offsetFilterPipeline" is required (not null)
            if (offsetFilterPipeline == null)
            {
                throw new InvalidDataException("offsetFilterPipeline is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.OffsetFilterPipeline = offsetFilterPipeline;
            }

            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new InvalidDataException("domain is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.Domain = domain;
            }

            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new InvalidDataException("attributes is a required property for ArraySchema and cannot be null");
            }
            else
            {
                this.Attributes = attributes;
            }

            this.Uri = uri;
            this.AllowsDuplicates = allowsDuplicates;
        }

        /// <summary>
        /// URI of schema
        /// </summary>
        /// <value>URI of schema</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// file format version
        /// </summary>
        /// <value>file format version</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public List<int> _Version { get; set; }




        /// <summary>
        /// Capacity of array
        /// </summary>
        /// <value>Capacity of array</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or Sets CoordsFilterPipeline
        /// </summary>
        [DataMember(Name="coordsFilterPipeline", EmitDefaultValue=true)]
        public FilterPipeline CoordsFilterPipeline { get; set; }

        /// <summary>
        /// Gets or Sets OffsetFilterPipeline
        /// </summary>
        [DataMember(Name="offsetFilterPipeline", EmitDefaultValue=true)]
        public FilterPipeline OffsetFilterPipeline { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public Domain Domain { get; set; }

        /// <summary>
        /// Attributes of array
        /// </summary>
        /// <value>Attributes of array</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// True if the array allows coordinate duplicates. Applicable only to sparse arrays.
        /// </summary>
        /// <value>True if the array allows coordinate duplicates. Applicable only to sparse arrays.</value>
        [DataMember(Name="allowsDuplicates", EmitDefaultValue=false)]
        public bool AllowsDuplicates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArraySchema {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  ArrayType: ").Append(ArrayType).Append("\n");
            sb.Append("  TileOrder: ").Append(TileOrder).Append("\n");
            sb.Append("  CellOrder: ").Append(CellOrder).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  CoordsFilterPipeline: ").Append(CoordsFilterPipeline).Append("\n");
            sb.Append("  OffsetFilterPipeline: ").Append(OffsetFilterPipeline).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AllowsDuplicates: ").Append(AllowsDuplicates).Append("\n");
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
            return this.Equals(input as ArraySchema);
        }

        /// <summary>
        /// Returns true if ArraySchema instances are equal
        /// </summary>
        /// <param name="input">Instance of ArraySchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArraySchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version != null &&
                    input._Version != null &&
                    this._Version.SequenceEqual(input._Version)
                ) && 
                (
                    this.ArrayType == input.ArrayType ||
                    (this.ArrayType != null &&
                    this.ArrayType.Equals(input.ArrayType))
                ) && 
                (
                    this.TileOrder == input.TileOrder ||
                    (this.TileOrder != null &&
                    this.TileOrder.Equals(input.TileOrder))
                ) && 
                (
                    this.CellOrder == input.CellOrder ||
                    (this.CellOrder != null &&
                    this.CellOrder.Equals(input.CellOrder))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.CoordsFilterPipeline == input.CoordsFilterPipeline ||
                    (this.CoordsFilterPipeline != null &&
                    this.CoordsFilterPipeline.Equals(input.CoordsFilterPipeline))
                ) && 
                (
                    this.OffsetFilterPipeline == input.OffsetFilterPipeline ||
                    (this.OffsetFilterPipeline != null &&
                    this.OffsetFilterPipeline.Equals(input.OffsetFilterPipeline))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.AllowsDuplicates == input.AllowsDuplicates ||
                    (this.AllowsDuplicates != null &&
                    this.AllowsDuplicates.Equals(input.AllowsDuplicates))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.ArrayType != null)
                    hashCode = hashCode * 59 + this.ArrayType.GetHashCode();
                if (this.TileOrder != null)
                    hashCode = hashCode * 59 + this.TileOrder.GetHashCode();
                if (this.CellOrder != null)
                    hashCode = hashCode * 59 + this.CellOrder.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.CoordsFilterPipeline != null)
                    hashCode = hashCode * 59 + this.CoordsFilterPipeline.GetHashCode();
                if (this.OffsetFilterPipeline != null)
                    hashCode = hashCode * 59 + this.OffsetFilterPipeline.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AllowsDuplicates != null)
                    hashCode = hashCode * 59 + this.AllowsDuplicates.GetHashCode();
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