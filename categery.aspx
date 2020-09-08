<%@ Page Language="C#" AutoEventWireup="true" CodeFile="categery.aspx.cs" Inherits="categery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Categery Master</title>
     <script type="text/javascript" language="javascript" src="javascript/categery.js"></script>
    
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
   
    <style type="text/css">
        .style1
        {
            width: 727px;
            height: 28px;
        }
        .newStyle1
        {
            position: absolute;
        }
        .newStyle2
        {
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
      <table border="0" cellpadding="0" cellspacing="0" width="100">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(images/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:100PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> Categery Master</center></b></td>
                     <td style="background-image:url(images/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            
                    <tr>
                                   <td style="height: 25px"></td>
                             </tr>
            </table> 
                 
    <table cellpadding="0" cellspacing="0" align="center" style ="border: 2px solid #7DAAE3; height: 35px; width: 677px;" >
    <tr>
    <td style ="border: 1px solid #7DAAE3;" class="style1"> 
         <asp:Label ID="Label1" runat="server" Text="Categery"></asp:Label>
              <asp:DropDownList ID="drp1" runat="server" style="height: 47px; top: 63px; position: absolute; left: 352px; width: 99px; right: 347px;">
             <asp:ListItem>Select Categery</asp:ListItem>
             <asp:ListItem>Sports</asp:ListItem>
             <asp:ListItem>Education</asp:ListItem>
             <asp:ListItem>Health</asp:ListItem>
        </asp:DropDownList>
        </td>
         <td>
<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Add Row</asp:LinkButton>
        
          </td></tr>
          <tr><td>
                    <asp:TextBox ID="detail" runat="server" TextMode="MultiLine" 
              Width="700px" Height="100px"></asp:TextBox>
                   
          </td></tr>
       
          
            <tr id="tr2" style="display:none" >
    <td style ="border: 1px solid #7DAAE3;" class="style1" > 
         <asp:Label ID="l2" runat="server" Text="Categery"></asp:Label>
              
         
          <asp:DropDownList ID="drp2" runat="server" Height="50px" Width="93px" style="top:197px; left: 352px; position: absolute">
              <asp:ListItem>Select Categery</asp:ListItem>
              <asp:ListItem>Sports</asp:ListItem>
              <asp:ListItem>Education</asp:ListItem>
              <asp:ListItem>Health</asp:ListItem>
        </asp:DropDownList>
        </td>
        <td>
<asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Add Row</asp:LinkButton>
 </td>
 </tr>
        
       <tr id="tr3" style="display:none"><td>
                    <asp:TextBox ID="tx2" runat="server" TextMode="MultiLine" 
              Width="700px" Height="120px"></asp:TextBox>
                   
          </td></tr>
          
           <tr id="tr4" style="display:none" >
    <td style ="border: 1px solid #7DAAE3;" class="style1" > 
         <asp:Label ID="Label2" runat="server" Text="Categery"></asp:Label>
              
          
          <asp:DropDownList
            ID="Dr3" runat="server" Height="50px" Width="93px" 
             style="top: 355px; left: 352px; position: absolute">
              <asp:ListItem>Select Categery</asp:ListItem>
              <asp:ListItem>Sports</asp:ListItem>
              <asp:ListItem>Education</asp:ListItem>
              <asp:ListItem>Health</asp:ListItem>
        </asp:DropDownList>
        </td>
        <td>
         <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton1_Click" Enabled="False">Add Row</asp:LinkButton>
        
          </td></tr>
        
       <tr id="tr5" style="display:none"><td>
                    <asp:TextBox ID="d3" runat="server" TextMode="MultiLine" 
              Width="700px" Height="120px"></asp:TextBox>
                   
          </td></tr>
         </table>
    
    </form>
</body>
</html>
