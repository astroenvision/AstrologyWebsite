﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astrochartcombi.aspx.cs" Inherits="astrochartcombi" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Chart Combination</title>
    
    <script type="text/javascript" language="javascript" src="javascript/astrochartcomb.js"></script>
     <link href="css/combine.css" type="text/css" rel="stylesheet" />
      
      
        
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
    <style type="text/css">
      .style1
       {
           font-size: 3px;
       }
      
   </style>
   
    <style type="text/css"></style>
      </head>
<body  id="body" onload="vargas()"; style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
 
    <form id="form1" runat="server">
  <table>
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="Astrochart Combination"></uc1:topbar></td>
    </tr>
    </table>
    
    
    <table id="outertable" width="400px" border="0" cellpadding="0" cellspacing="0">
          <tr>
                                             <td valign="top" style="width: 184px"><uc2:leftbar id="Leftbar1" runat="server"></uc2:leftbar></td>
	
	                                       <td valign="top">
						<table  style="margin-top:-4px;margin-left:-5px;height:20px;width: 825px">
							<tr style="height:25px;">
			<td><asp:ImageButton id="btnNew" runat="server"   Font-Size="XX-Small" 
                    BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/new.jpg"  ></asp:ImageButton>
                <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" 
                  ></asp:ImageButton>
                <asp:ImageButton id="btnModify" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/modify.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnQuery" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/query.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExecute" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/execute.jpg"></asp:ImageButton>
                <asp:ImageButton id="btnCancel" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/clear.jpg"></asp:ImageButton>
                <asp:ImageButton id="btnfirst"  runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/first.jpg" Width="70px" Height="27px"></asp:ImageButton>
                <asp:ImageButton id="btnprevious" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/previous.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnnext" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/next.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnlast" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/last.jpg" Width="70px" Height="27px" ></asp:ImageButton>
                <asp:ImageButton id="btnDelete" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/delete.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExit" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/exit.jpg" ></asp:ImageButton>
								</td>
								
								</tr>
							
				<tr valign="top" align="left">
								<td>
									
								</td>
							</tr>			
				<tr>
	                    <td style="height: 15px"></td>
	                </tr>
	                </table>
	               </td>
	               </tr>
	                </table>	
	                
	                
	                
							
                    
          <table>         
   	<tr>
   	 <td>   
                    
                    
                      <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> Astrochart Combination Master</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>           
                    
                  </td>
               	
                  </tr>  
                  </table> 
<table style="width: 1000px;">
<tr>
<td>
<div>

<td style="padding-left:00px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 275px;">
<tr>
<tr>

<td style="padding-left:00px;border:1px solid;border-color:#7DAAE3;">
<div id="Divgrid1" style= "overflow:auto;padding-left:00px;display:none; width:500px; height:260px;" >
<table >
<tr>
<td runat="server" id="hdsviewgrid" style="width:300px;" align="left" ></td>
</tr>

</table></div></td>
    
</tr>

</tr>
<tr>
<td>


  	  <table id="Table1" cellpadding="2" cellspacing="2" width="500px" style="border:2px solid;border-color:#7DAAE3;margin-left:00px; margin-top:100px;">
<tr>
<td style="padding-left:00px;">
   <table id="Table2" cellpadding="1" cellspacing="1" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr> 


<td style="padding-left:0px;"><asp:Label ID="Label9" runat="server" Text="Select Chart"></asp:Label></td>
  <td> <asp:DropDownList ID="chart" runat="server" width="100px"></asp:DropDownList></td>
  
  <td style="padding-left:0px;"><asp:Label ID="Label7" runat="server" Text="Planet"></asp:Label></td>
  <td> <asp:TextBox ID="planet" runat="server" width="100px"></asp:TextBox></td>
 
 
 
 
 <td style="padding-left:0px;"><asp:Label ID="Label8" runat="server" Text="Balance Dasha"></asp:Label></td>
  <td> <asp:TextBox ID="balance" runat="server" width="100px"></asp:TextBox></td>
  
  </tr>
  <tr> </tr>


  </table>
</td>
</tr>
</td>
</tr>
</table>
    
</table>
<div>
<div class="rashidiv" runat="server" id="rashiid" style="display:none;" >
<div class="rashidiv1">
<span class="rashispan1">
<asp:Label ID="h2l1" runat="server" Text="" Font-Size="Small" Class="style1">
                    </asp:Label>
                   
                    <asp:Label ID="h2r" runat="server" Text="" Font-Size="Small" Class="style1">
                    </asp:Label>
                    
                    </span>
                    
                    <span class="rashispan2">
                    <asp:Label ID="h12l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                    <asp:Label ID="h12r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                    </span>
                </div>
                
                <div class="rashidiv2">
                     <span class="rashispan3">
                     <asp:Label ID="h3l1" runat="server" Text=""   Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                     <asp:Label ID="h3r" runat="server" Text=""   Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                     </span>
                     <span class="rashispan7">
                     <asp:Label ID="h1l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                     <asp:Label ID="h1r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                     </span>
                     <span class="rashispan4">
                     <asp:Label ID="h11l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                     <asp:Label ID="h11r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                     </span>
                </div>
                
                <div class="rashidiv3">
                    <span class="rashispan5">
                    <asp:Label ID="h4l1" runat="server" Text=""   Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h4r" runat="server" Text=""   Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    </span>
                    <span class="rashispan6">
                    <asp:Label ID="h10l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h10r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    </span>
                </div>
                
              
                    
                <div class="rashidiv3">
                    <span class="rashispan3">
                    <asp:Label ID="h5l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                    <asp:Label ID="h5r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                   </span>
                    <span class="rashispan7">
                    <asp:Label ID="h7l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h7r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    </span>
                    <span class="rashispan4">
                    <asp:Label ID="h9l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h9r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                   
                    </span>
                </div>
               
                <div class="rashidiv4">
                    <span class="rashispan1">
                    <asp:Label ID="h6l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h6r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    </span>
                    <span class="rashispan2">
                    <asp:Label ID="h8l1" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    <asp:Label ID="h8r" runat="server" Text=""  Font-Size= "Small" Class="style1">
                    </asp:Label>
                    
                    </span>
</div>
                   
                    
</div>
</div>
            
</td>

</div>
</td>
</tr>  
    
  	  </table>
  	  
  	  

  	  

<table>
<tr>
<td style="padding-left:200px;"> <asp:Button ID="search" runat="server" Text="search" /></td>
<td><asp:Button ID="calvergas" runat="server" Text="Vargas Chart" Width="100px" /></td>
</tr>
</table>



 <table>
             <tr>
             <td>      
    <div id="divcategery" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstcategery" Width="200px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
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
<div id="Divgrid2" style= "border-color: inherit; padding-left:100px; border-width: medium; position:absolute; top:740px; left:80px; z-index:0;  width:900px; height:500px" runat="server" >
       
        <table>
             <tr align="left">
             <td runat="server" id="hdsviewgrid2" style=" padding-left:100px;  height:0px;width:900px;" ></td>
            
             </tr>
             
             </table>
    
</div>				
	 </td>
             </tr>
             </table>
             
             
<table>  
   <tr>
   <td style="padding-left:120px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 650px">
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
   
   
   <table>
   <tr>
   <td>
   
   
   
   <div id="Div3" style=" border-style: none; overflow:none; display:none; border-color: inherit; border-width: medium; position:absolute; top:700px;  z-index:0;  width:350px; height:155px" runat="server" >
    <table><tr><td><asp:TextBox id="list"  runat="server" TextMode="MultiLine" Height="155px" Width="350px"  ></asp:TextBox></td></tr></table>
    </div>        
      </td>
             </tr>
             </table> 

   
   
<table id="outertbl" cellpadding="2" cellspacing="2" width="700px" style="border:2px solid;border-color:#7DAAE3;margin-left:00px">
<tr>
<td style="padding-left:00px;">
   <table id="innertbl" cellpadding="1" cellspacing="1" 
        style="border:1px solid #7DAAE3; width: 00px;">
<tr>    
   <td style="padding-left:00px;">
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

  <tr></tr>
 <tr></tr> 


  </tr>
  
  
  
  <tr></tr>
 <tr></tr> 

  
  
  
</table>
</td>
</tr>
</table>   

                

  <tr></tr>
 <tr></tr> 






<input type="hidden" runat="server" id="hidden123" />

<input type="hidden" runat="server" id="Hiddenvargas" />
<input type="hidden" runat="server" id="Hidden4" />
<input type="hidden" runat="server" id="Hidden5" />

<input type="hidden" runat="server" id="Hidden1" />

<input type="hidden" runat="server" id="Hidden2" />
    </form>
    
  
</body>
</html>
