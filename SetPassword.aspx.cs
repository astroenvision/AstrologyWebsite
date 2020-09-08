using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetPassword : System.Web.UI.Page
{
    #region Declaration
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #endregion

    #region Change Password
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {

        if (Request.QueryString["UserID"] != null)
        {
            string DecryptEmailID = Request.QueryString["UserID"].ToString().Trim();
            string EmailID = Decrypt(DecryptEmailID);
            if (EmailID != "")
            {
                DataSet ds = new DataSet();
                if (txtNewpwd.Text == txtConfrimPwd.Text)
                {
                    ds = obj_subs.ChangeUserPassword("CHANGE_USER_PASSWORD_BY_EMAIL", EmailID, "", txtNewpwd.Text.Trim());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Status"].ToString() == "1")
                        {
                            HttpContext.Current.Session["UserID"] = null;
                            HttpContext.Current.Session["UserEmailID"] = null;
                            HttpContext.Current.Session["UserName"] = null;

                            string msg = "Your password has been updated successfully !";
                            var page = HttpContext.Current.CurrentHandler as Page;
                            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + msg + "');window.location ='" + "index.html" + "';", true);
                            return;
                        }
                    
                    }
                    else
                    {
                        txtNewpwd.Text = "";
                        txtConfrimPwd.Text = "";
                        ScriptManager.RegisterClientScriptBlock(this, typeof(ChangePassword), "wq", "alert('Warning! Some Error Occurred!');", true);
                        return;
                    }
                }
                else
                {
                    txtNewpwd.Text = "";
                    txtConfrimPwd.Text = "";
                    ScriptManager.RegisterClientScriptBlock(this, typeof(ChangePassword), "wq", "alert('Password and confirm password does not match!');", true);
                    return;
                }
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