<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astrodegree.aspx.cs" Inherits="astrodegree"  enableEventValidation="true"%>
<%@ register TagPrefix="uc1" TagName="topbar" Src="topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="leftbar.ascx"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASTRO Degree</title>
    
   <script type="text/javascript" language="javascript" src="javascript/astrodegree.js"></script>
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript">

</script>
    <style type="text/css">
      
    </style>
</head>
<body  id="body" onload="gridcall()"; style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
    <form id="form1" runat="server">
   
   
    
   <table cellpadding="0" cellspacing="0">
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="extentions"></uc1:topbar></td>
    </tr>
    </table>
     <table id="outertable" width="400px" border="0" cellpadding="0" cellspacing="0">
          <tr>
                                             <td valign="top" style="width: 184px"><uc2:leftbar id="Leftbar1" runat="server"></uc2:leftbar></td>
	
	                                       <td valign="top">
						
 </td>
</tr>
</table> 
	                
	      <table>
	      <tr>
	      <td height="10px"></td>
	      
	      </tr>
	      
	      </table>         
	                
	                
	                <table>
	                <tr> <td>   
                    
                        <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center>  Astrodegree Master</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>           
                    
                           
                    
                  </td>
                  </tr> 
                  
                  </table>
             <table>
             <tr>
             <td>   
			<div id="Divgrid1"  style="border-style: none; border-color: inherit; border-width: medium;  position:absolute; top:0px; left:0px; z-index:0;  width:1050px; height:300px" runat="server" >
       
        <table>
             <tr  align="left">
             <td runat="server" id="hdsviewgrid" style="overflow:hidden; height:300px; width:1050px;"></td>
            
             </tr>
             
             </table>
             </div>
             </td>
             </tr>
             </table>
             
             
          <table>
             <tr>
             <td>      
    <div id="divcategery" style="position:absolute;top:0px;left:0px;border:none;overflow:hidden; display:none;z-index:1;"> 
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstcategery" Width="280px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
     </td>
             </tr>
             </table>
	

<table>
             <tr>
             <td>    
<div id="Divgrid2" style="border-style: none; border-color: inherit; border-width: medium;  position:absolute; top:700px; left:200px; z-index:0;  width:1050px; height:300px" runat="server" >
       
        <table>
             <tr align="left">
             <td runat="server" id="hdsviewgrid2" style="overflow:none;height:200px;width:900px;" ></td>
            
             </tr>
             
             </table>
    
</div>				
	 </td>
             </tr>
             </table>
             
     <table>
             <tr>
             <td>            
      <div id="Div3" style=" border-style: none; overflow:hidden; display:none; border-color: inherit; border-width: medium; position:absolute; top:700px;  z-index:0;  width:350px; height:155px" runat="server" >
    <table><tr><td><asp:TextBox id="list"  runat="server" TextMode="MultiLine" Height="155px" Width="350px"  ></asp:TextBox></td></tr></table>
    </div>        
      </td>
             </tr>
             </table>        
            
      <table>
  <tr>
  <td  style="padding-left:120px;padding-top:300px;">        
  <table>
  <tr>
  <td style="padding-left:0px;"><asp:Label ID="lqbel1231" runat="server" Text="Birth Time"></asp:Label></td>
  <td> <asp:DropDownList ID="bitrh" runat="server" width="100px"></asp:DropDownList></td>
  
  
  <td style="padding-left:0px;"><asp:Label ID="Label6" runat="server" Text="Planet"></asp:Label></td>
  <td> <asp:DropDownList ID="planet1" runat="server" width="100px"></asp:DropDownList></td>
  
  <td style="width: 112px;padding-left:10px"><asp:Label ID="label7" runat="server" Text="Balance Dasha"></asp:Label></td>
                          <td style="width:200px"><asp:textbox id="Texttodate" runat="server"  Width='100px'></asp:textbox>
                          <img src='Image/cal1.gif'   onclick="popUpCalendar(this, form1.Texttodate,'mm/dd/yyyy',event)" height="14" width="14" style="width: 14px"  alt="" / ></td>
     
      </table>
       </td> 
      </tr>                   
  
 </table>
 
    
      
    
            
    
    
 
     
   
   <table>
   
   <tr>
   <td style="padding-left:120px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 750px">
   
    
   <tr>    
   <td style="padding-left:300px; margin-top:700px;">
  
    
    <asp:Button ID="sreach1" Text="Search D01" runat="server" Width="100px" Height="25px"/>
    <asp:Button ID="button2" Text="Calculate Vargas" runat="server" Width="100px" Height="25px"/>
  </td>
  
  
  
    
  



  </tr>
  </table>
    </td>
    </tr>
    </table>   
   
  
   <table>  
   <tr>
   <td style="padding-left:120px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 750px">
   <tr>    
   <td style="padding-left:20px;">
   <asp:Label ID="Label3" runat="server" Text="Select Categery[F2*]" Font-Size="Small">
   </asp:Label>
</td>
<td style="padding-left:20px;">
 <asp:TextBox ID="categery" runat="server" Width="140px" Height="15 px" >
 </asp:TextBox> 
 </td>

<td style="padding-left:20px;">
<asp:Label ID="Label2" runat="server" Text="All Of Them" Font-Size="Small">
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBox1" runat="server"  />
</td>

<td style="padding-left:20px;">
<asp:Label ID="Label1" runat="server" Text="Any Of Them" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBox2" runat="server" />
</td>
  </tr>
  
  
  
   <tr>    
   <td style="padding-left:20px;">
   <asp:Label ID="Label4" runat="server" Text="Enter Keywords" Font-Size="Small">
   </asp:Label>
</td>
<td style="padding-left:20px;">
 <asp:TextBox ID="k1" runat="server" Width="140px" Height="15 px" >
 </asp:TextBox> 
 </td>
  </tr>
   
  </table>
    </td>
    </tr>
   </table>
   
   
   
<table id="outertbl" cellpadding="2" cellspacing="2" width="800px" style="border:2px solid;border-color:#7DAAE3;margin-left:50px">
<tr>
<td style="padding-left:00px;">
   <table id="innertbl" cellpadding="1" cellspacing="1" width="800px" style="border:1px solid;border-color:#7DAAE3;">
<tr>    
   <td style="padding-left:20px;">
   <asp:Label ID="Label5" runat="server" Text="Searching By Planet" Font-Size="Small">
   </asp:Label>
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelSun" runat="server" Text="Sun" Font-Size="Small">
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxSun" runat="server"  />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelMoon" runat="server" Text="Moon" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxMoon" runat="server" />
</td>


<td style="padding-left:20px;">
<asp:Label ID="LabelMars" runat="server" Text="Mars" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxMars" runat="server" />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelMercury" runat="server" Text="Mercury" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxMercury" runat="server" />
</td>


<td style="padding-left:20px;">
<asp:Label ID="LabelJupitor" runat="server" Text="Jupitor" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxJupitor" runat="server" />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelVenus" runat="server" Text="Venus" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxVenus" runat="server" />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelSaturn" runat="server" Text="Saturn" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxSaturn" runat="server" />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelRahu" runat="server" Text="Rahu" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxRahu" runat="server" />
</td>

<td style="padding-left:20px;">
<asp:Label ID="LabelKetu" runat="server" Text="Ketu" Font-Size="Small" >
</asp:Label>
</td>

<td style="padding-left:20px;">
<asp:CheckBox ID="CheckBoxKetu" runat="server" />
</td>







  </tr>

</table>
</td></tr>
</table>   

   
   
       
     
     
<input type="hidden" runat="server" id="tblfields" />
<input type="hidden" runat="server" id="fields" />
<input type="hidden" runat="server" id="hiddendateformat" />    
<input type="hidden" runat="server" id="hidden123" />  

<input type="hidden" runat="server" id="Hidden4" />          
    </form>
</body>
</html>
