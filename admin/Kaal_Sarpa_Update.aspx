<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Kaal_Sarpa_Update.aspx.cs" Inherits="admin_Kaal_Sarpa_Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Update Kaal Sarpa Yoga Predictive</h3>
            </div>
            <div class="title_right" runat="server" visible="false">
                <div class="col-md-5 col-sm-5  form-group pull-right top_search">
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
        <div class="row">
            <div class="col-md-12 ">
                <div class="x_panel">
                    <div class="x_title">
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <div class="col-md-6 col-sm-6  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Kaal Sarpa Type</label>
                            <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox runat="server" ID="txtKaalSarpaType" CssClass="form-control" Enabled="false" ></asp:TextBox>
                        </div>
                       <div class="col-md-2 col-sm-6  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Rahu House</label>
                            <asp:TextBox runat="server" ID="txtRahuHouse" CssClass="form-control" Enabled="false"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-sm-6  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Ketu House</label>
                            <asp:TextBox runat="server" ID="txtKetuHouse" CssClass="form-control" Enabled="false"></asp:TextBox>
                        </div>
                              <div class="col-md-2 col-sm-3  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Status</label>
                            <asp:dropdownlist runat="server" ID="ddlStatus" CssClass="form-control">
                                        <asp:ListItem Value="" Text="Select"></asp:ListItem>
                                        <asp:ListItem Value="A" Text="Show"></asp:ListItem>
                                        <asp:ListItem Value="U" Text="Hide"></asp:ListItem>
                            </asp:dropdownlist>
                        </div>
                         <div class="col-md-2 col-sm-3  form-group has-feedback">
                           <label style="font-size: 14px; color: #555; font-weight: bold;">Checked</label>
                                    <asp:DropDownList runat="server" ID="ddlchecked" CssClass="form-control">
                                        <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                        <asp:ListItem Value="T" Text="Checked"></asp:ListItem>
                                        <asp:ListItem Value="F" Text="Unchecked"></asp:ListItem>
                                    </asp:DropDownList>
                        </div>
                         <div class="col-md-2 col-sm-3  form-group has-feedback">
                           <label style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                    <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
                                   <asp:ListItem Value="0">Select Priority</asp:ListItem>
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
                        </div>
                         <div class="col-md-12  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Remedial</label>
                            <FCKeditorV2:FCKeditor ID="fckRemedial" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                         <div class="col-md-12  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive</label>
                            <FCKeditorV2:FCKeditor ID="fckPredictive" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                        <div class="col-md-12  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Expert Opinion</label>
                            <FCKeditorV2:FCKeditor ID="fckExpertOpinion" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                           <div class="col-md-12  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Definition</label>
                            <FCKeditorV2:FCKeditor ID="rteDefinition" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                        <div class="clearfix"></div>
                        <div class="form-group row">
                            <div class="col-md-9 col-sm-9  offset-md-3">
                                <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" OnClick="btnUpdate_click" ValidationGroup="save" />
                                <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

