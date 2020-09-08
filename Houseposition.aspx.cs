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

public partial class Houseposition : System.Web.UI.Page
{
    string message="";
    int v=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(Houseposition));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/houseposition.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
        hiddenvalue.Value = ds1.Tables[1].Rows[0].ItemArray[0].ToString();

        //Hidden7.Value = Request.QueryString["ss"].ToString();
        //Hidden6.Value = Request.QueryString["kk"].ToString();       
      
        if (!Page.IsPostBack)
        {
            bindhouse();
            bindrashi();
            bindplanet();
            bindascendent();
            bindconstellation();
            bindchart();
            bindaspectingplanet();
           // lordofhouse();
          //  bindhouse1();
            
            Button6.Attributes.Add("onclick", "javascript:return ShowPreview();");
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnSave.Attributes.Add("onclick", "javascript:return Save_Records();");
            btnCancel.Attributes.Add("onclick", "javascript:return ClearAll();");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            //btnExit.Attributes.Add("onclick", "javascript:return callback_allview(res);");
           btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
           // LinkButton1.Attributes.Add("onclick", "javascript:return LinkButton1_Click();");

            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");
            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");
            addrow.Attributes.Add("onclick", "javascript:return grid1()");




        }

    }

    public void bindchart()
    {

        chart.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_chart("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;

        chart.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            

            chart.Items.Add(li1);
        }




    }

    //public void lordofhouse()
    //{

    //    loh.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.AST_lord_bind("");

    //    }


    //    ListItem li = new ListItem();
    //    li.Text = "--Select Lord Of House--";
    //    li.Value = "0";
    //    li.Selected = true;

    //    loh.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();


    //        loh.Items.Add(li1);
    //    }




    //}
    public void bindhouse()
    {
        Drphouse.Items.Clear();
        loh.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_house("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        Drphouse.Items.Add(li);
        loh.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            Drphouse.Items.Add(li1);
            loh.Items.Add(li1);

        }
    }
    //public void bindhouse1()
    //{
    //    DropDownList1.Items.Clear();

    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.ast_house("");

    //    }

    //    //hdncompcode.Value
    //    ListItem li = new ListItem();
    //    li.Text = "--Select House--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    DropDownList1.Items.Add(li);

    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
    //        li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        DropDownList1.Items.Add(li1);


    //    }
    //}

    public void bindconstellation()
    {
        constellationbox.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_constellation("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Constellation--";
        li.Value = "0";
        li.Selected = true;
        constellationbox.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            constellationbox.Items.Add(li1);

        }
    }



    public void bindascendent()
    {
        ascendentbox.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_ascendent("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Ascendent--";
        li.Value = "0";
        li.Selected = true;
        ascendentbox.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            ascendentbox.Items.Add(li1);

        }
    }
    //.........................................bind Rashi................


    public void bindrashi()
    {
        Drprashi.Items.Clear();
       
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
        Drprashi.Items.Add(li);
        
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            Drprashi.Items.Add(li1);
            

        }




    }

    //..............................Bind for Planet..........................
    public void bindplanet()
    {
        Drpplanet.Items.Clear();
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
        Drpplanet.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            Drpplanet.Items.Add(li1);

        }




    }


    public void bindaspectingplanet()
    {
        accepting.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Aspecting Planet--";
        li.Value = "0";
        li.Selected = true;
        accepting.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            accepting.Items.Add(li1);

        }




    }
    //..........................for execute................

    [Ajax.AjaxMethod]
    public DataSet execute(string tbl, string col, string val, string mit, string formt, string extra1, string extra2)
    {
        //try
        //{
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.execute(tbl, col, val, mit, formt, extra1, extra2);
        }
        return ds;
        //  }
        //     catch (Exception ex)
        //     {
        //         return Convert.ToString(ex.Message);

        //     }

    }


    //this is for save..........................................................


    [Ajax.AjaxMethod]
    public string save(string tbl, string col, string val, string mit, string formt, string extra1, string extra2, string extra3,string extra4,string extra5,string extra6,string extra7,string extra8,string extra9,string extra10,string extra11,string extra12,string extra13)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.save(tbl, col, val, mit, formt, extra1, extra2, extra3, extra4, extra5, extra6, extra7, extra8, extra9, extra10, extra11, extra12, extra13);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);
        }
    }



    [Ajax.AjaxMethod]
    public string save_priority(string code, string priority, string descclob, string ref_, string updated, string casedescription)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.savepriority(code, priority, descclob, ref_, updated, casedescription);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);
        }
    }

    //*********************this is for delete*************************

    [Ajax.AjaxMethod]
    public string agency_delete(string tbl, string col, string val, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.delete(tbl, col, val, formt, extra1, extra2);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }

    [Ajax.AjaxMethod]
    public DataSet genastcode(string tbl, string col, string val, string mit, string ascendent, string constellation, string degrrefrom, string degreeto, string chart, string aspecting,string loh1)
    {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.genastcode(tbl, col, val, mit, ascendent, constellation, degrrefrom, degreeto, chart, aspecting, loh1);
            }
            return ds;
    }

    [Ajax.AjaxMethod]
    public string refcode(string extra1, string extra2)
    {
        string fetchvalue = "";
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.refcode(extra1, extra2);

            if (ds.Tables[0].Rows.Count > 0)
            {
                fetchvalue = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                return fetchvalue;
            }

        }
        return fetchvalue;
    }

    [Ajax.AjaxMethod]
    public string Modify_data(string tbl, string col, string val, string mit, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modify_data(tbl, col, val, mit, formt, extra1, extra2);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }
    }
    
    protected void AspNetMessageBox(string strMessage)
    {
        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(Houseposition), "ShowAlert", strAlert, true);
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Categery.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
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
                message = "Upload status: Only JPEG,gif,tif,eps files are accepted!";
                AspNetMessageBox(message);
                return;
            }
        }
    }
    int value11;
    int value21;
    int valu1 = 0;
    int val11;
    protected void Drprashi_SelectedIndexChanged(object sender, EventArgs e)
    {
        string rashi;
        string house;
        string loh1;
    
        if (Drprashi.SelectedIndex == 1 || Drprashi.SelectedIndex == 8)
        {
            Drpplanet.SelectedIndex = 5;
        }

        if (Drprashi.SelectedIndex == 2 || Drprashi.SelectedIndex == 7)
        {
            Drpplanet.SelectedIndex = 4;
        }
        if (Drprashi.SelectedIndex == 3 || Drprashi.SelectedIndex == 6)
        {
            Drpplanet.SelectedIndex = 3;
        }
        if (Drprashi.SelectedIndex == 4)
        {
            Drpplanet.SelectedIndex = 2;
        }

        if (Drprashi.SelectedIndex == 5)
        {
            Drpplanet.SelectedIndex = 1;
        }

        if (Drprashi.SelectedIndex == 9 || Drprashi.SelectedIndex == 12)
        {
            Drpplanet.SelectedIndex = 6;
        }

        if (Drprashi.SelectedIndex == 10 || Drprashi.SelectedIndex == 11)
        {
            Drpplanet.SelectedIndex = 7;
        }
    }
    protected void loh_SelectedIndexChanged(object sender, EventArgs e)
    {
        string rashi;
        string house;
        string loh1;
        if (Drphouse.SelectedIndex == 0)
        {
            Drpplanet.SelectedIndex = 0;
            return;
        }
        else
        {
          house=  Drphouse.SelectedValue;
        }
        if (Drprashi.SelectedIndex == 0)
        {
           Drpplanet.SelectedIndex = 0;
           return;
        }
        else
        {
          rashi= Drprashi.SelectedValue;
        }
         if(loh.SelectedIndex==0)
         {
            Drpplanet.SelectedIndex = 0;
            return;
         }
        else
        {
           loh1= loh.SelectedValue;
           DataSet ds = new DataSet();
           if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
           {
               ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
               ds = country.getlordofhouse(loh1,house,rashi);
               Drpplanet.SelectedValue = ds.Tables[0].Rows[0]["NAME"].ToString();
           }
          }
    }
    int value1;
    int value2;
    int valu = 0;
    int val1;
    protected void Drphouse_SelectedIndexChanged(object sender, EventArgs e)
    {
        string rashi;
        string house;
        string loh1;
        if (Drprashi.SelectedIndex == 0)
        { }
        else
        {
            if (Hidden4.Value == "")
            {
                Hidden4.Value = "0";
            }
            valuehidden.Value = Convert.ToString(Drphouse.SelectedIndex);
            int a = Convert.ToInt32(valuehidden.Value) - Convert.ToInt32(Hidden4.Value);
            if (a < 0)
            {
                a = a * (-1);
            }
            Hidden4.Value = valuehidden.Value;
            value2 = Drprashi.SelectedIndex;
            val1 = value2 + a;
            if (val1 > 12)
            {
                int val2 = val1 - 12;
                Drprashi.SelectedIndex = val2;
            }
            else
            {
                Drprashi.SelectedIndex = val1;
            }
        }
    

        if (Drprashi.SelectedIndex == 1 || Drprashi.SelectedIndex == 8)
        {
            Drpplanet.SelectedIndex = 5;
        }

        if (Drprashi.SelectedIndex == 2 || Drprashi.SelectedIndex == 7)
        {
            Drpplanet.SelectedIndex = 4;
        }
        if (Drprashi.SelectedIndex == 3 || Drprashi.SelectedIndex == 6)
        {
            Drpplanet.SelectedIndex = 3;
        }
        if (Drprashi.SelectedIndex == 4 )
        {
            Drpplanet.SelectedIndex = 2;
        }
        if (Drprashi.SelectedIndex == 5 )
        {
            Drpplanet.SelectedIndex = 1;
        }
        if (Drprashi.SelectedIndex == 9 || Drprashi.SelectedIndex == 12)
        {
            Drpplanet.SelectedIndex = 6;
        }
        if (Drprashi.SelectedIndex == 10 || Drprashi.SelectedIndex == 11)
        {
            Drpplanet.SelectedIndex = 7;
        }
    }
    protected void Drpplanet_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}
    


    
      
