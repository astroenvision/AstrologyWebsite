<%@ Page Language="C#" AutoEventWireup="true" CodeFile="auto_paypal.aspx.cs" Inherits="auto_paypal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PayPal Payment Gateway Integration</title>
</head>
<body onload="document.Paypal.submit();">
    <form id="Paypal" name="Paypal" action="https://www.paypal.com/cgi-bin/webscr" method="post">
    
        <!-- item_number should get passed back -->    
        <input type="hidden" name="cmd" value="_xclick" />        
        <input type="hidden" name="item_name" value="<%=memberid%>" />
        <input type="hidden" name="amount" value="<%=Amount%>" />
        <input type="hidden" name="quantity" value="1" />
        <input type="hidden" name="shipping" value="0.00" />
        <input type="hidden" name="handling" value="0.00" />
        <input type="hidden" name="business" value="<%=business%>" />
        <input type="hidden" name="city" value="Delhi" />
        <input type="hidden" name="state" value="new delhi" />
        <input type="hidden" name="country" value="IN" />
        <input type="hidden" name="currency_code" value="<%=CurrencyCode%>" />
        <input type="hidden" name="lc" value="<%=Location%>"  />
        <input type="hidden" name="return" value="<%=websiteUrl%>/thankyou_paypal.aspx" />
        <input type="hidden" name="cancel_return" value="<%=websiteUrl %>" />
        <input type="hidden" name="cn" value="How did you hear about us?" />
        <input type="hidden" name="rm" value="2" />
        <input type="submit" value="Submit Payment Info" />
        <input type="hidden" name="item_number" value="<%=uid%>" />
    </form>
</body>
</html>
