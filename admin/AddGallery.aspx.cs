using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddGallery : System.Web.UI.Page
{
    #region Declarations
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
            h3headertest.InnerText = "Add Gallery";
            btnSubmit.Text = "Save";
            if (Request.QueryString["q"] != null)
            {
                string ID = Request.QueryString["q"].ToString();
                h3headertest.InnerText = "Update Gallery";
                btnSubmit.Text = "Update";
                //LoadData(ID);
            }
           }
        }
    #endregion

    #region Group Select Change Event
    protected void ddlGroup_SelectChange(object sender, EventArgs e)
    {
        ddlCatName.Items.Clear();
        DataSet ds = new DataSet();
        //if(ddlGroup.SelectedValue == "-1")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Firstly Select Group Name!');", true);
        //    return;
        //}
        ds = obj.ManageAlbumCategory("GET_CAT_NAME", ddlGroup.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCatName.DataSource = ds.Tables[0];
            ddlCatName.DataValueField = "CAT_ID";
            ddlCatName.DataTextField = "CATEGORY_NAME";
            ddlCatName.DataBind();
            ddlCatName.Items.Insert(0, new ListItem("Select Category", "-1"));
        }
        ds.Dispose();
    }
    #endregion

    #region Category Select Change Event
    protected void ddlCatName_SelectChange(object sender , EventArgs e)
    {
        ddlAlbum.Items.Clear();
        DataSet ds = new DataSet();
        //if(ddlGroup.SelectedValue == "-1")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Firstly Select Group Name!');", true);
        //    return;
        //}
        ds = obj.ManageAlbum("GET_ALBUM_NAME", ddlCatName.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlAlbum.DataSource = ds.Tables[0];
            ddlAlbum.DataValueField = "ALBUM_ID";
            ddlAlbum.DataTextField = "ALBUM_NAME";
            ddlAlbum.DataBind();
            ddlAlbum.Items.Insert(0, new ListItem("Select Album", "-1"));
        }
        ds.Dispose();
    }
    #endregion

    #region Submit Click 
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        if (FileUserPhoto.HasFiles)
        {
            int i = 0;
            foreach (HttpPostedFile uploadedFile in FileUserPhoto.PostedFiles)
            {   i++;
                string fileType = string.Empty;
                string filePath = string.Empty;
                string imgName = uploadedFile.FileName;
                string extension = System.IO.Path.GetExtension(uploadedFile.FileName);
                Random randomNo = new Random();
                string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
                string ImageName = yyyy_sys + "_" + mm_sys + "_" + ddlAlbum.SelectedItem.Text.Replace(" ", "_") + "_" + randomNo.Next() + extension;
                filePath =  yyyy_sys + "/" + mm_sys + "/" + ImageName;
                string path = folderPath.Replace("\\admin", "") + ImageName;
                uploadedFile.SaveAs(path);
                ds = obj.AddGallery("INSERT_GALLERY", "", ddlAlbum.SelectedItem.Text, ddlAlbum.SelectedValue , filePath , i.ToString(), ddlGroup.SelectedValue ,"");
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
                if (STATUS != "N")
                {
                    string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddGallery), "wq", "alert(' " + Message + "');", true);
                   common.ClearAllControls(Page.Controls);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddGallery), "wq", "alert('Some Error Occured');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddGallery), "wq", "alert('Some Error Occured');", true);
                return;
            }

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddGallery), "wq", "alert('Please Select Gallery Image!');", true);
            return;
        }
    }
    #endregion

}

