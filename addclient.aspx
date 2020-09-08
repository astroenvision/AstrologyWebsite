<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addclient.aspx.cs" Inherits="addclient"
    EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header_astro.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%--<%@ Register Src="~/usercontrol/menu_bar.ascx" TagName="menubar" TagPrefix="uc3" %>--%>
<%@ Register Src="~/usercontrol/horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc4" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology, Online Consultancy, Prashna, Horary Astrology | Astro Envision
    </title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css" />
    <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />
    <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />

    <script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <script type="text/javascript" language="javascript" src="javascript/addclient.js"></script>

    <script language="javascript" src="javascript/popupcalenderlead.js" type="text/javascript"></script>

    <script src="javascript/prototype.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        var popUpWin = 0;
        function getopen(pagename)
        {
          if(popUpWin)
           {
                if(!popUpWin.closed) popUpWin.close();
           }
	        //popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')
	       popUpWin = window.open(''+ pagename +'',null);
        }
        function getopen1(pagename)
        {
           window.parent.location.href="login.aspx";
        }
    </script>

</head>
<body id="body" onload="accountuser();">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <uc4:horarymenubar ID="horarymenubar1" runat="server" />
        <div class="middlecontainer">
            <div class="middlecontainer_left">
                <%--<uc3:menubar ID="menubar1" runat="server" />--%>
            </div>
            <div class="middlecontainer_right" style="width: 99%;">
                <div id="list_state" style="position: absolute; top: 0px; left: 0px; border: none;
                    display: none; z-index: 2; margin-top: 23px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>--%>
                                        <asp:ListBox ID="state_list" Width="300px" Height="100px" runat="server" CssClass="btextlist121">
                                        </asp:ListBox>
                                   <%-- </ContentTemplate>
                                </asp:UpdatePanel>--%>
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
                            <h3 class="mid_over1h3">
                                Query Details</h3>
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
                                                    <asp:ListItem>Natal</asp:ListItem>
                                                    <asp:ListItem>Horary</asp:ListItem>
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
                                                <asp:TextBox ID="dob" runat="server" Width="56%" Height="35px" Enabled="true" PlaceHolder="DD/MM/YYYY"
                                                    CssClass="textbox"></asp:TextBox>
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
                                                <asp:DropDownList ID="ddlcunt" runat="server" Width="59%" CssClass="DropDownbox" onchange="bind_ddl_states(this);" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                State <font class="star">*</font>
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="ddlstat" runat="server" Width="58%" Height="35px" CssClass="textbox" style="display:none;" />
                                                <asp:DropDownList ID="ddlstates" runat="server" Width="59%" CssClass="DropDownbox" onchange="bind_ddl_cities(this);"></asp:DropDownList> 
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
                                                <asp:TextBox ID="city" runat="server" Width="58%" Height="35px" CssClass="textbox" style="display:none;"></asp:TextBox>
                                                <asp:DropDownList ID="ddlcities" runat="server" Width="59%" CssClass="DropDownbox"></asp:DropDownList> 
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
                                                <asp:TextBox ID="cl_pro" runat="server" Width="58%" Height="35px" CssClass="textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Sex
                                            </td>
                                            <td class="latter" style="background: #F2F2F2; margin: 0px 0px 0px 4px; border-radius: 5px;
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
                                            <td class="latter" colspan="2">
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
                                                Querist's Query <br />for your reference
                                            </td>
                                            <td class="latter" colspan="2">
                                                <asp:TextBox ID="txtquery" runat="server" Width="58%" Height="70px" TextMode="MultiLine"
                                                    CssClass="textbox"></asp:TextBox>
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
                                                <asp:LinkButton ID="pqh" runat="server" class="per_btn_new" Style="margin-left: 0px;
                                                    display: none;">Probable Query</asp:LinkButton>
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
        <uc2:footer ID="footer1" runat="server" />
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
    <%--Second Page Code Start Here--%>
    <div style="float: left; width: 40%; display: block;" id="make_astroclient_chartid"
        runat="server">
        <div id="Divgrid1_astroclient" class="divg1homenewpage">
            <table>
                <tr>
                    <td runat="server" id="hdsviewgrid_astroclient" style="width: 520px;" align="left">
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
    <div class="column1ho" id="rashiid" style="display: none;">
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
    
            <input type="hidden" runat="server" id="Hidden4" />
            <input type="hidden" runat="server" id="hidden1" />
            <input type="hidden" runat="server" id="Hidden2" />
            <input type="hidden" runat="server" id="hdnastid" />
            <input type="hidden" runat="server" id="hdnclientid" />
            <input type="hidden" runat="server" id="Hclmail" />
            <input type="hidden" runat="server" id="Hclname" />
            <input type="hidden" runat="server" id="SPHastmail" />
            <input type="hidden" runat="server" id="SPHastname" />
            <input type="hidden" runat="server" id="Hnewdiffm" />
            <input type="hidden" runat="server" id="Hnewdiffm1" />
            <input type="hidden" runat="server" id="Hnewdiffv" />
            <input type="hidden" runat="server" id="Hnewdiffv1" />
            <input type="hidden" runat="server" id="SPhdngroup" />
            <input type="hidden" runat="server" id="hdngroup_u" />
            <input type="hidden" runat="server" id="hdnmobile" />
            <input type="hidden" runat="server" id="hdndob" />
            <input type="hidden" runat="server" id="hdnidob" />
            <input type="hidden" runat="server" id="hdnimoob" />
            <input type="hidden" runat="server" id="hdniyob" />
            <input type="hidden" runat="server" id="hdntob" />
            <input type="hidden" runat="server" id="hdnihob" />
            <input type="hidden" runat="server" id="hdnimob" />
            <input type="hidden" runat="server" id="hdncountry" />
            <input type="hidden" runat="server" id="SPhdnstate" />
            <input type="hidden" runat="server" id="SPhdndist" />
            <input type="hidden" runat="server" id="SPhdncity" />
            <input type="hidden" runat="server" id="hdnlatit" />
            <input type="hidden" runat="server" id="hdnlongit" />
            <input type="hidden" runat="server" id="hdntzo" />
            <input type="hidden" runat="server" id="SPhdnprof" />
            <input type="hidden" runat="server" id="hdnsex" />
            <input type="hidden" runat="server" id="hdncd" />
            <input type="hidden" runat="server" id="SPhdnuser" />
            <input type="hidden" runat="server" id="hdnasc" />
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
            <input type="hidden" runat="server" id="hdnmoc" />
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
            <input type="hidden" runat="server" id="hdnrr1" />
            <input type="hidden" runat="server" id="hdnrr2" />
            <input type="hidden" runat="server" id="hdnrr3" />
            <input type="hidden" runat="server" id="hdnrr4" />
            <input type="hidden" runat="server" id="hdnrr5" />
            <input type="hidden" runat="server" id="hdnrr6" />
            <input type="hidden" runat="server" id="hdnrr7" />
            <input type="hidden" runat="server" id="hdnrr8" />
            <input type="hidden" runat="server" id="hdnrr9" />
            <input type="hidden" runat="server" id="hdnrr10" />
            <input type="hidden" runat="server" id="hdnprevret1" />
            <input type="hidden" runat="server" id="hdnprevret2" />
            <input type="hidden" runat="server" id="hdnprevret3" />
            <input type="hidden" runat="server" id="hdnprevret4" />
            <input type="hidden" runat="server" id="hdnprevret5" />
            <input type="hidden" runat="server" id="hdnprevret6" />
            <input type="hidden" runat="server" id="hdnprevret7" />
            <input type="hidden" runat="server" id="hdnprevret8" />
            <input type="hidden" runat="server" id="hdnprevret9" />
            <input type="hidden" runat="server" id="hdnprevret10" />
            <input type="hidden" runat="server" id="SPhdsunsetpre" />
            <input type="hidden" runat="server" id="SPhdsunrise" />
            <input type="hidden" runat="server" id="SPhdsunset" />
            <input type="hidden" runat="server" id="SPhdsunrisenext" />
            <input type="hidden" runat="server" id="SPhdnastmail" />
            <input type="hidden" runat="server" id="hdgulikatime" />
            <input type="hidden" runat="server" id="gulikaval" />
            <input type="hidden" runat="server" id="hdntzval" />
            <input type="hidden" runat="server" id="hdnquery" />
            
            
            
             <input type="hidden" runat="server" id="finalnextpageurl" />
            
    <%--Second Page Code End Here--%>
    </form>
</body>
</html>
