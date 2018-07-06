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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader_id.Text = "";
            name.Text = "";
            address.Text = "";
            tel.Text = "";
            password.Text = "";
            makesure_password.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = reader_id.Text.ToString().Trim();
            string uname = name.Text.ToString().Trim();
            string sex;
            if (sex_man.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            string birth_date = birth.Value.ToShortDateString();
            string addr = address.Text.ToString().Trim();
            string telphone = tel.Text.ToString().Trim();
            string pwd = password.Text.ToString().Trim();
            string rpwd = makesure_password.Text.ToString().Trim();
            
            if(uid.Equals("")||uname.Equals("")|| birth_date.Equals("")|| 
                addr.Equals("")|| telphone.Equals("") || pwd.Equals("") || rpwd.Equals(""))
            {
                MessageBox.Show("请完善你的信息！");
            }
            else
            {
                if (!pwd.Equals(rpwd))
                {
                    MessageBox.Show("两次输入的密码不同！");
                }
                else
                {
                    string sql = "INSERT INTO reader_info(reader_id,name,sex,birth,address,tel,password)" +
                    "VALUES(" + "'" + uid + "','" + uname + "','" + sex + "','" + birth_date + "','"
                    + addr + "','" + telphone + "','" + pwd + "')";
                    if (Userhelp.register(sql)){
                        MessageBox.Show("注册成功！");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
 
        }
    }
}
