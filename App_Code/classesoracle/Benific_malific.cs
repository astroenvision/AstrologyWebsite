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

    public class Benific_malific : orclconnection
    {
        public Benific_malific()
        {
            //
            // TODO: Add constructor logic here
            //
        }







        public DataSet ast_benificmalific(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_BENIFICS_MALIFICS_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;



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

        public DataSet aspectbenimali(string planet, string house, string benmal)
        {
           OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_ASPECTS_BENIFICS_MALIFICS", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_benmal", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = benmal;
                orclcmd.Parameters.Add(prm3);


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

        public DataSet save_benific_malific(string f14planet, string f14house, string f14aplanet, string f14book, string f14page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_benific_malific", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f14planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f14house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f14aplanet;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = detail;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f14book;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;

                if (f14page == "")
                { prm6.Value = System.DBNull.Value; }
                else
                { prm6.Value = f14page; }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                if (keystring == "")
                {
                    prm7.Value = System.DBNull.Value;
                }
                else
                {
                    prm7.Value = keystring;
                }
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_desc", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = desc;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_comb", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = combination;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_lagna", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = lagna;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = chart;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = unique;
                orclcmd.Parameters.Add(prm12);


                OracleParameter prm13 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = fid;
                orclcmd.Parameters.Add(prm13);


                OracleParameter prm14 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = today;
                orclcmd.Parameters.Add(prm14);

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



        public DataSet ast_malific(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MALIFICS_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;



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

        public DataSet lohinhouseloh(string loh, string house, string aloh)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_lordfromlord", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_loh2", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aloh;
                orclcmd.Parameters.Add(prm3);


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

        public DataSet lordrashiclass(string loh, string rashi)
        {
           OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lord_rashi_class", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);

                
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
