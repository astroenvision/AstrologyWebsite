<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageCategory.aspx.cs" Inherits="admin_ManageCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Manage Category<small></small></h3>
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
            <div class="col-md-12 col-sm-12">
                <div class="x_panel">
                    <div class="x_title">
                        <div class="col-md-3">
                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" Width="250">
                                <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                        </div>
                          <div class="col-sm-5">
                            <asp:hyperlink ID="btnAddNew" runat="server" href="AddNatalCategory.aspx" Target="_blank" Style="color:White;"  CssClass="btn btn-success">Add New</asp:hyperlink>
                        
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                            <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                        </div>
                        <div class="table-responsive">
                            <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowDataBound="grdData_RowDataBound"
                                CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                <AlternatingRowStyle CssClass="even" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ID" Visible="false">
                                        <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_ID").ToString()) %>'></asp:Label>
                                             <asp:Label ID="lblColor" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_COLOR").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ROW_NO" HeaderText="SNO" HeaderStyle-Width="30" />
                                    <asp:BoundField DataField="CATEGORY_ID" HeaderText="CATID" HeaderStyle-Width="30" />
                                    <asp:TemplateField HeaderText="IMAGE">
                                        <HeaderStyle HorizontalAlign="Left" Width="120px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Image ID="Image1" runat="server"  Height="70px" Width="80px" ImageUrl='<%# "~/img/" + Eval("CATEGORY_IMAGE") %>'  />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="CATEGORY NAME">
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" Font-Bold="true" Font-Size="larger"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblCategoryName"  runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_NAME").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY" HeaderStyle-Width="90" />
                                    <%--<asp:BoundField DataField="STATUS" HeaderText="STATUS" HeaderStyle-Width="70" />--%>
                                    <%--<asp:BoundField DataField="IS_PAID" HeaderText="PAID/FREE" HeaderStyle-Width="90" />--%>
                                    <asp:TemplateField HeaderText="STATUS">
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" Font-Bold="true" Font-Size="larger"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus"  runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUS").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText="IS_PAID">
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" Font-Bold="true" Font-Size="larger"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblIspaid"  runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "IS_PAID").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cogs' aria-hidden='true'></i></span>">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/UpdateCategory.aspx?q=" + Eval("CATEGORY_ID") %>'
                                                title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="View Questions">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="125px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/admin/UpdateQuestions.aspx?q=" + Eval("CATEGORY_ID") %>'
                                                title="View" Target="_blank" Font-Size="1.4em"><i  class="fa fa-eye" aria-hidden="true"></i></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="View Category">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="125px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "~/natal-astrology/" + Eval("CATEGORY_URL").ToString().Replace(" ", "-").ToLower() + ".html" %>'
                                                title="View" Target="_blank" Font-Size="1.4em"><i  class="fa fa-eye" aria-hidden="true"></i></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Add Price">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink ID="lnkAdd" runat="server" NavigateUrl='<%# "~/admin/AddCategoryPrice.aspx?q=" + Eval("CATEGORY_ID") + "&PayType="+ "INR"  %>'
                                                    title="Edit" Target="_blank" Font-Size="1.4em"><i class="fa fa-plus-circle" aria-hidden="true"></i></asp:HyperLink>
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



