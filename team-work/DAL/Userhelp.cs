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

        public static string ruid;

        public static void reuid(string Uid)
        {
            ruid = Uid;
        }

        //search id exists
        public static SqlDataReader ExistsID(string Uid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select count(1) from reader_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("reader_id=");
            stringBuilder.Append(Uid);
            return DBhelp.ExecuteReader(stringBuilder.ToString());
        }

        //check password
        public static SqlDataReader Password(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from reader_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("reader_id=");
            stringBuilder.Append(Uid);
            stringBuilder.Append(" and password=");
            stringBuilder.Append(pwd);
            return DBhelp.ExecuteReader(stringBuilder.ToString());
        }

        //check admin password
        public static SqlDataReader adminPassword(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from admin");
            stringBuilder.Append(" where ");
            stringBuilder.Append("admin_id=");
            stringBuilder.Append(Uid);
            stringBuilder.Append(" and password=");
            stringBuilder.Append(pwd);
            return DBhelp.ExecuteReader(stringBuilder.ToString());
        }

        public static bool ChangePassword(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update reader_info set ");
            stringBuilder.Append("password=");
            stringBuilder.Append(pwd);
            stringBuilder.Append("where reader_id=");
            stringBuilder.Append(Uid);
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

        public static bool adminChangePassword(string Uid, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update admin set ");
            stringBuilder.Append("password=");
            stringBuilder.Append(pwd);
            stringBuilder.Append("where admin_id=");
            stringBuilder.Append(Uid);
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

        public static bool register(string strsql)
        {
            int rows = DBhelp.ExecuteNonQuery(strsql);

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
