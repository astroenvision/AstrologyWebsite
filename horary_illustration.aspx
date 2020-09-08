<%@ Page Language="C#" AutoEventWireup="true" CodeFile="horary_illustration.aspx.cs"
    Inherits="horary_illustration" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Horary Illustrations | Astro Envision
    </title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css">
    <link type="text/css" rel="stylesheet" href="CSS/tabletmyaccount.css">
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

    <script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>

    <script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>--%>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/horary_illustration.js"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>

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

    <script type="text/javascript" language="javascript">
	    // DOM ready
	    $(function () {
	        // Create the dropdown base
	        $("<select />").appendTo("nav");

	        // Create default option "Go to..."
	        $("<option />", {
	            "selected": "selected",
	            "value": "",
	            "text": "Go to..."
	        }).appendTo("nav select");

	        // Populate dropdown with menu items
	        $("nav a").each(function () {
	            var el = $(this);
	            $("<option />", {
	                "value": el.attr("href"),
	                "text": el.text()
	            }).appendTo("nav select");
	        });

	        // To make dropdown actually work
	        // To make more unobtrusive: http://css-tricks.com/4064-unobtrusive-page-changer/
	        $("nav select").change(function () {
	            window.location = $(this).find("option:selected").val();
	        });

	    });
    </script>

    <script type="text/javascript">
	    var popUpWin = 0;
	    function getopen(pagename) {

	        if (popUpWin) {
	            if (!popUpWin.closed) popUpWin.close();
	        }

	        //popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
            window.location.href = ""+pagename+""; 
	    }
	    function getopen1(pagename) {
	        window.parent.location.href = "login.aspx";
	    }

    </script>

</head>
<%--<body id="body" oncontextmenu="return false;" onload="accountuser();">--%>
<body id="body" onload="accountuser();">
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
        <div class="middlecontainer">
            <div class="menu_main_lower" id="horarydiv" runat="server" style="display: none;">
                <div class="menu" id="nav">
                    <ul>
                        <li id='Li1' runat="server"><a href="#">Home</a></li>
                        <li id='Li9' runat="server"><a href="#">My Account</a></li>
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
                                <li><a href="#">Horary Calculation</a></li>
                                <li><a href="#">Probable Query</a></li>
                            </ul>
                        </li>
                        <li id='Li6' runat="server"><a class="menu_Selact" onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Horary")'
                            style='cursor: pointer'>Horary Illustration</a></li>
                        <li id='Li10' runat="server"><a href="#">About us</a> </li>
                        <li class="menu_last" id='Li11' runat="server"><a onclick='javascript:getopen1("login.aspx")'
                            style='cursor: pointer'>Log Out</a></li>
                    </ul>
                </div>
            </div>
            <div class="menu_main_lower" id="nataldiv" runat="server" style="display: none;">
                <div class="menu" id="nav">
                    <ul>
                        <li id="a1" runat="server"><a href="#">Home</a></li>
                        <li id="a9" runat="server"><a href="#">My Account</a></li>
                        <li id="a6" runat="server"><a href="#"'">Natal Yoga</a></li>
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
                        <li id='Li12' runat="server"><a class="menu_Selact" onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")'
                            style='cursor: pointer'>Natal Illustration</a></li>
                        <li id="a10" runat="server"><a href="#">About Us</a> </li>
                        <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")'
                            style='cursor: pointer'>Log Out</a></li>
                    </ul>
                </div>
            </div>
            <div class="mid_body_myaccount">
                <div class="mid_sec">
                    <div class="mid_over_myaccount">
                        <div id="Div2" class="div_header">
                            <div class="d_header_1 h_filtersc">
                                <div style="margin-bottom: 10px; display: none;">
                                    <asp:Label ID="Label3" font-weight="600" Font-Size="11px" Text="Astrologer ID :"
                                        runat="server">
                                    </asp:Label>
                                    <asp:Label ID="astid" font-weight="600" Font-Size="11px" runat="server">
                                    </asp:Label>
                                </div>
                                <div class="illustration_fltr">
                                    <div class="illustration_grp">
                                        <asp:Label ID="Label1" runat="server" Text="Client Group :" CssClass="illustration_grplbl"></asp:Label>
                                        <asp:DropDownList ID="clgroup" CssClass="drpo_homenew" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="illustration_adgrp">
                                        <asp:Label ID="cag" runat="server" Text="Admin Group :" CssClass="illustration_grplbl"></asp:Label>
                                        <asp:DropDownList ID="adgrp" CssClass="drpo_homenew" runat="server" Style="display: inline-block;">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="illustration_srchby">
                                        <asp:Label ID="seby" runat="server" Text="Search By :" CssClass="illustration_grplbl"></asp:Label>
                                        <asp:DropDownList ID="sebyd" CssClass="drpo_homenew" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="illustration_srchbtn">
                                        <asp:TextBox ID="sebyt" Style="display: none; font-size: 12px; padding: 4px 5px;
                                            border-radius: 4px;" runat="server" Width="65%" CssClass="textbox" Font-Names="Rod"
                                            Font-Overline="False" Font-Strikeout="False" ForeColor="Black" placeholder="Type here..."></asp:TextBox>
                                        <asp:LinkButton ID="sebyb" class="per_btn1_2" runat="server">Search</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="whitediv2" class="div_curve1m" style="max-height: 150px;">
                            <div id="Divgrid2" class="divg">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid2" style="width: 100%;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="Divgrid1" class="divg1homenewpage div-scroll_vargas" style="display: none;">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid" style="width: 550px;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <div>
                            <table>
                                <tr>
                                    <td style="display: none;" class="new_font2" id="td1" runat="server">
                                        Client Name :
                                    </td>
                                    <td class="latter">
                                        <asp:Label ID="DropDownList1" runat="server" Width="100%" CssClass="textbox" Style="display: none;"></asp:Label>
                                    </td>
                                    <td style="display: none;" class="new_font2" id="td2" runat="server">
                                        Client Mail :
                                    </td>
                                    <td class="latter">
                                        <asp:Label ID="DropDownList2" runat="server" Width="100%" CssClass="textbox" Style="display: none;"></asp:Label>
                                    </td>
                                    <td style="display: none;" class="new_font2" id="td3" runat="server">
                                        Query :
                                    </td>
                                    <td class="latter">
                                        <asp:DropDownList ID="cat" runat="server" Width="100%" CssClass="textbox" Style="display: none;">
                                        </asp:DropDownList>
                                    </td>
                                    <td class="latter">
                                        <asp:TextBox ID="catn" runat="server" Width="100%" placeholder="Enter Your Query"
                                            CssClass="textbox" Style="display: none;"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="mar_div_chart" style="float: left; width: 37%; margin-left: 0px;">
                            <div>
                                <div style="display: none; margin-left: 68px;" id="ch" runat="server">
                                    <asp:Label ID="label11" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                        ForeColor="Black" runat="server" Text="Chart"></asp:Label>
                                    <asp:DropDownList ID="chart" runat="server" CssClass="drpo_homenew">
                                    </asp:DropDownList>
                                </div>
                                <div style="display: none; float: left;" id="lb" runat="server">
                                    <asp:Label ID="Label1d01" runat="server" ForeColor="Black" CssClass="varga_lbl">
                                    </asp:Label>
                                </div>
                                <div class="columnd01hi" id="rashiidd01" style="display: none;">
                                    <div class="column-div1">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h1l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr1">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h1rd01" runat="server" Text="">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div2">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h2l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr2">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h2rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div3">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h3l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr3">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h3rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div4">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h4l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr4">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h4rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div5">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h5l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr5">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h5rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div6">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h6l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr6">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h6rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div7">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h7l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr7">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h7rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div8">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h8l1d01" runat="server" Text="">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-divr8">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h8rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div9">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h9l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr9">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h9rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div10">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h10l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr10">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h10rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div11">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h11l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr11">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h11rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div12">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h12l1d01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divr12">
                                        <span style="font-size: 11px;">
                                            <asp:Label ID="h12rd01" runat="server" Text="">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <figure class="fixedratio"></figure>
                                </div>
                            </div>
                        </div>
                        <div style="float: left; width: 100%;">
                            <td>
                                <FCKeditorV2:FCKeditor ID="explanation_text" runat="server" BasePath="~/fckeditor/"
                                    Height="400px" ToolbarStartExpanded="false">
                                </FCKeditorV2:FCKeditor>
                                <%--<asp:TextBox ID="explanation_text" runat="server" TextMode="MultiLine" 
         Width="370px" Height="100px"  ></asp:TextBox>--%>
                            </td>
                        </div>
                        <%---- <asp:ImageButton ID="groupasfamily" runat="server" style="visibility:hidden" ImageUrl="~/Image/group.png" CssClass="button" /> ----%>
                    </div>
                    <table>
                        <tr>
                            <td>
                                <asp:LinkButton ID="se" class="per_btn1_2" Style="margin-left: 250px; display: none;"
                                    runat="server">Save</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="up" class="per_btn1_2" Style="margin-left: 250px; display: none;"
                                    runat="server">Update</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="de" class="per_btn1_2" Style="margin-left: 250px; display: none;"
                                    runat="server">Delete</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <%-- <div class="menu_mainf" >
	<div class="menuf" id="nav">
    	<ul>
        	<li id="a1l" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a onclick='javascript:getopen("homenewpage.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
             <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul>
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Various Awastha’s in Varga’s  </a></li>
                        <li><a  onclick='javascript:getopen("ResearchTool_awastha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Planets in Rashi’s & House’s in Varga’s</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conjunction.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("research_tool_any.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of Planets – Number of Planets</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Search the  Single or Multiple Planets on Basis of Multiple Nakashtra/Constellation</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_aspect.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Aspects of Planet’s</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a onclick='javascript:getopen("ResearchTool_Driskkan.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Driskkan Division</a></li>
            </ul>
            </li>
           
            <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a href="#" class="menu_Selact">MY ACCOUNT</a></li>    
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
    </div>--%>
            <input type="hidden" runat="server" id="hdnastname" />
            <input type="hidden" runat="server" id="hdnastid" />
            <input type="hidden" runat="server" id="hdnclientid" />
            <input type="hidden" runat="server" id="Hclmail" />
            <input type="hidden" runat="server" id="Hclname" />
            <input type="hidden" runat="server" id="Hastmail" />
            <input type="hidden" runat="server" id="Hastname" />
            <input type="hidden" runat="server" id="Hidden1" />
            <input type="hidden" runat="server" id="Hidden9" />
            <input type="hidden" runat="server" id="hdnas" />
            <input type="hidden" runat="server" id="hdnasn" />
            <input type="hidden" runat="server" id="Hiddencons" />
            <input type="hidden" runat="server" id="Hidden5d01" />
            <input type="hidden" runat="server" id="hdnid" />
            <input type="hidden" runat="server" id="hdngroupunder" />
            <input type="hidden" runat="server" id="hdnuser" />
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
