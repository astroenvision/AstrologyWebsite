using ASTROLOGY.classesoracle;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;

public partial class admin_NewsLetterSend : System.Web.UI.Page
{
    #region Description
    admin obj = new admin();
    common common = new common();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    public int dd_sys, mm_sys, yyyy_sys;
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        string system_date = System.DateTime.Now.ToString();
        String[] split_date = system_date.Split('/');
        string mm = split_date[0];
        string dd = split_date[1];
        string yyyy = split_date[2];
        string final_date = dd + "/" + mm + "/" + yyyy.Substring(0, 4);

        dd_sys = Convert.ToInt32(dd);
        mm_sys = Convert.ToInt32(mm);
        yyyy_sys = Convert.ToInt32(yyyy.Substring(0, 4));
        if (!IsPostBack)
        {
            obj_main.check_year_folder(yyyy_sys, mm_sys);
        }

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    
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
                if (!Page.IsPostBack)
                {
                    
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

    #region Submit Click
    protected void btnSubmit_Click(object sender , EventArgs e)
    {
        string ModifyBy = "";
        string Status = "I";
        if (fckHeadline.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_NewsLetterSend), "wq", "alert('Please Enter Headline!');", true);
            return;
        }
        if (fckDescription.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_NewsLetterSend), "wq", "alert('Please Enter Description!');", true);
            return;
        }
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }
        string flag = "INSERT_NEWSLETTER";
        if (Session["UserID"] != null)
        {
            ModifyBy = Session["UserID"].ToString();
        }
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUserPhoto.HasFiles)
        {
            string imgName = FileUserPhoto.FileName;
            string extension = System.IO.Path.GetExtension(FileUserPhoto.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = "NEWSLETTER_" + imgName.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileUserPhoto.SaveAs(path);
        }
        else
        {
            filePath = hdnImage.Value;
        }
        DataSet ds = new DataSet();
        ds = obj.SaveNewsLetter(flag,"", txtSubject.Text , fckHeadline.Value , fckDescription.Value , filePath , ModifyBy , "NATAL" , Status);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if(STATUS =="1")
            {
                string result = "FAILED", Message = ""; ;
                result = common.SendMail("noreply@astroenvision.com", "chaudharypriyanshi12@gmail.com", "", "", txtSubject.Text, fckHeadline.Value + "<br/>" + fckDescription.Value);
                if (result == "SENT")  //FAILED  // SENT
                {
                    Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                    Message = Message + " And News Letter Sent successfully";
                }
                else
                {
                    Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                    Message = Message + " And News Letter Sent Failed";
                }
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_NewsLetterSend), "wq", "alert(' " + Message + "');", true);
                common.ClearAllControls(Page.Controls);
                fckDescription.Value = "";
                fckHeadline.Value = "";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_NewsLetterSend), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_NewsLetterSend), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}