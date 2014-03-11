using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IM.Model;

namespace IM.BLL
{
    class UserBLL:BaseDB
    {
        private User m_user = new User();
        public User user
        {
            get { return m_user; }
            set { m_user = value; }
        }
        
    }
}
