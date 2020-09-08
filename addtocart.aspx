<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addtocart.aspx.cs" Inherits="addtocart"
    EnableEventValidation="false" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/headernew.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footernew.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology and Consultancy, Prashna(Horary) Astrology</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css" />
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
    <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
    <%--<link href="css/combine.css" type="text/css" rel="stylesheet" />--%>
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans" />
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />--%>
    <style type="text/css">
        nav select
        {
            display: none;
        }
        @media (max-width: 768px)
        {
            nav ul
            {
                display: none;
            }
            nav select
            {
                display: inline-block;
            }
        }
    </style>
    <%-- <script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>

    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js" type="text/javascript"></script>--%>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/addtocart.js"></script>

    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>

    <%--<script type="text/javascript" language="javascript">
	 // DOM ready
	 $(function() {
	   
      // Create the dropdown base
      $("<select />").appendTo("nav");
      
      // Create default option "Go to..."
      $("<option />", {
         "selected": "selected",
         "value"   : "",
         "text"    : "Go to..."
      }).appendTo("nav select");
      
      // Populate dropdown with menu items
      $("nav a").each(function() {
       var el = $(this);
       $("<option />", {
           "value"   : el.attr("href"),
           "text"    : el.text()
       }).appendTo("nav select");
      });
      
	   // To make dropdown actually work
	   // To make more unobtrusive: http://css-tricks.com/4064-unobtrusive-page-changer/
      $("nav select").change(function() {
        window.location = $(this).find("option:selected").val();
      });
	 
	 });
    </script>--%>

    <script language="javascript" type="text/javascript">    
    function HideMainMenu(e) {
        if (window.event) {
            e = window.event;
        }
        if (e.keyCode == 13) {
             $k( '#dl-menu' ).dlmenu("closeMenu");
             return false;
        }
    }
    </script>

    <%--<link href="css/combine.css" type="text/css" rel="stylesheet" />--%>
    <%--CSS for showing chart (homenewpage css)--%>
</head>
<body id="body1" onload="ChangeLabels();" onkeypress="javascript:return HideMainMenu(event);">
    <form id="form1" runat="server">
    <asp:ScriptManager runat="Server" ID="ScriptManager1" />
    <div class="maincontainer">
        <div id="loading" style="display: none;">
            <img id="loading-image" src="IMAGES/please_wait.gif" alt="Loading..." />
        </div>
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer" style="width: 50%; display: none;">
                <ul id="tabs" runat="server">
                    <li><a id="groupheaderid" href="#" runat="server"></a></li>
                </ul>
                <div class="fullarticle" id="fullarticle_id" runat="server">
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="HoraryPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvHoraryQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="true" GridLines="none" HeaderStyle-Width="96%" OnRowDataBound="GvHoraryQuestions_RowDataBound"
                                OnRowDeleting="GvHoraryQuestions_RowDeleting" DataKeyNames="GROUP_ID" CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="Type" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="10%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblgroupid" runat="server" Text='<%# Eval("GROUP_ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Category" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="20%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcatid" runat="server" Text='<%# Eval("CATID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="You've Chosen/May Add More" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="50%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbladdmore" runat="server" Text='<%# Eval("totalques") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Edit" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="10%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="btnedit" runat="server" Target="_self">
                                               <img src="Image/editbtn.png" alt="Edit" title="Edit" />
                                            </asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Delete" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="8%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btndelete" runat="server" Text="" CommandName="Delete">
                                                            <img src="Image/deletebtn.png" alt="Delete" title="Delete" />
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                        <%--<asp:Panel ID="NatalPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvNatalQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="false" GridLines="none" CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="Country" ItemStyle-Width="100%" ItemStyle-ForeColor="#5D5D5D">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("QUESTION") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>--%>
                        <div class="fullarticle_offer" id="offermaindiv" runat="server">
                            <h2 class="offerh1">
                                Current Offer – Free of Cost
                            </h2>
                            <h2 class="offerh2" id="offerid" runat="server">
                            </h2>
                        </div>
                        <div class="fullarticle_next">
                            <h2 class="priceh2" id="totalamt" runat="server">
                            </h2>
                            <asp:Button ID="btnaddmorecat" runat="server" Text="Add more Category" class="nextbtncss"
                                OnClick="btnaddmorecat_Click" />
                            <%--<asp:Button ID="btnnext" runat="server" Text="Next" class="nextbtncss" />--%>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="rightmiddlecontainer" style="width: 98%; border: none;">
                <div id="list_state" style="position: absolute; top: 0px; left: 0px; border: none;
                    display: none; z-index: 2; margin-top: 23px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:ListBox ID="state_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121"
                                            onkeydown="javascript:StateKeyPressed(event);"></asp:ListBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="list_district" style="position: absolute; top: 0px; left: 0px; border: none;
                    display: none; z-index: 2; margin-top: 23px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <asp:ListBox ID="district_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                                        </asp:ListBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="list_div" style="position: absolute; top: 0px; left: 0px; border: none;
                    display: none; z-index: 2; margin-top: 23px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel71" runat="server">
                                    <ContentTemplate>
                                        <asp:ListBox ID="city_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121"
                                            onkeydown="javascript:CityKeyPressed(event);"></asp:ListBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="mid_body_new">
                    <div class="mid_seca_enduser">
                        <div class="mid_seca_enduser_main">
                            <div class="mid_seca_enduser_background">
                                <div class="mid_seca_enduser-title-row">
                                    <h1>
                                        Query Details
                                    </h1>
                                </div>
                                <fieldset class="fieldsetcss">
                                    <div>
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>
                                                <table cellspacing="5" cellpadding="5" class="endusertblcss">
                                                    <tr>
                                                        <td>
                                                            Category Name <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="mid_seca_enduser-row-dropdown "
                                                                Enabled="false">
                                                                <asp:ListItem>Select Category</asp:ListItem>
                                                                <asp:ListItem Value="natal">Natal</asp:ListItem>
                                                                <asp:ListItem Value="horary">Horary</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Client Email Id <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="txtmail" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr id="pwdlabel" runat="server" style="display: none;">
                                                        <td>
                                                            Password <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="txtpwd" runat="server" CssClass="mid_seca_enduser-row-txtbx" TextMode="Password"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Client Name <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="cl_name" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="datelabel">
                                                                D.O.B / D.O.Q <font class="star">*</font></div>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="dob" runat="server" Enabled="true" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                            <img id="cal" runat="server" src='Image/cal1.png' width="22" height="24" onclick="popUpCalendar(this, form1.dob,'dd/mm/yyyy',event)"
                                                                alt="" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="timelabel">
                                                                T.O.B / T.O.Q<font class="star"> *</font></div>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:DropDownList ID="hob" runat="server" Width="19%" CssClass="dropdowncss">
                                                                <asp:ListItem>Hours</asp:ListItem>
                                                                <asp:ListItem>0</asp:ListItem>
                                                                <asp:ListItem>01</asp:ListItem>
                                                                <asp:ListItem>02</asp:ListItem>
                                                                <asp:ListItem>03</asp:ListItem>
                                                                <asp:ListItem>04</asp:ListItem>
                                                                <asp:ListItem>05</asp:ListItem>
                                                                <asp:ListItem>06</asp:ListItem>
                                                                <asp:ListItem>07</asp:ListItem>
                                                                <asp:ListItem>08</asp:ListItem>
                                                                <asp:ListItem>09</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                                <asp:ListItem>21</asp:ListItem>
                                                                <asp:ListItem>22</asp:ListItem>
                                                                <asp:ListItem>23</asp:ListItem>
                                                            </asp:DropDownList>
                                                            <asp:DropDownList ID="mob" runat="server" Width="18%" CssClass="dropdowncss">
                                                                <asp:ListItem>Minutes</asp:ListItem>
                                                                <asp:ListItem>0</asp:ListItem>
                                                                <asp:ListItem>01</asp:ListItem>
                                                                <asp:ListItem>02</asp:ListItem>
                                                                <asp:ListItem>03</asp:ListItem>
                                                                <asp:ListItem>04</asp:ListItem>
                                                                <asp:ListItem>05</asp:ListItem>
                                                                <asp:ListItem>06</asp:ListItem>
                                                                <asp:ListItem>07</asp:ListItem>
                                                                <asp:ListItem>08</asp:ListItem>
                                                                <asp:ListItem>09</asp:ListItem>
                                                                <asp:ListItem>10</asp:ListItem>
                                                                <asp:ListItem>11</asp:ListItem>
                                                                <asp:ListItem>12</asp:ListItem>
                                                                <asp:ListItem>13</asp:ListItem>
                                                                <asp:ListItem>14</asp:ListItem>
                                                                <asp:ListItem>15</asp:ListItem>
                                                                <asp:ListItem>16</asp:ListItem>
                                                                <asp:ListItem>17</asp:ListItem>
                                                                <asp:ListItem>18</asp:ListItem>
                                                                <asp:ListItem>19</asp:ListItem>
                                                                <asp:ListItem>20</asp:ListItem>
                                                                <asp:ListItem>21</asp:ListItem>
                                                                <asp:ListItem>22</asp:ListItem>
                                                                <asp:ListItem>23</asp:ListItem>
                                                                <asp:ListItem>24</asp:ListItem>
                                                                <asp:ListItem>25</asp:ListItem>
                                                                <asp:ListItem>26</asp:ListItem>
                                                                <asp:ListItem>27</asp:ListItem>
                                                                <asp:ListItem>28</asp:ListItem>
                                                                <asp:ListItem>29</asp:ListItem>
                                                                <asp:ListItem>30</asp:ListItem>
                                                                <asp:ListItem>31</asp:ListItem>
                                                                <asp:ListItem>32</asp:ListItem>
                                                                <asp:ListItem>33</asp:ListItem>
                                                                <asp:ListItem>34</asp:ListItem>
                                                                <asp:ListItem>35</asp:ListItem>
                                                                <asp:ListItem>36</asp:ListItem>
                                                                <asp:ListItem>37</asp:ListItem>
                                                                <asp:ListItem>38</asp:ListItem>
                                                                <asp:ListItem>39</asp:ListItem>
                                                                <asp:ListItem>40</asp:ListItem>
                                                                <asp:ListItem>41</asp:ListItem>
                                                                <asp:ListItem>42</asp:ListItem>
                                                                <asp:ListItem>43</asp:ListItem>
                                                                <asp:ListItem>44</asp:ListItem>
                                                                <asp:ListItem>45</asp:ListItem>
                                                                <asp:ListItem>46</asp:ListItem>
                                                                <asp:ListItem>47</asp:ListItem>
                                                                <asp:ListItem>48</asp:ListItem>
                                                                <asp:ListItem>49</asp:ListItem>
                                                                <asp:ListItem>50</asp:ListItem>
                                                                <asp:ListItem>51</asp:ListItem>
                                                                <asp:ListItem>52</asp:ListItem>
                                                                <asp:ListItem>53</asp:ListItem>
                                                                <asp:ListItem>54</asp:ListItem>
                                                                <asp:ListItem>55</asp:ListItem>
                                                                <asp:ListItem>56</asp:ListItem>
                                                                <asp:ListItem>57</asp:ListItem>
                                                                <asp:ListItem>58</asp:ListItem>
                                                                <asp:ListItem>59</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Country <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:DropDownList ID="ddlcunt" runat="server" CssClass="mid_seca_enduser-row-dropdown " />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            State <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="ddlstat" runat="server" CssClass="mid_seca_enduser-row-txtbx" />
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none;">
                                                        <td id="dis" runat="server">
                                                            District<font class="star"> *</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="district" runat="server" CssClass="mid_seca_enduser-row-txtbx" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="citylabel">
                                                                City\Place Of Birth- Query<font class="star"> *</font></div>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="city" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <%--<tr>
                                                        <td>
                                                            Client Email Id <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="txtmail" runat="server" Width="58%" Height="25px" CssClass="textbox"></asp:TextBox>
                                                        </td>
                                                        </tr>
                                                        <tr id="pwdlabel" runat="server">
                                                        <td>
                                                            Password <font class="star">*</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="txtpwd" runat="server" Width="58%" Height="25px" TextMode="Password" CssClass="textbox"></asp:TextBox>
                                                        </td>
                                                        </tr>--%>
                                                    <tr>
                                                        <td>
                                                            Contact Number
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="mn" runat="server" CssClass="mid_seca_enduser-row-txtbx" MaxLength="10"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Profession
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="cl_pro" runat="server" TextMode="MultiLine" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Sex
                                                        </td>
                                                        <td class="latter" style="margin: 0px 0px 0px 4px; border-radius: 5px;
                                                            color: #333333; font-family: Open Sans; width: 180px; float: left">
                                                            <asp:RadioButton ID="female" value="F" Text="Female" CssClass="gendercss" runat="server" />
                                                            <asp:RadioButton ID="male" value="M" Text="Male" CssClass="gendercss" runat="server"
                                                                Checked="true" />
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none;">
                                                        <td>
                                                            Group Name <font class="star">*</font>
                                                        </td>
                                                        <td class="latter">
                                                            <asp:DropDownList ID="cat" runat="server" Width="71%" CssClass="dropdowncss" Enabled="false">
                                                                <asp:ListItem Value="AEH">Astro Envision Horary</asp:ListItem>
                                                                <asp:ListItem Value="AEN">Astro Envision Natal</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td class="latter">
                                                            <asp:TextBox ID="catn" runat="server" placeholder="Enter Group Name" CssClass="mid_seca_enduser-row-txtbx"
                                                                Style="display: none;"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Latitude<font class="star"> *</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="lat" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Longitude<font class="star"> *</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="lng" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Time Zone<font class="star"> *</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="tz" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="display: none;">
                                                            Age<font class="star"> *</font>
                                                        </td>
                                                        <td class="latter" colspan="2">
                                                            <asp:TextBox ID="cl_age" Style="display: none;" runat="server" CssClass="mid_seca_enduser-row-txtbx"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td colspan="2">
                                                            <asp:LinkButton ID="logout" runat="server" class="per_btn">Save_Updates</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                    <tr class="mid_over1_border">
                                                        <td colspan="3" class="mid_over1_border_td">
                                                            <asp:LinkButton ID="submit" runat="server" class="per_btn_new" Style="margin-left: 0px;">View Chart & Reports</asp:LinkButton>
                                                            &nbsp;
                                                            <asp:LinkButton ID="moc" runat="server" class="per_btn_new" Style="margin-left: 0px;
                                                                display: none;">Calculate Chart With Your Planetry Details</asp:LinkButton>
                                                            &nbsp;
                                                            <asp:LinkButton ID="pqh" runat="server" class="per_btn_new" Style="margin-left: 0px;
                                                                display: none;">Probable Query</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td colspan="2">
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <font class="star"> *</font> <asp:Label ID="Label1" runat="server" Text=" Please Do Not Refresh or close the Current Page..for a while as your Reports are in process."></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div id="clinetnamediv" runat="server" style="width: 100%; display: none;">
                                        <asp:Label ID="Label2" runat="server" Text="Probale Query" font-weight="600" font-family="Open Sans"
                                            Font-Size="11px" ForeColor="White"></asp:Label>
                                        <asp:Button ID="cross" runat="server" Text="X" />
                                        <div id="Divgrid1" style="width: 550px; height: 125px; display: none; overflow: auto;">
                                            <table>
                                                <tr>
                                                    <td runat="server" id="hdsviewgrid" style="width: 280px;" align="left">
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
    <uc2:footer ID="footer1" runat="server" />
    </div>
    <input type="hidden" runat="server" id="TotalAmounts" />
    <input type="hidden" runat="server" id="CurrencyType" />
    <input type="hidden" runat="server" id="Hclmail" />
    <input type="hidden" runat="server" id="Hclname" />
    <input type="hidden" runat="server" id="Hastmail" />
    <input type="hidden" runat="server" id="Hastname" />
    <input type="hidden" runat="server" id="hdnuser" />
    <input type="hidden" runat="server" id="hdnastmail" />
    <input type="hidden" runat="server" id="hdnastname" />
    <input type="hidden" runat="server" id="hdnclmail" />
    <input type="hidden" runat="server" id="hdnclname" />
    <input type="hidden" runat="server" id="hdnage" />
    <input type="hidden" runat="server" id="hdngender" />
    <input type="hidden" runat="server" id="hdnmob" />
    <input type="hidden" runat="server" id="hdnprof" />
    <input type="hidden" runat="server" id="hdngroup" />
    <input type="hidden" runat="server" id="hdngroup_u" />
    <input type="hidden" runat="server" id="hdnflag" />
    <input type="hidden" runat="server" id="username" />
    <input type="hidden" runat="server" id="hdnstate" />
    <input type="hidden" runat="server" id="hdndistrict" />
    <input type="hidden" runat="server" id="hdnlat" />
    <input type="hidden" runat="server" id="hdnlng" />
    <input type="hidden" runat="server" id="hiddendateformat" />
    <input type="hidden" runat="server" id="hdncit" />
    <input type="hidden" runat="server" id="hdntz" />
    <input type="hidden" runat="server" id="hdndifftz" />
    <input type="hidden" runat="server" id="hdnditob" />
    <input type="hidden" runat="server" id="hdnhob" />
    <input type="hidden" runat="server" id="hdnmiob" />
    <input type="hidden" runat="server" id="hdncon" />
    <input type="hidden" runat="server" id="hdnstateu" />
    <input type="hidden" runat="server" id="hdndist" />
    <input type="hidden" runat="server" id="hdncity" />
    <input type="hidden" runat="server" id="hdngroupu" />
    <input type="hidden" runat="server" id="hdncat" />
    <input type="hidden" runat="server" id="hdsunsetpre" />
    <input type="hidden" runat="server" id="hdsunrise" />
    <input type="hidden" runat="server" id="hdsunset" />
    <input type="hidden" runat="server" id="hdsunrisenext" />
    <div style="float: left; width: 40%; display: none;" id="makeenduserchartid" runat="server">
        <div id="Divgrid1_enduser" class="divg1homenewpage">
            <table>
                <tr>
                    <td runat="server" id="hdsviewgrid_enduser" style="width: 520px;" align="left">
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="divg1homenewpage11" style="display: none;">
        <asp:Label ID="label11" font-weight="600" font-family="Open Sans" Font-Size="11px"
            ForeColor="Black" runat="server" Text="Birth"></asp:Label>
        <asp:DropDownList ID="birth" runat="server" CssClass="drpo_homenew">
        </asp:DropDownList>
        <asp:Label ID="label12" font-weight="600" font-family="Open Sans" Font-Size="11px"
            ForeColor="Black" Style="display: none;" runat="server" Text="Planet"></asp:Label>
        <asp:DropDownList ID="planet" runat="server" Style="display: none;" CssClass="drpo_homenew">
        </asp:DropDownList>
        <asp:Label ID="label13" font-weight="600" font-family="Open Sans" Font-Size="11px"
            ForeColor="Black" runat="server" Text="D.O.B / D.O.Q"></asp:Label>
        <asp:TextBox ID="Texttodate" runat="server" CssClass="drpo_homenew"></asp:TextBox>
        <img src='Image/cal1.gif' onclick="popUpCalendar(this, form1.Texttodate,'dd/mm/yyyy',event)"
            class="calendra_homenew" alt="" />
    </div>
    <div class="column1ho" id="rashiid_enduser" style="display: none; float: left;">
        <div class="column-div1">
            <span>
                <asp:Label ID="h1l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr1">
            <span>
                <asp:Label ID="h1r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div2">
            <span>
                <asp:Label ID="h2l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr2">
            <span>
                <asp:Label ID="h2r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div3">
            <span>
                <asp:Label ID="h3l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr3">
            <span>
                <asp:Label ID="h3r" runat="server" Text="">
                </asp:Label></span>
        </div>
        <div class="column-div4">
            <span>
                <asp:Label ID="h4l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr4">
            <span>
                <asp:Label ID="h4r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div5">
            <span>
                <asp:Label ID="h5l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr5">
            <span>
                <asp:Label ID="h5r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div6">
            <span>
                <asp:Label ID="h6l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr6">
            <span>
                <asp:Label ID="h6r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div7">
            <span>
                <asp:Label ID="h7l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr7">
            <span>
                <asp:Label ID="h7r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div8">
            <span>
                <asp:Label ID="h8l1" runat="server" Text="">
                </asp:Label></span>
        </div>
        <div class="column-divr8">
            <span>
                <asp:Label ID="h8r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div9">
            <span>
                <asp:Label ID="h9l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr9">
            <span>
                <asp:Label ID="h9r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div10">
            <span>
                <asp:Label ID="h10l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr10">
            <span>
                <asp:Label ID="h10r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div11">
            <span>
                <asp:Label ID="h11l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr11">
            <span>
                <asp:Label ID="h11r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-div12">
            <span>
                <asp:Label ID="h12l1" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <div class="column-divr12">
            <span>
                <asp:Label ID="h12r" runat="server" Text="">
                </asp:Label>
            </span>
        </div>
        <figure class="fixedratio"></figure>
    </div>
    <input type="hidden" runat="server" id="hdnmoc" />
    <input type="hidden" runat="server" id="hdndob" />
    <input type="hidden" runat="server" id="hdnidob" />
    <input type="hidden" runat="server" id="hdnimoob" />
    <input type="hidden" runat="server" id="hdniyob" />
    <input type="hidden" runat="server" id="hdntob" />
    <input type="hidden" runat="server" id="hdnihob" />
    <input type="hidden" runat="server" id="hdnimob" />
    <input type="hidden" runat="server" id="Hnewdiffm" />
    <input type="hidden" runat="server" id="Hnewdiffm1" />
    <input type="hidden" runat="server" id="Hnewdiffv" />
    <input type="hidden" runat="server" id="Hnewdiffv1" />
    <input type="hidden" runat="server" id="hdntzo" />
    <input type="hidden" runat="server" id="Hidden4" />
    <input type="hidden" runat="server" id="hdnretro0" />
    <input type="hidden" runat="server" id="hdnretro1" />
    <input type="hidden" runat="server" id="hdnretro2" />
    <input type="hidden" runat="server" id="hdnretro3" />
    <input type="hidden" runat="server" id="hdnretro4" />
    <input type="hidden" runat="server" id="hdnretro5" />
    <input type="hidden" runat="server" id="hdnretro6" />
    <input type="hidden" runat="server" id="hdnretro7" />
    <input type="hidden" runat="server" id="hdnretro8" />
    <input type="hidden" runat="server" id="hdnretro9" />
    <input type="hidden" runat="server" id="hdnretro10" />
    <input type="hidden" runat="server" id="hdnr0" />
    <input type="hidden" runat="server" id="hdnr1" />
    <input type="hidden" runat="server" id="hdnr2" />
    <input type="hidden" runat="server" id="hdnr3" />
    <input type="hidden" runat="server" id="hdnr4" />
    <input type="hidden" runat="server" id="hdnr5" />
    <input type="hidden" runat="server" id="hdnr6" />
    <input type="hidden" runat="server" id="hdnr7" />
    <input type="hidden" runat="server" id="hdnr8" />
    <input type="hidden" runat="server" id="hdnr9" />
    <input type="hidden" runat="server" id="hdnr10" />
    <%--Vargas Chart Page Code--%>
    <div style="display: none;">
        <div id="Div1" class="div_header" style="float: left; width: 98%;">
            <div class="d_header_1 h_filters">
                <span class="filterss">
                    <asp:Label ID="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" Text="Astrologer Name :" runat="server">
                    </asp:Label>
                    <asp:Label ID="astname" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" runat="server">
                    </asp:Label>
                </span><span class="filterss">
                    <asp:Label ID="lblastrologerid" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" Text="Astrologer ID :" runat="server">
                    </asp:Label>
                    <asp:Label ID="astid" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" runat="server">
                    </asp:Label>
                </span><span class="filterss">
                    <asp:Label ID="lblclientname" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" Text="Client Name :" runat="server">
                    </asp:Label>
                    <asp:Label ID="clientname" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" runat="server">
                    </asp:Label>
                </span><span class="filterss">
                    <asp:Label ID="lblclientid" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" Text="Client ID :" runat="server">
                    </asp:Label>
                    <asp:Label ID="clientid" ForeColor="White" font-weight="600" font-family="Open Sans"
                        Font-Size="11px" runat="server"></asp:Label>
                </span>
            </div>
        </div>
        <div id="whitediv" class="div_curve_vargas">
            <div id="Divgrid1_final" class="divg1homenewpage div-scroll_vargas">
                <table>
                    <tr>
                        <td runat="server" id="hdsviewgrid_final" style="width: 550px;" align="left">
                        </td>
                    </tr>
                </table>
            </div>
            <div class="divg1_vargas">
                <asp:Label ID="label11_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                    ForeColor="Black" runat="server" Text="Chart"></asp:Label>
                <asp:DropDownList ID="chart_final" runat="server" CssClass="drpo_homenew">
                </asp:DropDownList>
                <asp:Label ID="label6_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                    ForeColor="Black" runat="server" Text="D.O.B \ D.O.Q" Style="display: none;"></asp:Label>
                <asp:TextBox ID="dasha_final" runat="server" CssClass="drpo_homenew" Style="display: none;"></asp:TextBox>
                <asp:Label ID="label7_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                    ForeColor="Black" runat="server" Text="Yogas" Style="display: none;"></asp:Label>
                <asp:DropDownList ID="dropyogas_final" runat="server" Style="display: none;" CssClass="drpo_homenew_new">
                </asp:DropDownList>
                <asp:Label ID="label2_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                    ForeColor="Black" runat="server" Text="Planet" Style="display: none;"></asp:Label>
                <asp:TextBox ID="planet_final" runat="server" Style="display: none;" CssClass="drpo_homenew_new"></asp:TextBox>
            </div>
            <div class="buttondiv">
                <div id="d3" runat="server" style="width: 559px; float: left; display: none;">
                    <asp:LinkButton ID="yogasbutton" runat="server" Style="width: 165px; height: 20px;"
                        class="per_btn_vargas">Calculate Horary Yogas</asp:LinkButton>
                    <asp:LinkButton ID="horarycombina" runat="server" Style="width: 165px; height: 20px;"
                        class="per_btn_vargas">Horary Combination</asp:LinkButton>
                </div>
                <div id="De" runat="server" style="text-align: center; margin-left: 50px;">
                    <asp:LinkButton ID="ImageButton1" runat="server" Style="width: 100px;" class="per_btn_vargas">Vargas Chart</asp:LinkButton>
                    <asp:LinkButton ID="ImageButton2" runat="server" Style="width: 100px;" class="per_btn_vargas">Save</asp:LinkButton>
                </div>
                <div id="d2" runat="server" style="display: none;">
                    <asp:LinkButton ID="ImageButton4" runat="server" Style="width: 100px;" class="per_btn_vargas">Remedials</asp:LinkButton>
                    <asp:LinkButton ID="D01" runat="server" Style="width: 100px;" class="per_btn_vargas">Show Predictive</asp:LinkButton>
                    <asp:LinkButton ID="yoga" runat="server" Style="width: 100px;" class="per_btn_vargas">Natal Yogas</asp:LinkButton>
                    <asp:LinkButton ID="astrocalc" runat="server" Style="width: 100px;" class="per_btn_vargas">Astro Cals</asp:LinkButton>
                </div>
            </div>
        </div>
        <div id="clinetnamediv_final" runat="server" class="div_name_id_div">
            <div style="margin-left: 5px;">
                <asp:Button ID="cross_final" runat="server" Text="X" CssClass="vargas_1" /></div>
            <asp:Label ID="Label12_final" ForeColor="Black" Text="Group Category" runat="server"
                Style="margin-left: 35px;"></asp:Label>
            <div style="margin-left: 35px;">
                <asp:DropDownList ID="cat_grp" runat="server" CssClass="drpo_homenew">
                    <asp:ListItem>Select Category</asp:ListItem>
                    <asp:ListItem>Natal</asp:ListItem>
                    <asp:ListItem>Horary</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Label ID="Label10_final" ForeColor="Black" Text="Enter group" runat="server"
                Style="margin-left: 35px;"></asp:Label>
            <div style="margin-left: 35px;">
                <asp:DropDownList ID="groupdrop_final" runat="server" CssClass="drpo_homenew">
                </asp:DropDownList>
            </div>
            <div style="margin-left: 35px;">
                <asp:Label ID="Label8_final" ForeColor="Black" Text="Enter Client ID" runat="server"></asp:Label>
                <asp:TextBox ID="clientidtextbox" runat="server"></asp:TextBox></div>
            <div class="vargas_2" style="margin-left: 35px;">
                <asp:Label ID="Label9_final" ForeColor="Black" Text="Enter Client Name" runat="server"></asp:Label>
                <asp:TextBox ID="clientnametextbox" runat="server"></asp:TextBox></div>
            <div class="vargas_3" style="margin-left: 35px;">
                <asp:LinkButton ID="cliidname" runat="server" Style="margin-left: 35px;" class="per_btn_vargas">Save</asp:LinkButton></div>
        </div>
        <div class="mar_div_chart">
            <div>
                <div style="float: left; width: 50%;">
                    <asp:Label ID="Label1d01" runat="server" ForeColor="Black" CssClass="varga_lbl">
                    </asp:Label>
                </div>
                <div class="columnd01" id="rashiidd01">
                    <div class="column-div1">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h1l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr1">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h1rd01" runat="server" Text="">
                            </asp:Label></span>
                    </div>
                    <div class="column-div2">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h2l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr2">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h2rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div3">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h3l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr3">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h3rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div4">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h4l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr4">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h4rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div5">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h5l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr5">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h5rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div6">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h6l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr6">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h6rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div7">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h7l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr7">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h7rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div8">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h8l1d01" runat="server" Text="">
                            </asp:Label></span>
                    </div>
                    <div class="column-divr8">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h8rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div9">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h9l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr9">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h9rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div10">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h10l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr10">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h10rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div11">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h11l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr11">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h11rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div12">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h12l1d01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divr12">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h12rd01" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <figure class="fixedratio"></figure>
                </div>
            </div>
            <div class="sec_varga">
                <div style="float: left;">
                    <asp:Label ID="Label1_final" runat="server" ForeColor="Black" CssClass="varga_lbl">
                    </asp:Label>
                </div>
                <div class="column" id="rashiid_final">
                    <div class="column-div1">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h1l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv1">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h1r_final" runat="server" Text="">
                            </asp:Label></span>
                    </div>
                    <div class="column-div2">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h2l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv2">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h2r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div3">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h3l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv3">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h3r_final" runat="server" Text="">
                            </asp:Label></span>
                    </div>
                    <div class="column-div4">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h4l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv4">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h4r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div5">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h5l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv5">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h5r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div6">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h6l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv6">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h6r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div7">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h7l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv7">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h7r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div8">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h8l1_final" runat="server" Text="">
                            </asp:Label></span>
                    </div>
                    <div class="column-divrv8">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h8r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div9">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h9l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv9">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h9r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div10">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h10l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv10">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h10r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div11">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h11l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv11">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h11r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-div12">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h12l1_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <div class="column-divrv12">
                        <span style="font-size: 11px;">
                            <asp:Label ID="h12r_final" runat="server" Text="">
                            </asp:Label>
                        </span>
                    </div>
                    <figure class="fixedratio"></figure>
                </div>
            </div>
        </div>
    </div>
    <input type="hidden" runat="server" id="Hiddencons" />
    <input type="hidden" runat="server" id="Hidden1" />
    <input type="hidden" runat="server" id="Hidden5" />
    <input type="hidden" runat="server" id="Hidden2" />
    <input type="hidden" runat="server" id="Hidden3" />
    <input type="hidden" runat="server" id="Hidden5d01" />
    <input type="hidden" runat="server" id="hdncountry" />
    <input type="hidden" runat="server" id="hdnsex" />
    <input type="hidden" runat="server" id="hdnmobile" />
    <input type="hidden" runat="server" id="hdnlongit" />
    <input type="hidden" runat="server" id="hdnlatit" />
    <input type="hidden" runat="server" id="hddayofbirth" />
    <input type="hidden" runat="server" id="hdrashi" />
    <input type="hidden" runat="server" id="hdconstellation" />
    <input type="hidden" runat="server" id="hdndayduration" />
    <input type="hidden" runat="server" id="hdnnightduration" />
    <input type="hidden" runat="server" id="hdnbalancedasha" />
    <input type="hidden" runat="server" id="CVal" />
    <input type="hidden" runat="server" id="BalanceDashaVal" />
    <input type="hidden" runat="server" id="hdnclientemailid" />
    <input type="hidden" runat="server" id="hdncartid" />
    <input type="hidden" runat="server" id="Hs" />
    <input type="hidden" runat="server" id="Hm" />
    <input type="hidden" runat="server" id="Hv" />
    <input type="hidden" runat="server" id="hdncountrycode" />
    </form>
</body>
</html>
