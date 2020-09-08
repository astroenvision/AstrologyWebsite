<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportExportData.aspx.cs" Inherits="admin_ImportExportData" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/headernew.ascx" TagName="header" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Import Export | Admin</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/index.css") %>" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/admincss.css") %>" />

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/admin.js") %>"></script>
</head>
<body>
        <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="maincontainer">
            <uc1:header ID="header1" runat="server" />
            <div class="middlecontainer">
                <div class="form-main" style="float: left; width: 98%; margin: 1% 0% 1% 1%;">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>Import Export Data
                                    </h1>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; text-align: left;">
                                    <asp:Button ID="btninsert" runat="server" Text="Click Here For New Mapping" CssClass="buttoncss"
                                        OnClick="btninsert_Click" />
                                    <asp:Button ID="btnupdate" runat="server" Text="Update For Exist Predictive" CssClass="buttoncss marginlft" OnClick="btnupdate_Click" />
                                </div>
                                <div class="form-row" style="float: left; width: 100%;">
                                    <label>
                                        <h4 id="lbl_result" runat="server"></h4>
                                    </label>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
