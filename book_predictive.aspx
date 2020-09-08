<%@ Page Language="C#" AutoEventWireup="true" CodeFile="book_predictive.aspx.cs"
    Inherits="book_predictive" EnableEventValidation="false" %>

<%@ Register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx" %>
<%@ Register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book_Predictive</title>

    <script type="text/javascript" language="javascript" src="javascript/bookpredictive.js"></script>

    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>

    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
        </style>
</head>
<body id="body" onload="filter();" style="background-color: #f3f6fd; margin: 0px 0px 0px 0px">
    <form id="form1" runat="server">
    <table cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="2">
                <uc1:topbar ID="Topbar1" runat="server" Text="All Predictive"></uc1:topbar>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td style="width: 27px;">
                        </td>
                        <td style="background-image: url(image/corner-left.jpg); width: 11px; background-position: right center;
                            background-repeat: no-repeat; height: 20px;">
                        </td>
                        <td style="width: 150PX; font-family: Verdana; text-align: right; font-size: 10px;
                            background-color: #a0bfeb; height: 20px;">
                            <center>
                                <b>Book Wise Predictive</b></center>
                        </td>
                        <%-- <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:25px;"><center><b> ASTRO EXTENTIONS</b></center></td>--%>
                        <td style="background-image: url(image/corner-right.jpg); background-repeat: no-repeat;
                            height: 25px; width: 11px">
                        </td>
                        <td style="width: 770px">
                            <table cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="background-color: #a0bfeb; width: 770px; height: 3px;">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table id="outertbl" cellpadding="0" cellspacing="0" width="450px" style="border: 2px solid;
        border-color: #7DAAE3; margin-left: 100px">
        <tr>
            <td style="padding-left: 4px; padding-top: 4px; padding-bottom: 4px; padding-right: 4px;">
                <table id="innertbl" cellpadding="2" cellspacing="2" width="450px" style="border: 1px solid;
                    border-color: #7DAAE3;">
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Select Filter"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="f1" runat="server" Style="height: 16px; width: 140px">
                                <asp:ListItem Value="0">Astro Predictive</asp:ListItem>
                                <asp:ListItem Value="1">Horary Predictive</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblextentions" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="bokcate" runat="server" Style="height: 16px; width: 140px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="b1" runat="server" Style="height: 16px; width: 140px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="gh" runat="server" Text="Unique id"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="unique" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Page No"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="page111" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="s1" runat="server" Text="Search by book" />
                        </td>
                        <td>
                            <asp:Button ID="s2" runat="server" Text="search by id" />
                        </td>
                        <td>
                            <asp:Button ID="sbp" runat="server" Text="search by page" />
                        </td>
                        <td>
                            <asp:Button ID="ra" runat="server" Text="Replace All" />
                        </td>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="From date"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Texttodate" runat="server" CssClass="drpo_homenew"></asp:TextBox>
                                <img src='Image/cal1.gif' onclick="popUpCalendar(this, form1.Texttodate,'dd/mm/yyyy',event)"
                                    class="calendra_homenew" alt="" />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="To date"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="todate" runat="server" CssClass="drpo_homenew" Style="margin-left: -93px;"></asp:TextBox>
                                <img src='Image/cal1.gif' onclick="popUpCalendar(this, form1.todate,'dd/mm/yyyy',event)"
                                    class="calendra_homenew" alt="" />
                            </td>
                            <td>
                                <asp:Button ID="datesearch" runat="server" Text="Search by date" />
                            </td>
            </td>
        </tr>
        </tr>
    </table>
    </td> </tr>
    <table>
        <tr>
            <td>
                <asp:Label ID="lc" runat="server" Font-Bold="true" Style="margin-left: 300px;"></asp:Label>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td style="padding-left: 160px;">
                <table align="left" cellspacing="0" cellpadding="0" style="width: 758px">
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td style="padding-left: 20px;">
                            <table>
                                <tr>
                                    <td runat="server" id="Td1" style="width: 200px;" align="left">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <div id="replace_div" style="position: absolute; filter: alpha(Opacity=92, FinishOpacity=80, Style=0, StartX=0, FinishX=100, StartY=0, FinishY=100);
                    top: 0px; left: 0px; padding: 177px 50px; display: none; z-index: 1; border: 3px solid #a0bfeb;
                    height: 300px; width: 900px">
                </div>
            </td>
        </tr>
    </table>
    <table style="width:99%;">
        <tr>
            <td style="padding-left: 0px;">
                <table align="left" cellspacing="0" cellpadding="0" style="width: 99%;">
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td style="padding-left: 0px;">
                            <div id="Divgrid1h" style="overflow: auto; display: none; width: 100%; height: 50px;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td runat="server" id="hdsviewgridh" style="width: 99%;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="Divgrid1" style="overflow: auto; display: none; width: 100%; height: 500px;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td runat="server" id="hdsviewgrid" style="width: 99%" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <%--</table>--%>
    <input type="hidden" runat="server" id="hiddenc1" />
    <input type="hidden" runat="server" id="hiddenc2" />
    <input type="hidden" runat="server" id="hiddenc3" />
    <input type="hidden" runat="server" id="hiddendateformat" />
    </form>
</body>
</html>
