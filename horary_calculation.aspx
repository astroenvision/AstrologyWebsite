<%@ Page Language="C#" AutoEventWireup="true" CodeFile="horary_calculation.aspx.cs"
    Inherits="horary_calculation" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> /*****************************CHNAG***/
    <title>Hora | Astro Envision
    </title>
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletmyaccount.css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
       <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

    <script src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>

    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>--%>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/myaccount.js"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script type="text/javascript" language="javascript" src="javascript/horary_calculation.js"></script>
    <style>
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
<body id="body" <%--onload="accountuser();"--%>>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
        <div class="middlecontainer">
    <div class="head_main" style="display: none;">
        <div class="head">
            <div class="head_logo">
                <img src="IMAGES/logo.jpg" alt="Astro Envision" /></div>
            <div class="head_ad">
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    <div class="menu_main_lower" id="horarydiv" runat="server" style="display: none;">
        <div class="menu" id="nav">
            <ul>
                <li id='Li1' runat="server"><a href="#">Home</a></li>
                <li id='Li9' runat="server"><a href="#" class="menu_Selact">My Account</a></li>
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
                  <li><a onclick='javascript:gethorarycalculation();'style='cursor:pointer;'>Horary Calculation</a></li>
                 <li><a onclick='javascript:getprobablequery();'style='cursor:pointer;'>Probable Query</a></li>
            </ul>
            </li>
                <li id='Li12' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Horary")'
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
                <li id="a9" runat="server"><a href="#" class="menu_Selact">My Account</a></li>
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
                <li id='Li6' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")'
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
            <div id="dvdinmaan12" runat="server" class="divg" style="display: block;">
                <%--<table>
                <tbody>
                    <tr>
                        <td style="width: 600px; display: block;" align="left">
                            <table id="Divgrid1" runat="server" align="left" width="460px" height="0px" style="border: 1px;
                                solid #7daae3;" cellpadding="0" cellspacing="0">
                                <tbody>
                                    <tr>
                                        <td class="colum-td-head" colspan="16">
                                            Dinmaan
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td-subhead">
                                            Date
                                        </td>
                                        <td class="colum-td-subhead">
                                            23.06.2015
                                        </td>
                                        <td class="colum-td-subhead">
                                           23.06.2015
                                        </td>
                                         <td class="colum-td-subhead">
                                           23.06.2015
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -1
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -2
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -3
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -4
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -5
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -6
                                        </td>
                                        <td class="colum-td-subhead">
                                          Hora -7
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -8
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -9
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -10
                                        </td>
                                        <td class="colum-td-subhead">
                                            Hora -11
                                        </td>
                                        <td class="colum-td-subhead">
                                          Hora -12
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td-subhead">
                                            Day
                                        </td>
                                        <td class="colum-td-subhead">
                                           Sunrise -H:M:S
                                        </td>
                                        <td class="colum-td-subhead">
                                           Sunset -H:M:S
                                        </td>
                                        <td class="colum-td-subhead">
                                            Day Length - H:M:S
                                        </td>
                                        <td class="colum-td-subhead">
                                            Moon
                                        </td>
                                        <td class="colum-td-subhead">
                                            Saturn
                                        </td>
                                        <td class="colum-td-subhead">
                                            Jupiter
                                        </td>
                                        <td class="colum-td-subhead">
                                            Mars
                                        </td>
                                        <td class="colum-td-subhead">
                                            Sun
                                        </td>
                                        <td class="colum-td-subhead">
                                          Venus
                                        </td>
                                        <td class="colum-td-subhead">
                                           Mercury
                                        </td>
                                        <td class="colum-td-subhead">
                                           Moon
                                        </td>
                                        <td class="colum-td-subhead">
                                          Saturn
                                        </td>
                                        <td class="colum-td-subhead">
                                            Jupiter 
                                        </td>
                                        <td class="colum-td-subhead">
                                          Mars
                                        </td>
                                         <td class="colum-td-subhead">
                                          Sun
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td">
                                            <input type="text" enabled="false" disabled="" style="width: 200px;" class="dropdown_large_corr" align="left"
                                                value="HARI SHARMA" id="name_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" enabled="false" disabled="" style="width: 200px;" align="left"
                                                class="dropdown_large_corr" value="hshoradm@horary.com" id="pmail1_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr"
                                                value="info@harisharma.com" id="altmail_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="9958883955" id="mobno_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="01127867202" id="landno_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="24, KK aptt, Rohini" id="add1_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="Rohini" id="add2_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="Rohini" id="landmark_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="IN" id="country_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="110085" id="zip_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="pwd_0">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text1">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text2">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text3">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text4">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text5">
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>--%>
            </div>
            <br />
            <div id="dvratrimaan12" class="divg" runat="server" style="display: block;">
                <%--<table>
                <tbody>
                    <tr>
                        <td id="Td1" style="width: 600px; display: block;" align="left">
                            <table id="Table1" runat="server" align="left" width="460px" height="0px" style="border: 1px;
                                solid #7daae3;" cellpadding="0" cellspacing="0">
                                <tbody>
                                    <tr>
                                        <td class="colum-td-head" colspan="16">
                                            Ratrimaan
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td-head">
                                            Date
                                        </td>
                                        <td class="colum-td-head">
                                            23.06.2015
                                        </td>
                                        <td class="colum-td-head">
                                            23.06.2015
                                        </td>
                                        <td class="colum-td-head">
                                            23.06.2015
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -1
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -2
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -3
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -4
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -5
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -6
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -7
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -8
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -9
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -10
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -11
                                        </td>
                                        <td class="colum-td-head">
                                            Hora -12
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td-head">
                                            Day
                                        </td>
                                        <td class="colum-td-head">
                                            Sunrise -H:M:S
                                        </td>
                                        <td class="colum-td-head">
                                            Sunset -H:M:S
                                        </td>
                                        <td class="colum-td-head">
                                            Day Length - H:M:S
                                        </td>
                                        <td class="colum-td-head">
                                            Moon
                                        </td>
                                        <td class="colum-td-head">
                                            Saturn
                                        </td>
                                        <td class="colum-td-head">
                                            Jupiter
                                        </td>
                                        <td class="colum-td-head">
                                            Mars
                                        </td>
                                        <td class="colum-td-head">
                                            Sun
                                        </td>
                                        <td class="colum-td-head">
                                            Venus
                                        </td>
                                        <td class="colum-td-head">
                                            Mercury
                                        </td>
                                        <td class="colum-td-head">
                                            Moon
                                        </td>
                                        <td class="colum-td-head">
                                            Saturn
                                        </td>
                                        <td class="colum-td-head">
                                            Jupiter
                                        </td>
                                        <td class="colum-td-head">
                                            Mars
                                        </td>
                                        <td class="colum-td-head">
                                            Sun
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" class="dropdown_large_corr" align="left"
                                                value="HARI SHARMA" id="Text6">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" enabled="false" disabled="" style="width: 200px;" align="left"
                                                class="dropdown_large_corr" value="hshoradm@horary.com" id="Text7">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="info@harisharma.com" id="Text8">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="9958883955" id="Text9">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="01127867202" id="Text10">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="24, KK aptt, Rohini" id="Text11">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="Rohini" id="Text12">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="Rohini" id="Text13">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="IN" id="Text14">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="110085" id="Text15">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text16">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text17">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text18">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text19">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text20">
                                        </td>
                                        <td class="colum-td">
                                            <input type="text" style="width: 200px;" align="left" class="dropdown_large_corr" ;=""
                                                value="hs17121959" id="Text21">
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>--%>
            </div>
            <br />
            <div id="dvdinmaan36" runat="server" class="divg" style="display: block;">
            </div>
            <br />
            <div id="dvratrimaan36" runat="server" class="divg" style="display: block;">
            </div>
        </div>
    </div>
    <input type="hidden" runat="server" id="Hidden1" />
    <input type="hidden" runat="server" id="Hidden9" />
    <input type="hidden" runat="server" id="hdnas" />
    <input type="hidden" runat="server" id="hdnasn" />
    <input type="hidden" runat="server" id="hdncat" />
    <input type="hidden" runat="server" id="hdnuser" />
    <input type="hidden" runat="server" id="hdsunsetpre" />
    <input type="hidden" runat="server" id="hdsunrise" />   
    <input type="hidden" runat="server" id="hdsunset" />   
    <input type="hidden" runat="server" id="hdnsunrisenext" />
    <input type="hidden" runat="server" id="Hastid" />   
    <input type="hidden" runat="server" id="hdntob" />   
    <input type="hidden" runat="server" id="hdndob" />   
    <input type="hidden" runat="server" id="hdncity" /> 
    <input type="hidden" runat="server" id="hdnquery" />
    </div>
        <uc2:footer ID="footer1" runat="server" />  
    </div>
    </form>
</body>
</html>
