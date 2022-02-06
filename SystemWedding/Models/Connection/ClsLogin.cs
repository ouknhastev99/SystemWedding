using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemWedding.Models
{
    class ClsLogin
    {
        private int ErrorCode;
        private string ErrorMsg;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter ad;

        public int _ErrorCode { get { return ErrorCode; } }
        public string _ErrorMsg { get { return ErrorMsg; } }
        public SqlConnection _con { get { return con; } set { con = value; } }
        public SqlCommand _cmd { get { return cmd; } set { cmd = value; } }
        public SqlDataAdapter _ad { get { return ad; } set { ad = value; } }

        [Obsolete]
        public ClsLogin()
        {
            getConnection();
        }
        [Obsolete]
        string constr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"].ToString();
        [Obsolete]
        private void getConnection()
        {
            try
            {
                _con = new SqlConnection(constr);
                if (_con.State == System.Data.ConnectionState.Closed) _con.Open();

                if (_con.State == System.Data.ConnectionState.Open) ErrorCode = 0;
                else
                {
                    ErrorCode = 9999;
                    ErrorMsg = "login fail";
                }
            }
            catch (Exception ex)
            {
                ErrorCode = ex.HResult;
                ErrorMsg = ex.Message;
            }
        }
    }
}
