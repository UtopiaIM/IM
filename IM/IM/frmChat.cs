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
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void toolStripButtonWenJian_Click(object sender, EventArgs e)
        {
            sendfile sendf = new sendfile();
            sendf.Show();
        }

        private void toolStripButtonLiaoTianJiLu_Click(object sender, EventArgs e)
        {
            frmClassroom frmc = new frmClassroom();
            frmc.Show();
        }
    }
}
