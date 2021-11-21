<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="OracleDBConnection2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LB_ERR" runat="server" Text=""></asp:Label>
            <asp:DataGrid ID="DGR_TEST" runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanged="DGR_TEST_PageIndexChanged" OnItemCommand="DGR_TEST_ItemCommand">
            <HeaderStyle BackColor="LightBlue" />
            <PagerStyle Mode="NextPrev"></PagerStyle>
            <Columns>
                <asp:TemplateColumn HeaderText="NOMOR">
                    <ItemTemplate>
                        <asp:LinkButton ID="LB_NOMOR" runat="server" CommandName="Edit" ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="NOMOR" Visible="false"></asp:BoundColumn>
                <asp:BoundColumn DataField="KETERANGAN" HeaderText="KETERANGAN"></asp:BoundColumn>
                
            </Columns>
        </asp:DataGrid>

        <table>
            <tr>
                <td><asp:Label ID="LB_NOMOR_0" runat="server">NOMOR</asp:Label></td>
                <td><asp:TextBox ID="TXT_NOMOR" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="LB_KETERANGAN" runat="server">KETERANGAN</asp:Label></td>
                <td><asp:TextBox ID="TXT_KETERANGAN" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        
        <asp:Button ID="BT_SAVE" Text="SAVE" runat="server" OnClick="BT_SAVE_Click"/>
        </div>
    </form>
</body>
</html>
