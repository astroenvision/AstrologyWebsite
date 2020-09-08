<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showgallery.aspx.cs" Inherits="photogallery_showgallery" ValidateRequest="false" EnableEventValidation="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Photo Gallery | Astro Envision</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="https://www.astroenvision.com/Image/favicon.ico" type="image/x-icon" />
    <%--<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />--%>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Noto+Sans:400,700" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css" />
    <link rel='stylesheet prefetch' href="css/photoswipe.css" />
    <link rel='stylesheet prefetch' href="css/default-skin.css" />
    <link rel="stylesheet" href="css/style.css" />
    <link rel="stylesheet" href="css/responsive.css" />
    <link rel="stylesheet" href="../lib/bootstrap/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="../css/style.css" />
    <script>
        function BackPage()
        {
            try
            {
                window.location = "photo-gallery.html";
            }
            catch(ex)
            {
                alert(ex);
                return false;
            }
        }
    </script>
    <style>
        .btn_well
        {
            text-transform: uppercase; 
            font-weight: 500;
            font-size: .845rem;
            display: inline-block; 
            padding: 8px 28px;
            border-radius: 5px;
            transition: 0.5s; 
            margin-top: 10px;
            background: #f25e0a;
            border: 1px solid #f25e0a;
            color: #fff;
        }
    </style>
</head>

<body runat="server">
    <div class="wrapDiv">
        <div style="float:left; margin:0px; padding:1em 0em 0em 0em;width: 100%; text-align:center;">
             <a href="https://www.astroenvision.com" title="Astro Envision">
                 <img src="https://www.astroenvision.com/Image/large_logo.svg" alt="Astro Envision" title="Astro Envision" />
            </a>
        </div>
       <div style="float:left;width:100%;border-bottom: 2px solid #F4600A;" runat="server" id="divHeader">
         </div>
        <div class="col-xs-12 gallery_1 padd0" id="divShowGallery" runat="server">
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
                        <button class="pswp__button pswp__button--close" title="Close (Esc)"></button>
                        <button class="pswp__button pswp__button--share" title="Share"></button>
                        <button class="pswp__button pswp__button--fs" title="Toggle fullscreen"></button>
                        <button class="pswp__button pswp__button--zoom" title="Zoom in/out"></button>
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
                    <button class="pswp__button pswp__button--arrow--left" title="Previous (arrow left)"></button>
                    <button class="pswp__button pswp__button--arrow--right" title="Next (arrow right)"></button>
                    <div class="pswp__caption">
                       <div class="pswp__caption__center">
                       </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js'></script>
    <script src="../photogallery/js/index.js"></script>
    <script src='../photogallery/js/photoswipe.min.js'></script>
    <script src='../photogallery/js/photoswipe-ui-default.min.js'></script>
    <label id="hdnPreviousURL" runat="server" visible="false"></label>
</body>

</html>
