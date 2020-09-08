<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="UpdatePredictiveMapping.aspx.cs" Inherits="admin_UpdatePredictiveMapping" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

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
            var table = document.getElementById('ctl00_ContentPlaceHolder1_grdData');
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

            var lblpredictiveid = "ctl00_ContentPlaceHolder1_grdData_ctl" + (k) + "_rtepredictive";
            var inspre = FCKeditorAPI.GetInstance(lblpredictiveid);
            var preval = inspre.GetHTML();
            var insprenew = FCKeditorAPI.GetInstance('ctl00_ContentPlaceHolder1_rtepredictivenew');
            insprenew.SetHTML(preval);

            var lblremedialid = "ctl00_ContentPlaceHolder1_grdData_ctl" + (k) + "_rteremedial";
            var insrem = FCKeditorAPI.GetInstance(lblremedialid);
            var remval = insrem.GetHTML();
            var insremnew = FCKeditorAPI.GetInstance('ctl00_ContentPlaceHolder1_rteremedialnew');
            insremnew.SetHTML(remval);

            var xState = chkB.checked;
            if (xState) {
                chkB.parentElement.parentElement.parentElement.style.backgroundColor = 'lightblue';
            }
            else {
                //document.getElementById('txtpredictivenew').value = '';
                FCKeditorAPI.GetInstance('ctl00_ContentPlaceHolder1_rtepredictivenew').SetHTML("");
                FCKeditorAPI.GetInstance('ctl00_ContentPlaceHolder1_rteremedialnew').SetHTML("");
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="page-title">
                    <div class="title_left">
                        <h3>Update Predictive Mapping</h3>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="row">
                    <div class="col-md-12 ">
                        <div class="x_panel">
                            <div class="x_title">
                                <ul class="nav navbar-right panel_toolbox">
                                    <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                    </li>
                                    <li><a class="close-link"><i class="fa fa-close"></i></a>
                                    </li>
                                </ul>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div class="form-label-left input_mask">
                                    <div class="col-md-3 col-sm-3  form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Table:</label>
                                        <asp:DropDownList runat="server" ID="ddltable" CssClass="form-control" OnSelectedIndexChanged="ddltable_SelectedIndexChanged" AutoPostBack="true">
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
                                    </div>
                                    <div class="col-md-3 col-sm-3  form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Category:</label>
                                        <asp:DropDownList runat="server" ID="ddlcategory" CssClass="form-control" OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3  form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Question:</label>
                                        <asp:DropDownList runat="server" ID="ddlquestion" CssClass="form-control" OnSelectedIndexChanged="ddlquestion_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3  form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Keystring:</label>
                                        <asp:DropDownList runat="server" ID="ddlfilter" CssClass="form-control" OnSelectedIndexChanged="ddlfilter_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-6 form-group has-feedback" style="display: none;">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">New Keystring/Filter:</label>
                                        <asp:TextBox runat="server" ID="txtkeystringnew" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Mapping Categories</label>
                                        <asp:TextBox runat="server" ID="txtmappedcategories" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Is Mapped:</label>
                                        <asp:DropDownList runat="server" ID="ddlismapped" CssClass="form-control" AutoPostBack="true">
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="Y" Text="Yes"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-6 form-group has-feedback" style="display: none;">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Book:</label>
                                        <asp:DropDownList runat="server" ID="ddlbooks" CssClass="form-control" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlbooks_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-6 form-group has-feedback" style="display: none;">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Sub Book:</label>
                                        <asp:DropDownList runat="server" ID="ddlsubbooks" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                    <div class="col-md-6 form-group has-feedback" style="display: none;">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Unique Id:</label>
                                        <asp:TextBox runat="server" ID="txtuniqueid" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive Type:</label>
                                        <asp:DropDownList runat="server" ID="ddlpredictivetype" CssClass="form-control" AutoPostBack="true">
                                            <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                            <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-6 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">New Predictive:</label>
                                        <FCKeditorV2:FCKeditor ID="rtepredictivenew" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="500px"
                                            Height="270px">
                                        </FCKeditorV2:FCKeditor>
                                    </div>
                                    <div class="col-md-6  form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">New Remedial:</label>
                                        <FCKeditorV2:FCKeditor ID="rteremedialnew" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="500px"
                                            Height="270px">
                                        </FCKeditorV2:FCKeditor>
                                    </div>
                                    <div class="clearfix"></div>
                                    <div class="form-group row">
                                        <div class="col-md-9 col-sm-9  offset-md-3">
                                            <asp:LinkButton ID="btninsert" runat="server" Text="Click Here For New Mapping" CssClass="btn btn-primary"
                                                OnClick="btninsert_Click" />
                                            <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnupdate_Click" />
                                            <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="x_content">
                        <div class="table-responsive">
                            <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowDataBound="grdData_RowDataBound"
                                CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                <AlternatingRowStyle CssClass="even" />
                                <Columns>
                                    <asp:BoundField DataField="DESCRIPTION" HeaderText="Code" Visible="false" />
                                    <asp:TemplateField HeaderText="Auto_ID" Visible="false">
                                        <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblautoid" runat="server" Text='<%# Bind("AUTO_ID")%>'></asp:Label>
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
                                            <FCKeditorV2:FCKeditor ID="rteremedial" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="200px"
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
                                    <%--<asp:TemplateField HeaderText="Modify">
                                        <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink Text="Edit" ID="btnedit" runat="server" Target="_blank" ForeColor="Red" Font-Bold="false" Font-Size="0.85em" Font-Underline="true"></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                </Columns>
                                <EmptyDataTemplate>
                                    No record to display...
                                </EmptyDataTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                                <PagerStyle CssClass="gridpager" />
                                <RowStyle CssClass="odd" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
                </div>
            </ContentTemplate>
            <%--<Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
            </Triggers>--%>
        </asp:UpdatePanel>
    </div>
</asp:Content>






