<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="_01.Print_Browser_Type_And_Client_IP.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label runat="server" ID="BrowserTypeLabel">Browser's type: </asp:Label>
        <br />

        <asp:Label runat="server" ID="UserAgentLabel">User agent: </asp:Label>
        <br />

        <asp:Label runat="server" ID="ClientIPLabel">Client IP: </asp:Label>
    </form>
</body>
</html>
