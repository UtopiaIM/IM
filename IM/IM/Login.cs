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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void regist_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regist re = new regist();
            re.Show();
            regist_link.LinkVisited = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mai = new main();
            mai.Show();
            this.Hide();
        }

    }
}
