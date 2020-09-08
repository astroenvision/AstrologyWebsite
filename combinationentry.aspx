<%@ Page Language="C#" AutoEventWireup="true" CodeFile="combinationentry.aspx.cs" Inherits="combinationentry" %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Combination Entry</title>
    <script type="text/javascript" language="javascript" src="javascript/combinationentry.js"></script>
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
    <style type="text/css">
     </style>
    
</head>
<body  id="body" style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <!--onkeydown="javascript:return chkfld(event)"-->

  
     <table cellpadding="0" cellspacing="0">
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="Charge Master"></uc1:topbar></td>
    </tr>
    </table>
      <table id="outertable"   border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                            <td valign="top" style="width: 184px"><uc2:leftbar id="Leftbar1" runat="server"></uc2:leftbar></td>
	</tr>
	</table>
            <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                      <tr>
                    <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><center><b> Combination Master</b></center></td>
                      <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
				</tr>
                    </table>         
                    
                  </td></tr>  
                  
                  
                 <tr>
								<td style="height: 25px"></td>
						</tr>
                  
                  
                  
                  
           
          <table>  
    <tr>
								<td style="padding-left:160px;">
									<table align="left" cellspacing="0" cellpadding="0" 
                          style="width: 758px">
                          
                          
                          
                          
   <tr>    
   <td style="padding-left:20px;" > 
   <asp:Label ID="l6" runat="server" Text="Chart Number" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel5" runat="server"><ContentTemplate>
   <asp:DropDownList ID="chart" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   
   <td style="padding-left:20px;"> 
   <asp:Label ID="l5" runat="server" Text="Auto Genrate Code" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="TextBox3" runat="server" style="width: 150px;" Height="20px" ></asp:TextBox> 
   </td>
   </tr>
   
   <tr>
   <td style="padding-left:20px;">  
   <asp:Label ID="Labl3" runat="server" Text="House" Font-Size="Small">
   </asp:Label> 
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
   <asp:DropDownList ID="DropDownList1" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>

   <td style="padding-left:20px;">
   <asp:Label ID="Labl5" runat="server" Text="Rashi" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate>
   <asp:DropDownList ID="DropDownList2" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>
            
   <tr>    
   <td style="padding-left:20px;">
   <asp:Label ID="Labl4" runat="server" Text="Planet" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel3" runat="server"><ContentTemplate>
   <asp:DropDownList ID="DropDownList3" runat="server" style="width: 150px;" 
           Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
 
   <td style="padding-left:20px;">
   <asp:Label ID="l8" runat="server" Text="Aspecting Planet" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel4" runat="server"><ContentTemplate>
   <asp:DropDownList ID="aspecting" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>

   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="Label4" runat="server" Text="Key String" Font-Size="Small">
   </asp:Label> 
   </td>

   <td style="padding-left:20px;">
   <asp:TextBox ID="keystring" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   
   <td style="padding-left:20px;">
   <asp:Label ID="Label3" runat="server" Text="Aspecting House" Font-Size="Small">
   </asp:Label>  
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel6" runat="server"><ContentTemplate>
   <asp:DropDownList ID="DropDownList4" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </ContentTemplate></asp:UpdatePanel>
   </td>
   </tr>

   <tr>
   <td style="padding-left:20px;">  
   <asp:Label ID="l1" runat="server" Text="Ascendent" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel7" runat="server"><ContentTemplate>
   <asp:DropDownList ID="ascendentbox" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList> 
   </ContentTemplate></asp:UpdatePanel>   
   </td>
 
   <td style="padding-left:20px;">
   <asp:Label ID="Labl8" runat="server" Text="Ascendent Degree" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="TextBox1" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   </tr>
   
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="l2" runat="server" Text="Constellation" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:UpdatePanel ID="UpdatePanel8" runat="server"><ContentTemplate>
   <asp:DropDownList ID="constellationbox" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList> 
   </ContentTemplate></asp:UpdatePanel>   
   </td>

   <td style="padding-left:20px;">
   <asp:Label ID="Label1" runat="server" Text="Lord Of House" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:DropDownList ID="loh" runat="server" style="width: 150px;" Height="20px">
   </asp:DropDownList>
   </td>
   </tr>

   <tr>
   <td style="padding-left:20px;"> 
   <asp:Label ID="l3" runat="server" Text="Degree From" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="degreefrom" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   
   <td style="padding-left:20px;">
   <asp:Label ID="l4" runat="server" Text="Degree To" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="degreeto" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   </tr>
               
   <tr>
   <td style="padding-left:20px;">  
   <asp:Label ID="code" runat="server" Text="Code" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="Textcode" runat="server"   style="width: 150px;" Height="16px">
   </asp:TextBox> 
   </td>
   
   <td style="padding-left:20px;">
   <asp:Label ID="Label2" runat="server" Text="Name" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="Textname" runat="server"  style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   </tr>
   
   <tr>
   <td style="padding-left:20px;">
   <asp:Label ID="la1" runat="server" Text="Book" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="book" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   
   <td style="padding-left:20px;">
   <asp:Label ID="La2" runat="server" Text="Page No" Font-Size="Small">
   </asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="page0" runat="server" style="width: 150px;" Height="20px">
   </asp:TextBox> 
   </td>
   </tr>
   </table>
   </td>
   </tr>


   <tr>
   <td style="padding-left:160px;">
   <table align="left" cellspacing="0" cellpadding="0" style="width: 900px">
          
   <tr>
   <td style="padding-left:20px; width:20px;" >
   <asp:Label ID="Label6" runat="server" Text="Description" Font-Size="Small">
   </asp:Label>

   
   <asp:TextBox ID="Textdesc"  runat="server"  Height="20px" Width="670px">
   </asp:TextBox>
   </td>
   </tr>
   
   <tr>
   <td style="padding-left:20px;" >
   <asp:TextBox ID="detaildesc" runat="server" TextMode="MultiLine" Width="500px" Height="140px">
   </asp:TextBox>
   <asp:ListBox ID="ListBox1" runat="server" Width="80px" Height="140px">
   </asp:ListBox>
   <asp:ListBox ID="ListBox2" runat="server" Width="80px" Height="140px">
   </asp:ListBox> 
   </td> 
   </tr>
   
  <tr>
  <td style="padding-left:20px;">
  <input id="File1" runat="server" type="file" style="width:250px;"/>
  <asp:Button ID="Button8" runat="server" style="Width:70px;" Text="Preview" />
  <asp:Button ID="Button7" runat="server" style="Width:70px;" Text="Attachment" onclick="Button7_Click" />
  <asp:Button ID="Button5" runat="server" style="width:70px;" Text="Add to list" onclick="Button5_Click" />
  </td>
  </tr>
  
 
  
  <tr>
  <td style="padding-left:20px;">
  <asp:Button ID="Button6" runat="server" onclick="Button6_Click" style="width:90px;" Text="clear list" />
  <asp:Button ID="Buton1" runat="server" style="width:90px;" Text="Search" onclick="Buton1_Click" />
  <asp:Button ID="Buton2" runat="server" Text="Cancel" style="width:90px;"/>
  <asp:Button ID="Buton3" runat="server" Text="New" style="width:90px;"/>
  <asp:Button ID="Button4" runat="server" Text="Save" onclick="Button4_Click" style="width:90px;"/>
  </td>
  </tr>
  </table>
</td>
</tr>
</table>    

<table>  
<tr>
<td style="padding-left:160px;">
<table align="left" cellspacing="0" cellpadding="0" style="width: 758px">
<td style="padding-left:20px;" >
<div id="div1" runat="server" style="OVERFLOW: auto; WIDTH: 360px; HEIGHT: 306px; ">
               
  <asp:GridView  ID="GridView1" runat="server"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" onselectedindexchanged="CheckBox1_CheckedChanged">
  <FooterStyle BackColor="#507CD1" Font-Bold="True"  ForeColor="White" />
  <RowStyle BackColor="#EFF3FB"  />
  
  <Columns>
  <asp:TemplateField HeaderText="Check">
  
  <ItemTemplate>
  <asp:CheckBox ID="check1" runat="server" AutoPostBack="true"  OnCheckedChanged="CheckBox1_CheckedChanged"/>
  </ItemTemplate>
  </asp:TemplateField>
  <asp:TemplateField HeaderText="Detail Description">
  <ItemTemplate>
  <asp:Button ID="bt1" Text="Select" DataTextField="HOUSE_POSITIPON_CODE" runat="server" AutoPostBack="true"   OnClick="aa_a" />
  </ItemTemplate>
  </asp:TemplateField>
  <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
  <asp:BoundField DataField="HOUSE_POSITIPON_CODE" ShowHeader ="false" HeaderText="Combination" ItemStyle-ForeColor="Blue" SortExpression="Name" >
  <ItemStyle ForeColor="Blue"></ItemStyle>
  </asp:BoundField>
  <asp:BoundField DataField="description" HeaderText="Description" SortExpression="DESCRIPTION" />
  
  </Columns>
  
  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
  <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
  <AlternatingRowStyle BackColor="White" />
  </asp:GridView>
  </div>
</td>

<td style="padding-left:20px;">  
<div id="div2" runat="server" style="OVERFLOW: auto; WIDTH: 420px; HEIGHT: 180px;">
<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" style="height: 180px;width: 423px" ReadOnly="True">
</asp:TextBox>
</div>
  </td>
  </table>
    </td>
    </tr>
    </table>
    
    <input type="hidden" runat="server" id="tblfields"/>
     <input type="hidden" runat="server" id="hiddendateformat"/>
     <input type="hidden" runat="server" id="fields" />
        <input type="hidden" runat="server" id="hiddenfilename" />
  <input type="hidden" runat="server" id="hiddenjobid" /> 
  <input type="hidden" runat="server" id="Hidden1" /> 
  <input type="hidden" runat="server" id="Hidden2" />  
       
    </form>
</body>
</html>
