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
/// Summary description for chartindex
/// </summary>
/// 
namespace ASTROLOGY.classesoracle
{

    public class chartindex : orclconnection

    {
        public chartindex()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        public DataSet ast_rashi(string vishu)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand(" AST_chart_index_rashi_bind", ref con);
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

        public DataSet f28lohwithbenmal(string loh, string benmal, string sign)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lord_ben_watery", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_sign", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = sign;
                cmd.Parameters.Add(prm3);


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

        public DataSet ast_rashisearch(string planet, string rashi, string astrolrger, string client)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_chart_index_search", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrolrger;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = client;
                cmd.Parameters.Add(prm4);
                


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



        public DataSet ast_viewclientinfo(string astid, string clinid)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_chk_duplicacy_chart", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("pastid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = astid;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pclientid", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = clinid;
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


        public DataSet showyogas(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_ptanet_itchaal", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);

              


                OracleParameter prm3 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = degree;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = degreesecond;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_menuitem", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = menuitemsvalus;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_retro", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = retro;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = rashie;
                cmd.Parameters.Add(prm8);

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

       

        public DataSet showyogas1(string lagnarashi, string degree, string house, string menuitemsvalus, string retro)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_ptanet_esaraph", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);

               

                OracleParameter prm3 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = degree;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("p_menuitem", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = menuitemsvalus;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_retro", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = retro;
                cmd.Parameters.Add(prm6);



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


        public DataSet kamboola_proce(string lagnarashi,string degree,string house,string degreesecond,string moonrashi,string moonhouse,string sunhouse)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_kamboola_yoga", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);




                OracleParameter prm3 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = degree;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = degreesecond;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_moonrashi", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = moonrashi;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_moon_house", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = moonhouse;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_sun_house", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = sunhouse;
                cmd.Parameters.Add(prm8);


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







        public DataSet karya_sidhi_yoga(string asendrashi, string houselord, string housewithtill, string lagnarashi)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_karyasidhi_yoga", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_asendrashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = asendrashi;
                cmd.Parameters.Add(prm1);

                 OracleParameter prm2 = new OracleParameter("p_houselord", OracleType.VarChar, 4000);
                 prm2.Direction = ParameterDirection.Input;
                 prm2.Value = houselord;
                 cmd.Parameters.Add(prm2);

                 OracleParameter prm3 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                 prm3.Direction = ParameterDirection.Input;
                 prm3.Value = lagnarashi;
                 cmd.Parameters.Add(prm3);

                 OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                 prm4.Direction = ParameterDirection.Input;
                 prm4.Value = housewithtill;
                 cmd.Parameters.Add(prm4);

                
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


        public DataSet showyogas_nakta_proce(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_nakta_yoga", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = degree;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = house;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = newdegree;
                cmd.Parameters.Add(prm4);
               
                OracleParameter prm5 = new OracleParameter("p_houselord", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = lordhouse;
                cmd.Parameters.Add(prm5);


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




        public DataSet showyogas_yamya_proce(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_yamya_yoga", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = degree;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = house;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = newdegree;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_houselord", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = lordhouse;
                cmd.Parameters.Add(prm5);


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


        public DataSet showyogas_manau_process(string lagnarashi, string degree, string house, string degreesecond)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_manau_yoga", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);




                OracleParameter prm3 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = degree;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = degreesecond;
                cmd.Parameters.Add(prm5);


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
        public DataSet ast_clientinfo(string varga)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_chart_client", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_varga", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = varga;
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

        public DataSet showyogas_menu(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("horary_ptanet_itchaal_cat", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                cmd.Parameters.Add(prm1);




                OracleParameter prm3 = new OracleParameter("p_degree", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = degree;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_newdegree", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = degreesecond;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_menuitem", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = menuitemsvalus;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_retro", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = retro;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = rashie;
                cmd.Parameters.Add(prm8);


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