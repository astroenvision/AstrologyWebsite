<%@ Page Language="C#" AutoEventWireup="true" CodeFile="significator.aspx.cs" Inherits="significator" %>

<!doctype html><html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   
<meta charset="utf-8">
<title>Astorylogy</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<link type="text/css" rel="stylesheet" href="CSS/main.css">
<link type="text/css" rel="stylesheet" href="CSS/tabletsignificator.css">
<link href="css/combine.css" type="text/css" rel="stylesheet" />
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

<script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    
     <script type="text/javascript" language="javascript" src="javascript/significator.js"></script>
 
    <script  src="javascript/prototype.js" type="text/javascript"></script>

	
	
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
	
	
	<script>
var popUpWin = 0;
function getopen(pagename)
{

if(popUpWin)
       {
            if(!popUpWin.closed) popUpWin.close();
       }

	popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

}
function getopen1(pagename)
{
window.parent.location.href="login.aspx";
}

    </script>
 
   
  
   
   
    
</head>
<body oncontextmenu="return false";>
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
             <li id='Li6' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Horary")' style='cursor:pointer' >Horary Illustration</a></li>
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
            <li id="a3" runat="server"><a class="menu_Selact">Natal Significators</a></li>
            <li id="a4" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Natal Knowledge</a></li>
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
            <li id='Li12' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")' style='cursor:pointer' >Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>


 <div class="mid_body_myaccount"  >
 <div class="mid_sec" >
   <div class="mid_over">
  <div id="Div2" class="div_header_significator" >
        
	
    <div runat="server" style="float:left;" class="d_header_3s">
    <asp:DropDownList ID="texthouse" CssClass="drpo_homenew signidrp" runat="server"      >
    </asp:DropDownList>
    
      
    
    <asp:DropDownList ID="planet" CssClass="drpo_homenew signidrp" runat="server"     > 
    </asp:DropDownList>
    
    
    
    <asp:DropDownList ID="rashi" CssClass="drpo_homenew signidrp" runat="server"     >
    </asp:DropDownList>
     
     
     <div class="butt_div">
    <asp:LinkButton ID="exte" runat="server" class="per_btn signidrp">Choose Categories</asp:LinkButton>
    </div>
    </div>
   
    
    <div runat="server" class="d_header_3s">
    
    
     <asp:Label ID="Label2" CssClass="signidrp" ForeColor="Black" runat="server" Text="Multiple Significator" Font-Size="Small">
     </asp:Label>
     
     
     
     <asp:TextBox ID="Textname" CssClass="signidrp_1" runat="server"  >
     </asp:TextBox>
     
     
     
     <div class="butt_div_1">
     <asp:LinkButton ID="ms"  runat="server"  class="per_btns per_btn signidrp" >Multiple Significator</asp:LinkButton>
     </div>
     </div> 
    
      
      <div class="d_header_3s">
      <asp:Label ID="Label6" runat="server" CssClass="signidrp" ForeColor="Black" Text="General Significators[*F2]">
     </asp:Label>
     
     
     
     <asp:TextBox ID="gs" runat="server" CssClass="signidrp"  >
     </asp:TextBox> 
     </div>
     
     </div>





<div id="whitediv1" class="div_curve1"">       
<div id="Divgrid2" class="div2signi">
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid2" style="width:300px;" align="left" ></td>
    </tr>
    </table></div>

<div id="Divgrid1" class="div1signi">
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:450px;" align="left" ></td>
    </tr>
    </table></div>

        
        
      </div>  
        
       </div>
        </div>
        
        </div>
       <%--  <div class="menu_mainf" >
	<div class="menuf" id="nav">
    <ul>
        	<li id="a1l" runat="server" ><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a onclick='javascript:getopen("homenewpage.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a href="#" class="menu_Selact">SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
            <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6l" runat="server"><a>CHART INDEX</a></li>
              <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
               <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>   
            <li id="a10l" runat="server"> <a href="#">ABOUT US</a> </li>
            
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
</div>--%>
 
        
      
        
        
        <input type="hidden" runat="server" id="tblfields"/>
     <input type="hidden" runat="server" id="hiddendateformat"/>
     <input type="hidden" runat="server" id="fields" />
     
     
<input id="hdnunit" type="hidden" runat="server" name="hdnunit"/>
<input id="hdncompcode" type="hidden" runat="server" name="hdncompcode"/>
<input id="hdnuserid" type="hidden" runat="server" name="hdnuserid"/>
<input id="hidercode" type="hidden" runat="server" name="hidercode"/>
<input id="tooltipxml" type="hidden" runat="server" name="tooltipxml"/>

<input type="hidden" runat="server" id="executefields" />
<input type="hidden" runat="server" id="deltblfields" />

<input id="hdncompname" type="hidden" runat="server" name="hdncompname"/>
<input type="hidden" id="hdnduplicacy" runat="server" />


<input type="hidden" id="hdndateformat" runat="server" />
<input type="hidden" id="hdntablename" runat="server" />
<input type="hidden" id="hdnalert" runat="server" />
<input type="hidden" id="Hidden1" runat="server" />
<input type="hidden" id="tblfieldsupdate" runat="server" />
<input type="hidden" id="systemdate1" runat="server" />
<input type="hidden" id="Hidden2" runat="server" />
<input type="hidden" id="hdn_user_right" runat="server" />

<input type="hidden" runat="server" id="Hidden3" />
<input type="hidden" runat="server" id="fieldsupdate" />
<input type="hidden" runat="server" id="HDN_server_date" />
<input type="hidden" runat="server" id="hdngridQuery" />  


<input type="hidden" runat="server" id="wfields" />
<input type="hidden" runat="server" id="hiddenvalue" />
<input type="hidden" runat="server" id="hiddenfilename" />  
<input type="hidden" runat="server" id="hiddenjobid" />  
<input type="hidden" runat="server" id="Hidden4" />  
<input type="hidden" runat="server" id="Hidden5" />  
<input type="hidden" runat="server" id="Hiddencompcode" />
<input type="hidden" runat="server" id="Hiddenrashi" />
<input type="hidden" runat="server" id="Hiddenhouse" />

<input type="hidden" runat="server" id="Hiddenplanet" />
<input type="hidden" runat="server" id="Hiddenbook" />
<input type="hidden" runat="server" id="Hiddenpage" />
<input type="hidden" runat="server" id="Hiddendesc" />
<input type="hidden" runat="server" id="Hiddendetail" /> 
<input type="hidden" runat="server" id="Hiddenid" />
<input type="hidden" runat="server" id="Hiddenext" />     
<input type="hidden" runat="server" id="Hidden7" />       
<input type="hidden" runat="server" id="Hidden6" />   
       <input type="hidden" runat="server" id="hdnuser" />  
    
    </form>
</body>
</html>
