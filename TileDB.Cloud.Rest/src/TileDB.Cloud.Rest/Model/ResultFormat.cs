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
    /// Data format of a result
    /// </summary>
    /// <value>Data format of a result</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultFormat
    {
        /// <summary>
        /// Enum PythonPickle for value: python_pickle
        /// </summary>
        [EnumMember(Value = "python_pickle")]
        PythonPickle = 1,

        /// <summary>
        /// Enum RSerialization for value: r_serialization
        /// </summary>
        [EnumMember(Value = "r_serialization")]
        RSerialization = 2,

        /// <summary>
        /// Enum Json for value: json
        /// </summary>
        [EnumMember(Value = "json")]
        Json = 3,

        /// <summary>
        /// Enum Arrow for value: arrow
        /// </summary>
        [EnumMember(Value = "arrow")]
        Arrow = 4,

        /// <summary>
        /// Enum Bytes for value: bytes
        /// </summary>
        [EnumMember(Value = "bytes")]
        Bytes = 5,

        /// <summary>
        /// Enum TiledbJson for value: tiledb_json
        /// </summary>
        [EnumMember(Value = "tiledb_json")]
        TiledbJson = 6,

        /// <summary>
        /// Enum Native for value: native
        /// </summary>
        [EnumMember(Value = "native")]
        Native = 7

    }

}
