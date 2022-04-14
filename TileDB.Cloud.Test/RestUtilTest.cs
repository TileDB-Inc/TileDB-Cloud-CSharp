using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TileDB.Cloud;
namespace TileDB.Cloud.Test
{
    [TestClass]
    public class RestTest
    {
        [TestMethod]
        public void TestSplitUri()
        {
            string uri1 = "tiledb://user1/array_name";
            var (name_space_1, array_path1) = TileDB.Cloud.RestUtil.SplitUri(uri1);
            Assert.AreEqual<string>("user1", name_space_1);
            Assert.AreEqual<string>("array_name", array_path1);

            string uri2 = "s3://user2/array_name2";
            Assert.ThrowsException<ArgumentException>(()=>TileDB.Cloud.RestUtil.SplitUri(uri2));

        }


    }
}