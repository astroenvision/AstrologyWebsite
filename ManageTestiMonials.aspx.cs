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
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using ASTROLOGY.classesoracle;

public partial class ManageTestiMonials : System.Web.UI.Page
{
    dailyarticle obj = new dailyarticle();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string Photo = string.Empty;
        string filename = string.Empty;
        string Sysopsis = string.Empty;
        if (fuPhoto.HasFile)
        {
           
            string fileExtension = System.IO.Path.GetExtension(fuPhoto.FileName).ToString().ToLower();
            if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
            {
                string folderPath = Server.MapPath("~/Image/");
                //if (!Directory.Exists(folderPath))
                //{
                //    Directory.CreateDirectory(folderPath);
                //}
                string ImageName = fuPhoto.FileName.Replace(" ", "-");
                 filename = Guid.NewGuid() + Path.GetFileName(ImageName);
                string path = folderPath + filename;
                fuPhoto.SaveAs(path);
                Photo = folderPath + filename;
             }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(ManageTestiMonials), "wq", "alert('Select only .jpg ,.jpeg and .png files');", true);
                return;
            }
        }
        if(txtTestimonials.Text.Length > 300)
         {
             Sysopsis = txtTestimonials.Text.ToString().Substring(0, 300);
         }
        else
        {
            Sysopsis = txtTestimonials.Text.ToString();
        }
        
        ds = obj.Save_Article("BOTH", "4", "", Sysopsis.ToString(), txtTestimonials.Text.Trim(), txtName.Text.Trim(), filename, "", "", "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Message == "1")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(ManageTestiMonials), "wq", "alert('Your Experience Saved Successfully !');", true);
                txtName.Text = "";
                txtTestimonials.Text = "";
                fuPhoto.Dispose();
                imgauthor.Attributes.Add("style", "display:none;");
                return;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(ManageTestiMonials), "wq", "alert('Record Saved Failed !');", true);
                return;
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(ManageTestiMonials), "wq", "alert('Data Saved failed !');", true);
            return;
        }

    }

    public string UploadImage(string fileName, string folderName, HtmlInputFile file_posted)
    {
        if (fileName == "")
        {
            return "File name is invalid.";
        }

        fileName = System.IO.Path.GetFileName(fileName);
        if (folderName == "")
        {
            return "Path not found.";
        }
        string strBaseLocation = HttpContext.Current.Server.MapPath(folderName);

        //file_soft.PostedFile.SaveAs(Server.MapPath(folderName) + "\\" + fileName);

        if (null != file_posted.PostedFile)
        {
            //string fileName = GetFileName( file_soft.Value );
            string fileTarget = strBaseLocation + "\\" + fileName;
            try
            {
                //read/write buffer
                const int BUFFER_SIZE = 255;
                Byte[] Buffer = new Byte[BUFFER_SIZE];
                //lblerror.Text = "Uploading File: " + fileName;

                //incoming external file stream
                //Stream theStream = thumbimgfile.PostedFile.InputStream;
                Stream theStream = file_posted.PostedFile.InputStream;


                //local file stream
                FileStream fs = new FileStream(fileTarget, FileMode.CreateNew, FileAccess.Write);
                fs.Flush();
                //local binary writer on local file stream
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Flush();

                // read/write loop
                while (theStream.Read(Buffer, 0, BUFFER_SIZE) != 0)
                {
                    bw.Write(Buffer, 0, BUFFER_SIZE);
                }

                //Close the streams
                bw.Close();
                fs.Close();
                theStream.Close();

                fs.Dispose();
                theStream.Dispose();
                //lblerror.Text = "Upload finished.";

                //reload directory listing
                //FindAndDisplayFiles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        return fileName;
    }

}