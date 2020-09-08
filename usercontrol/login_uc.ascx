<%@ Control Language="C#" AutoEventWireup="true" CodeFile="login_uc.ascx.cs" Inherits="usercontrol_login_uc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1_login" %>
    <style type="text/css">
        /* login Styles */
.LogInDiv{background: white;float: left;margin: 8px;}
.black_overlay{display: none;position: fixed;top: 0%;left: 0%;width: 100%;height: 100%;background-color:gray;z-index: 1001;-moz-opacity: 0.8;opacity: .80;filter: alpha(opacity=80);}
.white_content{display: none;position: fixed;top: 25%;left: 28%;width:40%;height: auto;padding: 0px;background-color: white;z-index: 1002;overflow: no;background:#333 transparent;background:rgba(51,51,51,0.3);filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#4C333333',endColorstr='#4C333333');-ms-filter:"progid:DXImageTransform.Microsoft.gradient(startColorstr=#4C333333, endColorstr=#4C333333)"}
.white_content_rate{width: 250px;text-align: center;background-color: #e5e5e5;border: solid 1px gray;display: none;position: fixed;top: 35%;left: 40%;height: auto;border: 5px solid black;background-color: white;z-index: 1002;overflow: no;}
.loginLeft{float: left; width:55%;font:0.8em Tahoma;}

    </style>
    
    <script language="javascript" type="text/javascript">
        var flgCtrl = "";
        function showGDiv(id1) {


            flgCtrl = 'login';
            document.getElementById("txtemail").value = "";
            document.getElementById("txtpwd").value = "";
            document.getElementById('light').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
            document.getElementById(id1).style.display = 'block';
        }
        function showGDiv_Change(id2) {
            flgCtrl = 'Change';
            document.getElementById("email").value = "";
            document.getElementById("pass").value = "";
            document.getElementById("re_newpass").value = "";
            document.getElementById('change_pass').style.display = 'block';
            document.getElementById(id2).style.display = 'block';

        }
        function LTrim(value) {

            var re = /\s*((\S+\s*)*)/;
            return value.replace(re, "$1");

        }
        function RTrim(value) {

            var re = /((\s*\S+)*)\s*/;
            return value.replace(re, "$1");
        }
        function trim(value) {

            return LTrim(RTrim(value));
        }
        function vldChk(iid) {
            if (trim(document.getElementById(iid).value) == "") {
                alert('Please enter keyword to search!');
                return false;
            }
            else {
                return true;
            }
        }              
</script>

<asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="true" ScriptMode="release">
    </asp:ScriptManager>
    <div>
        <a style="cursor: pointer;" onclick="showGDiv('divComnt');">Login </a>
        <!-- Top MENU END here-->
        <div id="login_panel">
            <div id="UpdatePanel2">
                <div id="light" class="white_content">
                    <div class="LogInDiv" id="divComnt">
                        <div style="float: left; padding: 1%; width: 100%;">
                            <ul style="margin: 0%; padding: 0%; list-style-type: none;">
                                <li style="float: left; width: 95%; font-weight: bold;">USER LOGIN</li>
                                <li style="float: left; width: 3%;"><a href="javascript:void(0)" onclick="document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none';flgCtrl = '';">
                                    <%--<img src="images/close_btn.gif" style="border: 0px;" title="Close" alt="Close" />--%></a></li>
                            </ul>
                        </div>
                        <div style="width: 100%;">
                            <ul style="float: left; width: 100%; margin: 0%; padding: 0%;">
                                <li style="display: inline; float: left; width: 100%; border-bottom: 2pt solid rgb(225, 225, 225);">
                                </li>
                            </ul>
                        </div>
                        <div class="loginLeft">
                            <ul style="float: left; margin: 0%; padding: 1%; list-style-type: none;">
                                <li style="float: left;">
                                    <div style="float: left; width: 25%; padding: 2%;">
                                        Email</div>
                                    <div style="width: 52%; float: left; padding: 2%;">
                                        <asp:TextBox ValidationGroup="group1" ID="txtemail" runat="server" Width="100%" onkeypress="javascript:Submitform(event,'login');"></asp:TextBox>
                                    </div>
                                    <div style="float: left; width: 100%;">
                                    </div>
                                    <div style="float: left; width: 25%; padding: 2%;">
                                        Password</div>
                                    <div style="width: 52%; float: left; padding: 2%;">
                                        <asp:TextBox ValidationGroup="group1" ID="txtpwd" runat="server" Width="100%" TextMode="Password"
                                        onkeypress="javascript:Submitform(event,'login');"></asp:TextBox>
                                    </div>
                                </li>
                            </ul>
                            <div style="float: left; text-align: center; padding-left: 30%;">
                                <asp:Button ValidationGroup="group1" ID="btnSubmit" runat="server" CssClass="btn"
                                Text="Submit" OnClick="btnSubmit_Click" />
                            </div>
                            <div style="float: left; padding: 0% 7%">
                            
                                <asp:RequiredFieldValidator ValidationGroup="group1" ControlToValidate="txtemail"
                                SetFocusOnError="true" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Fill"
                                Font-Names="verdana" Font-Bold="True" Font-Size="11px"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ValidationGroup="group1" ControlToValidate="txtemail"
                                SetFocusOnError="true" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Valid email id."
                                Font-Names="verdana" Font-Bold="True" Font-Size="11px" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
                            <asp:RequiredFieldValidator ValidationGroup="group1" ControlToValidate="txtpwd" SetFocusOnError="true"
                                ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Fill" Font-Names="verdana"
                                Font-Bold="True" Font-Size="11px"></asp:RequiredFieldValidator>
                                
                            </div>
                            <div>
                                <div id="ctl00_menu1_UpdateProgress1" style="display: none;">
                                    <div style="float: left; width: 100%; text-align: center;">
                                        <h3>
                                            Please wait…</h3>
                                        <%--<img src="images/loading.gif" alt="Please wait…" />--%>
                                    </div>
                                </div>
                            </div>
                            <ul style="float: left; width: 100%; margin: 0%; padding-left: 2%; list-style-type: none;
                                font-size: 0.9em;">
                                <li style="float: left; padding-right: 1%;">Don't have an account? </li>
                                <li style="float: left; color: #7A9C00; font-weight: bold; cursor: pointer;" runat="server"
                                id="changepass" onclick="showGDiv_Change('div2');">Create One! </li>
                            </ul>
                            <div style="font-family: Tahoma; font-size: 0.9em; padding: 1.6%; float: left; cursor: pointer;">
                                Change Password
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
