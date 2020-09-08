<%@ Page Language="C#" AutoEventWireup="true" CodeFile="auto_ccavenue.aspx.cs" Inherits="auto_ccavenue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ccavenue Payment Gateway Integration</title>
</head>
<body onload="document.Ccavenue.submit();">
    <form id="Ccavenue" method="post" runat="server" action="https://www.ccavenue.com/shopzone/cc_details.jsp">
        <div>
            <table cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td width="80%" height="80%" valign="middle" align="center">
                        <font face="verdana" color="#a16084">For Payment Click On Pay Now Button</font>
                        <br />
                        <br />
                        <asp:Button ID="btnsubmit" runat="server" Text="Pay Now"></asp:Button>
                    </td>
                </tr>
            </table>
        </div>
        <input id="Merchant_Id" style="width: 0px; height: 0px" type="hidden" name="Merchant_Id"
            runat="server" />
        <input id="Order_Id" style="width: 0px; height: 0px" type="hidden" name="Order_Id"
            runat="server" />
        <input id="Amount" style="width: 0px; height: 0px" type="hidden" name="Amount" runat="server" />
        <input id="Redirect_Url" style="width: 0px; height: 0px" type="hidden" name="Redirect_Url"
            runat="server" />
        <input id="WorkingKey" style="width: 0px; height: 0px" type="hidden" name="WorkingKey"
            runat="server" />
        <input id="Checksum" style="width: 0px; height: 0px" type="hidden" name="Checksum"
            runat="server" />
        <input id="userid" style="width: 0px; height: 0px" type="hidden" name="userid"
            runat="server" />
        <input id="cat_id" style="width: 0px; height: 0px" type="hidden" name="catid"
            runat="server" />
        <input type="hidden" id="billing_cust_name" name="billing_cust_name" runat="server" />
        <input type="hidden" id="billing_cust_email" name="billing_cust_email" runat="server" />
        <input type="hidden" id="billing_cust_address" name="billing_cust_address" runat="server" />
        <input type="hidden" id="billing_cust_city" name="billing_cust_city" runat="server" />
        <input type="hidden" id="billing_cust_country" name="billing_cust_country" runat="server" />
        <input type="hidden" id="billing_cust_tel" name="billing_cust_tel" runat="server" />
        <input type="hidden" id="billing_zip_code" name="billing_zip_code" runat="server" />
        <input type="hidden" id="billing_cust_state" name="billing_zip_code" runat="server" />

    </form>
</body>
</html>
