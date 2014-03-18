using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using IM.Model;

namespace IM.BLL
{
    class UserBLL : BaseDB
    {
        private static User m_user = new User();

        public  User user
        {
            get { return m_user; }
            set { m_user = value; }
        }

        #region 公有方法
        /// <summary>
        /// 添加用户，注册用户
        /// </summary>
        /// <param name="sUserName">用户名&昵称</param>
        /// <param name="sPassWord1">密码</param>
        /// <param name="sPassWord2">确认密码</param>
        /// <param name="sEmail">邮箱</param>
        /// <param name="sPhoneNumber">电话号码</param>
        /// <param name="sAge">生日</param>
        /// <param name="sIdentity">身份</param>
        /// <param name="sSex">性别</param>
        /// <param name="sMessage">错误信息</param>
        /// <returns></returns>
        public bool AddUserInfo(string sUserName, string sPassWord1, string sPassWord2, string sEmail, string sPhoneNumber, string sAge, string sIdentity, string sSex, ref string[] sMessage)
        {
            string sReSql = string.Empty;
            bool sSuccess = false;
            DataTable dtResult = new DataTable();
            int pd=0;
            //判断输入是否符合要求
            if (string.IsNullOrEmpty(user.UserName))
            {
                sMessage[0] = "用户名不能为空";
            }
            if (string.IsNullOrEmpty(user.PassWord1))
            {
                sMessage[1] = "密码不能为空";
            }
            if (string.IsNullOrEmpty(user.PassWord2))
            {
                sMessage[2] = "密码不能为空";
            }
            if (string.IsNullOrEmpty(user.Identity))
            {
                sMessage[3] = "身份不能为空";
            }
            if (user.PassWord1 != user.PassWord2 && (sMessage[2] != null || sMessage[1] != null))
            {
                sMessage[4] = "两次密码不一致";
            }
            //判断是否存在该用户名
            if (!string.IsNullOrEmpty(user.UserName))
                sReSql = string.Format("SELECT * FROM im.user Where UserAccount='{0}'", user.UserName);
            dtResult = DB.GetData(sReSql);
            if (dtResult.Rows.Count != 0)
            {
                sMessage[5] = "用户名已存在";
            }
            else
            {
                for (int i=0; i < 6; i++)
                {
                    if (!string.IsNullOrEmpty(sMessage[i]))
                        pd++;
                }
                if (pd==0)
                {
                    DataRow drNew = dtResult.NewRow();
                    drNew["UserAccount"] = m_user.UserName;
                    drNew["UserPassword"] = m_user.PassWord1;
                    drNew["UserEmail"] = m_user.Email;
                    drNew["UserPhone"] = m_user.PhoneNumber;
                    //男=0，女=1
                    if (m_user.Sex == "男")
                    {
                        drNew["UserGender"] = 0;
                    }
                    else
                    {
                        drNew["UserGender"] = 1;
                    }
                    //学生=1，老师=0
                    if (m_user.Identity == "学生")
                    {
                        drNew["UserSorT"] = 1;
                    }
                    else
                    {
                        drNew["UserSorT"] = 0;
                    }
                    drNew["UserBirthDate"] = m_user.BirthDay;
                    drNew["UserNickName"] = m_user.UserName;
                    dtResult.Rows.Add(drNew);
                    sSuccess = DB.Update(ref dtResult, sReSql);
                }
            }
            return sSuccess;
        }

        /// <summary>
        /// 登录信息判断
        /// </summary>
        /// <param name="sUserName"></param>
        /// <param name="sPassWord"></param>
        /// <param name="sMessage"></param>
        /// <returns></returns>
        public bool Login(string sUserName, string sPassWord, ref string[] sMessage)
        {
            bool bSuccess = false;
            string sReSql = string.Empty;
            DataTable dt = new DataTable();
            sReSql = string.Format("select * from im.User where UserAccount='{0}'", sUserName);
            dt = DB.GetData(sReSql);
            if (dt.Rows.Count == 0)
            {
                if (sUserName == "")
                    sMessage[0] = "亲，用户名不能为空!";
                else
                    sMessage[0] = "亲，该用户不存在！";
            }
            else
            {
                if (dt.Rows[0]["UserPassword"].ToString().Trim() != sPassWord.Trim())
                {
                    sMessage[1] = "亲，密码错误！";
                }
                else
                {
                    bSuccess = true;
                }
            }
            if (bSuccess)
            {
                user.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                user.UserNickName = dt.Rows[0]["UserNickName"].ToString();
            }
            return bSuccess;
        }

        //public List<string[]> SearchFriend()
        //{
        //    List<string[]> friendlist = new List<string[]>();
        //    string sReSql = string.Empty;
        //    DataTable dt = new DataTable();
            
        //    return friendlist;
        //}

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        public DataTable Userinfo(int ID)
        {
            string sResql = string.Empty;
            DataTable dt = new DataTable();
            sResql = string.Format("select * from im.user where UserID='{0}'", ID);
            dt = DB.GetData(sResql);
            return dt;
        }
        /// <summary>
        /// 搜索信息（好友）
        /// </summary>
        /// <param name="sInfo">搜索条件（UserID，UserNickName，UserIMNum）</param>
        /// <returns></returns>
        public DataTable SearchUser(string sInfo)
        {
            DataTable dt = new DataTable();
            string sReSql = string.Empty;
            sReSql = string.Format("select * from im.user where UserID='{0}'", sInfo);
            dt = DB.GetData(sReSql);
            if (dt.Rows.Count==0)
            {
                sReSql = string.Format("select * from im.user where UserNickName='{0}'", sInfo);
                dt = DB.GetData(sReSql);
                if(dt.Rows.Count==0)
                {
                    sReSql = string.Format("select * from im.user where UserIMNum={0}", sInfo);
                    dt = DB.GetData(sReSql);
                }
            }
            return dt;
        }

        /// <summary>
        /// 判断是否IMNum重复
        /// </summary>
        /// <param name="sId"></param>
        /// <returns></returns>
        public bool IsUserIMNumRepeat(string sId)
        {
            bool bSuccess = false;
            string sReSql = string.Empty;
            DataTable dt = new DataTable();
            sReSql = string.Format("select * from im.user where im.UserIMNum={0}", sId);
            dt = DB.GetData(sReSql);
            if (dt.Rows.Count > 0)
            {
                return bSuccess;
            }
            else
            {
                bSuccess = true;
            }
            return bSuccess;
        }
        /// <summary>
        /// 获取朋友的ID
        /// </summary>
        /// <param name="sName">朋友的昵称</param>
        /// <returns></returns>
        public  string GetFriendID(string sName)
        {
            string sReSql = string.Empty;
            DataTable dt = new DataTable();
            sReSql = string.Format("select * from im.user where UserNickName='{0}'",sName);
            dt = DB.GetData(sReSql);
            return dt.Rows[0]["UserID"].ToString();
        }


        public bool AddFriend(string MyID, string FriendID)
        {
            bool bSuccess = false;
            string sReSql = string.Empty;
            DataTable dt = new DataTable();
            sReSql = string.Format("select * from im.friendrelationship where UserID='{0}' and Use_UserID='{1}'",MyID,FriendID);
            dt = DB.GetData(sReSql);
            if (dt.Rows.Count == 0)
            {
                DataRow dtr = dt.NewRow();
                dtr["UserID"] = MyID;
                dtr["Use_UserID"] = FriendID;
                dtr["GrouID"] = 1;
                dt.Rows.Add(dtr);
                bSuccess=DB.Update( ref dt, sReSql);
            }
            return bSuccess;
           
        }
        #endregion

    }
}
