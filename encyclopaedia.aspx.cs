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
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Media;
using AjaxControlToolkit;
public partial class encyclopaedia : System.Web.UI.Page
{ 
    string message="";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(encyclopaedia));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/encyclopaedia.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
        div5.Attributes.Add("style","visibility:hidden;");
             
        if (!Page.IsPostBack)
        {
            bindhouse();
            bindplanet();
            bindrashi();
            bindext();
            inserts.Attributes.Add("onclick", "javascript:return significatorinsert();");
            exte.Attributes.Add("onclick", "javascript:return showextentions();");
            ms.Attributes.Add("onclick", "javascript:return showmultiplesignificators();");
            gs.Attributes.Add("onkeydown", "javascript:return fillcategery(event);");
            Button2.Attributes.Add("onclick", "javascript:return ShowPreview();");
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnSave.Attributes.Add("onclick", "javascript:return Save_Records();");
            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnCancel.Attributes.Add("onclick", "javascript:return click_on_cancel();");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
            texthouse.Attributes.Add("onchange", "javascript:return clh()");
            planet.Attributes.Add("onchange", "javascript:return clp()");
            rashi.Attributes.Add("onchange", "javascript:return clr()");
        }
        Textname.Enabled = false;
        Textcode.Enabled = false;
        detail.Enabled = false;
        btnDelete.Enabled = false;
        btnExecute.Enabled = false;
        btnfirst.Enabled = false;
        btnlast.Enabled = false;
        btnModify.Enabled = false;
        btnnext.Enabled = false;
        btnprevious.Enabled = false;
        btnSave.Enabled = false;
        book.Enabled = false;
        page0.Enabled = false;
    }


    [Ajax.AjaxMethod]
    public DataSet fill_categery(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_categerygs(extra1);
        }
        //else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
        //{
        //    Circulation.Classes.lebel_gen gen = new Circulation.Classes.lebel_gen();
        //    ds = gen.bindagency_code1(compcode, unit, dateformate, extra1, extra2);
        //}
        return ds;
    }


    public void bindplanet()
    {
        planet.Items.Clear();
        plant.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        planet.Items.Add(li);
        plant.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
            plant.Items.Add(li1);
        }



    }


    public void bindext()
    {
        ext.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_ext("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Extentions--";
        li.Value = "0";
        li.Selected = true;
        ext.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["EXTENTIONS"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["EXTENTIONS"].ToString();
            ext.Items.Add(li1);

        }



    }


    public void bindrashi()
    {
        rashi.Items.Clear();
       rash.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rashi("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
        rashi.Items.Add(li);
      rash.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            rashi.Items.Add(li1);
           rash.Items.Add(li1);

        }




    }
    public void bindhouse()
    {
        texthouse.Items.Clear();
        hous.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_house("");
        }

        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        texthouse.Items.Add(li);
        hous.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            texthouse.Items.Add(li1);
            hous.Items.Add(li1);
        }
    }
   
    protected void AspNetMessageBox(string strMessage)
    {
        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(encyclopaedia), "ShowAlert", strAlert, true);
    }

    
    [Ajax.AjaxMethod]
    public string save1(string CODE, string KEY_STRING, string DESCCLOB,string BOOK,string PAGE_NO,string HOUSE,string PLANET,string RASHI,string EXTENTIONS)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.save_encyclopaedia(CODE, KEY_STRING, DESCCLOB,BOOK,PAGE_NO,HOUSE,PLANET,RASHI,EXTENTIONS);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }

    

    




    [Ajax.AjaxMethod]
    public DataSet execute1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
    {
      
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

      
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.execute1(tbl, col, val, mit, dateformat, extra1, extra2);
        }
        return ds;
      
    }
    [Ajax.AjaxMethod]
    public string agency_delete1(string tbl, string col, string val, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.delete1(tbl, col, val, formt, extra1, extra2);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }
    [Ajax.AjaxMethod]
    public string Modify_data1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

             
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modify_data1(tbl, col, val, mit, dateformat, extra1, extra2);

            }
            return "true";

        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        string serverpath = "";

        string strFileName = File1.PostedFile.FileName;



        if (strFileName == "")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have not Browse the File.');", true);
            return;
        }
        if (File1.PostedFile.ContentType == "image/pjpeg" || File1.PostedFile.ContentType == "image/gif" || File1.PostedFile.ContentType == "image/tiff" || File1.PostedFile.ContentType == "image/eps" || File1.PostedFile.ContentType == "image/pdf" || File1.PostedFile.ContentType == "image/tif" || File1.PostedFile.ContentType == "image/jpg")
        {

               for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (strFileName.Split('\\')[strFileName.Split('\\').Length - 1] == ListBox1.Items[i].Value)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have already attached this File.');", true);
                    return;
                }

            }


            serverpath = Server.MapPath("Attachment/");
            string fname = System.IO.Path.GetFileName(strFileName);
            File1.PostedFile.SaveAs(Path.Combine(serverpath, fname));
            hiddenfilename.Value = hiddenfilename.Value + fname + ":";
            string filelst = hiddenfilename.Value;
            string[] arr = filelst.Split(':');
            ListBox1.DataSource = arr;
            ListBox1.DataBind();
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('File Attached Successfully.');", true);
            return;

        }
        else 
        {
            message = "Upload status: Only Jpeg,gif,eps,tiff files are accepted!";
            AspNetMessageBox(message);
            return;
        }
    }

    protected void audio_Click1(object sender, EventArgs e)
    { 
    string serverpath = "";

        string strFileName = File2.PostedFile.FileName;



        if (strFileName == "")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have not Browse the File.');", true);
            return;
        }
        if (File2.PostedFile.ContentType == "audio/wav" || File2.PostedFile.ContentType == "audio/mpeg3" || File2.PostedFile.ContentType == "audio/mpeg" || File2.PostedFile.ContentType == "audio/mp3")
        {





            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                if (strFileName.Split('\\')[strFileName.Split('\\').Length - 1] == ListBox2.Items[i].Value)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have already attached this File.');", true);
                    return;
                }

            }




            serverpath = Server.MapPath("Attachment/");
            string fname = System.IO.Path.GetFileName(strFileName);
            File2.PostedFile.SaveAs(Path.Combine(serverpath, fname));
            hiddenfilename.Value = hiddenfilename.Value + fname + ":";

            string filelst = hiddenfilename.Value;
            string[] arr = filelst.Split(':');
            ListBox2.DataSource = arr;
            ListBox2.DataBind();


            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('File Attached Successfully.');", true);
            return;

        }
        else 
        
        {
            message = "Upload status: Only Audio files are accepted!";
            AspNetMessageBox(message);
            return;
        }
    
    
    
    
   
   
    
    
  }





    protected void play_Click1(object sender, EventArgs e)
    {
        string sound = ListBox2.SelectedValue;
        if (sound != "")
        {
            WinMedia1.Attributes.Add("src", "Attachment/" + sound);
            div5.Attributes.Add("style", "visibility:visible;");
        }
        else
        {

            message = "Select audio file!";
            AspNetMessageBox(message);
            return;
        
        }
        
    }



    [Ajax.AjaxMethod]
    public DataSet filtergrid1(string comp_code, string house, string rashi, string planet, string textname,  string book, string page0,string EXTENTIONS, string extra1)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.fillgrid(comp_code, house, rashi, planet, textname, book, page0,EXTENTIONS, extra1);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet update_grid(string key, string key1,string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_gridencyclo(key, key1,housev);
        }
        return ds;


    }



    [Ajax.AjaxMethod]
    public DataSet delete_grid_row(string key,string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.delete_gridencyclo(key,housev);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet showext(string exten)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showextn(exten);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet showextvalue(string exten, string extenvalue)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showextnvalue(exten, extenvalue);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet chk_encyclo(string key, string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.chk_encyclogrid(key, housev);
        }
        return ds;


    }

     [Ajax.AjaxMethod]
    public DataSet multisignificators(string multisign)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showmultisigni(multisign);
        }
        return ds;
    }


     [Ajax.AjaxMethod]
     public DataSet PublishUnpublishSignificators(string key, string key1, string housev,string status,string groupid)
     {
         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {
             ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
             ds = country.PublishUnpublishSignificators(key, key1, housev, status, groupid);
         }
         return ds;
     }

    
}
