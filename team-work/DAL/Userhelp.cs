using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Userhelp
    {
        
        //search id exists
        public static SqlDataReader ExistsID(string Uid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select count(1) from reader_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("reader_id=@Uid");
            return DBhelp.ExecuteReader(stringBuilder.ToString());
        }

        //check password
        public static SqlDataReader Password(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from reader_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("reader_id=@Uid");
            stringBuilder.Append("and password=@pwd");
            return DBhelp.ExecuteReader(stringBuilder.ToString());
        }

        public static bool ChangePassword(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update reader_info set ");
            stringBuilder.Append("password=@pwd ");
            stringBuilder.Append("where reader_id=@Uid");
            int rows = DBhelp.ExecuteNonQuery(stringBuilder.ToString());

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable SelectAdmin()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from reader_info");
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }
    }
}
