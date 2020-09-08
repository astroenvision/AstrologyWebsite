<%@ Page Title="Change Password | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section class="srvc-sec">
            <div class="container">
                <%--<div class="logo-section text-center">
                    <img src="img/large_logo.png" />
                </div>--%>
                <div class="row justify-content-center">
                    <div class="col-sm-6">
                        <div class="accntsec">
                            <header class="section-header">
                                <h3>Change Password</h3>
                            </header>
                            <div class="form-group">
                                <label class="required">Old Password</label>
                                <asp:TextBox ID="txtOldPwd" runat="server" CssClass="form-control form-control-lg" placeholder="Old Password" TextMode="Password" required="required"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label class="required">New Password</label>
                                <asp:TextBox ID="txtNewpwd" runat="server" CssClass="form-control form-control-lg" placeholder="********" TextMode="Password" required="required"></asp:TextBox>
                                  <asp:RegularExpressionValidator ID="regPassword" runat="server"    
                                            ErrorMessage="Password length must be between 7 to 10 characters"
                                            ControlToValidate="txtNewpwd"    
                                            ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,10}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                            </div>
                               <div class="form-group">
                                <label class="required">Confirm Password</label>
                                <asp:TextBox ID="txtConfrimPwd" runat="server" CssClass="form-control form-control-lg" Placeholder="********" TextMode="Password" required="required"></asp:TextBox>
                            </div>
                            <div class="mt-4 text-center">
                                <asp:Button ID="btnChangePassword" runat="server" Text="Submit" OnClick="btnChangePwd_Click" AutoPostBack="True" ValidationGroup="save" CssClass="btn btn-primary btn-block btn-lg"  />
                            </div>
                        </div>
                    </div>
                </div>
                </div>
        </section>
</asp:Content>

