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
    /// Metadata about the environment where we want to execute a UDF.
    /// </summary>
    [DataContract(Name = "TGUDFEnvironment")]
    public partial class TGUDFEnvironment : IEquatable<TGUDFEnvironment>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public UDFLanguage? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TGUDFEnvironment" /> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="languageVersion">The language version used to execute this UDF. Neither this nor &#x60;language&#x60; needs to be set for registered UDFs, since the language and version are stored server-side with the UDF itself. .</param>
        /// <param name="imageName">The name of the image to use for the execution environment. .</param>
        /// <param name="_namespace">If set, the non-default namespace to execute this UDF under (and to query any Array Nodes that are used as inputs to this UDF). .</param>
        /// <param name="resourceClass">The resource class to use for the UDF execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the UDF will execute in the standard resource class of the TileDB Cloud provider. .</param>
        /// <param name="runClientSide">A hint that, if possible, this function should be executed on the client side rather than on the server. Registered UDFs and functions which take arrays as inputs can never be executed client-side. If the client’s environment is incompatible, or the client does not support client-side execution, the function will be executed on the server. .</param>
        /// <param name="timeout">The maximum length of time this UDF is allowed to execute for before it is killed and fails. If not present (or zero), the function is allowed to run indefinitely (subject to the server’s global limits). .</param>
        public TGUDFEnvironment(UDFLanguage? language = default(UDFLanguage?), string languageVersion = default(string), string imageName = default(string), string _namespace = default(string), string resourceClass = default(string), bool runClientSide = default(bool), decimal? timeout = default(decimal?))
        {
            this.Language = language;
            this.LanguageVersion = languageVersion;
            this.ImageName = imageName;
            this.Namespace = _namespace;
            this.ResourceClass = resourceClass;
            this.RunClientSide = runClientSide;
            this.Timeout = timeout;
        }

        /// <summary>
        /// The language version used to execute this UDF. Neither this nor &#x60;language&#x60; needs to be set for registered UDFs, since the language and version are stored server-side with the UDF itself. 
        /// </summary>
        /// <value>The language version used to execute this UDF. Neither this nor &#x60;language&#x60; needs to be set for registered UDFs, since the language and version are stored server-side with the UDF itself. </value>
        [DataMember(Name = "language_version", EmitDefaultValue = false)]
        public string LanguageVersion { get; set; }

        /// <summary>
        /// The name of the image to use for the execution environment. 
        /// </summary>
        /// <value>The name of the image to use for the execution environment. </value>
        [DataMember(Name = "image_name", EmitDefaultValue = false)]
        public string ImageName { get; set; }

        /// <summary>
        /// If set, the non-default namespace to execute this UDF under (and to query any Array Nodes that are used as inputs to this UDF). 
        /// </summary>
        /// <value>If set, the non-default namespace to execute this UDF under (and to query any Array Nodes that are used as inputs to this UDF). </value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// The resource class to use for the UDF execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the UDF will execute in the standard resource class of the TileDB Cloud provider. 
        /// </summary>
        /// <value>The resource class to use for the UDF execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the UDF will execute in the standard resource class of the TileDB Cloud provider. </value>
        [DataMember(Name = "resource_class", EmitDefaultValue = false)]
        public string ResourceClass { get; set; }

        /// <summary>
        /// A hint that, if possible, this function should be executed on the client side rather than on the server. Registered UDFs and functions which take arrays as inputs can never be executed client-side. If the client’s environment is incompatible, or the client does not support client-side execution, the function will be executed on the server. 
        /// </summary>
        /// <value>A hint that, if possible, this function should be executed on the client side rather than on the server. Registered UDFs and functions which take arrays as inputs can never be executed client-side. If the client’s environment is incompatible, or the client does not support client-side execution, the function will be executed on the server. </value>
        [DataMember(Name = "run_client_side", EmitDefaultValue = true)]
        public bool RunClientSide { get; set; }

        /// <summary>
        /// The maximum length of time this UDF is allowed to execute for before it is killed and fails. If not present (or zero), the function is allowed to run indefinitely (subject to the server’s global limits). 
        /// </summary>
        /// <value>The maximum length of time this UDF is allowed to execute for before it is killed and fails. If not present (or zero), the function is allowed to run indefinitely (subject to the server’s global limits). </value>
        [DataMember(Name = "timeout", EmitDefaultValue = true)]
        public decimal? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TGUDFEnvironment {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LanguageVersion: ").Append(LanguageVersion).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ResourceClass: ").Append(ResourceClass).Append("\n");
            sb.Append("  RunClientSide: ").Append(RunClientSide).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as TGUDFEnvironment);
        }

        /// <summary>
        /// Returns true if TGUDFEnvironment instances are equal
        /// </summary>
        /// <param name="input">Instance of TGUDFEnvironment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TGUDFEnvironment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.LanguageVersion == input.LanguageVersion ||
                    (this.LanguageVersion != null &&
                    this.LanguageVersion.Equals(input.LanguageVersion))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ResourceClass == input.ResourceClass ||
                    (this.ResourceClass != null &&
                    this.ResourceClass.Equals(input.ResourceClass))
                ) && 
                (
                    this.RunClientSide == input.RunClientSide ||
                    this.RunClientSide.Equals(input.RunClientSide)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                hashCode = (hashCode * 59) + this.Language.GetHashCode();
                if (this.LanguageVersion != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageVersion.GetHashCode();
                }
                if (this.ImageName != null)
                {
                    hashCode = (hashCode * 59) + this.ImageName.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.ResourceClass != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceClass.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RunClientSide.GetHashCode();
                if (this.Timeout != null)
                {
                    hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
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
