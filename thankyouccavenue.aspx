<%@ Page Language="C#" AutoEventWireup="true" CodeFile="thankyouccavenue.aspx.cs"
    Inherits="thankyouccavenue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ccavenue ThankYou</title>
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="thankyoumain">
                <div class="form-thankyoumain">
                    <div class="form-white-background">
                        <div class="form-title-row">
                            <h1 id="resultid" runat="server">
                                <%--Your transaction is failed.--%>
                            </h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
