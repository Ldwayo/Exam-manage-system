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

        //delete reader
        private void button3_Click(object sender, EventArgs e)
        {
            if (Userhelp.deleteReader(reader_id.Text.ToString()))
            {
                MessageBox.Show("已注销该用户");
                init_grid();
            }
            else
            {
                MessageBox.Show("不存在此用户");
            }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //query
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt =  Userhelp.ReaderInfoManage(reader_id.Text.ToString());
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reader_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
