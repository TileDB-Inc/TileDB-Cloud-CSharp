using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileDB.Cloud
{
    public class Client
    {
        protected static TileDB.Cloud.Rest.Client.ApiClient m_apiInstance = null;
        public static TileDB.Cloud.Rest.Client.ApiClient ApiInstance()
        {
            if (m_apiInstance == null)
            {
                m_apiInstance = new Rest.Client.ApiClient();
            }
            return m_apiInstance;
        }



    }
}
