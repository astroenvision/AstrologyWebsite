<%@ Page Language="C#" AutoEventWireup="true" CodeFile="video_details.aspx.cs" Inherits="gallery_video_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astrology Videos</title>
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
        if($(this).hasClass('inactive')){ 
            $('#tabs li a').addClass('inactive');		 
            $(this).removeClass('inactive');
            $('.container').hide();
            $(t).fadeIn('slow');	
        }
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer">
                <ul id="tabs">
                    <li style="border-right: 0px;"><a href="#" name=".tab1">For End Users</a></li>
                    <li><a href="#" name=".tab2">For Astrologers</a></li>
                </ul>
                <div class="container tab1">
                    <div id="video_h1Id" runat="server">
                        <h1 class="video_h1">
                        </h1>
                    </div>
                    <div class="videoboxcss" id="dvPhoto" runat="server">
                    </div>
                    <div class="maincontainervideo" id="EndUserVideoId" runat="server">
                        <%--<h2 class="video_h2">
                            <a href="#">First</a></h2>
                        <h2 class="video_h2">
                            <a href="#">First</a></h2>
                        <h2 class="video_h2">
                            <a href="#">First</a></h2>--%>
                    </div>
                </div>
                <div class="container tab2" id="AstrologerVideoId" runat="server">
                    <div class="maincontainervideo">
                        <h2 class="video_h2">
                            <a href="#">sss</a></h2>
                        <h2 class="video_h2">
                            <a href="#">sss</a></h2>
                        <h2 class="video_h2">
                            <a href="#">sss</a></h2>
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
