<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADOTest.aspx.cs" Inherits="ADO3TierDisconnected.ADOTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            AddressID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TexADD" runat="server"></asp:TextBox>
            <br />
            <br />
            FirstName&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FName" runat="server"></asp:TextBox>
            <br />
            <br />
            LastName&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="LName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            EMail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="EMAIL" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="insert" runat="server" OnClick="insert_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update" />
            <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
