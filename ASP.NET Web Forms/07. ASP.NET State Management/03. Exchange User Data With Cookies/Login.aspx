<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_03.Exchange_User_Data_With_Cookies.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label runat="server">Username: </asp:Label>
        <asp:TextBox runat="server" ID="UsernameTextBox"></asp:TextBox>
        <br /> <br />

        <asp:Label runat="server">Password:</asp:Label>
        <asp:TextBox runat="server" TextMode="Password" ID="PasswordTextBox"></asp:TextBox>
        <br /> <br />
        
        <asp:Button runat="server" ID="LoginBtn" UseSubmitBehavior="true" Text="Login" OnClick="OnLoginButtonClick" />
    </form>
</body>
</html>
