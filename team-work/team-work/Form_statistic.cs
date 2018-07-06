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
    public partial class Form_statistic : Form
    {
        public Form_statistic()
        {
            InitializeComponent();
            InitBookTop();
            InitUserTop();
            InitStatistic();


        }

        private void InitBookTop()
        {
            bookTop.DataSource = Bookhelp.BookTop();
        }

        private void InitUserTop()
        {
            userTop.DataSource = Userhelp.UserTop();
        }

        private void InitStatistic()
        {
            Statistic.DataSource = Bookhelp.Statistic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void bookTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
