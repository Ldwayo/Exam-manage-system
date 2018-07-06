using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_work
{
    public partial class Form_main : Form
    {
        bool admin;
        public Form_main(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.IsMdiContainer = true;
            if (!admin)
            {
                信息管理ToolStripMenuItem.Visible = false;
                图书管理ToolStripMenuItem.Visible = false;
                管理员密码修改ToolStripMenuItem.Visible = false;
            }
            else
            {
                密码修改ToolStripMenuItem.Visible = false;
                图书借阅ToolStripMenuItem.Visible = false;
                我的信息ToolStripMenuItem.Visible = false;
            }
        }

        private void 信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void 添加图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Addbook();
            form.MdiParent = this;
            form.Show();
        }

        private void 图书信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_bookresearch();
            form.MdiParent = this;
            form.Show();
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Changepassword(false);
            form.MdiParent = this;
            form.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 用户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_User_InfoManage();
            form.MdiParent = this;
            form.Show();
        }

        private void 管理员信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Admin_infoManage();
            form.MdiParent = this;
            form.Show();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 我的信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_My_Information();
            form.MdiParent = this;
            form.Show();
        }

        private void 管理员密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Changepassword(true);
            form.MdiParent = this;
            form.Show();
        }

        /*private void 图书借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Lend_Book();
            form.MdiParent = this;
            form.Show();
        }*/

        private void 图书借阅ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Lend_Book();
            form.MdiParent = this;
            form.Show();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Back_Book();
            form.MdiParent = this;
            form.Show();
        }

        private void 管理员密码修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new Changepassword(true);
            form.MdiParent = this;
            form.Show();
        }

        private void 借书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new Lend_Book();
            form.MdiParent = this;
            form.Show();
        }

        private void 还书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new Back_Book();
            form.MdiParent = this;
            form.Show();
        }
    }
}
