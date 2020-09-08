<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddMappingCategory.aspx.cs" Inherits="admin_AddMappingCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="page-title">
                    <div class="title_left">
                        <h3>Mapped Category</h3>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="row" style="display: block;">
                    <div class="clearfix"></div>
                    <div class="col-md-12 col-sm-12">
                        <div class="x_panel">
                            <div class="x_title">
                                <div class="col-md-3">
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCategory" Width="250">
                                        <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" />
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                    <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                </div>
                                <div class="table-responsive">
                                    <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                        CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" PageSize="30">
                                        <AlternatingRowStyle CssClass="even" />
                                        <Columns>
                                            <asp:TemplateField>
                                                <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="20px" CssClass="column-title"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkrow" runat="server" />
                                                </ItemTemplate>
                                                <HeaderTemplate>
                                                    <input type="checkbox" id="chkallrow" />
                                                </HeaderTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CATEGORY ID" Visible="true">
                                                <HeaderStyle HorizontalAlign="Left" Width="50px" CssClass="column-title"></HeaderStyle>
                                                <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCatID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "category_id").ToString()) %>'></asp:Label>
                                                    <asp:Label ID="lblPriority" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRIORITY").ToString()) %>'></asp:Label>
                                                    <asp:Label ID="lblStatus" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUS").ToString()) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CATEGORY NAME">
                                                <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCatName" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CATEGORY_NAME").ToString()) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="PRIORITY">
                                                <HeaderStyle HorizontalAlign="Right" Width="150px"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:DropDownList ID="ddlPriority" runat="server" CssClass="form-control" ValidationGroup="save">
                                                        <asp:ListItem Value="">Select Priority</asp:ListItem>
                                                        <asp:ListItem Value="0">0</asp:ListItem>
                                                        <asp:ListItem Value="1">1</asp:ListItem>
                                                        <asp:ListItem Value="2">2</asp:ListItem>
                                                        <asp:ListItem Value="3">3</asp:ListItem>
                                                        <asp:ListItem Value="4">4</asp:ListItem>
                                                        <asp:ListItem Value="5">5</asp:ListItem>
                                                        <asp:ListItem Value="6">6</asp:ListItem>
                                                        <asp:ListItem Value="7">7</asp:ListItem>
                                                        <asp:ListItem Value="8">8</asp:ListItem>
                                                        <asp:ListItem Value="9">9</asp:ListItem>
                                                        <asp:ListItem Value="10">10</asp:ListItem>
                                                        <asp:ListItem Value="11">11</asp:ListItem>
                                                        <asp:ListItem Value="12">12</asp:ListItem>
                                                        <asp:ListItem Value="13">13</asp:ListItem>
                                                        <asp:ListItem Value="14">14</asp:ListItem>
                                                        <asp:ListItem Value="15">15</asp:ListItem>
                                                        <asp:ListItem Value="16">16</asp:ListItem>
                                                        <asp:ListItem Value="17">17</asp:ListItem>
                                                        <asp:ListItem Value="18">18</asp:ListItem>
                                                        <asp:ListItem Value="19">19</asp:ListItem>
                                                        <asp:ListItem Value="20">20</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <EmptyDataTemplate>
                                            No record to display...
                                        </EmptyDataTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <PagerStyle CssClass="PagerStyle" Wrap="True"
                                            HorizontalAlign="Center" />
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
                        <img src="/astrology/img/Loader.gif" alt="Astro" />
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
    <asp:HiddenField runat="server" ID="hdnFlag" />
</asp:Content>

