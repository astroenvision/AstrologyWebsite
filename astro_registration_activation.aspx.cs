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

public partial class astro_registration_activation : System.Web.UI.Page
{
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["UserID"] != null)
        {
            string DecryptEmailID = Request.QueryString["UserID"].ToString().Trim();
            string EmailID = Decrypt(DecryptEmailID);
            ds = objmc.Activate_registration(EmailID);
            if (ds.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string flag = ds.Tables[0].Rows[i]["active_flag"].ToString();
                    if(flag=="1")
                    {
                        activate_h1_id.InnerHtml = "Thank you! Your account has been activated successfully.";
                        activate_h2_id.InnerHtml = "<a href=\"" + ResolveUrl("login.aspx") + "\">Click Here For Login</a>";
                    }
                    else
                    {
                        activate_h1_id.InnerHtml = "Your account has already been activated successfully.";
                    }
                }
            }
        }
    }

    public string Decrypt(string Input)
    {
        Byte[] inputByteArray = new Byte[Input.Length];
        try
        {
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(Input);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }
}
