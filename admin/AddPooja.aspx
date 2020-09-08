<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddPooja.aspx.cs" Inherits="admin_AddPooja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3 id="h3headertest" runat="server"></h3>
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
                            <div class="form-label-left input_mask">
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja Code</label>
                                    <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtPoojaCode" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPoojaCode" runat="server" ControlToValidate="txtPoojaCode" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Pooja Code" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Category</label>
                                    <asp:Label ID="lblCategory" runat="server" Visible="false"></asp:Label>
                                    <asp:DropDownList runat="server" ID="ddlCategory" CssClass="form-control">
                                        <asp:ListItem Value="-1">Select Category</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqCategory" runat="server" enable="false" ControlToValidate="ddlCategory" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                        ErrorMessage="Select Category Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja Type</label>
                                    <asp:Label ID="lblPoojaType" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtPoojaType" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqProductType" runat="server" ControlToValidate="txtPoojaType" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product Type" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja Name</label>
                                    <asp:Label ID="lblProductName" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtProductName" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqName" runat="server" ControlToValidate="txtProductName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja URL</label>
                                    <asp:Label ID="lblProductURL" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtProductURL" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtProductURL_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqtxtProductURL" runat="server" ControlToValidate="txtProductURL" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product URL" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja Purpose</label>
                                    <asp:Label ID="lblProductPurpose" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtProductPurpose" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqProductPurpose" runat="server" ControlToValidate="txtProductPurpose" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product Purpose" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Pooja Rating</label>
                                    <asp:Label ID="lblPoojaRating" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtPoojaRating" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPoojaRating" runat="server" ControlToValidate="txtPoojaRating" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Pooja Rating" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Title</label>
                                    <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqTitle" runat="server" ControlToValidate="txtTitle" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Title" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                    <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
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
                                    <asp:RequiredFieldValidator ID="reqPriority" runat="server" ControlToValidate="ddlPriority" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Priority" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Small Image</label>
                                    <asp:UpdatePanel ID="upPhotograph" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:FileUpload ID="FileSmallImage" Style="margin-top: 5px;" runat="server" AllowMultiple="true" />
                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:PostBackTrigger ControlID="btnUpdate" />
                                        </Triggers>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Large Image</label>
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:FileUpload ID="fileLargeImage" Style="margin-top: 5px;" runat="server" AllowMultiple="true" />
                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:PostBackTrigger ControlID="btnUpdate" />
                                        </Triggers>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Meta Keywords</label>
                                    <asp:TextBox runat="server" ID="txtMetakeywords" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqMetakeywords" runat="server" ControlToValidate="txtMetakeywords" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Meta keywords" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Meta Description</label>
                                    <asp:TextBox runat="server" ID="txtMetaDesc" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqMetaDesc" runat="server" ControlToValidate="txtMetaDesc" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Meta Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                
                                <div class="col-md-12  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Short Description</label>
                                    <FCKeditorV2:FCKeditor ID="fckShortDesc" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                                </div>
                                <div class="col-md-12  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Full Description</label>
                                    <FCKeditorV2:FCKeditor ID="fckFullDesc" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Category Color</label>
                                    <input type="color" id="txtColor" runat="server" value="#f25e0a" />
                                    <asp:CheckBox runat="server" ID="chkStatus" Text="Active" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnUpdate_Click" />
                                    <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hdnSmallImage" runat="server" />
    <asp:HiddenField ID="hdnLargeImage" runat="server" />
</asp:Content>

