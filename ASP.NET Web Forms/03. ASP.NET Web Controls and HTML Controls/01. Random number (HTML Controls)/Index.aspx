<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.Random_number__HTML_Controls_.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <input type="text" runat="server" id="MinRange"
            min="0" max="1000000" placeholder="Enter min range ..." /> <br /> <br />

        <input type="text" runat="server" id="MaxRange" 
            min="0" max="1000000" placeholder="Enter max range ..." /> <br /> <br />

        <input type="button" runat="server" id="GenerateRandomNumber" value="Generate" onserverclick="ButtonGenerate_Click" /> <br /> <br />

        <span>Generated number: <span id="GeneratedNumber" runat="server"></span></span>
    </form>
</body>
</html>
