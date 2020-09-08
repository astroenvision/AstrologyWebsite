<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageProductPrice.aspx.cs" Inherits="admin_ManageProductPrice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/ManageAstrologerPrice.js"></script>
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
                    <h3>Manage Product Price<small></small></h3>
                </div>
                <div class="title_right" runat="server">
                    <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search" >
                                <div class="input-group" style=" margin-left: 394px;">
                                    <asp:HyperLink ID="btnBack" runat="server" Text="Back" CssClass="btn btn-success" NavigateUrl="~/admin/ManageProduct.aspx"  />
                                </div>
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
                            <div class="row">
                                <div class="col-md-2">
                                    <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Product Name</label>
                                    <asp:DropDownList ID="ddlProduct" runat="server" CssClass="form-control" Enabled="false">
                                        <asp:ListItem Value="-1">Select Product</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqProduct" runat="server" ControlToValidate="ddlProduct" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                        ErrorMessage="Select Product" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Product Dimension</label>
                                    <asp:TextBox runat="server" ID="txtProductDimension" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqProductDimension" runat="server" ControlToValidate="txtProductDimension" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product Dimension" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                 <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Product Weight</label>
                                    <asp:TextBox runat="server" ID="txtProductWeight" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqProductWeight" runat="server" ControlToValidate="txtProductWeight" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Product Weight" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">INR Price</label>
                                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPrice" runat="server" ControlToValidate="txtPrice" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regINRPrice" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtPrice" />
                                </div>
                                <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;" >INR Discount</label>
                                    <asp:TextBox ID="txtInrDiscount" runat="server" CssClass="form-control" onkeyup="CalculateDiscount();"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqInrDiscount" runat="server" ControlToValidate="txtInrDiscount" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter INR Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtInrDiscount" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtInrDiscount" />
                                </div>
                            </div>
                            <div class="row" style="margin-top: 10px;">
                                <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">INR Final Price</label>
                                    <asp:TextBox ID="txtFinalPrice" runat="server" CssClass="form-control"  onkeyup="CalculateDiscount();"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFinalPrice" runat="server" ControlToValidate="txtFinalPrice" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Final Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="reqtxtFinalPrice" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtFinalPrice" />
                                </div>
                                <div class="col-md-2">
                                    <label  class="required" style="font-size: 14px; color: #555; font-weight: bold;">USD Price</label>
                                    <asp:TextBox ID="txtPriceUSD" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPriceUSD" runat="server" ControlToValidate="txtPriceUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter USD Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtPriceUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtPriceUSD" />
                                </div>
                                <div class="col-md-2">
                                    <label class="required"  style="font-size: 14px; color: #555; font-weight: bold;">USD Discount</label>
                                    <asp:TextBox ID="txtDiscountUSD" runat="server" CssClass="form-control" onkeypress="return AcceptDecimal(event)"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqDiscountUSD" runat="server" ControlToValidate="txtDiscountUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter USD Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtDiscountUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtDiscountUSD" />
                                </div>
                                <div class="col-md-2">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">USD Final Price</label>
                                    <asp:TextBox ID="txtFinalPriceUSD" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFinalPriceUSD" runat="server" ControlToValidate="txtFinalPriceUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Final Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regFinalPriceUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtFinalPriceUSD" />
                                </div>
                                  <div class="col-md-2">
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

                            </div>
                            <div class="row">
                                <div class="col-sm-4" style="margin-top: 31px;">
                                        <asp:CheckBox runat="server" ID="chkStatus" Text="Active" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                     </div>
                                <div class="col-sm-4" style="margin-top: 25px;">
                                    <asp:Button ID="btnUpdate" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnUpdate_Click" ValidationGroup="save" />
                                    <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="x_content">
                                <div class="table-responsive" style="margin-top: 11px;">
                                    <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowCommand="grdData_RowCommand"
                                        CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                        <AlternatingRowStyle CssClass="even" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="ID" Visible="false">
                                                <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                                <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRODUCT_PRICE_ID").ToString()) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="PRODUCT_DIMENSION" HeaderText="PRODUCT DIMENSION" />
                                            <asp:BoundField DataField="PRODUCT_WEIGHT" HeaderText="PRODUCT WEIGHT" />
                                            <asp:BoundField DataField="PRODUCT_PRICE_INR" HeaderText="PRICE INR" />
                                            <asp:BoundField DataField="DISCOUNT_INR" HeaderText="DIS. PRICE INR" />
                                            <asp:BoundField DataField="TOTAL_AMOUNT_INR" HeaderText="FINAL PRICE INR" />
                                            <asp:BoundField DataField="PRODUCT_PRICE_USD" HeaderText="PRICE USD" />
                                            <asp:BoundField DataField="DISCOUNT_USD" HeaderText="DIS. PRICE USD" />
                                            <asp:BoundField DataField="TOTAL_AMOUNT_USD" HeaderText="FINAL PRICE USD" />
                                              <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY" />
                                               <asp:TemplateField HeaderText="&nbsp; <span class='fa fa-wrench'></span>">
                                                <HeaderStyle VerticalAlign="Middle"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkEdit" runat="server"  title="Edit" CommandName="EditPrice" Style="line-height: 0.65;" CommandArgument='<%# Bind("PRODUCT_PRICE_ID") %>'><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:LinkButton>
                                                                                                            
                                                </ItemTemplate>
                                            </asp:TemplateField>
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
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hdnPrice" runat="server" />
</asp:Content>



