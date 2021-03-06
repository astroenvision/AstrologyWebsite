﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="UpdatePredictive.aspx.cs" Inherits="admin_UpdatePredictive" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Update Natal Predictive</h3>
                </div>
                <div class="title_right" runat="server" visible="false">
                    <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-12 ">
                            <div class="x_panel">
                                <div class="x_title">
                                    <h2 id="MaxPriorityID" runat="server"></h2>
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
                                        <div class="col-md-3 col-sm-3 form-group has-feedback">
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
                                                <asp:ListItem Value="IMPORTANT_PLANET_MST" Text="IMPORTANT_PLANET_MST"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-3 col-sm-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Unique Id:</label>
                                            <asp:TextBox runat="server" ID="txtuniqueid" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-2 col-sm-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive Type:</label>
                                            <asp:DropDownList runat="server" ID="ddlpredictivetype" CssClass="form-control">
                                                <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                                <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                                <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                                <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-2 col-sm-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Status:</label>
                                            <asp:DropDownList runat="server" ID="ddlstatus" CssClass="form-control">
                                                <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                                <asp:ListItem Value="A" Text="Show"></asp:ListItem>
                                                <asp:ListItem Value="U" Text="Hide"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-2 col-sm-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Checked:</label>
                                            <asp:DropDownList runat="server" ID="ddlchecked" CssClass="form-control">
                                                <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                                <asp:ListItem Value="T" Text="Checked"></asp:ListItem>
                                                <asp:ListItem Value="F" Text="Unchecked"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-6 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Keystring/Filter:</label>
                                            <asp:TextBox runat="server" ID="txtkeystringnew" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Mapping Categories</label>
                                            <asp:TextBox runat="server" ID="txtmappedcategories" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                            <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
                                                <asp:ListItem Value="0" Text="--Select Priority--"></asp:ListItem>
                                                <asp:ListItem Value="0" Text="0"></asp:ListItem>
                                                <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                                <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                                <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                                 <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                                <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                                <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                                <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                                 <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                                <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                                <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                                <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                                 <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                                <asp:ListItem Value="13" Text="13"></asp:ListItem>
                                                <asp:ListItem Value="14" Text="14"></asp:ListItem>
                                                <asp:ListItem Value="15" Text="15"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-12 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Logic:</label>
                                            <asp:TextBox runat="server" ID="txtlogic" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-12 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive:</label>
                                            <FCKeditorV2:FCKeditor ID="rtepredictivenew" runat="server" BasePath="~/fckeditor/" Height="400"></FCKeditorV2:FCKeditor>
                                        </div>
                                        <div class="col-md-12 form-group has-feedback">
                                            <label style="font-size: 14px; color: #555; font-weight: bold;">Remedial:</label>
                                            <FCKeditorV2:FCKeditor ID="rteremedialnew" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                                        </div>
                                        <div class="clearfix"></div>
                                        <div class="form-group row">
                                            <div class="col-md-9 col-sm-9 offset-md-3">
                                                <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnupdate_Click" />
                                                <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
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
                                        <asp:DropDownList Width="100px" ID="ddlpredictive" runat="server" CssClass="txtblack" Visible="false">
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                            <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Label ID="lblpredictivetype" runat="server" Text='<%# Bind("PREDICTIVE_TYPE")%>'
                                            Visible="true"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%--<asp:TemplateField>
                                        <HeaderStyle VerticalAlign="top" HorizontalAlign="Center" Width="25px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="cbRows" runat="server" CssClass="grdchkbox" onclick="HighlightRow(this)"
                                                AutoPostBack="false" />
                                        </ItemTemplate>
                                        <HeaderTemplate>
                                            <input style="display: none;" type="checkbox" id="mainCB" class="grdchkbox" onclick="javascript: CheckAllRows(this);" />
                                        </HeaderTemplate>
                                    </asp:TemplateField>--%>
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
    </div>
</asp:Content>




