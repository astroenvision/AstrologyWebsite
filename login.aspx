<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology and Consultancy, Prashna Astrology</title>
    <meta name="description" content="Online Vedic Astrology Software generates multiple reports backed by Hundreds of Thousands of planetary combinations present in your birth Chart." />
    <meta name="keywords" content="Online Astrology Services, Astrology Portal, Astrology Website, Indian Astrologer, Indian Vedic Astrology,  Indian Astrology, Natal Astrology, Prashna Astrology, Horary Astrology, Tajik Astrology,  Personal Consultancy, Birth chart Astrology, Telephonic Astrology Consultancy, Skype Astrology Consultancy, Online Astrology Reports for Money,  Online Astrology Reports for Wealth, Online Astrology Reports for Career, Online Astrology Reports for Finance, Online Astrology Reports for Cash, Online Astrology Report for Riches, Online Astrology Reports for Property, Online Astrology Reports for Prosperity, Online Astrology Reports for Profession, Online Astrology Reports for Fame, Online Reports for Fortune, Online Astrology Reports for Love, Online Astrology Reports for Sex life, Online  Astrology Repots for Marriage Prospects, Online Astrology Reports for Manglik Dosha, Astrologer in Delhi, Astrologer in Delhi NCR, Astrologer in India, Top Astrologer, Unique Astrologer,  Old Astrologer, Mantra Astrologer, Tantra Astrologer, Yantra,  Female Astrology, Online Female Astrology, Famous Astrologer, Celebrity Astrologer, Future Astrology, Future Astrologer, Master Astrologer, Horary Astrologer, Prashna Astrologer, Tajik Astrologer Eminent Astrologer, Well known Astrologer, Prestigious Astrologer, Notable Astrologer, Outstanding Astrologer, Foremost Astrologer." />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<script type="text/javascript" src="<%=ResolveUrl("~/javascript/expandable_menutree_jquery.js") %>"></script>--%>

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/jquery.min.js") %>"></script>

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/login.js") %>"></script>

    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/responsiveslides.min.js") %>"></script>

    <%--<link href='http://fonts.googleapis.com/css?family=Roboto' rel='stylesheet' type='text/css' />--%>

    <%--<script type="text/javascript">
    $(document).ready(function() {	
        $('#tabs li a:not(:first)').addClass('inactive');
    $('.container:not(:first)').hide();
    $('.tab1').show();
    $('#tabs li a').click(function(){
        var t = $(this).attr('name');
        $('#tabs li a').addClass('inactive');		
        $(this).removeClass('inactive');
        $('.container').hide();
        $(t).fadeIn('slow');
        return false;
    })
    if($(this).hasClass('inactive')){ //this is the start of our condition 
        $('#tabs li a').addClass('inactive');		 
        $(this).removeClass('inactive');
        $('.container').hide();
        $(t).fadeIn('slow');	
    }
    });
    </script>--%>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#tabs li a:not(:first)').addClass('inactive');
            $('.container:not(:first)').hide();
            $('.tab2').show();
            $('#tabs li a').click(function () {
                var t = $(this).attr('name');
                $('#tabs li a').addClass('inactive');
                $(this).removeClass('inactive');
                $('.container').hide();
                $(t).fadeIn('slow');
                return false;
            })
            if ($(this).hasClass('inactive')) { //this is the start of our condition 
                $('#tabs li a').addClass('inactive');
                $(this).removeClass('inactive');
                $('.container').hide();
                $(t).fadeIn('slow');
            }
            //Match Querystring value
            if (window.location.search.indexOf('horary') > -1) {
                document.getElementById("nid").click();
            }
        });
    </script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('.treebox li').each(function () {
                if ($(this).children('ul').length > 0) {
                    $(this).addClass('parent');
                }
            });

            $('.treebox li.parent > a').click(function () {
                $(this).parent().toggleClass('active');
                $(this).parent().children('ul').slideToggle('fast');
            });

            $('#all').click(function () {

                $('.treebox li').each(function () {
                    $(this).toggleClass('active');
                    $(this).children('ul').slideToggle('fast');
                });
            });

            //$( '.tree li' ).each( function() {
            //	$( this ).toggleClass( 'active' );
            //	$( this ).children( 'ul' ).slideToggle( 'fast' );
            //	});	
        });
    </script>

    <script type="text/javascript">
        $(function () {
            $("#slider1").responsiveSlides({
                auto: true,
                pager: false,
                nav: true,
                speed: 500,
                play: 6000,
                pause: 2500,
                hoverPause: true,
                slideSpeed: 350,
                autoHeight: true,
                fadeSpeed: 500,
                namespace: "callbacks_hh"
            });
        });
    </script>

    <script type="text/javascript">
        $(function () {
            $("#slider2").responsiveSlides({
                auto: true,
                pager: false,
                nav: true,
                speed: 500,
                play: 6000,
                pause: 2500,
                hoverPause: true,
                slideSpeed: 350,
                autoHeight: true,
                fadeSpeed: 500,
                namespace: "callbacks_nh"
            });
        });
    </script>

    <script type="text/javascript">
        $(function () {
            $("#slider5").responsiveSlides({
                auto: false,
                pager: false,
                nav: true,
                speed: 500,
                play: 50000,
                pause: 2500,
                hoverPause: true,
                slideSpeed: 350,
                autoHeight: true,
                fadeSpeed: 500,
                namespace: "callbacks_nc"
            });
        });
    </script>

    <link href="tooltipcssjs/tooltip.css" rel="stylesheet" type="text/css" />
    <script src="tooltipcssjs/tooltip.js" type="text/javascript"></script>

    <%--<style type="text/css">
        /* Tooltip container */
        #tooltip {
            position: relative;
            display: inline-block;
        }

        /* Tooltip text */
        #tooltip .tooltiptext {
            visibility:hidden;
            width: 250px;
            background-color: #F2F2F2;
            color: #333;
            text-align: center;
            padding: 5px 0;
            border-radius: 5%;
            -moz-border-radius: 5%;
	        -webkit-border-radius: 5%;
         
            /* Position the tooltip text - see examples below! */
            position: absolute;
            z-index: 9999999999;
            opacity: 0;
            transition: opacity 1s;
            font:normal 100%/1.3 roboto, helvetica, sans-serif;
            font-size:0.60em;
            padding: 10%;
            text-align: left;
            line-height:1.5em;
            border: 1px solid #BBB;
            box-shadow: 0px 0px 6px #0F0000;
        }

        /* Show the tooltip text when you mouse over the tooltip container */
        #tooltip:hover .tooltiptext {
            visibility: visible;
            opacity: 1;
        }
        #tooltip .tooltiptext {
            width: 500px;
            top: -115px;
            left: 100%; 
            margin-left: 15px; /* Use half of the width (120/2 = 60), to center the tooltip */
        }
        #tooltip .tooltiptext:before {
          content: '';
          position: absolute;
          top: 47%;
          right: 100%;
          margin-left: -11px;
          width: 0; height: 0;
           border-right: 11px solid #BBB;
          border-top: 11px solid transparent;
          border-bottom: 11px solid transparent;
        }
        #tooltip .tooltiptext:after {
            content: '';
          position: absolute;
          top: 50%;
          right: 100%;
          margin-top: -8px;
          width: 0; height: 0;
          border-right: 8px solid #F2F2F2;
          border-top: 8px solid transparent;
          border-bottom: 8px solid transparent;
        }
    </style>--%>

    <script type="text/javascript">
        var blink_speed = 800;
        var t = setInterval(function () {
            var ele = document.getElementById('blinker');
            ele.style.visibility = (ele.style.visibility == 'hidden' ? '' : 'hidden');
        }, blink_speed);
    </script>

    <script type="text/javascript">
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-80701451-1', 'auto');
        ga('send', 'pageview');
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="Server" ID="ScriptManager1" EnablePageMethods="true" />
        <div class="maincontainer">
            <uc1:header ID="header1" runat="server" />
            <div class="middlecontainer middlecontainer_padd">
                <div class="leftmiddlecontainer">
                    <ul id="tabs">
                        <li style="border-right: 0px;"><a href="#" name=".tab2">Natal</a></li>
                        <li><a id="nid" href="#" name=".tab1">Prashna(Horary)</a></li>
                    </ul>
                    <div class="container tab2">
                        <div class="leftcontainer">
                            <span class="topleftheading"><a href="#">Astro Reports on Birth Chart Promise ?</a></span>
                            <ul class="rslides" id="slider5" runat="server">
                                <li id="natalcatfirst" runat="server"></li>
                                <li id="natalcatsecond" runat="server"></li>
                                <%--<li id="natalcatthird" runat="server"></li>--%>
                                <%--<div class="leftcat" id="natalleftid" runat="server">--%>
                                <%--<h1 class="cathead_left">
                                <a class="cathead_left_1" href="#">Travel</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_3" href="#">Job Or Career</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_4" href="#">Inheritance</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_2" href="#">Buy/Cell</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_4" href="#">Litigation</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_1" href="#">Health</a>
                            </h1>--%>
                                <%--</div>--%>
                                <%--<div class="middlecat" style="width: 205px;" id="natalmiddleid" runat="server">--%>
                                <%--<h1 class="cathead_middle">
                                <a class="cathead_middle_1" href="#">Captivity</a>
                            </h1>--%>
                                <%--</div>--%>
                                <%--<div class="rightcat" style="margin:0% 0% 0% -24%" id="natalrightid" runat="server">--%>
                                <%--<h1 class="cathead_right">
                                <a class="cathead_right_1" href="#">Education</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_3" href="#">Family Relations</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_4" href="#">Marriage</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_2" href="#">Love and Romance</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_4" href="#">Relationships</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_1" href="#">Wealth and Money</a>
                            </h1>--%>
                                <%-- </div>--%>
                            </ul>
                        </div>
                        <div class="rightcontainer">
                            <span class="toprighthighlight" style="display: none;">Natal Highlights</span>
                            <div class="topright_hl_details" id="natalhighlightid" runat="server">
                            </div>
                            <div style="width: 100%; margin: 30px auto 0px auto; text-align: center;">
                                <a href="<%=ResolveUrl("userregistration.aspx?usertype=ASTROLOGER") %>">
                                    <img src="<%=ResolveUrl("~/Image/Launch_Free_Trial_Offer_Ad.jpeg") %>" width="100%" height="270px" alt="Astro Envision" title="Astro Envision" />
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="container tab1">
                        <div class="leftcontainer">
                            <ul class="questionsdiv_main" id="question">
                            </ul>
                            <div class="backbtndiv" id="backbtndiv_id" runat="server" style="display: none;">
                                <asp:Button ID="btnback" runat="server" Text="Back" class="loginbtncss" OnClientClick="return BackFunction()" />
                            </div>
                        </div>
                        <div class="leftcontainer" id="leftcontainer_id" runat="server">
                            <span class="topleftheading"><a href="#">Ask Your Prashna / Horary Query ?</a></span>
                            <div class="leftcat" id="horaleftid" runat="server">
                                <%--<h1 class="cathead_left">
                                <a class="cathead_left_1" href="#">Travel</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_3" href="#">Job Or Career</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_4" href="#">Inheritance</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_2" href="#">Buy/Cell</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_4" href="#">Litigation</a>
                            </h1>
                            <br />
                            <h1 class="cathead_left">
                                <a class="cathead_left_1" href="#">Health</a>
                            </h1>--%>
                            </div>
                            <div class="middlecat" id="horamiddleid" runat="server" style="display: none;">
                                <%--<h1 class="cathead_middle">
                                <a class="cathead_middle_1" href="#">Captivity</a>
                            </h1>--%>
                            </div>
                            <div class="rightcat" id="horarightid" runat="server" style="display: none;">
                                <%--<h1 class="cathead_right">
                                <a class="cathead_right_1" href="#">Education</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_3" href="#">Family Relations</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_4" href="#">Marriage</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_2" href="#">Love and Romance</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_4" href="#">Relationships</a>
                            </h1>
                            <br />
                            <h1 class="cathead_right">
                                <a class="cathead_right_1" href="#">Wealth and Money</a>
                            </h1>--%>
                            </div>
                        </div>
                        <div class="rightcontainer">
                            <span class="toprighthighlight" style="display: none;">Horary Highlights</span>
                            <div class="topright_hl_details" id="horaryhighlightid" runat="server">
                            </div>
                            <div style="width: 100%; margin: 30px auto 0px auto; text-align: center;">
                                <a href="<%=ResolveUrl("userregistration.aspx?usertype=ASTROLOGER") %>">
                                    <img src="<%=ResolveUrl("~/Image/Launch_Free_Trial_Offer_Ad.png") %>" alt="Astro Envision" title="Astro Envision" />
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="rightmiddlecontainer">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="toplogin">
                                <h1 class="toplogin_h1" id="loginid" runat="server">
                                    <%--Login--%></h1>
                                <h2 class="toplogin_h2" id="logoutid" runat="server">
                                    <%--<a href="<%=ResolveUrl("astro_registration.aspx?user=1") %>">Register Now ?</a>--%>
                                </h2>
                            </div>
                            <div class="middlelogin" id="middleloginid" runat="server">
                                Username:&nbsp;&nbsp;<asp:TextBox ID="txtusername1" runat="server" Text="" CssClass="logintxtbox"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameReq" runat="server" ControlToValidate="txtusername1"
                                    ErrorMessage="Email ID is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                    CssClass="registrationvalidation" Display="Dynamic" /><br />
                                <asp:RegularExpressionValidator ID="EmailReqVal" ControlToValidate="txtusername1"
                                    Text="Invalid Email ID !" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    runat="server" CssClass="registrationvalidation" ValidationGroup="vgsubmit" />
                                Password:&nbsp;&nbsp;<asp:TextBox ID="txtpwd1" TextMode="Password" runat="server"
                                    Text="" CssClass="logintxtbox"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PwdReq" runat="server" ControlToValidate="txtpwd1"
                                    ErrorMessage="Password is required!" SetFocusOnError="True" ValidationGroup="vgsubmit"
                                    CssClass="registrationvalidation" Display="Dynamic" />
                                <br />
                                <span class="toplogin_h3"><a href="<%=ResolveUrl("forgot_password.html") %>">Forgot Password</a> &nbsp;&nbsp;
                        <asp:Button ID="btnsignin" runat="server" Text="Login" OnClick="btnsignin_Click"
                            class="loginbtncss" ValidationGroup="vgsubmit" />
                                </span>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="container tab1">
                        <div class="treebox" style="border-bottom: none; border-left: none; border-right: none;">
                            <%--<button id="all">Toggle All</button>--%>
                            <ul id="horary_astroid" runat="server">
                                <%--<li><a>Know about Horary Astrology</a>
                            <ul>
                                <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=KAHA&articleid=1") %>">What
                                    is Horary Astrology?</a></li>
                                <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=KAHA&articleid=2") %>">How
                                    does Horary Astrology benefit you?</a></li>
                                <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=KAHA&articleid=3") %>">What
                                    is important about Horary Query?</a></li>
                                <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=KAHA&articleid=4") %>">What
                                    are the alikeness between Natal and Horary Astrology?</a></li>
                                <li><a href="<%=ResolveUrl("~/article/article.aspx?catid=KAHA&articleid=5") %>">What
                                    are the dissimilarities between a Natal and Horary Astrology?</a></li>
                            </ul>
                        </li>--%>
                            </ul>
                        </div>
                    </div>
                    <div class="container tab2">
                        <div class="treebox" style="border-bottom: none; border-left: none; border-right: none;">

                            <ul id="natal_astroid" runat="server">
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <uc2:footer ID="footer1" runat="server" />
        </div>

    </form>
</body>
</html>
