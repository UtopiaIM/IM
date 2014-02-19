using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IM
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search_student sstu = new search_student();
            sstu.Show();
        }

        private void 发送即时消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChat frmc = new frmChat();
            frmc.Show();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
