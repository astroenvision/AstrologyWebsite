<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hoarary_knowledge.aspx.cs"
    Inherits="hoarary_knowledge" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Horary Knowledge | Astro Envision</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css" />
    <link type="text/css" rel="stylesheet" href="css/tabeletyoga.css">
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://docs.jquery.com/CSS/position">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">--%>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <%--<script type="text/javascript" language="javascript" src="javascript/yoga.js"></script>--%>

    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>

    <script language="javascript" src="javascript/hoarary_knowlegde.js" type="text/javascript"></script>

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

       // popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
         //window.location.href = "" + pagename + ""; 
         popUpWin = window.open('' + pagename + '', null);
    }
    function getopen1(pagename)
    {
       window.parent.location.href="login.aspx";
    }
    </script>

    <script type="text/javascript">
           function SetCursorToTextEnd(textControlID)
      {
	var text = document.getElementById(textControlID);
	if (text != null && text.value.length > 0)
        {
		if (text.createTextRange)
		{
			var range = text.createTextRange();
			range.moveStart('character', text.value.length);
                    		range.collapse();
                    		range.select();
		}
		else if (text.setSelectionRange)
		{
			var textLength = text.value.length;
			text.setSelectionRange(textLength, textLength);
		}
	}
    }
    </script>

</head>
<body id="body1">
    <form id="form1" runat="server" defaultfocus="tb1">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
        <div class="middlecontainer">
            <div class="menu_main_lower" id="horarydiv" runat="server" style="display: none;">
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
                        <li id='Li7' runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer'>Horary Significator</a></li>
                        <li id='Li8' runat="server"><a class="menu_Selact">Horary Knowledge</a></li>
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
            <div class="menu_main_lower" id="nataldiv" runat="server" style="display: none;">
                <div class="menu" id="nav">
                    <ul>
                        <li id="a1" runat="server"><a href="#">Home</a></li>
                        <li id="a9" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                            style='cursor: pointer;'>My Account</a></li>
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
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <div id="Div1" runat="server" class="div_curve  p h1 p2" style="width: 300px; overflow: auto;
                                    border-width: 2px; position: relative;">
                                    <asp:Label ID="ll1" class="vmiddle" runat="server" Text="Horary Search" Font-Bold="true"
                                        Style="font-size: 12px !important;"></asp:Label>
                                    <asp:TextBox ID="tb1" runat="server" OnTextChanged="tb1_TextChanged" Style="margin-left: 10px;
                                        width: 50%;" AutoPostBack="True" onfocus="SetCursorToTextEnd(this.id);" class="vmiddle" />
                                    <asp:ImageButton ID="im1" runat="server" ImageUrl="~/Image/searchImg.png" class="searchImg vmiddle" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <div id="data_tree" runat="server" class="div_curve  p h1 p2" style="float: left;
                                    width: 300px; height: 440px; max-height: 440px; overflow: auto; float: left;
                                    border-width: 2px; position: relative;">
                                    <div style="float: left; width: 100%; height: 30px; margin: 10px 0px 0px 0px;">
                                        <asp:LinkButton ID="cola" class="per_btn1_2" runat="server" OnClick="cola_Click">Collapse All</asp:LinkButton>
                                        <asp:LinkButton ID="lbreset" class="per_btn1_2" runat="server" OnClick="lbreset_Click">Reset</asp:LinkButton>
                                    </div>
                                    <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple">
                                        <HoverNodeStyle Font-Underline="True" ForeColor="#F25E0A" />
                                        <RootNodeStyle ForeColor="#6D6D6D" />
                                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Gray" HorizontalPadding="0px"
                                            NodeSpacing="0px" VerticalPadding="0px" />
                                        <ParentNodeStyle Font-Bold="False" ForeColor="#6D6D6D" />
                                        <SelectedNodeStyle Font-Underline="True" ForeColor="#6D6D6D" HorizontalPadding="0px"
                                            VerticalPadding="0px" />
                                    </asp:TreeView>
                                </div>
                                <div id="Div3" runat="server" class="div_curve1  p h1 p2" style="float: left; width: 620px;
                                    height: 22px; border-width: 2px; box-sizing: border-box; padding: 2px 8px;">
                                    <asp:Label ID="Label4" runat="server" Style="font-size: 11px !important; font-weight: 700;"></asp:Label>
                                </div>
                                <div id="show_data" runat="server" class="div_curve1 div_curve1a p h1 p2" style="float: left;
                                    position: static; width: 62%; height: 400px; border-width: 2px; margin-top: 10px;
                                    overflow: auto;">
                                    <asp:Label ID="Label3" runat="server" Style="color: Black; font-size: 13px !important;
                                        font-weight: 700; display: block; text-align: center; margin: 5px 0;"></asp:Label>
                                    <div id="data_shoe_div" runat="server" style="height: auto; color: inherit !important;
                                        max-height: 357px; overflow: auto; font-size: 14px !important; font-family: Arial !important;
                                        margin-top: 16px; margin-bottom: 13px;">
                                    </div>
                                    <asp:Label ID="Label1" runat="server" Style="color: Black; font-size: medium; margin-left: 209px;"></asp:Label>
                                    <div id="data_shoe_div1" runat="server" style="height: auto; max-height: 80px; overflow: auto;
                                        margin-top: 16px; margin-bottom: 14px;">
                                    </div>
                                    <asp:Label ID="Label2" runat="server" Style="color: Black; font-size: medium; margin-left: 209px;
                                        display: none;"></asp:Label>
                                    <div id="data_shoe_div2" runat="server" style="height: auto; display: none; max-height: 80px;
                                        overflow: auto; margin-top: 16px; margin-bottom: 14px;">
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
            <%-- <div class="menu_mainf">
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
           <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
             <li id="a8l" runat="server"><a href="#" class="menu_Selact">HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
    </div>--%>
            <input type="hidden" runat="server" id="treechild" />
            <input type="hidden" runat="server" id="hdnuser" />
            <input type="hidden" runat="server" id="hdnnode" />
            <input type="hidden" runat="server" id="hdnnl" />
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
