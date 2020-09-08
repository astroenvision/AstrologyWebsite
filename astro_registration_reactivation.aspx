<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_registration_reactivation.aspx.cs"
    Inherits="astro_registration_reactivation" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision
    </title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer loginMidCont">
            <div class="main-contentarticle">
                <div class="form-background_article">
                    <fieldset class="registrationmain" id="FSForgetPwdID" runat="server">
                        <div class="form-title-row-article">
                            <h1>
                                Forgot Password
                            </h1>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <span>Email Id</span>
                                <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtemailid"
                                    ErrorMessage="Email ID is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                    CssClass="form-row-article-validation" Display="Dynamic" />
                            </label>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <asp:UpdatePanel ID="updpanl" runat="server">
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                    </Triggers>
                                    <ContentTemplate>
                                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" ValidationGroup="vgsubmit"
                                            CssClass="form-row-article-button" OnClick="btnsubmit_Click" />
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </label>
                        </div>
                        <%--<table cellspacing="5" cellpadding="5" class="registrationtable">
                            <tr class="tr_css">
                                <td class="td_first">
                                    Email ID <font class="star">*</font>
                                </td>
                                <td class="td_second">
                                    <asp:TextBox ID="txtemailid_old" runat="server" Width="100%" CssClass="registrationtextbox"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtemailid_old"
                                        ErrorMessage="Email ID is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                        CssClass="registrationvalidation" Display="Dynamic" />
                                </td>
                            </tr>
                            <tr class="tr_css">
                                <td class="td_first">
                                </td>
                                <td class="td_second">
                                    <asp:UpdatePanel ID="updpanl" runat="server">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                        </Triggers>
                                        <ContentTemplate>
                                            <asp:Button ID="btnsubmit" runat="server" Text="Submit" ValidationGroup="vgsubmit"
                                                CssClass="loginbtncss" OnClick="btnsubmit_Click" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>--%>
                    </fieldset>
                    <fieldset class="registrationmain" id="FSChangePwdID" runat="server">
                        <div class="form-title-row-article">
                            <h1>
                                Change Password
                            </h1>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <span>Old Password <font class="star">*</font></span>
                                <asp:TextBox ID="txtoldpwd" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="oldpwdReq" runat="server" ControlToValidate="txtoldpwd"
                                    ErrorMessage="Old Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                    CssClass="form-row-article-validation" Display="Dynamic" />
                            </label>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <span>New Password <font class="star">*</font></span>
                                <asp:TextBox ID="txtnewpwd" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="newpwdReq" runat="server" ControlToValidate="txtnewpwd"
                                    ErrorMessage="New Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                    CssClass="form-row-article-validation" Display="Dynamic" />
                            </label>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <span>Confirm Password <font class="star">*</font></span>
                                <asp:TextBox ID="txtcfmnewpwd" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcfmnewpwd"
                                    ErrorMessage="Confirm New Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                    CssClass="form-row-article-validation" Display="Dynamic" />
                                <asp:CompareValidator ID="comparePasswords" runat="server" ControlToCompare="txtnewpwd"
                                    ControlToValidate="txtcfmnewpwd" ErrorMessage="New and confirm password didn't match!"
                                    Display="Dynamic" ValidationGroup="vgupdate" CssClass="form-row-article-validation" />
                            </label>
                        </div>
                        <div class="form-row-article">
                            <label>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                    </Triggers>
                                    <ContentTemplate>
                                        <asp:Button ID="btnupdatepwd" runat="server" Text="Update" ValidationGroup="vgupdate"
                                            CssClass="form-row-article-button" OnClick="btnupdatepwd_Click" />
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </label>
                        </div>
                        <%--<table cellspacing="5" cellpadding="5" class="registrationtable">
                            <tr>
                                <td class="td_first">
                                    Old Password <font class="star">*</font>
                                </td>
                                <td class="td_second" style="text-align: left;">
                                    <asp:TextBox ID="txtoldpwd" runat="server" Width="45%" CssClass="registrationtextbox"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="oldpwdReq" runat="server" ControlToValidate="txtoldpwd"
                                        ErrorMessage="Old Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                        CssClass="registrationvalidation" Display="Dynamic" />
                                </td>
                            </tr>
                            <tr>
                                <td class="td_first">
                                    New Password <font class="star">*</font>
                                </td>
                                <td class="td_second" style="text-align: left;">
                                    <asp:TextBox ID="txtnewpwd" runat="server" Width="45%" CssClass="registrationtextbox"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="newpwdReq" runat="server" ControlToValidate="txtnewpwd"
                                        ErrorMessage="New Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                        CssClass="registrationvalidation" Display="Dynamic" />
                                </td>
                            </tr>
                            <tr>
                                <td class="td_first">
                                    Confirm Password <font class="star">*</font>
                                </td>
                                <td class="td_second" style="text-align: left;">
                                    <asp:TextBox ID="txtcfmnewpwd" runat="server" Width="45%" CssClass="registrationtextbox"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcfmnewpwd"
                                        ErrorMessage="Confirm New Password is required!" SetFocusOnError="True" ValidationGroup="vgupdate"
                                        CssClass="registrationvalidation" Display="Dynamic" />
                                    <asp:CompareValidator ID="comparePasswords" runat="server" ControlToCompare="txtnewpwd"
                                        ControlToValidate="txtcfmnewpwd" ErrorMessage="New and confirm password didn't match!"
                                        Display="Dynamic" ValidationGroup="vgupdate" CssClass="registrationvalidation" />
                                </td>
                            </tr>
                            <tr>
                                <td class="td_first">
                                </td>
                                <td class="td_second" style="text-align: left;">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="btnsubmit" />
                                        </Triggers>
                                        <ContentTemplate>
                                            <asp:Button ID="btnupdatepwd" runat="server" Text="Update" ValidationGroup="vgupdate"
                                                CssClass="loginbtncss" OnClick="btnupdatepwd_Click" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>--%>
                    </fieldset>
                    <h1 class="activate_h1" id="activate_h1_id" runat="server">
                    </h1>
                    <%-- <h2 class="activate_h2" id="activate_h2_id" runat="server">
            </h2>--%>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
