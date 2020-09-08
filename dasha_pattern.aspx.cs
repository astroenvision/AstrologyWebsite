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

public partial class dasha_pattern : System.Web.UI.Page
{
    string usermail = "";
    string username1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(dasha_pattern));

        hdnidob.Value = Request.QueryString["dob"];
        hdnimoob.Value = Request.QueryString["mob"];
        hdniyob.Value = Request.QueryString["yob"];

        hdnihob.Value = Request.QueryString["htob"];
        hdnimob.Value = Request.QueryString["mtob"];
        

        hdnmdegree.Value = Request.QueryString["mdegree"];
        hdnmminute.Value = Request.QueryString["mminute"];
        hdnmsecond.Value = Request.QueryString["msecond"];
        hdnmrashi.Value = Request.QueryString["mrashi"];

        hdnusermail.Value = Request.QueryString["usermail"];
        
        if (!Page.IsPostBack)
        {
            yamyabut_Click();
           // grp_cat.Attributes.Add("Onchange", "javascript:return group_bind();");
          
            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"]);

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {


            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {

                horarydiv.Attributes.Add("style", "display:none;");
                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                // a2.Attributes.Add("style", "display:none;");
                nataldiv.Attributes.Add("style", "display:none;");
                //a2l.Attributes.Add("style", "display:none;");
                //a3l.Attributes.Add("style", "display:none;");
                //a4l.Attributes.Add("style", "display:none;");
                //a5l.Attributes.Add("style", "display:none;");
                //a6l.Attributes.Add("style", "display:none;");

                // d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");


            }
        }
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(dasha_pattern), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }



        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(dasha_pattern), "wq", "window.parent.location.href='login.aspx';", true);
            //   Response.Redirect("login.aspx");
            return;

        }
        else
        {
            var astrologer = Session["usermail"].ToString();
            Hidden9.Value = astrologer;

        }
    }

    public void yamyabut_Click()
    {
        img1.Visible = true; 
    RadioButton1.Checked = true;
    RadioButton2.Checked = false;
    RadioButton3.Checked = false;
    RadioButton4.Checked = false;
    int mdegree =int.Parse(hdnmdegree.Value);
    int mminute =int.Parse(hdnmminute.Value);
    int msecond = int.Parse(hdnmsecond.Value);
    string mrashi = hdnmrashi.Value;
    int htob = int.Parse(hdnihob.Value);
    int mtob = int.Parse(hdnimob.Value);
    int stob = int.Parse("0");
    int dob = int.Parse(hdnidob.Value);
    int mob = int.Parse(hdnimoob.Value);
    int yob = int.Parse(hdniyob.Value);
    string astrologer = hdnusermail.Value;

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
                ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer, RadioButton1.Text);
            }
                 bod.Text = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();

          
           GridView1.DataSource = ds.Tables[1];
           GridView1.DataBind();
           img1.Visible = false; 
           return;
    }



    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowIndex == 0)
                e.Row.Style.Add("height", "50px");
        }
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        img1.Visible = true; 
        //img1.Attributes.Add("style", "visibility:visible;");
        RadioButton2.Checked = true;
        
        RadioButton1.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;

        int mdegree = int.Parse(hdnmdegree.Value);
        int mminute = int.Parse(hdnmminute.Value);
        int msecond = int.Parse(hdnmsecond.Value);
        string mrashi = hdnmrashi.Value;
        int htob = int.Parse(hdnihob.Value);
        int mtob = int.Parse(hdnimob.Value);
        int stob = int.Parse("0");
        int dob = int.Parse(hdnidob.Value);
        int mob = int.Parse(hdnimoob.Value);
        int yob = int.Parse(hdniyob.Value);
        string astrologer = hdnusermail.Value;

        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer, RadioButton2.Text);

        }
        bod.Text = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();


        img1.Attributes.Add("style", "visibility:hidden;");
        GridView1.DataSource = ds.Tables[1];
        GridView1.DataBind();
        img1.Visible = false; 
        return;
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        img1.Visible = true; 
        RadioButton1.Checked = true;

        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;

        int mdegree = int.Parse(hdnmdegree.Value);
        int mminute = int.Parse(hdnmminute.Value);
        int msecond = int.Parse(hdnmsecond.Value);
        string mrashi = hdnmrashi.Value;
        int htob = int.Parse(hdnihob.Value);
        int mtob = int.Parse(hdnimob.Value);
        int stob = int.Parse("0");
        int dob = int.Parse(hdnidob.Value);
        int mob = int.Parse(hdnimoob.Value);
        int yob = int.Parse(hdniyob.Value);
        string astrologer = hdnusermail.Value;

        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer, RadioButton1.Text);

        }
        bod.Text = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();


        GridView1.DataSource = ds.Tables[1];
        GridView1.DataBind();
        img1.Visible = false; 
        return;
        
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        img1.Visible = true; 
        RadioButton3.Checked = true;

        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton4.Checked = false;

        int mdegree = int.Parse(hdnmdegree.Value);
        int mminute = int.Parse(hdnmminute.Value);
        int msecond = int.Parse(hdnmsecond.Value);
        string mrashi = hdnmrashi.Value;
        int htob = int.Parse(hdnihob.Value);
        int mtob = int.Parse(hdnimob.Value);
        int stob = int.Parse("0");
        int dob = int.Parse(hdnidob.Value);
        int mob = int.Parse(hdnimoob.Value);
        int yob = int.Parse(hdniyob.Value);
        string astrologer = hdnusermail.Value;

        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer, RadioButton3.Text);
        }
        bod.Text = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();

        GridView1.DataSource = ds.Tables[1];
        GridView1.DataBind();
        img1.Visible = false; 
        return;
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        img1.Visible = true; 
        RadioButton4.Checked = true;

        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;

        int mdegree = int.Parse(hdnmdegree.Value);
        int mminute = int.Parse(hdnmminute.Value);
        int msecond = int.Parse(hdnmsecond.Value);
        string mrashi = hdnmrashi.Value;
        int htob = int.Parse(hdnihob.Value);
        int mtob = int.Parse(hdnimob.Value);
        int stob = int.Parse("0");
        int dob = int.Parse(hdnidob.Value);
        int mob = int.Parse(hdnimoob.Value);
        int yob = int.Parse(hdniyob.Value);
        string astrologer = hdnusermail.Value;

        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer, RadioButton4.Text);

        }
        bod.Text = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();


        GridView1.DataSource = ds.Tables[1];
        GridView1.DataBind();
        img1.Visible = false; 
        return;
    }
}
