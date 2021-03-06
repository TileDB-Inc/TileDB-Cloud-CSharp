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
    /// UDF Type
    /// </summary>
    /// <value>UDF Type</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UDFType
    {
        /// <summary>
        /// Enum Multiarray for value: multi_array
        /// </summary>
        [EnumMember(Value = "multi_array")]
        Multiarray = 1,

        /// <summary>
        /// Enum Singlearray for value: single_array
        /// </summary>
        [EnumMember(Value = "single_array")]
        Singlearray = 2,

        /// <summary>
        /// Enum Generic for value: generic
        /// </summary>
        [EnumMember(Value = "generic")]
        Generic = 3

    }

}
