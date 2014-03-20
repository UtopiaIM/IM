using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IM.Model;
using IM.BLL;

namespace IM
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserId = string.Empty;
            error_username .Text= "";
            error_password .Text= "";
            error_password2.Text = "";
            error_identity.Text = "";
            UserBLL udb = new UserBLL();
            bool bSuccess = false;
            string[] sMessage = { "", "", "", "", "", "" };
            udb.user.UserName = username_textBox.Text;
            udb.user.PassWord1 = passwd_textbox.Text;
            udb.user.PassWord2 = passwd_textbox2.Text;
            udb.user.PhoneNumber = phonenum_textbox.Text;
            udb.user.Identity = Identity_comboBox.Text;
            udb.user.Email = email_textbox.Text;
            udb.user.BirthDay = birthday_textbox.Text;
            udb.user.Sex = sex_comboBox.Text;
            bSuccess = udb.AddUserInfo(udb.user.UserName, udb.user.PassWord1, udb.user.PassWord2, udb.user.Email, udb.user.PhoneNumber, udb.user.BirthDay, udb.user.Identity, udb.user.Sex, ref sMessage);
            if (bSuccess)
            {
                MessageBox.Show("注册成功！");
                Close();
  
            }
            else
            {
                //显示错误信息
                if (string.IsNullOrEmpty(sMessage[2]))
                    error_password2.Text = sMessage[4];
                else
                    error_password2.Text = sMessage[2];

                error_password.Text = sMessage[1];

                error_identity.Text = sMessage[3];

                if (string.IsNullOrEmpty(sMessage[0]))
                    error_username.Text = sMessage[5];
                else
                    error_username.Text = sMessage[0];
            }
        }

        private void regist_Load(object sender, EventArgs e)
        {

        }

        private void error_password_Click(object sender, EventArgs e)
        {

        }

        private void error_username_Click(object sender, EventArgs e)
        {

        }

    }
}
