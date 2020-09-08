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

    public class multiplesigni : orclconnection
    {
        public multiplesigni()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet bind_house(string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("bind_house_list", ref con);
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

        public DataSet bind_planet(string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("bind_planet_list", ref con);
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

        public DataSet bind_rashi(string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("bind_rashi_list", ref con);
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

        public DataSet save_multiplesigni(string casesignificators, string signifies)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_multi_significators", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("signific", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (casesignificators == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {
                    prm1.Value = casesignificators;
                }
                 orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("signifies", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (signifies == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = signifies;
                }


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

        public DataSet execute_multisigni(string txtmultisigni)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_multisigni", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_txtmultisigni", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (txtmultisigni == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {
                    prm1.Value = txtmultisigni;
                }
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

        public DataSet update_multisignificator(string multisignificators, string multisignificators1, string signifiesby)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_update_multisignificators", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pmultisignificators", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = multisignificators;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pmultisignificators1", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = multisignificators1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("psignifiesby", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = signifiesby;
                cmd.Parameters.Add(prm3);


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

        public DataSet delete_multisignificator(string multisignificators, string signifiesby)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_multisignificators", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pmultisignificators", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = multisignificators;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("psignifiesby", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = signifiesby;
                cmd.Parameters.Add(prm2);

               

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

        public DataSet chk_multisignificator(string multisignificators, string signifiesby)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_chk_multisignificators", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pmultisignificators", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = multisignificators;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("psignifiesby", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = signifiesby;
                cmd.Parameters.Add(prm2);



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
