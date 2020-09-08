<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginadmin.aspx.cs" Inherits="loginadmin" EnableEventValidation="false" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin | Astro Envision</title>
    <meta name="robots" content="noindex,nofollow" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <script language="javascript" type="text/javascript" src="<%=ResolveUrl("~/javascript/login.js") %>"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="adminlogincontainer">
                <div class="toplogin" style="width:270px;margin:0% 5% 0% 3%;">
                    <h1 class="toplogin_h1">
                        Administrator Login</h1>
                  <%--  <h2 class="toplogin_h2">
                        <a target="_blank" href="<%=ResolveUrl("astro_dtls.aspx") %>">Register Now ?</a></h2>--%>
                </div>
                <div class="middlelogin" style="text-align:left;padding:2% 0% 5% 0%;">
                    Username:&nbsp;&nbsp;<asp:TextBox ID="txtusername1" runat="server" Text="" CssClass="logintxtbox"></asp:TextBox>
                    <br />
                    Password:&nbsp;&nbsp;<asp:TextBox ID="txtpwd1" TextMode="Password" runat="server"
                        Text="" CssClass="logintxtbox"></asp:TextBox>
                    <br />
                    <span class="toplogin_h3"><%--<a href="#">Forget Password</a> &nbsp;&nbsp;--%>
                        <asp:Button ID="btnsignin" runat="server" Text="Login" OnClick="btnsignin_Click"
                            class="loginbtncss" />
                            <%--OnClientClick="login1();--%>
                    </span>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
