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
    public partial class Lend_Book : Form
    {
        string click_book;
        public Lend_Book()
        {
            InitializeComponent();
            init_grid();
        }

        private void init_grid()
        {
            string strsql = "select * from book_info";
            DataTable dataTable = DBhelp.GetDataTable(strsql);
            lendbookview.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                lendbookview.DataSource = data;
            }
            else
            {
                MessageBox.Show("查无此书");
            }
        }

        private void lendbookview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            click_book = lendbookview.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Userhelp.Lend_num() > 0)
            {
                if (Bookhelp.Have_book(click_book))
                {
                    if (Bookhelp.LendBook(click_book) && Userhelp.User_lend())
                    {
                        MessageBox.Show("借书成功！");
                        Userhelp.Record_Lend(click_book);
                    }
                    else
                    {
                        MessageBox.Show("借书失败！");
                    }
                }
                else
                {
                    MessageBox.Show("此书余量不足！");
                }
            }
            else
            {
                MessageBox.Show("可借次数不足！");
            }
        }
    }
}
