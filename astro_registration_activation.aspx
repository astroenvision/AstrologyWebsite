<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_registration_activation.aspx.cs"
    Inherits="astro_registration_activation" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer" style="text-align: center;">
            <h1 class="activate_h1" id="activate_h1_id" runat="server">
            </h1>
            <h2 class="activate_h2" id="activate_h2_id" runat="server">
            </h2>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
