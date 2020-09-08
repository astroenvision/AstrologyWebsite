<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="astrologerclientlist.aspx.cs" Inherits="admin_astrologerclientlist" %>


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
        .txtdatecss
        {
            width:120px;
            display:initial;
        }
    </style>
    <script src="../javascript/popupcalender.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Astro Client User<small></small></h3>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="row" style="display: block;">
                        <div class="clearfix"></div>
                        <div class="col-md-12 col-sm-12">
                            <div class="x_panel">
                                <div class="x_title">
                                    
                                    <div class="col-md-3" runat="server" id="Name" >
                                        <asp:TextBox ID="txtUserName" runat="server" PlaceHolder="Enter Name" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2" runat="server" id="FromDate" >
                                        <asp:TextBox ID="txtFromDate" runat="server" PlaceHolder="From Date" CssClass="form-control txtdatecss"></asp:TextBox>
                                        <img id="calfrom" runat="server" src='../Image/cal1.png' onclick="popUpCalendar(this, ctl00_ContentPlaceHolder1_txtFromDate,'dd/mm/yyyy',event)"
                                            alt="From Date" />
                                    </div>
                                    <div class="col-md-2" runat="server" id="ToDate" >
                                        <asp:TextBox ID="txtToDate" runat="server" PlaceHolder="To Date" CssClass="form-control txtdatecss"></asp:TextBox>
                                         <img id="calto" runat="server" src='../Image/cal1.png' onclick="popUpCalendar(this, ctl00_ContentPlaceHolder1_txtToDate,'dd/mm/yyyy',event)"
                                            alt="To Date" />
                                    </div>
                                    
                                    <div class="clearfix"></div>
                                </div>
                                 <div class="x_title">
                                    <div class="col-sm-6">
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
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" PageSize="30">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="USER ID" Visible="false">
                                                    <HeaderStyle HorizontalAlign="Left" Width="100px" CssClass="column-title"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "ID").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="NAME" HeaderText="USER NAME" />
                                                <asp:BoundField DataField="GENDER" HeaderText="GENDER" HeaderStyle-Width="70" />
                                               <asp:BoundField DataField="DateTimeOfBirth" HeaderText="DATE TIME OF BIRTH" HeaderStyle-Width="150" />
                                                <asp:BoundField DataField="ADDRESS" HeaderText="ADDRESS" />
                                                <asp:BoundField DataField="REGISTERD_DATE" HeaderText="REGISTERED DATE" HeaderStyle-Width="165" />
                                             <asp:TemplateField HeaderText="<span><i class='fa fa-eye' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkViewReport" runat="server" NavigateUrl='<%# "~/astrologerclientreport.aspx?ClientID=" + Eval("ID") + "&useremailid=" + Eval("EMAILID") + "&flag=vargas"  %>'
                                                            title="View Report" Target="_blank" Font-Size="1.4em"><i  class="fa fa-eye" aria-hidden="true"></i></asp:HyperLink>
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
                         <img src="<%=ResolveUrl("~/Image/loading_icon.gif") %>" alt="loader" title="loader" />
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    <input type="hidden" runat="server" id="hiddendateformat" />
</asp:Content>


