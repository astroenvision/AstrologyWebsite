<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_tree_view.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="astro_tree_view"%>

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

    <link rel="stylesheet" type="text/css" href="http://docs.jquery.com/CSS/position">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">




<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
 <%--<script type="text/javascript" language="javascript" src="javascript/yoga.js"></script>--%>
<script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
<script language="javascript" src="javascript/astro_tree_view.js" type="text/javascript"></script>
   <script type="text/javascript">
   <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
<style>
.hideRoot
{
    display:none;
}
<style></style></style>
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
    
    
function getopen1(pagename)
{

window.parent.location.href="login.aspx";
}
</script>
  
   
    <style type="text/css"></style>
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
<body id="body1" oncontextmenu="return false";>
       <form id="form1" runat="server" method="post" defaultfocus="tb1"  >
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
          <div class="head_main">
    	<div class="head">
        		<div class="head_logo">	<img src="IMAGES/logo.jpg" /></div>
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
 
   <div class="menu_main_lower" id="horarydiv" runat="server" >
	<div class="menu" id="nav">
    	<ul>
        	<li id='Li1' runat="server"><a  href="#" >Home</a></li>
        	<li id='Li9' runat="server"><a  onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>My Account</a></li>   
             <li id="Li2" runat="server"><a  href="#">Horary Yoga</a>
            <ul >
                        <li><a >Calculate Horary Yoga</a></li>
                        <li><a >Calculate Karyasiddhi Yoga</a></li>
                        
                    </ul></li>
            <li id='Li3' runat="server"><a  href="#"  >Nature Of Query</a></li>
            <li id='Li7' runat="server"><a  onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer' >Horary Significator</a></li>
            <li id='Li8' runat="server"><a  onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer' >Horary Knowledge</a></li>
             <li id='Li13' runat="server"><a href="javascript:void(0);">Calculation</a>
            <ul>
                 <li><a href="#">Horary Calculation</a></li>
                 <li><a href="#">Probable Query</a></li>
            </ul>
            </li>
            <li id='Li6' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value+ "&gropunder=" + "Horary")' style='cursor:pointer' >Horary Illustration</a></li>
            <li id='Li10' runat="server"><a  href="#">About us</a> </li>
            <li class="menu_last" id='Li11' runat="server"><a  onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>

    <div class="menu_main_lower"  id="nataldiv" runat="server" >
	<div class="menu" id="nav">
    	<ul>
        	<li id="a1" runat="server"><a href="#" >Home</a></li>
        	<li id="a9" runat="server"><a  onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'">My Account</a></li>
            <li id="a6" runat="server"><a href="#">Natal Yoga</a></li>
            <li id="a7" runat="server"><a href="#">Natal Predictive</a></li>
            <li id="a3" runat="server"><a  onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Natal Significators</a></li>
            <li id="a4" runat="server"><a class="menu_Selact">Natal Knowledge</a></li>
            <li id="a5" runat="server"><a >Research Tool</a>
           <ul>
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Various Awastha’s in Varga’s  </a></li>
                        <li><a  onclick='javascript:getopen("ResearchTool_awastha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Planets in Rashi’s & House’s in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("researchtool_conjunction.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("research_tool_any.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of Planets – Number of Planets</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Search the  Single or Multiple Planets on Basis of Multiple Nakashtra/Constellation</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_aspect.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Aspects of Planet’s</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a onclick='javascript:getopen("ResearchTool_Driskkan.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Driskkan Division</a></li>
            </ul>
            </li>
             <li id="Li4" runat="server"><a href="#">Natal Calculation</a></li>
             <li id="Li5" runat="server"><a href="#">Remedial</a></li>
            <li id='Li12' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value+ "&gropunder=" + "Natal")' style='cursor:pointer' >Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>


<div class="mid_body_myaccount">
 <div class="mid_sec" >
   
 <div class="mid_over">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ><ContentTemplate>
 <div id="Div1" runat="server" class="div_curve  p h1 p2" style=" width: 300px;  overflow:auto;  border-width: 2px; ">
<asp:Label ID="ll1" runat="server" Text="Astro Search" Font-Bold="true" Font-Size="Small"></asp:Label>
 <asp:TextBox ID="tb1" runat="server" ontextchanged="tb1_TextChanged" style="margin-left:20px;" AutoPostBack="True" onfocus="SetCursorToTextEnd(this.id);"  />
 <asp:ImageButton ID="im1" runat="server" ImageUrl="~/Image/as.jpg" Font-Size="XX-Small"  /> 
</div>
</ContentTemplate></asp:UpdatePanel>
 
 
    	
<div id="data_tree" runat="server"  class="div_curve  p h1 p2" style="float:left; width: 300px; height:440px; max-height:440px; overflow:auto; float:left; border-width: 2px;">
                    
      
   <asp:TreeView ID="TreeView1" runat="server" >
   </asp:TreeView>
     
</div>
    
 
    <div id="Div2" runat="server" class="div_curve1  p h1 p2" style="float:left; width:620px; height:20px;border-width: 2px; margin-left:20px;">
        <asp:Label id="Label4"   runat="server"  style=" font-size: medium; margin-left: 10px;" ></asp:Label>
        </div>
	<div id="show_data" runat="server" class="div_curve1  p h1 p2" style="float:left;position:static; width:620px; height:400px;border-width: 2px; margin:20px;margin-top:10px;  overflow:auto;">
	 <asp:Label id="Label3"    runat="server"  style="color: Black; font-size: medium; margin-left: 209px;" ></asp:Label>
	<div id="data_shoe_div" runat="server"  style="height: auto;color:inherit !important; max-height:357px; overflow:auto;font-size:14px !important;font-family:Arial !important; border:1px solid black !important; margin-top: 16px; border-width:1px; margin-bottom: 14px; border-style: double; ">

	</div>
	 <asp:Label id="Label1"   runat="server"  style="color: Black; font-size: medium; margin-left: 209px;" ></asp:Label>
	<div id="data_shoe_div1" runat="server" style="height: auto; max-height:80px; overflow:auto; border-color:Black ; margin-top: 16px; border-width:1px;  margin-bottom: 14px; border-style: double;"></div>
	 <asp:Label id="Label2"    runat="server"  style="color: Black; font-size: medium; margin-left: 209px; display:none;"  ></asp:Label>
	<div id="data_shoe_div2" runat="server" style="height: auto; display:none; max-height:80px; overflow:auto; border-color:Black ; margin-top: 16px; border-width:1px;   border-style:double; margin-bottom: 14px;"></div>
	  </div>


   
   
    
   
</div>
</div>
</div>


<%-- <div class="menu_mainf">
	<div class="menuf" id="nav">
    	<ul>
        	<li id="a1l" runat="server"  ><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a href="#">PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a href="#" class="menu_Selact">ASTRO KNOWLEDGE</a></li>
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
<input type="hidden" runat="server" id="treechild" />
 <input type="hidden" runat="server" id="hdnuser" />  
           <input type="hidden" runat="server" id="hdnsv" />
    </form>
</body>
</html>
