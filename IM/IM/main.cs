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
using System.IO;


namespace IM
{
    public partial class main : Form
    {
        public string s = "C://Users//Administrator//Documents//IM_Documents";
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
            frmChat1 frmc = new frmChat1();
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
            chatListBox1.Items.Clear();
            dt2 = udb.DB.GetData(string.Format("select * from friendgroup where userID={0}", udb.user.UserID));
            if (string.IsNullOrEmpty(dt.Rows[0]["HeadPicture"].ToString()))
            {
                headpicture.ImageLocation = s + "\\search_teacher.jpg";
            }
            else
            {
                headpicture.ImageLocation = dt.Rows[0]["HeadPicture"].ToString();
            }
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
                    chatListSubItem1.ID = Convert.ToInt32(dt1.Rows[l]["Use_UserID"]);
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
            frmChat1 frmc = new frmChat1();
            frmc.ChatUserID = chatListBox1.SelectSubItem.ID;
            frmc.Show();
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
                groupitem.Tag = dt.Rows[i]["GrouID"];
                移动联系人至ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            groupitem});
            }
        }

        private void 修改备注名ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangeAlternateName CAN = new ChangeAlternateName();
            CAN.UserID = chatListBox1.SelectSubItem.ID.ToString();
            CAN.AName = chatListBox1.SelectSubItem.DisplayName;
            CAN.ShowDialog();

        }

        private void 移动联系人至ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            bool bSuccess = false;
            UserBLL udb = new UserBLL();
            string sItemID = string.Empty;
            sItemID = chatListBox1.SelectSubItem.ID.ToString();
            bSuccess = udb.ChangeGroup(e.ClickedItem.Tag.ToString(), sItemID);
            if (bSuccess)
            {
                MessageBox.Show("移动分组成功！");
                main_Load(sender, e);
            }
            else
            {
                MessageBox.Show("移动分组失败！");
            }
        }

        private void 删除此好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool bSuccess = false;
            UserBLL udb = new UserBLL();
            string sItemID = string.Empty;
            sItemID = chatListBox1.SelectSubItem.ID.ToString();
            bSuccess = udb.DeleteFriend(sItemID);
            if (bSuccess)
            {
                MessageBox.Show("删除好友成功！");
                main_Load(sender, e);
            }
            else
            {
                MessageBox.Show("删除好友失败！");
            }
        }

        private void 添加分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup addg = new AddGroup();
            addg.ShowDialog();
            main_Load(sender, e);
        }

        private void 删除分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup dg = new DeleteGroup();
            dg.ShowDialog();
            main_Load(sender, e);

        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReNameGroup rng = new ReNameGroup();
            rng.ShowDialog();
            main_Load(sender, e);
        }

        private void headpicture_Click(object sender, EventArgs e)
        {
            UserBLL udb = new UserBLL();
            bool bSuccess = false;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "图片文件(*.jpg，*.gif,*.bmp)|*.jpg|*.gif|*.bmp";
            openfile.InitialDirectory = "C:\\";
            if (openfile.ShowDialog() == DialogResult.OK)
            {

                FileInfo pic = new FileInfo(openfile.FileName);
                string dz = s + "//" + pic.Name;
                pic.CopyTo(dz,true);
                bSuccess = udb.ChangeHeadPicture(dz, udb.user.UserID.ToString());
            }
            if (bSuccess)
            {
                MessageBox.Show("更换头像成功！");
                main_Load(sender, e);
            }
            else
            {
                MessageBox.Show("更换头像失败！");
            }
        }
    }
}
