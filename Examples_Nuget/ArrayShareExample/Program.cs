using System;
using System.Collections.Generic;
using TileDB.Cloud.Rest.Model;

namespace ArrayShareExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string? token = null; // Set TileDB API token here
            string host = "https://api.tiledb.com";
            TileDB.Cloud.Client.Login(token: token, host: host);
            var userDetails = TileDB.Cloud.RestUtil.GetUser();

            // S3 location of file to convert to TileDB array
            string fromUriS3 = "s3://iledb-inc-demo-data/files/original/VLDB17_TileDB.pdf";
            // S3 location to store TileDB file array data
            string toUriS3 = "s3://iledb-inc-demo-data/files/original/VLDB17_TileDB";
            // Namespace to share array with
            string friendNamespace = "friend-namespace";
            Console.WriteLine($"Converting file '{fromUriS3}' to TileDB array stored at {toUriS3}");

            DeregisterArraysByUriS3(new() {toUriS3});

            #region File Creation

            string destArrayName = null; // Set name for TileDB Cloud array
            destArrayName ??= GetFileName(toUriS3); // If no preferred name was provided use file base name

            string destArrayNamespace = null; // Set namespace here for registering new TileDB Cloud array
            destArrayNamespace ??= userDetails.Username; // Use username as namespace if not set

            // Get TileDB ArrayApi from current Cloud Client
            var arrayApi = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            var fileCreated = TileDB.Cloud.RestUtil.CreateFile(userDetails.Username, fromUriS3, toUriS3, destArrayName);
            if (fileCreated != null)
            {
                Console.WriteLine($"File '{fileCreated.FileName}' created as TileDB array at {fileCreated.OutputUri}");
                Console.WriteLine($"TileDB file array details: {fileCreated.ToJson()}");
            }
            else
            {
                Console.WriteLine($"Unable to create TileDB array {toUriS3} from file at location {fromUriS3}");

                // Register an existing TileDB file array to TileDB Cloud
                Console.WriteLine("Registering existing TileDB file array");
                var arrayInfo = new ArrayInfoUpdate(uri: toUriS3, name: destArrayName);
                var infoNew = arrayApi.RegisterArray(destArrayNamespace, toUriS3, arrayInfo);
                if (infoNew != null)
                {
                    Console.WriteLine($"Registered new array with info: {infoNew.ToJson()}");
                }
                else
                {
                    Console.WriteLine("Unable to register array");
                }
            }

            #endregion

            #region Share Array

            // Build ArraySharing object with updated sharing policies
            // + An empty list of arraySharing.Actions will remove the namespace from sharing
            // + Permissions do not accumulate; Allowed actions will be replaced with new arraySharing.Actions
            // + Can initialize ArraySharing using ctor or properties
            var arraySharing = new ArraySharing(new() { ArrayActions.Read }, friendNamespace);
            // arraySharing.Namespace = "friend-namespace"; // Namespace to share the array with
            // arraySharing.Actions.Add(ArrayActions.Read); // Actions to allow from the new namespace we are sharing with

            Console.WriteLine($"ArraySharing configuration: {arraySharing.ToJson()}");
            arrayApi.ShareArray(userDetails.Username, destArrayName, arraySharing);

            #endregion
        }

        static string GetFileName(string uri) => uri.Trim('/')[(uri.LastIndexOf('/')+1)..];

        static void DeregisterArraysByUriS3(List<string> delArrays, string? nameSpace=null)
        {
            var userDetails = TileDB.Cloud.RestUtil.GetUser();
            if (delArrays.Count == 0)
            {
                Console.WriteLine($"No arrays specified to delete");
                return;
            }

            // Get all arrays attached to this namespace
            nameSpace ??= userDetails.Username;
            var arrays = TileDB.Cloud.RestUtil.ListArrays(nameSpace);
            if (arrays?.Arrays == null)
            {
                Console.WriteLine($"No arrays found in '{nameSpace}' namespace");
                return;
            }

            // Build list of arrays to deregister from TileDB Cloud (Will not delete S3 objects)
            List<ArrayInfo> deregisterList = new();
            foreach (var array in arrays.Arrays)
            {
                if (delArrays.Contains(array.Uri))
                {
                    deregisterList.Add(array);
                }
            }

            Console.WriteLine($"Collected {deregisterList.Count} arrays to deregister");
            DeregisterArrays(deregisterList);
        }

        static void DeregisterArrays(List<ArrayInfo> deregisterList)
        {
            var api = TileDB.Cloud.Client.GetInstance().GetArrayApi();
            // Reference array by Id instead of name in case of >1 array with same name
            deregisterList.ForEach(array => api.DeregisterArray(array.Namespace, array.Id));
        }
    }
}
