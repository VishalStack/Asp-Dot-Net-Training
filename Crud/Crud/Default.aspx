<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crud.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Student</h1>
            <table width="100%">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td colspan="3">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table class="tblcolor" width="100%" border="1">
                    <tr>
                        <th>ID</th>
                        <th>Student Name</th>
                        <th>Age</th>
                        <th>Action</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblStudentID" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                    <td>
                        <%#Eval("Name") %>
                    </td>
                    <td>
                        <%#Eval("Age") %>
                    </td>
                    <th>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%#"~/Edit.aspx?id=" + Eval("ID") %>'>Edit</asp:HyperLink>
                        |
                        <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" OnClientClick="return confirm('Do you want to delete this Student?');" OnClick="DeleteStudent" />
                    </th>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
