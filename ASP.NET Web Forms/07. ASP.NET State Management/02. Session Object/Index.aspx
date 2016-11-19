<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_02.Session_Object.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label runat="server">Enter data: </asp:Label>
        <asp:TextBox runat="server" ID="InputTextBox"></asp:TextBox>
        <asp:Button runat="server" Text="Append" OnClick="OnSessionAppendButtonClick" />
        <br /> <br />

        <asp:Label runat="server">Session Result:</asp:Label>
        <asp:Label runat="server" ID="SessionResultLabel"></asp:Label>
    </form>
</body>
</html>
