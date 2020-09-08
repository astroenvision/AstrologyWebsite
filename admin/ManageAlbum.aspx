<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageAlbum.aspx.cs" Inherits="admin_ManageAlbum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="right_col" role="main">
        <div class="">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Manage Album</h3>
                        </div>
                        <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                                <div class="input-group">
                                    <asp:HyperLink ID="btnAddAlbum" runat="server" Text="Add Album" CssClass="btn btn-success" NavigateUrl="~/admin/AddAlbum.aspx" Target="_blank" />
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
                                    <%--   <div class="col-sm-2" style="margin-top: 16px;">
                                   <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnsearch_Click" />
                                    <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                </div>--%>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_content">
                                    <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowDataBound="grdData_RowDataBound"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50"
                                            HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Album ID">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("ALBUM_ID")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="ALBUM NAME">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNAME" runat="server" Text='<%# Bind("ALBUM_NAME")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="STATUS">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblSTATUS" runat="server" Text='<%# Bind("APPROVED")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                   <asp:TemplateField HeaderText="PRIORITY">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblPRIORITY" runat="server" Text='<%# Bind("PRIORITY")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                  <asp:TemplateField HeaderText="CREATED DATE">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCRTD_DATE" runat="server" Text='<%# Bind("CRTD_DATE")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="TOTAL IMAGES" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTOTALIMAGE" runat="server" Text='<%# Bind("TOTALPHOTO")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="COVER IMAGE">
                                                    <HeaderStyle HorizontalAlign="Left" Width="160px"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label id="lblAlbumImage" runat="server" Visible="false" Text='<%# Bind("THUMB_IMG")%>'></asp:Label>
                                                      <asp:Image ID="imgAlbumURL" runat="server"  ImageUrl="../Image/avatar.png" Height="70px" Width="80px" />
                                                     </ItemTemplate>
                                                 </asp:TemplateField>
                                                <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/AddAlbum.aspx?q=" + Eval("ALBUM_ID")  %>'
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

