using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace Datalib
{
    public class MySQLManager
    {
        private MySqlConnection conn;

        public MySQLManager(string hostIP,string port ,string username, string password, string databaseName)
        {
            conn = new MySqlConnection(string.Format("datasource={0};port={1};" + 
            "username={2};password={3};database={4}",hostIP,port,username,password,databaseName));
        }

        public MySQLManager(string hostIP, string username, string password, string databaseName)
        {
            string port = "3306";
            conn = new MySqlConnection(string.Format("datasource={0};port={1};" +
            "username={2};password={3};database={4}", hostIP, port, username, password, databaseName));
        }

        private void MapValueToType<T>(PropertyInfo prop, T rowData,
                                        MySqlDataReader reader, int columnIndex)
        {
            if (prop.PropertyType.Equals(typeof(int)))
                prop.SetValue(rowData, reader.GetInt32(columnIndex));
            else if (prop.PropertyType.Equals(typeof(string)))
                prop.SetValue(rowData, reader.GetValue(columnIndex).ToString());
        }

        private string MakeQueryFromType<T>(PropertyInfo prop, T obj,
                                            string queryType)
        {
            string query = "";
            switch (queryType)
            {
                case "update":
                    if (prop.PropertyType.Equals(typeof(int)))
                        query += string.Format("{0}={1},", prop.Name, prop.GetValue(obj));                    
                    else if (prop.PropertyType.Equals(typeof(string)))
                        query += string.Format("{0}='{1}',", prop.Name, prop.GetValue(obj));
                    break;

                case "insert":
                    if(prop.PropertyType.Equals(typeof(int)))
                        query += string.Format("{0},", prop.GetValue(obj));
                    else if(prop.PropertyType.Equals(typeof(string)))
                        query += string.Format("'{0}',", prop.GetValue(obj));
                    break;
            }
            return query;
        }

        public void insertRow<T>(T obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            string query = string.Format("insert into `{0}` values(",
                                         obj.GetType().Name);

            foreach (PropertyInfo prop in props)
            {
                MakeQueryFromType(prop, obj, "insert");
            }

            query = query.Substring(0, (query.Length - 1)) + ");";

            try
            {
                if (conn.State==System.Data.ConnectionState.Closed)
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
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rowData = new InstanceOf<T>().Create();                 

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        MapValueToType(props[i], rowData, reader, i);
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
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rowData = new InstanceOf<T>().Create();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        MapValueToType(props[i], rowData, reader, i);
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

        public T readRow<T>(T obj,string objectID)
        {
            T rowData = new InstanceOf<T>().Create();
            PropertyInfo[] props = obj.GetType().GetProperties();

            string query = string.Format("select * from {0} "+
                                         "where {1} = '{2}';",
                                         obj.GetType().Name,
                                         props[0].Name,
                                         objectID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {                            
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        MapValueToType(props[i], rowData, reader, i);
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
        
        public void updateRow<T>(T obj)
        {
            string query = string.Format("update {0} "+
                                         "set ", obj.GetType().Name);

            PropertyInfo[] props = obj.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                query += MakeQueryFromType(prop, obj, "update");
            }
            
            query = query.Substring(0, (query.Length - 1));
            query += string.Format(" where {0} = '{1}';",
                                    props[0].Name,
                                    props[0].GetValue(obj));
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteScalar();
                conn.Close();
            }
            catch (MySqlException err)
            {
                Console.WriteLine(err);
            }
        }

        public void deleteRow<T>(T obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            string query = string.Format("delete from {0} "+
                                        "where {1} = '{2}';",
                                        obj.GetType().Name,
                                        props[0].Name,
                                        props[0].GetValue(obj));

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
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
