using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_interface
{
    class SQLServerManager
    {
        private SqlConnection conn;

        public SQLServerManager(string serverAddress, string databaseName)
        {            
            conn = new SqlConnection(string.Format("data source={0};"+
                    "integrated security=SSPI;database={1};", serverAddress, databaseName));
        }
    }
}
