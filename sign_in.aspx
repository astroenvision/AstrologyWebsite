<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign_in.aspx.cs" Inherits="sign_in" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign in | Astro Envision</title>
    <meta name="description" content="Astro Envision, Online Vedic Astrology Software generates multiple reports backed by Hundreds of Thousands of planetary combinations present in your birth Chart. Prashna Astrology, Horary Astrology, Instant Horary Astrology." />
    <meta name="keywords" content="Online Astrology Services, Astrology Portal, Astrology Website, Indian Astrologer, Indian Vedic Astrology,  Indian Astrology, Natal Astrology, Prashna Astrology, Horary Astrology, Tajik Astrology,  Personal Consultancy, Birth chart Astrology, Telephonic Astrology Consultancy, Skype Astrology Consultancy, Online Astrology Reports for Money,  Online Astrology Reports for Wealth, Online Astrology Reports for Career, Online Astrology Reports for Finance, Online Astrology Reports for Cash, Online Astrology Report for Riches, Online Astrology Reports for Property, Online Astrology Reports for Prosperity, Online Astrology Reports for Profession, Online Astrology Reports for Fame, Online Reports for Fortune, Online Astrology Reports for Love, Online Astrology Reports for Sex life, Online  Astrology Repots for Marriage Prospects, Online Astrology Reports for Manglik Dosha, Astrologer in Delhi, Astrologer in Delhi NCR, Astrologer in India, Top Astrologer, Unique Astrologer,  Old Astrologer, Mantra Astrologer, Tantra Astrologer, Yantra,  Female Astrology, Online Female Astrology, Famous Astrologer, Celebrity Astrologer, Future Astrology, Future Astrologer, Master Astrologer, Horary Astrologer, Prashna Astrologer, Tajik Astrologer Eminent Astrologer, Well known Astrologer, Prestigious Astrologer, Notable Astrologer, Outstanding Astrologer, Foremost Astrologer." />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" href="loginform/demo.css" />
    <link rel="stylesheet" href="loginform/form-register.css" />
    <link rel="stylesheet" href="loginform/form-login.css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="main-contentregistration">
                <div class="form-register-with-email" id="enduser_div" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="form-white-background">
                                <div class="form-title-row">
                                    <h1>
                                        Sign in
                                    </h1>
                                    
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email Id</span>
                                        <asp:TextBox ID="txtusername1" runat="server" PlaceHolder="Email Id *"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Password</span>
                                        <asp:TextBox ID="txtpwd1" TextMode="Password" runat="server" PlaceHolder="Password *"></asp:TextBox>
                                        
                                    </label>
                                </div>
                                <div class="form-row">
                                 <asp:Button ID="btnsignin" runat="server" Text="Sign in" CssClass="loginbutton"
                                        OnClick="btnsignin_Click" />
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
