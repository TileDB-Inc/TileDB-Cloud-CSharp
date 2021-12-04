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
    ///  Class for testing UdfApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UdfApiTests
    {
        private UdfApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UdfApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UdfApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UdfApi
            //Assert.IsInstanceOf(typeof(UdfApi), instance);
        }

        
        /// <summary>
        /// Test DeleteUDFInfo
        /// </summary>
        [Test]
        public void DeleteUDFInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //instance.DeleteUDFInfo(_namespace, name);
            
        }
        
        /// <summary>
        /// Test GetUDFInfo
        /// </summary>
        [Test]
        public void GetUDFInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //var response = instance.GetUDFInfo(_namespace, name);
            //Assert.IsInstanceOf(typeof(UDFInfo), response, "response is UDFInfo");
        }
        
        /// <summary>
        /// Test GetUDFInfoSharingPolicies
        /// </summary>
        [Test]
        public void GetUDFInfoSharingPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //var response = instance.GetUDFInfoSharingPolicies(_namespace, name);
            //Assert.IsInstanceOf(typeof(List<UDFSharing>), response, "response is List<UDFSharing>");
        }
        
        /// <summary>
        /// Test RegisterUDFInfo
        /// </summary>
        [Test]
        public void RegisterUDFInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //UDFInfoUpdate udf = null;
            //instance.RegisterUDFInfo(_namespace, name, udf);
            
        }
        
        /// <summary>
        /// Test ShareUDFInfo
        /// </summary>
        [Test]
        public void ShareUDFInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //UDFSharing udfSharing = null;
            //instance.ShareUDFInfo(_namespace, name, udfSharing);
            
        }
        
        /// <summary>
        /// Test SubmitGenericUDF
        /// </summary>
        [Test]
        public void SubmitGenericUDFTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //GenericUDF udf = null;
            //string acceptEncoding = null;
            //var response = instance.SubmitGenericUDF(_namespace, udf, acceptEncoding);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SubmitMultiArrayUDF
        /// </summary>
        [Test]
        public void SubmitMultiArrayUDFTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //MultiArrayUDF udf = null;
            //string acceptEncoding = null;
            //var response = instance.SubmitMultiArrayUDF(_namespace, udf, acceptEncoding);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SubmitUDF
        /// </summary>
        [Test]
        public void SubmitUDFTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //MultiArrayUDF udf = null;
            //string xPayer = null;
            //string acceptEncoding = null;
            //string v2 = null;
            //var response = instance.SubmitUDF(_namespace, array, udf, xPayer, acceptEncoding, v2);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test UdfNamespaceArrayEndTimestampsGet
        /// </summary>
        [Test]
        public void UdfNamespaceArrayEndTimestampsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.UdfNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
            //Assert.IsInstanceOf(typeof(ArrayEndTimestampData), response, "response is ArrayEndTimestampData");
        }
        
        /// <summary>
        /// Test UpdateUDFInfo
        /// </summary>
        [Test]
        public void UpdateUDFInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string name = null;
            //UDFInfoUpdate udf = null;
            //instance.UpdateUDFInfo(_namespace, name, udf);
            
        }
        
    }

}
