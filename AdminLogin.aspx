<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Admin | Astro Envision</title>
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/Custom.css" rel="stylesheet" />
    <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=no" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <style>
        /*.form-group {
            text-align: center;
        }

        .form-control-lg {
            font-size: 1rem;
        }



        .form-control {
            padding: 10px 42px;
            border-radius: 0;
            box-shadow: none;
            font-size: 15px;
            margin-bottom: 17px;
        }*/

        body {
            height: 100%;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
            display: block;
            background-image: url("../Image/AdminLogin.jpg");
        }

        /*@media(max-width: 991px) {
            .border {
                width: 350px;
                height: 350px;
                padding: 45px;
                border: 1px solid #fefafa;
                background: white;
                border-radius: 25px;
            }
        }

        @media (min-width: 768px) {
            .border {
                width: 500px;
                height: 300px;
                padding: 45px;
                border: 1px solid #fefafa;
                background: white;
                border-radius: 25px;
            }
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="Server" ID="ScriptManager1" />
        <%-- <section class="srvc-sec">
            <div class="container">
                <div class="logo-section text-center" style="margin: 0rem;">
                    <a class="hme" href="<%=ResolveUrl("~") %>" title="Astro Envision">
                        <img src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" /></a>
                </div>

                <div class="row justify-content-center">
                    <div class="row">
                        <div class="col-sm-6 form-group border" style="display: inline-block;">
                            <h3 style="font-size: 20px;">Admin Login</h3>

                            <div class="col-sm-6 form-group">
                                <label style="font-size: 23px; font-weight: 500;">Username</label>
                                <asp:TextBox ID="txtuserid" runat="server" CssClass="form-control form-control-lg" placeholder="Username"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtuserid" CssClass="validator" Display="Dynamic"
                                    ErrorMessage="Enter User ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-sm-6 form-group">
                                <label style="font-size: 23px; font-weight: 500;">Password</label>
                                <asp:TextBox ID="txtpwd" runat="server" CssClass="form-control form-control-lg" placeholder="********" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqPass" runat="server" ControlToValidate="txtpwd" CssClass="validator" Display="Dynamic"
                                    ErrorMessage="Enter Password" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="mt-4 text-center">
                                <asp:Button ID="btnsignin" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnsignin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>--%>
        <section class="srvc-sec">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-sm-6">
                        <div class="accntsec" style="margin-top: 50px;">
                            <div class="logo-section text-center mt-2 mb-5">
                                <a class="hme" href="<%=ResolveUrl("~") %>" title="Astro Envision">
                                    <img src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" /></a>
                            </div>
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
                                <asp:Button ID="btnsignin" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnsignin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
