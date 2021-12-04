using System;

namespace TileDB.Cloud
{
    public class Array
    {
        protected static TileDB.Cloud.Rest.Api.ArrayApi m_apiInstance = null;
        public static TileDB.Cloud.Rest.Api.ArrayApi ApiInstance()
        {
            if(m_apiInstance==null)
            {
                m_apiInstance = new Rest.Api.ArrayApi();
            }
            return m_apiInstance;
        }

        public static void DeleteArray(string username, string array, string contentType) {
            ApiInstance().DeleteArray(username, array, contentType);
        }

        public static TileDB.Cloud.Rest.Model.ArrayInfo GetArrayInfo(string username, string array)
        {
            return ApiInstance().GetArrayMetadata(username, array);
        }


    }
}
