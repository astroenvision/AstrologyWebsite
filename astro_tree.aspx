<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_tree.aspx.cs" Inherits="astro_tree" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

  
<meta charset="utf-8">
<title>Astrology</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  
<link type="text/css" rel="stylesheet" href="CSS/main.css"/>
<link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css"/>
<link type="text/css" rel="stylesheet" href="css/tabeletyoga.css">


    <link rel="Stylesheet" href="css/combine.css" type="text/css" />


<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">




<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
 <%--<script type="text/javascript" language="javascript" src="javascript/yoga.js"></script>--%>
<script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
<script language="javascript" src="javascript/astroo_tree.js" type="text/javascript"></script>
   <script type="text/javascript">
   <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

<style>
 nav select {
      display: none;
    }
 @media (max-width: 768px) {
	 nav ul     { display: none; }
		nav select { display: inline-block;}
     
    }
	</style>


    <script>
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
   
    
<script>
    var popUpWin = 0;



    function getopen(pagename) {

        if (popUpWin) {
            if (!popUpWin.closed) popUpWin.close();
        }

        popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

    }
</script>
  
   
    <style type="text/css"></style>
</head>
<body>
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
          <div class="head_main">
    	<div class="head">
        	<div class="head_logo">Astrology</div>
        <div class="head_ad"><script type="text/javascript"><!--

                                 google_ad_client = "ca-pub-9581515182700674";

                                 /* 468x60, created 6/17/11 */

                                 google_ad_slot = "6032384492";

                                 google_ad_width = 468;

                                 google_ad_height = 60;

//-->

</script>

<script type="text/javascript"

src="http://pagead2.googlesyndication.com/pagead/show_ads.js">

</script></div>
        </div>
        <div style="clear:both"></div>
</div>
 <div class="menu_main_lower">
	<div class="menu">
    	<ul>
        	<li ><a href="#" >HOME</a></li>
        	<li><a href="#">PREDICTIVE SUPPORT</a></li>
            <li><a onclick='javascript:getopen("significator.aspx")' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li><a>RESEARCH TOOL</a></li>
            <li><a onclick='javascript:getopen("chartindex.aspx")' style='cursor:pointer'>CHART INDEX</a></li>
           <li><a onclick='javascript:getopen("horarysignificator.aspx")' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
             <li><a onclick='javascript:getopen("hoarary_knowledge.aspx")' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
              <li><a onclick='javascript:getopen("astro_tree_view.aspx")' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
            <li><a href="#">ABOUT US</a> </li>
            <li><a onclick='javascript:getopen("myaccount.aspx")' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li class="menu_last"><a onclick='javascript:getopen("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
</div>
<div class="mid_body" style=" padding-bottom: 74px;">
 <div class="mid_sec" >
 <div class="mid_over">
  <div class="div_header_significator" style="height: 323px;">
 <div  style="margin-left: 7px;">
 <asp:Label ID="Label3" runat="server" Text="Select Node Type"  ></asp:Label>
<asp:DropDownList ID="drop_parent" runat="server" >
    <asp:ListItem Value="0">Select Node type </asp:ListItem>
    <asp:ListItem>Parent</asp:ListItem>
    <asp:ListItem>Child</asp:ListItem>
     </asp:DropDownList>

<asp:Label ID="l1" runat="server" Text="Node Name" style="margin-left: 32px;" ></asp:Label>
<asp:TextBox ID="node_name" runat="server"  ></asp:TextBox>
 



 
 <asp:Label ID="Label2" runat="server" Text="Group Name" style=" visibility:hidden;"></asp:Label>
 <asp:TextBox ID="group_text" runat="server"  style=" visibility:hidden;"  ></asp:TextBox>
 </div> 
 <div>
<div  style="margin-left: 7px;">
 <asp:Label ID="Label1" runat="server" Text="Explanation"></asp:Label>
 </div>
 <div style="margin-top: -11px; margin-left: 89px;">
 <asp:TextBox ID="explanation_text" runat="server" TextMode="MultiLine" Width="200px" Height="80px" ></asp:TextBox>
 </div>
 
 <div   style="margin-left: 301px; margin-top: -86px;">
 <asp:Label ID="Label4" runat="server" Text="Explanation 2"></asp:Label>
 </div>
 <div  style="margin-top: -15px; margin-left: 387px;">
 <asp:TextBox ID="explanation_text2" runat="server" TextMode="MultiLine" Width="200px" Height="80px" ></asp:TextBox>
 </div>
 
 <div  style="margin-top: -85px; margin-left: 601px;">
 <asp:Label ID="Label5" runat="server" Text="Explanation 3"></asp:Label>
 </div>
 <div  style="margin-top: -16px; margin-left: 686px;">
 <asp:TextBox ID="explanation_text3" runat="server" TextMode="MultiLine" Width="200px" Height="80px" ></asp:TextBox>
 </div>
 </div>
 
 <div style="margin-left: 464px; margin-top: 14px; padding-bottom: 9px;">
         
              <asp:LinkButton ID="submit" class="per_btn1_2"    runat="server"  >Save</asp:LinkButton>
</div>

<div id="Divgrid1" class="divg_hora" style="margin-left: 310px; width: 450px; margin-top: 3px; height: auto; max-height: 152px;" >
    <table >   
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:600px;" align="left" ></td>  
   </tr> </table></div>
 
 
 
 </div> 
 
 
 
 
 
 
 
 
 </div>
 </div>
 </div>
     <div class="menu_main_lower">
	<div class="menu">
    	<ul>
        	<li ><a href="#" >HOME</a></li>
        	<li><a href="#">PREDICTIVE SUPPORT</a></li>
            <li><a onclick='javascript:getopen("significator.aspx")' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li><a>RESEARCH TOOL</a></li>
            <li><a onclick='javascript:getopen("chartindex.aspx")' style='cursor:pointer'>CHART INDEX</a></li>
            <li><a onclick='javascript:getopen("horarysignificator.aspx")' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li><a onclick='javascript:getopen("hoarary_knowledge.aspx")' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
             <li><a onclick='javascript:getopen("astro_tree_view.aspx")' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
            <li><a href="#">ABOUT US</a> </li>
            <li><a onclick='javascript:getopen("myaccount.aspx")' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li class="menu_last"><a onclick='javascript:getopen("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
</div>
    </form>
</body>
</html>
