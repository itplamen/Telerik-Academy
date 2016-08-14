<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.Random_number__Web_Controls_.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:TextBox ID="MinRange" min="0" max="1000000" placeholder="Enter min range ..." runat="server">
        </asp:TextBox> <br /> <br />
        
        <asp:TextBox ID="MaxRange" min="0" max="1000000" placeholder="Enter max range ..." runat="server">
        </asp:TextBox> <br /> <br />

        <asp:Button ID="GenerateNumber" runat="server" Text="Generate" OnClick="GenerateNumber_Click" /><br /> <br />
        
        <asp:Label runat="server" Text="Generated number: ">
            <asp:Label ID="GeneratedNumber" runat="server" Text=""></asp:Label>
        </asp:Label>
    </form>
</body>
</html>
