using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DBhelp
    {
        private static SqlConnection connection;

        //database help class
        public static SqlConnection GetConnection
        {
            get
            {
                string strConn = "";
                if (connection == null)
                {
                    connection = new SqlConnection(strConn);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection = new SqlConnection(strConn);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        //return sqlcommand
        public static SqlCommand Command(string strSql)
        {
            using (SqlCommand cmd = new SqlCommand(strSql, GetConnection))
            {
                return cmd;
            }
        }

        //return sqldatareader
        public static SqlDataReader ExecuteReader(string strSql)
        {
            SqlCommand cmd = Command(strSql);
            return cmd.ExecuteReader();
        }

        //update insert delete the database
        public static int ExecuteNonQuery(string strSql)
        {
            SqlCommand cmd = Command(strSql);
            return cmd.ExecuteNonQuery();
        }


    }
}
