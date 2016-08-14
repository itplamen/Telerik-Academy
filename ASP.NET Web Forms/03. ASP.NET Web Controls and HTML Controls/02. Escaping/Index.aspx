<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_02.Escaping.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:TextBox ID="TextBoxDangerousText" placeholder="Enter dangerous text ..." runat="server"></asp:TextBox> 
        <asp:Button ID="ButtonResult" runat="server" Text="Show" OnClick="ButtonResult_Click" /><br /> <br />

        <asp:TextBox ID="TextBoxResult" runat="server"></asp:TextBox> <br /> <br />
        <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
