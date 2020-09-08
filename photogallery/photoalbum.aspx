<%@ Page Title="Photo Album | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="photoalbum.aspx.cs" Inherits="photogallery_photoalbum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Astrology Related Photos like as Puja, Hawan etc." />
    <meta name="keywords" content="photo album, photo gallery, astrology photos." />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel='stylesheet prefetch' href='photogallery/css/photoswipe.css' />
    <link rel='stylesheet prefetch' href='photogallery/css/default-skin.css' />
    <link rel="stylesheet" href="photogallery/css/style.css" />
    <link rel="stylesheet" href="photogallery/css/responsive.css" />
    <script>
        function RedirectToAlbum(id) {
            try {
                var pageUrl = document.location.origin;
                if (pageUrl.indexOf('localhost') > -1) {
                    pageUrl = pageUrl + '/astrology'
                }
                else {
                    pageUrl = "https://www.astroenvision.com";
                }
                var url = pageUrl + "/photo-gallery/" + id + ".html";
                window.open(url, '_blank');
            }
            catch (ex) {
                alert(ex);
                return;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="srvc-sec">
        <div class="container">
            <div class="wrapDivcss">
                <div class="fullarticle">
                    <h1 class="fullarticle_catname">Photo Album</h1>
                    <%--<header class="section-header wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                    <h1>Photo Album</h1>
                </header>--%>
                </div>
                <div class="col-xs-12 gallery_1 padd0" id="divShowAlbum" runat="server">
                </div>
                <!-- Root element of PhotoSwipe. Must have class pswp. -->
                <div class="pswp" tabindex="-1" role="dialog" aria-hidden="true">
                    <!-- Background of PhotoSwipe. 
         It's a separate element, as animating opacity is faster than rgba(). -->
                    <div class="pswp__bg">
                    </div>
                    <!-- Slides wrapper with overflow:hidden. -->
                    <div class="pswp__scroll-wrap">
                        <!-- Container that holds slides. PhotoSwipe keeps only 3 slides in DOM to save memory. -->
                        <!-- don't modify these 3 pswp__item elements, data is added later on. -->
                        <div class="pswp__container">
                            <div class="pswp__item">
                            </div>
                            <div class="pswp__item">
                            </div>
                            <div class="pswp__item">
                            </div>
                        </div>
                        <!-- Default (PhotoSwipeUI_Default) interface on top of sliding area. Can be changed. -->
                        <div class="pswp__ui pswp__ui--hidden">
                            <div class="pswp__top-bar">
                                <!--  Controls are self-explanatory. Order can be changed. -->
                                <div class="pswp__counter">
                                </div>
                                <button class="pswp__button pswp__button--close" title="Close (Esc)">
                                </button>
                                <button class="pswp__button pswp__button--share" title="Share">
                                </button>
                                <button class="pswp__button pswp__button--fs" title="Toggle fullscreen">
                                </button>
                                <button class="pswp__button pswp__button--zoom" title="Zoom in/out">
                                </button>
                                <!-- Preloader demo http://codepen.io/dimsemenov/pen/yyBWoR -->
                                <!-- element will get class pswp__preloader--active when preloader is running -->
                                <div class="pswp__preloader">
                                    <div class="pswp__preloader__icn">
                                        <div class="pswp__preloader__cut">
                                            <div class="pswp__preloader__donut">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="pswp__share-modal pswp__share-modal--hidden pswp__single-tap">
                                <div class="pswp__share-tooltip">
                                </div>
                            </div>
                            <button class="pswp__button pswp__button--arrow--left" title="Previous (arrow left)">
                            </button>
                            <button class="pswp__button pswp__button--arrow--right" title="Next (arrow right)">
                            </button>
                            <div class="pswp__caption">
                                <div class="pswp__caption__center">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

