<%@ Page Language="C#" AutoEventWireup="true" CodeFile="highlight.aspx.cs" Inherits="flashslider_highlight" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link type="text/css" rel="Stylesheet" href="<%=ResolveUrl("~/flashslider/css/jquery.bxslider1.css") %>" />

    <script type="text/javascript" src="<%=ResolveUrl("~/flashslider/js/jquery.min.js") %>"></script>

</head>
<body style="width: 1000px; margin: 0px auto;">
    <form id="form1" runat="server">
    <%-- <div style="position: relative; width: 100%;" id="flashnewsid" runat="server">--%>
    <div class="bxslider1">
        <div class="slide" style='padding: 0.2em 0.5em 0em 0.5em; margin: 0em;'>
            <p style='font-family: sans-serif; font-size: 0.85em; white-space: normal; padding: 0% 0% 0% 0%;
                margin: 0em; color: black; overflow-x: hidden; overflow-y: hidden; text-overflow: ellipsis;
                max-height: 90px;'>
                First</p>
        </div>
        <div class="slide" style='padding: 0.2em 0.5em 0em 0.5em; margin: 0em;'>
            <p style='font-family: sans-serif; font-size: 0.85em; white-space: normal; padding: 0% 0% 0% 0%;
                margin: 0em; color: black; overflow-x: hidden; overflow-y: hidden; text-overflow: ellipsis;
                max-height: 90px;'>
                Second</p>
        </div>
        
    </div>
    <div class="outside">
            <p>
                <span id="slider-prev"></span>
                <br />
                <span id="slider-next"></span>
            </p>
        </div>
    <%--</div>--%>

    <script type="text/javascript" language="javascript" src="<%=ResolveUrl("~/flashslider/js/jquery.bxslider.min.js") %>"></script>

    <script type="text/javascript">
        var $m = jQuery.noConflict();
        $m('.bxslider1').bxSlider({
            slideWidth: 270,
            minSlides: 1,
            maxSlides: 1,
            moveSlides:1,
            slideMargin: 10,
            auto: true,
            pause: 4000,
            pager:false,
            autoControls: false,
            speed:1000,
            //randomStart:true,
            //tickerHover:true,
            autoControlsCombine:true,
            responsive:true,
            nextSelector: '#slider-next',
            prevSelector: '#slider-prev',
            nextText: '<img style="max-width:25px !important;" src="<%=ResolveUrl("~/flashslider/images/next.png") %>" height="22" width="15px"/>',
            prevText: '<img style="max-width:25px !important;" src="<%=ResolveUrl("~/flashslider/images/previous.png") %>" height="22" width="15px"/>'
        });
    </script>

    </form>
</body>
</html>
