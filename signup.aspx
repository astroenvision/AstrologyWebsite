<%@ Page Title="Signup | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="robots" content="noindex,nofollow" />
    <script type="text/javascript">
        function ValidateCheckBox(sender, args) {
            if (document.getElementById("<%=chkTerms.ClientID %>").checked == true) {
                args.IsValid = true;
                ctl00_ContentPlaceHolder1_CustomValidator1.style.display = 'block';
            } else {
                args.IsValid = false;
            }
        }
        function ShowHideDiv(chkPassport) {
            ctl00_ContentPlaceHolder1_CustomValidator1.style.display = 'none';
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel runat="server" ID="UpdInfo">
        <ContentTemplate>
            <section class="srvc-sec">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-sm-8">
                            <div class="accntsec">
                                <header class="section-header">
                                    <h3>Sign Up</h3>
                                    <p>Create your Astro Envision Account</p>
                                </header>
                                <%--<div class="row" style="display: none;">
                                    <div class="col-xl-3 col-sm-5 col-6 form-group">
                                        <div class="custom-control custom-radio">
                                            <input type="radio" class="custom-control-input" id="crEnduser" name="crEnduser" value="crEnduser" checked>
                                            <label class="custom-control-label" for="crEnduser">End User</label>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-sm-5 col-6 form-group">
                                        <div class="custom-control custom-radio">
                                            <input type="radio" class="custom-control-input" id="crAstrologer" name="crAstrologer" value="crEnduser">
                                            <label class="custom-control-label" for="crAstrologer">Astrologer</label>
                                        </div>
                                    </div>
                                </div>--%>
                                <div class="bdr-clearfix form-group"></div>
                                <div class="row">
                                    <div class="col-sm-6 form-group">
                                        <label class="required">Name</label>
                                        <asp:TextBox ID="txtname" runat="server" PlaceHolder="Enter full name" CssClass="form-control form-control-lg" onfocus="this.type='text'" TabIndex="1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqName" runat="server"
                                            ControlToValidate="txtname" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Name is required!" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regName" runat="server" ControlToValidate="txtname"
                                            ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enetr Only Alphabets" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                                    </div>

                                    <div class="col-sm-6 form-group">
                                        <label class="required">Email ID</label>
                                        <asp:TextBox ID="txtmailid" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter Email Id" type="email" AutoCompleteType="Disabled" autocomplete="off" TabIndex="2"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqEmail" runat="server"
                                            ControlToValidate="txtmailid" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Email Id is required!" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Enter Valid Email"
                                            ControlToValidate="txtmailid" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                                    </div>

                                    <div class="col-sm-6 form-group">
                                        <label class="required">Password</label>
                                        <asp:TextBox ID="txtpwd" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter password" TextMode="password" MaxLength="15" AutoCompleteType="Disabled" autocomplete="off" TabIndex="3"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqPassword" runat="server"
                                            ControlToValidate="txtpwd" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Password is required!" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regPassword" runat="server"
                                            ErrorMessage="Password length must be min 8 - max 15 character length, at least two letters (not case sensitive), one number, one special character, space is not allowed."
                                            ControlToValidate="txtpwd"
                                            ValidationExpression="^(?=(.*[a-zA-Z].*){2,})(?=.*\d.*)(?=.*\W.*)[a-zA-Z0-9\S]{8,15}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                                    </div>
                                    <div class="col-sm-6 form-group">
                                        <label class="required">Confirm Password</label>
                                        <asp:TextBox ID="txtconpwd" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter confirm password" TextMode="password" MaxLength="15" AutoCompleteType="Disabled" autocomplete="off" TabIndex="4"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqConPassword" runat="server"
                                            ControlToValidate="txtconpwd" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Confirm Password is required!" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>

                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtconpwd" ControlToCompare="txtpwd" ErrorMessage="Password does not match!"
                                            ValidationGroup="save" manimunvalue="1" CssClass="validator" Display="Dynamic" SetFocusOnError="True">
                                        </asp:CompareValidator>
                                    </div>
                                    <div class="col-sm-6 form-group">
                                        <label class="required">Mobile No</label>
                                        <asp:TextBox ID="txtcontact" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter Mobile No" onfocus="this.type='text'"
                                            onkeypress="return isNumber(event);" MaxLength="10" onblur="return ValidateNo();" TabIndex="5"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqContact" runat="server"
                                            ControlToValidate="txtcontact" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Mobile No is required!" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regContact" runat="server" ErrorMessage="Enter Valid Mobile No"
                                            ControlToValidate="txtcontact" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                                    </div>

                                    <div class="col-sm-6 form-group">
                                        <label class="required">Gender</label>
                                        <asp:DropDownList ID="userddlgender" runat="server" CssClass="form-control form-control-lg" TabIndex="6">
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Male"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Female"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="reqGender" runat="server"
                                            ControlToValidate="userddlgender" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Select Gender" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="col-sm-6 form-group" runat="server" visible="false">
                                        <label class="required">Country</label>
                                        <asp:DropDownList ID="ddlcountry" runat="server" CssClass="form-control form-control-lg" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" PlaceHolder="Select Country" />
                                        <%-- <asp:RequiredFieldValidator ID="reqCountry" runat="server"
                                            ControlToValidate="ddlcountry" CssClass="validator" Display="Dynamic" InitialValue="--Select Country--"
                                            ErrorMessage="Select Country" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                    </div>

                                    <div class="col-sm-6 form-group" runat="server" visible="false">
                                        <label class="required">State</label>
                                        <asp:DropDownList ID="ddlstate" runat="server" CssClass="form-control form-control-lg" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" PlaceHolder="Select State" />
                                        <%-- <asp:RequiredFieldValidator ID="reqState" runat="server"
                                            ControlToValidate="ddlstate" CssClass="validator" Display="Dynamic" InitialValue="--Select State--"
                                            ErrorMessage="Select State" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                    </div>

                                    <div class="col-sm-6 form-group" runat="server" visible="false">
                                        <label class="required">City</label>
                                        <asp:DropDownList ID="ddlcity" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter city" />
                                        <%--<asp:RequiredFieldValidator ID="reqCity" runat="server"
                                            ControlToValidate="ddlcity" CssClass="validator" Display="Dynamic" InitialValue="--Select City--"
                                            ErrorMessage="Select City" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                    </div>

                                    <div class="col-sm-12 form-group" runat="server" visible="false">
                                        <label class="required">Address</label>
                                        <asp:TextBox ID="txtaddress" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter address..." onfocus="this.type='text'"></asp:TextBox>
                                    </div>

                                    <div class="col-sm-6 form-group" style="display: none;">
                                        <label class="required">Pin Code</label>
                                        <asp:TextBox ID="txtpincode" runat="server" PlaceHolder="Pin Code" CssClass="form-control form-control-lg" onfocus="this.type='text'"></asp:TextBox>
                                    </div>

                                    <div class="col-sm-12 form-group">
                                        <div class="tnc-ttl">Terms and Conditions</div>
                                        <div class="tnc-desc">Please read the terms and indidate that you accept them to continue with the set up process. By clicking I accept you are agreeing to the <a href="<%=ResolveUrl("~/terms-of-use.html") %>">terms and conditions </a>, the Program Policy, and the <a href="<%=ResolveUrl("~/privacy-policy.html") %>">Privacy Policy</a>.</div>
                                    </div>

                                    <div class="col-sm-12 form-group">
                                        <div class="custom-checkbox">
                                            <%--  <input type="checkbox" class="custom-control-input" id="customCheck" name="example1">
                                            <label class="custom-control-label" for="customCheck">I accept all Terms & Conditions</label>--%>
                                            <%--<asp:CheckBox ID="chkbox" CssClass="custom-control-input" runat="server" AutoPostBack="true" Text="I accept all Terms & Conditions" />--%>
                                            <label class="chkcontainer">
                                                <asp:CheckBox ID="chkTerms" onclick="ShowHideDiv(this)" runat="server" />I accept all Terms & Conditions
                                        <asp:Label ID="Label3" AssociatedControlID="chkTerms" runat="server"
                                            CssClass="checkmark"></asp:Label>
                                            </label>
                                            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please Check Terms & Conditions" ClientValidationFunction="ValidateCheckBox" CssClass="validator" Display="Dynamic" ValidationGroup="save"></asp:CustomValidator>
                                        </div>
                                    </div>
                                </div>
                                <div class="mt-3 text-center">
                                    <asp:Button ID="btnregister" runat="server" Text="Sign Up" CssClass="kwm-btn-lg" ValidationGroup="save" OnClick="btnregister_Click" TabIndex="7" />
                                </div>

                            </div>
                        </div>
                    </div>

                </div>
            </section>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

