using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace team_work
{
    public partial class Back_Book : Form
    {
        public string sernum = "";
        public int count;
        public string bookid;
        public int bookcount;
        public Back_Book()
        {
            InitializeComponent();
            init_grid();
            count = Userhelp.Lend_num();
            name.Text = Userhelp.ruid;
            lend_num.Text = count.ToString();
        }

        public void init_grid()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string strsql = "select * from lend_list";
            stringBuilder.Append(strsql);
            stringBuilder.Append(" where reader_id='");
            stringBuilder.Append(Userhelp.ruid + "'");
            stringBuilder.Append(" and state != 0");
            DataTable dataTable = DBhelp.GetDataTable(stringBuilder.ToString());
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Book_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!sernum.Equals(""))
            {
                if (Userhelp.Back_book(sernum))
                {
                    Userhelp.update_ustate();
                    bookcount = Bookhelp.BookNum(bookid);
                    bookcount++;
                    Bookhelp.UpdateBook_lend(bookid, bookcount.ToString());
                    MessageBox.Show("还书成功！");
                    init_grid();
                    lend_num.Text = Userhelp.Lend_num().ToString();
                }
                else
                {
                    MessageBox.Show("本书已归还！请勿重复操作！");
                }
            }
            else
            {
                MessageBox.Show("没有选择的书目！");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sernum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bookid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
