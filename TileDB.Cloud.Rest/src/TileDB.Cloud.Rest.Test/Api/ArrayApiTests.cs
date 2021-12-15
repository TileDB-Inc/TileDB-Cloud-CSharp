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
    ///  Class for testing ArrayApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ArrayApiTests
    {
        private ArrayApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ArrayApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ArrayApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ArrayApi
            //Assert.IsInstanceOf(typeof(ArrayApi), instance);
        }

        
        /// <summary>
        /// Test ArrayActivityLog
        /// </summary>
        [Test]
        public void ArrayActivityLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? start = null;
            //int? end = null;
            //string eventTypes = null;
            //string taskId = null;
            //bool? hasTaskId = null;
            //var response = instance.ArrayActivityLog(_namespace, array, start, end, eventTypes, taskId, hasTaskId);
            //Assert.IsInstanceOf(typeof(List<ArrayActivityLog>), response, "response is List<ArrayActivityLog>");
        }
        
        /// <summary>
        /// Test ArraysBrowserOwnedGet
        /// </summary>
        [Test]
        public void ArraysBrowserOwnedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string search = null;
            //string _namespace = null;
            //string orderby = null;
            //string permissions = null;
            //List<string> tag = null;
            //List<string> excludeTag = null;
            //List<string> fileType = null;
            //List<string> excludeFileType = null;
            //List<string> fileProperty = null;
            //var response = instance.ArraysBrowserOwnedGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
            //Assert.IsInstanceOf(typeof(ArrayBrowserData), response, "response is ArrayBrowserData");
        }
        
        /// <summary>
        /// Test ArraysBrowserOwnedSidebarGet
        /// </summary>
        [Test]
        public void ArraysBrowserOwnedSidebarGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ArraysBrowserOwnedSidebarGet();
            //Assert.IsInstanceOf(typeof(ArrayBrowserSidebar), response, "response is ArrayBrowserSidebar");
        }
        
        /// <summary>
        /// Test ArraysBrowserPublicGet
        /// </summary>
        [Test]
        public void ArraysBrowserPublicGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string search = null;
            //string _namespace = null;
            //string orderby = null;
            //string permissions = null;
            //List<string> tag = null;
            //List<string> excludeTag = null;
            //List<string> fileType = null;
            //List<string> excludeFileType = null;
            //List<string> fileProperty = null;
            //var response = instance.ArraysBrowserPublicGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
            //Assert.IsInstanceOf(typeof(ArrayBrowserData), response, "response is ArrayBrowserData");
        }
        
        /// <summary>
        /// Test ArraysBrowserPublicSidebarGet
        /// </summary>
        [Test]
        public void ArraysBrowserPublicSidebarGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ArraysBrowserPublicSidebarGet();
            //Assert.IsInstanceOf(typeof(ArrayBrowserSidebar), response, "response is ArrayBrowserSidebar");
        }
        
        /// <summary>
        /// Test ArraysBrowserSharedGet
        /// </summary>
        [Test]
        public void ArraysBrowserSharedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string search = null;
            //string _namespace = null;
            //string orderby = null;
            //string permissions = null;
            //List<string> tag = null;
            //List<string> excludeTag = null;
            //List<string> fileType = null;
            //List<string> excludeFileType = null;
            //List<string> fileProperty = null;
            //var response = instance.ArraysBrowserSharedGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
            //Assert.IsInstanceOf(typeof(ArrayBrowserData), response, "response is ArrayBrowserData");
        }
        
        /// <summary>
        /// Test ArraysBrowserSharedSidebarGet
        /// </summary>
        [Test]
        public void ArraysBrowserSharedSidebarGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ArraysBrowserSharedSidebarGet();
            //Assert.IsInstanceOf(typeof(ArrayBrowserSidebar), response, "response is ArrayBrowserSidebar");
        }
        
        /// <summary>
        /// Test ArraysNamespaceArrayEndTimestampsGet
        /// </summary>
        [Test]
        public void ArraysNamespaceArrayEndTimestampsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ArraysNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
            //Assert.IsInstanceOf(typeof(ArrayEndTimestampData), response, "response is ArrayEndTimestampData");
        }
        
        /// <summary>
        /// Test ConsolidateArray
        /// </summary>
        [Test]
        public void ConsolidateArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //TileDBConfig tiledbConfig = null;
            //instance.ConsolidateArray(_namespace, array, tiledbConfig);
            
        }
        
        /// <summary>
        /// Test CreateArray
        /// </summary>
        [Test]
        public void CreateArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string contentType = null;
            //ArraySchema arraySchema = null;
            //string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null;
            //instance.CreateArray(_namespace, array, contentType, arraySchema, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME);
            
        }
        
        /// <summary>
        /// Test DeleteArray
        /// </summary>
        [Test]
        public void DeleteArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string contentType = null;
            //instance.DeleteArray(_namespace, array, contentType);
            
        }
        
        /// <summary>
        /// Test DeregisterArray
        /// </summary>
        [Test]
        public void DeregisterArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //instance.DeregisterArray(_namespace, array);
            
        }
        
        /// <summary>
        /// Test GetActivityLogById
        /// </summary>
        [Test]
        public void GetActivityLogByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string id = null;
            //var response = instance.GetActivityLogById(_namespace, array, id);
            //Assert.IsInstanceOf(typeof(ArrayActivityLog), response, "response is ArrayActivityLog");
        }
        
        /// <summary>
        /// Test GetAllArrayMetadata
        /// </summary>
        [Test]
        public void GetAllArrayMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicShare = null;
            //var response = instance.GetAllArrayMetadata(publicShare);
            //Assert.IsInstanceOf(typeof(List<ArrayInfo>), response, "response is List<ArrayInfo>");
        }
        
        /// <summary>
        /// Test GetArray
        /// </summary>
        [Test]
        public void GetArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string contentType = null;
            //var response = instance.GetArray(_namespace, array, contentType);
            //Assert.IsInstanceOf(typeof(ArraySchema), response, "response is ArraySchema");
        }
        
        /// <summary>
        /// Test GetArrayMaxBufferSizes
        /// </summary>
        [Test]
        public void GetArrayMaxBufferSizesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string subarray = null;
            //string contentType = null;
            //string xPayer = null;
            //var response = instance.GetArrayMaxBufferSizes(_namespace, array, subarray, contentType, xPayer);
            //Assert.IsInstanceOf(typeof(MaxBufferSizes), response, "response is MaxBufferSizes");
        }
        
        /// <summary>
        /// Test GetArrayMetaDataJson
        /// </summary>
        [Test]
        public void GetArrayMetaDataJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? length = null;
            //int? endTimestamp = null;
            //var response = instance.GetArrayMetaDataJson(_namespace, array, length, endTimestamp);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test GetArrayMetadata
        /// </summary>
        [Test]
        public void GetArrayMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //var response = instance.GetArrayMetadata(_namespace, array);
            //Assert.IsInstanceOf(typeof(ArrayInfo), response, "response is ArrayInfo");
        }
        
        /// <summary>
        /// Test GetArrayMetadataCapnp
        /// </summary>
        [Test]
        public void GetArrayMetadataCapnpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //var response = instance.GetArrayMetadataCapnp(_namespace, array);
            //Assert.IsInstanceOf(typeof(ArrayMetadata), response, "response is ArrayMetadata");
        }
        
        /// <summary>
        /// Test GetArrayNonEmptyDomain
        /// </summary>
        [Test]
        public void GetArrayNonEmptyDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //string contentType = null;
            //string xPayer = null;
            //var response = instance.GetArrayNonEmptyDomain(_namespace, array, contentType, xPayer);
            //Assert.IsInstanceOf(typeof(NonEmptyDomain), response, "response is NonEmptyDomain");
        }
        
        /// <summary>
        /// Test GetArrayNonEmptyDomainJson
        /// </summary>
        [Test]
        public void GetArrayNonEmptyDomainJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //var response = instance.GetArrayNonEmptyDomainJson(_namespace, array);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test GetArraySampleData
        /// </summary>
        [Test]
        public void GetArraySampleDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //decimal? samples = null;
            //var response = instance.GetArraySampleData(_namespace, array, samples);
            //Assert.IsInstanceOf(typeof(ArraySample), response, "response is ArraySample");
        }
        
        /// <summary>
        /// Test GetArraySharingPolicies
        /// </summary>
        [Test]
        public void GetArraySharingPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //var response = instance.GetArraySharingPolicies(_namespace, array);
            //Assert.IsInstanceOf(typeof(List<ArraySharing>), response, "response is List<ArraySharing>");
        }
        
        /// <summary>
        /// Test GetArraysInNamespace
        /// </summary>
        [Test]
        public void GetArraysInNamespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //var response = instance.GetArraysInNamespace(_namespace);
            //Assert.IsInstanceOf(typeof(List<ArrayInfo>), response, "response is List<ArrayInfo>");
        }
        
        /// <summary>
        /// Test GetFragmentEndTimestamp
        /// </summary>
        [Test]
        public void GetFragmentEndTimestampTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //int? endTimestamp = null;
            //var response = instance.GetFragmentEndTimestamp(_namespace, array, endTimestamp);
            //Assert.IsInstanceOf(typeof(int), response, "response is int");
        }
        
        /// <summary>
        /// Test GetLastAccessedArrays
        /// </summary>
        [Test]
        public void GetLastAccessedArraysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLastAccessedArrays();
            //Assert.IsInstanceOf(typeof(List<LastAccessedArray>), response, "response is List<LastAccessedArray>");
        }
        
        /// <summary>
        /// Test RegisterArray
        /// </summary>
        [Test]
        public void RegisterArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //ArrayInfoUpdate arrayMetadata = null;
            //instance.RegisterArray(_namespace, array, arrayMetadata);
            
        }
        
        /// <summary>
        /// Test ShareArray
        /// </summary>
        [Test]
        public void ShareArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //ArraySharing arraySharing = null;
            //instance.ShareArray(_namespace, array, arraySharing);
            
        }
        
        /// <summary>
        /// Test UpdateArrayMetadata
        /// </summary>
        [Test]
        public void UpdateArrayMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //ArrayInfoUpdate arrayMetadata = null;
            //instance.UpdateArrayMetadata(_namespace, array, arrayMetadata);
            
        }
        
        /// <summary>
        /// Test UpdateArrayMetadataCapnp
        /// </summary>
        [Test]
        public void UpdateArrayMetadataCapnpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //ArrayMetadata arrayMetadataEntries = null;
            //instance.UpdateArrayMetadataCapnp(_namespace, array, arrayMetadataEntries);
            
        }
        
        /// <summary>
        /// Test VacuumArray
        /// </summary>
        [Test]
        public void VacuumArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string array = null;
            //TileDBConfig tiledbConfig = null;
            //instance.VacuumArray(_namespace, array, tiledbConfig);
            
        }
        
    }

}