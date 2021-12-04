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
    /// User-defined function
    /// </summary>
    [DataContract]
    public partial class GenericUDF :  IEquatable<GenericUDF>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public UDFLanguage? Language { get; set; }
        /// <summary>
        /// Gets or Sets ResultFormat
        /// </summary>
        [DataMember(Name="result_format", EmitDefaultValue=false)]
        public ResultFormat? ResultFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericUDF" /> class.
        /// </summary>
        /// <param name="udfInfoName">name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec.</param>
        /// <param name="language">language.</param>
        /// <param name="version">Type-specific version.</param>
        /// <param name="imageName">Docker image name to use for udf.</param>
        /// <param name="exec">Type-specific executable text.</param>
        /// <param name="execRaw">optional raw text to store of serialized function, used for showing in UI.</param>
        /// <param name="argument">Argument(s) to pass to udf function, tuple or list of args/kwargs which can be in native or json format.</param>
        /// <param name="storedParamUuids">The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}..</param>
        /// <param name="resultFormat">resultFormat.</param>
        /// <param name="taskName">name of task, optional.</param>
        /// <param name="storeResults">store results for later retrieval.</param>
        public GenericUDF(string udfInfoName = default(string), UDFLanguage? language = default(UDFLanguage?), string version = default(string), string imageName = default(string), string exec = default(string), string execRaw = default(string), string argument = default(string), List<string> storedParamUuids = default(List<string>), ResultFormat? resultFormat = default(ResultFormat?), string taskName = default(string), bool storeResults = default(bool))
        {
            this.UdfInfoName = udfInfoName;
            this.Language = language;
            this._Version = version;
            this.ImageName = imageName;
            this.Exec = exec;
            this.ExecRaw = execRaw;
            this.Argument = argument;
            this.StoredParamUuids = storedParamUuids;
            this.ResultFormat = resultFormat;
            this.TaskName = taskName;
            this.StoreResults = storeResults;
        }

        /// <summary>
        /// name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec
        /// </summary>
        /// <value>name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec</value>
        [DataMember(Name="udf_info_name", EmitDefaultValue=false)]
        public string UdfInfoName { get; set; }


        /// <summary>
        /// Type-specific version
        /// </summary>
        /// <value>Type-specific version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string _Version { get; set; }

        /// <summary>
        /// Docker image name to use for udf
        /// </summary>
        /// <value>Docker image name to use for udf</value>
        [DataMember(Name="image_name", EmitDefaultValue=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// Type-specific executable text
        /// </summary>
        /// <value>Type-specific executable text</value>
        [DataMember(Name="exec", EmitDefaultValue=false)]
        public string Exec { get; set; }

        /// <summary>
        /// optional raw text to store of serialized function, used for showing in UI
        /// </summary>
        /// <value>optional raw text to store of serialized function, used for showing in UI</value>
        [DataMember(Name="exec_raw", EmitDefaultValue=false)]
        public string ExecRaw { get; set; }

        /// <summary>
        /// Argument(s) to pass to udf function, tuple or list of args/kwargs which can be in native or json format
        /// </summary>
        /// <value>Argument(s) to pass to udf function, tuple or list of args/kwargs which can be in native or json format</value>
        [DataMember(Name="argument", EmitDefaultValue=false)]
        public string Argument { get; set; }

        /// <summary>
        /// The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}.
        /// </summary>
        /// <value>The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}.</value>
        [DataMember(Name="stored_param_uuids", EmitDefaultValue=false)]
        public List<string> StoredParamUuids { get; set; }


        /// <summary>
        /// name of task, optional
        /// </summary>
        /// <value>name of task, optional</value>
        [DataMember(Name="task_name", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// store results for later retrieval
        /// </summary>
        /// <value>store results for later retrieval</value>
        [DataMember(Name="store_results", EmitDefaultValue=false)]
        public bool StoreResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericUDF {\n");
            sb.Append("  UdfInfoName: ").Append(UdfInfoName).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  Exec: ").Append(Exec).Append("\n");
            sb.Append("  ExecRaw: ").Append(ExecRaw).Append("\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
            sb.Append("  StoredParamUuids: ").Append(StoredParamUuids).Append("\n");
            sb.Append("  ResultFormat: ").Append(ResultFormat).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  StoreResults: ").Append(StoreResults).Append("\n");
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
            return this.Equals(input as GenericUDF);
        }

        /// <summary>
        /// Returns true if GenericUDF instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericUDF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericUDF input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UdfInfoName == input.UdfInfoName ||
                    (this.UdfInfoName != null &&
                    this.UdfInfoName.Equals(input.UdfInfoName))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.Exec == input.Exec ||
                    (this.Exec != null &&
                    this.Exec.Equals(input.Exec))
                ) && 
                (
                    this.ExecRaw == input.ExecRaw ||
                    (this.ExecRaw != null &&
                    this.ExecRaw.Equals(input.ExecRaw))
                ) && 
                (
                    this.Argument == input.Argument ||
                    (this.Argument != null &&
                    this.Argument.Equals(input.Argument))
                ) && 
                (
                    this.StoredParamUuids == input.StoredParamUuids ||
                    this.StoredParamUuids != null &&
                    input.StoredParamUuids != null &&
                    this.StoredParamUuids.SequenceEqual(input.StoredParamUuids)
                ) && 
                (
                    this.ResultFormat == input.ResultFormat ||
                    (this.ResultFormat != null &&
                    this.ResultFormat.Equals(input.ResultFormat))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.StoreResults == input.StoreResults ||
                    (this.StoreResults != null &&
                    this.StoreResults.Equals(input.StoreResults))
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
                if (this.UdfInfoName != null)
                    hashCode = hashCode * 59 + this.UdfInfoName.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.Exec != null)
                    hashCode = hashCode * 59 + this.Exec.GetHashCode();
                if (this.ExecRaw != null)
                    hashCode = hashCode * 59 + this.ExecRaw.GetHashCode();
                if (this.Argument != null)
                    hashCode = hashCode * 59 + this.Argument.GetHashCode();
                if (this.StoredParamUuids != null)
                    hashCode = hashCode * 59 + this.StoredParamUuids.GetHashCode();
                if (this.ResultFormat != null)
                    hashCode = hashCode * 59 + this.ResultFormat.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.StoreResults != null)
                    hashCode = hashCode * 59 + this.StoreResults.GetHashCode();
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
