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
using MySql.Data.MySqlClient;
namespace ASTROLOGY.classmysql
{

    /// <summary>
    /// Summary description for login
    /// </summary>
    public class login : connection
    {
        private string _Loginid;
        private string _password;
        private string _IPADRESS;
        public login()
        {
            _Loginid = null;
            _password = null;
            _IPADRESS = null;
        }

        public DataSet getUser(string QBC)
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();



            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("websp_getUser", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;

                objmysqlcommand.Parameters.Add("QBC", SqlDbType.VarChar);
                objmysqlcommand.Parameters["QBC"].Value = QBC;

                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                objmysqlconnection.Close();

            }
        }



        public DataSet getQBC(string pubcode)
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();



            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("websp_QBC", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;

                objmysqlcommand.Parameters.Add("pubcode", SqlDbType.VarChar);
                objmysqlcommand.Parameters["pubcode"].Value = pubcode;

                objmysqlcommand.Parameters.Add("compcode", SqlDbType.VarChar);
                objmysqlcommand.Parameters["compcode"].Value = "";

                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                objmysqlconnection.Close();

            }
        }


        public DataSet getPubCenter()
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();



            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("websp_pubcenter", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;


                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                objmysqlconnection.Close();

            }
        }



        public DataSet chklogin(string username, string password, string qbc)
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();
            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("Websp_LoginEmployee", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;

                objmysqlcommand.Parameters.Add("username", SqlDbType.VarChar);
                objmysqlcommand.Parameters["username"].Value = username;

                objmysqlcommand.Parameters.Add("password1", SqlDbType.VarChar);
                objmysqlcommand.Parameters["password1"].Value = password;

                objmysqlcommand.Parameters.Add("qbc", SqlDbType.VarChar);
                objmysqlcommand.Parameters["qbc"].Value = qbc;

                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                CloseConnection(ref objmysqlconnection);
            }
        }

        /*new change ankur 28 feb*/
        public DataSet getuser_login(string agencycode)
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();



            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("websp_getuserofagency", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;

                objmysqlcommand.Parameters.Add("agencycode", SqlDbType.VarChar);
                objmysqlcommand.Parameters["agencycode"].Value = agencycode;


                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                objmysqlconnection.Close();

            }
        }

        public DataSet getPubCenterlogin(string agency)
        {
            MySqlConnection objmysqlconnection;
            MySqlCommand objmysqlcommand;
            objmysqlconnection = GetConnection();
            MySqlDataAdapter objmysqlDataAdapter = new MySqlDataAdapter();
            DataSet objDataSet = new DataSet();



            try
            {
                objmysqlconnection.Open();
                objmysqlcommand = GetCommand("websp_pubcenterlogin", ref objmysqlconnection);
                objmysqlcommand.CommandType = CommandType.StoredProcedure;

                objmysqlcommand.Parameters.Add("agency", SqlDbType.VarChar);
                objmysqlcommand.Parameters["agency"].Value = agency;


                objmysqlDataAdapter.SelectCommand = objmysqlcommand;
                objmysqlDataAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                objmysqlconnection.Close();

            }
        }

    }
}