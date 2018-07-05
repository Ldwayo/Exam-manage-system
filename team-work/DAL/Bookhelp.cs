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
        //增加新书
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

        //更新图书
        public static bool UpdateBook(string bookid,string name,string author,string press,
            string intro,string price,string pubdate, string classid,string state,string bookCount )
        {
            StringBuilder updateBuilder = new StringBuilder();
            updateBuilder.Append("update book_info set ");
            updateBuilder.Append("name = '");
            updateBuilder.Append(name);
            updateBuilder.Append("' , author = '");
            updateBuilder.Append(author);
            updateBuilder.Append("' , publish = '");
            updateBuilder.Append(press);
            updateBuilder.Append("' , introduction = '");
            updateBuilder.Append(intro);
            updateBuilder.Append("' , price = '");
            updateBuilder.Append(price);
            updateBuilder.Append("' , pubdate = '");
            updateBuilder.Append(pubdate);
            updateBuilder.Append("' , class_id = '");
            updateBuilder.Append(classid);
            updateBuilder.Append("' , state = '");
            updateBuilder.Append(state);
            updateBuilder.Append("' , book_count = '");
            updateBuilder.Append(bookCount);
            updateBuilder.Append("' where book_id = '");
            updateBuilder.Append(bookid+"'");

            int row = DBhelp.ExecuteNonQuery(updateBuilder.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //删除图书
        public static bool DeleteBook(string bookid)
        {
            StringBuilder deleteBuilder = new StringBuilder();
            deleteBuilder.Append("delete from book_info where book_id = '");
            deleteBuilder.Append(bookid+"'");
            int row = DBhelp.ExecuteNonQuery(deleteBuilder.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
