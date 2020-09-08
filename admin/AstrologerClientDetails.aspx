<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AstrologerClientDetails.aspx.cs" Inherits="admin_AstrologerClientDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="admin/Admin.js"></script>
    <style>
        .calicnrgt {
            position: relative;
        }

            .calicnrgt input[type=text] {
                /*background-image: url(../img/calicn.svg);*/
                background-repeat: no-repeat;
                background-size: 18px 18px;
                background-position: right 12px bottom 12px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Update Category</h3>
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
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Name</label>
                                <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                <asp:TextBox runat="server" ID="txtname" CssClass="form-control" Enabled="false" placeholder="Name"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Mobile No</label>
                                <asp:TextBox runat="server" ID="txtcontact" CssClass="form-control" Enabled="false" placeholder="Name"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Gender</label>
                                <asp:DropDownList ID="userddlgender" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                    <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Male"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Female"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Birth Date</label>
                                <div class="calicnrgt">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <div class="col-sm-3">
                                                <asp:DropDownList ID="ddlDate" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-sm-5">
                                                <asp:DropDownList ID="ddlMonth" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-sm-4">
                                                <asp:DropDownList ID="ddlYear" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Birth Time <font color="red">(24 hours format)</font></label>
                                <div class="calicnrgt">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div class="col-sm-6">
                                                <asp:DropDownList ID="hob" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-sm-6">
                                                <asp:DropDownList ID="mob" Enabled="false" runat="server" CssClass="form-control" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Country</label>
                                <asp:TextBox ID="ddlCountry" Enabled="false" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">State</label>
                                <asp:TextBox ID="ddlState" Enabled="false" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>

                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">City</label>
                                <asp:TextBox ID="ddlCity" Enabled="false" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Minutes</label>
                                <asp:TextBox ID="txtNoOfMin" Enabled="false" runat="server" CssClass="form-control">
                                </asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Consultancy Language</label>
                                <asp:DropDownList ID="ddlConsultancyLanguage" runat="server" Enabled="false" CssClass="form-control">
                                    <asp:ListItem Selected="True" Value="-1">Select Consultancy Language</asp:ListItem>
                                    <asp:ListItem Value="English">English</asp:ListItem>
                                    <asp:ListItem Value="Hindi">Hindi</asp:ListItem>
                                    <asp:ListItem Value="Both">Both</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Consultancy Type</label>
                                <asp:DropDownList ID="ddlConsultationType" runat="server" Enabled="false" CssClass="form-control">
                                    <asp:ListItem Selected="True" Value="-1">Select Consultation Type</asp:ListItem>
                                    <asp:ListItem Value="Telephonic">Telephonic</asp:ListItem>
                                    <asp:ListItem Value="Video">Video</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Talk to client</label>
                                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control">
                                    <asp:ListItem Selected="True" Value="">Select Status</asp:ListItem>
                                    <asp:ListItem Value="T">Done</asp:ListItem>
                                    <asp:ListItem Value="F">Not Done</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Question 1</label>
                                <asp:TextBox ID="txtQuestion1" Enabled="false" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Answer 1</label>
                                <asp:TextBox ID="txtAnswer1" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Question 2</label>
                                <asp:TextBox ID="txtQuestion2" Enabled="false" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Answer 2</label>
                                <asp:TextBox ID="txtAnswer2" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Question 3</label>
                                <asp:TextBox ID="txtQuestion3" Enabled="false" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Answer 3</label>
                                <asp:TextBox ID="txtAnswer3" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Question 4</label>
                                <asp:TextBox ID="txtQuestion4" Enabled="false" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Answer 4</label>
                                <asp:TextBox ID="txtAnswer4" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Question 5</label>
                                <asp:TextBox ID="txtQuestion5" Enabled="false" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Answer 5</label>
                                <asp:TextBox ID="txtAnswer5" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="clearfix"></div>
                            <div class="form-group row">
                                <div class="col-md-9 col-sm-9  offset-md-3">

                                    <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnSubmit_Click" />
                                    <asp:HyperLink ID="ViewReport" runat="server" CssClass="btn btn-primary" Target="_blank"><i class="fa fa-eye" aria-hidden="true"></i>View Chart</asp:HyperLink>
                                    <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

