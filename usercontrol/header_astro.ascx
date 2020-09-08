<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header_astro.ascx.cs"
    Inherits="usercontrol_header_astro" %>
<link rel="stylesheet" href="<%=ResolveUrl("~/usercontrol/css/style.css") %>">
<div class="topcontainer">
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
        <div class="welcomeBox" id="welcomeBoxId" runat="server"></div>
    </div>
</div>