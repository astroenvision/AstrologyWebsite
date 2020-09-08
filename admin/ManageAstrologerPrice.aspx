<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManageAstrologerPrice.aspx.cs" Inherits="admin_ManageAstrologerPrice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                    <h3>Manage Astrologer Price<small></small></h3>
                </div>
                <div class="title_right" runat="server">
                    <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search" >
                                <div class="input-group" style=" margin-left: 394px;">
                                    <asp:HyperLink ID="btnBack" runat="server" Text="Back" CssClass="btn btn-success" NavigateUrl="~/admin/ManageAstrologer.aspx"  />
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
                                <div class="col-md-3">
                                    <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Astrologer Name</label>
                                    <asp:DropDownList ID="ddlAstrologer" runat="server" CssClass="form-control" Enabled="false">
                                        <asp:ListItem Value="-1">Select Astrologer</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqAstrologer" runat="server" ControlToValidate="ddlAstrologer" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                        ErrorMessage="Select Astrologer" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Payment For</label>
                                    <asp:DropDownList ID="ddlPaymentFor" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentFor_SelectChange" AutoPostBack="true">
                                        <asp:ListItem  Value="">Select Payment For</asp:ListItem>
                                        <asp:ListItem  selected="True" Value="TALK_TO_ASTROLOGER">Talk To Astrologer</asp:ListItem>
                                        <asp:ListItem Value="PERSONAL_MEETING">Personal Meeting</asp:ListItem>
                                        <asp:ListItem Value="CONSULT_AN_ASTROLOGER">Consult An Astrologer</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqPaymentFor" runat="server" ControlToValidate="ddlPaymentFor" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                        ErrorMessage="Select Payment For" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                    <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">No Of Questions</label>
                                    <asp:TextBox runat="server" ID="txtNoOfQuestions" CssClass="form-control"></asp:TextBox>
                                     <asp:RegularExpressionValidator ID="reqNoOfQuestions" CssClass="validator" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtNoOfQuestions" runat="server"
                                    ErrorMessage="Only Numbers allowed" ValidationGroup="save" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                                    </div>
                                <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">No Of Minutes</label>
                                    <asp:TextBox runat="server" ID="txtNoOfMinutes" CssClass="form-control"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="reqExperience" CssClass="validator" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtNoOfMinutes" runat="server"
                                            ErrorMessage="Only Numbers allowed" ValidationGroup="save" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                                </div>
                             </div>
                            <div class="row" style="margin-top: 10px;">
                                   <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">INR Price</label>
                                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPrice" runat="server" ControlToValidate="txtPrice" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regINRPrice" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtPrice" />
                                </div>
                                <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;" >INR Discount</label>
                                    <asp:TextBox ID="txtInrDiscount" runat="server" CssClass="form-control" onkeyup="CalculateDiscount();"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqInrDiscount" runat="server" ControlToValidate="txtInrDiscount" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter INR Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtInrDiscount" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtInrDiscount" />
                                </div>
                                <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">INR Final Price</label>
                                    <asp:TextBox ID="txtFinalPrice" runat="server" CssClass="form-control"  onkeyup="CalculateDiscount();"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFinalPrice" runat="server" ControlToValidate="txtFinalPrice" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Final Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="reqtxtFinalPrice" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtFinalPrice" />
                                </div>
                                <div class="col-md-3">
                                    <label  class="required" style="font-size: 14px; color: #555; font-weight: bold;">USD Price</label>
                                    <asp:TextBox ID="txtPriceUSD" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqPriceUSD" runat="server" ControlToValidate="txtPriceUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter USD Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtPriceUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtPriceUSD" />
                                </div>
                                <div class="col-md-3">
                                    <label class="required"  style="font-size: 14px; color: #555; font-weight: bold;">USD Discount</label>
                                    <asp:TextBox ID="txtDiscountUSD" runat="server" CssClass="form-control" onkeypress="return AcceptDecimal(event)"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqDiscountUSD" runat="server" ControlToValidate="txtDiscountUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter USD Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regtxtDiscountUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtDiscountUSD" />
                                </div>
                                <div class="col-md-3">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">USD Final Price</label>
                                    <asp:TextBox ID="txtFinalPriceUSD" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFinalPriceUSD" runat="server" ControlToValidate="txtFinalPriceUSD" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Final Price" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regFinalPriceUSD" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$" CssClass="validator" Display="Dynamic"
                                 ErrorMessage="Please enter valid integer or decimal number with 2 decimal places." ValidationGroup="save" ControlToValidate="txtFinalPriceUSD" />
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
                                                    <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "ID").ToString()) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                           <asp:BoundField DataField="PAYMENT_FOR" HeaderText="Price For" />
                                            <asp:BoundField DataField="NO_OF_QUESTIONS" HeaderText="NO OF QUESTIONS" />
                                            <asp:BoundField DataField="NO_OF_MINUTES" HeaderText="NO OF MINUTES" />
                                            <asp:BoundField DataField="PRICE_INR" HeaderText="PRICE INR" />
                                            <asp:BoundField DataField="DISCOUNT_INR" HeaderText="DIS. PRICE INR" />
                                            <asp:BoundField DataField="FINAL_PRICE_INR" HeaderText="FINAL PRICE INR" />
                                         <%--   <asp:BoundField DataField="PRICE_USD" HeaderText="PRICE USD" />
                                            <asp:BoundField DataField="DISCOUNT_USD" HeaderText="DIS. PRICE USD" />
                                            <asp:BoundField DataField="FINAL_PRICE_USD" HeaderText="FINAL PRICE USD" />--%>
                                               <asp:TemplateField HeaderText="&nbsp; <span class='fa fa-wrench'></span>">
                                                <HeaderStyle VerticalAlign="Middle"></HeaderStyle>
                                                <ItemStyle VerticalAlign="Middle"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkEdit" runat="server"  title="Edit" CommandName="EditPrice" Style="line-height: 0.65;" CommandArgument='<%# Bind("ID") %>'><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:LinkButton>
                                                                                                            
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

