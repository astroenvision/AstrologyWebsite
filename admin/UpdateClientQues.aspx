<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="UpdateClientQues.aspx.cs" Inherits="admin_UpdateClientQues" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%=ResolveUrl("~/admin/Admin.js") %> "></script>
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
                            <a href=<%=ResolveUrl("~/enterbirthdetails.aspx") %> target="_blank" style="font-weight: bold;font-size: 1rem;color:midnightblue;">
                                <i class="fa fa-keyboard-o fa-lg" aria-hidden="true"></i> Click Here For Fill Chart</a>
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
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Client Name</label>
                                    <asp:Label ID="lblQuestionID" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control" Enabled="false"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Birth Date Time</label>
                                    <asp:Label ID="lblBirthDateTime" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtBirthDateTime" CssClass="form-control" Enabled="false"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Birth Place</label>
                                    <asp:Label ID="lblBirthPlace" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtBirthPlace" CssClass="form-control" Enabled="false"></asp:TextBox>
                                </div>
                                <div id="dvLoaderConnnetion" runat="server" style="display: none"></div>
                                <div class="col-md-3 col-sm-3 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Pass</label>
                                    <asp:DropDownList runat="server" ID="ddlPass" CssClass="form-control">
                                        <asp:ListItem Value="0">Yes</asp:ListItem>
                                        <asp:ListItem Value="1">No</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                  <div class="col-md-3 col-sm-3 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Category</label>
                                      <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" Width="250">
                                      <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                         </asp:DropDownList>
                                </div>
                                <div class="col-md-12 col-sm-12 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Question</label>
                                    <asp:TextBox ID="txtQuestion" TextMode="MultiLine" Rows="3" runat="server" class="form-control form-control-lg" placeholder="Write your question"></asp:TextBox>
                                </div>
                                <div class="col-md-12 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Answer</label>
                                    <FCKeditorV2:FCKeditor ID="fckAns" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                        <asp:CheckBox runat="server" ID="chkStatus" Text="Active" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                    </div>
                                    <div class="col-md-9 col-sm-9  offset-md-3">
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
    </div>
    <asp:HiddenField ID="hdnCountry" runat="server" />
    <asp:HiddenField ID="hdnCity" runat="server" />
    <asp:HiddenField ID="hdnState" runat="server" />
</asp:Content>



