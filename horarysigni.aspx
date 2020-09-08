<%@ Page Language="C#" AutoEventWireup="true" CodeFile="horarysigni.aspx.cs" Inherits="horarysigni" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Horary Master</title>
    
     <script type="text/javascript" language="javascript" src="javascript/horarysigni.js"></script>
    <%-- <link href="css/combine.css" type="text/css" rel="stylesheet" />--%>
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
      <style type="text/css">
      
    </style>
</head>
<body onload="blankfields();"  id="body"   style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
    <form id="form1" runat="server">
    
    <table>
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="horarysigni Master"></uc1:topbar></td>
    </tr>
    </table>
    
    
    
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
	                </table>			
							
                    
                    
   	<tr> <td>   
                    
                    
                      <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> Horarysigni Master</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>           
                    
                  </td>
                  </tr>  
                  
<table>
<tr>
<td height="10px">

</tr>


</table>
            
   <table>  
    <tr>
	<td style="padding-left:160px;">
	<table align="left" cellspacing="0" cellpadding="0" style="width: 758px">
	
	<tr >
	<td style="padding-left:20px; ">
    <asp:DropDownList ID="ext" runat="server"  Width="150px" Height="20 px" >
    </asp:DropDownList>
    </td>
	
    <td style="padding-left:20px;">
    <asp:DropDownList ID="texthouse" runat="server"  Width="150px" Height="20 px" >
    </asp:DropDownList>
    </td>
      
    <td style="padding-left:20px;">
    <asp:DropDownList ID="planet" runat="server"  Width="150px" Height="20 px">
    </asp:DropDownList>
    </td>
    
    <td style="padding-left:20px;">
    <asp:DropDownList ID="rashi" runat="server"  Width="150px" Height="20 px">
    </asp:DropDownList>
    </td>
    </tr>
               
     <tr>
     <td style="padding-left:20px;">
     <asp:Label ID="code" runat="server" Text="Code" Font-Size="Small">
     </asp:Label>
     </td>
     
     <td style="padding-left:20px;">                       
     <asp:TextBox ID="Textcode" runat="server" Width="150px" Height="20 px">
     </asp:TextBox> 
     </td>
            
            
     <td style="padding-left:20px;"> 
     <asp:Label ID="Label2" runat="server" Text="Key-string" Font-Size="Small">
     </asp:Label>
     </td>
     
     <td style="padding-left:20px;">
     <asp:TextBox ID="Textname" runat="server" Width="150px" Height="20 px">
     </asp:TextBox>
     </td>
     </tr> 
  
     <tr>
     <td style="padding-left:20px;"> 
     <asp:Label ID="Label4" runat="server" Text="Book">
     </asp:Label>
     </td>
     
     <td style="padding-left:20px;">       
     <asp:TextBox ID="book" runat="server" Height="20 px" width="150px">
     </asp:TextBox> 
     </td>
      
     <td style="padding-left:20px;">
     <asp:Label ID="Label5" runat="server" Text="Page No">
     </asp:Label>
     </td>
     
     <td style="padding-left:20px;">
     <asp:TextBox ID="page0" runat="server" Width="150px" Height="20 px">
     </asp:TextBox> 
     </td>
     </tr>
      
      
      <tr>
     <td style="padding-left:20px;"> 
     <asp:Label ID="Label6" runat="server" Text="General Significators[*F2]">
     </asp:Label>
     </td>
     
     <td style="padding-left:20px;">       
     <asp:TextBox ID="gs" runat="server" Height="20 px" width="150px">
     </asp:TextBox> 
     </td>
       <td style="padding-left:20px;"> 
     <asp:Button ID="exte" runat="server" style="height: 26px; width: 75px" Text="Show Extension" />
    </td> 
       <td style="padding-left:20px;"> 
     <asp:Button ID="ms" runat="server" style="height: 26px; width: 80px" Text="Multiple Significators" />
    </td>  </tr>
      </table>  
</td>
</tr>
            
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 758px">
                         
<tr>
<td style="padding-left:20px;">
<asp:TextBox ID="detail" runat="server" TextMode="MultiLine" Width="580px" Height="100px" >
</asp:TextBox>
</td>
<td>
<asp:ListBox ID="ListBox1" runat="server" style="height: 95px; width: 65px" OnbdClick="ShowPreview">
</asp:ListBox></td>
<td>
<asp:ListBox ID="ListBox2" runat="server" style="height: 95px; width: 65px" OnbdClick="ShowPreview">
</asp:ListBox>
</td>
</tr> 
 </table>
 </td>
 </tr>
 
 
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 758px">
<tr>
<td style="padding-left:20px;">
<asp:Label ID="Label3" runat="server" Text="Attach a File">
</asp:Label>           
</td>

<td style="padding-left:20px;">
<input id="File1" type="file" runat="server" style="width:250px;" />
<asp:Button ID="Button1" runat="server" onclick=" Button1_Click1" style="height: 25px; width: 75px" Text="Attachment" />
<asp:Button ID="Button2" runat="server" style="height: 26px; width: 75px" Text="Preview" />

</td> 
</tr>
       
<tr>
<td style="padding-left:20px;">
<asp:Label ID="Label1" runat="server" Text="Attach a Audio">
</asp:Label>   
</td>

<td style="padding-left:20px;">
<input id="File2" type="file" runat="server" style="width:250px; height: 22px;" />
<asp:Button ID="audio" runat="server"  onclick=" audio_Click1" style="height: 25px; width: 75px" Text="Audio attach" />
<asp:Button ID="play" runat="server" style="height: 26px; width: 75px" Text="Play" onclick=" play_Click1" />
</td>
</tr>
      
</table>
</td>
</tr>
</table>

<table>
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 758px">
<tr>
<td style="padding-left:20px;display:none;">
<div id="div5" runat="server">
<embed  runat="server" id="WinMedia1" border="0" autostart="false" loop="false"/>
 </div>
   
    </td>
      </tr>
</table>
</td>
</tr>
</table>

<table>
<tr>
<td></td></tr></table>
<table>
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  >
<tr>

<td style="padding-left:20px;">
<asp:Label ID="Label7" runat="server" Text="Significator">
</asp:Label>   
</td>


<td style="padding-left:20px;">       
     <asp:TextBox ID="karka" runat="server" Height="20 px" width="120px">
     </asp:TextBox> 
     </td>

  <td style="padding-left:20px;">
    <asp:DropDownList ID="hous" runat="server"  Width="120px" Height="20 px" >
    </asp:DropDownList>
    </td>
      
    <td style="padding-left:20px;">
    <asp:DropDownList ID="plant" runat="server"  Width="120px" Height="20 px">
    </asp:DropDownList>
    </td>
    
    <td style="padding-left:20px;">
    <asp:DropDownList ID="rash" runat="server"  Width="120px" Height="20 px">
    </asp:DropDownList>
    </td>

 <td style="padding-left:20px;"> 
     <asp:Button ID="inserts" runat="server" style="height: 26px; width: 75px" Text="Insert" />
    </td>
   
      </tr>
</table>
</td>
</tr>
</table>

<table style="margin:0px 0px 40px 0px;">
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0"  >
<tr>
<td style="padding-left:20px;">
<div id="Divgrid2" style= "overflow:scroll;display:none; width:300px; height:250px;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid2" style="width:300px;" align="left" ></td>
    </tr>
    </table></div></td>
      </tr>
</table>
</td>

<td style="padding-left:20px;">
<table align="left" cellspacing="0" cellpadding="0"  >
<tr>
<td style="padding-left:20px;">
 <asp:Label ID="tots" runat="server"></asp:Label>
<div id="Divgrid1h" style= "overflow:auto;display:none; width:1000px; height:50px;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgridh" style="width:900px;" align="left" ></td>
    </tr>
    </table></div>
     
    <div id="Divgrid1" style= "overflow:auto;display:none; width:700px; height:250px;" >
   
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:450px;" align="left" ></td>
    </tr>
    </table></div>
    </td>
      </tr>
</table>
</td>
</tr>
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
       
  
         
      

            


       
       


  
    </form>
</body>
</html>
