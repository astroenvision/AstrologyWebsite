<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Natal_Category_Mapping.aspx.cs" Inherits="admin_Natal_Category_Mapping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Manage Category Mapping</h3>
            </div>
        </div>
        <div class="clearfix"></div>
        <div class="row" style="display: block;">
            <div class="clearfix"></div>
            <div class="col-md-12 col-sm-12">
                <div class="x_panel">
                    <div class="x_title">
                        <div class="col-md-3">
                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" Width="250">
                                <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_click" />
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                        </div>
                        <div class="col-sm-5">
                            <asp:hyperlink ID="btnAddNew" runat="server" href="AddMappingCategory.aspx" Target="_blank" Style="color:White;"  CssClass="btn btn-success">Add New</asp:hyperlink>
                            <asp:hyperlink ID="Hyperlink1" runat="server" href="AddMappingCategory.aspx?Flag=CompatibilityMatching" Target="_blank" Style="color:White;"  CssClass="btn btn-success">Add New For Marriage</asp:hyperlink>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                            <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                        </div>
                        <div class="table-responsive">
                            <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                <AlternatingRowStyle CssClass="even" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ID" Visible="true">
                                        <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_ID").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="CATEGORY_NAME" HeaderText="CATEGORY NAME" />
                                    <asp:BoundField DataField="CATMAPID" HeaderText="MAPPED CATEGORY ID" />
                                    <asp:BoundField DataField="CATMAPIDNAME" HeaderText="MAPPED CATEGORY NAME" />
                                    <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY" />
                                    <asp:BoundField DataField="STATUS" HeaderText="STATUS" />
                                    <asp:BoundField DataField="MAPPING_FOR" HeaderText="MAPPING FOR" />
                                    
                                    <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="85"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/AddMappingCategory.aspx?q=" + Eval("CATEGORY_ID") + "&Flag="+ Eval("MAPPING_FOR") %>'
                                                title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
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
    </div>
</asp:Content>

