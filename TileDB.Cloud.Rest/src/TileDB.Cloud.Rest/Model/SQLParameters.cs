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
    /// Parameters for running sql query
    /// </summary>
    [DataContract]
    public partial class SQLParameters :  IEquatable<SQLParameters>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResultFormat
        /// </summary>
        [DataMember(Name="result_format", EmitDefaultValue=false)]
        public ResultFormat? ResultFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SQLParameters" /> class.
        /// </summary>
        /// <param name="name">name of task, optional.</param>
        /// <param name="query">query to run.</param>
        /// <param name="outputUri">Output array uri.</param>
        /// <param name="storeResults">store results for later retrieval.</param>
        /// <param name="dontDownloadResults">Set to true to avoid downloading the results of this UDF. Useful for intermediate nodes in a task graph where you will not be using the results of your function. Defaults to false (\&quot;yes download results\&quot;)..</param>
        /// <param name="resourceClass">The resource class to use for the SQL execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the SQL will execute in the standard resource class of the TileDB Cloud provider. .</param>
        /// <param name="resultFormat">resultFormat.</param>
        /// <param name="initCommands">Queries or commands to run before main query.</param>
        /// <param name="parameters">SQL query parameters.</param>
        /// <param name="taskGraphUuid">If set, the ID of the log for the task graph that this was part of. .</param>
        /// <param name="clientNodeUuid">If set, the client-defined ID of the node within this task&#39;s graph. .</param>
        public SQLParameters(string name = default(string), string query = default(string), string outputUri = default(string), bool storeResults = default(bool), bool dontDownloadResults = default(bool), string resourceClass = default(string), ResultFormat? resultFormat = default(ResultFormat?), List<string> initCommands = default(List<string>), List<Object> parameters = default(List<Object>), string taskGraphUuid = default(string), string clientNodeUuid = default(string))
        {
            this.Name = name;
            this.Query = query;
            this.OutputUri = outputUri;
            this.StoreResults = storeResults;
            this.DontDownloadResults = dontDownloadResults;
            this.ResourceClass = resourceClass;
            this.ResultFormat = resultFormat;
            this.InitCommands = initCommands;
            this.Parameters = parameters;
            this.TaskGraphUuid = taskGraphUuid;
            this.ClientNodeUuid = clientNodeUuid;
        }

        /// <summary>
        /// name of task, optional
        /// </summary>
        /// <value>name of task, optional</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// query to run
        /// </summary>
        /// <value>query to run</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Output array uri
        /// </summary>
        /// <value>Output array uri</value>
        [DataMember(Name="output_uri", EmitDefaultValue=false)]
        public string OutputUri { get; set; }

        /// <summary>
        /// store results for later retrieval
        /// </summary>
        /// <value>store results for later retrieval</value>
        [DataMember(Name="store_results", EmitDefaultValue=false)]
        public bool StoreResults { get; set; }

        /// <summary>
        /// Set to true to avoid downloading the results of this UDF. Useful for intermediate nodes in a task graph where you will not be using the results of your function. Defaults to false (\&quot;yes download results\&quot;).
        /// </summary>
        /// <value>Set to true to avoid downloading the results of this UDF. Useful for intermediate nodes in a task graph where you will not be using the results of your function. Defaults to false (\&quot;yes download results\&quot;).</value>
        [DataMember(Name="dont_download_results", EmitDefaultValue=false)]
        public bool DontDownloadResults { get; set; }

        /// <summary>
        /// The resource class to use for the SQL execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the SQL will execute in the standard resource class of the TileDB Cloud provider. 
        /// </summary>
        /// <value>The resource class to use for the SQL execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the SQL will execute in the standard resource class of the TileDB Cloud provider. </value>
        [DataMember(Name="resource_class", EmitDefaultValue=false)]
        public string ResourceClass { get; set; }


        /// <summary>
        /// Queries or commands to run before main query
        /// </summary>
        /// <value>Queries or commands to run before main query</value>
        [DataMember(Name="init_commands", EmitDefaultValue=false)]
        public List<string> InitCommands { get; set; }

        /// <summary>
        /// SQL query parameters
        /// </summary>
        /// <value>SQL query parameters</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Object> Parameters { get; set; }

        /// <summary>
        /// If set, the ID of the log for the task graph that this was part of. 
        /// </summary>
        /// <value>If set, the ID of the log for the task graph that this was part of. </value>
        [DataMember(Name="task_graph_uuid", EmitDefaultValue=false)]
        public string TaskGraphUuid { get; set; }

        /// <summary>
        /// If set, the client-defined ID of the node within this task&#39;s graph. 
        /// </summary>
        /// <value>If set, the client-defined ID of the node within this task&#39;s graph. </value>
        [DataMember(Name="client_node_uuid", EmitDefaultValue=false)]
        public string ClientNodeUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SQLParameters {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  OutputUri: ").Append(OutputUri).Append("\n");
            sb.Append("  StoreResults: ").Append(StoreResults).Append("\n");
            sb.Append("  DontDownloadResults: ").Append(DontDownloadResults).Append("\n");
            sb.Append("  ResourceClass: ").Append(ResourceClass).Append("\n");
            sb.Append("  ResultFormat: ").Append(ResultFormat).Append("\n");
            sb.Append("  InitCommands: ").Append(InitCommands).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  TaskGraphUuid: ").Append(TaskGraphUuid).Append("\n");
            sb.Append("  ClientNodeUuid: ").Append(ClientNodeUuid).Append("\n");
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
            return this.Equals(input as SQLParameters);
        }

        /// <summary>
        /// Returns true if SQLParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SQLParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SQLParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.OutputUri == input.OutputUri ||
                    (this.OutputUri != null &&
                    this.OutputUri.Equals(input.OutputUri))
                ) && 
                (
                    this.StoreResults == input.StoreResults ||
                    (this.StoreResults != null &&
                    this.StoreResults.Equals(input.StoreResults))
                ) && 
                (
                    this.DontDownloadResults == input.DontDownloadResults ||
                    (this.DontDownloadResults != null &&
                    this.DontDownloadResults.Equals(input.DontDownloadResults))
                ) && 
                (
                    this.ResourceClass == input.ResourceClass ||
                    (this.ResourceClass != null &&
                    this.ResourceClass.Equals(input.ResourceClass))
                ) && 
                (
                    this.ResultFormat == input.ResultFormat ||
                    (this.ResultFormat != null &&
                    this.ResultFormat.Equals(input.ResultFormat))
                ) && 
                (
                    this.InitCommands == input.InitCommands ||
                    this.InitCommands != null &&
                    input.InitCommands != null &&
                    this.InitCommands.SequenceEqual(input.InitCommands)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.TaskGraphUuid == input.TaskGraphUuid ||
                    (this.TaskGraphUuid != null &&
                    this.TaskGraphUuid.Equals(input.TaskGraphUuid))
                ) && 
                (
                    this.ClientNodeUuid == input.ClientNodeUuid ||
                    (this.ClientNodeUuid != null &&
                    this.ClientNodeUuid.Equals(input.ClientNodeUuid))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.OutputUri != null)
                    hashCode = hashCode * 59 + this.OutputUri.GetHashCode();
                if (this.StoreResults != null)
                    hashCode = hashCode * 59 + this.StoreResults.GetHashCode();
                if (this.DontDownloadResults != null)
                    hashCode = hashCode * 59 + this.DontDownloadResults.GetHashCode();
                if (this.ResourceClass != null)
                    hashCode = hashCode * 59 + this.ResourceClass.GetHashCode();
                if (this.ResultFormat != null)
                    hashCode = hashCode * 59 + this.ResultFormat.GetHashCode();
                if (this.InitCommands != null)
                    hashCode = hashCode * 59 + this.InitCommands.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.TaskGraphUuid != null)
                    hashCode = hashCode * 59 + this.TaskGraphUuid.GetHashCode();
                if (this.ClientNodeUuid != null)
                    hashCode = hashCode * 59 + this.ClientNodeUuid.GetHashCode();
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
