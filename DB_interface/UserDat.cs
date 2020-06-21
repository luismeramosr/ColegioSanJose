using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DB_interface
{
    public class UserDat : ConexSqlLogin
    {
        public bool Login(string dni, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    
                    command.Connection = connection;
                    command.CommandText = "select * from `login` where `dniestu` = '"+dni+"' and `passestu` = '"+pass+"' ";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }


                }

            }

        }
    }
}
