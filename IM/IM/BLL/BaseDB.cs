using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace IM.BLL
{
    class BaseDB
    {
        public BaseDB()
        {
            string ConnStr = string.Empty;
            ConnStr = "";
            this.InitDB();
        }
        public IDBAccess.IDBAccess DB = null;

        private MySqlConnection _DBConn = null;

        public MySqlConnection DBConn
        {
            get;
            set;
        }

        public bool IsConnected
        {
            get
            {
                return _DBConn.State == ConnectionState.Open;
            }
        }

        public void InitDB()
        {
            DB = IDBAccess.DBAccessFactory.CreateDBAccess();

            _DBConn = new MySqlConnection();
            _DBConn.ConnectionString = "server=127.0.0.1;User Id=root;Password=123456;database=IM_new";
            _DBConn.Open();
            this.DBConn = _DBConn;
        }
        public void Dispose()
        {
            _DBConn.Dispose();
        }
        public string GetDate()
        {
            string DA;
            DateTime dt = DateTime.Now.Date;
            DA = dt.ToString();
            return DA;
        }
    }
}
