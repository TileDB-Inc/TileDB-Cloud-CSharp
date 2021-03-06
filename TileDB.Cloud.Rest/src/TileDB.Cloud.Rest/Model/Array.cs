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
    /// Represents an open array
    /// </summary>
    [DataContract]
    public partial class Array :  IEquatable<Array>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets QueryType
        /// </summary>
        [DataMember(Name="queryType", EmitDefaultValue=true)]
        public Querytype QueryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Array" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Array() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Array" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp (epoch milliseconds) array is opened at (required).</param>
        /// <param name="queryType">queryType (required).</param>
        /// <param name="uri">Array uri (required).</param>
        public Array(decimal timestamp = default(decimal), Querytype queryType = default(Querytype), string uri = default(string))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Array and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }

            // to ensure "queryType" is required (not null)
            if (queryType == null)
            {
                throw new InvalidDataException("queryType is a required property for Array and cannot be null");
            }
            else
            {
                this.QueryType = queryType;
            }

            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for Array and cannot be null");
            }
            else
            {
                this.Uri = uri;
            }

        }

        /// <summary>
        /// timestamp (epoch milliseconds) array is opened at
        /// </summary>
        /// <value>timestamp (epoch milliseconds) array is opened at</value>
        [DataMember(Name="timestamp", EmitDefaultValue=true)]
        public decimal Timestamp { get; set; }


        /// <summary>
        /// Array uri
        /// </summary>
        /// <value>Array uri</value>
        [DataMember(Name="uri", EmitDefaultValue=true)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Array {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as Array);
        }

        /// <summary>
        /// Returns true if Array instances are equal
        /// </summary>
        /// <param name="input">Instance of Array to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Array input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.QueryType != null)
                    hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
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
