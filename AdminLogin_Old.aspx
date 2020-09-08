<%@ Page Title="Admin | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="AdminLogin_Old.aspx.cs" Inherits="AdminLogin_Old" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <meta name="robots" content="noindex,nofollow" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <section class="srvc-sec">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-6">
                    <div class="accntsec">
                        <header class="section-header">
                            <h3>Admin Login</h3>
                         </header>
                        <div class="form-group">
                            <label class="required">Username</label>
                            <asp:TextBox ID="txtuserid" runat="server" CssClass="form-control form-control-lg" placeholder="Username"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtuserid" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter User ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label class="required">Password</label>
                            <asp:TextBox ID="txtpwd" runat="server" CssClass="form-control form-control-lg" placeholder="********" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqPass" runat="server" ControlToValidate="txtpwd" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Password" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mt-4 text-center">
                            <asp:Button ID="btnsignin" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" onclick="btnsignin_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

