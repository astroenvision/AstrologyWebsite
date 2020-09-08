<%@ Page Language="C#" AutoEventWireup="true" CodeFile="compatibility_matching.aspx.cs" Inherits="compatibility_matching" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Compatibility Matching | Astro Envision</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="css/compatibilitymatching.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="capMtch">Capability Match</div>
        <div class="capCont">
            <div class="capradioDv">
                <div class="capradio">
                    <label class="radioDv radioDvmrg">
                        <span class="radioDvLt">You want a matching for a Boy</span>
                        <input type="radio" name="optradio" class="radioDvRt" /></label>
                    <label class="radioDv">
                        <span class="radioDvLt">You want a matching for a Girl</span>
                        <input type="radio" name="optradio" class="radioDvRt" /></label>
                </div>
            </div>
            <div class="capBy">Boy Detail</div>

            <div class="capTable-responsive">
                <%--<table class="capTable">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Date Of Birth</th>
                            <th>Time Of Birth</th>
                            <th>Place Of Birth</th>
                            <th colspan="2" class="capCenter">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Anna</td>
                            <td>1/6/1990</td>
                            <td>11:00</td>
                            <td>Delhi</td>
                            <td class="capCenter">Edit</td>
                            <td class="capCenter">Delete</td>
                        </tr>
                    </tbody>
                </table>--%>
                <asp:GridView runat="server" ID="gridfirst" AllowPaging="false"
                     AutoGenerateColumns="false">
                    <HeaderStyle CssClass="headerstyle" />
                    <Columns>
                        <asp:BoundField DataField="rowidfirst" HeaderText="#" ReadOnly="true" HeaderStyle-Width="20px" HeaderStyle-HorizontalAlign="Left" />
                        <asp:TemplateField HeaderText="Name">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtNamefirst" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date Of Birth">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left" Width="90px"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left" Width="90px"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtdobfirst" runat="server" Width="90px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Time Of Birth">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txttobfirst" runat="server" Width="90px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Country">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtcountryfirst" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="State">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtstatefirst" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="City">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtcityfirst" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <div class="capButtonDv">
                <button type="button" class="capButton">Save</button>
            </div>

            <div class="capCenter">
                <div class="capMatch">Match With</div>
            </div>

            <div class="capGl">Girls Detail</div>
            <div class="capTable-responsive">
                <asp:GridView runat="server" ID="gridsecond" AllowPaging="false"
                     AutoGenerateColumns="false">
                    <HeaderStyle CssClass="headerstyle" />
                    <Columns>
                        <asp:BoundField HeaderText="#" ReadOnly="true" HeaderStyle-Width="20px" HeaderStyle-HorizontalAlign="Left" />
                        <asp:TemplateField HeaderText="Name">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtNamesecond" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date Of Birth">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left" Width="90px"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left" Width="90px"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtdobsecond" runat="server" Width="90px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Time Of Birth">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txttobsecond" runat="server" Width="90px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Country">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtcountrysecond" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="State">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtstatesecond" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="City">
                            <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Left"></HeaderStyle>
                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                            <ItemTemplate>
                                <asp:TextBox ID="txtcitysecond" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <%--<table class="capTable">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Date Of Birth</th>
                            <th>Time Of Birth</th>
                            <th>Place Of Birth</th>
                            <th colspan="2" class="capCenter">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Tamanna</td>
                            <td>1/6/1994</td>
                            <td>11:00</td>
                            <td>Delhi</td>
                            <td class="capCenter">Edit</td>
                            <td class="capCenter">Delete</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Divya</td>
                            <td>6/8/1987</td>
                            <td>16:00</td>
                            <td>Delhi</td>
                            <td class="capCenter">Edit</td>
                            <td class="capCenter">Delete</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>Juhi</td>
                            <td>12/1/1988</td>
                            <td>03:32</td>
                            <td>Delhi</td>
                            <td class="capCenter">Edit</td>
                            <td class="capCenter">Delete</td>
                        </tr>
                    </tbody>
                </table>--%>
            </div>

            <div class="capButtonDvCt">
                <button type="button" class="capButton2">Proceed</button>
            </div>

        </div>
    </form>
</body>
</html>
