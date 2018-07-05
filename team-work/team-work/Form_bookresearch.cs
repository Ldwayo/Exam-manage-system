using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string id = "";
            string bookAuthor = "";
            string bookName = "";
            string press = "";

            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "书名":
                        bookName = textBox1.Text.ToString();
                        break;
                    case "图书编号":
                        id = textBox1.Text.ToString();
                        break;
                    case "作者":
                        bookAuthor = textBox1.Text.ToString();
                        break;
                    case "出版社":
                        press = textBox1.Text.ToString();
                        break;
                    default:
                        MessageBox.Show("请勿修改选项");
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("请勿修改选项");
            }
            
            DataTable data = Bookhelp.QueryBook(id, bookAuthor, bookName, press);
            if (data.Rows.Count > 0)
            {
                bookgridview.DataSource = data;
            }
            else
            {
                MessageBox.Show("查无此书");
            }
            
        }

        //增加书籍
        private void add_book_Click(object sender, EventArgs e)
        {

        }
    }
}
