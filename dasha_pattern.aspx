<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dasha_pattern.aspx.cs" Inherits="dasha_pattern"
    EnableEventValidation="false" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css">
    <link type="text/css" rel="stylesheet" href="CSS/tabletmyaccount.css">
    <link href="CSS/GridviewScroll.css" rel="stylesheet" type="text/css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />

    <script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>

    <script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/dasha_pattern.js"></script>

    <script src="Scripts/gridviewScroll.min.js" type="text/javascript"></script>

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

	        popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

	    }
	    function getopen1(pagename) {
	        window.parent.location.href = "login.aspx";
	    }

    </script>

</head>
<body id="body">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
    <uc1:header ID="header1" runat="server" />
    <uc4:horarymenubar ID="horarymenubar1" runat="server" />
    <div class="middlecontainer" style="padding: 1% 0% 1% 0%;">
    <div class="head_main" style="display:none;">
        <div class="head">
            <div class="head_logo">
                <img src="IMAGES/logo.jpg" alt="logo" /></div>
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
                        <li><a href="#">Horary Calculation</a></li>
                        <li><a href="#">Probable Query</a></li>
                    </ul>
                </li>
                <li id='Li12' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value)+ "&gropunder=" + "Horary")'
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
                <li id="a9" runat="server"><a href="#" class="menu_Selact">My Account</a></li>
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
                <li id='Li6' runat="server"><a onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value)+ "&gropunder=" + "Natal")'
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
                <div id="whitediv" class="div_curve1">
                    <div class="d_header_3">
                        <p>
                            <asp:Label ID="bod" runat="server" Text="" Style="font-size: 16px !important;margin-left:24%; color:#F25E0A;"
                                CssClass="new_font2"></asp:Label>
                        </p>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <p style="margin-left: 20%;margin-top: 10px;font-weight: 600;">
                                    Choose :
                                    <asp:RadioButton ID="RadioButton1" Style="font-size: 14px !important;" CssClass="new_font2"
                                        AutoPostBack="true" runat="server" Text="Maha Dasha" OnCheckedChanged="RadioButton1_CheckedChanged" />
                                    <asp:RadioButton ID="RadioButton2" Style="font-size: 14px !important;" CssClass="new_font2"
                                        AutoPostBack="true" runat="server" Text="Antar Dasha" OnCheckedChanged="RadioButton2_CheckedChanged" />
                                    <asp:RadioButton ID="RadioButton3" Style="font-size: 14px !important;" CssClass="new_font2"
                                        AutoPostBack="true" runat="server" Text="Pratyantar Dasha" OnCheckedChanged="RadioButton3_CheckedChanged" />
                                    <asp:RadioButton ID="RadioButton4" Style="font-size: 14px !important;" CssClass="new_font2"
                                        AutoPostBack="true" runat="server" Text="Sookshma Dasha" OnCheckedChanged="RadioButton4_CheckedChanged" />
                                </p>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div class="loadingimage_yoga" id="img1" runat="server">
                            <img src="Image/preloader_transparent.gif" alt="hello" />
                        </div>
                        <div id="div1" runat="server" style="overflow: auto; height: 380px; margin:10px 0px 0px 0px;">
                            <%--<div id="grigdiv_data" class="g_data" style="margin-left:10px;margin-top:10px;">--%>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="GridView1" runat="server" Style="height: 380px; overflow: auto;"
                                        Width="100%" BorderWidth="0px" CellPadding="2" font-weight="600" font-family="Open Sans"
                                        Font-Size="11px" ForeColor="#5c5c5c" OnRowDataBound="GridView1_RowDataBound">
                                        <FooterStyle BackColor="Tan" />
                                        <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                        <HeaderStyle BackColor="#F25E0A" Font-Bold="True" ForeColor="White" />
                                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <%--</div>--%></div>
                        <div id="Divgrid1" class="divg">
                            <table>
                                <tr>
                                    <td runat="server" id="hdsviewgrid" style="width: 600px;" align="left">
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
        <input type="hidden" runat="server" id="Hidden1" />
        <input type="hidden" runat="server" id="Hidden9" />
        <input type="hidden" runat="server" id="hdnas" />
        <input type="hidden" runat="server" id="hdnasn" />
        <input type="hidden" runat="server" id="hdnidob" />
        <input type="hidden" runat="server" id="hdnimoob" />
        <input type="hidden" runat="server" id="hdniyob" />
        <input type="hidden" runat="server" id="hdnihob" />
        <input type="hidden" runat="server" id="hdnimob" />
        <input type="hidden" runat="server" id="hdnmdegree" />
        <input type="hidden" runat="server" id="hdnmminute" />
        <input type="hidden" runat="server" id="hdnmsecond" />
        <input type="hidden" runat="server" id="hdnmrashi" />
        <input type="hidden" runat="server" id="hdnusermail" />
        <input type="hidden" runat="server" id="hdnuser" />
     </div>
     <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
