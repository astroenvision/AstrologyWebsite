<%@ Page Language="C#" AutoEventWireup="true" CodeFile="article_astrologer.aspx.cs"
    Inherits="article_article_astrologer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision
    </title>
    <meta charset="utf-8" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="shortcut icon" href="../Image/favicon.ico" type="image/x-icon" />
    <script type="text/javascript">
        var popUpWin = 0;

        function getopen(pagename)
        {

        if(popUpWin)
               {
                    if(!popUpWin.closed) popUpWin.close();
               }

	        popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

        }
        function getopen1(pagename)
        {
             window.parent.location.href="login.aspx";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar id="horarymenubar1" runat="server" />
        <div class="middlecontainer loginMidCont">
            <div class="main-contentarticle">
                <div class="form-background_article">
                    <div class="fullarticle" id="fullarticle_id" runat="server">
                    </div>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
