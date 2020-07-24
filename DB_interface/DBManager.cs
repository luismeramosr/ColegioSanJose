using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace DB_interface
{
    public class DBManager
    {
        private MySqlConnection conn;

        public DBManager(string hostIP,string port ,string username, string password, string databaseName)
        {
            conn = new MySqlConnection(string.Format("datasource={0};port={1};" + 
            "username={2};password={3};database={4}",hostIP,port,username,password,databaseName));
        }

        public DBManager(string hostIP, string username, string password, string databaseName)
        {
            string port = "3306";
            conn = new MySqlConnection(string.Format("datasource={0};port={1};" +
            "username={2};password={3};database={4}", hostIP, port, username, password, databaseName));
        }

        public void insertRow<T>()
        {
            Type t = typeof(T);
            PropertyInfo[] props = t.GetProperties();
            string query = string.Format("insert into `{0}` values(",
                                         t.Name);

            foreach (PropertyInfo prop in props)
            {
                query += string.Format("'{0}',", prop.GetValue(t));
            }

            query = query.Substring(0, (query.Length - 1)) + ");";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                conn.Close();
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err);
            }
        }

        public List<T> readTable<T>()
        {
            Type t = typeof(T);
            List<T> tableData = new List<T>();
            T rowData;
            PropertyInfo[] props = t.GetProperties();

            string query = string.Format("select * from {0};",
                                         t.Name);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rowData = new InstanceOf<T>().Create();                 

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        props[i].SetValue(rowData, reader.GetValue(i).ToString());
                    }
                    tableData.Add(rowData);
                }
                conn.Close();
                return tableData;
            }
            
            catch (MySqlException err)
            {
                Console.WriteLine(err);
                return null;
            }
        }

        public List<T> readTable<T>(string objectID, int column)
        {
            Type t = typeof(T);
            List<T> tableData = new List<T>();
            T rowData;
            PropertyInfo[] props = t.GetProperties();

            string query = string.Format("select * from {0} "+
                                         "where {1} = '{2}';",
                                         t.Name,
                                         props[column].Name,
                                         objectID);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rowData = new InstanceOf<T>().Create();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        props[i].SetValue(rowData, reader.GetValue(i).ToString());
                    }
                    tableData.Add(rowData);
                }
                conn.Close();
                return tableData;
            }

            catch (MySqlException err)
            {
                Console.WriteLine(err);
                return null;
            }
        }

        public T readRow<T>(string objectID)
        {
            Type anyType = typeof(T);
            T rowData = new InstanceOf<T>().Create();
            PropertyInfo[] props = anyType.GetProperties();

            string query = string.Format("select * from {0} "+
                                         "where {1} = '{2}';",
                                         anyType.Name,
                                         props[0].Name,
                                         objectID);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {                            
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        props[i].SetValue(rowData, reader.GetValue(i).ToString());
                    }
                }
                conn.Close();
                return rowData;
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err);
                return default(T);
            }
        }
        
        public void updateRow<T>()
        {
            Type t = typeof(T);
            string query = string.Format("update {0} "+
                                         "set ", t.Name);

            PropertyInfo[] props = t.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                query += prop.Name + " = '" + prop.GetValue(t) + "',";
            }
            query = query.Substring(0, (query.Length - 1));
            query += string.Format("where {0} = '{1}';",
                                    props[0].Name,
                                    props[0].GetValue(t));

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err);
            }
        }

        public void deleteRow<T>()
        {
            Type t = typeof(T);
            PropertyInfo[] props = t.GetProperties();
            string query = string.Format("delete from {0} "+
                                        "where {1} = '{2}';",
                                        t.Name,
                                        props[0].Name,
                                        props[0].GetValue(t));

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err);
            }
        }

    }
}
