<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mod_article.aspx.cs" Inherits="mod_article" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modify Article</title>
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />

    <script type="text/javascript"> 
        function DeleteConfirm() 
        {  
            var Ans = confirm("Do you want to Delete Selected Record?");  
            if (Ans)
            {  
                return true;  
            }  
            else 
            {  
                return false;  
            }  
        }  
        
function Check_Click(objRef)
{
    //Get the Row based on checkbox
    var row = objRef.parentNode.parentNode.parentNode;
    if(objRef.checked)
    {
        //If checked change color to Aqua
        row.style.backgroundColor = "aqua";
    }
    else
    {   
        //If not checked change back to original color
        if(row.rowIndex % 2 == 0)
        {
           //Alternating Row Color
           row.style.backgroundColor = "#C2D69B";
        }
        else
        {
           row.style.backgroundColor = "white";
        }
    }
   
    //Get the reference of GridView
    var GridView = row.parentNode;
   
    //Get all input elements in Gridview
    var inputList = GridView.getElementsByTagName("input");
   
    for (var i=0;i<inputList.length;i++)
    {
        //The First element is the Header Checkbox
        var headerCheckBox = inputList[0];
       
        //Based on all or none checkboxes
        //are checked check/uncheck Header Checkbox
        var checked = true;
        if(inputList[i].type == "checkbox" && inputList[i] != headerCheckBox)
        {
            if(!inputList[i].checked)
            {
                checked = false;
                break;
            }
        }
    }
    headerCheckBox.checked = checked;
   
}
        
        
function checkAll(objRef)
{
var GridView = objRef.parentNode.parentNode.parentNode.parentNode;
var inputList = GridView.getElementsByTagName("input");

for (var i=0;i<inputList.length;i++)
{
    //Get the Cell To find out ColumnIndex
    var row = inputList[i].parentNode.parentNode.parentNode;
    if(inputList[i].type == "checkbox"  && objRef != inputList[i])
    {
        if (objRef.checked)
        {
       
            //If the header checkbox is checked
            //check all checkboxes
            //and highlight all rows
            row.style.backgroundColor = "aqua";
            inputList[i].checked=true;
        }
        else
        {
            //If the header checkbox is checked
            //uncheck all checkboxes
            //and change rowcolor back to original
            if(row.rowIndex % 2 == 0)
            {
               //Alternating Row Color
               row.style.backgroundColor = "#C2D69B";
            }
            else
            {
               row.style.backgroundColor = "white";
            }
            inputList[i].checked=false;
        }
    }
}
}


function MouseEvents(objRef, evt)
{
    var checkbox = objRef.getElementsByTagName("input")[0];
   if (evt.type == "mouseover")
   {
        objRef.style.backgroundColor = "orange";
   }
   else
   {
        if (checkbox.checked)
        {
            objRef.style.backgroundColor = "aqua";
        }
        else if(evt.type == "mouseout")
        {
            if(objRef.rowIndex % 2 == 0)
            {
               //Alternating Row Color
               objRef.style.backgroundColor = "#C2D69B";
            }
            else
            {
               objRef.style.backgroundColor = "white";
            }
        }
   }
}

</script>

</head>
<body style="margin: 0px auto; width: 1000px;">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <fieldset class="registrationmain" style="margin: 0em; width: 100%;">
                <table cellspacing="5" cellpadding="5" class="registrationtable">
                    <tr>
                        <td class="td_second" colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    Group:&nbsp;
                                    <asp:DropDownList ID="ddlgroup" runat="server" AutoPostBack="true" Width="150px"
                                        CssClass="registrationdropdown" OnSelectedIndexChanged="ddlgroup_SelectedIndexChanged">
                                        <asp:ListItem Value="0" Text="--Select Group--"></asp:ListItem>
                                        <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                        <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                        <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;&nbsp;&nbsp;Category:&nbsp;
                                    <asp:DropDownList ID="ddlcat" runat="server" AutoPostBack="true" Width="150px" CssClass="registrationdropdown">
                                    </asp:DropDownList>
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnsearch" runat="server" Text="Search" ValidationGroup="vgsearch"
                                        CssClass="loginbtncss" OnClick="btnsearch_Click" />
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btndelete" runat="server" Text="Delete" CssClass="loginbtncss" OnClick="btndelete_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="td_second" colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="grdviews" runat="server" Width="100%" AutoGenerateColumns="False"
                                        CellPadding="4" PageSize="10" AllowPaging="True" DataKeyNames="NEWS_ID" BorderColor="#CDE0F5"
                                        HeaderStyle-Font-Bold="true" BackColor="#F0F0F0" HeaderStyle-BackColor="#043454"
                                        HeaderStyle-ForeColor="White" HeaderStyle-Height="30px" HeaderStyle-Font-Size="12px"
                                        OnPageIndexChanging="grdviews_PageIndexChanging" OnRowDataBound="grdviews_RowDataBound"
                                        CssClass="gridview_css" AlternatingRowStyle-BackColor="#C2D69B">
                                        <Columns>
                                            <asp:BoundField DataField="NEWS_ID" HeaderText="News_id" Visible="false" />
                                            <asp:TemplateField HeaderText="id" Visible="false">
                                                <ItemStyle Width="50px" HorizontalAlign="Center" VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblnewsid" runat="server" Text='<%# Bind("NEWS_ID")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="S.No" Visible="true">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblrowno" Width="10px" runat="server" Text=""></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Headline">
                                                <ItemStyle Wrap="true" VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblhead" runat="server" Text='<%# Bind("HEADLINE")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Category" Visible="true">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblcatid" runat="server" Text='<%# Bind("CATID")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Group" Visible="true">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblgroupname" runat="server" Text='<%# Bind("GROUP_ID")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Modify">
                                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:HyperLink Text="Edit" Font-Underline="true" ID="btnedit" runat="server" Target="_blank" ForeColor="Green"></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="40px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="checkAll" runat="server" CssClass="grdchkbox" onclick="checkAll(this);" />
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="grdchkbox" onclick="Check_Click(this)" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Author Photo" Visible="false">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblauthorimg" runat="server" Text='<%# Bind("AUTHOR_IMG")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <PagerStyle BackColor="#2461BF" Height="10px" ForeColor="White" Wrap="True" HorizontalAlign="Center">
                                        </PagerStyle>
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
        <%--<uc2:footer ID="footer1" runat="server" />--%>
    </div>
    </form>
</body>
</html>
