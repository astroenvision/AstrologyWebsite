using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO.Ports;

using System.Net.Mail;



public partial class dailyairticle : System.Web.UI.Page
{
    string strProfExp = "";
    string TBL = "";
    string head="";
   string keyword="";
    string snopsis="";
         string story="";
         string date = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Ajax.Utility.RegisterTypeForAjax(typeof(dailyairticle));
        //DataSet ds1 = new DataSet();

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.dailyarticle country = new ASTROLOGY.classesoracle.dailyarticle();
            ds = country.datafopagetable();


        }
        TBL = "";
        TBL += "<table width='100%' cellspacing='0px' cellpadding = '0px' border='2'>";

        {
            TBL += "<tr>";
            TBL += "<td style='font-size:13px;' align='left' width='8%'><b> HEADLINES </b></td>";
            TBL += "<td style='font-size:13px;' align='left' width='7%'><b> KEYWORD </b></td>";
            TBL += "<td style='font-size:13px;' align='left' width='7%'><b>SYNOPSIS </b></td>";
            TBL += "<td style='font-size:13px;' align='left' width='7%'><b> FILLSTORY </b></td>";
            TBL += "<td  style='font-size:13px;' align='left' width='10%'><b>IMAGE</b></td>";
            TBL += "<td  style='font-size:13px;' align='left' width='10%'><b>TIME </b></td>";
            TBL += "<td  style='font-size:13px;' align='left' width='2%'><b>UPDATE </b></td>";
            TBL += "<td  style='font-size:13px;' align='left' width='1%'><b>DELETE </b></td>";
            // TBL += "<td  style='font-size:13px;' align='left' width='1%'><b>PUBLISH</b></td>";

            TBL += "</tr>";
        }
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            TBL += "<tr >";
            TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='headlines_" + i + "' >" + ds.Tables[0].Rows[i]["HEADLINES"].ToString() + "</div></td>";


            TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='keyword_" + i + "' >" + ds.Tables[0].Rows[i]["KEYWORD"].ToString() + "</div></td>";


            TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='synopsis_" + i + "' >" + ds.Tables[0].Rows[i]["SYNOPSIS"].ToString() + "</div></td>";


            TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:250px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='fillstory_" + i + "' >" + ds.Tables[0].Rows[i]["FILLSTORY"].ToString() + "</div></td>";


            TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='false' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='image_" + i + "' >" + ds.Tables[0].Rows[i]["IMAGE"].ToString() + "</div></td>";


            TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='false' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='time_" + i + "' >" + ds.Tables[0].Rows[i]["TIME"].ToString() + "</div></td>";
            TBL += "<td><Button runat='server' style='width:50px;'   align='left' Text='update' id=update_" + i + " onClick=\"data1('headlines_" + i + "' , 'keyword_" + i + "' , 'synopsis_" + i + "' , 'fillstory_" + i + "' , 'image_" + i + "' , 'time_" + i + "' )\">update</Button></td>";
            TBL += "<td><Button runat='server' style='width:50px; ' align='left' Text='delete' 'id=delete_" + i + " onClick=\"datadel('headlines_" + i + "' , 'keyword_" + i + "' , 'synopsis_" + i + "' , 'fillstory_" + i + "' , 'image_" + i + "' , 'time_" + i + "' )\">delete</Button></td>";
            //TBL += "<td><Button runat='server' style='width:50px; ' align='left' Text='publish' 'id=publish_" + i + " onClick='javascript:return datapublish(this.id);'>publish</Button></td>";
            TBL += "</tr'>";
            Htime.Value = ds.Tables[0].Rows[i]["TIME"].ToString();

        }
        TBL += "</table>";
        divgrid.InnerHtml = TBL.ToString(); ;
          

        if (!Page.IsPostBack)
        {
            
        }

    }






    protected void submitdata_Click(object sender, EventArgs e)
    {   
         head = headtext.Text;
         keyword = keywords.Text;
         snopsis = synopsis.Text;
         story = rte.Value;
         date = System.DateTime.Now.ToString();
        Convert.ToDateTime(date).ToString("MM/dd/yyyy hh:MM:tt:ss");

        string file_rename = "";
        string file_xnt = "";
        string picformat = "";

        

            hdnpath.Value = Server.MapPath("articles");
          
            string filename = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename == "")
            {
            }
            else
            {
                file_xnt = filename.Split('.')[1];
                //  file_rename = att_name + "_proof_";
                if (lblphoto.Text != "")
                {
                    int count = lblphoto.Text.Count(f => f == ',') + 1;
                    file_rename = file_rename + count.ToString();
                    lblphoto.Text = lblphoto.Text + "," + file_rename + "." + file_xnt;
                    lblphoto.ToolTip = lblphoto.Text + "," + file_rename + "." + file_xnt;
                }
                else
                {
                    //file_rename = file_rename + "0";
                    file_rename = file_rename + System.DateTime.Now.Day.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Second.ToString();
                    lblphoto.Text = file_rename + "." + file_xnt;
                    lblphoto.ToolTip = file_rename + "." + file_xnt;
                    picformat = file_rename + "." + file_xnt;
                }


                //FileUpload1.PostedFile.SaveAs(System.IO.Path.Combine(hdnpath.Value, file_rename + "." + file_xnt));
                FileUpload1.PostedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("articles"), file_rename + "." + file_xnt));
                
            }
        
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.dailyarticle country = new ASTROLOGY.classesoracle.dailyarticle();
                ds = country.savedatafopagetable(head, keyword, snopsis, story, picformat, date);
                ScriptManager.RegisterClientScriptBlock(this, typeof(dailyairticle), "sa", "alert(\"save successfully\");", true);
                 headtext.Text =string.Empty;
                 keywords.Text = string.Empty;
                 synopsis.Text = string.Empty;
                 rte.Value = string.Empty;
                 lblphoto.Text = string.Empty;
                  head = "";
                  keyword = "";
                  snopsis = "";
                  story = "";
                  date = "";
                  file_rename = "";

                  TBL = "";
                  TBL += "<table width='100%' cellspacing='0px' cellpadding = '0px' border='2'>";

                  {
                      TBL += "<tr>";
                      TBL += "<td style='font-size:13px;' align='left' width='8%'><b> HEADLINES </b></td>";
                      TBL += "<td style='font-size:13px;' align='left' width='7%'><b> KEYWORD </b></td>";
                      TBL += "<td style='font-size:13px;' align='left' width='7%'><b>SYNOPSIS </b></td>";
                      TBL += "<td style='font-size:13px;' align='left' width='7%'><b> FILLSTORY </b></td>";
                      TBL += "<td  style='font-size:13px;' align='left' width='10%'><b>IMAGE</b></td>";
                      TBL += "<td  style='font-size:13px;' align='left' width='10%'><b>TIME </b></td>";
                      TBL += "<td  style='font-size:13px;' align='left' width='2%'><b>UPDATE </b></td>";
                      TBL += "<td  style='font-size:13px;' align='left' width='1%'><b>DELETE </b></td>";
                      // TBL += "<td  style='font-size:13px;' align='left' width='1%'><b>PUBLISH</b></td>";

                      TBL += "</tr>";
                  }
                  for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                  {

                      TBL += "<tr >";
                      TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='headlines_" + i + "' >" + ds.Tables[0].Rows[i]["HEADLINES"].ToString() + "</div></td>";


                      TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='keyword_" + i + "' >" + ds.Tables[0].Rows[i]["KEYWORD"].ToString() + "</div></td>";


                      TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='synopsis_" + i + "' >" + ds.Tables[0].Rows[i]["SYNOPSIS"].ToString() + "</div></td>";


                      TBL += "<td    style='font-size:12px;font-family:arial;'><div type='text'contentEditable='true' style='overflow:auto; width:250px; height:50px; font-family:helvetica; font-size:14px;' align='left' id='fillstory_" + i + "' >" + ds.Tables[0].Rows[i]["FILLSTORY"].ToString() + "</div></td>";


                      TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='false' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='image_" + i + "' >" + ds.Tables[0].Rows[i]["IMAGE"].ToString() + "</div></td>";


                      TBL += "<td   style='font-size:12px;font-family:arial;'><div type='text'contentEditable='false' style='overflow:auto; width:130px; height:50px; font-family:helvetica; font-size:14px;' align='left'id='time_" + i + "' >" + ds.Tables[0].Rows[i]["TIME"].ToString() + "</div></td>";
                      TBL += "<td><Button runat='server' style='width:50px;'   align='left' Text='update' id=update_" + i + " onClick=\"data1('headlines_" + i + "' , 'keyword_" + i + "' , 'synopsis_" + i + "' , 'fillstory_" + i + "' , 'image_" + i + "' , 'time_" + i + "' )\">update</Button></td>";
                      TBL += "<td><Button runat='server' style='width:50px; ' align='left' Text='delete' 'id=delete_" + i + " onClick=\"datadel('headlines_" + i + "' , 'keyword_" + i + "' , 'synopsis_" + i + "' , 'fillstory_" + i + "' , 'image_" + i + "' , 'time_" + i + "' )\">delete</Button></td>";
                      //TBL += "<td><Button runat='server' style='width:50px; ' align='left' Text='publish' 'id=publish_" + i + " onClick='javascript:return datapublish(this.id);'>publish</Button></td>";
                      TBL += "</tr'>";
                      Htime.Value = ds.Tables[0].Rows[i]["TIME"].ToString();

                  }
                  TBL += "</table>";
                  divgrid.InnerHtml = TBL.ToString(); ;
          

            }
            return;


            
            
          
        }

    [Ajax.AjaxMethod]
    public DataSet upddata(string head, string keyword, string snopsis, string story, string picformat, string date, string datadate)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.dailyarticle country = new ASTROLOGY.classesoracle.dailyarticle();
            ds = country.upddata1(head, keyword, snopsis, story, picformat, date, datadate);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet deldata(string head, string keyword, string snopsis, string story, string picformat, string datadate)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.dailyarticle country = new ASTROLOGY.classesoracle.dailyarticle();
            ds = country.datadel(head, keyword, snopsis, story, picformat, datadate);
        }
        return ds;
    }

   
    
    }

