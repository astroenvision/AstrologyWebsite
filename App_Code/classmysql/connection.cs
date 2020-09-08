using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MySql.Data ;
using MySql.Data .MySqlClient ;
namespace ASTROLOGY.classmysql
{

    /// <summary>
    /// Summary description for connection
    /// </summary>
    public class connection
    {
        protected static string strConnectionString;
        public connection()
        {
            strConnectionString = ConfigurationSettings.AppSettings["mysqlconnectionstring"];
        }
        public MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection(strConnectionString);
            return con;
            //SqlConnection objSqlConnection = new SqlConnection(strConnectionString);
        }
        public void CloseConnection(ref MySqlConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Open)
                objConnection.Close();
            objConnection.Dispose();
        }
        public MySqlCommand GetCommand(string strSQLStmt, ref MySqlConnection objConnection)
        {
            return (new MySqlCommand(strSQLStmt, objConnection));
        }
        public void CloseDataReader(ref MySqlDataReader objDataReader)
        {
            if (objDataReader != null)
                if (!objDataReader.IsClosed)
                    objDataReader.Close();
        }
        public MySqlDataAdapter GetDataAdapter(string strSQLStmt, ref MySqlConnection objConnection)
        {
            return (new MySqlDataAdapter(strSQLStmt, objConnection));
        }
    }
}