using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.IO;
using System.Text;
using System.Drawing.Text;
public partial class preview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Response.Expires = -1;
        Response.Buffer = true;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
        Response.Expires = -1500;
        Response.CacheControl = "no-cache";
        hiddenfilename.Value = Request.QueryString["f_name"].ToString();
        hiddenjobid.Value = Request.QueryString["jobid"].ToString();
        if (!Page.IsPostBack)
        {

        }

        Ajax.Utility.RegisterTypeForAjax(typeof(preview));

        //---------------------------- new added--------------------------------------//
        string serverpath = "";
        serverpath = Server.MapPath("Attachment/");
        string fname = hiddenfilename.Value;
        string finaljobpath = serverpath + hiddenjobid.Value ;
      
            Bitmap bmp1 = new Bitmap(finaljobpath + fname.Replace(".tiff", ".jpg").Replace(".eps", ".jpg").Replace(".pdf", ".jpg").Replace(".tif", ".jpg").Replace(".jpeg", ".jpg"));
            Double width;
            Double height;
            height = Math.Round(((bmp1.Height / bmp1.VerticalResolution) * 2.54), 1);
            width = Math.Round(((bmp1.Width / bmp1.HorizontalResolution) * 2.54), 1);
            System.Drawing.Image bmp2 = bmp1.GetThumbnailImage(Convert.ToInt32(bmp1.Width), Convert.ToInt32(bmp1.Height), null, IntPtr.Zero);
            string ff = finaljobpath + fname;


            //----------------------------------------------------------------------------//
            int wd = Convert.ToInt32((Convert.ToDouble(width) * 72) / 2.54);
            int ht = Convert.ToInt32((Convert.ToDouble(height) * 72) / 2.54);
            div1.InnerHtml = "<img src='image.aspx?path=" + ff + "' width=" + Convert.ToString(wd) + " height=" + Convert.ToString(ht) + "/>";
            Label1.Text = hiddenpheight.Value;
            Label2.Text = hiddenpwidth.Value;
            bmp1.Dispose();

      
    }
   


}
   