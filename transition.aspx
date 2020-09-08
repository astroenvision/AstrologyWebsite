<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="transition.aspx.cs"
    Inherits="transition" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision
    </title>
    <meta content="" charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!--[if lt IE 9]>
     <script src="http://css3-mediaqueries-js.googlecode.com/svn/trunk/css3-mediaqueries.js"></script>
    <![endif]-->
    <!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <link type="text/css" rel="stylesheet" href="CSS/main.css">
    <link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css">
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="Stylesheet" href="css/astrocss.css" type="text/css" />--%>
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/transition.js"></script>

    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>

    <%--<script type="text/javascript" language="javascript" src="javascript/main.js"></script>--%>
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
            popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
        }
        function getopen1(pagename)
        {
            window.parent.location.href="login.aspx";
        }
    </script>

</head>
<body id="body" onload="vargas();">
    <form id="form1" runat="server">
    <div class="maincontainer">
    <uc1:header ID="header1" runat="server" />
    <uc4:horarymenubar ID="horarymenubar1" runat="server" />
    <div class="middlecontainer" style="padding: 1% 0% 1% 0%;">
    <div class="head_main" style="display:none;">
        <div class="head">
            <div class="head_logo">
                <img src="IMAGES/logo.jpg" /></div>
            <div class="head_ad">
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    <div class="menu_main_lower" id="horarydiv" runat="server" style="display:none;">
        <div class="menu" id="nav">
            <ul>
                <li id='Li1' runat="server"><a href="#">Home</a></li>
                <li id='Li9' runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'>My Account</a></li>
                <li id="Li2" runat="server"><a>Horary Yoga</a>
                    <ul>
                        <li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate
                            Horary Yoga</a></li>
                        <li><a onclick='javascript:return calculateyogas(id)' style='cursor: pointer'>Calculate
                            Karyasiddhi Yoga</a></li>
                    </ul>
                </li>
                <li id='Li3' runat="server"><a onclick='javascript:return openhorcomb();' style='cursor: pointer'>
                    Nature Of Query</a></li>
                <li id='Li7' runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'>Horary Significator</a></li>
                <li id='Li8' runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'>Horary Knowledge</a></li>
                <li id='Li13' runat="server"><a href="javascript:void(0);">Calculation</a>
                    <ul>
                        <li><a href="#">Horary Calculation</a></li>
                        <li><a href="#">Probable Query</a></li>
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
    <div class="menu_main_lower" id="nataldiv" runat="server" style="display:none;">
        <div class="menu" id="nav">
            <ul>
                <li id="a1" runat="server"><a href="#">Home</a></li>
                <li id="a9" runat="server"><a href="#">My Account</a></li>
                <li id="a6" runat="server"><a onclick='javascript:return yoga()' style='cursor: pointer'>
                    Natal Yoga</a></li>
                <li id="a7" runat="server"><a onclick='javascript:return searchdataopt()' style='cursor: pointer'>
                    Natal Predictive</a></li>
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
                <li id="Li4" runat="server"><a onclick='javascript:return openastrocalcu()' style='cursor: pointer'>
                    Natal Calculation</a></li>
                <li id="Li5" runat="server"><a onclick='javascript:return chartindexdata()' style='cursor: pointer'>
                    Remedial</a></li>
                <li id='Li12' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")'
                    style='cursor: pointer'>Natal Illustration</a></li>
                <li id="a10" runat="server"><a href="#">About Us</a> </li>
                <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")'
                    style='cursor: pointer'>Log Out</a></li>
            </ul>
        </div>
    </div>
    <div class="mid_body_myaccount">
        <div class="mid_sec">
            <div class="mid_over">
            <div style="display:none;">
                <h2 style="height: 20px; font-size: 0.80em; color: red;" id="gulikaid" runat="server">
                </h2>
                <h2 style="height: 20px; font-size: 0.80em; color: red;" id="ascendantid" runat="server">
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
                <div id="Div2" class="div_header">
                    <div class="d_header_1 h_filters">
                        <span class="filterss">
                            <asp:Label ID="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" Text="Astrologer Name :" runat="server">
                            </asp:Label>
                            <asp:Label ID="astname" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss">
                            <asp:Label ID="Label3" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" Text="Astrologer ID :" runat="server">
                            </asp:Label>
                            <asp:Label ID="astid" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss">
                            <asp:Label ID="Label5" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" Text="Client Name :" runat="server">
                            </asp:Label>
                            <asp:Label ID="clientname" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss">
                            <asp:Label ID="Label4" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" Text="Client ID :" runat="server">
                            </asp:Label>
                            <asp:Label ID="clientid" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" runat="server"></asp:Label>
                        </span>
                    </div>
                </div>
                <div id="whitediv" class="div_curve_vargas" style="width: 30%; height: auto;">
                    <div id="Divgrid1" class="divg1homenewpage div-scroll_vargas" style="width: 300px;">
                        <div>
                            Inner Birth Chart
                        </div>
                        <table>
                            <tr>
                                <td runat="server" id="hdsviewgrid" style="width: 150px;" align="left">
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="Divgrid2" class="divg1homenewpage div-scroll_vargas" style="width: 300px;">
                        <div>
                            Outer Transit Chart
                        </div>
                        <table>
                            <tr>
                                <td runat="server" id="hdsviewgrid2" style="width: 150px;" align="left">
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="mar_div_chart">
                    <div>
                        <div style="margin-left: 95px; float: left;">
                            Inner Birth Chart - Outer Transit Chart
                        </div>
                        <div class="columnd01transit" id="rashiidd01">
                            <div class="column-div1t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr1t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1rd01" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div1tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr1tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1rd01t" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div2t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr2t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div2tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr2tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div3t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr3t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div3tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr3tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div4t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr4t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div4tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr4tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div5t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr5t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div5tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr5tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div6t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr6t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div6tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr6tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div7t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr7t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div7tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr7tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div8t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8l1d01" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-divr8t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div8tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8l1d01t" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-divr8tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div9t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr9t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div9tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr9tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div10t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr10t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div10tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr10tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div11t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr11t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div11tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr11tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div12t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12l1d01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr12t">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12rd01" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div12tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12l1d01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr12tt">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12rd01t" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <figure class="fixedratiotransit"></figure>
                        </div>
                    </div>
                </div>
                <div style="margin-left: 50px; float: left;">
                    Time Tool</div>
                <div id="tt" class="div_curve_vargas" style="float: left; width: 20%; margin:0% 0% 0% 1%">
                    <div style="width: 50%; float: left;">
                        <b>10 Year</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="yearp10" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="yearm10" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Year</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="yearp1" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="yearm1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Month</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="monthp1" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="monthm1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Week</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="weekp1" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="weekm1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Day</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="dayp1" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="daym1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>10 Hours</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="hrp10" runat="server" Text="+" text-align="right;" Width="20px" /><asp:Button
                            ID="hrm10" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Hour </b>
                    </div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="hrp1" runat="server" Text="+" Width="20px" /><asp:Button ID="hrm1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>10 Minutes </b>
                    </div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="mip10" runat="server" Text="+" Width="20px" /><asp:Button ID="mim10" Text="-"
                            runat="server" Width="20px" />
                    </div>
                    <div style="width: 50%; float: left;">
                        <b>1 Minute</b></div>
                    <div style="width: 50%; float: left;">
                        <asp:Button ID="mip1" runat="server" Text="+" Width="20px" /><asp:Button ID="mim1" Text="-" runat="server" Width="20px" />
                    </div>
                    <div style="width: 100%; float: left;">
                        <asp:Label ID="wday" runat="server" Text="" Style="font-size: 1.5em !important;"></asp:Label>
                        <asp:TextBox ID="ttt" runat="server" Style="margin:2% 0% 0% 0%; width:100%;" Enabled="false"></asp:TextBox>
                        <%--  <img id="cal" runat="server" src='Image/cal1.gif' onclick="popUpCalendar(this, form1.dob,'dd/mm/yyyy',event)" height="14"
                            width="14" style="width: 14px" alt="" />--%>
                        <asp:Button ID="sod" Text="Edit Date" CssClass="per_btn hnpBtn" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--      
    <div class="menu_mainf" >
	<div class="menuf" id="nav">
                <ul>
        	<li id='a1l' runat="server"><a href="#" >HOME</a></li>
        	<li id='a2l' runat="server"><a href="#" class="menu_Selact">PREDICTIVE SUPPORT</a></li>
            <li id='a3l' runat="server"> <a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id='a4l' runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
            <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id='a6l' runat="server"><a onclick='javascript:getopen("chartindex.aspx?clmail="+document.getElementById("Hclid").value + "&clname="+document.getElementById("Hclname").value + "&astname="+document.getElementById("Hastname").value + "&astmail="+document.getElementById("Hastid").value + "&usermail=" + document.getElementById("hdnuser").value)'  style='cursor:pointer'>CHART INDEX</a></li>
            <li id='a7l' runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id='a8l' runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id='a9l' runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>   
            <li id='a10l' runat="server"><a href="#">ABOUT US</a> </li>
            <li id='a11l' runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    
     </div></div>--%>
    <input type="hidden" runat="server" id="hdnuser" />
    <input type="hidden" runat="server" id="Hidden4" />
    <input type="hidden" runat="server" id="Hidden5" />
    <input type="hidden" runat="server" id="Hidden1" />
    <input type="hidden" runat="server" id="Hidden2" />
    <input type="hidden" runat="server" id="Hidden5d01" />
    <input type="hidden" runat="server" id="Hastname" />
    <input type="hidden" runat="server" id="Hastid" />
    <input type="hidden" runat="server" id="Hclname" />
    <input type="hidden" runat="server" id="Hclid" />
    <input type="hidden" runat="server" id="Hiddencons" />
    <input type="hidden" runat="server" id="hdngroup" />
    <input type="hidden" runat="server" id="hdndob" />
    <input type="hidden" runat="server" id="hdntob" />
    <input type="hidden" runat="server" id="hdncountry" />
    <input type="hidden" runat="server" id="hdnstate" />
    <input type="hidden" runat="server" id="hdndist" />
    <input type="hidden" runat="server" id="hdncity" />
    <input type="hidden" runat="server" id="hdngroup_u" />
    <input type="hidden" runat="server" id="hdnprof" />
    <input type="hidden" runat="server" id="hdnsex" />
    <input type="hidden" runat="server" id="hdnmobile" />
    <input type="hidden" runat="server" id="username" />
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
    <input type="hidden" runat="server" id="hdnr11" />
    <input type="hidden" runat="server" id="hdnr12" />
    <input type="hidden" runat="server" id="hdnidateob" />
    <input type="hidden" runat="server" id="hdnimonthob" />
    <input type="hidden" runat="server" id="hdniyearob" />
    <input type="hidden" runat="server" id="hdnihourob" />
    <input type="hidden" runat="server" id="hdniminuteob" />
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
    <input type="hidden" runat="server" id="Hidden3" />
    <input type="hidden" runat="server" id="Hidden6" />
    <input type="hidden" runat="server" id="Hidden7" />
    <input type="hidden" runat="server" id="Hidden8" />
    <input type="hidden" runat="server" id="Hidden9" />
    <input type="hidden" runat="server" id="Hidden10" />
    <input type="hidden" runat="server" id="Hidden11" />
    <input type="hidden" runat="server" id="Hidden12" />
    <input type="hidden" runat="server" id="Hidden13" />
    <input type="hidden" runat="server" id="Hidden14" />
    <input type="hidden" runat="server" id="hdnlongit" />
    <input type="hidden" runat="server" id="hdnlatit" />
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
    <input type="hidden" runat="server" id="hdntzo" />
    <input type="hidden" runat="server" id="hdntzval" />
    <input type="hidden" runat="server" id="hdsunsetpre" />
    <input type="hidden" runat="server" id="hdsunrise" />
    <input type="hidden" runat="server" id="hdsunset" />
    <input type="hidden" runat="server" id="hdsunrisenext" />
    <input type="hidden" runat="server" id="hdgulikatime" />
    <input type="hidden" runat="server" id="gulikaval" />
    </div>
     <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
