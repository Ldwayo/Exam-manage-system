using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Bookhelp
    {
        public static bool AddBookinfo(string addinfo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into book_info(book_id, name," +
                " author, publish, introduction, price, pubdate, class_id," +
                " state,book_count) values(");
            stringBuilder.Append(addinfo + ")");
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

        //查询书籍信息
        public static DataTable QueryBook(string book_id, string author, string name, string press)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("select * from book_info where ");
            queryBuilder.Append("book_id LIKE  '%");
            queryBuilder.Append(book_id);
            queryBuilder.Append("%' and author LIKE '%");
            queryBuilder.Append(author);
            queryBuilder.Append("%' and name LIKE '%");
            queryBuilder.Append(name);
            /*queryBuilder.Append("' and name =  '");
            queryBuilder.Append(name);*/
            queryBuilder.Append("%' and publish LIKE '%");
            queryBuilder.Append(press+"%'");
            
            DataTable data =  DBhelp.GetDataTable(queryBuilder.ToString());
            return data;
        }
    }
}
