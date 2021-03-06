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
    ///  Class for testing RegisteredTaskGraphsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RegisteredTaskGraphsApiTests
    {
        private RegisteredTaskGraphsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RegisteredTaskGraphsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RegisteredTaskGraphsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RegisteredTaskGraphsApi
            //Assert.IsInstanceOf(typeof(RegisteredTaskGraphsApi), instance);
        }

        
        /// <summary>
        /// Test DeleteRegisteredTaskGraph
        /// </summary>
        [Test]
        public void DeleteRegisteredTaskGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //instance.DeleteRegisteredTaskGraph(_namespace, name);
            
        }
        
        /// <summary>
        /// Test GetRegisteredTaskGraph
        /// </summary>
        [Test]
        public void GetRegisteredTaskGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //var response = instance.GetRegisteredTaskGraph(_namespace, name);
            //Assert.IsInstanceOf(typeof(RegisteredTaskGraph), response, "response is RegisteredTaskGraph");
        }
        
        /// <summary>
        /// Test GetRegisteredTaskGraphSharingPolicies
        /// </summary>
        [Test]
        public void GetRegisteredTaskGraphSharingPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //var response = instance.GetRegisteredTaskGraphSharingPolicies(_namespace, name);
            //Assert.IsInstanceOf(typeof(List<TaskGraphSharing>), response, "response is List<TaskGraphSharing>");
        }
        
        /// <summary>
        /// Test RegisterRegisteredTaskGraph
        /// </summary>
        [Test]
        public void RegisterRegisteredTaskGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //RegisteredTaskGraph graph = null;
            //instance.RegisterRegisteredTaskGraph(_namespace, name, graph);
            
        }
        
        /// <summary>
        /// Test ShareRegisteredTaskGraph
        /// </summary>
        [Test]
        public void ShareRegisteredTaskGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //TaskGraphSharing taskGraphSharing = null;
            //instance.ShareRegisteredTaskGraph(_namespace, name, taskGraphSharing);
            
        }
        
        /// <summary>
        /// Test UpdateRegisteredTaskGraph
        /// </summary>
        [Test]
        public void UpdateRegisteredTaskGraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //RegisteredTaskGraph graph = null;
            //instance.UpdateRegisteredTaskGraph(_namespace, name, graph);
            
        }
        
    }

}
