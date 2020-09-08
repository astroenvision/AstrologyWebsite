<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Houseposition.aspx.cs" Inherits="Houseposition" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>House Position</title>
    <script type="text/javascript" language="javascript" src="javascript/Houseposition.js"></script>
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript">
</script>
   
       
       <style type="text/css">
        
    </style>
</head>
<%--<body onload = "blankfields();">--%>

<body  id="body" onload="grid()";  style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
  
    <!--onkeydown="javascript:return chkfld(event)"-->
 

    <form id="form1" runat="server">  
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      <table>
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text=" Astrology Master"></uc1:topbar></td>
    </tr>
    </table>
    
<div id="Divgrid1" 
        style="border-style: none; border-color: inherit; border-width: medium; position:absolute; top:0px; left:0px; z-index:0;  width:89px; height:9px"  
        runat="server" >
     
       
        <table>
             <tr style="overflow:auto;height:0px;width:450px;" align="center">
             <td runat="server" id="hdsviewgrid"></td>
            
             </tr>
             
             </table>
    
</div>
   
         <table id="outertable" width="400px" border="0" cellpadding="0" cellspacing="0">
         <tr>
         
           <td valign="top" style="width: 184px"><uc2:leftbar id="Leftbar1" runat="server"></uc2:leftbar></td>
	
	                                       <td valign="top">
						<table  style="margin-top:-4px;margin-left:-5px;height:20px;width: 900px">
							<tr style="height:25px;">
         <td><asp:ImageButton id="btnNew" runat="server"   Font-Size="XX-Small" 
                    BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/new.jpg"  ></asp:ImageButton>
                <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" ></asp:ImageButton>
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
                    ImageUrl="~/Image/clear.jpg" ></asp:ImageButton>
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
							  </table>	
							   </td></tr>
				<table>	
						
				<tr>
	                    <td style="padding-left:20px;">
	                     <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Extra Prediction
                </asp:LinkButton>
                </td>
	            </tr>
	           </table>
	           
	          	
							
               
                
         
  <table>
  	<tr> <td>   
                                        
                     <%--<table border="0" cellpadding="0" cellspacing="0"  width="100%">
                      <tr>
                     <td style="width:27px;"></td>
                     <td style="background-image:url(images/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:25px;"><center><b> Astrology Master</b></center></td>
                     <td style="background-image:url(images/corner-right.jpg); background-repeat:no-repeat; height:25px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
				</tr>
                    </table>  --%>
                    
                    
                     <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> Astrology Master</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>      
                    
                  </td></tr>  
                  
                  
                 <tr>
								<td style="height: 25px"></td>
							</tr> 
                  
         </table>
            
   <%--       All right from  here--%>
    <table>  
    <tr>
	<td style="padding-left:160px;">
	<table align="left" cellspacing="0" cellpadding="0" style="width: 758px">
  
   <tr>    
   <td style="padding-left:20px;" > 
   <asp:Label ID="l5" runat="server" Text="Chart Number" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;"  >
   <asp:DropDownList ID="chart" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </td>
 
   <td style="padding-left:20px;" > 
   <asp:Label ID="l17" runat="server" Text="Lord Of House" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate> 
   <asp:DropDownList ID="loh" runat="server" Width="150px" Height="20px" AutoPostBack="True" onselectedindexchanged="loh_SelectedIndexChanged">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel> 
   </td>
   </tr>
   
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="code" runat="server" Text="Code" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;"  >
   <asp:TextBox ID="Textcode" runat="server" Width="150px" Height="15 px" ReadOnly="True">
   </asp:TextBox> 
   </td>
   
   <td style="padding-left:20px;" >
   <asp:Label ID="Label2" runat="server" Text="Name" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="Textname" runat="server" Width="150px" Height="15 px">
   </asp:TextBox> 
   </td>
   </tr> 
   
   <tr>           
   <td style="padding-left:20px;"> 
   <asp:Label ID="Label3" runat="server" Text="House" Font-Size="Small">
   </asp:Label>
   </td>
       
   <td style="padding-left:20px;" >
   <asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate> 
   <asp:DropDownList ID="Drphouse" runat="server" Width="150px" Height="22px" AutoPostBack="True" onselectedindexchanged="Drphouse_SelectedIndexChanged">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>
            
   <tr>  
   <td style="padding-left:20px;">
   <asp:Label ID="Label5" runat="server" Text="Rashi" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;"  >
   <asp:UpdatePanel ID="UpdatePanel3" runat="server"><ContentTemplate>
   <asp:DropDownList ID="Drprashi" runat="server" Width="150px" Height="22px" AutoPostBack="True" onselectedindexchanged="Drprashi_SelectedIndexChanged">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>
   
   
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="Label4" runat="server" Text="Planet" Font-Size="Small">
   </asp:Label>
   </td>

   <td style="padding-left:20px;" >
   <asp:UpdatePanel ID="UpdatePanel4" runat="server"><ContentTemplate>
   <asp:DropDownList ID="Drpplanet" runat="server" Width="150px" Height="20px" AutoPostBack="True" onselectedindexchanged="Drpplanet_SelectedIndexChanged">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td> 
   
   <td style="padding-left:20px;" >
   <asp:Label ID="Label9" runat="server" Text="Aspecting Planet">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel5" runat="server"><ContentTemplate>
   <asp:DropDownList ID="accepting" runat="server" Width="150px" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>
           
   <tr>    
   <td style="padding-left:20px;">
   <asp:Label ID="L1" runat="server" Text="Ascendent" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;"  >
   <asp:DropDownList ID="ascendentbox" runat="server" Width="150px" Height="22px">
   </asp:DropDownList>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:Label ID="Label8" runat="server"  Text="Ascendent Degree" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="Textpdegree" runat="server" Width="150px" Height="15 px">
   </asp:TextBox>
   </td>
   </tr>
   
   <tr> 
   <td style="padding-left:20px;">
   <asp:Label ID="l2" runat="server" Text="Constellation" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:DropDownList ID="constellationbox" runat="server" Width="150px" Height="22px">
   </asp:DropDownList>
   </td>
   
   <td style="padding-left:20px;">
   <asp:Label ID="Label7" runat="server" Text="Key String" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:TextBox ID="keystring" runat="server" Width="150px" Height="17 px">
   </asp:TextBox>
   </td>
   
   </tr>
            
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="l3" runat="server" Text="Degree From" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="degreefrom" runat="server" Width="150px" Height="17 px">
   </asp:TextBox>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:Label ID="l4" runat="server" Text="Degree To" style="Font:Verdana;" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="degreeto" runat="server" Width="150px" Height="17 px">
   </asp:TextBox>
   </td>
   </tr>    
   
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="l7" runat="server" Text="Book" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:TextBox ID="book" runat="server" Width="150px" Height="17 px" >
   </asp:TextBox>
   </td>
   
   <td style="padding-left:20px;" >  
   <asp:Label ID="Label1" runat="server" Text="Page No." Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="page0" runat="server" Width="150px" Height="17 px">
   </asp:TextBox>
   </td>
   </tr>
   
 </table>  
</td>
</tr>
            
<tr>
 <td style="padding-left:160px;">
	<table align="left" cellspacing="0" cellpadding="0"  style="width: 900px">
                         
   
   
   
   
   <tr>
   <td style="padding-left:20px;" >  
   <asp:Label ID="Label6" runat="server" Text="Description" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:TextBox ID="Textdesc" runat="server"  Height="18px" Width="535px">
   </asp:TextBox>
   </td>
   </tr>
            
   <tr>
   <td style="padding-left:20px;" >
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="detaildesc" runat="server" TextMode="MultiLine"  Width="500px" Height="140px">
   </asp:TextBox>

  <asp:ListBox ID="ListBox1" runat="server" Width="80px" Height="145px" 
           style="top: 425px; left: 800px; position: absolute">
  </asp:ListBox>
  </td>
  </tr>
  
  <tr>
  <td style="padding-left:20px;height:20px" >
  </td>
  <td style="padding-left:20px; height:70px">
   <input id="File1" type="file" runat="server" style="width:250px;"/>
   
   <asp:Button ID="Button5" runat="server" style="Width:90px;" Text="Attachment" onclick="Button5_Click"/>
 
   <asp:Button ID="Button6" runat="server" Text="Preview" style="Width:90px;" onclick="Button5_Click"/>
  
   <asp:Button ID="addrow" runat="server" style="Width:90px;" Text="Add Row"/>
   
   </td>
 
   </tr>
   
   
  
   
  
   
  
      
      
   	</table>
	</td>
	</tr>
				
     </table>   
      
      
      
      
      
      
      
      
      
      
   <%--may be  for view button--%>
  <table style="margin:40px 200px 40px 100px">
   <tr>
   <td style="padding-left:20px;">
   <input type="button" id="Button4"  runat="server" value="View" style=" width:90px;height:30px; font-size:11px;font-family:arial;" visible="false">
   </td>
   </tr>
   </table>
                        
   </table>

     
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

     <input type="hidden" runat="server" id="valuehidden" />
     <input type="hidden" runat="server" id="Hidden4" />
     <input type="hidden" runat="server" id="Hidden5" />
     <input type="hidden" runat="server" id="Hidden6" />
     <input type="hidden" runat="server" id="Hidden7" />
     <input type="hidden" runat="server" id="valuehidden1" />
  <%--   <input type="hidden" runat="server" id="houseposition"/>--%>
     
     
     
     
    </form>
</body>
</html>
