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
    /// actions a user can take on a UDF
    /// </summary>
    /// <value>actions a user can take on a UDF</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaskGraphActions
    {
        /// <summary>
        /// Enum Fetchtaskgraph for value: fetch_task_graph
        /// </summary>
        [EnumMember(Value = "fetch_task_graph")]
        Fetchtaskgraph = 1,

        /// <summary>
        /// Enum Sharetaskgraph for value: share_task_graph
        /// </summary>
        [EnumMember(Value = "share_task_graph")]
        Sharetaskgraph = 2

    }

}
