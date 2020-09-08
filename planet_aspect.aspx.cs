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


public partial class planet_aspect : System.Web.UI.Page
{
    int count;
    string ss = "";
    string kk = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(planet_aspect));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/aspectplanet.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
        hiddenvalue.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        //Hidden38.Value = Request.QueryString["ss"].ToString();
        //Hidden37.Value = Request.QueryString["kk"].ToString();
        if (!Page.IsPostBack)
        {
            bindplanet();
            bindlohhouse();
            bindcategery();
            bindastrocat();

            div2.Attributes.Add("style", "visibility:hidden;");
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnCancel.Attributes.Add("onclick", "javascript:return ClearAll();");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            // d1.Attributes.Add("onclick", "javascript:return d1chart();");
            //d9.Attributes.Add("onclick", "javascript:return d9chart();");

            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");

            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");




        }


    }


    public void bindcategery()
    {
        DropDownList2.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_categery("");
        }
        ListItem li = new ListItem();
        li.Text = "--Select categery--";
        li.Value = "0";
        li.Selected = true;
        DropDownList2.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();
            DropDownList2.Items.Add(li1);
        }
    }
    public void bindplanet()
    {
        planet.Items.Clear();
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
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
        }
    }

    public void bindastrocat()
    {
        astrocat.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_astrocat("");
        }
        ListItem li = new ListItem();
        li.Text = "--Select astrocat--";
        li.Value = "0";
        li.Selected = true;
        astrocat.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();
            astrocat.Items.Add(li1);
        }
    }

    public void bindlohhouse()
    {
        DropDownList1.Items.Clear();
        house.Items.Clear();
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
        DropDownList1.Items.Add(li);
        house.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            DropDownList1.Items.Add(li1);
            house.Items.Add(li1);
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

    protected void cbCheckAll1_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkall = (CheckBox)GridView4.HeaderRow.Cells[0].FindControl("checkselect1");
        foreach (GridViewRow dr in GridView4.Rows)
        {
            if (chkall.Checked == true)
            {
                CheckBox chk = dr.Cells[0].FindControl("check2") as CheckBox;
                chk.Checked = true;
            }
            else
            {
                CheckBox chk = dr.Cells[0].FindControl("check2") as CheckBox;
                chk.Checked = false;
            }
        }
    }

    protected void cbCheckeach1_CheckedChanged(object sender, EventArgs e)
    {
        var flag = "false";
        CheckBox chkall = (CheckBox)GridView4.HeaderRow.Cells[0].FindControl("checkselect1");
        foreach (GridViewRow dr in GridView4.Rows)
        {
            CheckBox chk = dr.Cells[0].FindControl("check2") as CheckBox;
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

    protected void cbCheckAll2_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkall = (CheckBox)GridView6.HeaderRow.Cells[0].FindControl("checkselect2");
        foreach (GridViewRow dr in GridView6.Rows)
        {
            if (chkall.Checked == true)
            {
                CheckBox chk = dr.Cells[0].FindControl("check3") as CheckBox;
                chk.Checked = true;
            }
            else
            {
                CheckBox chk = dr.Cells[0].FindControl("check3") as CheckBox;
                chk.Checked = false;
            }
        }
    }

    protected void cbCheckeach2_CheckedChanged(object sender, EventArgs e)
    {
        var flag = "false";
        CheckBox chkall = (CheckBox)GridView6.HeaderRow.Cells[0].FindControl("checkselect2");
        foreach (GridViewRow dr in GridView6.Rows)
        {
            CheckBox chk = dr.Cells[0].FindControl("check3") as CheckBox;
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



    protected void cbCheckAll8_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkall = (CheckBox)GridView8.HeaderRow.Cells[0].FindControl("checkselect8");
        foreach (GridViewRow dr in GridView8.Rows)
        {
            if (chkall.Checked == true)
            {
                CheckBox chk = dr.Cells[0].FindControl("check8") as CheckBox;
                chk.Checked = true;
            }
            else
            {
                CheckBox chk = dr.Cells[0].FindControl("check8") as CheckBox;
                chk.Checked = false;
            }
        }
    }

    protected void cbCheckeach8_CheckedChanged(object sender, EventArgs e)
    {
        var flag = "false";
        CheckBox chkall = (CheckBox)GridView8.HeaderRow.Cells[0].FindControl("checkselect8");
        foreach (GridViewRow dr in GridView8.Rows)
        {
            CheckBox chk = dr.Cells[0].FindControl("check8") as CheckBox;
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


    [Ajax.AjaxMethod]
    public string Modify_dataaspect(string tbl, string col, string val, string mit, string formt, string extra1, string extra2)
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

    [Ajax.AjaxMethod]
    public string deleteaspect(string tbl, string col, string val, string formt, string extra1, string extra2)
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

    //[Ajax.AjaxMethod]
    //public DataSet donechart(string planet, string house,string ldeg,string pdeg)
    //{

    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {

    //        //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.donecharts(planet, house, ldeg,pdeg);
    //    }
    //    return ds;


    //}








    protected void plant_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void quardent_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void house_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (astrocat.SelectedIndex == 1 || astrocat.SelectedIndex == 0)
        {
            if (DropDownList2.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        return;
                    }
                    else
                    {
                        string aspecthouse = house.SelectedValue;
                        string lordofhouse = DropDownList1.SelectedValue;
                        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                        ds = country.aspect(aspecthouse, lordofhouse);
    
                        GridView4.Visible = false;
                        GridView6.Visible = false;
                        GridView8.Visible = false;
                        GridView1.DataSource = ds.Tables[0];
                        GridView1.DataBind();
                        GridView1.Visible = true;
                        
                        
                        return;
                    }
                }
            }
            if (DropDownList2.SelectedIndex == 2)
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                        {
                            string withthouse = house.SelectedValue;
                            string lordofhouse = DropDownList1.SelectedValue;
                            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                            ds = country.bindwithhouse(withthouse, lordofhouse);
                        }
                        
                        GridView1.Visible = false;
                        GridView6.Visible = false;
                        GridView8.Visible = false;
                        GridView4.DataSource = ds.Tables[0];
                        GridView4.DataBind();
                        GridView4.Visible = true;
                       
                        return;
                    }
                }
            }

            if (DropDownList2.SelectedIndex == 3)
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                        {
                            string inhouse = house.SelectedValue;
                            string lordofhouse = DropDownList1.SelectedValue;
                            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                            ds = country.bindinhouse(lordofhouse,inhouse);
                        }
                        
                        GridView4.Visible = false;
                        GridView8.Visible = false;
                        GridView1.Visible = false;
                        GridView6.DataSource = ds.Tables[0];
                        GridView6.DataBind();
                        GridView6.Visible = true;
                       
                        return;
                    }
                }
            }
        }
        else
        {
            if (DropDownList2.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    if (planet.SelectedIndex == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                        {
                            string lordhouse = house.SelectedValue;
                            string planet1 = planet.SelectedValue;
                            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                            ds = country.bindplanethouse(lordhouse, planet1);
                            
                            GridView4.Visible = false;
                            GridView1.Visible = false;
                            GridView6.Visible = false;
                            GridView8.DataSource = ds.Tables[0];
                            GridView8.DataBind();
                            GridView8.Visible = true;
                            
                            return;
                        }
                    }
                }
            }

            
        }
    }



    protected void AspNetMessageBox(string strMessage)
    {
        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(planet_aspect), "ShowAlert", strAlert, true);
    }

    string message;
    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        if (Hidden36.Value == "1")
        {
            string col = "";
            string val = "";
            string planet1 = "";
            string loh = "";
            string astrocat1 = astrocat.SelectedValue;
            string loh2 = house.SelectedValue;
            string categery = DropDownList2.SelectedValue;
            string desc = Textdesc.Text;
            string detail = detaildesc.Text;
            string book1 = book.Text;
            string keystring1 = keystring.Text;
            if (astrocat.SelectedIndex == 2)
            {
                planet1 = planet.SelectedValue;
            }
            else
            {
                loh = DropDownList1.SelectedValue;
            }
            if (astrocat.SelectedIndex == 2)
            {
                val = "'" + loh2 + "'" + "$~$" + "'" + desc + "'" + "$~$" + "'" + detail + "'" + "$~$" + "'" + categery + "'" + "$~$" + "'" + planet1 + "'" + "$~$" + "'" + astrocat1 + "'" + "$~$" + "'" + book1 + "'" + "$~$" + "'" + keystring1 + "'" + "$~$";
            }
            else
            {
                val = "'" + loh2 + "'" + "$~$" + "'" + desc + "'" + "$~$" + "'" + detail + "'" + "$~$" + "'" + categery + "'" + "$~$" + "'" + loh + "'" + "$~$" + "'" + astrocat1 + "'" + "$~$" + "'" + book1 + "'" + "$~$" + "'" + keystring1 + "'" + "$~$";
            }
            string tbl = "PLANET_ASPECT";
            string concolname = "LORD_OF_HOUSE2" + "$~$" + "LORD_OF_HOUSE" + "$~$" + "CATEGERY" + "$~$" + "ASTRO_CAT" + "$~$";
            string mit = concolname;
            string formt = hiddendateformat.Value;
            if (astrocat.SelectedIndex == 2)
            {
                col = "LORD_OF_HOUSE2" + "$~$" + "DESCRIPTION" + "$~$" + "DESCCLOB" + "$~$" + "CATEGERY" + "$~$" + "PLANET" + "$~$" + "ASTRO_CAT" + "$~$" + "BOOK" + "$~$" + "KEY_STRING" + "$~$";
            }
            else
            {
                col = "LORD_OF_HOUSE2" + "$~$" + "DESCRIPTION" + "$~$" + "DESCCLOB" + "$~$" + "CATEGERY" + "$~$" + "LORD_OF_HOUSE" + "$~$" + "ASTRO_CAT" + "$~$" + "BOOK" + "$~$" + "KEY_STRING" + "$~$";
            }
            string extra1 = "";
            string extra2 = "";
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modify_data(tbl, col, val, mit, formt, extra1, extra2);
            }
            message = "Data updated Successfully";
            AspNetMessageBox(message);
            Hidden36.Value = "0";
            return;
        }
        else
        {
            if (astrocat.SelectedIndex == 1 || astrocat.SelectedIndex == 0)
            {
                if (DropDownList2.SelectedIndex == 1)
                {
                    foreach (GridViewRow r in GridView1.Rows)
                    {
                        CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                        if (ch.Checked == true)
                        {
                            string book1 = book.Text;
                            string keystring1 = keystring.Text;
                            string astrocat1 = astrocat.SelectedValue;
                            string lord = r.Cells[1].Text.ToString();
                            string rashi = r.Cells[2].Text.ToString();
                            string aspectrashi = r.Cells[5].Text.ToString();
                            string hous = r.Cells[3].Text.ToString();
                            string lagna = r.Cells[4].Text.ToString();
                            string aspects = house.SelectedValue;
                            string desc = Textdesc.Text.ToString();
                            string detail = detaildesc.Text.ToString();
                            string loh = DropDownList1.SelectedValue;
                            string categery = DropDownList2.SelectedValue;
                            string f11page = "";
                            DataSet ds = new DataSet();
                            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                            {
                                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                                ds = country.save_aspect(astrocat1, aspects, lord, rashi, hous, desc, detail, loh, categery, lagna, book1, keystring1, aspectrashi,f11page,"","","","");

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
                    Textdesc.Text = "";
                    detaildesc.Text = "";
                    book.Text = "";
                    keystring.Text = "";
                }

                if (DropDownList2.SelectedIndex == 2)
                {
                    foreach (GridViewRow r4 in GridView4.Rows)
                    {
                        CheckBox ch = r4.Cells[0].FindControl("check2") as CheckBox;
                        if (ch.Checked == true)
                        {
                            string book1 = book.Text;
                            string keystring1 = keystring.Text;
                            string astrocat1 = astrocat.SelectedValue;
                            string lagna = r4.Cells[1].Text.ToString();
                            string rashiwith = r4.Cells[6].Text.ToString();
                            string rashi = r4.Cells[5].Text.ToString();
                            string lordof = r4.Cells[2].Text.ToString();
                            string with = r4.Cells[3].Text.ToString();
                            string house1 = r4.Cells[4].Text.ToString();
                            string withhouse = house.SelectedValue;
                            string desc = Textdesc.Text.ToString();
                            string detail = detaildesc.Text.ToString();
                            string loh = DropDownList1.SelectedValue;
                            string categery = DropDownList2.SelectedValue;
                            DataSet ds = new DataSet();
                            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                            {
                                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                                ds = country.save_with(astrocat1, lagna, lordof, with, house1, withhouse, loh, desc, detail, categery, book1, keystring1, rashi, rashiwith);
                            }
                        }
                    }
                    message = "Data Saved Successfully";
                    CheckBox chkall = (CheckBox)GridView4.HeaderRow.Cells[0].FindControl("checkselect1");
                    chkall.Checked = false;
                    foreach (GridViewRow r4 in GridView4.Rows)
                    {
                        CheckBox ch = r4.Cells[0].FindControl("check2") as CheckBox;
                        ch.Checked = false;
                    }
                    AspNetMessageBox(message);
                    Textdesc.Text = "";
                    detaildesc.Text = "";
                    book.Text = "";
                    keystring.Text = "";
                }
                if (DropDownList2.SelectedIndex == 3)
                {
                    foreach (GridViewRow r6 in GridView6.Rows)
                    {
                        CheckBox ch = r6.Cells[0].FindControl("check3") as CheckBox;
                        if (ch.Checked == true)
                        {
                            string book1 = book.Text;
                            string keystring1 = keystring.Text;
                            string astrocat1 = astrocat.SelectedValue;
                            string lagna = r6.Cells[1].Text.ToString();
                            string rashi = r6.Cells[4].Text.ToString();
                            string inrashi = r6.Cells[5].Text.ToString();
                            string lordof = r6.Cells[2].Text.ToString();
                            string house2 = r6.Cells[3].Text.ToString();

                            string inhouse = house.SelectedValue;
                            string desc = Textdesc.Text.ToString();
                            string detail = detaildesc.Text.ToString();
                            string loh = DropDownList1.SelectedValue;
                            string categery = DropDownList2.SelectedValue;
                            string f9page = "";
                            DataSet ds = new DataSet();
                            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                            {
                                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                                ds = country.save_in(astrocat1, lagna, lordof, house2, inhouse, loh, desc, detail, categery, book1, keystring1, rashi, inrashi,f9page,"","","","");

                            }
                        }
                    }
                    message = "Data Saved Successfully";
                    CheckBox chkall = (CheckBox)GridView6.HeaderRow.Cells[0].FindControl("checkselect2");
                    chkall.Checked = false;
                    foreach (GridViewRow r6 in GridView6.Rows)
                    {
                        CheckBox ch = r6.Cells[0].FindControl("check3") as CheckBox;
                        ch.Checked = false;
                    }
                    AspNetMessageBox(message);
                    Textdesc.Text = "";
                    detaildesc.Text = "";
                    book.Text = "";
                    keystring.Text = "";
                }
            }
            else
            {
                if (DropDownList2.SelectedIndex == 1)
                {
                    foreach (GridViewRow r8 in GridView8.Rows)
                    {
                        CheckBox ch = r8.Cells[0].FindControl("check8") as CheckBox;
                        if (ch.Checked == true)
                        {
                            string book1 = book.Text;
                            string keystring1 = keystring.Text;
                            string astrocat1 = astrocat.SelectedValue;
                            string lagna = r8.Cells[1].Text.ToString();
                            string rashi = r8.Cells[5].Text.ToString();
                            string aspectrashi = r8.Cells[6].Text.ToString();
                            string lordp = r8.Cells[2].Text.ToString();
                            string aspecthouse = r8.Cells[4].Text.ToString();
                            string house1 = r8.Cells[3].Text.ToString();
                            string housep = house.SelectedValue;
                            string desc = Textdesc.Text.ToString();
                            string detail = detaildesc.Text.ToString();
                            string planet1 = planet.SelectedValue;
                            string categery = DropDownList2.SelectedValue;
                            string f12page = "";
                            DataSet ds = new DataSet();
                            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                            {
                                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                                ds = country.save_planet(astrocat1, lagna, planet1, categery, housep, desc, detail, lordp, house1, aspecthouse, book1, keystring1, rashi, aspectrashi,f12page,"","","","");
                            }
                        }
                    }
                    message = "Data Saved Successfully";
                    CheckBox chkall = (CheckBox)GridView8.HeaderRow.Cells[0].FindControl("checkselect8");
                    chkall.Checked = false;
                    foreach (GridViewRow r8 in GridView8.Rows)
                    {
                        CheckBox ch = r8.Cells[0].FindControl("check8") as CheckBox;
                        ch.Checked = false;
                    }
                    AspNetMessageBox(message);
                    Textdesc.Text = "";
                    detaildesc.Text = "";
                    book.Text = "";
                    keystring.Text = "";
                }
            }
        }
    }

    protected void btnExecute_Click(object sender, ImageClickEventArgs e)
    {
        if (astrocat.SelectedIndex == 2)
        {
            planet.SelectedValue = Hidden29.Value;
        }
        else
        {
            DropDownList1.SelectedValue = Hidden7.Value;
        }

        DropDownList2.SelectedValue = Hidden28.Value;
        house.SelectedValue = Hidden3.Value;
        Textdesc.Text = Hidden5.Value;
        detaildesc.Text = Hidden6.Value;
        string s = Hidden28.Value;
        if (astrocat.SelectedIndex == 0 || astrocat.SelectedIndex == 1)
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden7.Value;
                    string s1 = Hidden3.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.aspect1(s1, s2);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                string aspect = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspecthouse("");
                    GridView3.DataSource = ds1.Tables[0];
                    GridView3.DataBind();
                }
                foreach (GridViewRow r in GridView1.Rows)
                {
                    string l = r.Cells[1].Text.ToString();
                    string ra = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView3.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string housegrid = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && ra == ras && ho == housegrid && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }

            if (s == "With")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s3 = Hidden7.Value;
                    string s4 = Hidden3.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.with1(s3, s4);
                    GridView1.Visible = false;
                    GridView6.Visible = false;
                    GridView4.DataSource = ds.Tables[0];
                    GridView4.DataBind();
                    GridView4.Visible = true;
                }

                string with = house.SelectedValue;
                DataSet ds1 = new DataSet();


                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindwithhouse("");
                    GridView5.DataSource = ds1.Tables[0];
                    GridView5.DataBind();
                }

                foreach (GridViewRow r in GridView4.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string withlord = r.Cells[3].Text.ToString();
                    string ho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView5.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string withlord1 = r1.Cells[2].Text.ToString();
                        string housewith = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && withlord == withlord1 && ho == housewith && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check2") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }


            if (s == "In")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s5 = Hidden7.Value;
                    string s6 = Hidden3.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.in1(s5, s6);
                    GridView4.Visible = false;
                    GridView1.Visible = false;
                    GridView6.DataSource = ds.Tables[0];
                    GridView6.DataBind();
                    GridView6.Visible = true;
                }

                string inhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.inwithhouse("");
                    GridView7.DataSource = ds1.Tables[0];
                    GridView7.DataBind();
                }

                foreach (GridViewRow r in GridView6.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string lagna = r.Cells[1].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView7.Rows)
                    {
                        string lagn = r1.Cells[0].Text.ToString();
                        string inlord1 = r1.Cells[1].Text.ToString();
                        string housein = r1.Cells[2].Text.ToString();
                        string descr = r1.Cells[3].Text.ToString();
                        if (l == inlord1 && ho == housein && desc == descr && lagna == lagn)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check3") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden29.Value;
                    string s2 = Hidden3.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.bindplanethouse1(s2, s1);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.Visible = false;
                    GridView8.DataSource = ds.Tables[0];
                    GridView8.DataBind();
                    GridView8.Visible = true;
                }

                string lordofhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();

                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspectplanet("");
                    GridView9.DataSource = ds1.Tables[0];
                    GridView9.DataBind();
                }

                foreach (GridViewRow r in GridView8.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string aspho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView9.Rows)
                    {
                        string asphou = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string hou = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (lo == lor && ra == ras && ho == hou && aspho == asphou && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check8") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
    }
    protected void btnnext_Click(object sender, ImageClickEventArgs e)
    {
        string val = Hidden35.Value;
        if (astrocat.SelectedIndex == 2)
        {
            planet.SelectedValue = Hidden32.Value;
        }
        else
        {
            DropDownList1.SelectedValue = Hidden9.Value;
        }

        DropDownList2.SelectedValue = Hidden25.Value;
        house.SelectedValue = Hidden8.Value;
        Textdesc.Text = Hidden10.Value;
        detaildesc.Text = Hidden11.Value;
        btnfirst.Enabled = true;
        btnprevious.Enabled = true;
        string s = Hidden25.Value;
        if (astrocat.SelectedIndex == 0 || astrocat.SelectedIndex == 1)
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden8.Value;
                    string s2 = Hidden9.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.aspect1(s1, s2);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Visible = true;

                }

                string aspect = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspecthouse("");
                    GridView3.DataSource = ds1.Tables[0];
                    GridView3.DataBind();
                }
                foreach (GridViewRow r in GridView1.Rows)
                {
                    string l = r.Cells[1].Text.ToString();
                    string ra = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView3.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string housegrid = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && ra == ras && ho == housegrid && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }


            if (s == "With")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s3 = Hidden9.Value;
                    string s4 = Hidden8.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.with1(s3, s4);
                    GridView1.Visible = false;
                    GridView6.Visible = false;
                    GridView4.DataSource = ds.Tables[0];
                    GridView4.DataBind();
                    GridView4.Visible = true;
                }

                string with = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindwithhouse("");
                    GridView5.DataSource = ds1.Tables[0];
                    GridView5.DataBind();
                }

                foreach (GridViewRow r in GridView4.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string withlord = r.Cells[3].Text.ToString();
                    string ho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView5.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string withlord1 = r1.Cells[2].Text.ToString();
                        string housewith = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && withlord == withlord1 && ho == housewith && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check2") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
            if (s == "In")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s5 = Hidden9.Value;
                    string s6 = Hidden8.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.in1(s5, s6);
                    GridView4.Visible = false;
                    GridView1.Visible = false;
                    GridView6.DataSource = ds.Tables[0];
                    GridView6.DataBind();
                    GridView6.Visible = true;
                }

                string inhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();


                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.inwithhouse("");
                    GridView7.DataSource = ds1.Tables[0];
                    GridView7.DataBind();
                }

                foreach (GridViewRow r in GridView6.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string lagna = r.Cells[1].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView7.Rows)
                    {
                        string lagn = r1.Cells[0].Text.ToString();
                        string inlord1 = r1.Cells[1].Text.ToString();
                        string housein = r1.Cells[2].Text.ToString();
                        string descr = r1.Cells[3].Text.ToString();
                        if (l == inlord1 && ho == housein && desc == descr && lagna == lagn)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check3") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden8.Value;
                    string s1 = Hidden32.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.bindplanethouse1(s2, s1);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.Visible = false;
                    GridView8.DataSource = ds.Tables[0];
                    GridView8.DataBind();
                    GridView8.Visible = true;
                }
                string planethouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspectplanet("");
                    GridView9.DataSource = ds1.Tables[0];
                    GridView9.DataBind();
                }
                foreach (GridViewRow r in GridView8.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string aspho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView9.Rows)
                    {
                        string asphou = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string hou = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (lo == lor && ra == ras && ho == hou && aspho == asphou && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check8") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
    }
    protected void btnprevious_Click(object sender, ImageClickEventArgs e)
    {
        if (astrocat.SelectedIndex == 2)
        {
            planet.SelectedValue = Hidden33.Value;
        }
        else
        {
            DropDownList1.SelectedValue = Hidden13.Value;
        }
        DropDownList2.SelectedValue = Hidden26.Value;
        house.SelectedValue = Hidden12.Value;
        Textdesc.Text = Hidden14.Value;
        detaildesc.Text = Hidden15.Value;
        btnnext.Enabled = true;
        btnlast.Enabled = true;
        string s = Hidden26.Value;
        if (astrocat.SelectedIndex == 0 || astrocat.SelectedIndex == 1)
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden12.Value;
                    string s2 = Hidden13.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.aspect1(s1, s2);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                string aspect = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspecthouse("");
                    GridView3.DataSource = ds1.Tables[0];
                    GridView3.DataBind();
                }
                foreach (GridViewRow r in GridView1.Rows)
                {
                    string l = r.Cells[1].Text.ToString();
                    string ra = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView3.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string housegrid = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && ra == ras && ho == housegrid && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }

            if (s == "With")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s3 = Hidden13.Value;
                    string s4 = Hidden12.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.with1(s3, s4);
                    GridView1.Visible = false;
                    GridView6.Visible = false;
                    GridView4.DataSource = ds.Tables[0];
                    GridView4.DataBind();
                    GridView4.Visible = true;
                }

                string with = house.SelectedValue;
                DataSet ds1 = new DataSet();

                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindwithhouse("");
                    GridView5.DataSource = ds1.Tables[0];
                    GridView5.DataBind();
                }

                foreach (GridViewRow r in GridView4.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string withlord = r.Cells[3].Text.ToString();
                    string ho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView5.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string withlord1 = r1.Cells[2].Text.ToString();
                        string housewith = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && withlord == withlord1 && ho == housewith && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check2") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }


            if (s == "In")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s5 = Hidden13.Value;
                    string s6 = Hidden12.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.in1(s5, s6);
                    GridView1.Visible = false;
                    GridView4.Visible = false;
                    GridView6.DataSource = ds.Tables[0];
                    GridView6.DataBind();
                    GridView6.Visible = true;
                }

                string inhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.inwithhouse("");
                    GridView7.DataSource = ds1.Tables[0];
                    GridView7.DataBind();
                }

                foreach (GridViewRow r in GridView6.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string lagna = r.Cells[1].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView7.Rows)
                    {
                        string lagn = r1.Cells[0].Text.ToString();
                        string inlord1 = r1.Cells[1].Text.ToString();
                        string housein = r1.Cells[2].Text.ToString();
                        string descr = r1.Cells[3].Text.ToString();
                        if (l == inlord1 && ho == housein && desc == descr && lagna == lagn)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check3") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (s == "Aspects")
            {

                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden12.Value;
                    string s1 = Hidden33.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.bindplanethouse1(s2, s1);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.Visible = false;
                    GridView8.DataSource = ds.Tables[0];
                    GridView8.DataBind();
                    GridView8.Visible = true;
                }
                string planethouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspectplanet("");
                    GridView9.DataSource = ds1.Tables[0];
                    GridView9.DataBind();
                }

                foreach (GridViewRow r in GridView8.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string aspho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView9.Rows)
                    {
                        string asphou = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string hou = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (lo == lor && ra == ras && ho == hou && aspho == asphou && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check8") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
    }
    protected void btnlast_Click(object sender, ImageClickEventArgs e)
    {
        btnlast.Enabled = false;
        btnfirst.Enabled = true;
        btnprevious.Enabled = true;
        btnnext.Enabled = false;
        if (astrocat.SelectedIndex == 2)
        {
            planet.SelectedValue = Hidden34.Value;
        }
        else
        {
            DropDownList1.SelectedValue = Hidden17.Value;
        }

        DropDownList2.SelectedValue = Hidden27.Value;
        house.SelectedValue = Hidden16.Value;
        Textdesc.Text = Hidden18.Value;
        detaildesc.Text = Hidden19.Value;
        string s = Hidden27.Value;
        if (astrocat.SelectedIndex == 0 || astrocat.SelectedIndex == 1)
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden16.Value;
                    string s2 = Hidden17.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.aspect1(s1, s2);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                string aspect = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspecthouse("");
                    GridView3.DataSource = ds1.Tables[0];
                    GridView3.DataBind();
                }

                foreach (GridViewRow r in GridView1.Rows)
                {
                    string l = r.Cells[1].Text.ToString();
                    string ra = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView3.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string housegrid = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && ra == ras && ho == housegrid && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
            if (s == "With")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s3 = Hidden17.Value;
                    string s4 = Hidden16.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.with1(s3, s4);
                    GridView1.Visible = false;
                    GridView6.Visible = false;
                    GridView4.DataSource = ds.Tables[0];
                    GridView4.DataBind();
                    GridView4.Visible = true;
                }

                string with = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindwithhouse("");
                    GridView5.DataSource = ds1.Tables[0];
                    GridView5.DataBind();
                }

                foreach (GridViewRow r in GridView4.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string withlord = r.Cells[3].Text.ToString();
                    string ho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView5.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string withlord1 = r1.Cells[2].Text.ToString();
                        string housewith = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && withlord == withlord1 && ho == housewith && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check2") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }

            if (s == "In")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s5 = Hidden17.Value;
                    string s6 = Hidden16.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.in1(s5, s6);
                    GridView4.Visible = false;
                    GridView1.Visible = false;
                    GridView6.DataSource = ds.Tables[0];
                    GridView6.DataBind();
                    GridView6.Visible = true;
                }

                string inhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.inwithhouse("");
                    GridView7.DataSource = ds1.Tables[0];
                    GridView7.DataBind();
                }
                foreach (GridViewRow r in GridView6.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string lagna = r.Cells[1].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView7.Rows)
                    {
                        string lagn = r1.Cells[0].Text.ToString();
                        string inlord1 = r1.Cells[1].Text.ToString();
                        string housein = r1.Cells[2].Text.ToString();
                        string descr = r1.Cells[3].Text.ToString();
                        if (l == inlord1 && ho == housein && desc == descr && lagna == lagn)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check3") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden16.Value;
                    string s1 = Hidden34.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.bindplanethouse1(s2, s1);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.Visible = false;
                    GridView8.DataSource = ds.Tables[0];
                    GridView8.DataBind();
                    GridView8.Visible = true;
                }
                string planethouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspectplanet("");
                    GridView9.DataSource = ds1.Tables[0];
                    GridView9.DataBind();
                }
                foreach (GridViewRow r in GridView8.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string aspho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView9.Rows)
                    {
                        string asphou = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string hou = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (lo == lor && ra == ras && ho == hou && aspho == asphou && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check8") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
    }
    protected void btnfirst_Click(object sender, ImageClickEventArgs e)
    {
        btnfirst.Enabled = false;
        btnnext.Enabled = true;
        btnlast.Enabled = true;
        btnprevious.Enabled = false;
        if (astrocat.SelectedIndex == 2)
        {
            planet.SelectedValue = Hidden31.Value;
        }
        else
        {
            DropDownList1.SelectedValue = Hidden21.Value;
        }
        DropDownList2.SelectedValue = Hidden24.Value;
        house.SelectedValue = Hidden20.Value;
        Textdesc.Text = Hidden22.Value;
        detaildesc.Text = Hidden23.Value;
        string s = Hidden24.Value;
        if (astrocat.SelectedIndex == 0 || astrocat.SelectedIndex == 1)
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s1 = Hidden20.Value;
                    string s2 = Hidden21.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.aspect1(s1, s2);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                string aspect = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspecthouse("");
                    GridView3.DataSource = ds1.Tables[0];
                    GridView3.DataBind();
                }
                foreach (GridViewRow r in GridView1.Rows)
                {
                    string l = r.Cells[1].Text.ToString();
                    string ra = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView3.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string housegrid = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && ra == ras && ho == housegrid && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
            if (s == "With")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s3 = Hidden21.Value;
                    string s4 = Hidden20.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.with1(s3, s4);
                    GridView1.Visible = false;
                    GridView6.Visible = false;
                    GridView4.DataSource = ds.Tables[0];
                    GridView4.DataBind();
                    GridView4.Visible = true;
                }

                string with = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindwithhouse("");
                    GridView5.DataSource = ds1.Tables[0];
                    GridView5.DataBind();
                }

                foreach (GridViewRow r in GridView4.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string withlord = r.Cells[3].Text.ToString();
                    string ho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView5.Rows)
                    {
                        string lo = r1.Cells[1].Text.ToString();
                        string withlord1 = r1.Cells[2].Text.ToString();
                        string housewith = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (l == lo && withlord == withlord1 && ho == housewith && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check2") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
            if (s == "In")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s5 = Hidden21.Value;
                    string s6 = Hidden20.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.in1(s5, s6);
                    GridView1.Visible = false;
                    GridView4.Visible = false;
                    GridView6.DataSource = ds.Tables[0];
                    GridView6.DataBind();
                    GridView6.Visible = true;
                }

                string inhouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.inwithhouse("");
                    GridView7.DataSource = ds1.Tables[0];
                    GridView7.DataBind();
                }

                foreach (GridViewRow r in GridView6.Rows)
                {
                    string l = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string lagna = r.Cells[1].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView7.Rows)
                    {
                        string lagn = r1.Cells[0].Text.ToString();
                        string inlord1 = r1.Cells[1].Text.ToString();
                        string housein = r1.Cells[2].Text.ToString();
                        string descr = r1.Cells[3].Text.ToString();
                        if (l == inlord1 && ho == housein && desc == descr && lagna == lagn)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check3") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
        else
        {
            if (s == "Aspects")
            {
                DataSet ds = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    string s2 = Hidden20.Value;
                    string s1 = Hidden31.Value;
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds = country.bindplanethouse1(s2, s1);
                    GridView4.Visible = false;
                    GridView6.Visible = false;
                    GridView1.Visible = false;
                    GridView8.DataSource = ds.Tables[0];
                    GridView8.DataBind();
                    GridView8.Visible = true;
                }
                string planethouse = house.SelectedValue;
                DataSet ds1 = new DataSet();
                if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
                {
                    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                    ds1 = country.bindaspectplanet("");
                    GridView9.DataSource = ds1.Tables[0];
                    GridView9.DataBind();
                }
                foreach (GridViewRow r in GridView8.Rows)
                {
                    string ra = r.Cells[1].Text.ToString();
                    string lo = r.Cells[2].Text.ToString();
                    string ho = r.Cells[3].Text.ToString();
                    string aspho = r.Cells[4].Text.ToString();
                    string desc = Textdesc.Text;
                    foreach (GridViewRow r1 in GridView9.Rows)
                    {
                        string asphou = r1.Cells[0].Text.ToString();
                        string lor = r1.Cells[1].Text.ToString();
                        string ras = r1.Cells[2].Text.ToString();
                        string hou = r1.Cells[3].Text.ToString();
                        string descr = r1.Cells[4].Text.ToString();
                        if (lo == lor && ra == ras && ho == hou && aspho == asphou && desc == descr)
                        {
                            CheckBox ch = r.Cells[0].FindControl("check8") as CheckBox;
                            ch.Checked = true;
                        }
                    }
                }
            }
        }
    }

    protected void astrocat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (astrocat.SelectedIndex == 1)
        {
            DropDownList1.Visible = true;
            planet.Visible = false;
        }
        if (astrocat.SelectedIndex == 2)
        {
            planet.Visible = true;
            DropDownList1.Visible = false;

        }

        if (astrocat.SelectedIndex == 2 && DropDownList2.SelectedIndex == 3)
        {

        }
    }


  

    //[Ajax.AjaxMethod]
    //public DataSet dninechart(string planet, string house, string ldeg, string pdeg)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {

    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        //ds = country.d9chart(planet, house, ldeg, pdeg);
    //        ds = country.dninecharts(planet, house, ldeg, pdeg);
    //    }           
    //        if (ds.Tables[1].Rows.Count == 0)
    //        {
    //            DataGrid1.DataSource = ds.Tables[1];
    //            DataGrid1.DataBind();

    //        }
    //        else
    //        {
    //            //divgrid1.Attributes.Add("style", "visibility:Visible;");

    //            DataGrid1.Visible = true;
    //            DataGrid1.DataSource = ds.Tables[1];
    //            DataGrid1.DataBind();



    //        }
    //    return ds;


    //}




  
}










