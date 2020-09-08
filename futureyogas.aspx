<%@ Page Language="C#" AutoEventWireup="true" CodeFile="futureyogas.aspx.cs" Inherits="futureyogas" %>

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
    <link type="text/css" rel="stylesheet" href="CSS/yogas.css">
    <%--<link rel="Stylesheet" href="css/astrocss.css" type="text/css" />--%>
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans" />
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />--%>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/futureyogas.js"></script>

    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>

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
        popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no');
    }
    function getopen1(pagename)
    {
        window.parent.location.href="login.aspx";
    }
    </script>

</head>
<body id="body" <%--oncontextmenu="return false;"--%>>
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
                <li id="Li2" runat="server"><a class="menu_Selact">Horary Yoga</a>
                    <ul>
                        <li><a>Calculate Horary Yoga</a></li>
                        <li><a>Calculate Karyasiddhi Yoga</a></li>
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
    <div class="mid_body" style="padding-bottom: 74px;">
    <h1 class="mid_sec_query" id="clientqueryid" runat="server"></h1>
        <div class="mid_sec">
            <div class="mid_over" style="padding-bottom: 5px;">
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
                        <span class="filterss" style="display:none;">
                            <asp:Label ID="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" Text="Astrologer Name :" runat="server">
                            </asp:Label>
                            <asp:Label ID="astname" ForeColor="White" font-weight="600" font-family="Open Sans"
                                Font-Size="11px" runat="server">
                            </asp:Label>
                        </span><span class="filterss" style="display:none;">
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
                <div id="whitediv" class="div_curve_combi" style="height: 400px; padding: 10px;box-sizing: border-box;">
                    <asp:Label ID="toc" runat="server" Style="font-size: 1.2em !important;"></asp:Label>
                    <div class="divhorary1" style="width: 65%;">
                        <div id="foritchaaldiv" runat="server" class="for_align_menu" style="padding: 10px;box-sizing: border-box;">
                            <p style="float: left;">
                                Choose:
                            </p>
                            <asp:DropDownList ID="fi" runat="server" Width="40%" CssClass="textbox" Style="float: left;">
                                <asp:ListItem>Within 1st Week</asp:ListItem>
                                <asp:ListItem>From 1st to 2nd Week</asp:ListItem>
                                <asp:ListItem>From 2nd to 3rd Week</asp:ListItem>
                                <asp:ListItem>From 3rd to 4th Week</asp:ListItem>
                                <asp:ListItem>From 4th to 5th Week</asp:ListItem>
                                <asp:ListItem>From 5th to 6th Week</asp:ListItem>
                                <asp:ListItem>From 6th to 7th Week</asp:ListItem>
                                <asp:ListItem>From 7th to 8th Week</asp:ListItem>
                                <asp:ListItem>From 8th to 9th Week</asp:ListItem>
                                <asp:ListItem>From 9th to 10th Week</asp:ListItem>
                                <asp:ListItem>From 10th to 11th Week</asp:ListItem>
                                <asp:ListItem>From 11th to 12th Week</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="daysd" runat="server" Width="40%" CssClass="textbox" Style="float: left; margin-left: 5px;">
                                <asp:ListItem>Upto 7th Day</asp:ListItem>
                                <asp:ListItem>Upto 1st Day</asp:ListItem>
                                <asp:ListItem>Upto 2nd Day</asp:ListItem>
                                <asp:ListItem>Upto 3rd Day</asp:ListItem>
                                <asp:ListItem>Upto 4th Day</asp:ListItem>
                                <asp:ListItem>Upto 5th Day</asp:ListItem>
                                <asp:ListItem>Upto 6th Day</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Menu ID="Menu1" runat="server" DynamicHorizontalOffset="2"
                                Font-Names="PT Sans Narrow" Font-Size="14px" Font-Weight="600" ForeColor="#034a86"
                                StaticSubMenuIndent="10px" OnMenuItemClick="Menu1_MenuItemClick">
                                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                <DynamicHoverStyle BackColor="#3aa6f7" ForeColor="White" />
                                <DynamicSelectedStyle BackColor="#3aa6f7" />
                                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                <StaticHoverStyle BackColor="#3aa6f7" ForeColor="White" />
                                <Items>
                                    <asp:MenuItem Text="(A)Lagnesh with Lord of house" Value="house">
                                        <asp:MenuItem Text="HOUSE2" Value="HOUSE2"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE3" Value="HOUSE3"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE4" Value="HOUSE4"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE5" Value="HOUSE5"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE6" Value="HOUSE6"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE7" Value="HOUSE7"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE8" Value="HOUSE8"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE9" Value="HOUSE9"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE10" Value="HOUSE10"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE11" Value="HOUSE11"></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE12" Value="HOUSE12"></asp:MenuItem>
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="(B)From MOON with Lord of house" Value="MOON">
                                        <asp:MenuItem Text="HOUSE1" Value=" HOUSE1 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE2" Value=" HOUSE2 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE3" Value=" HOUSE3 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE4" Value=" HOUSE4 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE5" Value=" HOUSE5 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE6" Value=" HOUSE6 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE7" Value=" HOUSE7 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE8" Value=" HOUSE8 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE9" Value=" HOUSE9 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE10" Value=" HOUSE10 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE11" Value=" HOUSE11 "></asp:MenuItem>
                                        <asp:MenuItem Text="HOUSE12" Value=" HOUSE12 "></asp:MenuItem>
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="(C) From Lagnesh" Value="Lagnesh" ToolTip="First Query to be checked between Lagnesh  &  Karyesh or Querent  & House of Query">
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="(D) From other Planets" Value="planet">
                                        <asp:MenuItem Text="From MOON" Value="MOON" ToolTip="First Query to be checked between Moon & Karyesh, When Lord of Lagna and Lord of House of Query are same Planet">
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="From SUN" Value="SUN" ToolTip="Second Query to be checked between Sun & Karyesh as here Sun is treated as Lagnesh or Querent.">
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="From VENUS" Value="VENUS" ToolTip="Third Query to be checked between Venus & Karyesh as here Sun is treated as Lagnesh or Querent.">
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="From JUPITER" Value="JUPITER" ToolTip="Fourth Query to be checked between Jupier & Karyesh as here Sun is treated as Lagnesh or Querent.">
                                        </asp:MenuItem>
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="(E)Others" Value="other">
                                        <asp:MenuItem Text="MARS" Value="MARS"></asp:MenuItem>
                                        <asp:MenuItem Text="MERCURY" Value="MERCURY"></asp:MenuItem>
                                    </asp:MenuItem>
                                </Items>
                            </asp:Menu>
                        </div>
                        <div id="newhiddiv" class="for_new_hor">
                            <p1 cssclass="label_yogas_class"> Choose Lagnesh </p1>
                            <input type="radio" name="group1" runat="server" value="Banefic" id="Radio1" class="label_1" />
                            <p1 cssclass="label_yogas_class">Choose MOON as Lagnesh (When Lagnesh and Kaeresh are in same Planet)</p1>
                            <input type="radio" name="group1" runat="server" value="Malefic" id="r1" class="label_1" />
                            <div class="drop_div_style">
                                <asp:Label ID="jdhjk" runat="server" Text="Choose Karyesh as lord of house" ForeColor="#5c5c5c"
                                    font-weight="600" font-family="Open Sans" Font-Size="11px"></asp:Label>
                                <asp:DropDownList ID="hd" runat="server" CssClass="yoga_drop">
                                </asp:DropDownList>
                                <div class="lov_div_but">
                                    <asp:LinkButton ID="horarykaryasidhi" runat="server" class="per_btn">check Karya Siddhi</asp:LinkButton></div>
                            </div>
                        </div>
                        <div class="drp_lbl_div" style="display: none;">
                            <asp:Label ID="labchart" runat="server" Text="Chart" Style="margin: 5px 15px 5px 25px;"></asp:Label>
                        </div>
                        <div class="drp_lbl_div" style="display: none;">
                            <asp:DropDownList ID="vargaschart" runat="server" CssClass="drpo_homenew">
                            </asp:DropDownList>
                        </div>
                        <div id="naktadiv" class="for_new_hor_nakta">
                            <div class="drop_div_style">
                                <asp:Label ID="Label1" runat="server" Text="Choose Karyesh as lord of house" CssClass="label_yogas_class"></asp:Label>
                                <asp:DropDownList ID="naktadrop" runat="server" CssClass="yoga_drop">
                                </asp:DropDownList>
                                <div class="lov_div_but_new">
                                    <asp:LinkButton ID="naktabutton" runat="server" class="per_btn_yamya">Nakta Yoga</asp:LinkButton>
                                    <asp:LinkButton ID="yamyabut" runat="server" class="per_btn_yamya">Yamya Yoga</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="loadingimage_yogas_page" id="img1" runat="server" style="display: none;">
                            <img src="Image/preloader_transparent.gif" alt="hello" />
                        </div>
                        <div class="divhoraryy">
                            <div id="Divgrid1" class="div_curve_yogas">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid" style="width: 850px;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="Divgrid2" class="div_curve_yogas_new">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid2" style="width: 448px;" align="left">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div id="clinetnamediv" runat="server" class="div_name_id_div_searchpage" style="width: 700px;
                                margin-top: -210px; height: 200px; margin-left: 5px;">
                                <div class="colum-td-head" style="width: 98% !important;">
                                    <asp:Label ID="Label2" runat="server" Text="HOARAY SIGNIFICATOR" font-weight="600"
                                        font-family="Open Sans" Font-Size="11px" ForeColor="White"></asp:Label>
                                    <asp:Button ID="cross" runat="server" Text="X" Style="margin-left: 652px; margin-top: -19px;" /></div>
                                <div id="palnet_div" font-weight="600" font-family="Open Sans  !important;" font-size="11px"
                                    forecolor="White" runat="server">
                                    <asp:LinkButton ID="planet_link" font-weight="600" font-family="Open Sans !important;"
                                        Font-Size="11px" ForeColor="White" OnClick='javascript:showshignificator()' Style='cursor: pointer'></asp:LinkButton></div>
                                <div id="house1_div" font-weight="600" font-family="Open Sans" font-size="11px" forecolor="White"
                                    runat="server">
                                    <asp:LinkButton ID="house1_link" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                        ForeColor="White" OnClick='javascript:showshignificator_house()' Style='cursor: pointer'></asp:LinkButton></div>
                                <div id="house2_div" font-weight="600" font-family="Open Sans" font-size="11px" forecolor="White"
                                    runat="server">
                                    <asp:LinkButton ID="house2_link" font-weight="600" font-family="Open Sans" Font-Size="11px"
                                        ForeColor="White" OnClick='javascript:showshignificator_house2()' Style='cursor: pointer'></asp:LinkButton></div>
                                <div id="Divgrid3" style="width: 550px; height: 125px; display: none; overflow: auto;
                                    margin-top: -45px; margin-left: 150px;">
                                    <table>
                                        <tr>
                                            <td runat="server" id="hdsviewgrid3" style="width: 280px;" align="left">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div id="vargasdiv" runat="server">
                            <div class="column1ho" id="rashiid">
                                <div class="column-div1">
                                    <span>
                                        <asp:Label ID="h1l1" runat="server" Text="">
                                        </asp:Label>
                                    </span>
                                </div>
                                <div class="column-divr1">
                                    <span>
                                        <asp:Label ID="h1r" runat="server" Text="">
                                        </asp:Label></span>
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
                                <figure class="fixedratio"></figure>
                            </div>
                        </div>
                    </div>
                    <div id="Div3" class="searchdiv">
                        <table>
                            <tr>
                                <td runat="server" id="dhdsviewgrid2" style="width: 600px;" align="left">
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="Div4" style="overflow: auto; display: none; width: 600px; height: 260px;">
                        <table>
                            <tr>
                                <td runat="server" id="dhdsviewgrid3" style="width: 600px;" align="left">
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--
    <div class="menu_mainf"  >
	<div class="menuf" id="nav">
    	<ul>
        	<li id="a1l" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a href="#" class="menu_Selact">PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
            <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6l" runat="server"><a >CHART INDEX</a></li>
              <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
               <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>     
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
    </div>--%>
    <input type="hidden" runat="server" id="Hlagnarashi" />
    <input type="hidden" runat="server" id="Hlagnadegree" />
    <input type="hidden" runat="server" id="Hdegree" />
    <input type="hidden" runat="server" id="Hhouse" />
    <input type="hidden" runat="server" id="Hdrop1" />
    <input type="hidden" runat="server" id="Hdegreesecond" />
    <input type="hidden" runat="server" id="Hmoonrashi" />
    <input type="hidden" runat="server" id="Hsunhouse" />
    <input type="hidden" runat="server" id="Hmoonhouse" />
    <input type="hidden" runat="server" id="Hasendrashi" />
    <input type="hidden" runat="server" id="Hsuninhouse" />
    <input type="hidden" runat="server" id="Hmooninhouse" />
    <input type="hidden" runat="server" id="Hmarsinhouse" />
    <input type="hidden" runat="server" id="Hmrecinhouse" />
    <input type="hidden" runat="server" id="Hjupinhouse" />
    <input type="hidden" runat="server" id="Hvenusinhouse" />
    <input type="hidden" runat="server" id="Hsaturninhouse" />
    <input type="hidden" runat="server" id="menuitsmcvalue">
    <input type="hidden" runat="server" id="Hretro" />
    <input type="hidden" runat="server" id="Hrashie" />
    <input type="hidden" runat="server" id="astrologername" />
    <input type="hidden" runat="server" id="astrologerid" />
    <input type="hidden" runat="server" id="hdnuser" />
    <input type="hidden" runat="server" id="Hidden8" />
    <input type="hidden" runat="server" id="Hiddenva" />
    <input type="hidden" runat="server" id="hdnidateob" />
    <input type="hidden" runat="server" id="hdnimonthob" />
    <input type="hidden" runat="server" id="hdniyearob" />
    <input type="hidden" runat="server" id="hdnihourob" />
    <input type="hidden" runat="server" id="hdniminuteob" />
    <input type="hidden" runat="server" id="hdnidateobf" />
    <input type="hidden" runat="server" id="hdnimonthobf" />
    <input type="hidden" runat="server" id="hdniyearobf" />
    <input type="hidden" runat="server" id="hdnihourobf" />
    <input type="hidden" runat="server" id="hdniminuteobf" />
    <input type="hidden" runat="server" id="hdnlongit" />
    <input type="hidden" runat="server" id="hdnlatit" />
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
    <input type="hidden" runat="server" id="hdnr0" />
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
    <input type="hidden" runat="server" id="username" />
    <input type="hidden" runat="server" id="hdndob" />
    <input type="hidden" runat="server" id="hdntob" />
    <input type="hidden" runat="server" id="hdntzo" />
    <input type="hidden" runat="server" id="hdntzval" />
    <input type="hidden" runat="server" id="hdsunsetpre" />
    <input type="hidden" runat="server" id="hdsunrise" />
    <input type="hidden" runat="server" id="hdsunset" />
    <input type="hidden" runat="server" id="hdsunrisenext" />
    <input type="hidden" runat="server" id="hdgulikatime" />
    <input type="hidden" runat="server" id="gulikaval" />
    <input type="hidden" runat="server" id="hdnquery" />
    </div>
     <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
