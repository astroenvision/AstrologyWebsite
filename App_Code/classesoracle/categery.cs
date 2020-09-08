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
namespace ASTROLOGY.classesoracle
{
    /// <summary>
    /// Summary description for categery
    /// </summary>
    public class categery:orclconnection
    {
        public categery()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataSet bind_categery(string extra1)
   {
       OracleConnection con;
       OracleCommand cmd;
       con = GetConnection();
       DataSet ds = new DataSet();
       OracleDataAdapter da = new OracleDataAdapter();
       try
       {
           con.Open();
           cmd = GetCommand("bind_predictive_categery", ref con);
           cmd.CommandType = CommandType.StoredProcedure;

           
           OracleParameter prm1 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
           prm1.Direction = ParameterDirection.Input;
           prm1.Value = extra1;
           cmd.Parameters.Add(prm1);

           
           cmd.Parameters.Add("p_accounts", OracleType.Cursor);
           cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;


           da.SelectCommand = cmd;
           da.Fill(ds);
           return ds;

       }
       catch (Exception ex)
       {
           throw (ex);
       }
       finally
       {
           CloseConnection(ref con);
       }
   }


        public DataSet bind_desc(string ss  , string kk)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_search", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = ss;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = kk;
                orclcmd.Parameters.Add(prm3);


                //OracleParameter prm4 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                //prm4.Direction = ParameterDirection.Input;
                //prm4.Value = "";
                //orclcmd.Parameters.Add(prm4);


                //OracleParameter prm5 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                //prm5.Direction = ParameterDirection.Input;
                //prm5.Value = "";
                //orclcmd.Parameters.Add(prm5);


                //OracleParameter prm6 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                //prm6.Direction = ParameterDirection.Input;
                //prm6.Value = "";
                //orclcmd.Parameters.Add(prm6);

                //OracleParameter prm7 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                //prm7.Direction = ParameterDirection.Input;
                //prm7.Value = "";
                //orclcmd.Parameters.Add(prm7);

                //OracleParameter prm8 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                //prm8.Direction = ParameterDirection.Input;
                //prm8.Value = "";
                //orclcmd.Parameters.Add(prm8);

                //OracleParameter prm9 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                //prm9.Direction = ParameterDirection.Input;
                //prm9.Value = "";
                //orclcmd.Parameters.Add(prm9);

              

             
                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;



            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet bind_categerygs(string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("bind_predictive_categerygs", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra1;
                cmd.Parameters.Add(prm1);


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;


                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(ref con);
            }
        }

        public DataSet findandreplace(string filter, string subfilter)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_filter_subfilter", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pfilter", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = filter;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("psubfilter", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = subfilter;
                orclcmd.Parameters.Add(prm2);


                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;



            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet bind_subcategery(string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_predictive_subcategery", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra1;
                cmd.Parameters.Add(prm1);


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;


                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(ref con);
            }
        }
    }
}