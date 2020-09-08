<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="admin_AddUser" EnableEventValidation="false" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <script type="text/javascript" src="<%=ResolveUrl("~/admin/Admin.js") %> "></script>
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
                                     <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Name</label>
                                      <asp:label ID="lblUserID" runat="server" Visible="false"></asp:label>
                                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtName" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter User Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                 <div id="dvLoaderConnnetion" runat="server" style="display: none"></div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Email ID</label>
                                <asp:TextBox runat="server" ID="txtEmailID" CssClass="form-control" ></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmailID" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Email ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Enter Valid Email"
                                        ControlToValidate="txtEmailID" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Login ID</label>
                                <asp:TextBox runat="server" ID="txtLoginID" CssClass="form-control" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLoginID" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Login ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>

                                  <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Password</label>
                                <asp:TextBox runat="server" ID="txtPassword"  CssClass="form-control" ></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Password" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Phone No</label>
                                   <asp:TextBox runat="server" ID="txtPhoneNo" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPhoneNo" CssClass="validator" Display="Dynamic"
                                      ErrorMessage="Enter Phone No" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="regContact" runat="server"  ErrorMessage="Enter Valid No"
                                    ControlToValidate="txtPhoneNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"  CssClass="validator" Display="Dynamic" ValidationGroup="save"/>
                                  </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Address</label>
                                   <asp:TextBox runat="server" ID="txtAddress" CssClass="form-control"></asp:TextBox>
                                </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Country</label>
                                   <asp:dropdownlist runat="server" ID="ddlCountry" CssClass="form-control" Onchange="ddlCountryChange();"></asp:dropdownlist>
                                </div>

                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">State</label>
                                   <asp:dropdownlist runat="server" ID="ddlState" CssClass="form-control" Onchange="ddlStateChange();"></asp:dropdownlist>
                                </div>

                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">City</label>
                                   <asp:dropdownlist runat="server" ID="ddlCity"  CssClass="form-control " Onchange="ddlCityChange();"></asp:dropdownlist>
                                </div>
                            
                              <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Group Name</label>
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="ddlGroup" AutoPostBack="true">
                                            <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                            <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                            <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                  </asp:DropDownList>
                              </div>
                              
                             <div class="form-group row">
                              <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                   <asp:checkbox runat="server" ID="chkStatus" Text="Active"  style="margin-left: 10px;FONT-SIZE: 14px;color: #555; font-weight: bold;"></asp:checkbox>
                                <asp:checkbox runat="server" ID="chkIsSuperAdmin" Text="Is Super Admin"  style="margin-left: 10px;FONT-SIZE: 14px;color: #555; font-weight: bold;"></asp:checkbox>   
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
     <asp:HiddenField  ID="hdnCountry" runat="server"/>
    <asp:HiddenField  ID="hdnCity" runat="server"/>
   <asp:HiddenField  ID="hdnState" runat="server"/>
</asp:Content>

