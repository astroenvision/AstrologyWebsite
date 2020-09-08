<%@ Page Language="C#" AutoEventWireup="true" CodeFile="predictive_categery.aspx.cs" Inherits="predictive_categery" EnableEventValidation="false" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Predictive_Categery</title>
    <script language="javascript" type="text/javascript" src="javascript/prediction_categery.js"></script>    
<link href="css/combine.css" type="text/css" rel="stylesheet" />

</head>
<body  style="background-color:#f3f6fd;margin:0px 0px 0px 0px">
    <form id="form1" runat="server">
    
    
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        
         <table>
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="Astrology Master"></uc1:topbar></td>
    </tr>
    </table>
    <div>
    <div id="divcategery" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstcategery" Width="280px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
    
  <tr> <td>   
                 
                     <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center>Predictive_Categery</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>      
                    
                  </td></tr>  
                  
                  
                 <tr>
								<td style="height: 25px"></td>
							</tr> 
            
            
            <div id="Divgrid1" style="border-style: none; border-color: inherit; border-width: medium; position:absolute; top:0px; left:0px; z-index:0; height:100px; width:100px; " runat="server" >
       
        <table>
             <tr style="overflow:auto;width:500px;" align="left">
             <td runat="server" id="hdsviewgrid"></td>
            
             </tr>
             
             </table>
    
</div>		
            
                     
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
</table>
</td>
</tr>
</table>

 
<table>  
   <tr>
   <td style="padding-left:120px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 750px">
   
   <tr>
   <td style="padding-left:100px;">

</td>
</tr>
   
   <tr>
   <td style="padding-left:350px;">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate> 
<asp:Button ID="Button2" runat="server" height="26px" width="61px" Text="Select" />
         </ContentTemplate></asp:UpdatePanel>  
</td>
</tr>
</table>                  
</td>
</tr>
</table>            
</div>

<table>  
   <tr>
   <td style="padding-left:120px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 750px">
   <tr>    
   <td style="padding-left:20px;">
  <div id="div1" runat="server" style="OVERFLOW: auto; WIDTH: 500px; HEIGHT: 306px; ">
               
<%-----   <asp:GridView  ID="GridView1" runat="server"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
  <FooterStyle BackColor="#507CD1" Font-Bold="True"  ForeColor="White" />
  <RowStyle BackColor="#EFF3FB"  />
  
  <Columns>
 
  <asp:TemplateField HeaderText="Detail Description">
  <ItemTemplate>
  <asp:Button ID="bt1" Text="Select" DataTextField="DESCRIPTION" runat="server" AutoPostBack="true"    />
  </ItemTemplate>
  </asp:TemplateField>
  <asp:BoundField DataField="DESCRIPTION"  HeaderText="DESCRIPTION" ItemStyle-ForeColor="Blue" SortExpression="Name" >
  <ItemStyle ForeColor="Blue"></ItemStyle>
  </asp:BoundField>
   
  </Columns>
  
  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
  <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
  <AlternatingRowStyle BackColor="White" />
  </asp:GridView>----%>
  </div>
</td>


<td style="padding-left:20px;">  
<div id="div2" style=" border-style: none; overflow:auto; display:none; border-color: inherit; border-width: medium; position:absolute; top:0px; left:0px; z-index:0;  width:350px; height:155px" runat="server" >
<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="155px" Width="350px">
</asp:TextBox>
</div>
  </td>
  </tr>
  </table>
    </td>
    </tr>
    </table> 

<input type="hidden" runat="server" id="hiddenpage" />
    
    
    </form>
</body>
</html>
