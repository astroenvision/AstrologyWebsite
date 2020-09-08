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
/// Summary description for researchtool
/// </summary>
/// 
namespace ASTROLOGY.classesoracle
{
    public class researchtool : orclconnection
    {
        public researchtool()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        public DataSet bind_grclient(string astrologer, string clgroup, string clgroupu)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_myclient_bind", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pastrologer", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = astrologer;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = clgroup;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = clgroupu;
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

        public DataSet getdropdown(string drop1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_reseach_tool_new", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_item", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = drop1;
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

        public DataSet getdropdownval(string drop2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_reseach_toolfix", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_item", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = drop2;
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


        public DataSet bookpredictive(string book)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_bookcategery_bind", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = book;
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



        public DataSet ast_rashisearch(string planet, string rashi, string astrolrger,string clgroup,string flag,string client,string sv,string svn)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_tool", ref con);
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

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
                cmd.Parameters.Add(prm4);




                OracleParameter prm5 = new OracleParameter("p_flag", OracleType.Number);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = client;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = sv;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_svn", OracleType.Number);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = svn;
                cmd.Parameters.Add(prm8);

                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


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

        public DataSet ast_rashisearch_rashi(string planet, string rashi, string astrolrger, string clgroup,string house1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_tool_rashi", ref con);
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

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = house1;
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

        public DataSet ast_rashisearch_withoutconj_rashi(string planet, string rashi,string house1,string astrolrger, string clgroup,string flag ,string client,string sv,string svn)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_TOOL_RASHI", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = house1;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = astrolrger;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = clgroup;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_flag", OracleType.Number);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = client;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = sv;
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_svn", OracleType.Number);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = svn;
                cmd.Parameters.Add(prm9);



                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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

        public DataSet ast_research_tool_any(string rashi, string house1, string astrolrger, string clgroup, string client, string sv, string svn, string vn)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_TOOL_NONE", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


               
                OracleParameter prm1 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = rashi;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrolrger;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
                cmd.Parameters.Add(prm4);

               


                OracleParameter prm5 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = client;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = sv;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_svn", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = svn;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_vn", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = vn;
                cmd.Parameters.Add(prm8);


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;
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

        public DataSet ast_rashisearch_conj_rashi(string planet, string rashi, string house1, string astrolrger, string clgroup, string flag, string client, string sv, string svn)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_CONJ_RASHI", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = house1;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = astrolrger;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = clgroup;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_flag", OracleType.Number);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = client;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = sv;
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_svn", OracleType.Number);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = svn;
                cmd.Parameters.Add(prm9);



                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


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
        public DataSet ast_rashisearch_conjunction(string planet1, string astrolrger, string clgroup,string client,string sv,string svn)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_tool_conjunction", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrolrger;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = clgroup;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = client;
                cmd.Parameters.Add(prm4);



                OracleParameter prm5 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = sv;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_svn", OracleType.Number);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = svn;
                cmd.Parameters.Add(prm6);


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


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

        public DataSet ast_research_driskkan(string planet1, string astrolrger, string clgroup, string client, string sv, string svn,string house)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_TOOL_DRESHKAN", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrolrger;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = clgroup;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = client;
                cmd.Parameters.Add(prm4);



                OracleParameter prm5 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = sv;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_svn", OracleType.Number);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = svn;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = house;
                cmd.Parameters.Add(prm7);

                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


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

        public DataSet ast_rashisearch_withoutconjnakshatra(string planet, string nakshatra, string astrolrger, string clgroup,string flag,string client)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_tool_nakshatra", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = nakshatra;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrolrger;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_flag", OracleType.Number);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = client;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "HOROSCOPE_D01 is not null";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_svn", OracleType.Number);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "1";
                cmd.Parameters.Add(prm8); 


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;
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

        public DataSet ast_rashisearch_withconjnakshatra(string planet, string nakshatra, string astrolrger, string clgroup, string flag, string client)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_conj_nakshatra", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = nakshatra;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrolrger;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_flag", OracleType.Number);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_client", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = client;
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_sv", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "HOROSCOPE_D01 is not null";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_svn", OracleType.Number);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "1";
                cmd.Parameters.Add(prm8);


                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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

        public DataSet ast_rashisearch_aspect(string planet, string astrolrger, string clgroup)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_tool_aspect", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

              
                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrolrger;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = clgroup;
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
        public DataSet ast_rashisearch_awastha(string pw, string astrolrger, string clgroup,string client)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_TOOL_DEGREE", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = pw;
                cmd.Parameters.Add(prm1);

              
                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrolrger;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = clgroup;
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
        public DataSet ast_dashamshasearch(string astrolrger, string clgroup)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_dashamsha", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


               


                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrolrger;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = clgroup;
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


        public DataSet ast_searchdasha(string dasha,string astrologer)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_calculate_dashamsha", ref con);
                cmd.CommandType = CommandType.StoredProcedure;





                OracleParameter prm1 = new OracleParameter("p_dashamsha", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = dasha;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrologer;
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

        public DataSet ast_clientinfo(string varga,string astrologer)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_client", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_varga", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = varga;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrologer;
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
        public DataSet ast_clientinfoany(string varga, string astrologer)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_client_any", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_varga", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = varga;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astrologer;
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
        public DataSet ast_clientinfoa(string planet,string seq,string astrologer)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_research_client_aspect", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_seq", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = seq;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_astro", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astrologer;
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

        public DataSet clientinfoall()
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_RESEARCH_CLIENTALL", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


               



                cmd.Parameters.Add("p_accounts", OracleType.Cursor);
                cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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

        public DataSet valuesindropdown(string drop1, string drop2)
        {


            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_fetch_data_inchart", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_drop1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = drop1;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_drop2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = drop2;
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