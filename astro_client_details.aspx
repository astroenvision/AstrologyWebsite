<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_client_details.aspx.cs"
    Inherits="astro_client_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <script type="text/javascript">
        function PrintDiv() {
             var divToPrint = document.getElementById('dvContents');
                var popupWin = window.open('', '_blank', 'width=1000,height=1000,location=no,left=200px');
                popupWin.document.open();
                popupWin.document.write('<html><body style="border:2px dotted black;text-align:center;line-height:0.50em;" onload="window.print()"><h2 style="padding:0.8em 0em 0.5em 0em;margin:0em 0em 0em 0em;color:#F4600A;">ASTRO ENVISION</h2>' + divToPrint.innerHTML + '<h3 style="padding:0.5em 0.2em 0.5em 0em;margin:0em 0em 0em 0em;color:#F4600A; text-align:right;">www.astroenvision.com</h3></html>');
                popupWin.document.close();
        }
    </script>
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="fullarticle_catname">
                <h1 class="fullarticle_catname_h1">
                    Client Details</h1>
            </div>
            <fieldset id="dvContents" class="registrationmain">
                <table cellspacing="5" cellpadding="5" class="registrationtable">
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Client Name:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtname" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Gender:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtsex" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" id="dobid" runat="server" style="width: 220px; float: left;">
                            D.O.B / D.O.Q:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtdob_doq" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" id="tobid" runat="server" style="width: 220px; float: left;">
                            T.O.B / T.O.Q:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txttob_toq" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" id="pobid" runat="server" style="width: 220px; float: left;">
                            P.O.B / P.O.Q:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtpob_poq" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" id="daybirthid" runat="server" style="width: 220px; float: left;">
                            Day of Birth / Day of Query:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtdayob" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Country:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtcountry" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            State:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtstate" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Email Id :
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtemailid" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Latitude:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtlatitude" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Longitude:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtlongitude" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Time Zone:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txttimezone" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Constellation:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtconstellation" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Rashi:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtrashi" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Balance Dasha of Birth Time:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtbalancedasha" runat="server" Width="330px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Sunrise Time:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtsunrise" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Sunset Time:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtsunset" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Next Day Sunrise Time:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtsunrisenext" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Day Duration / Dinmaan:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtdinmaan" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Night Duration / Ratrimaan:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtratrimaan" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="display: none;">
                        <td class="td_first" style="width: 220px; float: left;">
                            Hora at the time of Birth:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txthoraname" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Client's Contact Number:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtcontactno" runat="server" Width="250px" ReadOnly="true" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Astrologer's Name:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtastrologername" runat="server" Width="250px" ReadOnly="true"
                                CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Astrologer's Mobile No:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtastrologermobile" runat="server" Width="250px" ReadOnly="true"
                                CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                            Astrologer's Email Id:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtastrologeremail" runat="server" Width="250px" ReadOnly="true"
                                CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first" style="width: 220px; float: left;">
                        </td>
                        <td class="td_second">
                        </td>
                    </tr>
                </table>
            </fieldset>
            <div style="float:left; width:100%; text-align:center; margin:0% 0% 1% 0%; padding:0em;">
            <asp:Button ID="btnPrint" runat="server" Text="Print" CssClass="loginbtncss" OnClientClick="return PrintDiv();" />
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
