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
/// <summary>
/// Summary description for predictive_input1
/// </summary>
namespace ASTROLOGY.classesoracle
{
    public class predictive_input1 : orclconnection
    {
        public predictive_input1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet planetaspectplanet(string planet, string house, string aspplanet, string ahouse)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planet_asp_planet_house", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_planet2", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aspplanet;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_house1", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ahouse;
                orclcmd.Parameters.Add(prm4);

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



        public DataSet f2binddispositor(string dhouse, string house)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_DISPOSITOR_LORD_INHOUSE", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = dhouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
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



        public DataSet f3planetasploh(string planet, string house, string lohouse)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_ASPECTS_LOH", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = lohouse;
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


        public DataSet ast_fixed(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_fixed_bind", ref con);
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


        public DataSet f4lohinfixed(string loh, string rashi)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_LORD_FIXED_RASHI", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_sign", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
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





        public DataSet f5dopinrashi(string dop, string rashi)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_DISPOSITOR_PLANET_INRASHI", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = dop;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
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





        public DataSet ast_own(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_Own_bind", ref con);
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




        public DataSet ast_deb(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_DEBLITATION_BIND", ref con);
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




        public DataSet f6planetinownrashi(string planet, string rashi)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_OWN", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
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


        public DataSet f7planetinbenmal(string benmal)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_BEN_MAL", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = benmal;
                orclcmd.Parameters.Add(prm1);


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




        public DataSet lordhouseasphouse(string loh, string house, string ahouse)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_LOH_ASPECTBY_LOH", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_lord_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ahouse;
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



















        public DataSet inhouse123(string loh, string benmal, string house)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_LORD_BEN_MAL_HOUSE", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_house_code2", OracleType.VarChar, 4000);
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



        public DataSet benmalinhousebet(string loh, string benmal)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_lord_between_ben_mal", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
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

















        public DataSet planetbenmalbet(string planet, string benmal)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planet_between_ben_mal", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
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

        public DataSet planetdeb(string planet)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planetin_deb", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pplanet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


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


        public DataSet lordindeb(string house)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_lordin_deb", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("phouse", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                orclcmd.Parameters.Add(prm1);


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


        
   





