using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /* 
     * BooksManage 的 class_info 的实体
     */
    class Bookclass
    {
        private int _classId;
        private string _className;

        public int ClassId { get => _classId; set => _classId = value; }
        public string ClassName { get => _className; set => _className = value; }
    }
}
