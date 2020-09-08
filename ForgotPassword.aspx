<%@ Page Title="Forgot Password | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
      <meta name="robots" content="noindex,nofollow" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-6">
                    <div class="accntsec">
                        <header class="section-header">
                            <h3>Forgot Your Password?</h3>
                        </header>
                        <div class="form-group">
                            <label class="required">Email ID</label>
                            <asp:TextBox ID="txtmailid" runat="server" CssClass="form-control form-control-lg" PlaceHolder="Enter email id" type="email" validate="required:true"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqEmail" runat="server"
                                ControlToValidate="txtmailid" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Email" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Enter Valid Email"
                                ControlToValidate="txtmailid" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                        </div>
                        <div class="mt-4 text-center">
                            <asp:Button ID="btnregister" runat="server" Text="Forgot Password" CssClass="kwm-btn-lg" OnClick="btnsubmit_Click" ValidationGroup="save" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

