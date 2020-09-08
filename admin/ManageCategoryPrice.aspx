<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageCategoryPrice.aspx.cs" Inherits="admin_ManageCategoryPrice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%=ResolveUrl("~/js/ApproveTestimonials.js") %>"></script>
    <script src="<%=ResolveUrl("~/admin/custom.css") %>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Manage Category Price<small></small></h3>
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
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <div class="col-md-2">
                                <asp:DropDownList ID="ddlCat" runat="server" CssClass="form-control">
                                    <asp:ListItem Selected="True" Value="-1">Select Category</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-7">
                                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                            </div>
                            <div class="col-sm-3">
                                  <asp:hyperlink ID="btnAddNew" runat="server" href="AddCategoryPrice.aspx" Target="_blank" Style="color:White;"  CssClass="btn btn-success">Add Category Price</asp:hyperlink>
                           </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                              <div style="float: left; width: 100%; margin: 0% auto;padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black;font-weight:bold;"></span>
                                    </div>
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                    CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="ID" Visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px" CssClass="column-title"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "AUTOID").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="CAT_NAME" HeaderText="CATEGORY NAME" />
                                        <asp:BoundField DataField="PRICE_INR" HeaderText="ACTUAL PRICE INR" />
                                        <asp:BoundField DataField="DISCOUNT_INR" HeaderText="DIS.(%) INR" />
                                        <asp:BoundField DataField="DISCOUNTPRICE_INR" HeaderText="DIS. PRICE INR" />
                                        <asp:BoundField DataField="FINALPRICE_INR" HeaderText="FINAL PRICE INR" />
                                        <asp:BoundField DataField="PRICE_USD" HeaderText="ACTUAL PRICE USD" />
                                        <asp:BoundField DataField="DISCOUNT_USD" HeaderText="DIS.(%) USD" />
                                        <asp:BoundField DataField="DISCOUNTPRICE_USD" HeaderText="DIS. PRICE USD" />
                                        <asp:BoundField DataField="FINALPRICE_USD" HeaderText="FINAL PRICE USD" />
                                        <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/UpdateCategoryPrice.aspx?q=" + Eval("AUTOID") + "&PayType="+ "INR"  %>'
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
    </div>
</asp:Content>
