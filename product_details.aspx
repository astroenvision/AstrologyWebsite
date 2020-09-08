<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="product_details.aspx.cs" Inherits="product_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="<%=ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="/astrology/js/AddToCartProduct.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Start Page Section -->	
    <section class="srvc-sec">
	<div class="container">

			<div class="ttbastr">
			
				<div class="yntradesc">
				<div class="row">
					<div class="col-sm-5 form-group">
						<div class="prddtlpic">
							<img class="dscphto" runat="server" id="ImgProduct" src="img/sri-yantra.png" />
						</div>
					</div>
					<div class="col-sm-7 form-group">
						<div class="hrchy">Home<i class="fa fa-angle-right fwdnxt"></i>Product<i class="fa fa-angle-right fwdnxt"></i> Yantras<i class="fa fa-angle-right fwdnxt"></i></div>
						<div class="d-flex align-items-center justify-content-between">
							<div class="prdnmez" id="divProductName" runat="server"></div>
							<div class="ttlrtng"><i class="fa fa-star"></i> 1,36,234 Ratings</div>
						</div>
						<div class="prdcde" id="divProductCode" runat="server">Product ID : 232343</div>
						
						<div class="prctxz d-flex align-items-center justify-content-between">
							<div class="prcintx" id="divPayableAmount" runat="server">
								₹ 1100 <span>(Incl. of all taxes)</span>
							</div>
							<div class="qntyz">
								Quantity 
                                <asp:DropDownList runat="server" id="ddlQuantity"  class="slctqnty">
                                    <asp:ListItem Value="1" Selected="True">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4">4</asp:ListItem>
                                    <asp:ListItem Value="5">5</asp:ListItem>
                                </asp:DropDownList>
							</div>
						</div>
						
						<div class="prodsecsec">
						<div class="smlttlz">Product Features</div>
						<div class="prddscz" id="divPurpose" runat="server">
							<%--This is a very beautiful Shree Mahalakshmi Yantra crafted in thick Pure Silver plate.
<br><br>
Yantra’s are the geometric pattern or design representing or depicting a Mantra of a particular deity. They are very powerful as praying them is equivalent to chanting the specified Mantra. This yantra is associated with Goddess Lakshmi. This yantra personifies wealth, riches, luxuries etc.--%>
						</div>
						<%--<ul class="ullist">
							<li>Lakshmi Paduka</li>
							<li>Kamal Gatte Ki Maala</li>
							<li>Lakshmi Paduka</li>
							<li>Kamal Gatte Ki Maala</li>
						<ul>--%>
						</div>
						
						<div class="prodsecsec">
						<div class="smlttlz">Product Description</div>
						<div class="prddscz" runat="server" id="divDesc">
							<%--This is a very beautiful Shree Mahalakshmi Yantra crafted in thick Pure Silver plate.
<br><br>
Yantra’s are the geometric pattern or design representing or depicting a Mantra of a particular deity. They are very powerful as praying them is equivalent to chanting the specified Mantra. This yantra is associated with Goddess Lakshmi. This yantra personifies wealth, riches, luxuries etc.--%>
						</div>
					<%--	<ul class="ullist">
							<li>Lakshmi Paduka</li>
							<li>Kamal Gatte Ki Maala</li>
							<li>Lakshmi Paduka</li>
							<li>Kamal Gatte Ki Maala</li>
						<ul>--%>
						</div>
						
						<div class="btnsecx">
							<%--<a href="javascript:;" class="kwm-btn-bg"><i class="fa fa-shopping-cart mr-2"></i>Add to Cart</a>--%>
                            <asp:linkbutton runat="server" ID="btnAddToCart" OnClick="btnAddToCart_Click" CssClass="kwm-btn-bg" ><i class="fa fa-shopping-cart mr-2"></i>Add to Cart</asp:linkbutton>
							<a href="javascript:;" class="kwm-btn-bg"><i class="fa fa-share-alt mr-2"></i>Share</a>
						</div>
						
					</div>
					</div>
				</div>
				
				
				<div class="moreprod">
					More Products from this Category
				</div>
				
				<div class="row" runat="server" id="divRelatedProduct">
				</div>
				
			</div>
		 
	</div>
</section>
    <asp:HiddenField id="hdnProductID" runat="server"/>
    <asp:HiddenField id="hdnProductWeight" runat="server"/>
    <asp:HiddenField id="hdnProductDimension" runat="server"/>
    <asp:HiddenField id="hdnINRActualPrice" runat="server"/>
    <asp:HiddenField id="hdnDiscount" runat="server"/>
    <asp:HiddenField id="hdnPayableAmount" runat="server"/>
     <asp:HiddenField id="hdnCatID" runat="server"/>
     <asp:HiddenField id="hdnProductPriceID" runat="server"/>
<!-- End Page Section -->
</asp:Content>

