using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IM.BLL;
using MySql.Data;

namespace IM
{
    public partial class frmChat1 : Form
    {
        public int ChatUserID;
        public string s = "C://Users//Administrator//Documents//IM_Documents";
        public frmChat1()
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

        private void frmChat_Load(object sender, EventArgs e)
        {
            UserBLL udb = new UserBLL();
            //聊天对象信息表
            DataTable dt = new DataTable();
            //用户好友列表
            DataTable dt1 = new DataTable();
            //用户信息表
            DataTable dt2 = new DataTable();
            dt = udb.Userinfo(ChatUserID);
            dt1 = udb.GetFriendShipInfo(udb.user.UserID.ToString(), ChatUserID.ToString());
            dt2 = udb.Userinfo(udb.user.UserID);
            Text = "与" + dt1.Rows[0]["AlternateName"] + "聊天中";
            FriendName.Text = dt1.Rows[0]["AlternateName"].ToString();
            UserName.Text = dt2.Rows[0]["UserNickName"].ToString();
            if (string.IsNullOrEmpty(dt.Rows[0]["HeadPicture"].ToString()))
            {
                FriendHead.ImageLocation = s + "\\search_teacher.jpg";
            }
            else
            {
                FriendHead.ImageLocation = dt.Rows[0]["HeadPicture"].ToString();
            }
            if (string.IsNullOrEmpty(dt2.Rows[0]["HeadPicture"].ToString()))
            {
                UserHead.ImageLocation = s + "\\search_teacher.jpg";
            }
            else
            {
                UserHead.ImageLocation = dt2.Rows[0]["HeadPicture"].ToString();
            }
        }

        private void toolStripButtonZiTi_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                this.MessageTextBox.Font=fontDialog1.Font;
                this.MessageTextBox.ForeColor = fontDialog1.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
