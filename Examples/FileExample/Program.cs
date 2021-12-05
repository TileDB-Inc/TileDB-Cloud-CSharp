using System;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cfg = (new TileDB.Cloud.Config()).GetConfig();

            TileDB.Cloud.Rest.Model.User userprofile = TileDB.Cloud.RestUtil.GetUser(cfg);
            Console.WriteLine("{0}", userprofile.ToJson());
            
            var arrayList = TileDB.Cloud.RestUtil.ListArrays(userprofile.Username, cfg: cfg);
            Console.WriteLine("{0}", arrayList.ToJson());
            
            var listPublicArrays = TileDB.Cloud.RestUtil.ListPublicArrays(userprofile.Username, cfg: cfg);
            Console.WriteLine("{0}", listPublicArrays.ToJson());
            
            var listSharedArrays = TileDB.Cloud.RestUtil.ListSharedArrays(userprofile.Username, cfg: cfg);
            Console.WriteLine("{0}", listSharedArrays.ToJson());
        }
    }
}