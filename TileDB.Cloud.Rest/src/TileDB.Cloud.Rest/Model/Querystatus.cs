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
    /// Status of query
    /// </summary>
    /// <value>Status of query</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Querystatus
    {
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 1,

        /// <summary>
        /// Enum COMPLETED for value: COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED = 2,

        /// <summary>
        /// Enum INPROGRESS for value: INPROGRESS
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS = 3,

        /// <summary>
        /// Enum INCOMPLETE for value: INCOMPLETE
        /// </summary>
        [EnumMember(Value = "INCOMPLETE")]
        INCOMPLETE = 4,

        /// <summary>
        /// Enum UNINITIALIZED for value: UNINITIALIZED
        /// </summary>
        [EnumMember(Value = "UNINITIALIZED")]
        UNINITIALIZED = 5

    }

}
