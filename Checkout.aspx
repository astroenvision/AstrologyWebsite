<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .rad {
            display: block;
            line-height: 28px;
            position: relative;
            padding-left: 35px;
            margin-bottom: 12px;
            cursor: pointer;
            font-size: 14px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

            /* Hide the browser's default checkbox */
            .rad input {
                position: absolute;
                opacity: 0;
                cursor: pointer;
                height: 0;
                width: 0;
            }

        /* Create a custom checkbox */
        .checkmark {
            position: absolute;
            top: 8px;
            left: 0;
            height: 22px;
            width: 20px;
            border-radius: 10px;
            background-color: #eee;
        }

        /* On mouse-over, add a grey background color */
        .rad:hover input ~ .checkmark {
            background-color: #ccc;
        }

        /* When the checkbox is checked, add a blue background */
        .rad input:checked ~ .checkmark {
            background-color: #2196F3;
        }

        /* Create the checkmark/indicator (hidden when not checked) */
        .checkmark:after {
            content: "";
            position: absolute;
            display: none;
        }

        /* Show the checkmark when checked */
        .rad input:checked ~ .checkmark:after {
            display: block;
        }

        /* Style the checkmark/indicator */
        .rad .checkmark:after {
            left: 9px;
            top: 5px;
            width: 5px;
            height: 10px;
            border: solid white;
            border-width: 0 3px 3px 0;
            -webkit-transform: rotate(45deg);
            -ms-transform: rotate(45deg);
            transform: rotate(45deg);
        }
    </style>
    <script src="<%=ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="<%=ResolveUrl("js/Checkout.js") %>"></script>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <header class="section-header">
                <h3>Shipping Information</h3>
                  <p id="pTotalItem" runat="server">
                </p>
            </header>
             <div class="row" style="background-color: white">
                <div class="col-xl-8 col-sm-12 form-group" style="margin-top: 49px" id="Productlist" runat="server">
                    <div class="table-responsive">
                        <table class="table table-bordered crttbl">
                            <%--<thead>
                                <tr>
                                    <th class="text-left">Categories</th>
                                    <th class="text-right">Actual Amount</th>
                                    <th class="text-right">Discount</th>
                                    <th class="text-right">You Save</th>
                                    <th class="text-right">Payable Amount</th>
                                    <th class="text-left">Remove</th>
                                </tr>
                            </thead>--%>
                            <thead id="divColoumNameForCat" runat="server">
                              
                            </thead>
                            <tbody id="divData" runat="server">
                            </tbody>
                        </table>
                    </div>
                </div>

                <div class="col-xl-8 col-sm-12 form-group" id="DivAddNewAddress" runat="server" style="margin-top: 17px; display:none" >
                    <div class="row">
                        <div class="col-sm-6 form-group">
                            <label class="required">Name</label>
                            <asp:TextBox ID="txtname" runat="server" PlaceHolder="Name" CssClass="form-control form-control-lg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqName" runat="server"
                                ControlToValidate="txtname" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regName" runat="server" ControlToValidate="txtname"
                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enetr Only Alphabets" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Mobile No</label>
                            <asp:TextBox ID="txtMobileNo" runat="server" PlaceHolder="Mobile No" CssClass="form-control form-control-lg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtMobileNo" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Mobile No" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regContact" runat="server" ErrorMessage="Enter Valid Mobile No"
                                ControlToValidate="txtMobileNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="">Alternate Mobile No</label>
                            <asp:TextBox ID="txtAlternateNo" runat="server" PlaceHolder="Alternate Mobile No" CssClass="form-control form-control-lg"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="regAlternateNo" runat="server" ErrorMessage="Enter Valid Mobile No"
                                ControlToValidate="txtAlternateNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" SetFocusOnError="True" />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Landmark</label>
                            <asp:TextBox ID="txtLandmark" runat="server" PlaceHolder="Landmark" CssClass="form-control form-control-lg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqLandmark" runat="server"
                                ControlToValidate="txtLandmark" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Landmark" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Address</label>
                            <asp:TextBox ID="txtAddress" runat="server" PlaceHolder="Address" CssClass="form-control form-control-lg js-example-placeholder-single"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqAddress" runat="server"
                                ControlToValidate="txtAddress" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Address" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Country</label>
                            <asp:DropDownList ID="ddlCountry" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" Onchange="ddlCountryChange();">
                                <asp:ListItem Value="-1" Selected="True">Select Country</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqCountry" runat="server"
                                ControlToValidate="ddlcountry" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                ErrorMessage="Select Country" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">State</label>
                            <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" Onchange="ddlStateChange();">
                                <asp:ListItem Value="-1" Selected="True">Select State</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqState" runat="server"
                                ControlToValidate="ddlstate" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                ErrorMessage="Select State" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">City</label>
                            <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control form-control-lg" Onchange="ddlCityChange();">
                                <asp:ListItem Value="-1" Selected="True">Select City</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqCity" runat="server"
                                ControlToValidate="ddlcity" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                ErrorMessage="Select City" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Pin Code</label>
                            <asp:TextBox ID="txtpincode" runat="server" PlaceHolder="Pin Code" CssClass="form-control form-control-lg"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="reqpincode" runat="server"
                                ControlToValidate="txtpincode" CssClass="validator" Display="Dynamic" 
                                ErrorMessage="Select Pin Code" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label class="required">Address Type</label>
                            <asp:RadioButtonList runat="server" ID="rdAddressType" RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
                                <asp:ListItem Value="H" Selected="True">Home</asp:ListItem>
                                <asp:ListItem Value="O">Office</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                            <div class="col-sm-12 form-group">
                          <asp:LinkButton ID="LinkButton2" style="float: right;color: blue;" OnClick="btnShowOldAddress_Click" runat="server">Show Previous Address</asp:LinkButton>
                    </div>   

                    </div>
                </div>


                <div class="col-xl-8 col-sm-12 form-group" style="margin-top: 34px;display:none" runat="server" id="divAllAddress">
                    <div runat="server" id="bindAddress"></div>
                     <asp:LinkButton ID="LinkButton1" style="float: right;color: blue;" OnClick="btnAddNewAddress_Click" runat="server">Add New Address</asp:LinkButton>
                </div>
                <div class="col-xl-4 col-sm-12 form-group" id="categories_price" style="margin-top: 48px;" runat="server">
                    <table class="table table-bordered crttbl">
                        <tbody>
                            <tr>
                                <td class="text-left"><strong>Total Amount:</strong></td>
                                <td class="text-left">
                                    <div id="divTotalAmount" runat="server"></div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left"><strong>Additional Discount(%):</strong></td>
                                <td class="text-left">
                                    <div id="divDiscountPrice" runat="server"></div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left"><strong>You Save:</strong></td>
                                <td class="text-left">
                                    <div id="divYouSave" runat="server"></div>
                                </td>
                            </tr>
                            <tr>
                                <th class="text-left"><strong>Total Payable Amount:</strong></th>
                                <th class="text-left">
                                    <div id="divTotalPayableAmount" runat="server"></div>
                                </th>
                            </tr>
                        </tbody>
                    </table>
                    <div class="text-sm-right">
                        <asp:LinkButton ID="lnkContinue" OnClick="btnContinue_Click" style="display:none" ValidationGroup="save" runat="server" CssClass="vwall-btn">Add Address And Continue</asp:LinkButton>
                          <asp:LinkButton ID="lnkContinueWithAddress" OnClick="btnContinueWithOld_Click" ValidationGroup="save" runat="server" style="display:none" CssClass="vwall-btn">Select Address And Continue</asp:LinkButton>
                        <asp:LinkButton ID="lnkNext" runat="server" CssClass="vwall-btn"  OnClick="lnkNext_Click">Next</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </section>
      <input type="hidden" runat="server" id="TotalAmounts" />
      <input type="hidden" runat="server" id="hdnAddressID" />
      <input type="hidden" runat="server" id="hdnFlag" />
            <asp:HiddenField ID="hdnCountry" runat="server" />
            <asp:HiddenField ID="hdnCity" runat="server" />
            <asp:HiddenField ID="hdnState" runat="server" />
</asp:Content>

