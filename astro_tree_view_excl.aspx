<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_tree_view_excl.aspx.cs"
    EnableEventValidation="false" Inherits="astro_tree_view_excl" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Assembly="System.Web.Extensions" Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register TagPrefix="uc1" TagName="Topbar" Src="~/Topbarnew.ascx" %>
<%@ Register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbar.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Astro Tree Through Excl</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletvargaschart.css" />
    <link type="text/css" rel="stylesheet" href="css/tabeletyoga.css">
    <link rel="Stylesheet" href="css/combine.css" type="text/css" />

    <script type="text/javascript" language="javascript" src="javascript/astro_tree_view_excl.js"></script>

    <script language="javascript" type="text/javascript">

    </script>

</head>
<body style="background-color: #f8f9fd;" onkeypress="eventcalling(event);">
    <form id="form2" method="post" runat="server" autocomplete="off">
    <asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="true" AsyncPostBackTimeout="6000">
    </asp:ScriptManager>
    <div style="margin-left: 430px;">
        <asp:Label ID="Label11" runat="server" Text="Astro knowledge New Entry Module" Style="color: black;
            font-family: Georgia; font-size: 25px; margin: 0 auto; padding: 3px 10px;"></asp:Label>
            </div>
    
    <div id="list_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel71" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="root_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter1_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter1_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter2_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter2_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter3_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter3_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter4_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter4_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter5_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter5_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter6_div" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter6_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <table id="outertable" width="990px" cellspacing="0" cellpadding="0" border="0" align="center"
        style="margin-top:10px; margin-left: -50px;">
        <tr valign="top">
            <td valign="top">
                <table class="RightTable" id="RightTable" cellspacing="0" cellpadding="0" border="0"
                    style="left: 0px; top: 0px; padding-left: 50px; background-color: #f8f9fd;">
                    <tr>
                        <td>
                            <table border="1" align="center" style="width: 92.5%;">
                                <tr>
                                    <td>
                                        <table border="0" style="width: 100%; background-color: #e4e8f8;">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label10" runat="server" Text="Select data source"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="drop_select" runat="server">
                                                            <asp:ListItem>Astro knowledge</asp:ListItem>
                                                            <asp:ListItem>Horary knowledge</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label3" runat="server" Text="Main Root"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                            <ContentTemplate>
                                                                <asp:TextBox ID="root" runat="server" onblur="return initCapr(this.value)"></asp:TextBox>
                                                                 <asp:LinkButton ID="anr" runat="server">ANR</asp:LinkButton>

                                                            </ContentTemplate>
                                                       
                                                              </asp:UpdatePanel>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label2" runat="server" Text="Filter 1"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter1" runat="server" onblur="return initCapf1(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr1" runat="server">Ctr1</asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label4" runat="server" Text="Filter 2"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter2" runat="server" onblur="return initCapf2(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr2" runat="server">Ctr2</asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label5" runat="server" Text="Filter 3"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter3" runat="server" onblur="return initCapf3(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr3" runat="server">Ctr3</asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label6" runat="server" Text="Filter 4"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter4" runat="server" onblur="return initCapf4(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr4" runat="server">Ctr4</asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label9" runat="server" Text="Filter 5"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter5" runat="server" onblur="return initCapf5(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr5" runat="server">Ctr5</asp:LinkButton>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label23" runat="server" Text="Filter 6"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter6" runat="server" onblur="return initCapf6(this.value)"></asp:TextBox>
                                                        <asp:LinkButton ID="ctr6" runat="server">Ctr6</asp:LinkButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label24" runat="server" Text="Synonym"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="syn" runat="server" onblur="return initCaps(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                    <asp:Label ID="client" runat="server" Text="Child List"  font-weight="600" font-family="Open Sans" font-size="11px"></asp:Label>
                                                     </td>
                                                     <td><asp:DropDownList ID="synon"  runat="server"></asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    <asp:Label ID="Label26" runat="server" Text="Parent"  font-weight="600" font-family="Open Sans" font-size="11px"></asp:Label>
                                                     </td>
                                                     <td><asp:DropDownList ID="par"  runat="server"></asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1" runat="server" Text="Explanation"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <FCKeditorV2:FCKeditor ID="explanation_text" runat="server" BasePath="~/fckeditor/"
                                                            Width="620px" Height="400px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--<asp:TextBox ID="explanation_text" runat="server" TextMode="MultiLine" 
         Width="370px" Height="100px"  ></asp:TextBox>--%>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label7" runat="server" Text="Explanation 2"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <FCKeditorV2:FCKeditor ID="explanation_text2" runat="server" BasePath="~/fckeditor/"
                                                            Width="620px" Height="400px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--
 <asp:TextBox ID="explanation_text2" runat="server" TextMode="MultiLine" Width="370px" Height="100px" ></asp:TextBox>--%>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label8" runat="server" Text="Explanation 3" Style="display: none;"></asp:Label>
                                                    </td>
                                                    <td style="display: none;">
                                                        <FCKeditorV2:FCKeditor ID="explanation_text3" runat="server" BasePath="~/fckeditor/"
                                                            Width="370px" Height="100px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--<asp:TextBox ID="explanation_text3" runat="server" TextMode="MultiLine" Width="370px" Height="100px" ></asp:TextBox>--%>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:LinkButton ID="save" runat="server" Style="margin-left: 40px;">Save New Entry</asp:LinkButton>
                                                        <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                    
                                                        <td>
                                                        
                                                        <asp:LinkButton ID="clear" runat="server" Style="margin-left: 150px;">Clear</asp:LinkButton>
                                                            <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                    <td>
                                                        
                                                      <asp:LinkButton ID="sas" runat="server" Style="margin-left: 430px;">Save as Synonyam</asp:LinkButton>
                                                          <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                   
                                                </tr>
                                            </table>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
     <div style="margin-left: 430px;">
        <asp:Label ID="Label25" runat="server" Text="Astro knowledge Update Module" Style="color: black;
            font-family: Georgia; font-size: 25px; margin: 0 auto; padding: 3px 10px;"></asp:Label>
            </div>
    <div id="list_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="root_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter1_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter1_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter2_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter2_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter3_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter3_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter4_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter4_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter5_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter5_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <div id="filter6_divu" style="position: absolute; top: 0px; left: 0px; border: none;
        display: none; z-index: 2; margin-top: 23px;">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                        <ContentTemplate>
                            <asp:ListBox ID="filter6_listu" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                            </asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    <table id="Table1" width="990px" cellspacing="0" cellpadding="0" border="0" align="center"
        style="margin-top: 50px; margin-left: -50px;">
        <tr valign="top">
            <td valign="top">
                <table class="RightTable" id="Table2" cellspacing="0" cellpadding="0" border="0"
                    style="left: 0px; top: 0px; padding-left: 50px; background-color: #f8f9fd;">
                    <tr>
                        <td>
                            <table border="1" align="center" style="width: 92.5%;">
                                <tr>
                                    <td>
                                        <table border="0" style="width: 100%; background-color: #e4e8f8;">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label12" runat="server" Text="Select data source"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="drop_selectu" runat="server">
                                                            <asp:ListItem>Astro knowledge</asp:ListItem>
                                                            <asp:ListItem>Horary knowledge</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label13" runat="server" Text="Main Root"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                            <ContentTemplate>
                                                                <asp:TextBox ID="rootu" runat="server" onblur="return initCapru(this.value)"></asp:TextBox></ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label14" runat="server" Text="Filter 1"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter1u" runat="server" onblur="return initCapf1u(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label15" runat="server" Text="Filter 2"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter2u" runat="server" onblur="return initCapf2u(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label16" runat="server" Text="Filter 3"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter3u" runat="server" onblur="return initCapf3u(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label17" runat="server" Text="Filter 4"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter4u" runat="server" onblur="return initCapf4u(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label21" runat="server" Text="Filter 5"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter5u" runat="server" onblur="return initCapf5u(this.value)"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label22" runat="server" Text="Filter 6"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="filter6u" runat="server" onblur="return initCapf6u(this.value)"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                 <td>
                                                    <asp:Label ID="Label27" runat="server" Text="Child List"  font-weight="600" font-family="Open Sans" font-size="11px"></asp:Label>
                                                     </td>
                                                     <td><asp:DropDownList ID="cl"  runat="server"></asp:DropDownList>
                                                    </td>
                                                    <td>
                                                    <asp:Label ID="Label28" runat="server" Text="Parent"  font-weight="600" font-family="Open Sans" font-size="11px"></asp:Label>
                                                     </td>
                                                     <td><asp:DropDownList ID="pl"  runat="server"></asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label18" runat="server" Text="Explanation"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <FCKeditorV2:FCKeditor ID="explanation_textu" runat="server" BasePath="~/fckeditor/"
                                                            Width="620px" Height="400px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--<asp:TextBox ID="explanation_textu" runat="server" TextMode="MultiLine" Width="370px" Height="100px" ></asp:TextBox>--%>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label19" runat="server" Text="Explanation 2"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <FCKeditorV2:FCKeditor ID="explanation_text2u" runat="server" BasePath="~/fckeditor/"
                                                            Width="620px" Height="400px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--<asp:TextBox ID="explanation_text2u" runat="server" TextMode="MultiLine" Width="370px" Height="100px" ></asp:TextBox>--%>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label20" runat="server" Text="Explanation 3" Style="display: none;"></asp:Label>
                                                    </td>
                                                    <td style="display: none;">
                                                        <FCKeditorV2:FCKeditor ID="explanation_text3u" runat="server" BasePath="~/fckeditor/"
                                                            Width="370px" Height="100px" ToolbarStartExpanded="false">
                                                        </FCKeditorV2:FCKeditor>
                                                        <%--<asp:TextBox ID="explanation_text3u" runat="server" TextMode="MultiLine" Width="370px" Height="100px" ></asp:TextBox>--%>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:LinkButton ID="update" runat="server" Style="margin-left: 40px;" 
                                                           >Update</asp:LinkButton>
                                                        <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton ID="clear1" runat="server" Style="margin-left: 150px;">Clear</asp:LinkButton>
                                                        <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton ID="delete" runat="server" Style="margin-left: 480px;">Delete</asp:LinkButton>
                                                        <%--<asp:button id="save" runat="server" text="SAVE" />--%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <input type="hidden" runat="server" id="hidden_root" />
    <input type="hidden" runat="server" id="hidden_filter1" />
    <input type="hidden" runat="server" id="hidden_filter2" />
    <input type="hidden" runat="server" id="hidden_filter3" />
    <input type="hidden" runat="server" id="hidden_filter4" />
    <input type="hidden" runat="server" id="hidden_filter5" />
    <input type="hidden" runat="server" id="hidden_filter6" />
    <input type="hidden" runat="server" id="hidden_rootu" />
    <input type="hidden" runat="server" id="hidden_filter1u" />
    <input type="hidden" runat="server" id="hidden_filter2u" />
    <input type="hidden" runat="server" id="hidden_filter3u" />
    <input type="hidden" runat="server" id="hidden_filter4u" />
    <input type="hidden" runat="server" id="hidden_filter5u" />
    <input type="hidden" runat="server" id="hidden_filter6u" />
    <input type="hidden" runat="server" id="up" />
    <input type="hidden" runat="server" id="hidden_ex" />
    
    </form>
</body>
</html>
