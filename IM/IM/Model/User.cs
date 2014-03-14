using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IM.Model
{
    class User
    {
        private string m_UserName = "";
        public string UserName
        {
            get{return m_UserName;}
            set { m_UserName = value; }
        }

        private string m_PassWord1 = "";
        public string PassWord1
        {
            get{return m_PassWord1;}
            set { m_PassWord1 = value; }
        }
        public string PassWord2
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string BirthDay
        {
            get;
            set;
        }
        public string Identity
        {
            get;
            set;
        }
        public string Sex
        {
            get;
            set;
        }


    }
}
