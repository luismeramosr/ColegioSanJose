using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_interface
{
    public abstract class ConexSqlLogin
    {
        private readonly string connectionString;
        public ConexSqlLogin()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=littman423;database=test_login";

        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
