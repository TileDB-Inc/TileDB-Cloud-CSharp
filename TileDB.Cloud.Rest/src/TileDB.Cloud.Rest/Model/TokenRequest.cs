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
    /// A request from a user for an api token
    /// </summary>
    [DataContract(Name = "TokenRequest")]
    public partial class TokenRequest : IEquatable<TokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        /// <param name="expires">Expiration date for token, if empty token defaults to 30 minutes.</param>
        /// <param name="name">Optional name for token, if the name already exists for the user it will be auto incremented (i.e. myToken-1).</param>
        /// <param name="scope">Optional scope to limit token, defaults to all permissions, current supported values are password_reset or *.</param>
        public TokenRequest(DateTime expires = default(DateTime), string name = default(string), List<TokenScope> scope = default(List<TokenScope>))
        {
            this.Expires = expires;
            this.Name = name;
            this.Scope = scope;
        }

        /// <summary>
        /// Expiration date for token, if empty token defaults to 30 minutes
        /// </summary>
        /// <value>Expiration date for token, if empty token defaults to 30 minutes</value>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Optional name for token, if the name already exists for the user it will be auto incremented (i.e. myToken-1)
        /// </summary>
        /// <value>Optional name for token, if the name already exists for the user it will be auto incremented (i.e. myToken-1)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional scope to limit token, defaults to all permissions, current supported values are password_reset or *
        /// </summary>
        /// <value>Optional scope to limit token, defaults to all permissions, current supported values are password_reset or *</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public List<TokenScope> Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenRequest {\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as TokenRequest);
        }

        /// <summary>
        /// Returns true if TokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
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
                if (this.Expires != null)
                {
                    hashCode = (hashCode * 59) + this.Expires.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
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
