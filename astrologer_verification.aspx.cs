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

public partial class astrologer_verification : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["emailid"] != null)
            {
                string VerifyEmailStatus = "T";
                ds = obj_subs.UpdateCommon("ID", "UserId", Request.QueryString["emailid"].ToString(), "UserType", "GroupId", "CartID", VerifyEmailStatus, "Value2", "Value3", "Value4", "Value5", "VERIFY_ASTROLOGER_EMAILID");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string resultval = ds.Tables[0].Rows[0]["outresult"].ToString();
                    if (resultval == "Y")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_verification), "wq", "alert('Your email id has been successfully verified.');window.location.href='index.html'", true);
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_verification), "wq", "window.parent.location.href='index.html'", true);
                    }
                }
                ds.Dispose();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_verification), "wq", "window.parent.location.href='index.html'", true);
            }
        }

    }
}
