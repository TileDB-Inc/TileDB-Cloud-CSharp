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
    /// The location where an individual node of a task graph is executed. 
    /// </summary>
    /// <value>The location where an individual node of a task graph is executed. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskGraphLogRunLocation
    {
        /// <summary>
        /// Enum Server for value: server
        /// </summary>
        [EnumMember(Value = "server")]
        Server = 1,

        /// <summary>
        /// Enum Client for value: client
        /// </summary>
        [EnumMember(Value = "client")]
        Client = 2,

        /// <summary>
        /// Enum Virtual for value: virtual
        /// </summary>
        [EnumMember(Value = "virtual")]
        Virtual = 3

    }

}
