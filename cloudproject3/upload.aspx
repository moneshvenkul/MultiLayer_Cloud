<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <table style="width: 100%; height: 774px;">
        <tr>
            <td style="width: 77px; height: 54px"></td>
            <td style="width: 498px; height: 54px"></td>
            <td style="height: 54px"></td>
        </tr>
        <tr>
            <td style="width: 77px; height: 557px"></td>
            <td style="width: 498px; height: 557px">
                <asp:Panel ID="Panel1" runat="server" Height="737px" BorderColor="#CCFFFF">
                    <table style="width:100%; background-color: #99CCFF;">
                        <tr>
                            <td style="width: 184px; height: 20px;"></td>
                            <td style="width: 227px; height: 20px;">
                                <asp:Label ID="StatusLabel" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td style="height: 20px"></td>
                        </tr>
                        <tr>
                            <td style="width: 184px">
                                <asp:Label ID="Label1" runat="server" Text="Select File"></asp:Label>
                            </td>
                            <td style="width: 227px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 184px">&nbsp;</td>
                            <td style="width: 227px">
                                <asp:FileUpload ID="FileUpload1"  runat="server" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 184px">&nbsp;</td>
                            <td style="width: 227px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 184px">&nbsp;</td>
                            <td style="width: 227px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 184px">&nbsp;</td>
                            <td style="width: 227px">&nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Upload" Width="85px" OnClick="Button1_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td style="height: 557px"></td>
        </tr>
        <tr>
            <td style="width: 77px">&nbsp;</td>
            <td style="width: 498px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

