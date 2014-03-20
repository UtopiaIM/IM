using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using IM.BLL;
using CCWin.SkinControl;

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

        private void main_Load(object sender, EventArgs e)
        {
            UserBLL udb = new UserBLL();
            //用户信息表
            DataTable dt = new DataTable();
            //好友表
            DataTable dt1 = new DataTable();
            //分组信息表
            DataTable dt2 = new DataTable();
            //好友详细信息表
            DataTable dt3 = new DataTable();
            dt = udb.Userinfo(udb.user.UserID);
            Name_skinLable.Text = udb.user.UserNickName;
            PersonalMessage.Text = udb.user.UserPersonalMessage;

            dt2 = udb.DB.GetData(string.Format("select * from friendgroup where userID={0}", udb.user.UserID));
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ChatListItem chatlist1 = new ChatListItem();
                chatlist1.Bounds = new System.Drawing.Rectangle(0, 53, 363, 25);
                chatlist1.IsTwinkleHide = false;
                chatlist1.OwnerChatListBox = this.chatListBox1;
                chatlist1.Text = dt2.Rows[i]["GrouName"].ToString();
                chatlist1.TwinkleSubItemNumber = 0;
                chatListBox1.Items.AddRange(new ChatListItem[] { chatlist1 });
                dt1 = udb.GetFriendList(udb.user.UserName, dt2.Rows[i]["GrouID"].ToString());
                for (int l = 0; l < dt1.Rows.Count; l++)
                {
                    dt3 = udb.DB.GetData(string.Format("select * from user where UserID={0}", dt1.Rows[l]["Use_UserID"]));
                    ChatListSubItem chatListSubItem1 = new ChatListSubItem();
                    chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
                    chatListSubItem1.DisplayName = dt1.Rows[l]["Alternatename"].ToString();
                    chatListSubItem1.HeadImage = null;
                    chatListSubItem1.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
                    chatListSubItem1.ID = Convert.ToInt32( dt1.Rows[0]["Use_UserID"]);
                    chatListSubItem1.IpAddress = null;
                    chatListSubItem1.IsTwinkle = false;
                    chatListSubItem1.IsTwinkleHide = false;
                    chatListSubItem1.NicName = dt3.Rows[0]["UserNickName"].ToString();
                    chatListSubItem1.OwnerListItem = chatlist1;
                    chatListSubItem1.PersonalMsg = dt3.Rows[0]["UserPersonalMessage"].ToString();
                    chatListSubItem1.Status = ChatListSubItem.UserStatus.Online;
                    chatListSubItem1.Tag = null;
                    chatListSubItem1.TcpPort = 0;
                    chatListSubItem1.UpdPort = 0;
                    chatlist1.SubItems.AddRange(new ChatListSubItem[] {
            chatListSubItem1});
                }
            }



        }

        private void chatListBox_DoubleClickSubItem(object sender, CCWin.SkinControl.ChatListEventArgs e)
        {
            frmChat frmc = new frmChat();
            frmc.ShowDialog();
        }

        private void 移动联系人至ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            移动联系人至ToolStripMenuItem.DropDownItems.Clear();
            UserBLL udb = new UserBLL();
            DataTable dt = new DataTable();
            dt = udb.DB.GetData(string.Format("select * from friendgroup where userID={0}", udb.user.UserID));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ToolStripMenuItem groupitem = new ToolStripMenuItem();
                groupitem.Name = "Group" + i.ToString();
                groupitem.Size = new System.Drawing.Size(152, 24);
                groupitem.Text = dt.Rows[i]["GrouName"].ToString();
                移动联系人至ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            groupitem});
            }
        }

        private void 修改备注名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBLL udb = new UserBLL();
            DataTable dt = new DataTable();
            string sSql = string.Empty;
            string sReSql = string.Empty;
            sReSql = string.Format("select * from user where UserID={0}");

            //sSql = string.Format("select * from friendrelatrionship where userid={0} and use_userid={1}",udb.user.UserID);

        }

        private void Usermenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void 修改备注名ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }



    }
}
