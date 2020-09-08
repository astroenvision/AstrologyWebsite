<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astro_client.aspx.cs" Inherits="astro_client"
    EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision</title>
    <%-- <meta content="Astrology" charset="utf-8" />--%>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css" />
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
    <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <%--<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans" />
    <link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet"
        type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz" />--%>

    <%--<script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/files/css3-mediaqueries.js"></script>--%>

    <%--<script src="http://html5shim.googlecode.com/svn/trunk/html5.js" type="text/javascript"></script>--%>

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    
    <script type="text/javascript" language="javascript" src="javascript/astrologer.js"></script>

    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>

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

    <script type="text/javascript" language="javascript">
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
    </script>

    <script type="text/javascript">
        var popUpWin = 0;

        function getopen1(pagename)
        {
        window.parent.location.href="login.aspx";
        }
        function getopen(pagename)
        {
        if(popUpWin)
               {
                    if(!popUpWin.closed) popUpWin.close();
               }
	        //popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no');
	        popUpWin = window.open(''+ pagename +'',null);
        }
    </script>

</head>
<body id="body" onload="accountuser();">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" AsyncPostBackTimeout="6000">
    </asp:ScriptManager>
    <div class="maincontainer">
        <%--Start Deepak comment following line on 19/06/2020--%>
         <%--<uc1:header ID="header1" runat="server" />
         <uc4:horarymenubar ID="horarymenubar1" runat="server" />--%>
        <%--End Deepak comment following line on 19/06/2020--%>
        <div class="middlecontainer">
            <div class="middlecontainer_left">
               <%-- <uc3:menubar ID="menubar1" runat="server" />--%>
            </div>
            <div class="middlecontainer_right" style="width:99%;">
                <div id="list_state" style="position: absolute; top: 0px; left: 0px; border: none;
                    display: none; z-index: 2; margin-top: 23px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:ListBox ID="state_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                                        </asp:ListBox>
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
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
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
                                        <asp:ListBox ID="city_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                                        </asp:ListBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="mid_body_new">
                    <div class="mid_seca_new">
                        <div class="mid_over1">
                         <h3 class="mid_over1h3"><%--Query Details--%> Create New Chart</h3>
                            <fieldset class="fieldsetcss">
                                <div>
                                    <table cellspacing="5" cellpadding="5">
                                        <tr>
                                            <td>
                                                Category Name <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:DropDownList ID="DropDownList2" runat="server" Width="59%" CssClass="DropDownbox">
                                                    <asp:ListItem>Select Category</asp:ListItem>
                                                    <asp:ListItem Value="NATAL">Natal</asp:ListItem>
                                                    <asp:ListItem Value="HORARY">Horary</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr> 
                                        <tr>
                                            <td>
                                                Name <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="cl_name" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td id="dobid" runat="server">
                                                D.O.B / D.O.Q <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="dob" runat="server" Width="56%" Height="35px" Enabled="true" PlaceHolder="DD/MM/YYYY" CssClass="textbox"></asp:TextBox>
                                                <img id="cal" runat="server" src='Image/cal1.png' onclick="popUpCalendar(this, form1.dob,'dd/mm/yyyy',event)"
                                                    alt="" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td id="tobid" runat="server">
                                                T.O.B / T.O.Q <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:DropDownList ID="hob" runat="server" Width="29%" CssClass="DropDownboxtime">
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
                                                <asp:DropDownList ID="mob" runat="server" Width="29%" CssClass="DropDownboxtime">
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
                                                <asp:DropDownList ID="ddlcunt" runat="server" Width="59%" CssClass="DropDownbox" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                State <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="ddlstat" runat="server" Width="58%" Height="35px" CssClass="textbox" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="display: none;" id="dis" runat="server">
                                                District<font class="star"> *</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="district" runat="server" Style="display: none;" Width="58%" CssClass="textbox" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td id="pobid" runat="server">
                                                 P.O.B / P.O.Q:<font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="city" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Email Id <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="txtmail" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Contact Number
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="mn" runat="server" Width="58%" Height="35px" CssClass="textbox"
                                                    MaxLength="10"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Profession
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="cl_pro" runat="server" Width="58%" Height="35px" 
                                                    CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Sex
                                            </td>
                                            <td  class="latter" style="background: #F2F2F2; margin: 0px 0px 0px 4px; border-radius: 5px;
                                                color: #333333; font-family: Open Sans; width: 180px; float: left">
                                                <asp:RadioButton ID="female" value="F" Text="Female" CssClass="gendercss" runat="server" />
                                                <asp:RadioButton ID="male" value="M" Text="Male" CssClass="gendercss" runat="server"
                                                    Checked="true" />
                                                     <%--<asp:ListItem Value = "M" Selected  ="True">Male</asp:ListItem>
                                                    <asp:ListItem Value = "F">Female</asp:ListItem>
                                                    </asp:RadioButtonList>--%>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Group Name <font class="star">*</font>
                                            </td>
                                            <td class="latter">
                                                <asp:DropDownList ID="cat" runat="server" Width="69%" CssClass="DropDownbox">
                                                </asp:DropDownList>
                                            </td>
                                            <%--<td class="latter">
                                                <asp:TextBox ID="catn" runat="server" Width="58%" Height="35px" placeholder="Enter Group Name"
                                                    CssClass="textbox" Style="display: none;"></asp:TextBox>
                                            </td>--%>
                                        </tr>
                                        <tr id="catn_newgroup" runat="server" style="display: none;">
                                            <td>
                                                Enter Group Name <font class="star">*</font>
                                            </td>
                                            <td class="latter"  colspan="2">
                                               <asp:TextBox ID="catn" runat="server" Width="58%" Height="35px" placeholder="Enter Group Name"
                                                    CssClass="textbox" Style="display: none;"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Latitude<font class="star"> *</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="lat" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Longitude<font class="star"> *</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="lng" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Time Zone<font class="star"> *</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="tz" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Querist's Query
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="txtquery" runat="server" Width="58%" Height="70px" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="display: none;">
                                                Age<font class="star"> *</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="cl_age" Style="display: none;" runat="server" Width="70%" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td colspan="2">
                                                <asp:LinkButton ID="logout" runat="server" class="per_btn">Update</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr class="mid_over1_border">
                                            <td colspan="3" class="mid_over1_border_td">
                                                <asp:LinkButton ID="submit" runat="server" class="per_btn_new" Style="margin-left: 0px">Calculate Chart</asp:LinkButton>
                                                &nbsp;
                                                <asp:LinkButton ID="moc" runat="server" class="per_btn_new" Style="margin-left: 0px">Enter Manual Chart</asp:LinkButton>
                                                &nbsp;
                                                <asp:LinkButton ID="pqh" runat="server" class="per_btn_new" Style="margin-left: 0px; display:none;">Probable Query</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td colspan="2">
                                                <asp:ImageButton ID="Button1" Text="View Horoscope" runat="server" OnClick="horoscope_Click"
                                                    ImageUrl="~/Image/viewhoroscope.png" Style="visibility: hidden" />
                                            </td>
                                        </tr>
                                    </table>
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
        <%--Start Deepak comment following line on 19/06/2020--%>
        <%--<uc2:footer ID="footer1" runat="server" />--%>
        <%--End Deepak comment following line on 19/06/2020--%>
    </div>
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
    </form>
</body>
</html>
