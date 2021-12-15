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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Model;

namespace TileDB.Cloud.Rest.Test
{
    /// <summary>
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests
    {
        private TasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TasksApi
            //Assert.IsInstanceOf(typeof(TasksApi), instance);
        }

        
        /// <summary>
        /// Test RunSQL
        /// </summary>
        [Test]
        public void RunSQLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //SQLParameters sql = null;
            //string acceptEncoding = null;
            //var response = instance.RunSQL(_namespace, sql, acceptEncoding);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test TaskIdGet
        /// </summary>
        [Test]
        public void TaskIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TaskIdGet(id);
            //Assert.IsInstanceOf(typeof(ArrayTask), response, "response is ArrayTask");
        }
        
        /// <summary>
        /// Test TaskIdResultGet
        /// </summary>
        [Test]
        public void TaskIdResultGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptEncoding = null;
            //var response = instance.TaskIdResultGet(id, acceptEncoding);
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test TasksGet
        /// </summary>
        [Test]
        public void TasksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string createdBy = null;
            //string array = null;
            //int? start = null;
            //int? end = null;
            //int? page = null;
            //int? perPage = null;
            //string type = null;
            //List<string> excludeType = null;
            //List<string> fileType = null;
            //List<string> excludeFileType = null;
            //string status = null;
            //string search = null;
            //string orderby = null;
            //var response = instance.TasksGet(_namespace, createdBy, array, start, end, page, perPage, type, excludeType, fileType, excludeFileType, status, search, orderby);
            //Assert.IsInstanceOf(typeof(ArrayTaskData), response, "response is ArrayTaskData");
        }
        
    }

}