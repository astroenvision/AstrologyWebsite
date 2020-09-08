<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myaccount.aspx.cs" Inherits="myaccount" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletmyaccount.css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen"/>
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans"/>
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />--%>

    <%--<script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>--%>

    <%--<script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>--%>

    <script type="text/javascript" language="javascript" src="<%=ResolveUrl("~/javascript/jquery.min.js") %>"></script>

    <script type="text/javascript" language="javascript" src="javascript/myaccount.js"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>

    <%--<style>
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
    </style>--%>

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

	        //popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
            window.location.href = ""+pagename+""; 

        }
        function getopen1(pagename)
        {
            window.parent.location.href="login.aspx";
        }
    </script>

   
</head>
<body id="body" onload="accountuser();group_bind();">
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
        <div class="middlecontainer">
            <div class="middlecontainer_left">
               <%-- <uc3:menubar ID="menubar1" runat="server" />--%>
            </div>
            <div class="middlecontainer_right" style="width:99%;">
                <div class="mid_body_myaccount_new">
                    <div class="mid_sec_new">
                        <div class="mid_over_myaccount">
                            <div class="headlines_1_new" style="display:none;">
                                <asp:Label ID="astro" runat="server" Text="Astrologer Detail" CssClass="new_font_new"></asp:Label>
                                <div style="float: right; padding: 0em 0.5em 0em 0em;" id="cngpwd" runat="server">
                                </div>
                            </div>
                            <div class="myacc_btn">
                                <asp:LinkButton ID="newclient" class="per_btn_121_new" runat="server">Create New Chart</asp:LinkButton>
                            </div>
                            <div id="whitediv" class="div_curve1_new" style="display:none;">
                                <div id="Divgrid1" class="divg">
                                    <table>
                                        <tr>
                                            <td runat="server" id="hdsviewgrid" style="width: 100%;" align="left">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <div class="div1update_new" style="display:none;">
                                <asp:LinkButton ID="update1" class="per_btn1_2_new" runat="server">Update</asp:LinkButton>
                                <asp:LinkButton ID="delete_0" class="per_btn1_2_new" runat="server" Style="visibility: hidden;">delete</asp:LinkButton>
                            </div>
                            <div class="div1btns_new">
                                <div class="div1btns_new_cat">
                                    <asp:Label ID="Label1" runat="server" Text="Category" Style="float: left;"
                                        CssClass="new_font2_new"></asp:Label>
                                    <asp:DropDownList ID="grp_cat" CssClass="drpo_homenew" Style="float: left; margin-left: 10px;"
                                        runat="server">
                                        <asp:ListItem>Select Category</asp:ListItem>
                                        <asp:ListItem>Natal</asp:ListItem>
                                        <asp:ListItem Selected="True">Horary</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="div1btns_new_group">
                                    <asp:Label ID="client" runat="server" Text="Group" Style="float: left;"
                                        CssClass="new_font2_new"></asp:Label>
                                    <asp:DropDownList ID="clgroup" CssClass="drpo_homenew" Style="float: left; margin-left: 10px;"
                                        runat="server">
                                    </asp:DropDownList>
                                </div>
                                <div class="div1btns_new_srchby">
                                    <asp:Label ID="seby" runat="server" Text="Search By" Style="float: left;" CssClass="new_font2_new"></asp:Label>
                                    <asp:DropDownList ID="sebyd" CssClass="drpo_homenew" Style="float: left; margin-left: 10px;"
                                        runat="server">
                                    </asp:DropDownList>
                                </div>
                                <div class="div1btns_new_srchbtn">
                                    
                                    <asp:LinkButton ID="sebyb" class="per_btn1_2_new" runat="server">Search</asp:LinkButton>&nbsp;&nbsp;
                                    <asp:TextBox ID="sebyt" Style="display: none;" runat="server"
                                        Width="150px" Height="25px" CssClass="textboxcss" Font-Overline="False" Font-Strikeout="False"
                                        ForeColor="Black"></asp:TextBox>
                                </div>
                            </div>
                            <div id="whitediv2" class="div_curve1m">
                                <div id="Divgrid2" class="divg">
                                    <table>
                                        <tr>
                                            <td runat="server" id="hdsviewgrid2" style="width:100%;" align="left">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <div class="div1update" style="display: none;">
                                <asp:LinkButton ID="update2" class="per_btn1" runat="server">Update</asp:LinkButton>
                            </div>
                            <%--<div class="myacc_btn">
                                <asp:LinkButton ID="newclient" class="per_btn_121_new" runat="server">Create New Chart</asp:LinkButton>
                            </div>--%>
                            <div class="button_manage" style="display: none;">
                                <asp:LinkButton ID="chartfilling" class="per_btn_12" runat="server">Create Chart</asp:LinkButton>
                            </div>
                            <%---- <asp:ImageButton ID="groupasfamily" runat="server" style="visibility:hidden" ImageUrl="~/Image/group.png" CssClass="button" /> ----%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    <input type="hidden" runat="server" id="Hidden1" />
    <input type="hidden" runat="server" id="Hidden9" />
    <input type="hidden" runat="server" id="hdnas" />
    <input type="hidden" runat="server" id="hdnasn" />
    <input type="hidden" runat="server" id="hdncat" />
    <input type="hidden" runat="server" id="hdnuser" />
    </form>
</body>
</html>
