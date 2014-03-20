using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IM.BLL;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace IM
{
    public partial class search_student : Form
    {
        public search_student()
        {
            InitializeComponent();
        }

        private void search_student_Load(object sender, EventArgs e)
        {
            picture_head1.Image = null;
            item_name1.Text = null;
            introduction1.Text = null;
            picture_head2.Image = null;
            item_name2.Text = null;
            introduction2.Text = null;
            add_button1.Visible = false;
            add_button2.Visible = false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            picture_head1.Image = null;
            item_name1.Text = null;
            introduction1.Text = null;
            picture_head2.Image = null;
            item_name2.Text = null;
            introduction2.Text = null;
            UserBLL udb=new UserBLL ();
            string sName = string.Empty;
            sName = search_textBox.Text;
            DataTable dt = new DataTable();
            dt = udb.SearchUser(search_textBox.Text,"1");
            if (dt.Rows.Count ==1)
            {
                    picture_head1.Image = IM.Properties.Resources.search_teacher;
                    item_name1.Text = dt.Rows[0]["UserNickName"].ToString();
                    introduction1.Text = dt.Rows[0]["UserPersonalMessage"].ToString();
                    add_button1.Visible = true;
                    picture_head2.Image = null;
                    item_name2.Text = null;
                    introduction2.Text = null;
                    add_button2.Visible = false;
            }
            if (dt.Rows.Count == 2)
            {
                picture_head1.Image = IM.Properties.Resources.search_teacher;
                item_name1.Text = dt.Rows[0]["UserNickName"].ToString();
                introduction1.Text = dt.Rows[0]["UserPersonalMessage"].ToString();
                add_button1.Visible = true;
                picture_head2.Image = IM.Properties.Resources.search_teacher;
                item_name2.Text = dt.Rows[1]["UserNickName"].ToString();
                introduction2.Text = dt.Rows[1]["UserPersonalMessage"].ToString();
                add_button2.Visible = false;
            }
            if (dt.Rows.Count == 0)
            {
                add_button1.Visible = false;
                add_button2.Visible = false;
                MessageBox.Show("未找到该用户！");
            }
        }

        private void add_button1_Click(object sender, EventArgs e)
        {
            add_friend(item_name1.Text);
        }
        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="sNickName">好友昵称</param>
        private void add_friend(string sNickName)
        {
            UserBLL udb=new UserBLL ();
            string sReSql = string.Empty;
            string SorT = string.Empty;
            DataTable dt = new DataTable();
            string FriendId=string.Empty;
            FriendId = udb.GetFriendID(sNickName);
            SorT = udb.GetSorT(sNickName);
            bool bSuccess = udb.AddFriend(udb.user.UserID.ToString(), FriendId,SorT);
            if (bSuccess)
            {
                MessageBox.Show("添加好友成功！");
            }
            else
            {
                MessageBox.Show("该好友已存在!");
            }
        }

        private void add_button2_Click(object sender, EventArgs e)
        {
            add_friend(item_name2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture_head1.Image = null;
            item_name1.Text = null;
            introduction1.Text = null;
            picture_head2.Image = null;
            item_name2.Text = null;
            introduction2.Text = null;
            UserBLL udb = new UserBLL();
            string sName = string.Empty;
            sName = search_textBox1.Text;
            DataTable dt = new DataTable();
            dt = udb.SearchUser(search_textBox1.Text, "0");
            if (dt.Rows.Count == 1)
            {
                picture_head1.Image = IM.Properties.Resources.search_teacher;
                item_name1.Text = dt.Rows[0]["UserNickName"].ToString();
                introduction1.Text = dt.Rows[0]["UserPersonalMessage"].ToString();
                add_button1.Visible = true;
                picture_head2.Image = null;
                item_name2.Text = null;
                introduction2.Text = null;
                add_button2.Visible = false;
            }
            if (dt.Rows.Count == 2)
            {
                picture_head1.Image = IM.Properties.Resources.search_teacher;
                item_name1.Text = dt.Rows[0]["UserNickName"].ToString();
                introduction1.Text = dt.Rows[0]["UserPersonalMessage"].ToString();
                add_button1.Visible = true;
                picture_head2.Image = IM.Properties.Resources.search_teacher;
                item_name2.Text = dt.Rows[1]["UserNickName"].ToString();
                introduction2.Text = dt.Rows[1]["UserPersonalMessage"].ToString();
                add_button2.Visible = false;
            }
            if (dt.Rows.Count == 0)
            {
                add_button1.Visible = false;
                add_button2.Visible = false;
                MessageBox.Show("未找到该用户！");
            }
        }
    }
}
