<%@ Page Language="C#" AutoEventWireup="true" CodeFile="horarysignificator.aspx.cs"
    Inherits="horarysignificator" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Horary Significators | Astro Envision</title>
    <meta name="description" content="Approx 2000 plus significators for Planet, Houses and Rashi individually has been provided, and one can look for any particular Significator by search across 2500 significators related to horary for practical applicability of exact query.">
    <meta name="keywords" content="Online Astrology Services, Horary Significators, Online Horary Significators,Prashna Significators">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css" />
    <link type="text/css" rel="stylesheet" href="css/tabeletyoga.css">
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <%--<script type="text/javascript" language="javascript" src="javascript/yoga.js"></script>--%>

    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>

    <script language="javascript" src="javascript/horarysignificator.js" type="text/javascript"></script>

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
                "value": "",
                "text": "Go to..."
            }).appendTo("nav select");

            // Populate dropdown with menu items
            $("nav a").each(function() {
                var el = $(this);
                $("<option />", {
                    "value": el.attr("href"),
                    "text": el.text()
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
    function getopen(pagename) {

        if (popUpWin) {
            if (!popUpWin.closed) popUpWin.close();
        }

        //popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
         window.location.href = ""+pagename+""; 
    }
    function getopen1(pagename)
    {
       window.parent.location.href="login.aspx";
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
    <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
    <div class="middlecontainer">
    <div class="menu_main_lower" id="horarydiv" runat="server" style="display:none;">
        <div class="menu" id="nav">
            <ul>
                <li id='Li1' runat="server"><a href="#">Home</a></li>
                <li id='Li9' runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'>My Account</a></li>
                <li id="Li2" runat="server"><a href="#">Horary Yoga</a>
                    <ul>
                        <li><a>Calculate Horary Yoga</a></li>
                        <li><a>Calculate Karyasiddhi Yoga</a></li>
                    </ul>
                </li>
                <li id='Li3' runat="server"><a href="#">Nature Of Query</a></li>
                <li id='Li7' runat="server"><a class="menu_Selact">Horary Significator</a></li>
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
                <li id="a9" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'"'>My Account</a></li>
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
        <div class="mid_sec">
            <div class="mid_over">
                <div class="div_header_significator">
                    <div class="yoga_drop1">
                        <div class="yogaPRH">
                            <asp:Label ID="l1" runat="server" Text="Planet"></asp:Label>
                            <asp:DropDownList ID="horpalnet" CssClass="drpo_homenew" runat="server" Style="margin-right: 20px; float:none;">
                            </asp:DropDownList>
                        </div>
                        <div class="yogaPRH">
                            <asp:Label ID="Label1" runat="server" Text="Rashi"></asp:Label>
                            <asp:DropDownList ID="horrashi" runat="server" CssClass="drpo_homenew" Style="margin-right: 20px;float:none;">
                            </asp:DropDownList>
                        </div>
                        <div class="yogaPRH">
                            <asp:Label ID="Label2" runat="server" Text="House"></asp:Label>
                            <asp:DropDownList ID="horhouse" runat="server" CssClass="drpo_homenew" style="float:none;">
                            </asp:DropDownList>
                        </div>
                    
                    <div class="hora_div_text">
                        <asp:Label ID="Label3" runat="server" Text="Search Significator"></asp:Label>
                        <asp:TextBox ID="searchsignificator" runat="server"></asp:TextBox>
                    </div>
                    </div>
                    <div class="horar_sidngi_div">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:LinkButton ID="yamyabut" runat="server" class="per_btn" OnClick="yamyabut_Click">Submit</asp:LinkButton>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div id="grigdiv_data" class="g_data">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="10" BorderWidth="0px" font-weight="600" font-family="Open Sans" Font-Size="11px" ForeColor="#5c5c5c"
                                OnPageIndexChanging="GridView1_PageIndexChanging">
                                <PagerSettings PageButtonCount="4" Mode="NextPrevious" />
                                <FooterStyle BackColor="Tan" />
                                <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="#FFFFFF" />
                                <HeaderStyle BackColor="#F25E0A" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
    <%--<div class="menu_mainf">
	<div class="menuf" id="nav">
    <ul>
        	<li id="a1l" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a href="#">PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
             <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6l" runat="server"><a >CHART INDEX</a></li>
            <li id="a7l" runat="server"><a href="#" class="menu_Selact">HORARY SIGNIFICATOR</a></li>
            <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li> 
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
   </div>--%>
   
    <input type="hidden" runat="server" id="hs" />
    <input type="hidden" runat="server" id="hdnuser" />
    </div>
     <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
