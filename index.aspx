<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta content="" name="keywords" />
    <meta content="" name="description" />

    <!-- Favicons -->
    <link href="img/favicon.ico" rel="icon" />

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet" />

    <!-- Bootstrap CSS File -->
    <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Libraries CSS Files -->
    <link href="lib/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="lib/animate/animate.min.css" rel="stylesheet" />
    <link href="lib/ionicons/css/ionicons.min.css" rel="stylesheet" />
    <link href="lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet" />
    <link href="lib/lightbox/css/lightbox.min.css" rel="stylesheet" />

    <!-- Main Stylesheet File -->
    <link href="css/style.css" rel="stylesheet" />

    <!-- =======================================================
    Theme Name: BizPage
    Theme URL: https://bootstrapmade.com/bizpage-bootstrap-business-template/
    Author: BootstrapMade.com
    License: https://bootstrapmade.com/license/
  ======================================================= -->

    <script type="text/javascript">  
        function AddToCart(CatID,GroupID) {
            PageMethods.AddToCart(CatID,GroupID, onSucess, onError);
            function onSucess(result) {
                if (result == "0") {
                    window.location = "signin.aspx";
                  }
               else {
                    document.getElementById('astroheader1_lblMessage').innerHTML = result;
               }
            }  
  
            function onError(result) {  
                alert('Something wrong.');  
            }  
        }  
   </script>  

    <script type="text/javascript">  
        function Logout() {
            PageMethods.Logout(onSucess, onError);
           function onSucess(result) {  
               if (result == "1") {
                   window.location = "index.html";
               }
            }  
            function onError(result) {  
                alert('Something wrong.');  
            }  
        }  
   </script>  

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>  
        <%--Header--%>
        <uc1:astroheader ID="astroheader1" runat="server" />
        <%--Header--%>

        <section class="bannerarea">
            <div class="container">
                <div class="logo-section text-center">
                    <img src="<%=ResolveUrl("~/Image/large_logo.png") %>" alt="Astro Envision" title="Astro Envision" />
                </div>

                <div class="bnrsec" style="display:none;">
                    <div class="row">
                        <div class="col-sm-2"></div>
                        <div class="col-sm-7 form-group">
                            <div class="bnr-sb-title">Learn Astrology</div>
                            <div class="bnrp-title">
                                Vedic Astrology<br />
                                Accuracy<span> & </span>Expertise
                            </div>
                            <a href="javascript:;" class="kwm-btn-bg" data-toggle="modal" data-target="#readMore">Know More</a>
                        </div>

                        <div class="col-sm-3 form-group">
                            <img src="img/bnr-icon.jpg" />
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <main id="main">

                <!--==========================
                  Portfolio Section
                ============================-->
            <section class="srvc-sec">
                <div class="container">
                    <div class="srvc-sec-innr">

                        <header class="section-header wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                            <h3>Astro Reports on Birth Chart Promise ?</h3>
                        </header>

                        <ul class="nav nav-pills justify-content-center" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" data-toggle="pill" href="#natal">Natal</a>
                            </li>
                            <li class="nav-item" style="display:none">
                                <a class="nav-link" data-toggle="pill" href="#prashna">Prashna (Horary)</a>
                            </li>
                        </ul>

                        <!-- Tab panes -->
                        <div class="tab-content">
                            <div id="natal" class="tab-pane active">
                                <br />
                                <div class="row service-cols" id="natalcategorydiv" runat="server">

                                   <%-- <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="javascript:;" class="kwm-btn" data-toggle="modal" data-target="#readMore1">Know More</a>
                                                <a href="javascript:;" class="kwm-btn"><i class="fa fa-shopping-cart mr-1"></i>Add to Cart</a>
                                            </div>
                                        </div>

                                        <div class="modal fade" id="readMore1">
                                        <div class="modal-dialog modal-lg modal-dialog-centered">
                                            <div class="modal-content">

                                                <!-- Modal Header -->
                                                <div class="modal-header">
                                                    <h4 class="modal-title">Personality Traits</h4>
                                                    <button type="button" class="close" data-dismiss="modal"><i class="ion-ios-close-outline text-bold"></i></button>
                                                </div>

                                                <!-- Modal body -->
                                                <div class="modal-body">
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>

                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>

                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                </div>
                                            </div>
                                        </div>
                                        </div>


                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn" data-toggle="modal" data-target="#readMore2">Know More</a>
                                            </div>
                                        </div>

                                         <div class="modal fade" id="readMore2">
                                        <div class="modal-dialog modal-lg modal-dialog-centered">
                                            <div class="modal-content">

                                                <!-- Modal Header -->
                                                <div class="modal-header">
                                                    <h4 class="modal-title">Political career</h4>
                                                    <button type="button" class="close" data-dismiss="modal"><i class="ion-ios-close-outline text-bold"></i></button>
                                                </div>

                                                <!-- Modal body -->
                                                <div class="modal-body">
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>

                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>

                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                </div>


                                            </div>
                                        </div>
                                    </div>


                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>--%>

                                </div>
                            </div>
                            <div id="prashna" class="container tab-pane fade" style="display:none">
                                <br>
                                <div class="row service-cols">

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>

                        <div class="vwall-sec text-center" style="display:none">
                            <div class="vwall">We have <span>11 more interesting categories</span> for you...</div>
                            <a class="vwall-btn" href="#">Click to View More...</a>
                        </div>

                    </div>

                </div>
            </section>

            <section id="testimonials" class="section-bg wow fadeInUp">
                <div class="container">

                    <header class="section-header">
                        <h3>Our Happy Customer's</h3>
                        <p>Experience Story/ Testimonials of the our respected customers</p>
                    </header>

                    <div class="owl-carousel testimonials-carousel" id="testimonialid" runat="server">
                        
                        <%--<div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="" />
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                                    <img src="img/quote-sign-right.png" class="quote-sign-right" alt="" />
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>--%>

                        <%--<div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
              <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>

                        <div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
              <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>

                        <div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
              <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>--%>

                    </div>

                </div>
            </section>
            <!-- #testimonials -->

            <!--==========================
              Services Section
            ============================-->
            <section id="expert">
                <div class="container">

                    <header class="section-header wow fadeInUp">
                        <h3>Experts Comments</h3>
                        <p>Experience Story/ Testimonials of the our respected customers</p>
                    </header>

                    <div class="owl-carousel expert-carousel" id="expertid" runat="server">
                      <%--<div class="expert-item">
                        <img src="img/comment.jpg" class="expert-img" alt="">
                        <p>
                          <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                          Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                          <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                        </p>
			            <h3>Mr. SN Chattarjee</h3>
			            <div class="cmddesg">(Vice President ICSA) Counsil of Astrological Sciences, (Regd.)</div>
                      </div>--%>
                    </div>

                </div>
            </section>
            <!-- #services -->

            <!--==========================
              About Us Section
            ============================-->
            <section id="about" style="display:none;">
                <div class="container">

                    <div class="fus">
                        <div class="titlehead mb-3">Also for you</div>
                        <div class="row">
                            <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                                <div class="fuimg">
                                    <img src="img/fu1.jpg" alt="">
                                </div>
                                <div class="bdy">
                                    <h2 class="title"><a href="#">Learn Astrology</a></h2>
                                    <div class="desc">
                                        Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                    </div>
                                    <a href="#" class="kwm-btn">Know More</a>
                                </div>
                            </div>

                            <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                                <div class="fuimg">
                                    <img src="img/fu2.jpg" alt="">
                                </div>
                                <div class="bdy">
                                    <h2 class="title"><a href="#">Free Kundali</a></h2>
                                    <div class="desc">
                                        Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                    </div>
                                    <a href="#" class="kwm-btn">Know More</a>
                                </div>
                            </div>

                            <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                                <div class="fuimg">
                                    <img src="img/fu3.jpg" alt="">
                                </div>
                                <div class="bdy">
                                    <h2 class="title"><a href="#">Free Astrology</a></h2>
                                    <div class="desc">
                                        Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                    </div>
                                    <a href="#" class="kwm-btn">Know More</a>
                                </div>
                            </div>

                            <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                                <div class="fuimg">
                                    <img src="img/fu4.jpg" alt="">
                                </div>
                                <div class="bdy">
                                    <h2 class="title"><a href="#">Free Astrology</a></h2>
                                    <div class="desc">
                                        Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                    </div>
                                    <a href="#" class="kwm-btn">Know More</a>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </section>

        </main>


        <%--Footer--%>
        <uc2:astrofooter ID="astrofooter1" runat="server" />
        <%--Footer--%>

        <a href="#" class="back-to-top"><i class="fa fa-chevron-up"></i></a>


        


    </form>
</body>
</html>
