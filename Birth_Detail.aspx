<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Birth_Detail.aspx.cs" Inherits="Birth_Detail"  %>

<!doctype html><html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   
<meta charset="utf-8">
<title>Astrology</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<link type="text/css" rel="stylesheet" href="CSS/main.css">
<link type="text/css" rel="stylesheet" href="CSS/tablet.css">

<link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css">

     <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
     <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel = "Stylesheet" type = "text/css" href = "css/mystyle.css" />

<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">
    
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>


<script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

  <script type = "text/javascript" src = "javascript/astrologer.js"></script> 
  <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>
	  <script language="javascript" />
	  <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
	<style>
 nav select {
      display: none;
    }
 @media (max-width: 768px) {
	 nav ul     { display: none; }
		nav select { display: inline-block;}
     
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
	
	
	<script>
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
<body id="body" oncontextmenu="return false";>
    <form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="true" AsyncPostBackTimeout="6000">
    </asp:ScriptManager>
       <div id="list_state" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="state_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>


   <div id="list_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel71" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="city_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>

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


<div class="menu_main" style="margin: 20px auto;">
	<div class="menu" id="nav">
    	<ul>
        	<li id='Li1' runat="server"><a  href="#">Home</a></li>
        	<li id='Li9' runat="server" ><a href="#" >My Account</a></li>   
             <li id="Li2" runat="server"><a >Horary Yoga</a>
            <ul >
                        <li><a  href="#">Calculate Horary Yoga</a></li>
                        <li><a  href="#">Calculate Karyasiddhi Yoga</a></li>
                        
                    </ul></li>
            <li id='Li3' runat="server"><a  href="#" >Nature Of Query</a></li>
            <li id='Li7' runat="server"><a   href="#"  >Horary Significator</a></li>
            <li id='Li8' runat="server"><a   href="#"  >Horary Knowledge</a></li>
            <li id='Li6' runat="server"><a href="#">Horary Illustration</a></li>
            <li id='Li10' runat="server"><a  href="#">About us</a> </li>
            <li class="menu_last" id='Li11' runat="server"><a   href="#" >Log Out</a></li>
        </ul>
    </div>
</div>
        
  <div class="menu_main" style="margin: 20px auto;">
	<div class="menu" id="nav">
    	<ul>
        	<li id="a1" runat="server"><a href="#" >Home</a></li>
        	<li id="a9" runat="server" ><a href="#" >My Account</a></li>
            <li id="a6" runat="server"><a href="#"'>Natal Yoga</a></li>
            <li id="a7" runat="server"><a href="#">Natal Predictive</a></li>
            <li id="a3" runat="server"><a  href="#" >Natal Significators</a></li>
            <li id="a4" runat="server"><a  href="#" >Natal Knowledge</a></li>
            <li id="a5" runat="server"><a >Research Tool</a>
           <ul>
                        <li><a   href="#" >Planets in Various Awastha’s in Varga’s  </a></li>
                        <li><a   href="#" >Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a   href="#" >Planets in Rashi’s & House’s in Varga’s</a></li>
                        <li><a  href="#" >Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a  href="#" >Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a  href="#" >Conjunction of Planets – Number of Planets</a></li>
                        <li><a   href="#" >Search the  Single or Multiple Planets on Basis of Multiple Nakashtra/Constellation</a></li>
                        <li><a   href="#" >Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a   href="#" >Search for Aspects of Planet’s</a></li>
                        <li><a  href="#" >Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a  href="#" >Driskkan Division</a></li>
            </ul>
            </li>
             <li id="Li4" runat="server"><a href="#">Natal Calculation</a></li>
             <li id="Li5" runat="server"><a href="#">Remedial</a></li>
                <li id='Li12' runat="server"><a href="#">Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a  href="#" >Log Out</a></li>
        </ul>
    </div>
</div>

        
        
       <div class="mid_body_myaccount" style=" padding-bottom: 32px;" >
 <div class="mid_seca" >
   <div class="mid_over" style="padding-bottom: 8px;">  
        
    <fieldset>
    <div>
    <table cellspacing = "5" cellpadding  = "5" >
    
        <tr>
            <td>D.O.B <font class = "star"> *</font></td>
            <td class = "latter">
                  <asp:textbox id="dob" runat="server"  Width='70%' Enabled="true"  CssClass = "textbox"></asp:textbox>
                            <img src='Image/cal1.gif'   onclick="popUpCalendar(this, form1.dob,'dd/mm/yyyy',event)" height="14"
                            width="14" style="width: 14px" alt="" />
            </td>
        </tr>
         <tr>
            <td>T.O.B <font class = "star"> *</font></td>
            <td class = "latter">
                  <asp:textbox id="tob" runat="server"  Width='70%' Enabled="true" placeholder="00:00" CssClass = "textbox"></asp:textbox>
                   
            </td>
        </tr>
    <tr>
    <td>Country <font class = "star"> *</font></td><td class = "latter"><asp:DropDownList ID = "ddlcunt" runat = "server" Width  ="70%"  CssClass = "textbox"/></td>
    </tr>

         <tr>
    <td>State <font class = "star"> *</font></td><td class = "latter"><asp:TextBox ID = "ddlstat" runat = "server" Width  ="70%"  CssClass = "textbox"/></td>
    </tr>


    <tr>
    <td>City<font class = "star"> *</font></td><td class = "latter"><asp:TextBox ID = "city" runat = "server"  width = "70%" CssClass = "textbox" ></asp:TextBox></td>
    </tr>
    
        
    <tr>
    <td>Latitude<font class = "star"> *</font></td><td class = "latter"><asp:TextBox ID = "lat" runat = "server"  width = "70%" CssClass = "textbox"></asp:TextBox></td>
    </tr>

        
    <tr>
    <td>Longitude<font class = "star"> *</font></td><td class = "latter"><asp:TextBox ID = "lng" runat = "server"  width = "70%" CssClass = "textbox"></asp:TextBox></td>
    </tr>

        
    <tr>
    <td>Time Zone<font class = "star"> *</font></td><td class = "latter"><asp:TextBox ID = "tz" runat = "server"  width = "70%" CssClass = "textbox"></asp:TextBox></td>
    </tr>

    <tr>
     <td>
    <asp:LinkButton ID = "submit" class="per_btn"   runat="server">Submit</asp:LinkButton>
            
            </td>
    </tr>
  
    </table>
      
    </div>
      </fieldset>
      
      </div></div></div>
      
     
    
    </form>
     <input type="hidden" runat="server" id="hdnstate" />
    <input type="hidden" runat="server" id="hdnlat" />
    <input type="hidden" runat="server" id="hdnlng" />
 <input type="hidden" runat="server" id="hiddendateformat" />
    <input type="hidden" runat="server" id="hdncit" />

</body>
</html>
