using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;



namespace DB_interface
{
    public class DB
    {
        private MySqlConnection conn;

        public DB(string hostIP, string username, string password, string databaseName)
        {
            conn = new MySqlConnection(string.Format("datasource={0};" + 
            "username={1};password={2};database={3}",hostIP,username,password,databaseName));
        }

        public List<T> readTable<T>(string query, T obj)
        {
            List<T> tableData = new List<T>();
            T rowData;
            PropertyInfo[] props;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rowData = (T) Activator.CreateInstance(obj.GetType());
                    props = rowData.GetType().GetProperties();

                    for (int i=0; i< reader.FieldCount; i++)
                    {
                        props[i].SetValue(rowData, reader.GetValue(i).ToString());
                    }

                    tableData.Add(rowData);
                    
                }

                conn.Close();

                return tableData;
            }
            
            catch (Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
        }

    }
}
