<%@ Control Language="C#" AutoEventWireup="true" CodeFile="headernew.ascx.cs" Inherits="usercontrol_headernew" %>


<link rel="stylesheet" type="text/css" href="<%=ResolveUrl("~/css/responsivemenubar.css") %>" />

 <script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsivemenubar.custom.js") %>"></script>
    
    
<div class="topcontainer">
    <%--<div class="main_menucss">
        <img src="<%=ResolveUrl("~/Image/menu.png") %>" alt="Menu" title="Menu" />
    </div>--%>
    
    <%-- <div class="container demo-2">--%>
        <!-- Codrops top bar -->
        <div class="main clearfix" style="float:left; display:none;">
            <div class="column_menu">
                <div id="dl-menu" class="dl-menuwrapper">
                    <button class="dl-trigger">
                        Open Menu</button>
                    <ul class="dl-menu" id="menubarid" runat="server">
                        <%--<li><a href="<%=ResolveUrl("~/login.aspx") %>">Home</a></li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=10&articleid=34") %>">Services</a></li>
                        <li><a href="<%=ResolveUrl("~/article/details.aspx?catid=20&articleid=40") %>">Consult an Astrologer</a> </li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=7&articleid=32") %>">About Us</a> </li>
                        <li><a href="<%=ResolveUrl("~/feedback.aspx") %>">Feedback</a> </li>
                        <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=8&articleid=33") %>">FAQs</a> </li>
                        <li><a href="<%=ResolveUrl("~/your_queries.aspx") %>">Your Queries</a> </li>--%>
                    </ul>
                </div>
                <!-- /dl-menuwrapper -->
            </div>
        </div>
    <%-- </div>--%>
    <!-- /container -->
    
    <div class="large_logo" style="width:94%; text-align:center;">
       
            <img src="<%=ResolveUrl("~/Image/large_logo.png") %>" alt="Astro Envision" title="Astro Envision" />
    </div>
    <div class="socialmedia_icons_main" style="display:none;">
        <div id="myqueryid" runat="server" class="myquerycss">
        </div>
        <ul class="soc">
            <li><a class="soc-facebook" href="https://www.facebook.com/Astro-Envision-1702561730064187/" target="_blank"></a></li>
            <li><a class="soc-twitter" href="https://twitter.com/AstroEnvision" target="_blank"></a></li>
            <li><a class="soc-google" href="https://plus.google.com/u/1/103724043345926047151" target="_blank"></a></li>
            <li><a class="soc-linkedin" href="https://www.linkedin.com/in/astro-envision-049454124" target="_blank"></a></li>
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
       
       <%-- <div id="welcomeid" runat="server" class="welcomecss">
            <h3 id="welcomeguestid" runat="server">
            </h3>
            &nbsp;
            <asp:LinkButton ID="lblogout" runat="server" OnClick="lblogout_Click">Log Out</asp:LinkButton>
        </div>--%>
    </div>
</div>

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsivemenubar.dlmenu.js") %>"></script>

    <script type="text/javascript">
    var $k=jQuery.noConflict();
			$k(function() {
				$k( '#dl-menu' ).dlmenu({
					animationClasses : { classin : 'dl-animate-in-2', classout : 'dl-animate-out-2' }
				});
			});
		</script>
