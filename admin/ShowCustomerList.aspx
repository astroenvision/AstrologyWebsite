<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ShowCustomerList.aspx.cs" Inherits="admin_ShowCustomerList" %>

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
        <div class="">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Manage Customer</h3>
                        </div>
                        <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                            </div>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="row" style="display: block;">
                        <div class="clearfix"></div>
                        <div class="col-md-12 col-sm-12  ">
                            <div class="x_panel">
                                <div class="x_title">
                                    <div class="col-md-3">
                                        <asp:DropDownList ID="ddlAstrologer" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="-1" Text="Select Astrologer"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3">
                                        <asp:DropDownList ID="ddlConsultType" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="" Selected="True" Text="Select Consult Type"></asp:ListItem>
                                            <asp:ListItem Value="8">Talk To Astrologer</asp:ListItem>
                                            <asp:ListItem Value="13">Consult An Astrologer</asp:ListItem>
                                            <asp:ListItem Value="12">Personal Meeting</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn btn-primary" />
                                        <asp:Button ID="btnReset" runat="server" Visible="false" Text="Reset" OnClick="btnReset_Click" CssClass="btn btn-secondary" />
                                    </div>
                                    <div class="clearfix"></div>
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
                                        HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                        <AlternatingRowStyle CssClass="even" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="USER ID" Visible="true">
                                                <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUSERID" runat="server" Text='<%# Bind("CLIENT_ID")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="USER NAME">
                                                <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblNAME" runat="server" Text='<%# Bind("CLIENT_NAME")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CUSTOMER NO">
                                                <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCUSTOMERNO" runat="server" Text='<%# Bind("CONTACT_NO")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="DATE OF BIRTH" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDOB" runat="server" Text='<%# Bind("DOB")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="MAP FOR" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDOB" runat="server" Text='<%# Bind("FLAG")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CREATED DATE" Visible="true">
                                                <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCREATED_DATE" runat="server" Text='<%# Bind("CREATED_DATE")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/AstrologerClientDetails.aspx?q=" + Eval("CLIENT_ID") + "&Type="+ "Admin"  %>' title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
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
                    <%-- <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />--%>
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
    </div>
</asp:Content>

