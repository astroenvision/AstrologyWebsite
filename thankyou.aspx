<%@ Page Language="C#" AutoEventWireup="true" CodeFile="thankyou.aspx.cs" Inherits="thankyou" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology and Consultancy, Prashna(Horary) Astrology</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:astroheader ID="astroheader1" runat="server" />
        <section class="bannerarea">
            <div class="container">
                 <div class="logo-section text-center">
                    <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
                </div>
                <div class="row justify-content-center">
                    <div class="col-sm-12">
                        <div class="accntsec">
                            <div class="jumbotron text-center">
                                <h1 class="display-3">Thank You!</h1>
                                <p class="lead"><strong>Thank you for choosing our service. we will send you astro report within 24 hours on your registered email id.</strong></p>
                                <p class="lead">
                                    <a class="btn btn-primary btn-sm" href="<%=ResolveUrl("~/index.html") %>" title="Astro Envision" role="button">Continue to homepage</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <uc2:astrofooter ID="astrofooter1" runat="server" />
    </form>
</body>
</html>
