<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageGallery.aspx.cs" Inherits="admin_ManageGallery" %>

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
           <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Manage Gallery</h3>
                        </div>
                        <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                                <div class="input-group">
                                    <asp:HyperLink ID="btnGallery" runat="server" Text="Upload Gallery Image" CssClass="btn btn-success" NavigateUrl="~/admin/AddGallery.aspx" Target="_blank" />
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
                                              <asp:DropDownList runat="server" CssClass="form-control" ID="ddlGroup" AutoPostBack="true" OnSelectedIndexChanged="ddlGroup_SelectChange">
                                        <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                        <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                          <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                         </asp:DropDownList>
                                            </div>
                                     <div class="col-md-2">
                                          <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCatName" AutoPostBack="true" OnSelectedIndexChanged="ddlCatName_SelectChange">
                                        <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                    </asp:DropDownList>
                                         </div>
                                    <div class="col-md-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlAlbum" AutoPostBack="true">
                                        <asp:ListItem Value="-1" Text="Select Album"></asp:ListItem>
                                    </asp:DropDownList>
                                        </div>
                                       <div class="col-sm-2">
                                      <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnsearch_Click" />
                                    <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_content">
                                    <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                        <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowDataBound="grdData_RowDataBound"
                                            CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50"
                                            HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" OnRowCancelingEdit="grdData_RowCancelingEdit" OnRowDeleting="grdData_RowDeleting"
                                            OnRowEditing="grdData_RowEditing" OnRowUpdating="grdData_RowUpdating" EmptyDataText="No records has been added.">
                                            <AlternatingRowStyle CssClass="even" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Gallery ID">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("GALL_ID")%>'></asp:Label>
                                                        <asp:Label ID="lblPriorityVal" Visible="false" runat="server" Text='<%# Bind("PRIORITY")%>'></asp:Label>
                                                        <asp:Label ID="lblAlbumImage" runat="server" Visible="false" Text='<%# Bind("LARGE_IMG")%>'></asp:Label>
                                                         <asp:Label ID="lblDescriptionValue" runat="server"  Visible="false" Text='<%# Bind("DESCRIPTION")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="ALBUM NAME">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblALBUMNAME" runat="server" Text='<%# Bind("HEADLINE")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                  <asp:TemplateField HeaderText="DESCRIPTION">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDESCRIPTION" runat="server" Text='<%# Bind("DESCRIPTION")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" ></asp:TextBox>
                                                 </EditItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField HeaderText="PRIORITY">
                                                    <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblPRIORITY" runat="server" Text='<%# Bind("PRIORITY")%>'></asp:Label>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control" SelectedValue='<%# Eval("PRIORITY") %>'>
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
                                                            <asp:ListItem Value="21">21</asp:ListItem>
                                                            <asp:ListItem Value="22">22</asp:ListItem>
                                                            <asp:ListItem Value="23">23</asp:ListItem>
                                                            <asp:ListItem Value="24">24</asp:ListItem>
                                                            <asp:ListItem Value="25">25</asp:ListItem>
                                                            <asp:ListItem Value="26">26</asp:ListItem>
                                                            <asp:ListItem Value="27">27</asp:ListItem>
                                                            <asp:ListItem Value="28">28</asp:ListItem>
                                                            <asp:ListItem Value="29">29</asp:ListItem>
                                                            <asp:ListItem Value="30">30</asp:ListItem>
                                                            <asp:ListItem Value="31">31</asp:ListItem>
                                                            <asp:ListItem Value="32">32</asp:ListItem>
                                                            <asp:ListItem Value="33">33</asp:ListItem>
                                                            <asp:ListItem Value="34">34</asp:ListItem>
                                                            <asp:ListItem Value="35">35</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="IMAGE">
                                                    <HeaderStyle HorizontalAlign="Left" Width="160px"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                   
                                                        <asp:Image ID="imgAlbumURL" runat="server" Height="70px" Width="80px" />
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                           <asp:FileUpload ID="FileGallery" Style="margin-top: 5px;" runat="server" />
                                                    </EditItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="COVER IMAGE">
                                            <ItemTemplate>
                                                <asp:Label ID="lblCoverImage" runat="server" Visible="false"  Text='<%# Bind("ISCOVERIMAGE")%>' ></asp:Label>
                                               <asp:CheckBox  ID="chkCoverImage" runat="server" Enabled="false" />
                                            </ItemTemplate>
                                                <EditItemTemplate>
                                                      <asp:CheckBox  ID="chKimage"  runat="server" Checked='<%# (Convert.ToString(Eval("ISCOVERIMAGE")).Equals("1") ? true : false) %>'/>  

                                                  
                                                     
                                                   
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                          <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"
                                                    ItemStyle-Width="120" HeaderText="Action" />
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
              <%--  </ContentTemplate>
                <Triggers>--%>
                    <%-- <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />--%>
              <%--  </Triggers>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <div class="loading">
                        <div class="loader-custom-inner">
                            <img src="/astrology/img/Loader.gif" alt="Astro" />
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>--%>
        </div>
    </div>
</asp:Content>

