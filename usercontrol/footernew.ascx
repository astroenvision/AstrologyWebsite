<%@ Control Language="C#" AutoEventWireup="true" CodeFile="footernew.ascx.cs" Inherits="usercontrol_footernew" %>

<link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/CSS/index.css") %>" />

<script type="text/javascript" src="<%=ResolveUrl("~/javascript/jquery.min.js") %>"></script>

<script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsiveslides.min.js") %>"></script>

<script type="text/javascript">
    $(function () {
    var $s3 = jQuery.noConflict();
      $s3("#slider3").responsiveSlides({
        auto: true,
        pager: false,
        nav: true,
        speed: 500,
        play: 1000,
		slideSpeed: 15000,        autoHeight: true,
		fadeSpeed: 2000,
        namespace: "callbacks2"
      });
    });
</script>

<script type="text/javascript">
    $(function () {
    var $s4 = jQuery.noConflict();
      $s4("#slider4").responsiveSlides({
        auto: true,
        pager: false,
        nav: true,
        speed: 500,
        play: 1000,
		slideSpeed: 15000,        autoHeight: true,
		fadeSpeed: 2000,
        namespace: "callbacks2"
      });
    });
</script>

<div class="bottomcontainer">
    <div class="bottomleft" style="display:none;">
        <h1 class="bottomleft_h1">
            <a href="javascript:void(0);">- Expert's Comment</a></h1>
        <div id="expertid" style="float: left;" runat="server">
        </div>
    </div>
    <div class="bottommiddle" style="display:none;">
        <a href="<%=ResolveUrl("~/videos.html") %>">
            <img src="<%=ResolveUrl("~/Image/astro_video.png") %>" width="100%" alt="astro_video"
                title="astro_video" /></a>
    </div>
    <div class="bottomright" style="display:none;">
        <h1 class="bottomright_h1">
            - Testimonials
        </h1>
        <div id="testimonialid" style="float: left;" runat="server">
        </div>
    </div>
    <div class="bottom_menu" style="display:none;">
        <ul id="navigation">
            <li><a href="<%=ResolveUrl("~/login.aspx") %>">Home</a></li>
            <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=10&articleid=34") %>">Services</a></li>
            <li><a href="<%=ResolveUrl("~/article/details.aspx?catid=20&articleid=40") %>">Consult an Astrologer</a></li> 
            <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=7&articleid=32") %>">About Us</a></li>
            <li><a href="<%=ResolveUrl("~/feedback.aspx") %>">Feedback</a></li>
            <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=8&articleid=33") %>">FAQs</a></li>
            <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=14&articleid=35") %>">Privacy Policy</a></li>
            <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=15&articleid=36") %>">Terms of Use</a></li>
        </ul>
    </div>
    <span class="bottom_logo">
        <img src="<%=ResolveUrl("~/Image/small_logo.png") %>" alt="Astrology" title="Astrology" /></span>
    <span class="bottom_copyright">Copyright @ 2016 Astro Envision. All Rights Reserved.
    </span><span class="bottom_copyright" style="font-size: 0.85em;">Designed by : 4C Plus
    </span>
</div>
