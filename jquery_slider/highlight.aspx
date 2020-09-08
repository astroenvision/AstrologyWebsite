<%@ Page Language="C#" AutoEventWireup="true" CodeFile="highlight.aspx.cs" Inherits="jquery_slider_highlight" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
     <link href="css/style.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript" src="<%=ResolveUrl("~/jquery_slider/js/jquery.min.js") %>"></script>
</head>
<body style="margin:0px auto;">
    <form id="form1" runat="server">
      	<div id="slider">
        <img id="button-prev" src="images/left.jpg">

        <div class="slider-mask">
        <div id="slider-content">
            <div class="slider-img">
                <div class="caption">ASTANA: India and Kazakhstan on Wednesday inked five key agreements, including a defence pact to enhance military cooperation and a contract for supply of uranium, after Prime Minister Narendra Modi and Kazakh President Nursultan Nazarbayev held comprehensive talks in which they decided to actively engage in the fight against terrorism and extremism.</div>
            </div>
            <div class="slider-img">
                <div class="caption">UJJAIN/NEW DELHI: The Madhya Pradesh Police have decided to reopen the death case of an MBBS student whose name figured in the Vyapam scam after her postmortem report, which described it has “homicidal” caused by “violent asphyxia”, became public, adding yet another twist to the scandal.</div>
            </div>
            <div class="slider-img">
                <div class="caption">JABALPUR/NEW DELHI: The Madhya Pradesh High Court on Wednesday deferred till July 20 the hearing on the plea of the state government seeking handing over the Vyapam scam probe to CBI. A division bench deferred the hearing on the ground that the Supreme Court is to hear a clutch of similar pleas on Thursday.</div>
            </div>
            </div>
        </div>

        <img id="button-next" src="images/right.jpg">
    </div>


    <script src="js/lib/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script src="js/jquery.index.js" type="text/javascript"></script>
    </form>
</body>
</html>
