<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MENU</title>
    <script type="text/javascript" language="javascript" src="javascript/menu.js"></script>
    
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript">
</script>
</head>
<body  id="body"   style="background-color:#f3f6fd;margin:0px 0px 0px 0px"> 
    <form id="form1" runat="server">
    <div>
     <table border="0" cellpadding="0" cellspacing="0" width=100%>
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(images/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:100PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> ASTROLOGY MASTER</center></b></td>
                     <td style="background-image:url(images/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            
                    <tr>
                                   <td style="height: 25px"></td>
                             </tr>
            </table> 
            
            <table>
            <tr>
            <td>
            <table>
            <tr>
            <td>
            
            
            </td>
            
            
            </tr>
            
            <tr>
            <td>
            
            
            </td>
            
            
            </tr>
            <tr>
            <td>
            
            
            </td>
            
            
            </tr>
            
            </table>
            
            
            </td>
            
            </tr>
            
            </table>
            
        <%--<asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
            DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284E98" StaticSubMenuIndent="10px" Height="235px" 
                      onmenuitemclick="Menu1_MenuItemClick" Width="120px" >
            <StaticSelectedStyle BackColor="#507CD1" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <Items>
                <asp:MenuItem Text="Combination Entry" Value="combinationentry">
                </asp:MenuItem>
                <asp:MenuItem Text="House Position" Value="Houseposition">
                </asp:MenuItem>
                <asp:MenuItem Text="Encyclopaedia Master" Value="encyclopaedia">
                </asp:MenuItem>
                <asp:MenuItem Text="Planet From Planet" Value="Planetfromplanet">
                </asp:MenuItem>
                <asp:MenuItem Text="Aspects Planet" Value="Planet_aspect">
                </asp:MenuItem>
                <asp:MenuItem Text="Astrodegree" Value="astrodegree">
                </asp:MenuItem>
                <asp:MenuItem Text="Predictive Categery" Value="predictive_categery">
                </asp:MenuItem>
            </Items>
        </asp:Menu>--%>
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" Height="405px" Width="77px" 
            onselectednodechanged="TreeView1_SelectedNodeChanged" BorderColor="#3366FF" 
            ForeColor="#0033CC" ImageSet="Simple" ShowLines="True">
            <ParentNodeStyle ChildNodesPadding="20px" ForeColor="#CC0000" />
            <SelectedNodeStyle ForeColor="#3333CC" />
            <Nodes>
                <asp:TreeNode Text="ASTROLOGY" Value="ASTROLOGY">
                    <asp:TreeNode Text="Combination Entry" Value="combinationentry"></asp:TreeNode>
                    <asp:TreeNode Text="House Position" Value="Houseposition"></asp:TreeNode>
                    <asp:TreeNode Text="Encyclopaedia Master" Value="encyclopaedia">
                    </asp:TreeNode>
                    <asp:TreeNode Text="Planet From Planet" Value="Planetfromplanet">
                    </asp:TreeNode>
                    <asp:TreeNode Text="Aspects Planet" Value="Planet_aspect"></asp:TreeNode>
                    <asp:TreeNode Text="Astrodegree" Value="astrodegree"></asp:TreeNode>
                    <asp:TreeNode Text="Predictive Categery" Value="predictive_categery">
                    </asp:TreeNode>
                    <asp:TreeNode Text="Astro Extentions" Value="extentions">
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <RootNodeStyle ChildNodesPadding="20px" ForeColor="#CC0000" />
            <NodeStyle ChildNodesPadding="20px" />
        </asp:TreeView>
    </form>
</body>
</html>
