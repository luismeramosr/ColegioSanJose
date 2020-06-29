using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;



namespace DB_interface
{
    public class DB
    {
        private MySqlConnection conn;

        public DB(string hostIP,string port ,string username, string password, string databaseName)
        {
            if (port == "") port = "3306";
            conn = new MySqlConnection(string.Format("datasource={0};port={1};" + 
            "username={2};password={3};database={4}",hostIP,port,username,password,databaseName));
        }

        #region readTable
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
                    rowData = (T)Activator.CreateInstance(obj.GetType());
                    props = rowData.GetType().GetProperties();

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
        #endregion

        #region writeTable
        public void writeTable<T>(T obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            string query = string.Format("insert into `{0}`(",obj.GetType().Name);

            foreach (PropertyInfo prop in props)
            {
                query += string.Format("`{0}`,",prop.Name);
            }

            query = query.Substring(0,(query.Length - 1)) + ") values(";

            foreach (PropertyInfo prop in props)
            {
                query += string.Format("'{0}',", prop.GetValue(obj));
            }

            query = query.Substring(0, (query.Length - 1)) + ")";                     

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
        #endregion
    }
}
