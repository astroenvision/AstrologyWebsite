<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enduser_queries.aspx.cs"
    Inherits="enduser_queries" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
    <link type="text/css" rel="stylesheet" href="CSS/thankyou.css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager runat="Server" ID="ScriptManager1" />
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="maincontent_box_container">
                <div class="maincontent_box">
                    <div class="maincontent_box_background">
                        <span class="rpthead">
                            <h1>
                                End User's Questions</h1>
                        </span>
                        <div class="outputdetails" id="outputdetailsid" runat="server">
                        </div>
                        <br />
                        <br />
                        <hr />
                        <FCKeditorV2:FCKeditor ID="rtedetails" runat="server" BasePath="~/fckeditor/" Width="700px"
                            Height="500px">
                        </FCKeditorV2:FCKeditor>
                        <br />
                        <hr />
                        <asp:Button ID="sendtouser" class="nextbtncss" runat="server" Text="Send To User"
                            OnClick="sendtouser_Click" />
                        <br />
                        <br />
                        <br />
                        <br />
                        <hr />
                        <span class="rpthead">
                            <h1>
                                Sent Mail To End User</h1>
                        </span>
                        <FCKeditorV2:FCKeditor ID="rtesentnaswer" runat="server" BasePath="~/fckeditor/"
                            Width="700px" Height="500px">
                        </FCKeditorV2:FCKeditor>
                    </div>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
