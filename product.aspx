<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%=ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="js/AddToCartProduct.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Start Page Section -->
    <section class="srvc-sec">
        <div class="container">
            <div class="ttbastr">
                <%--    <div class="yntradesc">
                    <div class="row">
                        <div class="col-sm-3 form-group">
                            <img class="dscphto" src="img/sri-yantra.png" />
                        </div>
                        <div class="col-sm-9 form-group">
                            <div class="pgsbttl">Behind the Yantras</div>
                            <div class="pgmnttl">Science and Supernatural Energy</div>
                            <div class="pgdsc">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
					
                                <br>
                                <br>
                                Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
					
                                <br>
                                <br>
                                Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper. Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus.
					
                            </div>
                            <a href="javascript:;" class="kwm-btn-bg">Consult for Yantra</a>
                        </div>
                    </div>
                </div>

                <div class="fltrsec d-flex justify-content-between align-items-center">
                    <div class="lftfltr d-flex">
                        <div class="dropdown">
                            <a class="dprdwn dropdown-toggle" href="javascript:;" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Sort By
						  </a>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                <a class="dropdown-item" href="#">Sort By</a>
                                <a class="dropdown-item" href="#">Sort By</a>
                                <a class="dropdown-item" href="#">Sort By</a>
                            </div>
                        </div>

                        <div class="dropdown">
                            <a class="dprdwn dropdown-toggle" href="javascript:;" id="dropdownMenuButton1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Select Language
						  </a>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton1">
                                <a class="dropdown-item" href="#">Hindi</a>
                                <a class="dropdown-item" href="#">English</a>
                            </div>
                        </div>

                        <div class="dropdown">
                            <a class="dprdwn dropdown-toggle" href="javascript:;" id="dropdownMenuButton2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Ratings
						  </a>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton2">
                                <a class="dropdown-item" href="#">1 Star</a>
                                <a class="dropdown-item" href="#">2 Star</a>
                            </div>
                        </div>

                        <div class="dropdown">
                            <a class="dprdwn dropdown-toggle" href="javascript:;" id="dropdownMenuButton3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Expertise
						  </a>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton3">
                                <a class="dropdown-item" href="#">Expertise</a>
                                <a class="dropdown-item" href="#">Expertise</a>
                            </div>
                        </div>

                    </div>
                    <div class="rgtfltr">
                        <div class="input-group flex-nowrap">
                            <div class="input-group-prepend">
                                <i class="fa fa-search"></i>
                            </div>
                            <input type="text" class="fltersrch" placeholder="Search Astrologer" />
                        </div>
                    </div>
                </div>--%>
                <div class="row" runat="server" id="divProduct">
                </div>
            </div>
        </div>
    </section>
    <!-- End Page Section -->
</asp:Content>

