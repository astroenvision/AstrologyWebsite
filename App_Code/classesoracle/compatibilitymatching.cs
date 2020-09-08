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
using System.Data;
using System;

/// <summary>
/// Summary description for compatibilitymatching
/// </summary>
namespace ASTROLOGY.classesoracle
{
    public class compatibilitymatching : orclconnection
    {
        public compatibilitymatching()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet GetMatchingUserDetails(string Id,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_MATCHING_USER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = flag;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

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

        public DataSet GetAshthakootNadiMatch(string BoyId,string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_NADI_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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

        public DataSet GetAshthakootBhakootMatch(string BoyId,string GirlId,string BoyNadi,string GirlNadi,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_BHAKOOT_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("BOYNADIVAL", OracleType.VarChar, 50);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = BoyNadi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("GIRLNADIVAL", OracleType.VarChar, 50);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = GirlNadi;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetAshthakootGanaMatch(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_GANA_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetAshthakootGrahamaitriMatch(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_GRAHAMAITRI", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetAshthakootYoniMatch(string BoyId, string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_YONI_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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

        public DataSet GetAshthakootTaraMatch(string BoyId, string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_TARA_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out4", OracleType.Cursor);
                orclcmd.Parameters["p_out4"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out5", OracleType.Cursor);
                orclcmd.Parameters["p_out5"].Direction = ParameterDirection.Output;

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

        public DataSet GetAshthakootVasyaMatch(string BoyId, string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_VASYA_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out4", OracleType.Cursor);
                orclcmd.Parameters["p_out4"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out5", OracleType.Cursor);
                orclcmd.Parameters["p_out5"].Direction = ParameterDirection.Output;

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

        public DataSet GetAshthakootVarnaMatch(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_ASHTAKOOT_VARNA_MATCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetNakashtraDosha(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_NAKSHTRA_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetEkaNakashtraDosha(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_EKANAKASHTRA_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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

        public DataSet GetNakashtra27thDosha(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_NAKSHTRA_27TH_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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


        public DataSet GetVadhaVainasikaDosha(string BoyId, string GirlId, string BoyNadi, string GirlNadi, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_VADHA_VAINASIKA_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

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

        public DataSet GetKaalSarpaYogaReport(string BoyId, string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_KAAL_SARPA_YOGA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BOYID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GIRLID", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out2", OracleType.Cursor);
                orclcmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out3", OracleType.Cursor);
                orclcmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out4", OracleType.Cursor);
                orclcmd.Parameters["p_out4"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_out5", OracleType.Cursor);
                orclcmd.Parameters["p_out5"].Direction = ParameterDirection.Output;

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

        #region Get Manglik Dosha
        public DataSet GetManglikDosha(string UserId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_CALCULATE_MANGLIK_DOSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_USERID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = UserId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = flag;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("P_OUT1", OracleType.Cursor);
                orclcmd.Parameters["P_OUT1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT2", OracleType.Cursor);
                orclcmd.Parameters["P_OUT2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT3", OracleType.Cursor);
                orclcmd.Parameters["P_OUT3"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT4", OracleType.Cursor);
                orclcmd.Parameters["P_OUT4"].Direction = ParameterDirection.Output;

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
        #endregion

        #region Get Manglik Dosha Matching
        public DataSet GetManglikDoshaMatching(string BoyId, string GirlId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_MANGLIK_DOSHA_MATCHING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_BOYID", OracleType.VarChar, 20);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = BoyId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_GIRLID", OracleType.VarChar, 20);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GirlId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("P_OUT1", OracleType.Cursor);
                orclcmd.Parameters["P_OUT1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT2", OracleType.Cursor);
                orclcmd.Parameters["P_OUT2"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT3", OracleType.Cursor);
                orclcmd.Parameters["P_OUT3"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("P_OUT4", OracleType.Cursor);
                orclcmd.Parameters["P_OUT4"].Direction = ParameterDirection.Output;

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
        #endregion

    }
}