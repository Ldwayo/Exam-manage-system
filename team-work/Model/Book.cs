using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /*
     * BooksManage  book_info的实体 
     */
    class Book
    {
        private int _bookid;
        private string _bookName;
        private string _author;
        private string _publish;
        private string _introduce;
        private decimal _price;
        private DateTime _pubdate;
        private int _bookClass;
        private int _state;

        public string BookName { get => _bookName; set => _bookName = value; }
        public int BookClass { get => _bookClass; set => _bookClass = value; }
        public decimal Price { get => _price; set => _price = value; }
        public int Bookid { get => _bookid; set => _bookid = value; }
        public string Author { get => _author; set => _author = value; }
        public string Publish { get => _publish; set => _publish = value; }
        public string Introduce { get => _introduce; set => _introduce = value; }
        public DateTime Pubdate { get => _pubdate; set => _pubdate = value; }
        public int State { get => _state; set => _state = value; }
    }
}
