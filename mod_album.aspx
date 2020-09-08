<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mod_album.aspx.cs" Inherits="mod_album" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>Modify Albums</title>
        <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />
</head>
<body style="margin: 0px auto; width: 1000px;">
    <form id="form1" runat="server">
    <ajaxToolkit:ToolkitScriptManager runat="Server" CombineScripts="false" EnablePartialRendering="true" EnablePageMethods="true"
            ID="ScriptManager1" />
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <fieldset class="registrationmain" style="margin: 0em; width: 100%;">
                <table cellspacing="5" cellpadding="5" class="registrationtable">
                    <tr>
                        <td class="td_first">
                            User:<font class="star"> *</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddluser" runat="server" AutoPostBack="true" Width="200px" CssClass="registrationdropdown">
                                        <asp:ListItem Value="0" Text="--Select User--"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="ASTROLOGER"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="END USER"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="BOTH"></asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Group:<font class="star"> *</font>
                        </td>
                        <td class="td_second">
                            <asp:DropDownList ID="ddlgroup" runat="server" AutoPostBack="true" Width="200px"
                                CssClass="registrationdropdown">
                                <asp:ListItem Value="0" Text="--Select Group--"></asp:ListItem>
                                <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Headline:<font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtheadline" runat="server" Width="90%" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Synopsis:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtsynopsis" TextMode="MultiLine" Height="70px" runat="server" Width="90%"
                                CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Author:
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtauthor" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Status:
                        </td>
                        <td class="td_second">
                            <asp:DropDownList ID="ddlstatus" runat="server" AutoPostBack="true" Width="100px"
                                CssClass="registrationdropdown">
                                <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                <asp:ListItem Value="A" Text="Publish"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Unpublish"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Priority:
                        </td>
                        <td class="td_second">
                            <asp:DropDownList ID="ddlpriority" runat="server" AutoPostBack="true" Width="100px"
                                CssClass="registrationdropdown">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr id="submitid" runat="server">
                        <td class="td_first">
                        </td>
                        <td class="td_second">
                            <asp:Button ID="btnsubmit" runat="server" Text="Submit" ValidationGroup="vgsubmit"
                                CssClass="loginbtncss" OnClick="btnsubmit_Click" />
                        </td>
                    </tr>
                    <tr id="updateid" runat="server">
                        <td class="td_first">
                        </td>
                        <td class="td_second">
                            <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="loginbtncss" OnClick="btnupdate_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <%--<ajaxToolkit:ajaxfileupload id="ajaxFileUploadAttachments" runat="server" onuploadcomplete="ajaxFileUploadAttachments_UploadComplete"
                                onclientuploadcomplete="ajaxFileUploadAttachments_ClientUploadComplete" />--%>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
        <%--<uc2:footer ID="footer1" runat="server" />--%>
    </div>
    </form>
</body>
</html>
