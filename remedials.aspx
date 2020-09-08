<%@ Page Language="C#" AutoEventWireup="true" CodeFile="remedials.aspx.cs" Inherits="remedials"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

  
<meta charset="utf-8">
<title>Astrology</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  
<link type="text/css" rel="stylesheet" href="CSS/main.css"/>
<link type="text/css" rel="stylesheet" href="css/tablethararycomb.css"/>
<link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css">


    <link rel="Stylesheet" href="css/combine.css" type="text/css" />


<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">



<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
 <script type="text/javascript" language="javascript" src="javascript/remedials.js"></script>

<script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
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
    {window.parent.location.href="login.aspx";
    }
</script>
  
   
    <style type="text/css"></style>
</head>
<body oncontextmenu="return false"; onload="vargaschart11()";>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
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
            <li id="a3" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Natal Significators</a></li>
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
             <li id="Li4" runat="server"><a  href="#">Natal Calculation</a></li>
             <li id="Li5" runat="server"><a class="menu_Selact">Remedial</a></li>
            <li id='Li12' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")' style='cursor:pointer' >Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>
 <div class="mid_body" style=" padding-bottom: 74px;" >
 <div class="mid_sec" style="padding-bottom: 5px;" >
 <div class="mid_over">
    <div id="Div1" class="div_header" >
  <div class="d_header_1 h_filters">    
       
    <span class="filterss">
   <asp:Label id="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer Name :" runat="server" >
   </asp:Label>
   <asp:Label id="astname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" >
   </asp:Label>
  </span>
  
  <span class="filterss">
   <asp:Label id="Label3"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer ID :" runat="server" >
   </asp:Label>
   <asp:Label id="astid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"   runat="server" >
   </asp:Label>
   </span>
  <span class="filterss">
   
   <asp:Label id="Label5"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client Name :" runat="server" >
   </asp:Label>
   <asp:Label id="clientname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"   runat="server" >
   </asp:Label>  
  </span>
  
  <span class="filterss">
  
   <asp:Label id="Label4"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client ID :" runat="server" >
   </asp:Label>
   <asp:Label id="clientid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" ></asp:Label>
  </span>
   
   
   </div>
   
   </div>
   
   <div id="whitediv" class="div_curve_combi "  style="height: 400px;">
   <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
   <div class="hc" >
      
       <div class="MenuBar" style="max-height:300px; overflow:auto; width:200px; float:left;">
	
         <asp:Menu ID="menuBar" runat="server" Orientation="Vertical" Width="100%"   onmenuitemclick="Menu1_MenuItemClick" Font-Names="PT Sans Narrow" Font-Size="14px" Font-Weight="600"
                                ForeColor="#034a86" StaticSubMenuIndent="10px">
		<StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <DynamicHoverStyle BackColor="#3aa6f7" ForeColor="White" />
                                   
                                    <DynamicSelectedStyle BackColor="#3aa6f7" />
                                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <StaticHoverStyle BackColor="#3aa6f7" ForeColor="White" />
	</asp:Menu>
         
</div>
          


   <table >
   <tr>
       <td style="display:none;"> 
           <asp:Label id="Label1"  Text="Remedials" runat="server" ></asp:Label>
           <asp:DropDownList ID="mainfilter" CssClass="drpo_homenew" runat="server"></asp:DropDownList> 
       </td>

       <td style="display:none;">
           
            <asp:DropDownList ID="subfilter" CssClass="drpo_homenew" runat="server" ></asp:DropDownList>
       </td>
    
       <td>
           
            <asp:DropDownList ID="remedies" CssClass="drpo_homenew" runat="server" ></asp:DropDownList>
       </td>

        <td id="lg" runat="server" style="display:none;">
           
            <asp:DropDownList ID="lagna" CssClass="drpo_homenew"  runat="server" ></asp:DropDownList>
       </td>

       <td>
            <asp:LinkButton ID="search" class="per_btn"   runat="server"  style=" width:120px; " >Search</asp:LinkButton>
       </td>
   
       <td style="display:none">
            <asp:Label ID="labchart"  runat="server" Text="Chart"  ></asp:Label>
       </td>
       
       <td style="display:none">
            <asp:DropDownList ID="vargaschart" CssClass="drpo_homenew" runat="server"  ></asp:DropDownList>        
       </td>
   
   </tr>
   
   

       
   
    
    
    
    </table>
    
</div>

 </ContentTemplate></asp:UpdatePanel>


 <div class="divhoraryr" >
    <div class="loadingimage" id="img1"  runat ="server"  style=" display:none; margin-left:300px;">
    <img src="Image/preloader_transparent.gif" alt="hello"/>
 </div>  
    <div id="Divgrid1" class="horary_combination_cssre"  style="border: 1px solid #7DAAE3;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:395px;" align="left"></td>
    </tr>
    </table></div>
    
    
    <span id="Label6" style="color: Black; font-size: small; font-weight: bold; width: 34px; margin:5px; margin-left: 180px;"></span>
     <div id="Divgrid2" class="horary_combination_cssre">
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid2" style="width:550px;" align="left"></td>
    </tr>
    </table></div>
   
   </div>
   
   
   

       
      

      
<div id="vargasdiv" runat="server" style="float:left; width:36%;">

   <div class="columnd01hcr" id="rashiidd01" >
        
            	<div class="column-div1">	
                	 <span >
                     <asp:Label ID="h1l1d01" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                 
                 <div class="column-divr1">
                     <span>
                     <asp:Label ID="h1rd01" runat="server" Text=""  >
                    </asp:Label></span>
                 </div>
                    
                <div class="column-div2">	
                	 <span >
                    <asp:Label ID="h2l1d01" runat="server" Text="" >
                    </asp:Label>
                   </span>
                  
                    
                </div>
                
                 <div class="column-divr2">
                      <span>
                    <asp:Label ID="h2rd01" runat="server" Text="" >
                    </asp:Label>
                   </span>
                 </div>
                 
                 
                <div class="column-div3">	
                	<span >
                     <asp:Label ID="h3l1d01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                 <div class="column-divr3">
                     <span>
                     <asp:Label ID="h3rd01" runat="server" Text=""   >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div4">	
                	 <span >
                    <asp:Label ID="h4l1d01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr4">
                    <span>
                    <asp:Label ID="h4rd01" runat="server" Text="" >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div5">	
                	<span >
                    <asp:Label ID="h5l1d01" runat="server" Text=""  >
                    </asp:Label>
                   </span>
               </div>
                
                 <div class="column-divr5">
                    <span>
                    <asp:Label ID="h5rd01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div6">	
                	 <span>
                    <asp:Label ID="h6l1d01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                 <div class="column-divr6">
                   <span>
                    <asp:Label ID="h6rd01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div7">	
                	 <span >
                    <asp:Label ID="h7l1d01" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr7">
                  <span>
                    <asp:Label ID="h7rd01" runat="server" Text=""  >
                    </asp:Label>
                  </span>
                </div>
                
                <div class="column-div8">	
                	<span >
                    <asp:Label ID="h8l1d01" runat="server" Text=""  >
                    </asp:Label></span>
                </div>
                
                 <div class="column-divr8">
                  <span>
                   <asp:Label ID="h8rd01" runat="server" Text=""  >
                   </asp:Label>
                  </span>
                </div>
                
                
                <div class="column-div9">	
                	<span >
                    <asp:Label ID="h9l1d01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr9">
                  <span>
                    <asp:Label ID="h9rd01" runat="server" Text="" >
                    </asp:Label>
                   </span>
                </div>
                
                <div class="column-div10">	
                	<span>
                    <asp:Label ID="h10l1d01" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr10">
                  <span>
                    <asp:Label ID="h10rd01" runat="server" Text=""  >
                    </asp:Label>
                  </span>
                </div>
                
                <div class="column-div11">	
                	<span >
                     <asp:Label ID="h11l1d01" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                 <div class="column-divr11">
                  <span>
                     <asp:Label ID="h11rd01" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                <div class="column-div12">	
                	<span >
                    <asp:Label ID="h12l1d01" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                 <div class="column-divr12">
                  <span>
                    <asp:Label ID="h12rd01" runat="server" Text="" >
                    </asp:Label>
                  </span>
                </div>
                
            	<figure class="fixedratio"></figure>
             </div>
             
             

           <%-- <div class="column" id="rashiid"  >
        
            	<div class="column-div1">	
                	 <span >
                     <asp:Label ID="h1l1" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                
                 <div class="column-divrv1">
                     <span>
                     <asp:Label ID="h1r" runat="server" Text=""  >
                    </asp:Label></span>
                 </div>
                 
                
                <div class="column-div2">	
                	 <span >
                    <asp:Label ID="h2l1" runat="server" Text="" >
                    </asp:Label>
                   </span>
                   
                    
                </div>
                 <div class="column-divrv2">
                     <span>
                    <asp:Label ID="h2r" runat="server" Text="" >
                    </asp:Label>
                   </span>
                 </div>
                
                <div class="column-div3">	
                	<span >
                     <asp:Label ID="h3l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divrv3">
                   <span>
                     <asp:Label ID="h3r" runat="server" Text=""   >
                    </asp:Label></span>
                 </div>
                 
                 
                <div class="column-div4">	
                	 <span >
                    <asp:Label ID="h4l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                <div class="column-divrv4">
                  <span>
                    <asp:Label ID="h4r" runat="server" Text="" >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div5">	
                	<span >
                    <asp:Label ID="h5l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                  <div class="column-divrv5">
                 <span>
                    <asp:Label ID="h5r" runat="server" Text=""  >
                    </asp:Label>
                   
                   </span>
                 </div>
                
                
                <div class="column-div6">	
                	 <span>
                    <asp:Label ID="h6l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                <div class="column-divrv6">
                 <span>
                    <asp:Label ID="h6r" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div7">	
                	 <span >
                    <asp:Label ID="h7l1" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                 <div class="column-divrv7">
                 <span>
                    <asp:Label ID="h7r" runat="server" Text=""  >
                    </asp:Label>
                    
                    </span>
                 </div>
                
                <div class="column-div8">	
                	<span >
                    <asp:Label ID="h8l1" runat="server" Text=""  >
                    </asp:Label></span>
                </div>
                 <div class="column-divrv8">
                <span>
                    
                    <asp:Label ID="h8r" runat="server" Text=""  >
                    </asp:Label>
                    
                    </span>
                 </div>
                
                
                <div class="column-div9">	
                	<span >
                    <asp:Label ID="h9l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                 <div class="column-divrv9">
               <span>
                    <asp:Label ID="h9r" runat="server" Text="" >
                    </asp:Label>
                   
                    </span>
                 </div>
                
                <div class="column-div10">	
                	<span>
                    <asp:Label ID="h10l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                <div class="column-divrv10">
               <span>
                    <asp:Label ID="h10r" runat="server" Text=""  >
                    </asp:Label>
                    
                    </span>
                 </div>
                
                <div class="column-div11">	
                	<span >
                     <asp:Label ID="h11l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                <div class="column-divrv11">
               <span>
                     <asp:Label ID="h11r" runat="server" Text=""  >
                    </asp:Label>
                   
                     </span>
                 </div>
                
                <div class="column-div12">	
                	<span >
                    <asp:Label ID="h12l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                  <div class="column-divrv12">
              <span>
                    <asp:Label ID="h12r" runat="server" Text="" >
                    </asp:Label>
                   
                    </span>
                 </div>
            	<figure class="fixedratio"></figure>
             </div>--%>
                
</div> 
            
           
            
   <div id="Div2" class="searchdiv">
    <table >
    <tr>
    <td runat="server" id="dhdsviewgrid2" style="width:600px;" align="left" ></td>
    </tr>
    </table></div>
      
      
      
    

<div id="Div3" style= "overflow:auto;display:none; width:600px; height:260px;" >
    <table >
    <tr>
    <td runat="server" id="dhdsviewgrid3" style="width:600px;" align="left" ></td>
    </tr>
    </table></div>
   </div>
   
   
   
   
   
   </div>
   </div>
   </div>
   
<%--   <div class="menu_mainf"  >
	<div class="menuf" id="Div4">
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

    
    
    
     <input type="hidden" runat="server" id="Hs" />
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
    <input type="hidden" runat="server" id="hdnuser" />
    <input type="hidden" runat="server" id="Hrashie" />
   <input type="hidden" runat="server" id="Hretro" />
    <input type="hidden" runat="server" id="Hidden9" />
    <input type="hidden" runat="server" id="Hiddenva" />
    <input type="hidden" runat="server" id="Hidden8" />
      <input type="hidden" runat="server" id="Hidden5d01" />
    </form>
</body>
</html>
