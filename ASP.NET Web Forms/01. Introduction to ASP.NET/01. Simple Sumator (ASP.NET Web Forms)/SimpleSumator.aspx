<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleSumator.aspx.cs" Inherits="_01.Simple_Sumator__ASP.NET_Web_Forms_.SimpleSumator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
    <div>
        <asp:TextBox ID="FirstNumber" runat="server" Width="50px" Height="15px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text=" + "></asp:Label>
        <asp:TextBox ID="SecondNumber" runat="server" Width="50px" Height="15px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text=" = "></asp:Label>
        <asp:Label ID="ResultLabel" runat="server" Text=" "></asp:Label>
    </div>
        <br />
            <asp:Button ID="Sum" runat="server" Text="Sum" OnClick="Sum_Click" />
        
    </form>
</body>
</html>
