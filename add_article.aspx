<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_article.aspx.cs" Inherits="add_article" ValidateRequest="false" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Article</title>
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />

    <script language="javascript" type="text/javascript">
    function onFileSelected(event) {
            var selectedFile = event.target.files[0];
            var reader = new FileReader();
            var imgtag = document.getElementById("imgauthor");
            imgtag.title = selectedFile.name;
            reader.onload = function(event) {
                imgtag.src = event.target.result;
            };
            reader.readAsDataURL(selectedFile);
        }
    </script>

</head>
<body style="margin: 0px auto; width: 1000px;">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <fieldset class="registrationmain" style="margin: 0em; width: 100%;">
                <table cellspacing="5" cellpadding="5" class="registrationtable">
                    <tr>
                        <td class="td_first">
                            Group:<font class="star"> *</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlgroup" runat="server" AutoPostBack="true" Width="200px"
                                        CssClass="registrationdropdown" OnSelectedIndexChanged="ddlgroup_SelectedIndexChanged">
                                        <asp:ListItem Value="0" Text="--Select Group--"></asp:ListItem>
                                        <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                        <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                        <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Category:<font class="star"> *</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlcat" runat="server" AutoPostBack="true" Width="200px" CssClass="registrationdropdown">
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Headline:<font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtheadline" runat="server" Width="90%" CssClass="registrationtextbox"></asp:TextBox>
                            <%--<br />
                            <asp:RequiredFieldValidator ID="nameReq" runat="server" ControlToValidate="txtname"
                                ErrorMessage="Name is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                CssClass="registrationvalidation" Display="Dynamic" />--%>
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
                            Full Details:<font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <FCKeditorV2:FCKeditor ID="rtedetails" runat="server" BasePath="~/fckeditor/" Width="600px"
                                Height="300px">
                            </FCKeditorV2:FCKeditor>
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
                            Author Image:
                        </td>
                        <td class="td_second">
                            <input visible="true" id="imgauthorfilename" runat="server" type="file" onchange="onFileSelected(event)" />
                            <br />
                            <br />
                            <asp:Image ID="imgauthor" runat="server" Height="100px" ImageUrl="" Width="150px"
                                BorderWidth="1px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Status:
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlstatus" runat="server" AutoPostBack="true" Width="100px"
                                        CssClass="registrationdropdown">
                                        <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                        <asp:ListItem Value="A" Text="Publish"></asp:ListItem>
                                        <asp:ListItem Value="P" Text="Unpublish"></asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Priority:
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlpriority" runat="server" AutoPostBack="true" Width="100px"
                                        CssClass="registrationdropdown">
                                        <%-- <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                        <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                        <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                        <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                        <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                        <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                        <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                        <asp:ListItem Value="10" Text="10"></asp:ListItem>--%>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr id="submitid" runat="server">
                        <td class="td_first">
                        </td>
                        <td class="td_second">
                           <%-- <asp:UpdatePanel ID="updpanl" runat="server">
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                </Triggers>
                                <ContentTemplate>--%>
                                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" ValidationGroup="vgsubmit"
                                        CssClass="loginbtncss" OnClick="btnsubmit_Click" />
                              <%--  </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </td>
                    </tr>
                    <tr id="updateid" runat="server">
                        <td class="td_first">
                        </td>
                        <td class="td_second">
                            <%--<asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                </Triggers>
                                <ContentTemplate>--%>
                                   <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="loginbtncss" OnClick="btnupdate_Click" />
                               <%--  </ContentTemplate>
                            </asp:UpdatePanel>--%>
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
