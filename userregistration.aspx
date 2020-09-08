<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userregistration.aspx.cs"
    Inherits="userregistration" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration | Astro Envision</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" href="loginform/demo.css" />
    <link rel="stylesheet" href="loginform/form-register.css" />
    <link rel="stylesheet" href="loginform/form-login.css" />

    <script type="text/javascript">
       function isNumber(evt) {
        evt = (evt) ? evt : window.event;
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            alert("Please enter only Numbers.");
            return false;
        }

        return true;
    }

    function ValidateNo() {
        var phoneNo = document.getElementById('txtcontact');

    if (phoneNo.value == "" || phoneNo.value == null) {
            alert("Please enter your Mobile No.");
            return false;
        }
        if (phoneNo.value.length < 10 || phoneNo.value.length > 10) {
            alert("Mobile No. is not valid, Please Enter 10 Digit Mobile No.");
            return false;
        }
        return true;
        }
    </script>

    <script type="text/javascript">
    function hideDiv() 
    {
    document.getElementById('enduser_div').style.display = 'none';
    document.getElementById('astrologer_div').style.display = 'none';
    if (document.getElementById('RadioButtonTipoUser_0') != null) {
        if (document.getElementById('RadioButtonTipoUser_0').checked) {
            document.getElementById('enduser_div').style.display = 'block';
        }
    }

    if (document.getElementById('RadioButtonTipoUser_1') != null) {
        if (document.getElementById('RadioButtonTipoUser_1').checked) {
            document.getElementById('astrologer_div').style.display = 'block';
        }
      }
    }
    
    function HideSubsDiv() 
    {
    document.getElementById('natalperiod_div').style.display = 'none';
    document.getElementById('horaryperiod_div').style.display = 'none';
    if (document.getElementById('rbl_subscription_0') != null) {
        if (document.getElementById('rbl_subscription_0').checked) {
            document.getElementById('natalperiod_div').style.display = 'block';
        }
    }

     if (document.getElementById('rbl_subscription_1') != null) {
        if (document.getElementById('rbl_subscription_1').checked) {
            document.getElementById('horaryperiod_div').style.display = 'block';
        }
      }
       if (document.getElementById('rbl_subscription_2') != null) {
        if (document.getElementById('rbl_subscription_2').checked) {
            document.getElementById('natalperiod_div').style.display = 'block'
            document.getElementById('horaryperiod_div').style.display = 'block';
        }
      }
    }
    </script>

    <script type="text/javascript">
            function CheckOtherIsCheckedByGVID_Natal(spanChk) {
                var IsChecked = spanChk.checked;
                if (IsChecked) {
                    spanChk.parentElement.parentElement.style.backgroundColor = '#d7d4d4';
                    spanChk.parentElement.parentElement.style.color = 'white';
                }
                var CurrentRdbID = spanChk.id;
                var Chk = spanChk;
                Parent = document.getElementById("<%=dvnatalsubs.ClientID%>");
                var items = Parent.getElementsByTagName('input');
                for (i = 0; i < items.length; i++) {
                    if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                        if (items[i].checked) {
                            items[i].checked = false;
                            items[i].parentElement.parentElement.style.backgroundColor = 'white'
                            items[i].parentElement.parentElement.style.color = 'black';
                        }
                    }
                }
            }
            
            
            function CheckOtherIsCheckedByGVID_Horary(spanChk) {
                var IsChecked = spanChk.checked;
                if (IsChecked) {
                    spanChk.parentElement.parentElement.style.backgroundColor = '#d7d4d4';
                    spanChk.parentElement.parentElement.style.color = 'white';
                }
                var CurrentRdbID = spanChk.id;
                var Chk = spanChk;
                Parent = document.getElementById("<%=dvhorarysubs.ClientID%>");
                var items = Parent.getElementsByTagName('input');
                for (i = 0; i < items.length; i++) {
                    if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                        if (items[i].checked) {
                            items[i].checked = false;
                            items[i].parentElement.parentElement.style.backgroundColor = 'white'
                            items[i].parentElement.parentElement.style.color = 'black';
                        }
                    }
                }
            }
    </script>
    
    <script type="text/javascript">
    function Validate() {
        var password = document.getElementById("txtPassword").value;
        var confirmPassword = document.getElementById("txtConfirmPassword").value;
        if (password != confirmPassword) {
            alert("Passwords do not match.");
            return false;
        }
        return true;
    }
</script>

</head>
<body onload="hideDiv();">
    <%--HideSubsDiv();--%>
    <%--<form id="form1" runat="server" novalidate>--%>
    <form id="form1" runat="server" novalidate>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer loginMidCont">
            <div class="main-contentregistration">
                <div class="form-register-usertype">
                    <asp:RadioButtonList ID="RadioButtonTipoUser" runat="server" RepeatDirection="Horizontal"
                        onchange="hideDiv()">
                        <asp:ListItem Selected="True" Value="ENDUSER">For Non-Astrologer</asp:ListItem>
                        <asp:ListItem Value="ASTROLOGER">For Astrologers</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="form-register-with-email" id="enduser_div" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="form-white-background">
                                <div class="form-title-row">
                                    <h1>
                                        Create My Account - New User
                                    </h1>
                                    <h2>
                                        * Indicates Mandatory Fields</h2>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Name</span>
                                        <%--<input type="text" name="name" placeholder="Name *" id="txtname" runat="server" />--%>
                                        <asp:TextBox ID="txtname" runat="server" PlaceHolder="Name *" onfocus="this.type='text'"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email</span>
                                        <%--<input type="text" name="email" placeholder="Email *" id="emailid" runat="server" />--%>
                                        <asp:TextBox ID="txtmailid" runat="server" PlaceHolder="Email *" type="email"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Password</span>
                                        <%--<input type="password" name="password" placeholder="Password *" id="txtpwd" runat="server" />--%>
                                        <asp:TextBox ID="txtpwd" runat="server" PlaceHolder="Password *" onfocus="this.type='password'"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Mobile No</span>
                                        <asp:TextBox ID="txtcontact" runat="server" PlaceHolder="Mobile No *" onfocus="this.type='text'"
                                            onkeypress="return isNumber(event);" onblur="return ValidateNo();"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Gender</span>
                                        <asp:DropDownList ID="userddlgender" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            required>
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Male"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Female"></asp:ListItem>
                                        </asp:DropDownList>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Address</span>
                                        <asp:TextBox ID="txtaddress" runat="server" PlaceHolder="Address" onfocus="this.type='text'"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Country</span>
                                        <asp:DropDownList ID="ddlcountry" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>State</span>
                                        <asp:DropDownList ID="ddlstate" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>City</span>
                                        <asp:DropDownList ID="ddlcity" runat="server" CssClass="dropdowncss" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Pin Code</span>
                                        <asp:TextBox ID="txtpincode" runat="server" PlaceHolder="Pin Code" onfocus="this.type='text'"></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <span>Terms and Conditions</span> <span class="form-conditions">Please read the terms
                                        and indidate that you accept them to continue with the set up process. By clicking
                                        I accept below you are agreeing to the terms and conditions below, the Program Policy,
                                        and the Privacy Policy.</span>
                                </div>
                                <div class="form-row">
                                    <label class="form-checkbox">
                                        <input type="checkbox" name="checkbox" checked />
                                        <span>I accept all Terms & Conditions</span>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <%--<button type="submit">
                                Register</button>--%>
                                    <%--<triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnregister" />
                                    </triggers>--%>
                                    <asp:Button ID="btnregister" runat="server" Text="Register" CssClass="loginbutton"
                                        OnClick="btnregister_Click" />
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div class="form-register-with-email" id="astrologer_div" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <div class="form-white-background">
                                <div class="form-title-row">
                                    <h1>
                                        Create My Account - Astrologer
                                    </h1>
                                    <h2>
                                        * Indicates Mandatory Fields</h2>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Name</span>
                                        <asp:TextBox ID="txtastro_name" runat="server" PlaceHolder="Name *" onfocus="this.type='text'"
                                            required></asp:TextBox>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Email</span>
                                        <%--<input type="text" name="email" placeholder="Email *" id="emailid" runat="server" />--%>
                                        <asp:TextBox ID="txtastro_email" runat="server" PlaceHolder="Email *" type="email"
                                            pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" required></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Password</span>
                                        <input type="password" placeholder="Password *" id="txtastro_pwd" runat="server" title="Password must contain at least 6 characters, including uppercase/lowercase and numbers." required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}" />
                                       <%-- <asp:TextBox ID="txtastro_pwd" runat="server" PlaceHolder="Password *" onfocus="this.type='password'"
                                            onblur="this.type='password'" title="Password must contain at least 6 characters, including UPPER/lowercase and numbers." required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}"></asp:TextBox>--%>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Confirm Password</span>
                                        <input type="password" placeholder="Confirm Password *" id="txtastro_conpwd" runat="server" title="Please enter the same Password as above." required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}" />
                                       <%-- <asp:TextBox ID="txtastro_pwd" runat="server" PlaceHolder="Password *" onfocus="this.type='password'"
                                            onblur="this.type='password'" title="Password must contain at least 6 characters, including UPPER/lowercase and numbers." required pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}"></asp:TextBox>--%>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Mobile No</span>
                                        <asp:TextBox ID="txtastro_mobile" runat="server" PlaceHolder="Mobile No *" onkeypress='return event.charCode >= 48 && event.charCode <= 57'
                                            required></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Address</span>
                                        <asp:TextBox ID="txtastro_address" runat="server" PlaceHolder="Address" onfocus="this.type='text'"
                                            required></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <%--<asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>--%>
                                        <span>Gender</span>
                                        <asp:DropDownList ID="astroddlgender" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            required>
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Male"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Female"></asp:ListItem>
                                        </asp:DropDownList>
                                        <%-- </ContentTemplate>
                                        </asp:UpdatePanel>--%>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Country</span>
                                        <asp:DropDownList ID="astroddlcountry" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="astroddlcountry_SelectedIndexChanged" required />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>State</span>
                                        <asp:DropDownList ID="astroddlstate" runat="server" CssClass="dropdowncss" AutoPostBack="true"
                                            OnSelectedIndexChanged="astroddlstate_SelectedIndexChanged" required />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>City</span>
                                        <asp:DropDownList ID="astroddlcity" runat="server" CssClass="dropdowncss" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Pin Code</span>
                                        <asp:TextBox ID="txtastro_pincode" runat="server" PlaceHolder="Pin Code" onfocus="this.type='text'"
                                            onkeypress='return event.charCode >= 48 && event.charCode <= 57' required></asp:TextBox>
                                    </label>
                                </div>
                                <div class="form-row" style="display: none;">
                                    <label>
                                        <span>Upload Aadhar Card</span>
                                        <input type="file" id="aadhar_card_img" accept="image/png, image/jpeg, image/gif"
                                            runat="server" />
                                    </label>
                                </div>
                                <div class="form-row">
                                    <label>
                                        <span>Subscription For</span>
                                        <asp:RadioButtonList ID="rbl_subscription" runat="server" RepeatDirection="Horizontal"
                                            onchange="HideSubsDiv()" OnSelectedIndexChanged="rbl_subscription_SelectedIndexChanged"
                                            AutoPostBack="false">
                                            <%--<asp:ListItem Value="NATAL" Selected="True" Text="Natal"></asp:ListItem>--%>
                                            <asp:ListItem Value="HORARY" Text="Horary" Selected="True"></asp:ListItem>
                                            <%-- <asp:ListItem Value="BOTH" Text="Both"></asp:ListItem>--%>
                                        </asp:RadioButtonList>
                                    </label>
                                </div>
                                <div class="form-row-price" id="natalperiod_div" style="display: none;">
                                    <label>
                                        <span>Natal Subscription</span>
                                        <asp:GridView ID="dvnatalsubs" runat="server" CssClass="Gridview" AutoGenerateColumns="false"
                                            DataKeyNames="PRICE_INR" HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="White"
                                            OnRowDataBound="dvnatalsubs_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:RadioButton ID="rdbnatal" GroupName="rdbgn" runat="server" onclick="javascript:CheckOtherIsCheckedByGVID_Natal(this);" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Subscription" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblsubscription" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PACK_NAME").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Regular Price(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblactualprice" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRICE_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Discount(%)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbldiscountper" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "DISCOUNT_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="You Save(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbldiscount" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "DISCOUNT_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="You Pay(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblfinalprice" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRICE_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="NatalSubscription" Visible="false">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblnatalsubscription" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PACK_NAME").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </label>
                                </div>
                                <div class="form-row-price" id="horaryperiod_div" style="display: none;">
                                    <label>
                                        <span>Horary Subscription</span>
                                        <asp:GridView ID="dvhorarysubs" runat="server" CssClass="Gridview" AutoGenerateColumns="false"
                                            DataKeyNames="PRICE_INR" HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="White"
                                            OnRowDataBound="dvhorarysubs_RowDataBound">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:RadioButton ID="rdbhorary" GroupName="rdbgn" runat="server" onclick="javascript:CheckOtherIsCheckedByGVID_Horary(this);" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Subscription" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblsubscription" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PACK_NAME").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Regular Price(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblactualprice" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRICE_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Discount(%)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbldiscountper" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "DISCOUNT_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="You Save(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lbldiscount" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "DISCOUNT_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="You Pay(Rs)" Visible="true">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblfinalprice" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PRICE_INR").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="HorarySubscription" Visible="false">
                                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblhorarysubscription" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PACK_NAME").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </label>
                                </div>
                                <div class="form-row">
                                    <asp:Button ID="btnastro_registration" runat="server" Text="Register" CssClass="loginbutton"
                                        OnClick="btnastro_registration_Click" OnClientClick="return Validate();" />
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
