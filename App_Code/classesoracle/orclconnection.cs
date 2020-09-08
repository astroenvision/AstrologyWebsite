using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.OracleClient;
namespace ASTROLOGY.classesoracle
{

    /// <summary>
    /// Summary description for orclconnection
    /// </summary>
    public class orclconnection
    {
        protected static string strConnectionString;
        public orclconnection()
        {
            //strConnectionString = ConfigurationSettings.AppSettings["OracleConnectionString"];
            strConnectionString = ConfigurationSettings.AppSettings["orclconnectionstring"];
        }

        public OracleConnection GetConnection()
        {
            OracleConnection objOracleConnection = new OracleConnection(strConnectionString);
            return objOracleConnection;
        }
        public void OpenConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Closed)
                objConnection.Open();

        }
        public void CloseConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Open)
                objConnection.Close();
            objConnection.Dispose();
        }
        public OracleCommand GetCommand(string strOracleStmt, ref OracleConnection objConnection)
        {
            return (new OracleCommand(strOracleStmt, objConnection));
        }
        public void CloseDataReader(ref OracleDataReader objDataReader)
        {
            if (objDataReader != null)
                if (!objDataReader.IsClosed)
                    objDataReader.Close();
        }
        public OracleDataAdapter GetDataAdapter(string strOracleStmt, ref OracleConnection objConnection)
        {
            return (new OracleDataAdapter(strOracleStmt, objConnection));
        }
    }
}