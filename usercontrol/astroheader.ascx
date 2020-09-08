<%@ Control Language="C#" AutoEventWireup="true" CodeFile="astroheader.ascx.cs" Inherits="usercontrol_astroheader" %>

<!-- Google Fonts -->
<link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />

<!-- Bootstrap CSS File -->
<link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

<!-- Libraries CSS Files -->
<link href="lib/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
<link href="lib/animate/animate.min.css" rel="stylesheet" />
<link href="lib/ionicons/css/ionicons.min.css" rel="stylesheet" />
<link href="lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet" />
<link href="lib/lightbox/css/lightbox.min.css" rel="stylesheet" />

<!-- Main Stylesheet File -->
<link href="css/style.css" rel="stylesheet" />
<link href="css/indexpage.css" rel="stylesheet" />

<!--==========================
    Header
  ============================-->
<header id="header">
    <div class="container">

        <div class="pull-left">
            <nav id="nav-menu-container">
                <ul class="nav-menu">
                    <li class="active"><a class="hme" href="<%=ResolveUrl("~") %>"><i class="fa fa-home"></i></a></li>
                    <li class="menu-has-children"><a href="#" title="Services">Services</a>
                        <ul>
                            <li><a href="<%=ResolveUrl("~/natal-astrology.html") %>" title="Natal Astrology">Natal Astrology</a> </li>
                            <li><a href="<%=ResolveUrl("~/astro-reports.html") %>" title="Astro Reports">Astro Reports</a> </li>
                            <li class="menu-has-children"><a href="#" title="Specialised Services">Specialised Services</a>
                                <ul>
                                    <li><a href="<%=ResolveUrl("~/24-7-astrological-support.html") %>" title="24X7 - Astrological Support">24X7 - Astrological Support</a></li>
                                    <li><a href="<%=ResolveUrl("~/weekly-predictions.html") %>" title="Weekly Predictions">Weekly Predictions</a></li>
                                    <li><a href="<%=ResolveUrl("~/monthly-predictions.html") %>" title="Monthly Predictions">Monthly Predictions</a></li>
                                    <%--<li><a href="<%=ResolveUrl("~/yearly-predictions.html") %>" title="Yearly Predictions">Yearly Predictions</a></li>--%>
                                    <li><a href="<%=ResolveUrl("~/birth-chart-analysis.html") %>" title="Birth Chart Analysis">Birth Chart Analysis</a></li>
                                </ul>
                            </li>
                            <li><a href="<%=ResolveUrl("~/corporate-astrology.html") %>" title="Corporate Astrology">Corporate Astrology</a> </li>
                            <%--<li><a href="<%=ResolveUrl("~/business-astrology.html") %>" title="Business Astrology">Business Astrology</a> </li>--%>
                        </ul>
                    </li>
                    <li class="menu-has-children"><a href="<%=ResolveUrl("~/consult-an-astrologer.html") %>" title="Consult an Astrologer">Consult an Astrologer</a>
                        <ul>
                            <li><a href="<%=ResolveUrl("~/personal-meeting.html") %>" title="Personal Meeting">Personal Meeting</a></li>
                        </ul>
                    </li>
                    <li class="menu-has-children"><a href="#" title="Highlights">Highlights</a>
                        <ul>
                            <%-- <li><a href="<%=ResolveUrl("~/astrology/highlights/a-natal-glimpse/24-43.html") %>" title="A Natal Glimpse">A Natal Glimpse</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/natal-features/25-44.html") %>" title="Natal Features">Natal Features</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/a-horary-glimpse/26-45.html") %>" title="A Horary Glimpse">A Horary Glimpse</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/horary-features/27-46.html") %>" title="Horary Features">Horary Features</a></li>--%>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/a-natal-glimpse.html") %>" title="A Natal Glimpse">A Natal Glimpse</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/natal-features.html") %>" title="Natal Features">Natal Features</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/a-horary-glimpse.html") %>" title="A Horary Glimpse">A Horary Glimpse</a></li>
                            <li><a href="<%=ResolveUrl("~/astrology/highlights/horary-features.html") %>" title="Horary Features">Horary Features</a></li>
                        </ul>
                    </li>
                    <%--<li><a href="<%=ResolveUrl("~/compatibilitymatching.html") %>">Compatibility Matching</a></li>
                    <li><a href="<%=ResolveUrl("~/freehoroscope.html") %>">Free Horoscope</a></li>--%>
                    <li><a href="<%=ResolveUrl("~/astrology/blog.html") %>" title="Blogs">Blogs</a></li>
                    <li><a href="<%=ResolveUrl("~/talk-to-astrologers.html") %>" title="Talk To Astrologer">Talk To Astrologer</a></li>
                    <li><a href="<%=ResolveUrl("~/feedback.html") %>" title="Feedback">Feedback</a></li>
                    <li class="d-sm-none"><a href="<%=ResolveUrl("~/signin.html")%>" title="Login & Register">Login & Register</a></li>
                </ul>
            </nav>
        </div>

        <div class="pull-right rgtnv">
            <ul class="nav-menu1" id="menurightid" runat="server">

                <% if (Session["UserEmailID"] != null)
                    {%>
                <%--<li><a href="<%=ResolveUrl("~/CheckOutCart.html") %>" class="cartrgt"><img src="img/cart_white.svg" alt="User Image" /><asp:Label ID="lblMessage" runat="server"></asp:Label></a></li>
                <li class="d-768-none"><a href="#"><%=Session["name"]%></a></li>
                <li class="d-768-none"><a href="javascript:Logout();">Logout</a></li>--%>
                <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">
                    <div class="uzravtr">
                        <img class="usrpic" src="img/Default.jpg" alt="User Image">
                        <span class="usrstts"></span>
                    </div>
                    <span class="lgdusr">Welcome <%=Session["UserName"]%></span></a>
                    <ul class="dropdown-menu dropdown-menu-right">
                        <div class="dropdown-body">
                            <div class="uzrdtl">
                                <div class="row align-items-center">
                                    <div class="col-4">
                                        <img class="usrpic-big" src="<%=ResolveUrl("~/img/Default.jpg") %>" alt="User Image" title="User Image" />
                                    </div>
                                    <div class="col-8">
                                        <div class="uzrnme"><%=Session["UserName"]%></div>
                                        <div class="usreml"><%=Session["UserEmailID"]%></div>
                                        <div class="uzrnme"><a href='<%= Page.ResolveUrl("~/MyReports.html")%>' title="My Reports" style="color: #f25e0a;">My Reports</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="ddwn-foot">
                            <%--<a class="btn-drpdwn" data-toggle="modal" data-target="#chngePass" href="ChangePassword.aspx" >Change Password</a>--%>
                            <a class="btn-drpdwn" href='<%= Page.ResolveUrl("~/ChangePassword.aspx")%>'>Change Password</a>
                            <%-- <a class="btn-drpdwn pull-right" href="javascript:Logout();">Logout</a>--%>
                            <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click" CssClass="btn-drpdwn pull-right">Logout</asp:LinkButton>
                        </div>
                    </ul>
                </li>
                <%}
                    else
                    {%>
                <%--<li><a href="#"><i class="fa fa-shopping-cart cartfs"></i><asp:Label ID="Label1" runat="server"></asp:Label></a></li>--%>
                <li class="d-768-none"><a href="<%= Page.ResolveUrl("~/signin.html")%>" title="Login & Register">Login & Register</a></li>
                <%}%>
            </ul>
        </div>

    </div>
</header>
<!-- #header -->



<!-- JavaScript Libraries -->
<script src="lib/jquery/jquery.min.js"></script>
<script src="lib/jquery/jquery-migrate.min.js"></script>
<script src="lib/bootstrap/js/bootstrap.bundle.min.js"></script>
<script src="lib/superfish/hoverIntent.js"></script>
<script src="lib/superfish/superfish.min.js"></script>
<script src="lib/wow/wow.min.js"></script>
<script src="lib/waypoints/waypoints.min.js"></script>
<script src="lib/counterup/counterup.min.js"></script>
<script src="lib/owlcarousel/owl.carousel.min.js"></script>
<script src="lib/isotope/isotope.pkgd.min.js"></script>
<script src="lib/lightbox/js/lightbox.min.js"></script>
<script src="lib/touchSwipe/jquery.touchSwipe.min.js"></script>
<!-- Contact Form JavaScript File -->
<%--  <script src="contactform/contactform.js"></script>--%>

<!-- Template Main Javascript File -->
<script src="js/main.js"></script>
<%-- <script src="js/astroenvision.js"></script>--%>

<link href="js/Select2/select2.min.css" rel="stylesheet" />
<script src="js/Select2/select2.min.js"></script>
<script src="js/common.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        // activate left navigation based on current link
        $('.nav-menu li a').filter(function () { return this.href == location.href }).parent().addClass('active').siblings().removeClass('active')
        var current_url = window.location;
        $('.nav-menu li a').filter(function () {
            return this.href == current_url;
        }).last().parents('li').addClass('active');
    });
</script>
