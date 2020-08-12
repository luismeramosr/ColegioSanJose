using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;

namespace Datalib
{
    public class SQLServerManager
    {
        private SqlConnection conn;

        public SQLServerManager(string serverAddress, string databaseName)
        {            
            conn = new SqlConnection(string.Format("data source={0};"+
                    "integrated security=SSPI;database={1};", serverAddress, databaseName));
        }

        private void MapValueToType<T>(PropertyInfo prop, T rowData,
                                        SqlDataReader reader, int columnIndex)
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
                    if (prop.PropertyType.Equals(typeof(int)))
                        query += string.Format("{0},", prop.GetValue(obj));
                    else if (prop.PropertyType.Equals(typeof(string)))
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
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                conn.Close();
            }
            catch (SqlException err)
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
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

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

            catch (SqlException err)
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

            string query = string.Format("select * from {0} " +
                                         "where {1} = '{2}';",
                                         t.Name,
                                         props[column].Name,
                                         objectID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

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

            catch (SqlException err)
            {
                Console.WriteLine(err);
                return null;
            }
        }

        public T readRow<T>(string objectID, int columnIndex)
        {
            Type t = typeof(T);
            T rowData = new InstanceOf<T>().Create();
            PropertyInfo[] props = t.GetProperties();

            string query = string.Format("select * from {0} " +
                                         "where {1} = '{2}';",
                                         t.Name,
                                         props[columnIndex].Name,
                                         objectID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

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
            catch (SqlException err)
            {
                Console.WriteLine(err);
                return default(T);
            }
        }

        public void updateRow<T>(T obj)
        {
            string query = string.Format("update {0} " +
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
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteScalar();
                conn.Close();
            }
            catch (SqlException err)
            {
                Console.WriteLine(err);
            }
        }

        public void deleteRow<T>(T obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            string query = string.Format("delete from {0} " +
                                        "where {1} = '{2}';",
                                        obj.GetType().Name,
                                        props[0].Name,
                                        props[0].GetValue(obj));

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException err)
            {
                Console.WriteLine(err);
            }
        }

        public DataTable getDataTable(string query)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = new SqlCommand(query, conn);
            DataTable resultTable = new DataTable();
            ad.Fill(resultTable);
            return resultTable;
        }

    }
}
