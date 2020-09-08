<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_registration.aspx.cs"
    Inherits="user_registration" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" href="loginform/demo.css" />
    <link rel="stylesheet" href="loginform/form-register.css" />
    <link rel="stylesheet" href="loginform/form-login.css" />

    <script language="javascript" type="text/javascript">
        function AcceptTermsCheckBoxValidation(oSrouce, args)
        {
            var myCheckBox = document.getElementById('AcceptTermsCheckBox'); 
            if(!myCheckBox.checked)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    </script>

    <%--<script type="text/javascript">
    function isNumber(evt) {
        evt = (evt) ? evt : window.event;
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            alert("Please enter only Numbers.");
            return false;
        }
        return true;
    }

    function ValidateNo() {
        var phoneNo = document.getElementById('txtcontact');
        if (phoneNo.value == "" || phoneNo.value == null) {
            alert("Please enter your Mobile No.");
            return false;
        }
        if (phoneNo.value.length < 10 || phoneNo.value.length > 10) {
            alert("Mobile No. is not valid, Please Enter 10 Digit Mobile No.");
            return false;
        }
        return true;
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="false">
    </asp:ScriptManager>
    <script type="text/javascript" language="javascript">
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
    function EndRequestHandler(sender, args){
        if (args.get_error() != undefined){
            args.set_errorHandled(true);
        }
    }
   </script>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="main-content_registration">
                <!--You only need this form and the form-register.css-->
                <div class="form-register-with-email">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>
                                        Registration (For New User)
                                    </h1>
                                    <h2>
                                        * Indicates Mandatory Fields</h2>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Name</span>
                                        <%--<input type="text" name="name" placeholder="Name *" id="txtname" runat="server" />--%>
                                        <asp:TextBox ID="txtname" runat="server" PlaceHolder="Name *" onfocus="this.type='text'"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvname" ControlToValidate="txtname"
                                            ErrorMessage="Please enter your name !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpRegister" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email</span>
                                        <%--<input type="text" name="email" placeholder="Email *" id="emailid" runat="server" />--%>
                                        <asp:TextBox ID="txtmailid" runat="server" PlaceHolder="Email *" type="email"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvemailid" ControlToValidate="txtmailid"
                                            ErrorMessage="Please enter your Emailid !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpRegister" />
                                        <asp:RegularExpressionValidator ID="rfvemailidval" runat="server" ErrorMessage="Invalid Emailid."
                                            ControlToValidate="txtmailid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            Display="Dynamic" CssClass="loginformvalidate" ValidationGroup="GrpRegister">
                                        </asp:RegularExpressionValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Password</span>
                                        <%--<input type="password" name="password" placeholder="Password *" id="txtpwd" runat="server" />--%>
                                        <asp:TextBox ID="txtpwd" runat="server" PlaceHolder="Password *" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvpwd" ControlToValidate="txtpwd"
                                            ErrorMessage="Please enter your password !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpRegister" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Mobile No</span>
                                        <asp:TextBox ID="txtcontact" runat="server" PlaceHolder="Contact No *" onfocus="this.type='text'"></asp:TextBox>
                                        <%--onkeypress="return isNumber(event);" onblur="return ValidateNo();"></asp:TextBox>--%>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvMobil1" ControlToValidate="txtcontact"
                                            ErrorMessage="Please enter your Mobile no !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpRegister" />
                                        <asp:RegularExpressionValidator ID="rfvMobil2" ForeColor="Red" ControlToValidate="txtcontact"
                                            ValidationExpression="^[7-9][0-9](\s){0,1}(\-){0,1}(\s){0,1}[0-9]{1}[0-9]{7}$"
                                            runat="server" ErrorMessage="Please enter Valid MobileNo" ValidationGroup="GrpRegister"
                                            Display="Dynamic" CssClass="loginformvalidate"></asp:RegularExpressionValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Gender</span>
                                        <asp:DropDownList ID="userddlgender" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            >
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Male"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Female"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="regusergender" runat="server" InitialValue=""
                                            ControlToValidate="userddlgender" ErrorMessage="Please select gender !" Display="Dynamic"
                                            CssClass="loginformvalidate" ValidationGroup="GrpRegister"></asp:RequiredFieldValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Address</span>
                                        <asp:TextBox ID="txtaddress" runat="server" PlaceHolder="Address" onfocus="this.type='text'"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Country</span>
                                        <asp:DropDownList ID="ddlcountry" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" />
                                        <asp:RequiredFieldValidator ID="reqCountry" runat="server" InitialValue="--Select Country--"
                                            ControlToValidate="ddlcountry" ErrorMessage="Please select any country !" Display="Dynamic"
                                            CssClass="loginformvalidate" ValidationGroup="GrpRegister"></asp:RequiredFieldValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>State</span>
                                        <asp:DropDownList ID="ddlstate" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" />
                                        <asp:RequiredFieldValidator ID="reqState" runat="server" InitialValue="--Select State--"
                                            ControlToValidate="ddlstate" ErrorMessage="Please select any state !" Display="Dynamic"
                                            CssClass="loginformvalidate" ValidationGroup="GrpRegister"></asp:RequiredFieldValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>City</span>
                                        <asp:DropDownList ID="ddlcity" runat="server" CssClass="dropdowncss" />
                                        <asp:RequiredFieldValidator ID="reqCity" runat="server" InitialValue="--Select City--"
                                            ControlToValidate="ddlcity" ErrorMessage="Please select any city !" Display="Dynamic"
                                            CssClass="loginformvalidate" ValidationGroup="GrpRegister"></asp:RequiredFieldValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Pin Code</span>
                                        <asp:TextBox ID="txtpincode" runat="server" PlaceHolder="Pin Code" onfocus="this.type='text'"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="revpincode" runat="server" ControlToValidate="txtpincode"
                                            ErrorMessage="Only numeric allowed." ForeColor="Red" ValidationExpression="^[0-9]*$"
                                            ValidationGroup="GrpRegister" CssClass="loginformvalidate">
                                        </asp:RegularExpressionValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label class="form-checkbox">
                                        <%--<input id="" type="checkbox" name="checkbox" checked />--%>
                                        <asp:CheckBox ID="AcceptTermsCheckBox" runat="server" ValidationGroup="GrpRegister" />
                                        <asp:CustomValidator ID="ValTerms" ClientValidationFunction="AcceptTermsCheckBoxValidation"
                                            runat="server" ErrorMessage="Please Accept the Terms of Use and Privacy Policy" ValidationGroup="GrpRegister"
                                            CssClass="loginformvalidate"></asp:CustomValidator>
                                        <span>I agree to the <a href="<%=ResolveUrl("~/article/article.aspx?catid=15&articleid=36") %>" target="_blank">Terms of Use</a> and <a href="<%=ResolveUrl("~/article/article.aspx?catid=14&articleid=35") %>" target="_blank">Privacy Policy</a></span>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <%--<button type="submit">
                                         Register</button>--%>
                                    <%--<triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnregister" />
                                    </triggers>--%>
                                    <asp:Button ID="btnregister" runat="server" Text="Submit" CssClass="loginbutton"
                                        OnClick="btnregister_Click" ValidationGroup="GrpRegister" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="main-content_login">
                <!-- You only need this form and the form-login.css -->
                <div class="form-log-in-with-email">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>
                                        Login (Existing User)</h1>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email</span>
                                        <%--<input type="email" name="email" placeholder="Email" />--%>
                                        <asp:TextBox ID="txtloginemail" runat="server" PlaceHolder="Email" onfocus="this.type='text'"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="txtloginemail"
                                            ErrorMessage="Please enter your Emailid !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpLogin" />
                                        <asp:RegularExpressionValidator ID="reqEmailValid" runat="server" ErrorMessage="Invalid Emailid."
                                            ControlToValidate="txtloginemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            Display="Dynamic" CssClass="loginformvalidate" ValidationGroup="GrpLogin">
                                        </asp:RegularExpressionValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Password</span>
                                        <%--<input id="txtloginpwd" runat="server" type="password" name="password" placeholder="Password" />--%>
                                        <asp:TextBox ID="txtloginpwd" runat="server" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="reqPwd" ControlToValidate="txtloginpwd"
                                            ErrorMessage="Please enter your password !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpLogin" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <%--<button  type="submit">
                                   Log in</button>--%>
                                    <%-- <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnlogin" />
                                  </Triggers>--%>
                                    <asp:Button ID="btnlogin" runat="server" Text="Log in" CssClass="loginbutton" OnClick="btnlogin_Click"
                                        ValidationGroup="GrpLogin" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="main-content_pwd">
                <div class="form-pwd-in-with-email">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>
                                        Forgot Password ?</h1>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email</span>
                                        <%--<input type="email" name="email" placeholder="Email">--%>
                                        <asp:TextBox ID="txtforgotemail" runat="server" PlaceHolder="Email"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ID="rfvemail1" ControlToValidate="txtforgotemail"
                                            ErrorMessage="Please enter your Emailid !" CssClass="loginformvalidate" Display="Dynamic"
                                            ValidationGroup="GrpForgot" />
                                        <asp:RegularExpressionValidator ID="rfvemail2" runat="server" ErrorMessage="Invalid Emailid."
                                            ControlToValidate="txtforgotemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            Display="Dynamic" CssClass="loginformvalidate" ValidationGroup="GrpForgot">
                                        </asp:RegularExpressionValidator>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <%-- <button type="submit">
                                Get New Password</button>--%>
                                    <%--<Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnforgotpwd" />
                                   </Triggers>--%>
                                    <asp:Button ID="btnforgotpwd" runat="server" Text="Get Password" CssClass="loginbutton"
                                        OnClick="btnforgotpwd_Click" ValidationGroup="GrpForgot" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    <input type="hidden" runat="server" id="TotalAmounts" />
    <input type="hidden" runat="server" id="CurrencyType" />
    <input type="hidden" runat="server" id="hdncartid" />
    <input type="hidden" runat="server" id="hdncountrycode" />
    <input type="hidden" runat="server" id="hdngroupid" />
    </form>
</body>
</html>
