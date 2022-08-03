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

            string fromUriS3 = "s3://shaun.reed/VLDB17_TileDB.pdf";
            string toUriS3 = "s3://shaun.reed/TileDB-PDF";
            Console.WriteLine($"Converting file '{fromUriS3}' to TileDB array stored at {toUriS3}");

            DeregisterArraysByUriS3(delAll: true);

            #region File Creation

            string destArrayName = null; // Set name for TileDB Cloud array
            destArrayName ??= GetFileName(toUriS3);

            var fileCreated = TileDB.Cloud.RestUtil.CreateFile(userDetails.Username, fromUriS3, toUriS3, destArrayName);
            if (fileCreated != null)
            {
                Console.WriteLine($"File '{fileCreated.FileName}' created as TileDB array at {fileCreated.OutputUri}");
                Console.WriteLine($"TileDB file array details: {fileCreated.ToJson()}");
            }
            else
            {
                Console.WriteLine($"Unable to create TileDB array {toUriS3} from file at location {fromUriS3}");
            }

            #endregion

            #region Register Array

            // Get TileDB ArrayApi from current Cloud Client
            var arrayApi = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            string arrayNamespace = null; // Set namespace here for registering new TileDB Cloud array
            arrayNamespace ??= userDetails.Username; // Use username as namespace if not set

            // Register the new TileDB array to TileDB Cloud
            var arrayInfo = new ArrayInfoUpdate(uri: toUriS3, name: destArrayName);
            var infoNew = arrayApi.RegisterArray(arrayNamespace, toUriS3, arrayInfo);
            if (infoNew != null)
            {
                Console.WriteLine($"Registered new array with info: {infoNew.ToJson()}");
            }
            else
            {
                Console.WriteLine("Unable to register array");
            }

            #endregion

            #region Share Array

            // Build ArraySharing object with updated sharing policies
            // + An empty list of arraySharing.Actions will remove the namespace from sharing
            // + Permissions do not accumulate; Allowed actions will be replaced with new arraySharing.Actions
            // + Can initialize ArraySharing using ctor or properties
            var arraySharing = new ArraySharing(new() { ArrayActions.Read }, "shaunrd0");
            // arraySharing.Namespace = "friend-namespace"; // Namespace to share the array with
            // arraySharing.Actions.Add(ArrayActions.Read); // Actions to allow from the new namespace we are sharing with

            Console.WriteLine($"ArraySharing configuration: {arraySharing.ToJson()}");
            arrayApi.ShareArray(userDetails.Username, infoNew?.Id, arraySharing);

            #endregion
        }

        static string GetFileName(string uri) => uri.Trim('/')[(uri.LastIndexOf('/')+1)..];

        static void DeregisterArraysByUriS3(List<string>? delArrays=null, string? nameSpace=null, bool delAll=false)
        {
            var userDetails = TileDB.Cloud.RestUtil.GetUser();
            if (delArrays == null && delAll == false)
            {
                Console.WriteLine($"No arrays specified to delete; Set delAll parameter to true to delete all in namespace");
                return;
            }
            nameSpace ??= userDetails.Username;
            // Get all arrays attached to this namespace
            var arrays = TileDB.Cloud.RestUtil.ListArrays(nameSpace);
            // Build list of arrays to deregister from TileDB Cloud (Will not delete S3 objects)
            List<(string nameSpace, string id)> deleteList = new();
            if (arrays?.Arrays != null)
            {
                // Collect arrays to delete
                foreach (var array in arrays.Arrays)
                {
                    if (delArrays != null && !delArrays.Contains(array.Uri))
                    {
                        continue;
                    }
                    // Reference array by Id instead of name in case of >1 array with same name
                    deleteList.Add((array.Namespace, array.Id));
                }

                Console.WriteLine($"Deleting {deleteList.Count} arrays");
                DeleteArrays(deleteList);
            }
            else
            {
                Console.WriteLine($"No arrays found in '{nameSpace}' namespace");
            }
        }

        static void DeleteArrays(List<(string nameSpace, string id)> deleteList)
        {
            var api = TileDB.Cloud.Client.GetInstance().GetArrayApi();
            deleteList.ForEach(array => api.DeregisterArray(array.nameSpace, array.id));
        }
    }
}
