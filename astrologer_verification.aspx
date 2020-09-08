<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astrologer_verification.aspx.cs"
    Inherits="astrologer_verification" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email Verification | Astro Envision</title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
       <%-- <p style="color:#5f5f5f;">Your email id has been successfully verified</p>--%>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
