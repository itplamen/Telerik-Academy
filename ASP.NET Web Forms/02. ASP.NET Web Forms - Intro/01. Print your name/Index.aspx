<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.Print_your_name.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelEnterName" runat="server" Text="Enter name: "></asp:Label>
        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        <asp:Label ID="LabelMyNameIs" runat="server" Text=" "></asp:Label>
    
    </div>
        <p>
            <asp:Button ID="ButtonPrintName" runat="server" OnClick="ButtonPrintName_Click" Text="Print" />
        </p>
    </form>
</body>
</html>
