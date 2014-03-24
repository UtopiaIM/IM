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
    public partial class DeleteGroup : Form
    {
        public DeleteGroup()
        {
            InitializeComponent();
        }

        private void DeleteGroup_Load(object sender, EventArgs e)
        {
            UserBLL udb=new UserBLL ();
            DataTable dt = new DataTable();
            dt = udb.DB.GetData(string.Format("select * from FriendGroup where UserID={0}", udb.user.UserID));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Group_skinComboBox.Items.AddRange(new object[] { dt.Rows[i]["GrouName"] });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bSuccess = false;
            UserBLL udb = new UserBLL();
            string sGroupName = string.Empty;
            sGroupName = Group_skinComboBox.Text;
            bSuccess = udb.DeletedGroup(sGroupName,udb.user.UserID.ToString());
            if (bSuccess)
            {
                MessageBox.Show("删除好友成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("删除好友失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
