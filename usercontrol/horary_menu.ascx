<%@ Control Language="C#" AutoEventWireup="true" CodeFile="horary_menu.ascx.cs" Inherits="responsive_dropdown_menu_horary_menu" %>
<link rel="stylesheet" href="<%=ResolveUrl("css/style.css") %>">
<div class="topcontainer">
<nav id="cssmenu" style="margin-top: 5px;">
<%--<div class="logo"><a href="index.html">Responsive </a></div>--%>
<div id="head-mobile"></div>
<div class="button"></div>
<ul id="horarymenuid" runat="server">
    <%--<li><a href="#">My Account</a></li>--%>
    <%--<li><a href="<%=ResolveUrl("~/index.html") %>">Home</a></li>
    <li><a href="#">Horary Yoga</a>
        <ul>
            <li><a href="#">Calculate Horary Yoga</a></li>
            <li><a href="#">Calculate Karyasiddhi Yoga</a></li>
        </ul>
    </li>
     <li><a href="#">Nature Of Query</a></li>
    <li><a onclick="javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
        style="cursor: pointer;">Horary Significator</a></li>
    <li><a onclick="javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
        style="cursor: pointer;">Horary Knowledge</a></li>
        <li><a href="javascript:void(0);">Calculation</a>
        <ul>
            <li><a href="#">Horary Calculation</a></li>
            <li><a href="#">Probable Query</a></li>
        </ul>
    </li>
    <li><a onclick="javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)"
        style="cursor: pointer">Horary Illustration</a></li>
    <li><a href="<%=ResolveUrl("~/aboutus.html") %>">About us</a></li>
    <li><a onclick="javascript:getopen1(&quot;login.aspx&quot;)" style="cursor: pointer;">
        Log Out</a></li>--%>
</ul>
</nav>
</div>

<%--<script type="text/javascript" src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>--%>
<script type="text/javascript" src="<%=ResolveUrl("js/menu_jquery.min.js") %>"></script>
<script type="text/javascript" src="<%=ResolveUrl("js/menu_index.js") %>"></script>


    
    <script type="text/javascript"> 
        function LogOut(){ 
            '<%Session["endusermail"] = null; %>';
            '<%Session["name"] = null; %>';
            '<%Session["gender"] = null; %>';
            '<%Session["myquery"] = null; %>';
            window.parent.location.href="login.aspx";
        } 
    </script> 