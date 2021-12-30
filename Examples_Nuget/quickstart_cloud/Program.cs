 
using TileDB;
using System;



//Login
string host = "https://api.tiledb.com"; //default host
string api_key = System.Environment.GetEnvironmentVariable("REST_TOKEN_KEY"); //default token
TileDB.Cloud.Client.Login(token:api_key,host:host);
//TileDB.Cloud.Client.Login(); // use default values

// Get User information
var user_details = TileDB.Cloud.RestUtil.GetUser();
System.Console.WriteLine("{0}", user_details.ToJson());

//Array uri infos
string original_file = "s3://tiledb-inc-demo-data/files/original/VLDB17_TileDB.pdf";

//TileDB File details
string tiledb_file_name = "VLDB17_TileDB_Example";
string tiledb_file_s3_uri = user_details.DefaultS3Path + "/" + tiledb_file_name;
System.Console.WriteLine("tiledb_file_s3_uri:{0}", tiledb_file_s3_uri);

//Delete the file array if exists
var arrayinfo = TileDB.Cloud.RestUtil.GetArrayInfo(user_details.Username, tiledb_file_s3_uri);
if(arrayinfo != null) {
    System.Console.WriteLine("{0}", arrayinfo.ToJson());
    System.Console.WriteLine("Now start to delete {0}",tiledb_file_s3_uri );
    TileDB.Cloud.RestUtil.DeleteArray(user_details.Username, tiledb_file_s3_uri, "application/json");
}
else {
    System.Console.WriteLine("can not find uri: {0}", tiledb_file_s3_uri);
}

//Try to create a file array
var file_details = TileDB.Cloud.RestUtil.CreateFile(user_details.Username, original_file, tiledb_file_s3_uri, tiledb_file_name);
if(file_details == null) 
{
    System.Console.WriteLine("failed to create file:{0}", tiledb_file_s3_uri);
} 
else {
    System.Console.WriteLine("{0}", file_details.ToJson());
}

arrayinfo = TileDB.Cloud.RestUtil.GetArrayInfo(user_details.Username,tiledb_file_s3_uri);
if(arrayinfo==null)
{
    System.Console.WriteLine("failed to get array info for uri:{0}",tiledb_file_s3_uri);
}
else {
    System.Console.WriteLine("{0}",arrayinfo.ToJson());
}

//auth keys
string aws_key_id =  System.Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"); // or read from elsewhere
string aws_key_secret =  System.Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY"); // or read from elsewhere


TileDB.Config cfg = new TileDB.Config();
cfg.set("vfs.s3.aws_access_key_id",aws_key_id);
cfg.set("vfs.s3.aws_secret_access_key",aws_key_secret);
//if your aws region is not us-east-1, you also need to set the region
//cfg.set("vfs.s3.region", "us-east-2");
var ctx = new TileDB.Context(cfg);

//Add metadata

//if you donot use using statement block, please call array_write.close() at the end to materialize it on disk
using(var array_write = new TileDB.Array(ctx, tiledb_file_s3_uri, TileDB.QueryType.TILEDB_WRITE))
{
    // add int metadata
    System.Collections.Generic.List<int> int_metadata = new System.Collections.Generic.List<int>() {1,100};
    array_write.AddArrayMetadataByList<int>("int_metadata",int_metadata);
    // add double metadata
    var double_metadata = new System.Collections.Generic.List<double>() {1.0,100.0,1000.0};
    array_write.AddArrayMetadataByList<double>("double_metadata", double_metadata);
    // add string key value pair 
    array_write.AddArrayMetadataByStringKeyValue("key1","value1");
    // add multiple string key value pairs 
    var key_value_map = new System.Collections.Generic.Dictionary<string,string>();
    key_value_map["key2"] = "value2";
    key_value_map["key3"] = "value3";
    array_write.AddArrayMetadataByStringMap(key_value_map);    

}

//Get metadata
//open the array to read
var array_read = new TileDB.Array(ctx,tiledb_file_s3_uri, TileDB.QueryType.TILEDB_READ);

//get metadata from index
var metadata_json = array_read.GetArrayMetadataJsonFromIndex(0);
System.Console.WriteLine("{0}", metadata_json.ToString());

//get metadata from key
var double_metadata_json = array_read.GetArrayMetadataJsonForKey("double_metadata");
System.Console.WriteLine("{0}", double_metadata_json.ToString());
var double_list = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<double>>(double_metadata_json["value"].ToString());
System.Console.WriteLine("type of double_list:{0}, value of double_list:{1}",double_list.GetType(),string.Join(",",double_list));

// get string metadata
var string_metadata_json = array_read.GetArrayMetadataJsonForKey("key2");
System.Console.WriteLine("{0}", string_metadata_json.ToString());
// access key and value
System.Console.WriteLine("{0}:{1}",string_metadata_json["key"],string_metadata_json["value"]);

//get all metadata
var all_metadata_json = array_read.GetArrayMetadataJson();
System.Console.WriteLine("{0}", all_metadata_json.ToString());

//Catalog searching
System.Collections.Generic.List<string> file_types = new System.Collections.Generic.List<string>();
file_types.Add(TileDB.Cloud.Rest.Model.FileType.File.ToString());

//List owned arrays
var arrayList = TileDB.Cloud.RestUtil.ListArrays(username:user_details.Username,file_types:file_types);
Console.WriteLine("{0}", arrayList.ToJson());

//List public arrays
var listPublicArrays = TileDB.Cloud.RestUtil.ListPublicArrays(username:user_details.Username,file_types:file_types);
Console.WriteLine("{0}", listPublicArrays.ToJson());

//List shared arrays
var listSharedArrays = TileDB.Cloud.RestUtil.ListSharedArrays(username:user_details.Username, file_types:file_types);
Console.WriteLine("{0}", listSharedArrays.ToJson());

//Export from tiledb to s3
string export_s3_uri = user_details.DefaultS3Path + "/" + "exported.pdf";

var file_exported = TileDB.Cloud.RestUtil.ExportFile(user_details.Username, tiledb_file_s3_uri, export_s3_uri);
if (file_exported == null)
{
    System.Console.WriteLine("failed export from {0} to {1}", tiledb_file_s3_uri, export_s3_uri);
}
else
{
    System.Console.WriteLine("{0}", file_exported.ToJson());
}

//Export between local file and cloud array
TileDB.Config cfg2 = new TileDB.Config();
cfg2.set("vfs.s3.aws_access_key_id",aws_key_id);
cfg2.set("vfs.s3.aws_secret_access_key",aws_key_secret);
cfg2.set("vfs.s3.region", "us-east-2");
TileDB.Context ctx2 = new TileDB.Context(cfg2);

//export file array to local file, The function in RestUtil will be deprecated
//TileDB.Cloud.RestUtil.ExportFileArrayToLocalFile(ctx2, "s3://stefan-region-test/image_tdb", "image_exported.tiff");
TileDB.CoreUtil.ExportArrayToFile(ctx2, "s3://stefan-region-test/image_tdb", "image_exported.tiff" );

//export local file image_exported.tiff
//TileDB.Cloud.RestUtil.SaveLocalFileToFileArray(ctx2, "s3://tiledb-bin/image_tdb", "image_exported.tiff","","");
TileDB.CoreUtil.SaveFileToArray(ctx2,"s3://tiledb-bin/image_tdb", "image_exported.tiff","","");
