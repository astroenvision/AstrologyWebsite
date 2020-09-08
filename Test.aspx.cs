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
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NReco.PdfGenerator;
using System.Drawing;

public partial class Test : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    string clientname = "";//"Akshay@gmail.com";
    string ClientId = "";//"1";
    string ChartNo = "D01",Varga="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindVargas(ChartNo);
        }
    }

    #region Bind Vargas
    protected void BindVargas(string ChartNo)
    {
        if (Request.QueryString["userid"] != null && Request.QueryString["userid"] != null)
        {
            clientname = Request.QueryString["useremailid"].ToString().Trim();
            ClientId = Request.QueryString["userid"].ToString().Trim();
            DataSet dsvargas = new DataSet();
            dsvargas = obj_main.GetVargas(ClientId, ChartNo, "DashaVarga");
            if (dsvargas.Tables[0].Rows.Count > 0)
            {
                grdData.DataSource = dsvargas.Tables[0];
                grdData.DataBind();
            }
            dsvargas.Dispose();
        }
    }
    #endregion

    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindVargas(ddlChart.SelectedValue.Trim());
    }

    protected void ddlChart_SelectChange(object sender, EventArgs e)
    {
        if (ddlChart.SelectedValue != "")
        {
            ChartNo = ddlChart.SelectedValue.Trim();
            BindVargas(ChartNo);
        }
    }

    protected void ddlvarga_SelectChange(object sender, EventArgs e)
    {
        if (ddlvarga.SelectedValue != "")
        {
            Varga = ddlvarga.SelectedValue.Trim();

            DataSet dsvargaschart = new DataSet();
            dsvargaschart = obj_main.AstGetCommon(Varga, "", "", "GET_VARGAS_CHARTS");
            if (dsvargaschart.Tables[0].Rows.Count > 0)
            {
                ddlChart.Items.Clear();
                ddlChart.DataSource = dsvargaschart.Tables[0];
                ddlChart.DataValueField = "CHART_NO";
                ddlChart.DataTextField = "CHART_NO";
                ddlChart.DataBind();
                ddlChart.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select Chart", ""));
            }
            dsvargaschart.Dispose();
        }
    }

}