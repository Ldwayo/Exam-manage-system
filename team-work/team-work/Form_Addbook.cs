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
    public partial class Form_Addbook : Form
    {
        public Form_Addbook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_TextChanged(object sender, EventArgs e)
        {

        }

        private void introduction_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void class_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            book_id.Text = "";
            name.Text = "";
            author.Text = "";
            publish.Text = "";
            price.Text = "";
            class_id.Text = "";
            introduction.Text  = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //添加书籍信息
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder binfo = new StringBuilder();
            binfo.Append(book_id.Text.ToString() + ",");
            binfo.Append("'"+name.Text.ToString()+"'" +",");
            binfo.Append("'"+author.Text.ToString()+ "'" + ",");
            binfo.Append("'"+publish.Text.ToString()+ "'" + ",");
            binfo.Append("'"+introduction.Text.ToString()+"'" + ",");
            binfo.Append("'"+price.Text.ToString()+"'" + ",");
            binfo.Append("'"+pubdate.Value.ToShortDateString()+ "'" + ",");
            binfo.Append(class_id.Text.ToString()+ ",");
            if (radioButton1.Checked)
            {
                binfo.Append("0，");
            }
            else
            {
                binfo.Append("1,");
            }
            binfo.Append(book_count.Text.ToString());
            try
            {
                if (Bookhelp.AddBookinfo(binfo.ToString()))
                {
                    MessageBox.Show("添加书籍信息成功");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("必须保证图书编号，名称，作者，\n出版社，价格，可借数量不为空");
            }
            
        }
    }
}
