using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IM.BLL;

namespace IM
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            bool bSuccess = false;
            UserBLL udb = new UserBLL();
            bSuccess = udb.AddGroup(udb.user.UserID.ToString(),GroupName_TextBox.Text);
            if (bSuccess)
            {
                MessageBox.Show("添加分组成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("删除分组失败！");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
