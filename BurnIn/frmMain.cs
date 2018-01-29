using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurnIn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //control action method
        private void tsmiEXIT_Click(object sender, EventArgs e)//close program
        {
            Close();
        }
        private void tsmiAbout_Click(object sender, EventArgs e)//show logo in about
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void tsmiDebug_Click(object sender, EventArgs e)
        {
            frm_server frm_server = new frm_server();
            frm_server.Show();
        }

        //user define method
    }
}
