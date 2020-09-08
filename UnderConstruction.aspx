<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UnderConstruction.aspx.cs" Inherits="UnderConstruction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Under Construction | Astro Envision</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <style type="text/css">
        .background_article {
            float: left;
            width: 100%;
            box-sizing: border-box;
            background-color: #ffffff;
            box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.1);
            padding: 1% 3% 2% 3%;
            margin: 2% 0% 2% 0%;
            -webkit-border-radius: 15px;
            -moz-border-radius: 15px;
            border-radius: 15px;
            box-shadow: 0px 0px 3px 2px #CAC6C6;
            -moz-box-shadow: 0px 0px 3px 2px #CAC6C6;
            -webkit-box-shadow: 0px 0px 3px 2px #CAC6C6;
        }

        /*body {
            margin: 0;
            padding: 0;
            position: relative;
            height: -webkit-fill-available;
            background-color: #fff;
            font-family: Arial, Helvetica, sans-serif;
            background-image: url('udmt.png');
            background-repeat: no-repeat;
            background-position: right bottom;
        }*/



        .errorbox {
            position: absolute;
            top: 48%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
        }

        .mainhead {
            font-size: 100px;
            font-weight: 400;
            color: #384355;
            margin-bottom: 0px;
        }

        .subhead {
            font-size: 28px;
            color: #384355;
            margin-bottom: 10px;
            font-weight: 900;
            font-family: cursive;
        }

        .textp {
            font-size: 16px;
            color: #384355;
            margin-bottom: 0px;
            font-weight: 500;
            line-height: 22px;
            font-family: cursive;
        }

        .textpdesc {
            font-size: 20px;
            color: #384355;
            margin-bottom: 2px;
            font-weight: 500;
            line-height: 32px;
            font-family: sans-serif;
        }

        .backlinks {
            margin-top: 50px;
        }

            .backlinks a {
                font-size: 13px;
                text-decoration: none;
                color: #f2f2f2;
                background-color: #555;
                border: 1px solid #333;
                padding: 7px 18px;
            }

                .backlinks a:hover {
                    background-color: #333;
                    border: 1px solid #111;
                }
    </style>
</head>
<body style="background: #f6f6f6; width: 100%; margin: 0 auto; max-width: 980px;">
    <form id="form1" runat="server">
        <div style="float: left; width: 100%; text-align: center; margin: 10px 0px 0px 0px; padding: 0px 10px 20px 10px;" class="background_article">
            <div class="mainhead">
                <img src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
                <br />
                <img src="<%=ResolveUrl("~/img/Under_Construction_5.png") %>" style="width: 40%" alt="Under Construction" title="Under Construction" />
            </div>
            <div class="textp">WE ARE COMMING SOON</div>
            <div class="subhead">The System under maintenance!</div>
            <div class="textpdesc">
                Our System is currently undergoing scheduled maintenance.<br />
                We should we back shortly. Thanks you for your patience.
            </div>
            <br />
            <img class="footlogo" src="<%=ResolveUrl("~/Image/small_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
        </div>
    </form>
</body>
</html>
