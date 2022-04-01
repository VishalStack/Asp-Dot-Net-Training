<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EncryptDecrypt_ASPNET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>
            Username:
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" Text="" />
        </td>
    </tr>
    <tr>
        <td>
            Password:
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button ID="btnSubmit" OnClick="Submit" Text="Submit" runat="server" />
        </td>
    </tr>
</table>
<hr />
<asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="Gray"
    HeaderStyle-ForeColor="White" RowStyle-BackColor="white" OnRowDataBound = "OnRowDataBound">
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="Username" />
        <asp:BoundField DataField="UserPassword" HeaderText="Encrypted Password" />
        <asp:BoundField DataField="UserPassword" HeaderText="Desrypted Password" />
    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
