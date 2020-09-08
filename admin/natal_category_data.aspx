<%@ Page Language="C#" AutoEventWireup="true" CodeFile="natal_category_data.aspx.cs" Inherits="admin_natal_category_data" EnableEventValidation="false" ValidateRequest="false" %>

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
        .grdchkbox
        {
            width: 20px;
            height: 20px;
        }

            .grdchkbox input
            {
                width: 20px;
                height: 20px;
                background-color: Red;
            }

        .modal
        {
            position: fixed;
            z-index: 999;
            height: 100%;
            width: 100%;
            top: 0;
            /*background-color: Black;*/
            /*filter: alpha(opacity=60);
            opacity: 0.6;
            -moz-opacity: 0.8;*/
        }

        .center
        {
            z-index: 1000;
            margin: 300px auto;
            padding: 10px;
            width: 256px;
            border-radius: 10px;
            filter: alpha(opacity=100);
            opacity: 1;
            -moz-opacity: 1;
        }

            .center img
            {
                /*height: 128px;
                width: 128px;*/
            }
    </style>

    <script type="text/javascript">
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

            var lblpredictiveid = "grdviews_ctl" + (k) + "_lblpredictive";
            document.getElementById('txtpredictivenew').value = document.getElementById(lblpredictiveid).value;

            var xState = chkB.checked;
            if (xState) {
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = 'lightblue';
            }
            else {
                document.getElementById('txtpredictivenew').value = '';
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
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
            <ProgressTemplate>
                <div class="modal">
                    <div class="center">
                        <img alt="Fetching Records Please Wait..." src="../Image/loading_icon_transparent.gif" />
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <div class="maincontainer">
            <uc1:header ID="header1" runat="server" />
            <div class="middlecontainer">
                <div class="form-main" style="float: left; width: 98%; margin: 1% 0% 1% 1%;">
                    <div class="form-white-background">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="form-title-row">
                                    <h1>Search Natal Category Keystring/Filters
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
                                <div class="form-row" style="float: left; width: 100%; margin: 1em 0em 0em 0em;">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="buttoncss"
                                                OnClick="btnsearch_Click" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="form-row" style="float: left; width: 100%;">
                                    <label>
                                        <h4 id="lbl_result" runat="server"></h4>
                                    </label>
                                </div>

                                <div style="float: left; margin: 0.5em 0em 0em 0em; padding: 0em; width: 100%;">
                                    <asp:GridView ID="grdviews" runat="server" Width="100%" AutoGenerateColumns="False"
                                        CellPadding="4" PageSize="200" AllowPaging="True" DataKeyNames="DESCRIPTION" BorderColor="#CDE0F5"
                                        HeaderStyle-Font-Bold="true" BackColor="#F0F0F0"
                                        HeaderStyle-ForeColor="White" HeaderStyle-Height="30px" HeaderStyle-Font-Size="14px"
                                        OnPageIndexChanging="grdviews_PageIndexChanging" OnRowDataBound="grdviews_RowDataBound"
                                        CssClass="grdviewstable">
                                        <Columns>
                                            <asp:BoundField DataField="DESCRIPTION" HeaderText="Code" Visible="false" />
                                            <%--<asp:TemplateField HeaderText="S.No" Visible="true">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblrowno" Width="10px" runat="server" Text=""></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>--%>
                                            <asp:TemplateField HeaderText="Unique_Id" Visible="true">
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
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Predictive" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblpredictive" runat="server" Text='<%# Bind("DESCCLOB")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="U_Id" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lbluniqueid" runat="server" Text='<%# Bind("UNIQUE_ID")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Book" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblbook" runat="server" Text='<%# Bind("BOOK")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Page" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblpageno" runat="server" Text='<%# Bind("PAGE_NO")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Form_ID" Visible="true">
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
                                            <asp:TemplateField HeaderText="Type" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lbltype" runat="server" Text='<%# Bind("PREDICTIVE_TYPE")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Date" Visible="true">
                                                <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left" Width="100px"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lbldate" runat="server" Text='<%# Bind("CRTD_DATE")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Mapping">
                                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="70px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:HyperLink Text="Mapping" ID="btnedit" runat="server" Target="_blank" ForeColor="Red"
                                                        Font-Bold="false" Font-Size="0.85em" Font-Underline="true"></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Action" Visible="false">
                                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="70px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:HyperLink Text="Add Category" ID="btnaddcat" runat="server" Target="_blank"
                                                        ForeColor="Red" Font-Bold="false" Font-Size="0.85em" Font-Underline="true"></asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <FooterStyle CssClass="FooterStyle" />
                                        <RowStyle CssClass="RowStyle" />
                                        <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                                        <PagerStyle CssClass="PagerStyle" Wrap="True"
                                            HorizontalAlign="Center"></PagerStyle>
                                    </asp:GridView>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
