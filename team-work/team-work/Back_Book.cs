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
        public string sernum;
        public int count;
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
            if (Userhelp.Back_book(sernum))
            {
                Userhelp.update_ustate();
                MessageBox.Show("还书成功！");
            }
            else
            {
                MessageBox.Show("本书已归还！请勿重复操作！");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sernum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
