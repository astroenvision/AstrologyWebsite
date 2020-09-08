<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx" %>
<%@ Register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbanr.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Astro Envision | Admin</title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1" />
    <meta name="CODE_LANGUAGE" content="C#" />
    <meta name="vs_defaultClientScript" content="JavaScript" />
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5" />
    <script language="javascript" type="text/javascript" src="javascript/tree.js"></script>
    <script language="javascript" type="text/javascript" src="javascript/TreeLibrary.js"></script>
    <style type="text/css">
        .style1
        {
            FONT-WEIGHT: bold;
            COLOR: #ffffff;
            FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif;
        }

        .style2
        {
            COLOR: #ffffff;
        }
    </style>
    <link href="css/main.css" type="text/css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <script language="javascript" type="text/javascript" src="javascript/TreeLibrary.js"></script>
    <script language="javascript" type="text/javascript" src="javascript/tree.js"></script>
    <%--<script language="javascript" type="text/javascript" src="javascript/deletion.js"></script>--%>
</head>
<body style="margin-left: 0px; margin-top: 0px;" onload="return chkadmin();">
    <form id="Form1" method="post" runat="server">
        <table id="OuterTable" width="100%" align="center" border="0" cellpadding="0"
            cellspacing="0">
            <tr valign="top">
                <td colspan="2">
                    <uc1:topbar ID="Topbar1" runat="server" Text="Enter Page"></uc1:topbar>
                </td>
            </tr>
            <tr valign="top">
                <td valign="top">
                    <uc2:Leftbar ID="Leftbar1" runat="server" OnLoad="Leftbar1_Load"></uc2:Leftbar>
                </td>
                <td valign="top" align="left">
                    <iframe style="BACKGROUND-COLOR: white;" id="detail" frameborder="0" width="780" height="400"></iframe>
                </td>
            </tr>
        </table>
        <input id="hiddencompcode" runat="server" type="hidden" name="hiddencompcode" />
        <input id="hiddenuserid" runat="server" type="hidden" name="hiddenuserid" />
        <input id="hiddenusername" runat="server" type="hidden" name="username" />
        <input id="hiddencompuser" runat="server" type="hidden" name="username2" />
        <input id="hiddenadmin" runat="server" type="hidden" name="username1" />
        <input id="hiddencompname" runat="server" type="hidden" name="username1" />


        <ul class="soc">
            <li><a class="soc-twitter" href="#"></a></li>
            <li><a class="soc-facebook" href="#"></a></li>
            <li><a class="soc-google" href="#"></a></li>
            <li><a class="soc-linkedin" href="#"></a></li>
            <li><a class="soc-youtube soc-icon-last" href="#"></a></li>
        </ul>
    </form>
</body>
</html>
