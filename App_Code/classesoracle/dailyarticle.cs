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
using System.IO;

/// <summary>
/// Summary description for dailyarticle
/// </summary>
/// 

namespace ASTROLOGY.classesoracle
{
    public class dailyarticle : orclconnection
    {
        public dailyarticle()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet savedatafopagetable(string head, string keyword, string snopsis, string story, string picformat, string date)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                
                con.Open();

                cmd = GetCommand("AST_dailyarticle_bind", ref con);

                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_head", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = head;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_keyword", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = keyword;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_snopsis", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = snopsis;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_story", OracleType.Clob);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = story;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_pic", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = picformat;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = System.DateTime.Now.ToString();
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


        public DataSet upddata1(string head, string keyword, string snopsis, string story, string picformat, string date, string datadate)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                
                con.Open();

                cmd = GetCommand("AST_dailyarticle_bind_upd", ref con);

                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_head", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = head;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_keyword", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = keyword;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_snopsis", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = snopsis;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_story", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = story;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_pic", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = picformat;
                cmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_date", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = System.DateTime.Now;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_datetime", OracleType.VarChar, 50);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = datadate;
                cmd.Parameters.Add(prm7);

               

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

        public DataSet datadel(string head, string keyword, string snopsis, string story, string picformat, string datadate)
        {

             OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                
                con.Open();

                cmd = GetCommand("AST_dailyarticle_bind_del", ref con);

                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_head", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = head;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_keyword", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = keyword;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_snopsis", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = snopsis;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_story", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = story;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_pic", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = picformat;
                cmd.Parameters.Add(prm5);




                OracleParameter prm6 = new OracleParameter("p_datetime", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = datadate;
                cmd.Parameters.Add(prm6);

               

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

        public DataSet datafopagetable()
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {

                con.Open();

                cmd = GetCommand("AST_dailyarticle1_bind", ref con);

                cmd.CommandType = CommandType.StoredProcedure;

              
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



        public DataSet Save_Article(string groupid, string category, string headline, string synopsis, string detail, string author, string authorimg, string status, string priority, string crtdby , string metadescription , string metakeywords , string title , string articleurl , string StoryImage)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_SAVE_ARTICLE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("groupid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = groupid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("catid", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = category;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("headline", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value =headline;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("synopsis", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = synopsis;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("fulldetail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("author", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = author;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("authorimg", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = authorimg;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("status", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = status;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("priority", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = priority;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("crtdby", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = crtdby;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("metadescription", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = metadescription;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("metakeywords", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = metakeywords;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("title", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = title;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("articleurl", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = articleurl;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("StoryImage", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = StoryImage;
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

        public DataSet Update_Article(string groupid, string category, string headline, string synopsis, string detail, string author, string authorimg, string status, string priority, string crtdby,string newsid , string metadescription, string metakeywords, string title, string StoryImage)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_UPDATE_ARTICLE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("groupid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = groupid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("cat_id", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = category;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("head_line", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = headline;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("synopsis_val", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = synopsis;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("fulldetail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("authorname", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = author;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("authorimg", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = authorimg;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("status", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = status;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("priority_val", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = priority;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("modby", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = crtdby;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("newsid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = newsid;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("metadescription", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = metadescription;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("metakeywords", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = metakeywords;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_title", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = title;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("StoryImage", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = StoryImage;
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

        public DataSet Get_Categories(string Flag, string GroupID,string CatID)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_ASTRO_CATEGORY", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("Flag", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("GroupID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GroupID;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("CatID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatID;
                cmd.Parameters.Add(prm3);

                cmd.Parameters.Add("p_out1", OracleType.Cursor);
                cmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_out2", OracleType.Cursor);
                cmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

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


        public DataSet Get_Article_Data(string CatID, string GroupID,string NewsID , string Flag , string Status , string Headline)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_GET_ARTICLE", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_CatID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = CatID;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GroupID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = GroupID;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("NewsID", OracleType.Number);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = NewsID;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("Flag", OracleType.VarChar , 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Flag;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_Status", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Status;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_headline", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Headline;
                cmd.Parameters.Add(prm6);

                cmd.Parameters.Add("p_out1", OracleType.Cursor);
                cmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("p_out2", OracleType.Cursor);
                cmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

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

        public DataSet Delete_Article_Data(string NewsID)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_DELETE_ARTICLE", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("NewsID", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = NewsID;
                cmd.Parameters.Add(prm1);

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

        public string uploadsw(string fileName, string folderName, HtmlInputFile file_posted)
        {
            if (fileName == "")
            {
                return "File name is invalid.";
            }

            fileName = System.IO.Path.GetFileName(fileName);
            if (folderName == "")
            {
                return "Path not found.";
            }
            string strBaseLocation = HttpContext.Current.Server.MapPath(folderName);

            //file_soft.PostedFile.SaveAs(Server.MapPath(folderName) + "\\" + fileName);

            if (null != file_posted.PostedFile)
            {
                //string fileName = GetFileName( file_soft.Value );
                string fileTarget = strBaseLocation + "\\" + fileName;
                try
                {
                    //read/write buffer
                    const int BUFFER_SIZE = 255;
                    Byte[] Buffer = new Byte[BUFFER_SIZE];
                    //lblerror.Text = "Uploading File: " + fileName;

                    //incoming external file stream
                    //Stream theStream = thumbimgfile.PostedFile.InputStream;
                    Stream theStream = file_posted.PostedFile.InputStream;


                    //local file stream
                    FileStream fs = new FileStream(fileTarget, FileMode.CreateNew, FileAccess.Write);
                    fs.Flush();
                    //local binary writer on local file stream
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Flush();

                    // read/write loop
                    while (theStream.Read(Buffer, 0, BUFFER_SIZE) != 0)
                    {
                        bw.Write(Buffer, 0, BUFFER_SIZE);
                    }

                    //Close the streams
                    bw.Close();
                    fs.Close();
                    theStream.Close();

                    fs.Dispose();
                    theStream.Dispose();
                    //lblerror.Text = "Upload finished.";

                    //reload directory listing
                    //FindAndDisplayFiles();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return fileName;
        }

        #region Approve Request
        public DataSet ManageArticlesRequest(string Flag,string NewsID , string Status)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_MANAGE_ARTICLE_REQUEST", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("P_FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_ID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = NewsID;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("P_STATUS", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Status;
                cmd.Parameters.Add(prm3);

                cmd.Parameters.Add("P_OUT1", OracleType.Cursor);
                cmd.Parameters["P_OUT1"].Direction = ParameterDirection.Output;

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

        #endregion

        public DataSet Get_ArticleData_ByID(string Flag ,string NewsID)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_GET_ARTICLE_ID", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("Flag", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("NewsID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = NewsID;
                cmd.Parameters.Add(prm2);

                cmd.Parameters.Add("p_out1", OracleType.Cursor);
                cmd.Parameters["p_out1"].Direction = ParameterDirection.Output;
                
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
        public DataSet ManageCategory(string Flag ,string CatID , string  CatName , string MetaKeyWords , string MetaDesc , string CatDesc ,
            string CatSynopsis, string Priority , string Title , string ImageUrl , string Status , string CategoryColor , string IsBlink , 
            string IsPaid , string CatURl, string PostUrl , string PreUrl ,string CreatedBY , string IsAddToCart)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_MANAGE_CATEGORY", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar , 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_CATEGORYID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatID;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("P_CATNAME", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatName;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_METAKEYWORDS", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = MetaKeyWords;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_METADESC", OracleType.VarChar);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = MetaDesc;
                cmd.Parameters.Add(prm5);
                
                OracleParameter prm6 = new OracleParameter("P_CATDESC", OracleType.VarChar);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = CatDesc;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("P_CATSYNOP", OracleType.VarChar);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = CatSynopsis;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("P_PRIORITY", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Priority;
                cmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("P_TITLE", OracleType.VarChar, 100);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Title;
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("P_IMAGEURL", OracleType.VarChar, 100);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = ImageUrl;
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("P_STATUS", OracleType.VarChar, 100);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Status;
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_category_color", OracleType.VarChar, 100);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = CategoryColor;
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_IsBlink", OracleType.VarChar, 100);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = IsBlink;
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_ispaid", OracleType.VarChar, 100);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = IsPaid;
                cmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_CatURl", OracleType.VarChar, 100);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = CatURl;
                cmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_pre_category_url", OracleType.VarChar, 100);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = PreUrl;
                cmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("p_post_category_url", OracleType.VarChar, 100);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = PostUrl;
                cmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_createdby", OracleType.VarChar, 100);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = CreatedBY;
                cmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("P_ISADDTOCART", OracleType.VarChar, 100);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = IsAddToCart;
                cmd.Parameters.Add(prm19);

                cmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                cmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

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

        public DataSet UpdateQuestions(string Flag, string OldQuestion, string Question, string CAT)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_UPDATE_QUESTIONS", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("P_OldQuestion", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = OldQuestion;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("P_Question", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Question;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_CAT", OracleType.VarChar);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = CAT;
                cmd.Parameters.Add(prm4);

                cmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                cmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

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


        public DataSet GetCategoryDetails(string Flag, string CatID, string MappedFor)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_GET_CATEGORY_MAP_DETAILS", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("AUTOID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = CatID;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_mappedfor", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = MappedFor;
                cmd.Parameters.Add(prm3);

                cmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                cmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

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

        public DataSet SaveCategoryMapping(string Flag, string AutoID , string CatID , string RealtedCatID , string Status , string Priority , string GroupName , string MappingFor)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_SAVE_MAPPING_DETAILS", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Flag;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("AUTOID", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = AutoID;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("CAT_ID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = CatID;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CAT_MAP_ID", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = RealtedCatID;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("STATUS", OracleType.VarChar, 100);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Status;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("VAL_PRIORITY", OracleType.VarChar, 100);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Priority;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("GROUPNAME", OracleType.VarChar, 100);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = GroupName;
                cmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("P_MAPPING_FOR", OracleType.VarChar, 100);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = MappingFor;
                cmd.Parameters.Add(prm8);

                cmd.Parameters.Add("OUTFLAG", OracleType.Cursor);
                cmd.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

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
