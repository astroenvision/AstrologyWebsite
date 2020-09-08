using System;
using System.Data;
using System.Data.OracleClient;
namespace ASTROLOGY.classesoracle
{
    /// <summary>
    /// Summary description for subscription
    /// </summary>
    public class subscription : orclconnection
    {
        #region subscription
        public subscription()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataSet AddToCart(int autoid, string cartid, string subscriberuserid, string categoryid,string categoryname, string questionid, string question,string totalques, string ans, string totalprice,string usertype,string groupid,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_ADDTOCART", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTO_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CART_ID", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = cartid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("CLIENTEMAILID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = subscriberuserid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CATEGORYID", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = categoryid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("CATEGORYNAME", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = categoryname;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("QUESTION_ID", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = questionid;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("QUESTION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = question;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("TOTALQUESTION", OracleType.VarChar, 10);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = totalques;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("ANSWERS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = ans;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("TOTALPRICE", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = totalprice;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("USERTYPE", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = usertype;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("GROUPID", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = groupid;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = flag;
                orclcmd.Parameters.Add(prm13);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("outflag2", OracleType.Cursor);
                orclcmd.Parameters["outflag2"].Direction = ParameterDirection.Output;

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
        public DataSet AddToCartBilling(int autoid, string cartid, string totalprice, string groupid,string paymentstatus, string flag , string PaymentType,string PaymentFor)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_ADDTOCART_BILLING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTO_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = cartid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("TOTALPRICE", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = totalprice;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = groupid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("PAYMENTSTATUS", OracleType.VarChar, 10);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = paymentstatus;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("FLAGTYPE", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("PAYMENTTYPE", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PaymentType;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("PAYMENTFOR", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PaymentFor;
                orclcmd.Parameters.Add(prm8);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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
        public DataSet UpdateToCartBilling(int autoid, string cartid, string emailid,string totalprice, string paymentstatus, string RegUserId, string RegUserEmailId,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_ADDTOCART_BILLING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTO_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = cartid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("EMAILID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = emailid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("TOTALPRICE", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = totalprice;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("PAYMENTSTATUS", OracleType.VarChar, 10);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = paymentstatus;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("REGUSERID", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = RegUserId;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("REGUSEREMAILID", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = RegUserEmailId;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("FLAGTYPE", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = flag;
                orclcmd.Parameters.Add(prm8);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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
        public DataSet GetAddToCart(string cartid, string usertype, string groupid,string catid, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ADDTOCART", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = cartid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = usertype;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = groupid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CAT_ID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = catid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAG", OracleType.VarChar, 30);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                orclcmd.Parameters.Add(prm5);
                
                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

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
        public DataSet AstGetCommon(string Id, string UrseType, string GroupId, string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_COMMON", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UrseType;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GroupId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

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
        public DataSet AstDeleteCommon(string Id,string cartdid, string UrseType, string GroupId, string Flag)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ASP_DELETE_COMMON", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Id;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CARTD_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = cartdid;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = UrseType;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = GroupId;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Flag;
                cmd.Parameters.Add(prm5);

                cmd.Parameters.Add("outflag", OracleType.Cursor);
                cmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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
        public DataSet GetCategoryPrice(string cartid, string usertype, string groupid, string catid, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_PRICE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = cartid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = usertype;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = groupid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CAT_ID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = catid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                orclcmd.Parameters.Add(prm5);

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
        public DataSet update_horaryquestion_ans(int Autoid, int Questionid, string Answer,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_HORARY_QUES_ANS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTO_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("QUESTION_ID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Questionid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ANSWERVAL", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Answer;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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
        public DataSet get_natal_questions_substring(string catid,string questionid, string questionval, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_NATAL_QUESTIONS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CAT_ID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = catid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("QUESTION_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = questionid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("QUESTIONVAL", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = questionval;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

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
        public DataSet get_natalquestion_ans(string s, string ss, string kk, string rashi, string key, string planets, string chart, string astrologer1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                //orclcmd = GetCommand("ast_degree_comb_search", ref con);
                orclcmd = GetCommand("AST_DEGREE_COMB_SEARCH_TYPE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (ss == "")
                {
                    prm2.Value = '2';
                }
                else
                {
                    prm2.Value = ss;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (kk == "")
                {
                    prm3.Value = '3';
                }
                else
                {
                    prm3.Value = kk;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("prashilagna", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = rashi;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("keyword", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm5.Value = '2';
                }
                else
                {
                    prm5.Value = key;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("allplanets", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (planets == "")
                {
                    prm6.Value = '1';
                }
                else
                {
                    prm6.Value = planets;
                }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chart;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = astrologer1;
                orclcmd.Parameters.Add(prm8);

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
        public DataSet get_natalquestion_ans_temp(string s, string ss, string kk, string rashi, string key, string planets, string chart, string astrologer1, string sessionid, string actionflag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open(); 
               orclcmd = GetCommand("AST_DEGREE_COMB_SEARCH_TEMP", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (ss == "")
                {
                    prm2.Value = '2';
                }
                else
                {
                    prm2.Value = ss;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (kk == "")
                {
                    prm3.Value = '3';
                }
                else
                {
                    prm3.Value = kk;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("prashilagna", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = rashi;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("keyword", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm5.Value = '2';
                }
                else
                {
                    prm5.Value = key;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("allplanets", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (planets == "")
                {
                    prm6.Value = '1';
                }
                else
                {
                    prm6.Value = planets;
                }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chart;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = astrologer1;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_sessionid", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = sessionid;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_action", OracleType.VarChar, 200);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = actionflag;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;

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

        }
        public DataSet update_natalquestion_ans(int Autoid, int Questionid, string Answer,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_NATAL_QUES_ANS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTO_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("QUESTION_ID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Questionid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ANSWERVAL", OracleType.Clob);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Answer;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet UpdatePaymentStatus(string cartidval, string emailid, string groupval, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_PAYMENTSTATUS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = cartidval;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USER_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = emailid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = groupval;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet Get_Manglik_Dosha_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_MANGLIK_DOSHA_RESULT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("PLANETNAME", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("LAGNACHART", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lagnachart;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("MOONCHART", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = moonchart;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("VENUSCHART", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = venuschart;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("LAGNAPOINTS", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = lagnapoints;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("MOONPOINTS", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = moonpoints;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("VENUSPOINTS", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = venuspoints;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("DOSHAFLAG", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = doshaflag;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = flag;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("NOOFPLANET", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = noofplanet;
                orclcmd.Parameters.Add(prm10);
                
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

                orclcmd.Parameters.Add("p_out6", OracleType.Cursor);
                orclcmd.Parameters["p_out6"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet Get_Dosha_Samya_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_DOSHA_SAMYA_RESULT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("PLANETNAME", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("LAGNACHART", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lagnachart;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("MOONCHART", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = moonchart;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("VENUSCHART", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = venuschart;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("LAGNAPOINTS", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = lagnapoints;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("MOONPOINTS", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = moonpoints;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("VENUSPOINTS", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = venuspoints;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("DOSHAFLAG", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = doshaflag;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = flag;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("NOOFPLANET", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = noofplanet;
                orclcmd.Parameters.Add(prm10);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet AstGetEndUserLagna(string Id, string UrseType, string GroupId, string Flag, string NoofCat)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_ENDUSER_LAGNA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UrseType;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GroupId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Flag;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("NOOFCAT", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = NoofCat;
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
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        public DataSet InsertClientInfo(int autoid, string name,string email,string conactno,string pwd,string address,string city,string state,string country,string pincode,string active,string user_gender, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_CLIENTINFO", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("AUTOID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = autoid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CLIENTNAME", OracleType.VarChar, 200);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = name;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("CLIENTEMAILID", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = email;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CLIENTCONTACT_NO", OracleType.VarChar, 50);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = conactno;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("CLIENTPASSWORD", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = pwd;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("CLIENTADDRESS", OracleType.VarChar, 200);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = address;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("CLIENTCITY", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = city;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("CLIENTSTATE", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = state;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("CLIENTCOUNTRY", OracleType.VarChar, 100);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = country;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("PINCODEVALUE", OracleType.VarChar, 50);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = pincode;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("ACTIVEVALUE", OracleType.VarChar, 1);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = active;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("CLIENTGENDER", OracleType.VarChar, 10);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = user_gender;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("FLAGVALUE", OracleType.VarChar, 50);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = flag;
                orclcmd.Parameters.Add(prm13);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet CheckLoginEndUser(string mail, string pass, string usertype, string groupid,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_CHECK_LOGIN_ENDUSER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("EMAILIDVAL", OracleType.VarChar, 200);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = mail;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("PASSWORDVAL", OracleType.VarChar, 200);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = pass;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("USERTYPE", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = usertype;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("GROUPID", OracleType.VarChar, 200);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = groupid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAGVALUE", OracleType.VarChar, 200);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("POUT1", OracleType.Cursor);
                orclcmd.Parameters["POUT1"].Direction = ParameterDirection.Output;
                orclcmd.Parameters.Add("POUT2", OracleType.Cursor);
                orclcmd.Parameters["POUT2"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }
            finally
            {
                ds.Dispose();
                con.Close();
            }
        }
        public DataSet UpdateCommon(string ID, string UserId, string UserEmailId,string UserType, string GroupId, string CartID, string Value1, string Value2, string Value3, string Value4, string Value5,string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_COMMON", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar,10);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = ID;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USER_ID", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UserId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("USER_EMAILID", OracleType.VarChar, 50);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = UserEmailId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("USER_TYPE", OracleType.VarChar, 10);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = UserType;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("GROUPID", OracleType.VarChar, 10);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = GroupId;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("CARTD_ID", OracleType.VarChar, 20);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = CartID;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("VALUE1", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Value1;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("VALUE2", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Value2;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("VALUE3", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Value3;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("VALUE4", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Value4;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("VALUE5", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Value5;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Flag;
                orclcmd.Parameters.Add(prm12);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet GetConsultPrice(string id, string cartid, string userid, string useremail, string usertype, string groupid, string servicename, string packname,string currencytype,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_PRICE_CONSULT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CARTID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = cartid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("USERID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = userid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("USEREMAIL", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = useremail;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = usertype;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = groupid;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("SERVICENAME", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = servicename;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("PACKNAME", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = packname;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("CURRENCYTYPE", OracleType.VarChar, 10);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = currencytype;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = flag;
                orclcmd.Parameters.Add(prm10);

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
                ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }
        public DataSet Get_Manglik_Dosha_Predictive( string flag,string BoyTotalPoints, string GirlTotalPoints)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_MANGLIKDOSHA_PREDIC", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 500);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("BOY_TOTAL_POINTS", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = BoyTotalPoints;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GIRL_TOTAL_POINTS", OracleType.VarChar, 10);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GirlTotalPoints;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet Get_Dosha_Samya_Predictive(string flag, string BoyTotalPoints, string GirlTotalPoints)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_DOSHASAMYA_PREDIC", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 500);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("BOY_TOTAL_POINTS", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = BoyTotalPoints;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GIRL_TOTAL_POINTS", OracleType.VarChar, 10);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GirlTotalPoints;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
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
        }
        public DataSet GetLagnaPredictive(string Rashi, string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_LAGNA_PREDICTIVE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("RASHIVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Rashi;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Flag;
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
        public DataSet ChangeUserPassword(string Flag , string Email, string OldPassword , string NewPassword)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_CHANGE_PASSWORD", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                
                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("UserEmailId", OracleType.VarChar, 200);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Email;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("OldPassword", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = OldPassword;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("NewPassword", OracleType.VarChar, 200);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = NewPassword;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region MyCartDetails
        public DataSet GetMyCartDetails(string cartid, string usertype, string groupid, string catid, string EmailID, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_MYCART", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CART_ID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = cartid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = usertype;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = groupid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CAT_ID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = catid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("USER_ID", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = EmailID;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;


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
    
        #region Get Category Price List
        public DataSet ManageCategoryPrice(string Flag, string CatID, string ID, string PriceType)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GETPRICEDETAILS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CATID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_ID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("PRICETYPE", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = PriceType;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("OutFlag", OracleType.Cursor);
                orclcmd.Parameters["OutFlag"].Direction = ParameterDirection.Output;


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

        #region Update Category Price List
        public DataSet UpdateCategoryPrice(string Flag, string ID, string PriceType , string ActualPrice , string CatId , string DiscountPercentage , 
            string DiscountAmount , string FinalAmount, string InrUsdRate , string IncreaseRate , string ActualPriceUsd , string DiscountPriceUsd , string DiscountPercentageUsd ,string FinalAmountUsd , string IncreasePriceInINR, string CreatedBy)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_CATPRICE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_PRICETYPE", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = PriceType;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_PRICE", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ActualPrice;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_CATID", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = CatId;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_DISCOUNTPER", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = DiscountPercentage;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_DISCOUNTPRICE", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = DiscountAmount;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_PAYABLEAMOUNT", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = FinalAmount;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_INRUSDRATE", OracleType.VarChar, 100);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = InrUsdRate;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_INCREASERATE", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = IncreaseRate;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_ACTUALPRICEINUSD", OracleType.VarChar, 100);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = ActualPriceUsd;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("P_DISCOUNTPRICEUSD", OracleType.VarChar, 100);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = DiscountPriceUsd;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("P_DISCOUNTPERUSD", OracleType.VarChar, 100);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = DiscountPercentageUsd;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("P_FINALPRICEUSD", OracleType.VarChar, 100);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = FinalAmountUsd;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("P_INCREASEPRICEININR", OracleType.VarChar, 100);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = IncreasePriceInINR;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("P_CREATED_BY", OracleType.VarChar, 100);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = CreatedBy;
                orclcmd.Parameters.Add(prm16);

                orclcmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                orclcmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;


                


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

        #region Get Package Price List
        public DataSet ManagePackage(string Flag , string CatIdFrom , string CatIdTo , string DiscountUsd , string DisCountInr)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGEPACKAGE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CATIDFROM", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatIdFrom;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CATIDTO", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatIdTo;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_DISCOUNT_USD", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = DiscountUsd;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_DICOUNT_INR", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = DisCountInr;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("OutFlag", OracleType.Cursor);
                orclcmd.Parameters["OutFlag"].Direction = ParameterDirection.Output;

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

        #region Get Date Month Year Hour Minute
        public DataSet GetDateMonthYearHourMinute(string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_DATEMONTHYEAR", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("Flag", OracleType.VarChar, 200);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                orclcmd.Parameters.Add("p_date", OracleType.Cursor);
                orclcmd.Parameters["p_date"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_month", OracleType.Cursor);
                orclcmd.Parameters["p_month"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_year", OracleType.Cursor);
                orclcmd.Parameters["p_year"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_hour", OracleType.Cursor);
                orclcmd.Parameters["p_hour"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_minute", OracleType.Cursor);
                orclcmd.Parameters["p_minute"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_second", OracleType.Cursor);
                orclcmd.Parameters["p_second"].Direction = ParameterDirection.Output;

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

        #region Get Category Price List
        public DataSet SaveFeedBack(string Flag, string UserName, string EmailID, string PhoneNo, string Message, string GroupId)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_FEEDBACK", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERNAME", OracleType.NVarChar, 200);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UserName;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("EMAILID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = EmailID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("PHONENO", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = PhoneNo;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("MESSAGE", OracleType.NVarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Message;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = GroupId;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("OutFlag", OracleType.Cursor);
                orclcmd.Parameters["OutFlag"].Direction = ParameterDirection.Output;


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

        #region Update Razpr Payment Status
        public DataSet UpdateRazorPayStatus(string CartID , string user_id, string groupid, string payment_id, string order_id,  string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_RAZORPAY_PAYMENT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("cart_id", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = CartID;
                orclcmd.Parameters.Add(prm1);

                 OracleParameter prm2 = new OracleParameter("user_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = user_id;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("groupid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = groupid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("payment_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = payment_id;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("order_id", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = order_id;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("Flag", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Flag;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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
        
        #region Manage Payment
        public DataSet ManagePayment(string Flag, string PaymentId, string CartId, string RegUserID, string RegEmailId, string ClientId ,
                                     string ClientEmailId , string GroupId , string CategoryID , string ProductID , string PayableAmount , string Discount , string DiscountAmount ,
                                     string ActualAmount , string AmountType , string PaymentDesc , string PaymentStatus , string PaymentMode , string PaymentFor , string RazorpayPaymentID , string RazorpayOrderID , string PaymentGateway)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PAYMENT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_payment_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = PaymentId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cart_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CartId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = RegUserID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = RegEmailId;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_client_id", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ClientId;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_client_emailid", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ClientEmailId;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_group_id", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = GroupId;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_category_id", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = CategoryID;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_product_id", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = ProductID;
                orclcmd.Parameters.Add(prm10);
  
                OracleParameter prm11 = new OracleParameter("p_payable_amount", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = PayableAmount;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_discount", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Discount;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_discount_amount", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = DiscountAmount;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_actual_amount", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = ActualAmount;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_amount_type", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = AmountType;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_payment_desc", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = PaymentDesc;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_payment_status", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = PaymentStatus;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_payment_mode", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = PaymentMode;
                orclcmd.Parameters.Add(prm18);
                
                OracleParameter prm19 = new OracleParameter("p_payment_for", OracleType.VarChar);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = PaymentFor;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_razorpay_payment_id", OracleType.VarChar);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = RazorpayPaymentID;
                orclcmd.Parameters.Add(prm20);


                OracleParameter prm21 = new OracleParameter("p_razorpay_order_id", OracleType.VarChar);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = RazorpayOrderID;
                orclcmd.Parameters.Add(prm21);


                OracleParameter prm22 = new OracleParameter("p_payment_gateway", OracleType.VarChar);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = PaymentGateway;
                orclcmd.Parameters.Add(prm22);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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

        #region Get Payment
        public DataSet GetPayment(string Flag, string PaymentId, string CartId, string RegUserID , string RegEmailID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_PAYMENT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_payment_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = PaymentId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cart_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CartId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = RegUserID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = RegEmailID;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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

        #region Get Product
        public DataSet GetProduct(string Flag, string Id, string ProductID , string ProductPriceID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_PRODUCT_DETAILS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Id;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_productid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = ProductID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_product_Price_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ProductPriceID;
                orclcmd.Parameters.Add(prm4);

                

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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

        #region Get Product
        public DataSet ProductAddToCart(string Flag, string ProductOrderId, string Cartid, string ProductId, string ProductQuantity, string ProductDimension,
                                      string ProductWeight, string ActualPriceINR, string DiscountINR, string PayableAmountINR, string ActualPriceUsd,
                                      string DiscountUsd, string PayableAmountUsd, string Status, string MailSentToSupport, string MailSentToUser, string RegUserID, string RegEmailID )
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PRODUCT_ADDTOCART", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_product_order_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ProductOrderId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cartid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Cartid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_product_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ProductId;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_product_quantity", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = ProductQuantity;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_product_dimension", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = ProductDimension;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_product_weight", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ProductWeight;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_actual_price_inr", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = ActualPriceINR;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_discount_inr", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = DiscountINR;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_payable_amount_inr", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = PayableAmountINR;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_actual_price_usd", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = ActualPriceUsd;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_discount_usd", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = DiscountUsd;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_payable_amount_usd", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = PayableAmountUsd;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_status", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Status;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_mail_sent_tosupport", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = MailSentToSupport;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_mail_sent_touser", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = MailSentToUser;
                orclcmd.Parameters.Add(prm16);


                OracleParameter prm17 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = RegUserID;
                orclcmd.Parameters.Add(prm17);


                OracleParameter prm18 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = RegEmailID;
                orclcmd.Parameters.Add(prm18);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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

        #region Add Billing Details
        public DataSet AddBillingDetails(string Flag, string ProductBillingId, string Cartid, string PayableAmountINR, string PayableAmountUSD, string PaymentType,
                                         string PaymentDesc, string PaymentStatus, string PaymentMode, string RazorPaymentID, string RazorOrderID,
                                         string RegUserID, string RegEmailID, string PaymentFor, string ShippingID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_PRODUCT_BILLING", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_product_billing_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ProductBillingId;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cartid", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Cartid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_payable_amount_inr", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = PayableAmountINR;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_payable_amount_usd", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = PayableAmountUSD;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_payment_type", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = PaymentType;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_payment_desc", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PaymentDesc;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_payment_status", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = PaymentStatus;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_payment_mode", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = PaymentMode;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_razorpay_payment_id", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = RazorPaymentID;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_razorpay_order_id", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = RazorOrderID;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = RegUserID;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = RegEmailID;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_razorpay_payment_for", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = PaymentFor;
                orclcmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("p_shipping_id", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = ShippingID;
                orclcmd.Parameters.Add(prm15);



                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;
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

        #region Get Kaal Sarpa Dosha
          public DataSet GetKaalSarpaDosha(string ClientId, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_KAAL_SARPA_YOGA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("CLIENTID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = ClientId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

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
        #endregion

        #region Get Dashamsha
          public DataSet GetDashamsha(string UserId, string ChartNo, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_DASHAMSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_USERID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = UserId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CHARTNO", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ChartNo;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("P_OUT1", OracleType.Cursor);
                orclcmd.Parameters["P_OUT1"].Direction = ParameterDirection.Output;

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

        #region Get Vaisheshikamsha
        public DataSet GetVaisheshikamsha(string UserId, string ChartNo, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_VAISHESHIKAMSHA", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_USERID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = UserId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CHARTNO", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ChartNo;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("P_OUT1", OracleType.Cursor);
                orclcmd.Parameters["P_OUT1"].Direction = ParameterDirection.Output;

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

        #region Save Astrolger Comments
        public DataSet SaveAstrolgerComments(string flag , string CommentID, string AstrologerID , string UserID , string Comments , string Rating , string Status , string Priority)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ADD_ASTROLOGER_COMMENTS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_COMMENT_ID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CommentID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_ASTROLOGER_ID", OracleType.Number);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = AstrologerID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_USER_ID", OracleType.Number);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = UserID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_COMMENTS", OracleType.VarChar , 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Comments;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("P_RATING", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Rating;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_STATUS", OracleType.VarChar, 1);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Status;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_PRIORITY", OracleType.Number);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Priority;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("P_MODIFY_BY", OracleType.Number);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = UserID;
                orclcmd.Parameters.Add(prm9);


                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region Save Astrologer Client Details
        public DataSet SaveAstroClient(string flag, string PaymentID, string AstrologerID, string CartID, string RegUserID, string RegEmailID,
                                     string ClientID, string LanguageType, string ConsultationType, string Question1, string Question2 , string NoOfMin, 
                                     string Question3, string Question4, string Question5 , string PayFor)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_ASTRO_CLIENT", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_payment_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = PaymentID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_astrologer_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = AstrologerID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_cart_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = CartID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_reg_user_id", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = RegUserID;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = RegEmailID;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_client_id", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = ClientID;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_language_type", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = LanguageType;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_consultation_type", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = ConsultationType;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_question1", OracleType.NChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Question1;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_question2", OracleType.NChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Question2;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_min", OracleType.NChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = NoOfMin;
                orclcmd.Parameters.Add(prm12);


                OracleParameter prm13= new OracleParameter("p_question3", OracleType.NChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Question3;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14= new OracleParameter("p_question4", OracleType.NChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Question4;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_question5", OracleType.NChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = Question5;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_flag", OracleType.NChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = PayFor;
                orclcmd.Parameters.Add(prm16);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region Save Shipping Address
        public DataSet SaveShippingAddresss(string flag, string ShippingID, string CartID, string UserName, string MobileNo, string AlternateNo, string AddressType, string Address
               , string City , string State , string Country , string Pincode , string Landmark ,string Remarks , string Status , string CreatedBy , string RegUserID , string RegEmailID)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_SHIPPING_ADDRESS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_shipping_id", OracleType.VarChar);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ShippingID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cart_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CartID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_user_name", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = UserName;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_mobile_no", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = MobileNo;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_alt_mobile_no", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = AlternateNo;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_address_type", OracleType.VarChar, 1);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = AddressType;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_address", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Address;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_city", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = City;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_state", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = State;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_country", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Country;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_pin_code", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Pincode;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_landmark", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Landmark;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_remark", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Remarks;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_status", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = Status;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = CreatedBy;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = RegUserID;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = RegEmailID;
                orclcmd.Parameters.Add(prm18);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region Save Client Question
        public DataSet SaveClientQuestion(string flag, string QuestionID, string Question, string Answer, string Name, string Dob, string Tob, 
                                             string Country, string State , string City , string CreatedBy , string RegUserID , string RegUserEmailID ,
                                             string Status , string IsValid , string Flag1 , string Flag2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_CLIENT_QUES", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_question_id", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = QuestionID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_question", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Question;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_answer", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Answer;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_name", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Name;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_dob", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Dob;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_tob", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Tob;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_country", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Country;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_state", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = State;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_city", OracleType.VarChar);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = City;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_created_by", OracleType.VarChar);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = CreatedBy;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = RegUserID;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = RegUserEmailID;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_status", OracleType.VarChar);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = Status;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_isvalid", OracleType.VarChar);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = IsValid;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_flag1", OracleType.VarChar);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = Flag1;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_flag2", OracleType.VarChar);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = Flag2;
                orclcmd.Parameters.Add(prm17);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region Save Client Question Comments
        public DataSet SaveClientQuestionComment(string flag, string CommentID,  string QuestionID, string CommentDtls, string CommentBy, 
                                                    string RegUserID, string RegUserEmailID,
                                             string Status, string NoOfLike)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_QUES_COMMENTS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_comment_id", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CommentID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_question_id", OracleType.VarChar);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = QuestionID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_comment_dtls", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = CommentDtls;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_comment_by", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = CommentBy;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_reg_user_id", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = RegUserID;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_reg_user_emailid", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = RegUserEmailID;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_status", OracleType.VarChar);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Status;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_no_of_like", OracleType.VarChar);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = NoOfLike;
                orclcmd.Parameters.Add(prm9);
                
                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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

        #region Save Client Comments Reply
        public DataSet SaveClientCommentReply(string flag, string ReplyID, string CommentID, string QuestionID, string CommentDtls, string CommentBy,
                                               string Status)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MANAGE_COMMENTS_REPLY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("flag", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = flag;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_reply_id", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = ReplyID;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_comment_id", OracleType.Number);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CommentID;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_question_id", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = QuestionID;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_comment_dtls", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = CommentDtls;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_comment_by", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = CommentBy;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_status", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Status;
                orclcmd.Parameters.Add(prm7);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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