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
    public partial class Form_My_Information : Form
    {
        public Form_My_Information()
        {
            InitializeComponent();
            admin_id.Text = Userhelp.ruid;
            SqlDataReader sqlDataReader = Userhelp.ExistsID(Userhelp.ruid);
            while (sqlDataReader.Read())
            {
                name.Text = sqlDataReader.GetString(1);
                birth.Value = (DateTime)sqlDataReader["birth"];
                if (((string)sqlDataReader["sex"]).Equals("男"))
                {
                    sex_man.Checked = true;
                }
                else
                {
                    sex_woman.Checked = true;
                }
                reader_id.Text = Userhelp.ruid;
                address.Text = (string)sqlDataReader["address"];
                tel.Text = (string)sqlDataReader["tel"];
                password.Text = (string)sqlDataReader["password"];
            }
            sqlDataReader.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void My_Information_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_id.ReadOnly = false;
            name.ReadOnly = false;
            birth.Enabled = true;
            tel.ReadOnly = false;
            reader_id.ReadOnly = false;
            sex_man.Enabled = true;
            sex_woman.Enabled = true;
            address.ReadOnly = false;
            password.ReadOnly = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_id.ReadOnly = true;
            name.ReadOnly = true;
            birth.Enabled = false;
            tel.ReadOnly = true;
            reader_id.ReadOnly = true;
            sex_man.Enabled = false;
            sex_woman.Enabled = false;
            address.ReadOnly = true;
            password.ReadOnly = true;
            button1.Enabled = false;
            button2.Enabled = true;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(" name='");
            stringBuilder.Append(name.Text);
            stringBuilder.Append("' , sex='");
            if (sex_man.Checked)
            {
                stringBuilder.Append("男");
            }
            else
            {
                stringBuilder.Append("女");
            }
            stringBuilder.Append("' , birth='");
            stringBuilder.Append(birth.Value.ToShortDateString());
            stringBuilder.Append("' , address='");
            stringBuilder.Append(address.Text);
            stringBuilder.Append("' , tel='");
            stringBuilder.Append(tel.Text);
            stringBuilder.Append("' , password='");
            stringBuilder.Append(password.Text+"'");
            if (Userhelp.Changeinfo(admin_id.Text,stringBuilder.ToString()))
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
