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
    public partial class ReNameGroup : Form
    {
        public ReNameGroup()
        {
            InitializeComponent();
        }

        private void ReNameGroup_Load(object sender, EventArgs e)
        {
            UserBLL udb = new UserBLL();
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
            bSuccess = udb.ReNameGroup(sGroupName, udb.user.UserID.ToString(),NewName_TextBox.Text);
            if (bSuccess)
            {
                MessageBox.Show("重命名成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("重命名失败！");
            }
        }
    }
}
