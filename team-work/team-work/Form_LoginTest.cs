using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace team_work
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_LoginTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = admin_id.Text.ToString().Trim();
            string pwd = password.Text.ToString().Trim();
            if (uid.Equals("") && pwd.Equals(""))
            {
                MessageBox.Show("账号密码不能为空！");
            }
            else if (uid.Equals(""))
            {
                MessageBox.Show("账号不能为空！");
            }
            else if (pwd.Equals(""))
            {
                MessageBox.Show("密码不能为空！");
            }
            else
            {
                if (user_type.SelectedItem.ToString().Trim().Equals("用户"))
                {
                    Userhelp.reuid(uid);
                    SqlDataReader sqlDataReader;
                    sqlDataReader = Userhelp.Password(uid, pwd);
                    if (sqlDataReader.Read())
                    {
                        Form_main form = new Form_main(false);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }
                    sqlDataReader.Close();
                }
                else
                {
                    Userhelp.reuid(uid);
                    SqlDataReader sqlDataReader;
                    sqlDataReader = Userhelp.adminPassword(uid, pwd);
                    if (sqlDataReader.Read())
                    {
                        Form_main form = new Form_main(true);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }
                    sqlDataReader.Close();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_id.Text = "";
            password.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(user_type.Text == "用户")
            {
                Register form = new Register();
                form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("仅限用户注册！");
            }
                
        }
    }
}
