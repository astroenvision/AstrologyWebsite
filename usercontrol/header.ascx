<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header.ascx.cs" Inherits="usercontrol_header" %>
<link rel="stylesheet" href="<%=ResolveUrl("~/usercontrol/css/style.css") %>">

 
<%-- <link rel="stylesheet" type="text/css" href="<%=ResolveUrl("~/css/responsivemenubar.css") %>" />

 <script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsivemenubar.custom.js") %>"></script>--%>
<%-- <script type="text/javascript">
    var blink_speed = 300;
var t = setInterval(function () {
    var ele = document.getElementById('header1_welcomeguestid');
    ele.style.visibility = (ele.style.visibility == 'hidden' ? '' : 'hidden');
}, blink_speed);
    </script>--%>
<div class="topcontainer">
    <%--<div class="main_menucss">
        <img src="<%=ResolveUrl("~/Image/menu.png") %>" alt="Menu" title="Menu" />
    </div>--%>
    <%--Google Translate Script Start--%>
    <%-- <div id="google_translate_element"></div><script type="text/javascript">
                                                     function googleTranslateElementInit() {
                                                         new google.translate.TranslateElement({ pageLanguage: 'en', layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL }, 'google_translate_element');
                                                     }
</script><script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>--%>
    <%--
Google Translate Script End--%>
    <%-- <div class="container demo-2">--%>
    <!-- Codrops top bar -->
    <%--<div class="main clearfix" style="float:left;">
            <div class="column_menu">
                <div id="dl-menu" class="dl-menuwrapper">
                    <button class="dl-trigger">
                        Open Menu</button>
                    <ul class="dl-menu" id="menubarid" runat="server">
                        <li><a href="<%=ResolveUrl("~/login.aspx") %>">Home</a></li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=10&articleid=34") %>">Services</a></li>
                        <li><a href="<%=ResolveUrl("~/article/details.aspx?catid=20&articleid=40") %>">Consult an Astrologer</a> </li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=7&articleid=32") %>">About Us</a> </li>
                        <li><a href="<%=ResolveUrl("~/feedback.aspx") %>">Feedback</a> </li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=8&articleid=33") %>">FAQs</a> </li>
                        <li><a href="<%=ResolveUrl("~/your_queries.aspx") %>">Your Queries</a> </li>
                    </ul>
                </div>
            </div>
        </div>--%>
    <%-- </div>--%>
    <!-- /container -->
    <div class="large_logo" id="logoid" runat="server">
        <%--<a href="<%=ResolveUrl("~/login.aspx") %>">
            <img src="<%=ResolveUrl("~/Image/large_logo.png") %>" alt="Astro Envision" title="Astro Envision" /></a>--%>
    </div>
    <div class="socialmedia_icons_main">
        <div id="myqueryid" runat="server" class="myquerycss">
        </div>
        <ul class="soc">
            <li><a class="soc-facebook" href="https://www.facebook.com/Astro-Envision-1702561730064187/"
                target="_blank"></a></li>
            <li><a class="soc-twitter" href="https://twitter.com/AstroEnvision" target="_blank">
            </a></li>
            <li><a class="soc-google" href="https://plus.google.com/u/1/103724043345926047151"
                target="_blank"></a></li>
            <li><a class="soc-linkedin" href="https://www.linkedin.com/in/astro-envision-049454124"
                target="_blank"></a></li>
            <li><a class="soc-youtube soc-icon-last" href="#"></a></li>
        </ul>
        <%--<div class="socialmedia_icons">
            <img src="<%=ResolveUrl("~/Image/fb.png") %>" alt="Facebook" title="Facebook" /></div>
        <div class="socialmedia_icons">
            <img src="<%=ResolveUrl("~/Image/twitter.png") %>" alt="Twitter" title="Twitter" /></div>
        <div class="socialmedia_icons">
            <img src="<%=ResolveUrl("~/Image/gplus.png") %>" alt="GPlus" title="GPlus" /></div>
        <div class="socialmedia_icons" style="border-right: 0px solid #5D5D5D;">
            <img src="<%=ResolveUrl("~/Image/whatsapp.png") %>" alt="WhatsApp" title="WhatsApp" /></div>--%>
        <div class="welcomeBox" id="welcomeBoxId" runat="server"></div>
    </div>
    <nav id='cssmenu' style='float: left; margin-top:5px;'>
<div id="head-mobile"></div>
<div class="button"></div>
<ul class="ulmenuleft">
<li><a href="<%=ResolveUrl("~/index.html") %>">Home</a></li>
<li><a href="<%=ResolveUrl("~/services.html") %>">Services</a></li>
<li><a href="<%=ResolveUrl("~/consult-an-astrologer.html") %>">Consult an Astrologer</a> </li>
<li><a href="<%=ResolveUrl("~/aboutus.html") %>">About Us</a> </li>
<li><a href="<%=ResolveUrl("~/feedback.html") %>">Feedback</a></li>
<%--<li><a href="#">Horary Highlights</a>
<ul>
<li><a href="<%=ResolveUrl("~/astrology/horary-highlight/a-horary-glimpse/21-41.html") %>">A Horary Glimpse</a></li>
<li><a href="<%=ResolveUrl("~/astrology/horary-highlight/software-features/22-42.html") %>">Software Features</a></li>
</ul>
</li>--%>
<li><a href="<%=ResolveUrl("~/faqs.html") %>">FAQs</a></li>
<li><a href="#">Highlights</a>
<ul>
<li><a href="<%=ResolveUrl("~/astrology/highlights/a-natal-glimpse/24-43.html") %>">A Natal Glimpse</a></li>
<li><a href="<%=ResolveUrl("~/astrology/highlights/natal-features/25-44.html") %>">Natal Features</a></li>
<li><a href="<%=ResolveUrl("~/astrology/highlights/a-horary-glimpse/26-45.html") %>">A Horary Glimpse</a></li>
<li><a href="<%=ResolveUrl("~/astrology/highlights/horary-features/27-46.html") %>">Horary Features</a></li>
</ul>
</li>
<li><a href="<%=ResolveUrl("~/compatibilitymatching.html") %>">Compatibility Matching</a></li>
<li><a href="<%=ResolveUrl("~/freehoroscope.html") %>">Free Horoscope</a></li>
<li><a href="<%=ResolveUrl("~/astrology/blog.html") %>">Blog</a></li>
</ul>
<ul class="ulmenuright" id="signinsignup_id" runat="server">
<%--<li><a href="<%=ResolveUrl("~/registration.html") %>"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
<li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>--%>
</ul>
</nav>
</div>

<%--<script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>--%>
<script type="text/javascript" src="<%=ResolveUrl("js/menu_jquery.min.js") %>"></script>
<script type="text/javascript" src="<%=ResolveUrl("js/menu_index.js") %>"></script>
<script type="text/javascript" src="<%=ResolveUrl("~/javascript/login.js") %>"></script>


  <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

 <script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsivemenubar.dlmenu.js") %>"></script>

    <script type="text/javascript">
    var $k=jQuery.noConflict();
			$k(function() {
				$k( '#dl-menu' ).dlmenu({
					animationClasses : { classin : 'dl-animate-in-2', classout : 'dl-animate-out-2' }
				});
			});
		</script>--%>
		