<%@ Page Language="C#" AutoEventWireup="true" CodeFile="video_section.aspx.cs" Inherits="gallery_video_section" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="ajax" %>
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inauguration October 11th,2016 | Astro Envision</title>
     <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/jquery.min.js") %>"></script>

    <script type="text/javascript">
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
    </script>

    <script type="text/javascript">
$(document).ready(function() {	
    $('#tabsusernatal li a:not(:first)').addClass('inactive');
$('.containerusernatal:not(:first)').hide();
$('.tab3').show();
$('#tabsusernatal li a').click(function(){
    var t = $(this).attr('name');
    $('#tabsusernatal li a').addClass('inactive');		
    $(this).removeClass('inactive');
    $('.containerusernatal').hide();
    $(t).fadeIn('slow');
    return false;
})
if($(this).hasClass('inactive')){ //this is the start of our condition 
    $('#tabsusernatal li a').addClass('inactive');		 
    $(this).removeClass('inactive');
    $('.containerusernatal').hide();
    $(t).fadeIn('slow');	
}
});
    </script>
    
    <script type="text/javascript">
$(document).ready(function() {	
    $('#tabsuserhorary li a:not(:first)').addClass('inactive');
$('.containeruserhorary:not(:first)').hide();
$('.tab5').show();
$('#tabsuserhorary li a').click(function(){
    var t = $(this).attr('name');
    $('#tabsuserhorary li a').addClass('inactive');		
    $(this).removeClass('inactive');
    $('.containeruserhorary').hide();
    $(t).fadeIn('slow');
    return false;
})
if($(this).hasClass('inactive')){ //this is the start of our condition 
    $('#tabsuserhorary li a').addClass('inactive');		 
    $(this).removeClass('inactive');
    $('.containeruserhorary').hide();
    $(t).fadeIn('slow');	
}
});
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <ajax:ToolkitScriptManager ID="scriptmanager1" runat="server">
    </ajax:ToolkitScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer">
                <ul id="tabs">
                    <li style="border-right: 0px;"><a href="#" name=".tab1">For End Users</a></li>
                    <li><a href="#" name=".tab2">For Astrologers</a></li>
                </ul>
                <div class="container tab1">
                    <div class="leftcontainervideo">
                        <div class="topleftheadingvideo">
                            <a href="#">Natal Videos</a>
                            <ul id="tabsusernatal">
                                <li style="border-right: 0px;"><a href="#" name=".tab3">English</a></li>
                                <li><a href="#" name=".tab4">Hindi</a></li>
                            </ul>
                        </div>
                        <div class="containerusernatal tab3" id="UserNatalEngId" runat="server">
                            <%--<h2 class="video_h2">
                                <a href="#">First</a></h2>
                            <h2 class="video_h2">
                                <a href="#">First</a></h2>
                            <h2 class="video_h2">
                                <a href="#">First</a></h2>--%>
                        </div>
                        <div class="containerusernatal tab4" id="UserNatalHindiId" runat="server">
                            <%--<h2 class="video_h2">
                                <a href="#">sss</a></h2>
                            <h2 class="video_h2">
                                <a href="#">sss</a></h2>
                            <h2 class="video_h2">
                                <a href="#">sss</a></h2>--%>
                        </div>
                    </div>
                    <div class="rightcontainervideo">
                        <div class="topleftheadingvideo">
                            <a href="#">Horary Videos</a>
                            <ul id="tabsuserhorary">
                                <li style="border-right: 0px;"><a href="#" name=".tab5">English</a></li>
                                <li><a href="#" name=".tab6">Hindi</a></li>
                            </ul>
                        </div>
                        <div class="containeruserhorary tab5" id="UserHoraryEngId" runat="server">
                            <%--<h2 class="video_h2">
                                <a href="#">First</a></h2>
                            <h2 class="video_h2">
                                <a href="#">First</a></h2>
                            <h2 class="video_h2">
                                <a href="#">First</a></h2>--%>
                        </div>
                        <div class="containeruserhorary tab6" id="UserHoraryHindiId" runat="server">
                            <%--<h2 class="video_h2">
                                <a href="#">sss</a></h2>
                            <h2 class="video_h2">
                                <a href="#">sss</a></h2>
                            <h2 class="video_h2">
                                <a href="#">sss</a></h2>--%>
                        </div>
                    </div>
                </div>
                <div class="container tab2">
                    <div class="leftcontainervideo">
                        <div class="topleftheadingvideo">
                            <a href="#">Natal Videos</a></div>
                    </div>
                    <div class="rightcontainervideo">
                        <div class="topleftheadingvideo">
                            <a href="#">Horary Videos</a></div>
                    </div>
                </div>
            </div>
            <div class="rightmiddlecontainer">
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
