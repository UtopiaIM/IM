using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IM.BLL;
using System.IO;

namespace IM
{
    public partial class Login : Form
    {
        private bool bSuccess = false;
        public string[] str = { "", "", "", "" };
        string s = "C://Users//Administrator//Documents//IM_Documents";
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
            DirectoryInfo Doc = new DirectoryInfo(s);
            if (!Doc.Exists)
            {
                Directory.CreateDirectory(s);
            }
            FileInfo file = new FileInfo(s + "//info.txt");
            if (!file.Exists)
            {
                FileStream f = new FileStream(s + "//info.txt", FileMode.Create);
            }

            StreamReader re = new StreamReader(s + "//info.txt");



            for (int i = 0; i < 4; i++)
            {
                string sr = re.ReadLine();
                if (sr != null)
                {
                    str[i] = sr;
                }
            }
            re.Close();
            if (str[3] == "")
                str[3] = "0";

            if (str[2] == "1" && str[3] == "0")
            {
                Username_textbox.Text = str[0];
                Password_textbox.Text = str[1];
                remain_password.Checked = true;
                autologin.Checked = false;
            }
            if (str[2] == "0" && str[3] == "0")
            {
                Username_textbox.Text = "";
                Password_textbox.Text = "";
                remain_password.Checked = false;
                autologin.Checked = false;
            }
            if (str[3] == "1")
            {
                Username_textbox.Text = str[0];
                Password_textbox.Text = str[1];
                remain_password.Checked = true;
                autologin.Checked = true;
                login_();        
            }
        }

        private void f_load(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_();
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

        private void login_title_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录函数
        /// </summary>
        private void login_()
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

        private void remain_password_CheckedChanged(object sender, EventArgs e)
        {
            string[] sArray = { "", "", "", "" };
            if (remain_password.Checked == true)
            {
                StreamWriter wr = new StreamWriter(s + "//info.txt");
                wr.WriteLine(Username_textbox.Text);
                wr.WriteLine(Password_textbox.Text);
                wr.WriteLine("1");
                wr.Close();
            }
            else
            {
                StreamReader re = new StreamReader(s + "//info.txt");
                sArray[0] = re.ReadLine();
                sArray[1] = re.ReadLine();
                sArray[2] = re.ReadLine();
                sArray[2] = sArray[2].Replace("1", "0");
                re.Close();
                File.WriteAllLines(s + "//info.txt", sArray);

            }
        }

        private void autologin_CheckedChanged(object sender, EventArgs e)
        {
            string[] sArray = { "", "", "", "" };
            StreamReader re = new StreamReader(s + "//info.txt");
            for (int i = 0; i < 4; i++)
            {
                sArray[i] = re.ReadLine();
            }
            re.Close();
            if (autologin.Checked == true)
            {
                sArray[3] = "1";
            }
            else
            {
                sArray[3] = "0";
            }
            File.WriteAllLines(s + "//info.txt", sArray);
        }
    }
}
