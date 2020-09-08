<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="UpdateCategoryPrice.aspx.cs" Inherits="admin_UpdateCategoryPrice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script src="../js/UpdateCategoryPrice.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Update Category Price</h3>
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
                            <%--<h2>Form Design <small>different form elements</small></h2>--%>
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
                                     <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Category Name</label>
                                      <asp:label ID="lblCatID" runat="server" Visible="false"></asp:label>
                                    <asp:TextBox runat="server" ID="txtCatName" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">INR USD RATE</label>
                                <asp:TextBox runat="server" ID="txtUsdRate" CssClass="form-control" ></asp:TextBox>
                                </div>
                                   <div class="col-md-12">
                                <div class="btn btn-round btn-info" >INR</div></div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Actual Price</label>
                                   <asp:TextBox runat="server" ID="txtActualPrice" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Discount Price</label>
                                   <asp:TextBox runat="server" ID="txtDiscountPrice" CssClass="form-control"></asp:TextBox>
                                </div>
                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Discount(%)</label>
                                   <asp:TextBox runat="server" ID="txtDicountRate" CssClass="form-control"  onkeyup="CalculateDiscount();"></asp:TextBox>
                                </div>
                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Final Price</label>
                                   <asp:TextBox runat="server" ID="txtFinalPrice" CssClass="form-control"  onkeyup="CalculateDiscount();"></asp:TextBox>
                                </div>
                                 <div class="col-md-12">
                                <div class="btn btn-round btn-info" >USD</div></div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Increase USD Price(%)</label>
                                   <asp:TextBox runat="server" ID="txtIncreaseUsdPriceInPer" CssClass="form-control" onkeyup="CalculateDiscount_USD('UsdPrice');"></asp:TextBox>
                                </div>
                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Increase Price in INR</label>
                                   <asp:TextBox runat="server" ID="txtIncreaseUsdPrice" CssClass="form-control" ></asp:TextBox>
                                </div>
                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Actual Price In US</label>
                                   <asp:TextBox runat="server" ID="TxtActualPriceinUsd" CssClass="form-control" ></asp:TextBox>
                                </div>
                                  <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">USD Discount Price</label>
                                   <asp:TextBox runat="server" ID="txtUSD_DiscountPrice" CssClass="form-control" ></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">USD Discount(%)</label>
                                   <asp:TextBox runat="server" ID="txtUsdDiscount" CssClass="form-control" onkeyup="CalculateDiscount_USD('Discount');"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Final Price USD</label>
                                   <asp:TextBox runat="server" ID="txtUSD_FinalPrice" CssClass="form-control" ></asp:TextBox>
                                </div>
                                <div class="form-group row">
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
        <asp:HiddenField id="hdnActualAmountINR" runat="server"/>
        <asp:HiddenField id="hdntxtDiscountPriceINR" runat="server"/>
        <asp:HiddenField id="hdnActualAmountUSD" runat="server"/>
        <asp:HiddenField id="hdnDiscountPriceUSD" runat="server"/>
        <asp:HiddenField id="hdnFinalPriceUSD" runat="server"/>
</asp:Content>
