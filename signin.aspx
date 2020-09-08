<%@ Page Title="Signin | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="robots" content="noindex,nofollow" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-6">
                    <div class="accntsec">
                        <a style="float: right; margin-top: -25px;" href='<%= Page.ResolveUrl("~/signup.html")%>'><i class="fa fa-user-plus" aria-hidden="true"></i>New User</a>
                        <header class="section-header">
                            <h3>Login</h3>
                            <p>Sign in to continue to Astro Envision</p>
                        </header>
                        <div class="form-group">
                            <label class="required">Username</label>
                            <asp:TextBox ID="txtuserid" runat="server" CssClass="form-control form-control-lg" placeholder="Username" TabIndex="1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtuserid" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter User ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label class="required">Password</label>
                            <asp:TextBox ID="txtpwd" runat="server" CssClass="form-control form-control-lg" placeholder="********" TextMode="Password" TabIndex="2"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqPass" runat="server" ControlToValidate="txtpwd" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Password" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mt-4 text-center">
                            <asp:Button ID="btnsignin" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnsignin_Click" TabIndex="3" />
                            <div style="padding-top: 5px"><a href='<%= Page.ResolveUrl("~/forgot_password.html")%>'>Forgot Password?</a></div>
                        </div>
                        <div class="mt-2">
                            <div class="lgntxt">By Submitting, you agree to Astro Envision's <a href='<%= Page.ResolveUrl("~/privacy-policy.html")%>'>Privacy Policy</a> & <a href='<%= Page.ResolveUrl("~/terms-of-use.html")%>'>Terms & Conditions</a></div>
                        </div>
                    </div>
                    <div class="ntreg">Not Registered Yet?</div>
                    <div class="pd2">
                        <a href='<%= Page.ResolveUrl("~/signup.html")%>' class="btn btn-primary btn-block btn-lg">New User Register</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <asp:HiddenField ID="hdnPriviousURl" runat="server" />
</asp:Content>




