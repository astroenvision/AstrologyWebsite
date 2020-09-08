<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="vargas_chart.aspx.cs"
    Inherits="vargas_chart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <meta content="" charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!--[if lt IE 9]>
       <script src="http://css3-mediaqueries-js.googlecode.com/svn/trunk/css3-mediaqueries.js"></script>
    <![endif]-->
    <!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css" />
    <%--<link rel="Stylesheet" href="css/astrocss.css" type="text/css" />--%>
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">--%>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/vargas_chart.js"></script>

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

	        //popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
	        popUpWin = window.open(''+ pagename +'',null);

        }
        function getopen1(pagename)
        {
        window.parent.location.href="login.aspx";
        }
    </script>

</head>
<body id="body" onload="accountuser(); vargas();">
    <form id="form1" runat="server">
    <div class="maincontainer">
        <%--Start Deepak comment following line on 19/06/2020--%>
        <%--<uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />--%>
        <%--End Deepak comment following line on 19/06/2020--%>
    <div class="middlecontainer">
    <div class="head_main" style="display:none;">
        <div class="head">
            <div class="head_logo">
                <img src="IMAGES/logo.jpg" alt="Astro Envision" /></div>
            <div class="head_ad">
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    <div class="menu_main_lower" id="horarydiv" runat="server" style="display:block;">
        <div class="menu" id="nav">
            <ul>
                <li id='Li1' runat="server"><a href="#">Home</a></li>
                <li id='Li9' runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)'
                    style='cursor: pointer'>My Account</a></li>
                <li id="Li2" runat="server"><a>Horary Yoga</a>
                    <ul>
                        <li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate
                            Horary Yoga</a></li>
                        <li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate
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
    <div class="menu_main_lower" id="nataldiv" runat="server" style="display:block;">
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
    <h1 class="mid_sec_query" id="clientqueryid" runat="server"></h1>
        <div class="mid_sec" style="box-sizing: border-box;padding: 10px;">
            <div class="mid_over" style="width: 100%;">
                <%-- <div id="Div1" class="div_header"  >
                            <table style="margin-left:50px;">
                           <tr >
                           <td style="padding-left:50px;">
                           <asp:Label id="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" Text="Astrologer Name :" runat="server" >
                           </asp:Label>
                           </td>
                           <td  style="padding-left:10px;">
                          <asp:Label id="astname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" >
                           </asp:Label>
                           </td>
                           <td style="padding-left:50px;">
                           <asp:Label id="Label3"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" Text="Astrologer ID :" runat="server" >
                           </asp:Label>
                           </td>
                           <td style="padding-left:10px;" >
                           <asp:Label id="astid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" >
                           </asp:Label>
                           </td>
                           <td style="padding-left:50px;">
                           <asp:Label id="Label5"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" Text="Client Id :" runat="server" >
                           </asp:Label>
                           </td>
                           <td  style="padding-left:10px;">
                          <asp:Label id="clientid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" >
                           </asp:Label>
                           </td>
                           <td style="padding-left:50px;">
                           <asp:Label id="Label4"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" Text="Client Name :" runat="server" >
                           </asp:Label>
                           </td>
                           <td  style="padding-left:10px;">
                          <asp:Label id="clientname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" >
                           </asp:Label>
                           </td>
                           </tr></table>
                           </div>
                           <div class="vargas_page"></div>--%>
                <div id="Div1" class="div_header div_headerVC">
                    <div class="d_header_1 h_filters">
                        <span class="filterss" style="display:none;">
                            <asp:Label ID="lbusername" font-weight="600" 
                                Font-Size="11px" Text="Astrologer Name :" runat="server">
                            </asp:Label>
                            <asp:Label ID="astname" font-weight="600" 
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss" style="display:none;">
                            <asp:Label ID="Label3" font-weight="600" 
                                Font-Size="11px" Text="Astrologer ID :" runat="server">
                            </asp:Label>
                            <asp:Label ID="astid" font-weight="600" 
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss">
                            <asp:Label ID="Label5" font-weight="600" 
                                Font-Size="11px" Text="Client Name :" runat="server">
                            </asp:Label>
                            <asp:Label ID="clientname" font-weight="600" 
                                Font-Size="11px" runat="server">
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
                <div id="whitediv" class="div_curve_vargas" style="padding: 0;">
                    <div id="Divgrid1" class="divg1homenewpage div-scroll_vargas wid100">
                        <table>
                            <tr>
                                <td runat="server" id="hdsviewgrid" style="width: 550px;" align="left">
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="divg1_vargas widAuto">
                        <asp:Label ID="label11" font-weight="600" font-family="Open Sans" Font-Size="11px"
                            ForeColor="Black" runat="server" Text="Chart"></asp:Label>
                        <asp:DropDownList ID="chart" runat="server" CssClass="drpo_homenew" Width="210px">
                        </asp:DropDownList>
                        <asp:Label ID="label6" font-weight="600" font-family="Open Sans" Font-Size="11px"
                            ForeColor="Black" runat="server" Text="D.O.B \ D.O.Q" Style="display: none;"></asp:Label>
                        <asp:TextBox ID="dasha" runat="server" CssClass="drpo_homenew" Style="display: none;"></asp:TextBox>
                        <asp:Label ID="label7" font-weight="600" font-family="Open Sans" Font-Size="11px"
                            ForeColor="Black" runat="server" Text="Yogas" Style="display: none;"></asp:Label>
                        <asp:DropDownList ID="dropyogas" runat="server" Style="display: none;" CssClass="drpo_homenew_new">
                        </asp:DropDownList>
                        <asp:Label ID="label2" font-weight="600" font-family="Open Sans" Font-Size="11px"
                            ForeColor="Black" runat="server" Text="Planet" Style="display: none;"></asp:Label>
                        <asp:TextBox ID="planet" runat="server" Style="display: none;" CssClass="drpo_homenew_new"></asp:TextBox>
                    </div>
                    <div class="buttondiv margin0">
                        <div id="d3" runat="server" style="width: 559px; float: left; display: none;">
                            <asp:LinkButton ID="yogasbutton" runat="server" Style="width: 165px; height: 20px;"
                                class="per_btn_vargas">Calculate Horary Yogas</asp:LinkButton>
                            <asp:LinkButton ID="horarycombina" runat="server" Style="width: 165px; height: 20px;"
                                class="per_btn_vargas">Horary Combination</asp:LinkButton>
                        </div>
                        <div id="De" runat="server" style="text-align: center; width: 100%;">
                            <asp:LinkButton ID="ImageButton1" runat="server" Style="height: auto;width: auto;float: none !important;display: inline-block !important;" class="per_btn_vargas">Vargas Chart</asp:LinkButton>
                            <asp:LinkButton ID="ImageButton2" runat="server" Style="height: auto;width: auto;float: none !important;display: inline-block !important;" class="per_btn_vargas">Save Chart</asp:LinkButton>
                            <asp:Button ID="btncancel" runat="server" Style="height: auto;width: auto;float: none !important;display: inline-block !important;" class="per_btn_vargas" Text="Exit" onclick="btncancel_Click"  />
                        </div>
                        <div id="d2" runat="server" style="display: none;">
                            <asp:LinkButton ID="ImageButton4" runat="server" Style="width: 100px;" class="per_btn_vargas">Remedials</asp:LinkButton>
                            <asp:LinkButton ID="D01" runat="server" Style="width: 100px;" class="per_btn_vargas">Show Predictive</asp:LinkButton>
                            <asp:LinkButton ID="yoga" runat="server" Style="width: 100px;" class="per_btn_vargas">Natal Yogas</asp:LinkButton>
                            <asp:LinkButton ID="astrocalc" runat="server" Style="width: 100px;" class="per_btn_vargas">Astro Cals</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div id="clinetnamediv" runat="server" class="div_name_id_div">
                    <div style="margin-left: 5px;">
                        <asp:Button ID="cross" runat="server" Text="X" CssClass="vargas_1" /></div>
                    <asp:Label ID="Label12" ForeColor="Black" Text="Group Category" runat="server" Style="margin-left: 10px;"></asp:Label>
                    <div>
                        <asp:DropDownList ID="cat_grp" runat="server" CssClass="drpo_homenew" Width="150px">
                            <asp:ListItem>Select Category</asp:ListItem>
                            <asp:ListItem>Natal</asp:ListItem>
                            <asp:ListItem>Horary</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Label ID="Label10" ForeColor="Black" Text="Enter group" runat="server" Style="margin-left: 10px;"></asp:Label>
                    <div>
                        <asp:DropDownList ID="groupdrop" runat="server" CssClass="drpo_homenew" Width="150px">
                        </asp:DropDownList>
                    </div>
                    <div style="margin-left: 10px;">
                        <asp:Label ID="Label8" ForeColor="Black" Text="Enter Client ID" runat="server"></asp:Label>
                        <asp:TextBox ID="clientidtextbox" runat="server" Width="98%" Height="27px"></asp:TextBox></div>
                    <div class="vargas_2" style="margin-left: 10px;">
                        <asp:Label ID="Label9" ForeColor="Black" Text="Enter Client Name" runat="server"></asp:Label>
                        <asp:TextBox ID="clientnametextbox" runat="server" Width="98%" Height="27px"></asp:TextBox></div>
                    <div class="vargas_3" style="margin-left: 10px;">
                        <asp:LinkButton ID="cliidname" runat="server" Style="margin-left: 10px;" class="per_btn_vargas">Save</asp:LinkButton></div>
                </div>
                <div class="mar_div_chart">
                    <div>
                        <%--<div>
                            <asp:Label ID="Label1d01" runat="server" Font-Bold="true" ForeColor="#6D6D6D" CssClass="varga_lbl"></asp:Label>
                        </div>--%>
                        <div class="columnd01" id="rashiidd01" style="position: static;">
                       
                            <asp:Label ID="Label1d01" runat="server" Font-Bold="true" ForeColor="#6D6D6D" CssClass="varga_lbl"></asp:Label>
                       <div style="position: relative;">
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
                    <div class="sec_varga">
                        <%--<div>
                            <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="#6D6D6D" CssClass="varga_lbl"></asp:Label>
                        </div>--%>
                        <div class="column" id="rashiid" style="position: static;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="#6D6D6D" CssClass="varga_lbl"></asp:Label>
                        <div style="position: relative;">
                            <div class="column-div1">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv1">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h1r" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div2">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv2">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h2r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div3">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv3">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h3r" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div4">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv4">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h4r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div5">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv5">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h5r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div6">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv6">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h6r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div7">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv7">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h7r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div8">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8l1" runat="server" Text="">
                                    </asp:Label></span>
                            </div>
                            <div class="column-divrv8">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h8r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div9">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv9">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h9r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div10">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv10">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h10r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div11">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv11">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h11r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div12">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12l1" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divrv12">
                                <span style="font-size: 11px;">
                                    <asp:Label ID="h12r" runat="server" Text="">
                                    </asp:Label>
                                </span>
                            </div>
                            <figure class="fixedratio"></figure>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
          
   <%--<div class="menu_mainf" >
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
    <input type="hidden" runat="server" id="hdnidateob" />
    <input type="hidden" runat="server" id="hdnimonthob" />
    <input type="hidden" runat="server" id="hdniyearob" />
    <input type="hidden" runat="server" id="hdnihourob" />
    <input type="hidden" runat="server" id="hdniminuteob" />
    <input type="hidden" runat="server" id="hdnlongit" />
    <input type="hidden" runat="server" id="hdnlatit" />
    <input type="hidden" runat="server" id="hdntzo" />
    <input type="hidden" runat="server" id="hdntzval" />
    <input type="hidden" runat="server" id="hdncat" />
    <input type="hidden" runat="server" id="hdsunsetpre" />
    <input type="hidden" runat="server" id="hdsunrise" />
    <input type="hidden" runat="server" id="hdsunset" />
    <input type="hidden" runat="server" id="hdnsunrisenext" />
    <input type="hidden" runat="server" id="hddayofbirth" />
    <input type="hidden" runat="server" id="hdrashi" />
    <input type="hidden" runat="server" id="hdconstellation" />
    <input type="hidden" runat="server" id="hdndayduration" />
    <input type="hidden" runat="server" id="hdnnightduration" />
    <input type="hidden" runat="server" id="hdnbalancedasha" />
    <input type="hidden" runat="server" id="hdnquery" />
    </div>
        <%--Start Deepak comment following line on 19/06/2020--%>
     <%--<uc2:footer ID="footer1" runat="server" />--%>
          <%--End Deepak comment following line on 19/06/2020--%>
    </div>
    </form>
</body>
</html>
