<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Ashtakoot_Yoni_Search.aspx.cs" Inherits="admin_Ashtakoot_Yoni_Search" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
                            <h3>Yoni Predictive<small></small></h3>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="row" style="display: block;">
                        <div class="clearfix"></div>
                        <div class="col-md-12 col-sm-12  ">
                            <div class="x_panel">
                                 <div class="x_title">
                                    
                                </div>
                                <div class="x_content">
                                    <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True"  AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" PageSize="50">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="ID">
                                                    <HeaderStyle HorizontalAlign="Left" Width="20px" CssClass="column-title"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "ID").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="YONI_POINT" HeaderText="YONI POINT" HeaderStyle-Width="130" />
                                                   <asp:TemplateField HeaderText="DEFINITION" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <FCKeditorV2:FCKeditor ID="rtepredictive" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="350px"
                                                            Height="200px" Value='<%# Bind("DEFINITION")%>'>
                                                        </FCKeditorV2:FCKeditor>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:BoundField DataField="ISMATCH" HeaderText="IS MATCH" HeaderStyle-Width="115" />
                                                 <asp:BoundField DataField="ISMATCH_EXCEPTION" HeaderText="IS MATCH EXCEPTION" HeaderStyle-Width="175" />
                                                 <asp:BoundField DataField="YONI_POINT_EXCEPTION" HeaderText="YONI POINT EXCEPTION" HeaderStyle-Width="200" />
                                                 <asp:TemplateField HeaderText="STATUS" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Center" Width="70px"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblpredictivestatus" runat="server" ForeColor="Red" Font-Bold="true" Text='<%# Bind("PREDICTIVE_STATUS")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cogs' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="63px"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/Ashtakoot_Yoni_Update.aspx?q=" + Eval("ID") %>'
                                                            title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
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

