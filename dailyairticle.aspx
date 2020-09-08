<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dailyairticle.aspx.cs" Inherits="dailyairticle" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Daily News</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css">
    <link type="text/css" rel="stylesheet" href="CSS/tablet.css">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">
     <script type = "text/javascript" src = "javascript/dailyarticle.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"  />
    <div class="head_main">
        <div class="head">
            <div class="head_logo">
                Astrology</div>
            <div class="head_ad">
                <img src="images/top-ad.jpg" width="468" height="60" alt="ad"></div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    <div class="mid_body" style="padding-bottom: 144px;">
        <div class="mid_sec" style="padding-bottom: 43px; margin-top: 0px; padding-top: 89px;">
        <div id= "outertbl" style="border: 2px solid rgb(125, 170, 227); margin-top: -64px; padding-top: 77px; margin-left: 79px; margin-right: 200px; padding-left: 0px;" >
        
            <div style="margin: -73px 2px 2px; border: 1px solid rgb(125, 170, 227);">
                <div>
                    <tr>
                        <td>
                            <asp:Label ID="heada" runat="server" Text="Headlines :" Font-Bold="true" Font-Size="Small"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="headtext" runat="server"  style="width: 440px; margin-left: 4px;"></asp:TextBox>
                        </td>
                    </tr>
                </div>
                <div>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Keyword :" Font-Bold="true" Font-Size="Small"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="keywords" runat="server" Width="440px" style="width: 440px; border-left-width: 2px; margin-left: 13px; padding-bottom: 2px;"></asp:TextBox>
                        </td>
                    </tr>
                </div>
                <div>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Synopsis :" Font-Bold="true" Font-Size="Small"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="synopsis" runat="server" Width="440px" style="width: 440px; padding-bottom: 23px; margin-left: 11px;"></asp:TextBox>
                        </td>
                    </tr>
                </div>
                <tr>
                    <td align="right" style="width: 100px; font-size:small; " valign="middle" >
                        Fullstory :
                    </td>
                    <td style="width: 533px" valign="middle">
                        <b>
                            <FCKeditorV2:FCKeditor ID="rte" runat="server" BasePath="~/fckeditor/" Width="700px"
                                Height="300px">
                            </FCKeditorV2:FCKeditor>
                        </b>
                    </td>
                </tr>
              
                <div><asp:Label ID="lblphoto" runat="server"></asp:Label></div>
                <div>
                <asp:FileUpload ID="FileUpload1" runat="server" Width="200px" Height="28px" />
                </div>
                  <div style="margin-left: 145px;">
                  
                    <asp:Button ID="submitdata" runat="server" Text="save" style="width:74px"
                        onclick="submitdata_Click" /> 
                        
                </div>
            </div>
            </div>
            <div id="divgrid" runat="server" style="overflow:auto; height:200px "></div>
        </div>
    </div>
    <input type="hidden" runat="server" id="hdnpath" /> 
     <input type="hidden" runat="server" id="head1" /> 
     <input type="hidden" runat="server" id="keyword1" /> 
     <input type="hidden" runat="server" id="snopsis1" /> 
     <input type="hidden" runat="server" id="story1" /> 
      <input type="hidden" runat="server" id="Htime" /> 
    </form>
</body>
</html>
