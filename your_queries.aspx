<%@ Page Language="C#" AutoEventWireup="true" CodeFile="your_queries.aspx.cs" Inherits="your_queries" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager runat="Server" ID="ScriptManager1" />
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer" style="width: 50%;">
            </div>
            <div class="rightmiddlecontainer" style="width: 48%;">
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>