using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TileDB.Cloud.Test
{
    [TestClass]
    public class RestTest
    {
        [TestMethod]
        public void TestSplitUri()
        {
            string uri1 = "tiledb://user1/array_name";
            var (name_space_1, array_path1) = RestUtil.SplitUri(uri1);
            Assert.AreEqual("user1", name_space_1);
            Assert.AreEqual("array_name", array_path1);

            string uri2 = "s3://user2/array_name2";
            Assert.ThrowsException<ArgumentException>(() => RestUtil.SplitUri(uri2));
        }
    }
}
