<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="searchpredictive.aspx.cs" Inherits="admin_searchpredictive" %>

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
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Search Predictive</h3>
                        </div>
                        <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                                <div class="input-group">
                                    <asp:HyperLink ID="btnPredictive" runat="server" Text="Add Predictive" CssClass="btn btn-success" NavigateUrl="~/admin/managenatalpredictive.aspx" Target="_blank" />
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
                                        <asp:DropDownList runat="server" ID="ddlstatus" CssClass="form-control">
                                            <asp:ListItem Value="" Text="Select Status"></asp:ListItem>
                                            <asp:ListItem Value="A" Text="Show"></asp:ListItem>
                                            <asp:ListItem Value="U" Text="Hide"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:DropDownList runat="server" ID="ddlchecked" CssClass="form-control">
                                            <asp:ListItem Value="" Text="Select checked"></asp:ListItem>
                                            <asp:ListItem Value="T" Text="Checked"></asp:ListItem>
                                            <asp:ListItem Value="F" Text="Unchecked"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtpredictive" placeholder="Predictive">  </asp:TextBox>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_title">
                                    <div class="col-sm-6" style="margin-top: 10px;">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_content">
                                    <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                            OnPageIndexChanging="grdData_PageIndexChanging" OnRowCommand="grdData_RowCommand"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50"
                                            HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" OnRowDataBound="grdData_RowDataBound">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="ID" Visible="true">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left" Width="70px"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("PREDICTIVE_ID")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="CATEGORY_NAME">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCategoryName" runat="server" Text='<%# Bind("CATEGORY_NAME")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="LOGIC">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblLOGIC" runat="server" Text='<%# Bind("LOGIC_DESC")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="STATUS">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left" Width="70px"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hdnpredictivestatus" runat="server" Value='<%# Bind("PREDICTIVE_STATUS")%>' />
                                                        <asp:Label ID="lblpredictivestatus" runat="server" Font-Bold="true" Text='<%# Bind("PREDICTIVE_STATUS")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="PREDICTIVE" Visible="true">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <%--<FCKeditorV2:FCKeditor ID="rtepredictive" ToolbarSet="Standard" runat="server" BasePath="~/fckeditor/" Width="350px" Height="200px" Value='<%# Bind("PREDICTIVE")%>'>
                                                        </FCKeditorV2:FCKeditor>--%>
                                                        <asp:Label ID="lblpredictive" runat="server" Text='<%# Bind("PREDICTIVE")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Checked" Visible="false">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Center" Width="80px"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hdnchecked" runat="server" Value='<%# Bind("CHECKED")%>' />
                                                        <asp:Label ID="lblchecked" runat="server" Font-Bold="true" Text='<%# Bind("CHECKED")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Status" Visible="false">
                                                    <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Center" Width="80px"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hdnstatus" runat="server" Value='<%# Bind("STATUS")%>' />
                                                        <asp:Label ID="lblstatus" runat="server" Text='<%# Bind("STATUS")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/managenatalpredictive.aspx?q=" + Eval("PREDICTIVE_ID")  %>'
                                                            title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="<span><i class='fa fa-trash' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" CommandArgument='<%# Bind("PREDICTIVE_ID") %>' OnClientClick="return confirm('Are you sure you want to delete this record?');"
                                                            title="Delete Report" Font-Size="1.4em"><i  class="fa fa-trash" aria-hidden="true"></i></asp:LinkButton>
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


