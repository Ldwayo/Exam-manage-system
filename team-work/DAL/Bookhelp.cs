using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*public static bool SearchBook(string searchinfo)
        {

        }*/
    }
}
