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

        public static int Lend_num()
        {
            int count;
            string c = "";
            SqlDataReader sqlDataReader = ExistsID(ruid);
            while (sqlDataReader.Read())
            {
                c = sqlDataReader["borrowable"].ToString();
            }
            sqlDataReader.Close();
            count = int.Parse(c);
            if(count != 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }

        public static bool User_lend()
        {
            int count;
            string c = "";
            SqlDataReader sqlDataReader = ExistsID(ruid);
            while (sqlDataReader.Read())
            {
                c = sqlDataReader["borrowable"].ToString();
            }
            sqlDataReader.Close();
            count = int.Parse(c);
            if(count == 0)
            {
                return false;
            }
            else
            {
                count--;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("update reader_info set borrowable='");
                stringBuilder.Append(count);
                stringBuilder.Append("' where reader_id='");
                stringBuilder.Append(ruid+"'");
                if (DBhelp.ExecuteNonQuery(stringBuilder.ToString()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool Record_Lend(string bookid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into lend_list(book_id, reader_id, " +
                "lend_date, back_date) values(");
            stringBuilder.Append("'" + bookid + "' ,");
            stringBuilder.Append("'" + ruid + "' ,");
            stringBuilder.Append("'" + DateTime.Now.ToShortDateString() + "' ,");
            stringBuilder.Append("'" + DateTime.Now.AddMonths(3).ToShortDateString() + "'");
            stringBuilder.Append(")");
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

        public static bool update_ustate()
        {
            int count = Lend_num();
            count++;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update reader_info set ");
            stringBuilder.Append("borrowable='");
            stringBuilder.Append(count + "'");
            stringBuilder.Append(" where reader_id='");
            stringBuilder.Append(ruid + "'");
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

        public static bool Back_book(string sernum)
        {
            string str = return_state(sernum);
            int state = int.Parse(str);
            if(state == 0)
            {
                return false;
            }
            else
            {
                state--;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("update lend_list set ");
                stringBuilder.Append("state='");
                stringBuilder.Append(state + "'");
                stringBuilder.Append(" where sernum='");
                stringBuilder.Append(sernum + "'");
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
        }

        public static string return_state(string sernum)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select state from lend_list");
            stringBuilder.Append(" where ");
            stringBuilder.Append("sernum=");
            stringBuilder.Append(sernum);
            SqlDataReader sqlDataReader = DBhelp.ExecuteReader(stringBuilder.ToString());
            string state = "";
            while (sqlDataReader.Read())
            {
                state = sqlDataReader["state"].ToString();
            }
            sqlDataReader.Close();
            return state;
        }

        //search id exists
        public static SqlDataReader ExistsID(string Uid)
        {
            Uid = Uid.Trim();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from reader_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("reader_id=");
            stringBuilder.Append(Uid);
            SqlDataReader sqlDataReader = DBhelp.ExecuteReader(stringBuilder.ToString());
            return sqlDataReader;
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

        public static bool Changeinfo(string Uid, string info)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update reader_info set ");
            stringBuilder.Append(info);
            stringBuilder.Append(" where reader_id=");
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

        public static DataTable ReaderInfoManage(string reader_id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from reader_info where reader_id LIKE '%");
            stringBuilder.Append(reader_id + "%'");
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }

        public static bool deleteReader(string reader_id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("delete from reader_info where reader_id = '");
            stringBuilder.Append(reader_id +"'");
            int row = DBhelp.ExecuteNonQuery(stringBuilder.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable UserTop()
        {
            StringBuilder userTop = new StringBuilder();
            userTop.Append("SELECT top(5) reader_info.name as '用户名',count(reader_info.name) as '借书最多的用户' " +
                "FROM reader_info LEFT JOIN lend_list ON reader_info.reader_id = lend_list.reader_id " +
                "group by reader_info.name " +
                "order by 借书最多的用户 desc");
            DataTable data = DBhelp.GetDataTable(userTop.ToString());
            return data;
        }
    }
}
