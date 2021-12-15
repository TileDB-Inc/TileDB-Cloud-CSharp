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
    ///  Class for testing NotebooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NotebooksApiTests
    {
        private NotebooksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NotebooksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotebooksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' NotebooksApi
            //Assert.IsInstanceOf(typeof(NotebooksApi), instance);
        }

        
        /// <summary>
        /// Test NotebooksNamespaceArrayEndTimestampsGet
        /// </summary>
        [Test]
        public void NotebooksNamespaceArrayEndTimestampsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.NotebooksNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
            //Assert.IsInstanceOf(typeof(ArrayEndTimestampData), response, "response is ArrayEndTimestampData");
        }
        
    }

}