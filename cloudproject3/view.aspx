<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="398px">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />
    <Columns>
        <asp:BoundField DataField="f_name" HeaderText="File name" />
    </Columns>
</asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<table style="width: 100%; height: 769px;">
    <tr>
        <td style="height: 259px">
            <asp:Panel ID="Panel10" runat="server" BackColor="#99CCFF" Height="253px">
                <br />
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Cloud Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Decrypt" />
            </asp:Panel>
        </td>
        <td style="height: 259px">
            <asp:Panel ID="Panel2" runat="server" BackColor="#99CCFF" Height="253px">
                <br />
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Fog Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox4" runat="server" Height="132px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Decrypt" />
            </asp:Panel>
        </td>
        <td style="height: 259px">
            <asp:Panel ID="Panel3" runat="server" BackColor="#99CCFF" Height="253px">
                &nbsp;<br />
                <asp:Label ID="Label3" runat="server" Text="System Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox5" runat="server" Height="131px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Decrypt" />
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td style="height: 199px">
            <asp:Panel ID="Panel11" runat="server" BackColor="#FFFFCC" Height="253px">
                <br />
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Cloud Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox6" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
            </asp:Panel>
        </td>
        <td style="height: 199px">
            <asp:Panel ID="Panel12" runat="server" BackColor="#FFFFCC" Height="253px">
                <br />
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Fog Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox7" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Decrypt" Visible="False" />
                <br />
            </asp:Panel>
        </td>
        <td style="height: 199px">
            <asp:Panel ID="Panel13" runat="server" BackColor="#FFFFCC" Height="253px">
                <br />
                &nbsp;
                <asp:Label ID="Label7" runat="server" Text="System Data"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox8" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                <br />
                <br />
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Panel ID="Panel14" runat="server" BackColor="#656468" Height="248px">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Decrypt" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox10" runat="server" Height="134px" TextMode="MultiLine" Width="315px"></asp:TextBox>
            </asp:Panel>
        </td>
    </tr>
</table>
</asp:Content>

