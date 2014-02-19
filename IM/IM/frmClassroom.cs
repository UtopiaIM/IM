using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aptech.UI;

namespace IM
{
    public partial class frmClassroom : Form
    {
        public frmClassroom()
        {
            InitializeComponent();
        }

        private void sideBar1_Load_1(object sender, EventArgs e)
        {
            sideBar1.AddGroup("听课人员列表");
            sideBar1.AddGroup("发言申请人列表");
            sideBar1.AddGroup("资源共享列表");
        }
    }
}
