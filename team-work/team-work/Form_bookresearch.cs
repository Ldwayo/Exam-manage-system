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
    public partial class Form_bookresearch : Form
    {
        public Form_bookresearch()
        {
            InitializeComponent();
            init_gridview();
        }

        private void init_gridview()
        {
            string strsql = "select * from book_info";
            DataTable dataTable = DBhelp.GetDataTable(strsql);
            bookgridview.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_bookresearch_Load(object sender, EventArgs e)
        {

        }
    }
}
