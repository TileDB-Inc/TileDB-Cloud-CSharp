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
    /// Specific file types of group members
    /// </summary>
    /// <value>Specific file types of group members</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupMemberAssetType
    {
        /// <summary>
        /// Enum Group for value: group
        /// </summary>
        [EnumMember(Value = "group")]
        Group = 1,

        /// <summary>
        /// Enum Array for value: array
        /// </summary>
        [EnumMember(Value = "array")]
        Array = 2,

        /// <summary>
        /// Enum Notebook for value: notebook
        /// </summary>
        [EnumMember(Value = "notebook")]
        Notebook = 3,

        /// <summary>
        /// Enum Dashboard for value: dashboard
        /// </summary>
        [EnumMember(Value = "dashboard")]
        Dashboard = 4,

        /// <summary>
        /// Enum UserDefinedFunction for value: user_defined_function
        /// </summary>
        [EnumMember(Value = "user_defined_function")]
        UserDefinedFunction = 5,

        /// <summary>
        /// Enum MlModel for value: ml_model
        /// </summary>
        [EnumMember(Value = "ml_model")]
        MlModel = 6,

        /// <summary>
        /// Enum File for value: file
        /// </summary>
        [EnumMember(Value = "file")]
        File = 7

    }

}
