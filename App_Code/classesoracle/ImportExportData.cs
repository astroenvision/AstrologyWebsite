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
using System.Data.OracleClient;
using System.IO;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

/// <summary>
/// Summary description for ImportExportData
/// </summary>
/// 
namespace ASTROLOGY.classesoracle
{
    public class ImportExportData : orclconnection
    {
        protected static string strLocalConnectionString;
        protected static string strLiveConnectionString;
        public ImportExportData()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public OracleConnection GetLocalConnection()
        {
            strLocalConnectionString = System.Configuration.ConfigurationSettings.AppSettings["OrclConnectionStringLocal"];
            OracleConnection objOracleLocalConnection = new OracleConnection(strLocalConnectionString);
            return objOracleLocalConnection;
        }
        public void OpenLocalConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Closed)
                objConnection.Open();
        }
        public void CloseLocalConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Open)
                objConnection.Close();
            objConnection.Dispose();
        }


        public OracleConnection GetLiveConnection()
        {
            strLiveConnectionString = System.Configuration.ConfigurationSettings.AppSettings["OrclConnectionStringLive"];
            OracleConnection objOracleLiveConnection = new OracleConnection(strLiveConnectionString);
            return objOracleLiveConnection;
        }
        public void OpenLiveConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Closed)
                objConnection.Open();
        }
        public void CloseLiveConnection(ref OracleConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Open)
                objConnection.Close();
            objConnection.Dispose();
        }

        public DataSet GetTableData(string tablename, string flag)
        {
            string str = "";
            OracleConnection con = GetLocalConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                str = "SELECT * from " + tablename + "";
                OracleDataAdapter odt = new OracleDataAdapter(str, con);
                odt.Fill(ds);
            }
            catch (Exception ex)
            {
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }
}