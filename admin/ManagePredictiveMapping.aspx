<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManagePredictiveMapping.aspx.cs" Inherits="admin_ManagePredictiveMapping" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        #loading {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }

        .loading {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }

        #loadingimg {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Manage Natal Predictive<small></small></h3>
                        </div>
                        <div class="title_right" runat="server" visible="false">
                            <div class="col-md-5 col-sm-5   form-group pull-right top_search">
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
                    <div class="row" style="display: block;">
                        <div class="clearfix"></div>
                        <div class="col-md-12 col-sm-12 ">
                            <div class="x_panel">
                                <div class="x_title">
                                    <div class="col-md-2">
                                        <asp:Label runat="server" Font-Bold="true">Table</asp:Label>
                                        <asp:DropDownList ID="ddltable" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddltable_SelectedIndexChanged" AutoPostBack="true">
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

                                    <div class="col-md-2">
                                        <asp:Label runat="server" Font-Bold="true">KeyString:</asp:Label>
                                        <asp:DropDownList ID="ddlkeystring" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlkeystring_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-md-2">
                                        <asp:Label runat="server" Font-Bold="true">Logic:</asp:Label>
                                        <asp:DropDownList ID="ddllogic" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddllogic_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-md-2">
                                        <asp:Label runat="server" Font-Bold="true">Predictive Type:</asp:Label>
                                        <asp:DropDownList ID="ddlpredictivetype" runat="server" AutoPostBack="true" CssClass="form-control">
                                            <asp:ListItem Value="" Text="All" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="ddlcategory" runat="server" Visible="false" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged" />
                                        <asp:DropDownList ID="ddlquestion" runat="server" Visible="false" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlquestion_SelectedIndexChanged" />
                                        <asp:DropDownList ID="ddlfilter" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlfilter_SelectedIndexChanged" Visible="false" />
                                    </div>
                                    <div class="col-md-3">
                                         <asp:Label runat="server" Font-Bold="true">Predictive For:</asp:Label>
                                        <asp:DropDownList ID="ddlpredictivefor" runat="server" AutoPostBack="true" CssClass="form-control">
                                            <asp:ListItem Value="" Text="All" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="LAGNA" Text="LAGNA"></asp:ListItem>
                                            <asp:ListItem Value="PROFESSION" Text="PROFESSION"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="clearfix"></div>

                                </div>
                                <div class="x_title">
                                    <div class="col-md-3">
                                        <asp:Label runat="server" Font-Bold="true">Logic</asp:Label>
                                        <asp:TextBox ID="txtsrch" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:Label runat="server" Font-Bold="true">Predictive</asp:Label>
                                        <asp:TextBox ID="txtpredictive" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2" style="margin-top: 16px;">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnsearch_Click" />
                                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_content">
                                    <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50"
                                            HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" OnRowDataBound="grdData_RowDataBound">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:BoundField DataField="DESCRIPTION" HeaderText="Code" Visible="false" />
                                                <%--<asp:TemplateField HeaderText="S.No" Visible="true">
                                                <ItemStyle VerticalAlign="top"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblrowno" Width="10px" runat="server" Text=""></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>--%>
                                                <asp:TemplateField HeaderText="Id" Visible="true">
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
                                                <asp:TemplateField HeaderText="Type" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbltype" runat="server" Text='<%# Bind("PREDICTIVE_TYPE") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Predictive For" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblfor" runat="server" Text='<%# Bind("PREDICTIVE_FOR")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Date" Visible="false">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left" Width="100px"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbldate" runat="server" Text='<%# Bind("CRTD_DATE")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Mapping With">
                                                    <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="70px"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblmappingiwth" runat="server" Text='<%# Bind("MAPPING_CATEGORY")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Mapping">
                                                    <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="70px"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink Text="" ID="btnedit" runat="server" Target="_blank" ForeColor="Red"
                                                            Font-Bold="false" Font-Size="1em" Font-Underline="true"><i class="fa fa-map" aria-hidden="true"></i> Mapping</asp:HyperLink>
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
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <div class="loading">
                        <div class="loader-custom-inner">
                            <img src="<%=ResolveUrl("~/img/Loader.gif") %>" alt="Loader" title="Loader" />
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
</asp:Content>

