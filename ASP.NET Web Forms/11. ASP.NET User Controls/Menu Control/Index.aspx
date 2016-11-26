<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Menu_Control.Index" %>

<%@ Register Src="~/MenuOfLinks.ascx" TagPrefix="userControls" TagName="MenuOfLinks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
         <userControls:MenuOfLinks ID="MenuOfLinks" runat="server" />
    </form>
</body>
</html>
