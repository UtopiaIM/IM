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
    public partial class Login : Form
    {
        private bool bSuccess = false;
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            UserBLL User = new UserBLL();
            User.user.UserName = Username_textbox.Text;
            User.user.PassWord1 = Password_textbox.Text;
            string[] sMessage = { "", "" };
            bSuccess = User.Login(User.user.UserName, User.user.PassWord1, ref sMessage);
            if (bSuccess)
            {
                main mai = new main();
                mai.Show();
                this.Hide();
            }
            else
            {
                if (!string.IsNullOrEmpty(sMessage[0]))
                    MessageBox.Show(sMessage[0]);
                else
                    MessageBox.Show(sMessage[1]);
            }
        }
        main ma;

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ma != null)
            {
                ma.Show();
            }
            else
            {
                this.Show();
            }
        }

    }
}
