<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_album.aspx.cs" Inherits="add_album" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Albums</title>
    <link type="text/css" rel="stylesheet" href="CSS/index.css" />
    <link type="text/css" rel="stylesheet" href="CSS/mystyle.css" />

    <script language="javascript" type="text/javascript">
        function ajaxFileUploadAttachments_ClientUploadComplete(sender, e) {
            if (sender._filesInQueue[sender._filesInQueue.length - 1]._isUploaded)
                __doPostBack('updatePanelAttachments', ''); // Do post back only after all files have been uploaded
        }
        function updatedata() {
            if ((document.getElementById('ddluser').value == "--Select User--") || (document.getElementById('ddluser').value == "0")) {
                alert('Please select User.');
                document.getElementById('ddluser').focus();
                return false;
            }
            else if ((document.getElementById('ddlgroup').value == "--Select Group--") && (document.getElementById('ddlgroup').value == "0")) {
                alert("Please select Group.");
                document.getElementById('ddlgroup').focus();
                return false;
            }
            else if ((document.getElementById('ddlstatus').value == "--Select--") && (document.getElementById('ddlstatus').value == "0")) {
                alert("Please select Status.");
                document.getElementById('ddlstatus').focus();
                return false;
            }
            else if ((document.getElementById('ddllang').value == "--Select--") && (document.getElementById('ddllang').value == "0")) {
                alert("Please select Language.");
                document.getElementById('ddllang').focus();
                return false;
            }
            else if ((document.getElementById('txtalbumname').value != "") && (document.getElementById('ddlalbums').value != "0")) {
                alert("Please select Album Name or Enter a news Album Name");
                document.getElementById('txtalbumname').focus();
                return false;
            }
            else {

                var userid = document.getElementById('ddluser').value;
                var groupid = document.getElementById('ddlgroup').value;
                var albumname = document.getElementById('txtalbumname').value;
                var keywords = document.getElementById('txtkeywords').value;
                var desc = document.getElementById('txtdescription').value;
                var crtdby = document.getElementById('hdncrtdby').value;
                var status = document.getElementById('ddlstatus').value;
                var priority = document.getElementById('ddlpriority').value;
                var langid = document.getElementById('ddllang').value;
                var catid = "0";

                if (document.getElementById('txtalbumname').value != "") {
                    PageMethods.Save_Album(catid, albumname,keywords,desc,crtdby,status,priority,groupid,userid,langid, onSucceeded1, onFailed1);
                    return false;
                }
                else {
                    var albumid = document.getElementById('ddlalbums').value;
                    onSucceeded1(albumid);
                    return false;
                }

                return false;
            }
        }
        function onFailed1(error) {

            alert(error.get_message());
            return false;
        }
        function onSucceeded1(result) {
            var albumid = result;
            for (var i = 0; i < document.getElementById('divRepeater').children.length; i++) {
                var inPutNodes = document.getElementById('divRepeater').children[i].getElementsByTagName('input');
                var txtID = inPutNodes[2].value;
                var thumbimg = inPutNodes[3].value;
                var largeimg = inPutNodes[4].value;
                if (inPutNodes[1].checked == true) {
                    PageMethods.Update_AlbumGallery(albumid,"0","", thumbimg, largeimg,"ALBUM");
                }
                inPutNodes = document.getElementById('divRepeater').children[i].getElementsByTagName('textarea');
                var txtHead = inPutNodes[0].value;
                PageMethods.Update_AlbumGallery(albumid,txtID,txtHead, thumbimg, largeimg,"GALLERY");
            }
            alert('Album added successfully');
            window.location.href = 'add_album.aspx';
            return false;
        }

        function SelectSingleRadiobutton(rdbtnid) {
            var rdBtn = document.getElementById(rdbtnid);
            var rdBtnList = document.getElementsByTagName("input");
            for (i = 0; i < rdBtnList.length; i++) {
                if (rdBtnList[i].type == "checkbox" && rdBtnList[i].id != rdBtn.id) {
                    rdBtnList[i].checked = false;
                }
            }
        }
    </script>

    <style type="text/css">
        .headercss
        {
            color: #146295;
            font-weight: normal;
            font-size: 12px;
        }
        .rptchkboxcss
        {
            float: left;
            width: 20px;
            margin: -2px 0px 0px 0px;
            padding: 0px;
        }
        .rptchkboxcss input
        {
            width: 20px;
            height: 20px;
            background-color: Red;
        }
    </style>
</head>
<body style="margin: 0px auto; width: 1000px;">
    <form id="form1" runat="server">
    <asp:Panel ID="pan1" runat="server" Height="1003px" ScrollBars="none">
        <ajaxToolkit:ToolkitScriptManager runat="Server" CombineScripts="false" EnablePartialRendering="true" EnablePageMethods="true"
            ID="ScriptManager1" />
        <asp:UpdatePanel ID="updatePanelAttachments" runat="server" OnLoad="updatePanelAttachments_Load"
            UpdateMode="Conditional">
            <ContentTemplate>
                <div class="maincontainer">
                    <uc1:header ID="header1" runat="server" />
                    <div class="middlecontainer">
                        <fieldset class="registrationmain" style="margin: 0em; width: 100%;">
                            <table style="width: 98%;" cellspacing="5" cellpadding="5" class="registrationtable">
                                <tr>
                                    <td class="td_first">
                                        Language:<font class="star"> *</font>
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddllang" runat="server" AutoPostBack="true" Width="200px" CssClass="registrationdropdown">
                                            <asp:ListItem Value="0" Text="--Select Language--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="ENGLISH"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="HINDI"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        User:<font class="star"> *</font>
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddluser" runat="server" AutoPostBack="true" Width="200px" CssClass="registrationdropdown">
                                            <asp:ListItem Value="0" Text="--Select User--"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="ASTROLOGER"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="END USER"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="BOTH"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Group:<font class="star"> *</font>
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddlgroup" runat="server" AutoPostBack="true" Width="200px"
                                            CssClass="registrationdropdown">
                                            <asp:ListItem Value="0" Text="--Select Group--"></asp:ListItem>
                                            <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                            <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                            <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Albums:<font class="star"> *</font>
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddlalbums" runat="server" AutoPostBack="true" Width="200px"
                                            CssClass="registrationdropdown">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Album Name:<font class="star">*</font>
                                    </td>
                                    <td class="td_second">
                                        <asp:TextBox ID="txtalbumname" runat="server" Width="90%" CssClass="registrationtextbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Keywords:
                                    </td>
                                    <td class="td_second">
                                        <asp:TextBox ID="txtkeywords" runat="server" Width="90%" CssClass="registrationtextbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Description:
                                    </td>
                                    <td class="td_second">
                                        <asp:TextBox ID="txtdescription" TextMode="MultiLine" Height="70px" runat="server"
                                            Width="90%" CssClass="registrationtextbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Status:
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddlstatus" runat="server" AutoPostBack="true" Width="100px"
                                            CssClass="registrationdropdown">
                                            <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="A" Text="Publish" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="Unpublish"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="td_first">
                                        Priority:
                                    </td>
                                    <td class="td_second">
                                        <asp:DropDownList ID="ddlpriority" runat="server" AutoPostBack="true" Width="100px"
                                            CssClass="registrationdropdown">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr id="submitid" runat="server">
                                    <td class="td_first">
                                    </td>
                                    <td class="td_second">
                                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" ValidationGroup="vgsubmit"
                                            CssClass="loginbtncss" OnClick="btnsubmit_Click" OnClientClick="javascript:return updatedata();" />
                                    </td>
                                </tr>
                               <%-- <tr id="updateid" runat="server">
                                    <td class="td_first">
                                    </td>
                                    <td class="td_second">
                                        <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="loginbtncss" OnClick="btnupdate_Click" />
                                    </td>
                                </tr>--%>
                                <tr>
                                    <td colspan="2">
                                        <ajaxToolkit:AjaxFileUpload ID="ajaxFileUploadAttachments" runat="server" OnUploadComplete="ajaxFileUploadAttachments_UploadComplete"
                                            OnClientUploadComplete="ajaxFileUploadAttachments_ClientUploadComplete" />
                                        <br />
                                        <asp:Image Visible="false" ID="imgLoad" runat="server" ImageUrl="Image/loading.gif" />
                                        <asp:Label ID="lblmsg" runat="server" EnableTheming="true" EnableViewState="true"></asp:Label>
                                        <div style="float: left; width: 100%;" id="divRepeater">
                                            <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound"
                                                OnItemCommand="Repeater1_ItemCommand">
                                                <ItemTemplate>
                                                    <div style="float: left; box-shadow: 3px 3px 3px #666666; text-align: center; width: 200px;
                                                        height: 300px; margin: 5px; padding: 5px; border-radius: 8px; border: 4px solid #999999;">
                                                        <div class="headercss" style="float: left; width: 80px;">
                                                            Priority&nbsp;<asp:TextBox ID="gallery_prio" runat="server" Width="20px" Text='<%# Bind("GALL_ID")%>'></asp:TextBox>
                                                        </div>
                                                        <div class="headercss" style="float: left; width: 30px;">
                                                            <asp:CheckBox ID="chkalbum" CssClass="rptchkboxcss" runat="server" OnClick="javascript:SelectSingleRadiobutton(this.id)" />
                                                        </div>
                                                        <div class="headercss" style="float: left; width: 40px;">
                                                            <asp:LinkButton ID="btnDeleteComment" runat="server" CommandName="Delete" CommandArgument='<%# Bind("GALL_ID")%>'>
                                                                <asp:Image ID="Image1" runat="server" ImageUrl="Image/deleteimg.png" />
                                                            </asp:LinkButton>
                                                        </div>
                                                        <asp:Image ID="img1" runat="server" Style="width: 190px; margin: 5px 0px 10px 0px;
                                                            box-shadow: 6px 6px 5px #888888; height: 150px; border-radius: 10px;"></asp:Image>
                                                        <asp:TextBox ID="TextBox1" TextMode="MultiLine" Width="190px" Height="100px" runat="server"
                                                            BorderStyle="Solid" Text='<%# Bind("CAPTION")%>'></asp:TextBox>
                                                        <asp:HiddenField ID="lblid" runat="server" Value='<%# Bind("GALL_ID")%>' />
                                                        <asp:HiddenField ID="lblthumbimg" runat="server" Value='<%# Bind("THUMB_IMG")%>' />
                                                        <asp:HiddenField ID="lbllargeimg" runat="server" Value='<%# Bind("LARGE_IMG")%>' />
                                                    </div>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </div>
                    <%--<uc2:footer ID="footer1" runat="server" />--%>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="ajaxFileUploadAttachments" />
            </Triggers>
        </asp:UpdatePanel>
    </asp:Panel>
    <input type="hidden" id="hdncrtdby" runat="server" />
    <input type="hidden" id="hdnmaxgallid" runat="server" />
    
     <script language="javascript" type="text/javascript">
                                    Sys.Extended.UI.AjaxFileUpload.WebForm_OnSubmit = function() {
                                        /// <summary>
                                        /// Wraps ASP.NET's WebForm_OnSubmit in order to remove/disable input file controls prior to submission
                                        /// </summary>
                                        /// <returns type='Boolean'>
                                        /// Result of original WebForm_OnSubmit
                                        /// </returns>
                                        var result = Sys.Extended.UI.AjaxFileUpload._originalWebForm_OnSubmit();
                                        if (result) {
                                            // NEW LINE ADDED
                                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(Sys.Extended.UI.AjaxFileUpload.WebForm_OnSubmitBack);
                                            // END NEW LINE ADDED
                                            var components = Sys.Application.getComponents();
                                            for (var i = 0; i < components.length; i++) {
                                                var component = components[i];
                                                if (Sys.Extended.UI.AjaxFileUpload.isInstanceOfType(component)) {
                                                    component._html5InputFile.disabled = 'disabled';
                                                    component._inputFileElement.disabled = 'disabled';
                                                }
                                            }
                                        }
                                        return result;
                                    };
                                    // MY NEW FUNCTION
                                    Sys.Extended.UI.AjaxFileUpload.WebForm_OnSubmitBack = function() {
                                        Sys.WebForms.PageRequestManager.getInstance().remove_endRequest(Sys.Extended.UI.AjaxFileUpload.WebForm_OnSubmitBack);
                                        var components = Sys.Application.getComponents();
                                        for (var i = 0; i < components.length; i++) {
                                            var component = components[i];
                                            if (Sys.Extended.UI.AjaxFileUpload.isInstanceOfType(component)) {
                                                component._html5InputFile.disabled = '';
                                                component._inputFileElement.disabled = '';
                                            }
                                        }
                                    };
                                    // END MY NEW FUNCTION
                                </script>
                                
    </form>
</body>
</html>
