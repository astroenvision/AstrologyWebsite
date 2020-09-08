<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_registration.aspx.cs"
    Inherits="astro_registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="fullarticle_catname">
                <h1 class="fullarticle_catname_h1">
                    Registration (For New Members)</h1>
                <%--<asp:Button ID="btnback" runat="server" Text="Back" CssClass="fullarticle_catname_backbtn"
                    OnClick="btnback_Click" />--%>
            </div>
            <fieldset class="registrationmain">
                <table cellspacing="5" cellpadding="5" class="registrationtable">
                    <tr>
                        <td class="td_first">
                            Name <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtname" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="nameReq" runat="server" ControlToValidate="txtname"
                                ErrorMessage="Name is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                CssClass="registrationvalidation" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Email Id <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtemailid" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="EmailReq" runat="server" ControlToValidate="txtemailid"
                                ErrorMessage="EmailID is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                CssClass="registrationvalidation" Display="Dynamic" />
                            <asp:RegularExpressionValidator ID="EmailReqVal" ControlToValidate="txtemailid" Text="Invalid Email ID !"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server"
                                CssClass="registrationvalidation" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Password <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtpwd" TextMode="Password" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="passwordReq" runat="server" ControlToValidate="txtpwd"
                                ErrorMessage="Password is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                CssClass="registrationvalidation" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Confirm Password <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtconfirmpwd" TextMode="Password" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="confirmPasswordReq" runat="server" ControlToValidate="txtconfirmpwd"
                                ErrorMessage="Password confirmation is required!" SetFocusOnError="True" Display="Dynamic"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation" />
                            <asp:CompareValidator ID="comparePasswords" runat="server" ControlToCompare="txtpwd"
                                ControlToValidate="txtconfirmpwd" ErrorMessage="Your passwords do not match up!"
                                Display="Dynamic" ValidationGroup="vgsubmit" CssClass="registrationvalidation" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Alternate Email Id
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtaltemailid" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Mobile No. <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtmobileno" runat="server" Width="70%" CssClass="registrationtextbox"
                                MaxLength="10"></asp:TextBox><br />
                            <asp:RequiredFieldValidator ID="mobileReq" runat="server" ControlToValidate="txtmobileno"
                                ErrorMessage="Mobile No. is required!" SetFocusOnError="True" Display="Dynamic"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation" />
                            <asp:RegularExpressionValidator ID="mobilevalReq" runat="server" ControlToValidate="txtmobileno"
                                ErrorMessage="Invalid Mobile No." ValidationExpression="[0-9]{10}" CssClass="registrationvalidation"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Land Line No.
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtlandlineno" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Address One <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtaddressone" TextMode="MultiLine" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="addressoneReq" runat="server" ControlToValidate="txtaddressone"
                                ErrorMessage="Address One is required!" SetFocusOnError="True" Display="Dynamic"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Address Two <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtaddresstwo" TextMode="MultiLine" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="addresstwoReq" runat="server" ControlToValidate="txtaddresstwo"
                                ErrorMessage="Address Two is required!" SetFocusOnError="True" Display="Dynamic"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Gender <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlgender" runat="server" AutoPostBack="true" Width="72%" CssClass="registrationdropdown">
                                        <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="MALE"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="FEMALE"></asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlgender"
                                InitialValue="0" runat="server" ErrorMessage="Please select any gender type !"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Landmark
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtlandmark" TextMode="MultiLine" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Country <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlcountry" runat="server" Width="72%" AutoPostBack="true"
                                        CssClass="registrationdropdown" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Zip Code <font class="star">*</font>
                        </td>
                        <td class="td_second">
                            <asp:TextBox ID="txtzipcode" runat="server" Width="70%" CssClass="registrationtextbox"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="zipcodeReq" runat="server" ControlToValidate="txtzipcode"
                                ErrorMessage="Zip Code required!" SetFocusOnError="True" Display="Dynamic" ValidationGroup="vgsubmit"
                                CssClass="registrationvalidation" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            Subscription For<font class="star"> *</font>
                        </td>
                        <td class="td_second">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlsb" runat="server" AutoPostBack="true" Width="72%" CssClass="registrationdropdown">
                                        <asp:ListItem Value="0" Text="Select Subscription"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="Natal"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="Horary"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="Both"></asp:ListItem>
                                    </asp:DropDownList>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="ddlsb"
                                InitialValue="0" runat="server" ErrorMessage="Please select any subscription !"
                                ValidationGroup="vgsubmit" CssClass="registrationvalidation"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_first">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/CImage.aspx" Width="200" Style="display: none;" />
                        </td>
                        <td class="td_second">
                        </td>
                    </tr>
                    <tr>
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
                </table>
            </fieldset>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
