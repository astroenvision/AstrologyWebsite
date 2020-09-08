<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="ApproveArticles.aspx.cs" Inherits="admin_ApproveArticles" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="js/ApproveTestimonials.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div class="fullarticle_catname">Manage Articles</div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="row">
                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlGroup" runat="server" CssClass="form-control form-control-lg-Srch" OnSelectedIndexChanged="ddlGroup_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control form-control-lg-Srch">
                                <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-lg-Srch">
                                <asp:ListItem Selected="True" Value="-1"> Select Status</asp:ListItem>
                                <asp:ListItem Value="A" Text="Approved"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Pending"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-sm-5">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="kwm-btn-lg-sch" OnClick="btnSearch_Click" />
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="kwm-btn-lg-sch" OnClick="btnReset_Click" />
                            <asp:Button ID="btnApprove" runat="server" Text="Approved" CssClass="kwm-btn-lg-sch" OnClick="btnApproved_Click" />
                            <asp:Button ID="btnUnapproved" runat="server" Text="UnApproved" CssClass="kwm-btn-lg-sch" OnClick="btnUnapproved_Click" />
                        </div>
                    </div>

                    <br />

                    <div class="row justify-content-center">

                        <div class="col-sm-12">
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                    CssClass="table dataTable custom-table-bordered th-nowrap">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>

                                        <asp:TemplateField HeaderText="ID" Visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>

                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "NEWS_ID").ToString()) %>'></asp:Label>
                                                <asp:Label ID="lblStatus" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUSVAL").ToString()) %>'></asp:Label>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:BoundField DataField="AUTHOR" HeaderText="AUTHOR NAME" />
                                        <asp:BoundField DataField="CAT_NAME" HeaderText="CAT NAME" />
                                        <asp:BoundField DataField="GROUP_ID" HeaderText="GROUP" />
                                        <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY" />
                                        <asp:TemplateField HeaderText="STATUS">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblStatusVal" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUSVAL").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/EditArticlesRequest.aspx?q=" + Eval("NEWS_ID") %>'
                                                    title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="25px"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkrow" runat="server" onclick="HighlightRow(this)" AutoPostBack="false" />
                                            </ItemTemplate>
                                            <HeaderTemplate>
                                                <input type="checkbox" id="chkallrow" onclick="javascript: CheckAllRows(this)" />
                                            </HeaderTemplate>
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
    </section>
</asp:Content>

