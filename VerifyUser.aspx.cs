using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VerifyUser : System.Web.UI.Page
{
    #region Declaration
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    subscription sub = new subscription();
    DataSet ds = new DataSet();
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["UserID"] != null)
        {
            string DecryptEmailID = Request.QueryString["UserID"].ToString().Trim();
            string EmailID = Decrypt(DecryptEmailID);
            if (EmailID!= "")
            {
                 ds = sub.UpdateCommon("","", EmailID,"","","","","","","","", "VERIFY_CLIENT_EMAILID");
                 if (ds.Tables[0].Rows.Count > 0)
                 {
                    string flag = ds.Tables[0].Rows[0]["OutResult"].ToString();
                    if (flag == "Y")
                    {
                        divThanks.Visible = true;
                        divMsg.InnerHtml = "<span style='color:green;font-weight:bold;'>Your account has been activated successfully.</span><br/><a href=\"" + ResolveUrl("~/signin.html") + "\"><b>Click Here For Login</b></a>";
                    }
                    else
                    {
                        divThanks.Visible = true;
                        divMsg.InnerHtml = "Your account has already been activated successfully.";
                    }
                  }
                else
                {
                    divThanks.Visible = false;
                    divMsg.InnerHtml = "Some error occurred in database.";
                  }
            }
            else
            {
                divThanks.Visible = false;
                divMsg.InnerHtml = "<span style='color:red;'>Account Verification has been failed!</span><br/> <b>Please mail on support@astroenvision.com </b>";
            }
        }
    }
    #endregion

    #region Decrypt
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
    #endregion
}