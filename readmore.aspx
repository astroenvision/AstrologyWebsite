<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="readmore.aspx.cs" Inherits="readmore" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>read more</title>
       <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<link type="text/css" rel="stylesheet" href="CSS/main.css">
<link type="text/css" rel="stylesheet" href="CSS/tablet.css">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

<!--[if lt IE 9]>
	<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->
<style>
 nav select {
      display: none;
    }
 @media (max-width: 768px) {
	 nav ul     { display: none; }
		nav select { display: inline-block;}
     
    }
	</style>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
<script language="javascript" type="text/javascript" src="javascript/readmore.js"></script>
 <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
 <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

	<script>
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
	<script type="text/javascript"><!--
google_ad_client = "pub-9581515182700674";
/* 300x250, created 11/10/11 */
google_ad_slot = "6375179487";
google_ad_width = 300;
google_ad_height = 250;
//-->
</script>

</head>
<body id="body" oncontextmenu="return false"; onload="buttonhide()";>
    <form id="form1" runat="server">
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
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script></div>
        </div>
        <div style="clear:both"></div>
</div>

<div class="menu_main_lower" style="margin: 20px auto;">
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
            
             <li id='Li13' runat="server"><a href="javascript:void(0);">Calculation</a>
            <ul>
                 <li><a href="#">Horary Calculation</a></li>
                 <li><a href="#">Probable Query</a></li>
            </ul>
            </li>
            <li id='Li6' runat="server"><a href="#">Horary Illustration</a></li>
            <li id='Li10' runat="server"><a  href="#">About us</a> </li>
            <li class="menu_last" id='Li11' runat="server"><a   href="#" >Log Out</a></li>
        </ul>
    </div>
</div>
        
  <div class="menu_main_lower" style="margin: 20px auto;">
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
 <div class="mid_body" style=" padding-bottom: 74px;" >
 <div class="mid_sec" >
   <div class="mid_over" style="padding-bottom: 8px;">
            
           <div id="replace_div" runat="server" class="read_more_replace_div">
            
           </div>
            <div class="mid_div3">
            	<div class="mid_section3">
            
                <div class="login">
				  <section class="login_section1">
                   		<div>LOGING</div>
                    	<div><img src="images/login.png" width="35" height="35" alt="login"></div>	
                  </section>
					<section class="login_section2">
                    	<div><input type="radio" name="group1" runat="server" value="Administrator" id="r1"  >Administrator</div>
               	      <div><input type="radio" name="group1" runat="server" value="Astrologer" id="r2" checked>Astrologer</div>
                    </section>
					<section class="login_section3">
                    	<div>User Id<asp:TextBox name="" type="text" runat="server" id="txtusername1"/></div>
               	      <div>Password<asp:TextBox name="" type="text" runat="server" id="txtpwd1" 
                              TextMode="Password"/></div>
                    </section>
			      <section class="login_section4">
                  	<div id="linkabutton1" runat="server"><asp:LinkButton ID="LinkButton1"  runat="server" OnClick="LinkButton1_Click">Sign in</asp:LinkButton></div>
                <div id="linkabutton2" runat="server" ><asp:LinkButton ID="LinkButton2"  runat="server" OnClick="LinkButton2_Click">Sign Up</asp:LinkButton></div>
               </section>
                 <section ><div id="linkabutton3" runat="server" style="margin-left:110px; margin-bottom:10px" ><asp:LinkButton ID="linkbutton3" class="per_btn"   runat="server"   OnClientClick="login1()" >Submit</asp:LinkButton></div> </section>
                </div>
                <div>
                	
              </div>
    </div>
          </div> <div class="adver"><script type="text/javascript"><!--
google_ad_client = "pub-9581515182700674";
/* 300x250, created 11/10/11 */
google_ad_slot = "6375179487";
google_ad_width = 280;
google_ad_height = 250;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>
</div>
        
      
      
       </div>

</div>
</div>





                                                <INPUT type="hidden" name="UserLabel" runat="server" id="UserLabel">
												   <input type="hidden" name="UserLabel" runat="server" id="hiddenmysql">
													<input type="hidden" name="UserLabel" runat="server" id="hiddendepo">
													<input type="hidden" name="UserLabel" runat="server" id="hiddenshowrdbtn">
													<input type="hidden" name="UserLabel" runat="server" id="huser">
													 <input type="hidden" runat="server" id="hiddendateformat" />
													<input type="hidden" name="UserLabel" runat="server" id="hpass">
													 <input type="hidden" runat="server" id="head1" /> 
                                                     <input type="hidden" runat="server" id="keyword1" /> 
                                                        <input type="hidden" runat="server" id="snopsis1" /> 
                                                        <input type="hidden" runat="server" id="story1" /> 
                                                         <input type="hidden" runat="server" id="link1" />
                                                          <input type="hidden" runat="server" id="link2" /> 
                                                          <input type="hidden" runat="server" id="link3" /> 
                                                           <input type="hidden" runat="server" id="himg" /> 
                                                              <input type="hidden" runat="server" id="hstr" /> 
                                                           


    </form>
</body>
</html>
