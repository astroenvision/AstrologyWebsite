 <%@ Page Title="Checkout Cart | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="CheckOutCart.aspx.cs" Inherits="CheckOutCart"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%=ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="<%=ResolveUrl("js/AddToCartProduct.js") %>"></script>
    <style>
        #rzp-button1 {
            border: 0;
            border-radius: 3px;
            -webkit-transition: .2s;
            transition: .2s;
            box-shadow: 0 3px 13px rgba(0,0,0,0.09), 0 1px 5px 0 rgba(0,0,0,0.14);
            -webkit-user-select: none;
            -ms-user-select: none;
            user-select: none;
            line-height: 48px;
            height: 40px;
            padding: 0 24px;
            font-size: 14px;
            text-transform: uppercase;
            letter-spacing: .5px;
            font-weight: bold;
            background: #528ff0;
            color: #fff;
            cursor: pointer;
        }

            #rzp-button1:hover {
                -webkit-transform: translateY(-2px) scale(1.01);
                -ms-transform: translateY(-2px) scale(1.01);
                transform: translateY(-2px) scale(1.01);
                box-shadow: 0 5px 16px 1px rgba(0,0,0,0.13), 0 1px 4px 0 rgba(0,0,0,0.09);
            }

            #rzp-button1:active {
                -webkit-transform: perspective(40px) rotateX(1deg);
                transform: perspective(40px) rotateX(1deg);
            }

            #rzp-button1 p {
                margin: 0;
                padding: 0;
                line-height: 40px;
                font-size: 14px;
            }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <header class="section-header">
                <h3>Reports</h3>
                <%--<p>
                    You have added total categories :
                    <span id="spnTotalItem" runat="server"></span>
                </p>--%>
                <p id="pTotalItem" runat="server">
                </p>
            </header>
            <div class="row">
                <div class="col-xl-8 col-sm-12 form-group" id="categories_list" runat="server">
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
                <div class="col-xl-4 col-sm-12 form-group" id="categories_price" runat="server">
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
                        <asp:LinkButton ID="lnkAddMore" runat="server" CssClass="vwall-btn" OnClick="lnkAddMore_Click">Add More Reports</asp:LinkButton>
                        <asp:LinkButton ID="lnkNext" runat="server" CssClass="vwall-btn" OnClick="lnkNext_Click">Next</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <input type="hidden" runat="server" id="TotalAmounts" />
    <input type="hidden" runat="server" id="CurrencyType" />
    <input type="hidden" runat="server" id="hdncartid" />
    <input type="hidden" runat="server" id="hdncountrycode" />
    <input type="hidden" runat="server" id="hdngroupid" />
    <input type="hidden" runat="server" id="hdnAmountid" />
</asp:Content>

