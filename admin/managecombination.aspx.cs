using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_managecombination : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    Houseposition house_obj = new Houseposition();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    BindDropDown();
                    h3headertest.InnerText = "Add Combination";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            UserID = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                        }
                        else
                        {
                            UserID = Request.QueryString["q"].ToString();
                        }

                        h3headertest.InnerText = "Update Combination";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
            }
        }
        else
        {
            if (Session["AdminUserId"] != null)
            {
                AdminUserId = Session["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    BindDropDown();
                    h3headertest.InnerText = "Add Combination";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            UserID = Session["AdminUserId"].ToString();
                        }
                        else
                        {
                            UserID = Request.QueryString["q"].ToString();
                        }

                        h3headertest.InnerText = "Update Combination";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }
    #endregion

    #region Bind DropDown
    protected void BindDropDown()
    {
        DataSet ds = new DataSet();
        ds = house_obj.ast_chart("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlChart.Items.Clear();
            ddlChart.DataSource = ds.Tables[0];
            ddlChart.DataTextField = "CHART_NO";
            ddlChart.DataValueField = "CHART_NO";
            ddlChart.DataBind();
            ddlChart.Items.Insert(0, new ListItem("Select Chart", "-1"));
            ds.Dispose();
        }

        ds = house_obj.ast_house("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlHouse.Items.Clear();
            ddlHouse.DataSource = ds.Tables[0];
            ddlHouse.DataTextField = "Name";
            ddlHouse.DataValueField = "Code";
            ddlHouse.DataBind();
            ddlHouse.Items.Insert(0, new ListItem("Select House", "-1"));

            ddlMovedHouse.Items.Clear();
            ddlMovedHouse.DataSource = ds.Tables[0];
            ddlMovedHouse.DataTextField = "Name";
            ddlMovedHouse.DataValueField = "Code";
            ddlMovedHouse.DataBind();
            ddlMovedHouse.Items.Insert(0, new ListItem("Select House", "-1"));
            ds.Dispose();
        }

        ds = house_obj.ast_planet("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlPlanet.Items.Clear();
            ddlPlanet.DataSource = ds.Tables[0];
            ddlPlanet.DataTextField = "Name";
            ddlPlanet.DataValueField = "Code";
            ddlPlanet.DataBind();
            ddlPlanet.Items.Insert(0, new ListItem("Select Planet", "-1"));

            ddlMovedPlanet.Items.Clear();
            ddlMovedPlanet.DataSource = ds.Tables[0];
            ddlMovedPlanet.DataTextField = "Name";
            ddlMovedPlanet.DataValueField = "Code";
            ddlMovedPlanet.DataBind();
            ddlMovedPlanet.Items.Insert(0, new ListItem("Select Planet", "-1"));

            ds.Dispose();
        }

        ds = house_obj.ast_rashi("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlRashi.Items.Clear();
            ddlRashi.DataSource = ds.Tables[0];
            ddlRashi.DataTextField = "Name";
            ddlRashi.DataValueField = "Code";
            ddlRashi.DataBind();
            ddlRashi.Items.Insert(0, new ListItem("Select Rashi", "-1"));

            ddlMovedRashi.Items.Clear();
            ddlMovedRashi.DataSource = ds.Tables[0];
            ddlMovedRashi.DataTextField = "Name";
            ddlMovedRashi.DataValueField = "Code";
            ddlMovedRashi.DataBind();
            ddlMovedRashi.Items.Insert(0, new ListItem("Select Rashi", "-1"));
            ds.Dispose();
        }

        ds = house_obj.AST_lord_bind("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlLord.Items.Clear();
            ddlLord.DataSource = ds.Tables[0];
            ddlLord.DataTextField = "LORD";
            ddlLord.DataValueField = "LORD";
            ddlLord.DataBind();
            ddlLord.Items.Insert(0, new ListItem("Select Lord", "-1"));
            ds.Dispose();
        }


        ds = house_obj.ast_constellation("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlConstsllation.Items.Clear();
            ddlConstsllation.DataSource = ds.Tables[0];
            ddlConstsllation.DataTextField = "Name";
            ddlConstsllation.DataValueField = "Code";
            ddlConstsllation.DataBind();
            ddlConstsllation.Items.Insert(0, new ListItem("Select Constsllation", "-1"));

            ddlMovedConstsllation.Items.Clear();
            ddlMovedConstsllation.DataSource = ds.Tables[0];
            ddlMovedConstsllation.DataTextField = "Name";
            ddlMovedConstsllation.DataValueField = "Code";
            ddlMovedConstsllation.DataBind();
            ddlMovedConstsllation.Items.Insert(0, new ListItem("Select Constsllation", "-1"));
            ds.Dispose();
        }

        ds = house_obj.ast_constellation("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlConstsllation.Items.Clear();
            ddlConstsllation.DataSource = ds.Tables[0];
            ddlConstsllation.DataTextField = "Name";
            ddlConstsllation.DataValueField = "Code";
            ddlConstsllation.DataBind();
            ddlConstsllation.Items.Insert(0, new ListItem("Select Constsllation", "-1"));
            ds.Dispose();
        }



    }
    #endregion

    #region Load Data 
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.GetCombination("GET_DETAILS", ID,"","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlChart.SelectedValue = ds.Tables[0].Rows[0]["CHART_NO"].ToString();
            ddlHouse.SelectedValue = ds.Tables[0].Rows[0]["HOUSE"].ToString();
            ddlPlanet.SelectedValue = ds.Tables[0].Rows[0]["PLANET"].ToString().ToUpper();
            ddlRashi.SelectedValue = ds.Tables[0].Rows[0]["RASHI"].ToString();
            ddlLord.SelectedValue = ds.Tables[0].Rows[0]["LORD"].ToString();
            ddlConstsllation.SelectedValue = ds.Tables[0].Rows[0]["CONSTELLATION"].ToString();
            txtDegreeFrom.Text = ds.Tables[0].Rows[0]["DEGREE_FROM"].ToString();
            txtDegreeTo.Text = ds.Tables[0].Rows[0]["DEGREE_TO"].ToString();
            ddlMovedConstsllation.SelectedValue = ds.Tables[0].Rows[0]["MOVE_TO_CONSTELLATION"].ToString();
            ddlMovedHouse.SelectedValue = ds.Tables[0].Rows[0]["MOVE_TO_HOUSE"].ToString();
            ddlMovedPlanet.SelectedValue = ds.Tables[0].Rows[0]["MOVE_TO_PLANET"].ToString().ToUpper();
            ddlMovedRashi.SelectedValue = ds.Tables[0].Rows[0]["MOVE_TO_RASHI"].ToString();
            txtCombination.Text = ds.Tables[0].Rows[0]["COMBINATION"].ToString();
            txtLogicDesc.Text = ds.Tables[0].Rows[0]["LOGIC_DESC"].ToString();
            txtLogic.Text = ds.Tables[0].Rows[0]["LOGIC"].ToString();
            lblID.Text = ds.Tables[0].Rows[0]["LOGIC_ID"].ToString();
            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
        }

    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string Status = "U";
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }
        
        string Flag = "INSERT";
        if (lblID.Text != "")
        {
            Flag = "UPDATE";
        }
        else
        {
            lblID.Text = "";
        }
        DataSet ds = new DataSet();
        ds = obj.SaveCombinatiom(Flag , lblID.Text , txtLogicDesc.Text , txtLogic.Text , txtCombination.Text , 
            ddlRashi.SelectedValue , ddlLord.SelectedValue , ddlPlanet.SelectedValue , ddlHouse.SelectedValue , ddlConstsllation.SelectedValue , txtDegreeFrom.Text , 
            txtDegreeTo.Text , ddlMovedRashi.SelectedValue , "", ddlMovedPlanet.SelectedValue , ddlMovedHouse.SelectedValue, ddlMovedConstsllation.SelectedValue , "","","","","",ddlChart.SelectedValue , "",AdminUserId , "", Status, "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_managecombination), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Flag != "UPDATE")
            {
                common.ClearAllControls(Page.Controls);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_managecombination), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}