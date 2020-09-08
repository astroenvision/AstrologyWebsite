<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageCat.aspx.cs" Inherits="admin_ManageCat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Manage Category<small></small></h3>
                </div>

                <div class="title_right">
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
                               <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control">
                                   <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                          <div class="col-sm-4">
                                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                    CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" pagesize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>
                                       <asp:TemplateField HeaderText="ID" visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                   <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_ID").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                         <asp:BoundField DataField="CATEGORY_NAME" HeaderText="CATEGORY NAME"  />
                                         <asp:BoundField DataField="CATEGORY_IMAGE" HeaderText="CATEGORY IMAGE"  />
                                         <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY"  />
                                   
                                           <asp:TemplateField  HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="85"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/UpdateCategory.aspx?q=" + Eval("CATEGORY_ID") %>'
                                                   title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="View Questions">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="85"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/admin/UpdateQuestions.aspx?q=" + Eval("CATEGORY_ID") %>'
                                                   title="View" Target="_blank" Font-Size="1.4em"><i  class="fa fa-eye" aria-hidden="true"></i></asp:HyperLink>
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

