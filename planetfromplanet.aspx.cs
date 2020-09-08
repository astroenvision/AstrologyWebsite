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

public partial class planetfromplanet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(planetfromplanet));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/planetfromplanet.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
        hiddenvalue.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();

        //Hidden12.Value = Request.QueryString["ss"].ToString();
        //Hidden11.Value = Request.QueryString["kk"].ToString();        
        if (!Page.IsPostBack)
        {
            bindplanet();
            bindhouse();
            div2.Attributes.Add("style", "visibility:hidden;");
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnCancel.Attributes.Add("onclick", "javascript:return ClearAll();");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            //btnSave.Attributes.Add("onclick", "javascript:return save_records();");
            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");
            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");

        }


    }
    public void bindplanet()
    {
        planet.Items.Clear();
        planet1.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        planet.Items.Add(li);
        planet1.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
            planet1.Items.Add(li1);
        }
    }

    public void bindhouse()
    {
        house.Items.Clear();

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
        house.Items.Add(li);


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            house.Items.Add(li1);
        }
    }

    [Ajax.AjaxMethod]
    public string Modify_data(string tbl, string col, string val, string mit, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
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


    [Ajax.AjaxMethod]
    public DataSet execute(string tbl, string col, string val, string mit, string formt, string extra1, string extra2)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.execute(tbl, col, val, mit, formt, extra1, extra2);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public string deletep(string tbl, string col, string val, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
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

    protected void house_SelectedIndexChanged(object sender, EventArgs e)
    {
       DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    if (house.SelectedIndex == 0)
                    {
                        return;
                    }
                    else
                    {
                      if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                        {

                            string inhouse =house.SelectedValue;
                          string planets=planet.SelectedValue;
                          string fromplanet = planet1.SelectedValue;
                          ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                          ds = country.planetfromplanet(planets, fromplanet, inhouse);
                        }
                        GridView1.DataSource = ds.Tables[0];
                        GridView1.DataBind();
                        return;
                    }
                }
                    
    }

    protected void cbCheckAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkall = (CheckBox)GridView1.HeaderRow.Cells[0].FindControl("checkselect");
        foreach (GridViewRow dr in GridView1.Rows)
        {
            if (chkall.Checked == true)
            {
                CheckBox chk = dr.Cells[0].FindControl("check1") as CheckBox;
                chk.Checked = true;
            }
            else
            {
                CheckBox chk = dr.Cells[0].FindControl("check1") as CheckBox;
                chk.Checked = false;
            }

        }

    }

    protected void cbCheckeach_CheckedChanged(object sender, EventArgs e)
    {
        var flag = "false";
        CheckBox chkall = (CheckBox)GridView1.HeaderRow.Cells[0].FindControl("checkselect");
        foreach (GridViewRow dr in GridView1.Rows)
        {
            CheckBox chk = dr.Cells[0].FindControl("check1") as CheckBox;
            if (chk.Checked == false)
            {
                flag = "false";
                break;
            }
            else
            {
                flag = "true";
            }

        }
        if (flag == "true")
            chkall.Checked = true;
        else
            chkall.Checked = false;
    }

    protected void AspNetMessageBox(string strMessage)
    {
        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(planetfromplanet), "ShowAlert", strAlert, true);
    }
    
    string message;
    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        if (Hidden10.Value == "1")
        {
            string col = "";
            string val = "";
            string houses = house.SelectedValue;
            string planets = planet.SelectedValue;
            string planets1 = planet1.SelectedValue;
            string desc = description.Text;
            string details = detail.Text;
            string book1 = book.Text;
            string keystring1 = keystring.Text;
            val = "'" + planets + "'" + "$~$" + "'" + houses + "'" + "$~$" + "'" + planets1 + "'" + "$~$" + "'" + book1 + "'" + "$~$" + "'" + details + "'" + "$~$" + "'" + desc + "'" + "$~$" + "'" + keystring1 + "'" + "$~$";
               
         
            string tbl = "PLANETFROMPLANET";
            string concolname = "PLANET" + "$~$" + "HOUSE" + "$~$" + "FROM_PLANET"  + "$~$";
            string mit = concolname;
            string formt = hiddendateformat.Value;
            col = "PLANET" + "$~$" + "HOUSE" + "$~$" + "FROM_PLANET" + "$~$" + "BOOK" + "$~$" + "DESCRIPTION" + "$~$" + "DESCCLOB" + "$~$" + "KEY_STRING" + "$~$";

           
            string extra1 = "";
            string extra2 = "";
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modify_data(tbl, col, val, mit, formt, extra1, extra2);

            }



            message = "Data updated Successfully";
            AspNetMessageBox(message);
            Hidden10.Value = "0";
            return;


        }
        else
        {


            foreach (GridViewRow r in GridView1.Rows)
            {
                CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                if (ch.Checked == true)
                {
                    string BOOK = book.Text;
                    string KEY_STRING = keystring.Text;
                    
                    string RASHI = r.Cells[5].Text.ToString();
                    string HOUSE = r.Cells[4].Text.ToString();
                    string LAGNARASHI = r.Cells[1].Text.ToString();

                    string LORD = planet.SelectedValue;

                    string PLANET1 = planet1.SelectedValue;
                    string DESCRIPTION = description.Text.ToString();
                    string DESCCLOB = detail.Text.ToString();
                    string PLANET = planet.SelectedValue;

                    DataSet ds = new DataSet();
                    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                    {
                        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                        ds = country.saveplanetfromplanet(PLANET, HOUSE, PLANET1, BOOK, DESCRIPTION, DESCCLOB, RASHI, LORD, KEY_STRING, LAGNARASHI,"","","","");
                    }
                }


            }
            message = "Data Saved Successfully";

            CheckBox chkall = (CheckBox)GridView1.HeaderRow.Cells[0].FindControl("checkselect");
            chkall.Checked = false;
            foreach (GridViewRow r in GridView1.Rows)
            {
                CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                ch.Checked = false;

            }
            AspNetMessageBox(message);
            description.Text = "";
            detail.Text = "";
            book.Text = "";
            keystring.Text = "";
            house.SelectedIndex=0;
            planet.SelectedIndex = 0;
                planet1.SelectedIndex=0;
        }
    }
    protected void btnExecute_Click(object sender, ImageClickEventArgs e)
    {
       planet.SelectedValue = Hidden1.Value;
       house.SelectedValue = Hidden2.Value;
       planet1.SelectedValue = Hidden3.Value;
       description.Text = Hidden4.Value;
       detail.Text = Hidden5.Value;
       
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden2.Value;
                    string s1 = Hidden2.Value;
                  
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.inhouse1(s1, s2);
                    
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    
                }

                
                DataSet ds1 = new DataSet();


                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                    ds1 = country.bindin1("");
                    
                    GridView2.DataSource = ds1.Tables[0];
                    GridView2.DataBind();


                }

                foreach (GridViewRow r in GridView1.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string desc = description.Text;
                    foreach (GridViewRow r1 in GridView2.Rows)
                    {
                        string ras = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string descr = r1.Cells[2].Text.ToString();
                       
                        if (lo == lor && ra == ras && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }

                    }
                }

            }


    protected void btnnext_Click(object sender, ImageClickEventArgs e)
    {

       
        house.SelectedValue = Hidden6.Value;

       
        btnfirst.Enabled = true;
        btnprevious.Enabled = true;
       
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden6.Value;
                    string s2 = Hidden6.Value;

                    
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.inhouse1(s1, s2);
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                  

                }

                
                DataSet ds1 = new DataSet();


                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                    ds1 = country.bindin1("");
  
                    GridView2.DataSource = ds1.Tables[0];
                    GridView2.DataBind();


                }
                foreach (GridViewRow r in GridView1.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string l = r.Cells[2].Text.ToString();
                  
                    string desc = description.Text;
                    foreach (GridViewRow r1 in GridView2.Rows)
                    {
                        string ras = r1.Cells[0].Text.ToString();
                        string lo = r1.Cells[1].Text.ToString();
                        string descr = r1.Cells[2].Text.ToString();
                        
                        if (l == lo && ra == ras && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }

                    }

                }
            }

    protected void btnfirst_Click(object sender, ImageClickEventArgs e)
    {
        house.SelectedValue = Hidden7.Value;


        btnfirst.Enabled = false;
        btnnext.Enabled = true;
        btnlast.Enabled = true;
        btnprevious.Enabled = false;

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            string s1 = Hidden7.Value;
            string s2 = Hidden7.Value;


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.inhouse1(s1, s2);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


        }


        DataSet ds1 = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds1 = country.bindin1("");

            GridView2.DataSource = ds1.Tables[0];
            GridView2.DataBind();


        }
        foreach (GridViewRow r in GridView1.Rows)
        {
            string ra = r.Cells[1].Text.ToString();
            string l = r.Cells[2].Text.ToString();

            string desc = description.Text;
            foreach (GridViewRow r1 in GridView2.Rows)
            {
                string ras = r1.Cells[0].Text.ToString();
                string lo = r1.Cells[1].Text.ToString();
                string descr = r1.Cells[2].Text.ToString();

                if (l == lo && ra == ras && desc == descr)
                {
                    CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                    ch.Checked = true;
                }

            }

        }
    }
    protected void btnprevious_Click(object sender, ImageClickEventArgs e)
    {
        house.SelectedValue = Hidden8.Value;

        btnnext.Enabled = true;
        btnlast.Enabled = true;

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            string s1 = Hidden8.Value;
            string s2 = Hidden8.Value;


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.inhouse1(s1, s2);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


        }


        DataSet ds1 = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds1 = country.bindin1("");

            GridView2.DataSource = ds1.Tables[0];
            GridView2.DataBind();


        }
        foreach (GridViewRow r in GridView1.Rows)
        {
            string ra = r.Cells[1].Text.ToString();
            string l = r.Cells[2].Text.ToString();

            string desc = description.Text;
            foreach (GridViewRow r1 in GridView2.Rows)
            {
                string ras = r1.Cells[0].Text.ToString();
                string lo = r1.Cells[1].Text.ToString();
                string descr = r1.Cells[2].Text.ToString();

                if (l == lo && ra == ras && desc == descr)
                {
                    CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                    ch.Checked = true;
                }

            }

        }
    }
    protected void btnlast_Click(object sender, ImageClickEventArgs e)
    {
        house.SelectedValue = Hidden9.Value;

        btnlast.Enabled = false;
        btnfirst.Enabled = true;
        btnprevious.Enabled = true;
        btnnext.Enabled = false;

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            string s1 = Hidden9.Value;
            string s2 = Hidden9.Value;


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.inhouse1(s1, s2);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


        }


        DataSet ds1 = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds1 = country.bindin1("");

            GridView2.DataSource = ds1.Tables[0];
            GridView2.DataBind();


        }
        foreach (GridViewRow r in GridView1.Rows)
        {
            string ra = r.Cells[1].Text.ToString();
            string l = r.Cells[2].Text.ToString();

            string desc = description.Text;
            foreach (GridViewRow r1 in GridView2.Rows)
            {
                string ras = r1.Cells[0].Text.ToString();
                string lo = r1.Cells[1].Text.ToString();
                string descr = r1.Cells[2].Text.ToString();

                if (l == lo && ra == ras && desc == descr)
                {
                    CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                    ch.Checked = true;
                }

            }

        }
    }
}
