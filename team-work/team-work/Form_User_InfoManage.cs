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
    public partial class Form_User_InfoManage : Form
    {
        public Form_User_InfoManage()
        {
            InitializeComponent();
            init_grid();
        }

        private void init_grid()
        {
            string strsql = "select * from reader_info";
            DataTable dataTable = DBhelp.GetDataTable(strsql);
            dataGridView1.DataSource = dataTable;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_User_Information_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
