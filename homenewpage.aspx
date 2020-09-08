<%@ Page Language="C#" AutoEventWireup="true" CodeFile="homenewpage.aspx.cs" Inherits="homenewpage"  %>
<%@ PreviousPageType VirtualPath="~/astro_client.aspx" %> 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision
    </title>
    <meta charset="utf-8" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!--[if lt IE 9]>
       <script src="http://css3-mediaqueries-js.googlecode.com/svn/trunk/css3-mediaqueries.js"></script>
    <![endif]-->
    <!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tablethomenewpage.css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
  <%--  <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans" />
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />--%>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js" type="text/javascript"></script>
     <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript" src="javascript/main.js"></script>
    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <style type="text/css">
        nav select
        {
            display: none;
        }
        @media (max-width: 768px)
        {
            nav ul
            {
                display: none;
            }
            nav select
            {
                display: inline-block;
            }
        }
    </style>

    <script type="text/javascript">
	 // DOM ready
	 $(function() {
	   
      // Create the dropdown base
      $("<select />").appendTo("nav");
      
      // Create default option "Go to..."
      $("<option />", {
         "selected": "selected",
         "value"   : "",
         "text"    : "Go to..."
      }).appendTo("nav select");
      
      // Populate dropdown with menu items
      $("nav a").each(function() {
       var el = $(this);
       $("<option />", {
           "value"   : el.attr("href"),
           "text"    : el.text()
       }).appendTo("nav select");
      });
      
	   // To make dropdown actually work
	   // To make more unobtrusive: http://css-tricks.com/4064-unobtrusive-page-changer/
      $("nav select").change(function() {
        window.location = $(this).find("option:selected").val();
      });
	 
	 });
    </script>

    <script type="text/javascript">
        var popUpWin = 0;

        function getopen(pagename)
        {
        if(popUpWin)
               {
                    if(!popUpWin.closed) popUpWin.close();
               }

	        //popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
	        popUpWin = window.open(''+ pagename +'',null);

        }
        function getopen1(pagename)
        {
           window.parent.location.href="login.aspx";
        }
    </script>

</head>
<body id="body" <%--oncontextmenu="return false;"--%> onload="gridcall();">
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <%--Start Deepak comment following line on 19/06/2020--%>
        <%--<uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />--%>
        <%--End Deepak comment following line on 19/06/2020--%>
        <div class="middlecontainer">
            <div class="head_main" style="display: none;">
                <div class="head">
                    <div class="head_logo">
                        <img src="IMAGES/logo.jpg" alt="Astrology" title="Astrology" /></div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <div class="menu_main_lower" id="horarydiv" runat="server" style="display: block;">
                <div class="menu" id="nav">
                    <ul>
                        <li id='Li1' runat="server"><a href="#">Home</a></li>
                        <li id='Li9' runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>My Account</a></li>
                        <li id="Li2" runat="server"><a>Horary Yoga</a>
                            <ul>
                                <li><a href="#">Calculate Horary Yoga</a></li>
                                <li><a href="#">Calculate Karyasiddhi Yoga</a></li>
                            </ul>
                        </li>
                        <li id='Li3' runat="server"><a href="#">Nature Of Query</a></li>
                        <li id='Li7' runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>Horary Significator</a></li>
                        <li id='Li8' runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>Horary Knowledge</a></li>
                        <li id='Li13' runat="server"><a href="javascript:void(0);">Calculation</a>
                            <ul>
                                <li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Horary
                                    Calculation</a></li>
                                <li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Probable Query</a></li>
                            </ul>
                        </li>
                        <li id='Li6' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Horary")'
                            style='cursor: pointer'>Horary Illustration</a></li>
                        <li id='Li10' runat="server"><a href="#">About us</a> </li>
                        <li class="menu_last" id='Li11' runat="server"><a onclick='javascript:getopen1("login.aspx")'
                            style='cursor: pointer'>Log Out</a></li>
                    </ul>
                </div>
            </div>
            <div class="menu_main_lower" id="nataldiv" runat="server" style="display: block;">
                <div class="menu" id="nav">
                    <ul>
                        <li id="a1" runat="server"><a href="#">Home</a></li>
                        <li id="a9" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>My Account</a></li>
                        <li id="a6" runat="server"><a href="#">Natal Yoga</a></li>
                        <li id="a7" runat="server"><a href="#">Natal Predictive</a></li>
                        <li id="a3" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>Natal Significators</a></li>
                        <li id="a4" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>Natal Knowledge</a></li>
                        <li id="a5" runat="server"><a>Research Tool</a>
                            <ul>
                                <li><a onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Planets in Various Awastha’s in Varga’s </a></li>
                                <li><a onclick='javascript:getopen("ResearchTool_awastha.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Planets in Awastha’s – Planetary war etc</a></li>
                                <li><a onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")'
                                    style='cursor: pointer'>Planets in Rashi’s & House’s in Varga’s</a></li>
                                <li><a onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")'
                                    style='cursor: pointer'>Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                                <li><a onclick='javascript:getopen("researchtool_conjunction.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Conjunction of chosen Planets in Varga’s</a></li>
                                <li><a onclick='javascript:getopen("research_tool_any.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Conjunction of Planets – Number of Planets</a></li>
                                <li><a onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")'
                                    style='cursor: pointer'>Search the Single or Multiple Planets on Basis of Multiple
                                    Nakashtra/Constellation</a></li>
                                <li><a onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")'
                                    style='cursor: pointer'>Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                                <li><a onclick='javascript:getopen("researchtool_aspect.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Search for Aspects of Planet’s</a></li>
                                <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Search for Awastha of Planets in Dashamsha</a></li>
                                <li><a onclick='javascript:getopen("ResearchTool_Driskkan.aspx?usermail="+ document.getElementById("hdnuser").value)'
                                    style='cursor: pointer'>Driskkan Division</a></li>
                            </ul>
                        </li>
                        <li id="Li4" runat="server"><a href="#">Natal Calculation</a></li>
                        <li id="Li5" runat="server"><a href="#">Remedial</a></li>
                        <li id='Li12' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")'
                            style='cursor: pointer'>Natal Illustration</a></li>
                        <li id="a10" runat="server"><a href="#">About Us</a> </li>
                        <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")'
                            style='cursor: pointer'>Log Out</a></li>
                    </ul>
                </div>
            </div>
            <div class="mid_body_myaccount">
            <h1 class="mid_sec_query" id="clientqueryid" runat="server"></h1>
                <div class="mid_sec">
                    <div class="mid_over">
                    <div style="display:none;">
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="gulikaid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="dayofweekid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="dinmanid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="ratmanid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="sunsetpreid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="sunriseid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="sunsetid" runat="server">
                        </h2>
                        <h2 style="height: 20px; font-size: 0.80em; color: red;" id="sunrisenestid" runat="server">
                        </h2>
                        </div>
                        <div id="Div1" class="div_header">
                            <div class="d_header_1 h_filters">
                                <span class="filterss" style="display:none;">
                                    <asp:Label ID="lbusername" font-weight="600" Text="Astrologer Name :"
                                        runat="server">
                                    </asp:Label>
                                    <asp:Label ID="astname" font-weight="600" runat="server">
                                    </asp:Label>
                                </span><span class="filterss" style="display:none;">
                                    <asp:Label ID="Label3" font-weight="600" Text="Astrologer ID :"
                                        runat="server">
                                    </asp:Label>
                                    <asp:Label ID="astid" font-weight="600" runat="server">
                                    </asp:Label>
                                </span><span class="filterss">
                                    <asp:Label ID="Label5" font-weight="600" Text="Client Name :" runat="server">
                                    </asp:Label>
                                    <asp:Label ID="clientname" font-weight="600" runat="server">
                                    </asp:Label>
                                </span><span class="filterss">
                                    <asp:Label ID="Label4" font-weight="600" 
                                        Font-Size="11px" Text="Client ID :" runat="server">
                                    </asp:Label>
                                    <asp:Label ID="clientid" font-weight="600" 
                                        Font-Size="11px" runat="server"></asp:Label>
                                </span>
                            </div>
                        </div>
                        <div id="whitediv" class="div_curve_homenew">
                            <div id="Divgrid1" class="divg1homenewpage">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid" style="width: 520px;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="divg1homenewpage11" style="display: none;">
                                <asp:Label ID="label11" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                    ForeColor="Black" runat="server" Text="Birth"></asp:Label>
                                <asp:DropDownList ID="birth" runat="server" CssClass="drpo_homenew">
                                </asp:DropDownList>
                                <asp:Label ID="label1" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                    ForeColor="Black" Style="display: none;" runat="server" Text="Planet"></asp:Label>
                                <asp:DropDownList ID="planet" runat="server" Style="display: none;" CssClass="drpo_homenew">
                                </asp:DropDownList>
                                <asp:Label ID="label2" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                    ForeColor="Black" runat="server" Text="D.O.B / D.O.Q"></asp:Label>
                                <asp:TextBox ID="Texttodate" runat="server" CssClass="drpo_homenew"></asp:TextBox>
                                <img src='Image/cal1.gif' onclick="popUpCalendar(this, form1.Texttodate,'dd/mm/yyyy',event)"
                                    class="calendra_homenew" alt="" />
                            </div>
                            <div class="buttondiv">
                                <asp:LinkButton ID="ImageButton2" class="per_btn" runat="server" Style="width: 120px;
                                    display: none;">Crate new client</asp:LinkButton>
                                <asp:LinkButton ID="ImageButton1" class="per_btn hnpBtn" runat="server" Visible="true">Lagna Chart</asp:LinkButton>
                                <asp:LinkButton ID="calvargas" class="per_btn hnpBtn" runat="server">Continue</asp:LinkButton>
                                <asp:LinkButton ID="dp" class="per_btn hnpBtn" runat="server" Visible="true">Dasha Pattern</asp:LinkButton>
                                <asp:LinkButton ID="transit" class="per_btn hnpBtn" runat="server" Visible="true">Transit</asp:LinkButton>
                                <asp:LinkButton ID="ImageButton5" class="per_btn hnpBtn" runat="server" Style="display: none;">Chart Index</asp:LinkButton>
                            </div>
                        </div>
                        <div class="column1ho" id="rashiid" style="display: none;">
                            <div class="column-div1">
                                <span>
                                    <asp:Label ID="h1l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr1">
                                <span>
                                    <asp:Label ID="h1r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div2">
                                <span>
                                    <asp:Label ID="h2l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr2">
                                <span>
                                    <asp:Label ID="h2r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div3">
                                <span>
                                    <asp:Label ID="h3l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr3">
                                <span>
                                    <asp:Label ID="h3r" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div4">
                                <span>
                                    <asp:Label ID="h4l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr4">
                                <span>
                                    <asp:Label ID="h4r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div5">
                                <span>
                                    <asp:Label ID="h5l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr5">
                                <span>
                                    <asp:Label ID="h5r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div6">
                                <span>
                                    <asp:Label ID="h6l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr6">
                                <span>
                                    <asp:Label ID="h6r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div7">
                                <span>
                                    <asp:Label ID="h7l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr7">
                                <span>
                                    <asp:Label ID="h7r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div8">
                                <span>
                                    <asp:Label ID="h8l1" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-divr8">
                                <span>
                                    <asp:Label ID="h8r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div9">
                                <span>
                                    <asp:Label ID="h9l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr9">
                                <span>
                                    <asp:Label ID="h9r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div10">
                                <span>
                                    <asp:Label ID="h10l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr10">
                                <span>
                                    <asp:Label ID="h10r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div11">
                                <span>
                                    <asp:Label ID="h11l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr11">
                                <span>
                                    <asp:Label ID="h11r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div12">
                                <span>
                                    <asp:Label ID="h12l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr12">
                                <span>
                                    <asp:Label ID="h12r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <%--  <asp:Image id="img" runat="server" class="fixedratio" ImageUrl="~/IMAGES/7EV31VTV1astrology.jpg" />--%>
                            <figure class="fixedratio"></figure>
                        </div>
                    </div>
                    <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        <asp:Button ID="b1" runat="server" Text="HTML" onclick="b1_Click" />
      </ContentTemplate></asp:UpdatePanel>--%>
                </div>
            </div>
            <%--<div class="menu_mainf" >
	<div class="menuf" id="nav">
    	<ul>
        	<li id="a1l" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a href="#" class="menu_Selact">PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
             <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet In Avastha's</a></li>
                        <li><a  onclick='javascript:getopen("ResearchTool_awastha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet In Avastha's(Degree Wise)</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_rashi.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet In Rashi's</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conjunction.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Conjunction Of Planet's</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Conjunction Of Planet in Rashi's</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Nakshatra's & Planet's</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_aspect.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet Aspect's</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6l" runat="server"><a onclick='javascript:getopen("chartindex.aspx?clmail="+document.getElementById("Hclmail").value + "&clname="+document.getElementById("Hclname").value + "&astname="+document.getElementById("Hastname").value + "&astmail="+document.getElementById("Hastmail").value + "&usermail=" + document.getElementById("hdnuser").value)'  style='cursor:pointer'>CHART INDEX</a></li>
            <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
   </div>--%>
            <input type="hidden" runat="server" id="Hidden4" />
            <input type="hidden" runat="server" id="hiddendateformat" />
            <input type="hidden" runat="server" id="hdnastname" />
            <input type="hidden" runat="server" id="hdnastid" />
            <input type="hidden" runat="server" id="hdnclientid" />
            <input type="hidden" runat="server" id="Hclmail" />
            <input type="hidden" runat="server" id="Hclname" />
            <input type="hidden" runat="server" id="Hastmail" />
            <input type="hidden" runat="server" id="Hastname" />
            <input type="hidden" runat="server" id="Hnewdiffm" />
            <input type="hidden" runat="server" id="Hnewdiffm1" />
            <input type="hidden" runat="server" id="Hnewdiffv" />
            <input type="hidden" runat="server" id="Hnewdiffv1" />
            <input type="hidden" runat="server" id="hdngroup" />
            <input type="hidden" runat="server" id="hdngroup_u" />
            <input type="hidden" runat="server" id="hdnmobile" />
            <input type="hidden" runat="server" id="hdndob" />
            <input type="hidden" runat="server" id="hdnidob" />
            <input type="hidden" runat="server" id="hdnimoob" />
            <input type="hidden" runat="server" id="hdniyob" />
            <input type="hidden" runat="server" id="hdntob" />
            <input type="hidden" runat="server" id="hdnihob" />
            <input type="hidden" runat="server" id="hdnimob" />
            <input type="hidden" runat="server" id="hdncountry" />
            <input type="hidden" runat="server" id="hdnstate" />
            <input type="hidden" runat="server" id="hdndist" />
            <input type="hidden" runat="server" id="hdncity" />
            <input type="hidden" runat="server" id="hdnlatit" />
            <input type="hidden" runat="server" id="hdnlongit" />
            <input type="hidden" runat="server" id="hdntzo" />
            <input type="hidden" runat="server" id="hdnprof" />
            <input type="hidden" runat="server" id="hdnsex" />
            <input type="hidden" runat="server" id="hdncd" />
            <input type="hidden" runat="server" id="hdnuser" />
            <input type="hidden" runat="server" id="hdnasc" />
            <input type="hidden" runat="server" id="hdnretro0" />
            <input type="hidden" runat="server" id="hdnretro1" />
            <input type="hidden" runat="server" id="hdnretro2" />
            <input type="hidden" runat="server" id="hdnretro3" />
            <input type="hidden" runat="server" id="hdnretro4" />
            <input type="hidden" runat="server" id="hdnretro5" />
            <input type="hidden" runat="server" id="hdnretro6" />
            <input type="hidden" runat="server" id="hdnretro7" />
            <input type="hidden" runat="server" id="hdnretro8" />
            <input type="hidden" runat="server" id="hdnretro9" />
            <input type="hidden" runat="server" id="hdnretro10" />
            <input type="hidden" runat="server" id="hdnmoc" />
            <input type="hidden" runat="server" id="hdnr0" />
            <input type="hidden" runat="server" id="hdnr1" />
            <input type="hidden" runat="server" id="hdnr2" />
            <input type="hidden" runat="server" id="hdnr3" />
            <input type="hidden" runat="server" id="hdnr4" />
            <input type="hidden" runat="server" id="hdnr5" />
            <input type="hidden" runat="server" id="hdnr6" />
            <input type="hidden" runat="server" id="hdnr7" />
            <input type="hidden" runat="server" id="hdnr8" />
            <input type="hidden" runat="server" id="hdnr9" />
            <input type="hidden" runat="server" id="hdnr10" />
            <input type="hidden" runat="server" id="hdnrr1" />
            <input type="hidden" runat="server" id="hdnrr2" />
            <input type="hidden" runat="server" id="hdnrr3" />
            <input type="hidden" runat="server" id="hdnrr4" />
            <input type="hidden" runat="server" id="hdnrr5" />
            <input type="hidden" runat="server" id="hdnrr6" />
            <input type="hidden" runat="server" id="hdnrr7" />
            <input type="hidden" runat="server" id="hdnrr8" />
            <input type="hidden" runat="server" id="hdnrr9" />
            <input type="hidden" runat="server" id="hdnrr10" />
            <input type="hidden" runat="server" id="hdnprevret1" />
            <input type="hidden" runat="server" id="hdnprevret2" />
            <input type="hidden" runat="server" id="hdnprevret3" />
            <input type="hidden" runat="server" id="hdnprevret4" />
            <input type="hidden" runat="server" id="hdnprevret5" />
            <input type="hidden" runat="server" id="hdnprevret6" />
            <input type="hidden" runat="server" id="hdnprevret7" />
            <input type="hidden" runat="server" id="hdnprevret8" />
            <input type="hidden" runat="server" id="hdnprevret9" />
            <input type="hidden" runat="server" id="hdnprevret10" />
            <input type="hidden" runat="server" id="hdsunsetpre" />
            <input type="hidden" runat="server" id="hdsunrise" />
            <input type="hidden" runat="server" id="hdsunset" />
            <input type="hidden" runat="server" id="hdsunrisenext" />
            <input type="hidden" runat="server" id="hdnastmail" />
            <input type="hidden" runat="server" id="hdgulikatime" />
            <input type="hidden" runat="server" id="gulikaval" />
            <input type="hidden" runat="server" id="hdntzval" />
            <input type="hidden" runat="server" id="hdnquery" />
        </div>
         <%--Start Deepak comment following line on 19/06/2020--%>
        <%--<uc2:footer ID="footer1" runat="server" />--%>
        <%--End Deepak comment following line on 19/06/2020--%>
    </div>
    </form>
</body>
</html>
