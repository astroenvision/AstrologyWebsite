<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddProductCategory.aspx.cs" Inherits="admin_AddProductCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
           .required {
            position: relative;
        }

            .required:after {
                position: absolute;
                content: '*';
                color: #ff0000;
                right: -10px;
            }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3 id="h3headertest" runat="server"></h3>
                </div>
                <div class="title_right" runat="server" visible="false" >
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
                          
                            <div class="form-label-left input_mask">
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                     <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Category Name</label>
                                      <asp:label ID="lblID" runat="server" Visible="false"></asp:label>
                                    <asp:TextBox runat="server" ID="txtCategoryName" CssClass="form-control"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtCategoryName" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Category Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Title</label>
                                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control" ></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="reqTitle" runat="server" ControlToValidate="txtTitle" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Title" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Priority</label>
                                <asp:dropdownlist runat="server" ID="ddlPriority" CssClass="form-control" >
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
                                    
                                </asp:dropdownlist>
                                 <asp:RequiredFieldValidator ID="reqPriority" runat="server" ControlToValidate="ddlPriority" CssClass="validator" Display="Dynamic"
                                   ErrorMessage="Select Priority" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>

                                  <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Meta Keywords</label>
                                <asp:TextBox runat="server" ID="txtMetakeywords"  CssClass="form-control" ></asp:TextBox>
                               <asp:RequiredFieldValidator ID="reqMetakeywords" runat="server" ControlToValidate="txtMetakeywords" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Meta keywords" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Meta Description</label>
                                   <asp:TextBox runat="server" ID="txtMetaDesc" CssClass="form-control"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="reqMetaDesc" runat="server" ControlToValidate="txtMetaDesc" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Meta Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Short Desc</label>
                                   <asp:TextBox runat="server" ID="txtShortDesc" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqShortDesc" runat="server" ControlToValidate="txtShortDesc" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Short Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label class="required" style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Full Desc</label>
                                   <asp:TextBox runat="server" ID="txtFullDesc" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFullDesc" runat="server" ControlToValidate="txtFullDesc" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Full Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                            
                                 <div class="form-group row">
                              <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                   <asp:checkbox runat="server" ID="chkStatus" Text="Active"  style="margin-left: 10px;FONT-SIZE: 14px;color: #555; font-weight: bold;"></asp:checkbox>
                                 </div>
                                    <div class="col-md-9 col-sm-9  offset-md-3">
                                        <asp:linkbutton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save"  OnClick="btnUpdate_Click" />
                                        <asp:linkbutton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                     </div>
                                </div>
                            </div>
                                               
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

