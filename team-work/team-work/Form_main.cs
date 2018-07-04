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
        public Form_main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
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
            form.Dock = DockStyle.Fill;
        }

        private void 图书信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_bookresearch();
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Changepassword();
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
