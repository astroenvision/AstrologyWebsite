<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageClientQues.aspx.cs" Inherits="admin_ManageClientQues" %>

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
                            <h3>Manage Client Question<small></small></h3>
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
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "QUESTION_ID").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="NAME" HeaderText="NAME" HeaderStyle-Width="115" />
                                                <asp:BoundField DataField="QUESTION" HeaderText="QUESTION" HeaderStyle-Width="115" />
                                                <asp:BoundField DataField="DATETIMEOFBIRTH" HeaderText="DATE TIME OF BIRTH" HeaderStyle-Width="175" />
                                                 <asp:BoundField DataField="ISANSDONE" HeaderText="IS REPLY" HeaderStyle-Width="175" />
                                                     <asp:TemplateField HeaderText="NO OF COMMENTS">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="63px"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit"  runat="server" NavigateUrl='<%# "~/admin/ManageClientCmnt.aspx?q=" + Eval("QUESTION_ID") %>'
                                                        Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "NOOFCOMMENTS").ToString()) %>'    title="Edit" Target="_blank" Font-Size="1.4em"></asp:HyperLink>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cogs' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="63px"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/UpdateClientQues.aspx?q=" + Eval("QUESTION_ID") %>'
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




