<%@ Page Language="C#" AutoEventWireup="true" CodeFile="map_natal_data.aspx.cs" Inherits="admin_map_natal_data"
    ValidateRequest="false" EnableEventValidation="false" AsyncTimeout="36000" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/headernew.ascx" TagName="header" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision | Admin</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/index.css") %>" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/admincss.css") %>" />

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/admin.js") %>"></script>

    <style type="text/css">
        .grdchkbox {
            width: 20px;
            height: 20px;
        }

            .grdchkbox input {
                width: 20px;
                height: 20px;
                background-color: Red;
            }
    </style>

    <script type="text/javascript">

        function ConfirmDelete() {
            var Delet_Confirm = confirm("Do you really want to delete this record ?");
            if (Delet_Confirm == true) {
                return true;
            }
            else {
                return false;
            }
        }

        function rowno(chkB, rowindex) {
            var i, CellValue, Row, td, k;
            i = parseInt(rowindex) + 1;
            var table = document.getElementById('grdviews');
            Row = table.rows[i];
            td = Row.cells[1];
            //CellValue = Row.innerHTML;
            //CellValue = td.children[0].attributes[0].value;
            //alert(CellValue);
            if (i < 9) {
                i = i + 1;
                k = '0' + i;
            }
            else {
                i = i + 1;
                k = i;
            }

            //var lblpredictiveid = "grdviews_ctl" + (k) + "_lblpredictive";
            //document.getElementById('txtpredictivenew').value = document.getElementById(lblpredictiveid).value;

            var lblpredictiveid = "grdviews_ctl" + (k) + "_rtepredictive";
            var inspre = FCKeditorAPI.GetInstance(lblpredictiveid);
            var preval = inspre.GetHTML();
            var insprenew = FCKeditorAPI.GetInstance('rtepredictivenew');
            insprenew.SetHTML(preval);

            var lblremedialid = "grdviews_ctl" + (k) + "_rteremedial";
            var insrem = FCKeditorAPI.GetInstance(lblremedialid);
            var remval = insrem.GetHTML();
            var insremnew = FCKeditorAPI.GetInstance('rteremedialnew');
            insremnew.SetHTML(remval);

            var xState = chkB.checked;
            if (xState) {
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = 'lightblue';
            }
            else {
                //document.getElementById('txtpredictivenew').value = '';
                FCKeditorAPI.GetInstance('rtepredictivenew').SetHTML("");
                FCKeditorAPI.GetInstance('rteremedialnew').SetHTML("");
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = '#F0F0F0';
                chkB.parentElement.parentElement.parentElement.style.color = 'black';
            }
        }


        function HighlightRow(chkB) {
            var xState = chkB.checked;
            if (xState) {
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = 'lightblue';
            }
            else {
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = '#F0F0F0';
                chkB.parentElement.parentElement.parentElement.style.color = 'black';
            }
        }

        function CheckAllRows(objRef) {
            var GridView = objRef.parentNode.parentNode.parentNode;
            var inputList = GridView.getElementsByTagName("input");
            for (var i = 0; i < inputList.length; i++) {
                //Get the Cell To find out ColumnIndex
                var row = inputList[i].parentNode.parentNode.parentNode;
                if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
                    if (objRef.checked) {
                        //If the header checkbox is checked
                        //check all checkboxes
                        //and highlight all rows
                        row.style.backgroundColor = "lightblue";
                        inputList[i].checked = true;
                    }
                    else {
                        //If the header checkbox is checked
                        //uncheck all checkboxes
                        //and change rowcolor back to original
                        if (row.rowIndex % 2 == 0) {
                            //Alternating Row Color
                            //row.style.backgroundColor = "#C2D69B";
                            row.style.backgroundColor = "#F0F0F0";
                        }
                        else {
                            row.style.backgroundColor = "#F0F0F0";
                        }
                        inputList[i].checked = false;
                    }
                }
            }
        }
    </script>

    <script type="text/javascript" language="javascript">
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
        function EndRequestHandler(sender, args) {
            if (args.get_error() != undefined) {
                args.set_errorHandled(true);
            }
        }
    </script>

</head>
<body id="body">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="maincontainer">
            <uc1:header ID="header1" runat="server" />
            <div class="middlecontainer">
                <div class="form-main" style="float: left; width: 98%; margin: 1% 0% 1% 1%;">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>Search/Update Natal Predictive
                                    </h1>
                                    <h2>* Indicates Mandatory Fields</h2>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Table:</span>
                                        <asp:DropDownList ID="ddltable" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddltable_SelectedIndexChanged" Width="180">
                                            <asp:ListItem Value="--Select Table--" Text="--Select Table--"></asp:ListItem>
                                            <asp:ListItem Value="HOUSE_POSITIPON" Text="HOUSE_POSITIPON"></asp:ListItem>
                                            <asp:ListItem Value="HOUSE_POSITIPON_COMB" Text="HOUSE_POSITIPON_COMB"></asp:ListItem>
                                            <asp:ListItem Value="PLANET_ASPECT" Text="PLANET_ASPECT"></asp:ListItem>
                                            <asp:ListItem Value="EDM" Text="EDM"></asp:ListItem>
                                            <asp:ListItem Value="BENIFICS_MALIFICS_ASPECT" Text="BENIFICS_MALIFICS_ASPECT"></asp:ListItem>
                                            <asp:ListItem Value="PLANET_ASPECT_PLANET" Text="PLANET_ASPECT_PLANET"></asp:ListItem>
                                            <asp:ListItem Value="PLANETFROMPLANET" Text="PLANETFROMPLANET"></asp:ListItem>
                                            <asp:ListItem Value="COMBUSTION_DEGREE" Text="COMBUSTION_DEGREE"></asp:ListItem>
                                            <asp:ListItem Value="QUADRAPED_COMBINATION" Text="QUADRAPED_COMBINATION"></asp:ListItem>
                                            <asp:ListItem Value="MULTIPLE_COMBINATIONS" Text="MULTIPLE_COMBINATIONS"></asp:ListItem>
                                            <asp:ListItem Value="REMEDIAL_COMB" Text="REMEDIAL_COMB"></asp:ListItem>
                                            <asp:ListItem Value="LAGNA_MST" Text="LAGNA_MST"></asp:ListItem>
                                            <asp:ListItem Value="YOGA_PREDICTIVE" Text="YOGA_PREDICTIVE"></asp:ListItem>
                                        </asp:DropDownList>
                                    </label>
                                    <label>
                                        <span>Category:</span>
                                        <asp:DropDownList ID="ddlcategory" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged" Width="180" />
                                    </label>
                                    <label>
                                        <span>Question:</span>
                                        <asp:DropDownList ID="ddlquestion" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlquestion_SelectedIndexChanged" />
                                    </label>
                                    <label>
                                        <span>Keystring:</span>
                                        <asp:DropDownList ID="ddlfilter" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlfilter_SelectedIndexChanged" />
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; color: #5f5f5f; text-align: left;">
                                    <label>
                                        <span>New Keystring/Filter:</span><asp:TextBox ID="txtkeystringnew" runat="server"
                                            Text="" Width="300px"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; color: #5f5f5f; text-align: left;">
                                    <label>
                                        <span style="padding-right: 110px;">Book:</span>
                                        <asp:DropDownList ID="ddlbooks" CssClass="dropdowncss" runat="server" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlbooks_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        &nbsp;&nbsp;Sub Book:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="ddlsubbooks" CssClass="dropdowncss" AutoPostBack="true" runat="server">
                                    </asp:DropDownList>
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; color: #5f5f5f; text-align: left;">
                                    <label>
                                        <span style="padding-right: 76px;">Unique Id:</span>
                                        <asp:TextBox ID="txtuniqueid" runat="server" Text="" Width="208px"></asp:TextBox>
                                        &nbsp;&nbsp;Predictive Type:&nbsp;&nbsp;
                                    <asp:DropDownList ID="ddlpredictivetype" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                        Width="205">
                                        <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                        <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                        <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                        <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                    </asp:DropDownList>
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; color: #5f5f5f; text-align: left;">
                                    <label>
                                        <div style="float:left;">
                                        <span style="padding-right: 38px;">New Predictive:</span>
                                        <%--<asp:TextBox ID="txtpredictivenew" runat="server" Text="" TextMode="MultiLine" Height="150"></asp:TextBox>--%>
                                        <FCKeditorV2:FCKeditor ID="rtepredictivenew" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="500px"
                                                Height="270px">
                                         </FCKeditorV2:FCKeditor>
                                            </div>
                                        <div style="float:left;">
                                        <span style="padding-right: 38px;">New Remedial:</span>
                                        <FCKeditorV2:FCKeditor ID="rteremedialnew" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="500px"
                                                Height="270px">
                                         </FCKeditorV2:FCKeditor>
                                            </div>
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; color: #5f5f5f; text-align: left;">
                                    <label>
                                        <%--<span style="padding-right: 38px;">New Remedial:</span>--%>
                                        <%--<asp:TextBox ID="txtremedialnew" runat="server" Text="" TextMode="MultiLine" Height="150"></asp:TextBox>--%>
                                    </label>
                                </div>
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em; text-align: left;">
                                    <asp:Button ID="btninsert" runat="server" Text="Click Here For New Mapping" CssClass="buttoncss"
                                        OnClick="btninsert_Click" />
                                    <asp:Button ID="btnupdate" runat="server" Text="Update For Exist Predictive" CssClass="buttoncss marginlft" OnClick="btnupdate_Click" />
                                    <asp:Button ID="btndelete" runat="server" Text="Delete" CssClass="buttoncssfltright" OnClick="btndelete_Click" OnClientClick="return ConfirmDelete();" />
                                </div>
                                <div class="form-row" style="float: left; width: 100%;">
                                    <label>
                                        <h4 id="lbl_result" runat="server"></h4>
                                    </label>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div style="float: left; margin: 0.5em 0em 0em 0em; padding: 0em; width: 100%;">
                            <asp:GridView ID="grdviews" runat="server" Width="100%" AutoGenerateColumns="False"
                                CellPadding="4" PageSize="50" AllowPaging="True" DataKeyNames="DESCRIPTION" BorderColor="#CDE0F5"
                                HeaderStyle-Font-Bold="true" BackColor="#F0F0F0" HeaderStyle-BackColor="#F4600A"
                                HeaderStyle-ForeColor="White" HeaderStyle-Height="30px" HeaderStyle-Font-Size="14px"
                                OnPageIndexChanging="grdviews_PageIndexChanging" OnRowDataBound="grdviews_RowDataBound"
                                CssClass="table">
                                <Columns>
                                    <asp:BoundField DataField="DESCRIPTION" HeaderText="Code" Visible="false" />
                                    <asp:TemplateField HeaderText="Auto_ID" Visible="false">
                                        <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblautoid" runat="server" Text='<%# Bind("AUTO_ID")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Logic">
                                        <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbllogic" runat="server" Text='<%# Bind("DESCRIPTION")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Filter" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblkeystring" runat="server" Text='<%# Bind("KEY_STRING")%>'></asp:Label>
                                            <%--<asp:TextBox ID="lblkeystring" runat="server" Text='<%# Bind("KEY_STRING")%>' TextMode="MultiLine"
                                            Height="70px"></asp:TextBox>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Predictive" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <%--<asp:Label ID="lblpredictive" runat="server" Text='<%# Bind("DESCCLOB")%>'></asp:Label>--%>
                                            <%--<asp:TextBox ID="lblpredictive" runat="server" Text='<%# Bind("DESCCLOB")%>' TextMode="MultiLine"
                                                Height="70px"></asp:TextBox>--%>
                                            <FCKeditorV2:FCKeditor ID="rtepredictive" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="300px"
                                                Height="200px" Value='<%# Bind("DESCCLOB")%>'>
                                            </FCKeditorV2:FCKeditor>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Remedial" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <FCKeditorV2:FCKeditor ID="rteremedial" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="300px"
                                                Height="200px" Value='<%# Bind("REMEDIAL")%>'>
                                            </FCKeditorV2:FCKeditor>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Unique_Id" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbluniqueid" runat="server" Text='<%# Bind("UNIQUE_ID")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Book" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblbook" runat="server" Text='<%# Bind("BOOK")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Page" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblpageno" runat="server" Text='<%# Bind("PAGE_NO")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Form_ID" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblformid" runat="server" Text='<%# Bind("FORM_ID")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Category" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcat" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Question" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblquestion" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="House" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblhouse" runat="server" Text='<%# Bind("HOUSE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Planet" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblplanet" runat="server" Text='<%# Bind("PLANET")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Rashi" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblrashi" runat="server" Text='<%# Bind("RASHI")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="LRashi" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbllagnarashi" runat="server" Text='<%# Bind("LAGNA_RASHI")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Combination" Visible="false">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcombination" runat="server" Text='<%# Bind("COMBINATION")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Type" Visible="true">
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:DropDownList Width="100px" ID="ddlpredictive" runat="server" CssClass="txtblack">
                                                <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                                <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                                <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                                <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:Label ID="lblpredictivetype" runat="server" Text='<%# Bind("PREDICTIVE_TYPE")%>'
                                                Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <HeaderStyle VerticalAlign="top" HorizontalAlign="Center" Width="25px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="cbRows" runat="server" CssClass="grdchkbox" onclick="HighlightRow(this)"
                                                AutoPostBack="false" />
                                        </ItemTemplate>
                                        <HeaderTemplate>
                                            <input style="display: none;" type="checkbox" id="mainCB" class="grdchkbox" onclick="javascript: CheckAllRows(this);" />
                                        </HeaderTemplate>
                                    </asp:TemplateField>
                                    <%--<asp:TemplateField HeaderText="Modify">
                                        <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink Text="Edit" ID="btnedit" runat="server" Target="_blank" ForeColor="Red" Font-Bold="false" Font-Size="0.85em" Font-Underline="true"></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                </Columns>
                                <PagerStyle BackColor="#F4600A" CssClass="tablepagging" ForeColor="white" Wrap="True"
                                    HorizontalAlign="Center"></PagerStyle>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
