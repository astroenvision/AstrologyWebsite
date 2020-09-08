<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astrologer_details.aspx.cs"
    Inherits="astrologer_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Details | Astro Envision</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/index.css") %>" />
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/css/admincss.css") %>" />
    <style type="text/css">
        .GridViewStyle
        {
            border: 1px solid #ddd;
            border-collapse: collapse;
            font-family: Arial, sans-serif;
            table-layout: auto;
            font-size: 14px;
        }
        .HeaderStyle
        {
            border: 1px, solid, #ddd;
            background-color: #938ede;
        }
        .HeaderStyle th
        {
            padding: 5px 0px 5px 0px;
            color: #333;
            text-align: center;
        }
        tr.RowStyle
        {
            text-align: center;
            background-color: #ffffff;
            height: 30px;
        }
        tr.RowStyle td
        {
        	padding-left: 3px;
        }
        tr.AlternatingRowStyle
        {
            text-align: center;
            background-color: #7fefae;
            height: 30px;
        }
        tr.AlternatingRowStyle td
        {
        	padding-left: 3px;
        }
        tr.RowStyle:hover
        {
            cursor: pointer;
            background-color: #f69542;
        }
        tr.AlternatingRowStyle:hover
        {
            cursor: pointer;
            background-color: #f69542;
        }
        .FooterStyle
        {
            background-color: #938ede;
            height: 25px;
        }
        .PagerStyle table
        {
            margin: auto;
            border: none;
        }
        tr.PagerStyle
        {
            text-align: center;
            background-color: #ddd;
        }
        .PagerStyle table td
        {
            border: 1px;
            padding: 5px;
        }
        .PagerStyle a
        {
            border: 1px solid #fff;
            padding: 2px 5px 2px 5px;
            color: #333;
            text-decoration: none;
        }
        .PagerStyle span
        {
            padding: 2px 5px 2px 5px;
            color: #000;
            font-weight: bold;
            border: 2px solid #938ede;
        }
        #gvDetails
        {
            width: 100%;
        }
        .headerstyle
        {
            color: #FFFFFF;
            border-right-color: #abb079;
            border-bottom-color: #abb079;
            background-color: #f4600a;
            padding: 0.5em 0.5em 0.5em 0.5em;
            text-align: center;
        }
        .gvDetailsRowStyle
        {
            text-align: center;
            background-color: #ffffff;
            height: 30px;
        }
        .gvDetailsFooterStyle
        {
            background-color: #C2C2C2;
            height: 25px;
        }
        .gvDetailsRowStyle > td input
        {
            width: 100% !important;
            padding: 5px 10px !important;
            height: 30px;
        }
        .gvDetailsFooterStyle > td input
        {
            height: 30px;
            padding: 5px 10px !important;
            background-color: #f4600a !important;
            color: White !important;
        }
        #Progress
        {
            position: fixed;
            top: 22%;
            left: 40%;
            width: auto;
            height: auto;
            color: Red;
            font-size: 2em;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="form-main">
                        <div class="form-white-background">
                            <div class="form-title-row">
                                <h1>
                                    Astrologer Details
                                </h1>
                            </div>
                            <div class="form-row" style="float: left; width: 100%; margin: 0em 0em 1em 0em;">
                                <label>
                                    <asp:GridView runat="server" ID="gvDetails" ShowFooter="true" AllowPaging="true"
                                        PageSize="10" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" OnRowDeleting="gvDetails_RowDeleting">
                                        <HeaderStyle CssClass="headerstyle" />
                                        <Columns>
                                            <asp:BoundField DataField="rowid" HeaderText="Row Id" ReadOnly="true" />
                                            <asp:TemplateField HeaderText="Name">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtName" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Email Id">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtemailid" runat="server" />
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    <asp:Button ID="btnAdd" runat="server" Text="Add Row" OnClick="btnAdd_Click" />
                                                </FooterTemplate>
                                            </asp:TemplateField>
                                            <asp:CommandField ShowDeleteButton="true" />
                                        </Columns>
                                        <%--<HeaderStyle CssClass="HeaderStyle" />--%>
                                        <FooterStyle CssClass="gvDetailsFooterStyle" />
                                        <RowStyle CssClass="gvDetailsRowStyle" />
                                        <%--<AlternatingRowStyle CssClass="AlternatingRowStyle" />--%>
                                        <PagerStyle CssClass="PagerStyle" HorizontalAlign="Center" />
                                    </asp:GridView>
                                </label>
                            </div>
                            <div class="form-row" style="float: left; width: 100%; margin: 0em 0em 1em 0em;">
                                <label>
                                    <span></span>
                                    <asp:Button ID="btnsendmail" runat="server" Text="Send Mail" CssClass="buttoncss"
                                        OnClick="btnsendmail_Click" />
                                    <asp:Button ID="btnreset" runat="server" Text="Reset" CssClass="buttoncss" OnClick="btnreset_Click" />
                                </label>
                            </div>
                            <div class="form-row" style="float: left; width: 100%; margin: 0em 0em 0em 0em;">
                                <label>
                                    <span>Keyword:</span>
                                    <asp:TextBox ID="txtkeyword" runat="server" Text="" PlaceHolder="Name or EmailID"></asp:TextBox>
                                </label>
                                <label>
                                    <span></span>
                                    <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="buttoncss" OnClick="btnsearch_Click" />
                                </label>
                            </div>
                            <div class="form-row" style="float: left; width: 100%; margin: 0% auto;">
                                <label>
                                    <h4 id="lbl_result" runat="server">
                                    </h4>
                                </label>
                            </div>
                            <div style="float: left; margin: 0.5em 0em 0em 0em; padding: 0em; width: 100%;">
                                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                    <ProgressTemplate>
                                        <div id="Progress">
                                            <img src="<%=ResolveUrl("~/Image/loading.gif") %>" alt="Please Wait..." title="Please Wait..." style="vertical-align: middle" alt="Wait" />
                                            Please Wait...
                                        </div>
                                    </ProgressTemplate>
                                </asp:UpdateProgress>
                                <asp:GridView ID="grdviews" runat="server" Width="100%" AutoGenerateColumns="False"
                                    CellPadding="4" PageSize="30" AllowPaging="True" DataKeyNames="ID" BorderColor="#CDE0F5"
                                    HeaderStyle-Height="30px" OnPageIndexChanging="grdviews_PageIndexChanging" OnRowDataBound="grdviews_RowDataBound"
                                    CssClass="GridViewStyle" OnRowCancelingEdit="grdviews_RowCancelingEdit" OnRowDeleting="grdviews_RowDeleting"
                                    OnRowEditing="grdviews_RowEditing" OnRowUpdating="grdviews_RowUpdating" EmptyDataText="No records has been added.">
                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="Code" Visible="false" />
                                        <%--<asp:TemplateField HeaderText="S.No" Visible="true">
                                        <ItemStyle VerticalAlign="top"></ItemStyle>
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblrowno" Width="10px" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                      </asp:TemplateField>--%>
                                        <asp:TemplateField HeaderText="Name">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left" Wrap="true"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblname" runat="server" Text='<%# Bind("NAME")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="EmailID" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblemailid" runat="server" Text='<%# Bind("MAINMAIL")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Subscription" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblsubscription" runat="server" Text='<%# Bind("SUBSCRIPTION")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Gender" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblgender" runat="server" Text='<%# Bind("GENDER")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Mobile" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblmobile" runat="server" Text='<%# Bind("MOBILE_NO")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Password" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblpwd" runat="server" Text='<%# Bind("PASSWORD")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Created Date" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblcrtddate" runat="server" Text='<%# Bind("CRTDDATE")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Valid Form" Visible="false">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblvalidfrom" runat="server" Text='<%# Bind("VALID_FROM")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Valid To" Visible="false">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblvalidto" runat="server" Text='<%# Bind("VALID_TO")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Validity(In Days)" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblvalidity" runat="server" Text='<%# Bind("DAYS")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlvalidity" runat="server">
                                                    <asp:ListItem Value="0">--Select Validity--</asp:ListItem>
                                                    <asp:ListItem Value="15">15</asp:ListItem>
                                                    <asp:ListItem Value="30">30</asp:ListItem>
                                                    <asp:ListItem Value="45">45</asp:ListItem>
                                                    <asp:ListItem Value="60">60</asp:ListItem>
                                                    <asp:ListItem Value="75">75</asp:ListItem>
                                                    <asp:ListItem Value="90">90</asp:ListItem>
                                                    <asp:ListItem Value="180">180</asp:ListItem>
                                                    <asp:ListItem Value="270">270</asp:ListItem>
                                                    <asp:ListItem Value="365">365</asp:ListItem>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlstatus" runat="server">
                                                    <asp:ListItem Value="0">--Select Status--</asp:ListItem>
                                                    <asp:ListItem Value="T">Active</asp:ListItem>
                                                    <asp:ListItem Value="F">Inactive</asp:ListItem>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblstatus" runat="server" Text='<%# Bind("ACTIVE")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Mail Status" Visible="true">
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlmailstatus" runat="server">
                                                    <asp:ListItem Value="0">--Select Status--</asp:ListItem>
                                                    <asp:ListItem Value="T">Active</asp:ListItem>
                                                    <asp:ListItem Value="F">Inactive</asp:ListItem>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblmailstatus" runat="server" Text='<%# Bind("VERIFY_EMAILID")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <%--<asp:TemplateField HeaderText="Question" Visible="true">
                                            <ItemStyle VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblquestion" runat="server" Text=""></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>--%>
                                        <%--<asp:TemplateField HeaderText="Modify">
                                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink Text="Edit" ID="btnedit" runat="server" Target="_blank" ForeColor="Red"
                                                    Font-Bold="false" Font-Size="0.85em" Font-Underline="true"></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>--%>
                                        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"
                                            ItemStyle-Width="120" HeaderText="Action" />
                                    </Columns>
                                    <HeaderStyle CssClass="HeaderStyle" />
                                    <FooterStyle CssClass="FooterStyle" />
                                    <RowStyle CssClass="RowStyle" />
                                    <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                                    <PagerStyle CssClass="PagerStyle" HorizontalAlign="Center" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
