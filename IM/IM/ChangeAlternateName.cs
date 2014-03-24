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
    public partial class ChangeAlternateName : Form
    {
        public string UserID = string.Empty;
        public string AName = string.Empty;
        public ChangeAlternateName()
        {
            InitializeComponent();
        }

        private void ChangeAlternateName_Load(object sender, EventArgs e)
        {
            AlternateName_TextBox.Text = AName;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            bool bSuccess = false;
            UserBLL udb = new UserBLL();
            bSuccess=udb.ChangeAlternateName(UserID, AlternateName_TextBox.Text);
            if (bSuccess == false)
            {
                MessageBox.Show("修改备注名失败！");
            }
            else
            {
                MessageBox.Show("修改备注名成功！");
                this.Hide();
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
