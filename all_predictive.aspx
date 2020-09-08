<%@ Page Language="C#" AutoEventWireup="true" CodeFile="all_predictive.aspx.cs" Inherits="all_predictive" enableEventValidation="false" %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Predictive</title>
    <script type="text/javascript" language="javascript" src="javascript/allpredictive.js"></script>
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
     <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

 <link href="css/combine.css" type="text/css" rel="stylesheet" />
   <style type="text/css">
      
       .style1
       {
           width: 157px;
       }
      
   </style>
</head>
<body id="body"  style="background-color:#f3f6fd;margin:0px 0px 0px 0px">
    <form id="form1" runat="server">
     <table cellpadding="0" cellspacing="0">
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="All Predictive"></uc1:topbar></td>
    </tr>
    </table>
    <table>
	                <tr> <td>   
                                        
                     <table border="0" cellpadding="0" cellspacing="0" style="width:1000px">
                      <tr>
                     <td style="width:27px;"></td>
                     <td style="background-image:url(image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     
                      <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><center><b>ASTRO PREDICTIVE</b></center></td>
                    <%-- <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:25px;"><center><b> ASTRO EXTENTIONS</b></center></td>--%>
                     <td style="background-image:url(image/corner-right.jpg); background-repeat:no-repeat; height:25px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
				</tr>
				
				<tr>
				<td></td></tr>
				
				
                    </table>         
                    
                  </td>
                  </tr> 
                  
                  </table>
                  
                  
                  
    <table id="outertbl" cellpadding="0" cellspacing="0" width="1000px" style="border:2px solid;border-color:#7DAAE3;margin-left:0px">       
		
    <tr>
    
        <td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
       <table id="innertbl" cellpadding="2" cellspacing="2" width="1000px" style="border:1px solid;border-color:#7DAAE3;">
			  <tr>
			     <td><asp:Label ID="lblextentions" runat="server" Text="Name" ></asp:Label></td>
			     <td><asp:DropDownList ID="f1" runat="server" style="  height: 16px; width: 140px" >
                     <asp:ListItem>SELECT NAME</asp:ListItem>
                     <asp:ListItem>HOUSE_POSITIPON</asp:ListItem>
                     <asp:ListItem>HOUSE_POSITIPON_COMB</asp:ListItem>
                     <asp:ListItem>PLANET_ASPECT</asp:ListItem>
                     <asp:ListItem>PLANETFROMPLANET</asp:ListItem>
                     <asp:ListItem>BENIFICS_MALIFICS_ASPECT</asp:ListItem>
                     <asp:ListItem>PLANET_ASPECT_PLANET</asp:ListItem>
                     <asp:ListItem>EDM</asp:ListItem>
                     <asp:ListItem>CONSTELLATION_POSITION</asp:ListItem>
                     <asp:ListItem>QUADRAPED_COMBINATION</asp:ListItem>
                     <asp:ListItem>MULTIPLE_COMBINATIONS</asp:ListItem>
                     <asp:ListItem>COMBUSTION_DEGREE</asp:ListItem>
                     <asp:ListItem>YOGA_PREDICTIVE</asp:ListItem>
                     <asp:ListItem> HORARY_COMBINATION_PREDICTIVE</asp:ListItem>
                     <asp:ListItem> HORA_HOUSE_POSITIPON</asp:ListItem>
                     <asp:ListItem> HORA_HOUSE_POSITIPON_COMB</asp:ListItem>
                     <asp:ListItem>REMEDIAL_COMB</asp:ListItem>
                     <asp:ListItem>VARGAS_REPETITION</asp:ListItem>
                     <asp:ListItem>MOVED_ENTRY</asp:ListItem>
                     <asp:ListItem>ASTRO_KNOWLEDGE</asp:ListItem>
                    
 </asp:DropDownList></td>
 
 
 <td>
 <asp:Button ID="s1" runat="server"  Text="Search" />
 
 
 </td>
 <td><asp:TextBox ID="unique" runat="server" Width="100px"></asp:TextBox></td>
 <td><asp:Button ID="s2" runat="server" Text="search by id" /></td>
 
 <td style="padding-left:20px;" class="style1">
 <asp:Label ID="Label1" runat="server" Text="F2" ></asp:Label>
 <asp:TextBox ID="categery" runat="server" Width="100px" Height="15 px" >
 </asp:TextBox> 
 </td>
 
     <td>
 <asp:Button ID="sh" runat="server"  Text="Show" style="margin-left: -34px;" />
 <asp:Button ID="de" runat="server"  Text="Delete" />
 <asp:Button ID="ra" runat="server"  Text="Replace All" />
 <asp:Button ID="sf" runat="server"  Text="Add SubFilter" />

 </td>
  <tr><td>
 <td><asp:Label ID="Label2" runat="server" Text="From date"  style="margin-left: -41px;" ></asp:Label></td>
	     <td><asp:textbox id="Texttodate" runat="server"   CssClass="drpo_homenew" style=" margin-left: -127px;"></asp:textbox></td>
           <td> <img src='Image/cal1.gif'   onclick="popUpCalendar(this, form1.Texttodate,'dd/mm/yyyy',event)" class="calendra_homenew" alt="" style="margin-left: -104px;" /></td>
	     <td> <asp:Label ID="Label3" runat="server" Text="To date"  style="margin-left: -201px;"></asp:Label>
	 <td class="style1">  <asp:textbox id="todate" runat="server"    CssClass="drpo_homenew" Width="79px" style="margin-left: -255px;"></asp:textbox>
        <img src='Image/cal1.gif'   onclick="popUpCalendar(this, form1.todate,'dd/mm/yyyy',event)" class="calendra_homenew" alt=""  /></td>
         <td><asp:Button ID="datesearch" runat="server"  Text="Search by date"  style="margin-left: -313px;" /></td>
	      </tr>	 
			</tr> 
			
	    
				        </table></td>
	      </tr>
	  
		
		     <table><tr>
             <td>      
    <div id="divcategery" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstcategery" Width="190px" Height="75px" runat="server"   >
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
     </td></tr>
        </table>
	                                
	
	<table><tr>
             <td>      
    <div id="divsubcategery" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstsubcategery" Width="100px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
     </td></tr>
        </table>
        
        
	
	  <table>
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 758px">
<tr>

</tr>
<tr>

</tr>
<tr></tr>
<tr>
<td style="padding-left:20px;">

    <table >
    <tr>
    <td runat="server" id="Td1" style="width:200px;" align="left" ></td>
    </tr>
    </table></td>
      </tr>
</table>
</td>
</tr>                         
	  </table>
		  
	     <table>
<tr>
<td style="padding-left:00px;" >
<table align="left" cellspacing="0" cellpadding="0"  style="width: 900px">
<tr>

</tr>
<tr>

</tr>
<tr></tr>
<tr>
<td style="padding-left:00px;">
<div id="Divgrid2" style= "overflow:auto;display:none; width:1000px;  height:100px;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid2" style="width:700px;" align="left" ></td>
    </tr>
    </table></div></td>
      </tr>
</table>
</td>
</tr>                         
	  </table>	
	  
	  
	  
	  
	                               
	  

<tr>
<td style="padding-left:00px;">
<div id="Divgrid1" style= "overflow:auto;display:none; width:1000px; height:500px;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:1000px;" align="left" ></td>
    </tr>
    </table></div></td>
      </tr>

<%--</td>
<%--</tr>  --%>                    
	  </table>	
	  <table>
	  <tr>
	  <td>
	  <div id="replace_div" style="position:absolute;filter:alpha(Opacity=92, FinishOpacity=80, Style=0, StartX=0, FinishX=100, StartY=0, FinishY=100);top:0px;left:0px;padding:177px 50px;display:none;z-index:1;border:3px solid #a0bfeb; height:300px; width:900px"></div>  
	    </td>
	    </tr>
	    </table>
<table>
	  <tr>
	  <td>
	  <div id="subfilter" style="position:absolute;filter:alpha(Opacity=92, FinishOpacity=80, Style=0, StartX=0, FinishX=100, StartY=0, FinishY=100);top:0px;left:0px;padding:177px 50px;display:none;z-index:1;border:3px  height:300px; width:700px"></div>  
	    </td>
	    </tr>
	    </table>	
	<%--</table>--%>	  
		  <input type="hidden" runat="server" id="tblfields"/>
     <input type="hidden" runat="server" id="hiddendateformat"/>
     <input type="hidden" runat="server" id="fields" />
    <input type="hidden" runat="server" id="Hiddentxtextentions" /> 
     <input type="hidden" runat="server" id="hdnuserid" /> 
     <input type="hidden" runat="server" id="hiddenmodtxtextentions" />
     <input type="hidden" runat="server" id="hidden1" /> 
    </form>
</body>
</html>
