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

        private void ClearTextBox()
        {
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            introduction.Text = "";
            price.Text = "";
            class_id.Text = "";
        }

        //删除所选图书
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Bookhelp.DeleteBook(textBox5.Text.ToString());
                MessageBox.Show("删除成功,请重新查询以更新显示表单");
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        //查询
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

        private void add_book_Click(object sender, EventArgs e)
        {

        }

        private void bookgridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox5.Text = bookgridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox4.Text = bookgridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = bookgridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = bookgridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            introduction.Text =  bookgridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            price.Text = bookgridview.Rows[e.RowIndex].Cells[5].Value.ToString();
            pubdate.Text =  bookgridview.Rows[e.RowIndex].Cells[6].Value.ToString();
            class_id.Text = bookgridview.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (bookgridview.Rows[e.RowIndex].Cells[8].Value.ToString() == "0")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            book_count.Text = bookgridview.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        //修改图书信息
        private void change_book_Click(object sender, EventArgs e)
        {
            string state = "";
            if (radioButton1.Checked)
            {
                state = "0";
            }
            else
            {
                state = "1";
            }
            try
            {
                Bookhelp.UpdateBook(textBox5.Text.ToString(),textBox4.Text.ToString(), textBox3.Text.ToString(), 
                textBox2.Text.ToString(),introduction.Text.ToString(),
                price.Text.ToString(),pubdate.Value.ToString(),class_id.Text.ToString(),state,book_count.Text.ToString());
                MessageBox.Show("更新成功,请重新查询以更新显示表单");
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bookgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
