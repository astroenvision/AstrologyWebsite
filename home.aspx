<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
     <script type="text/javascript" language="javascript" src="javascript/Home.js"></script>
    
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" 
            style="top: 198px; left: 150px; position: absolute; height: 26px; width: 77px; right: 644px;" 
            Text="Combination Entry"  />
        <asp:Button ID="Button2" runat="server" 
            style="top: 198px; left: 310px; position: absolute; height: 26px; width: 74px" 
            Text="House Position" />
        <asp:Button ID="Button3" runat="server" 
            style="top: 198px; left: 596px; position: absolute; height: 26px; width: 79px" 
            Text="Encyclopaedia" />
        <asp:Button ID="Button4" runat="server" 
            style="top: 198px; left: 725px; position: absolute; height: 26px; width: 87px" 
            Text="Aspects Planet" />
        <asp:Button ID="Button6" runat="server" 
            style="top: 198px; left: 850px; position: absolute; height: 26px; width: 87px" 
            Text="Astro Degree" />
            <asp:Button ID="Button8" runat="server" 
            style="top: 198px; left: 1100px; position: absolute; height: 26px; width: 87px" 
            Text="Astro Extentions" />
    
    </div>
    <table border="0" cellpadding="0" cellspacing="0" width=100%>
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(images/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:100PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> ASTROLOGY MASTER</center></b></td>
                     <td style="background-image:url(images/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            
                    <tr>
                                   <td style="height: 25px">
        <asp:Button ID="Button5" runat="server" 
            style="top: 198px; left: 453px; position: absolute; height: 26px; width: 86px" 
            Text="Planet from Planet" />
    
    <asp:Button ID="Button7" runat="server" 
            style="top: 198px; left: 980px; position: absolute; height: 26px; width: 86px" 
            Text="Predictive_Categery" />
                                   </td>
                             </tr>
            </table>
    <p align="center" 
                      
                      style="width: 780px; top: 77px;  left: 89px; position: absolute; height: 110px">
        
    <asp:Image ID="Image1" runat="server" Height="110px" 
            ImageUrl="~/Image/k0449820.jpg" Width="183px" Visible="False" />
        <asp:Image ID="Image2" runat="server" Height="110px" ImageUrl="~/Image/as.png" 
            Width="183px" Visible="False" />
        <asp:Image ID="Image3" runat="server" Height="110px" ImageUrl="~/Image/ast.gif" 
            Width="183px" Visible="False" />
        <asp:Image ID="Image4" runat="server" Height="110px" ImageUrl="~/Image/ast.jpg" 
            Width="183px" Visible="False" />
    </p>
    </form>
</body>
</html>
