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

    public class planet_aspect_planet : orclconnection
    {
        public planet_aspect_planet()
        {
            //
            // TODO: Add constructor logic here
            //
        }
       

        public DataSet aspecthouse(string planet, string planet1,string house)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planet_aspects_planet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = house;
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

        public DataSet save_planet_aspect_planet(string f13planet, string f13house, string f13aplanet, string f13book, string f13page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planet_aspect_planet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f13planet;
                orclcmd.Parameters.Add(prm1);

                
                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f13house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f13aplanet;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = detail;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f13book;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = f13page;
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

        public DataSet aspectbyhouse(string planet, string planet1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planet_aspectby_planet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                orclcmd.Parameters.Add(prm2);


              

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

        public DataSet lohaspectedbyplanet(string planet, string loh)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_lord_aspectby_planet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet2", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_loh", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = loh;
                orclcmd.Parameters.Add(prm2);




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
    }
}
