<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="_01.Mobile.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label runat="server">Producers:</asp:Label>
        <asp:DropDownList runat="server" ID="ProducersDropDownList" AutoPostBack="true" DataTextField="Name" OnSelectedIndexChanged="ProducersDropDownList_OnSelectedIndexChanged">
        </asp:DropDownList>

        <br /> <br />

        <asp:Label runat="server">Models:</asp:Label>
        <asp:DropDownList runat="server" ID="ModelsDropDownList" AutoPostBack="true">
        </asp:DropDownList>

        <br /> <br />

        <asp:Label runat="server">Extras:</asp:Label>
        <asp:CheckBoxList runat="server" ID="ExtrasCheckBoxList" DataTextField="Name">
        </asp:CheckBoxList>

        <br /> <br />
        
        <asp:Label runat="server">Engines:</asp:Label>
        <asp:RadioButtonList runat="server" ID="EnginesRadioButtonList">
        </asp:RadioButtonList>

        <br /> <br />

        <asp:Button runat="server" Text="Search" OnClick="OnSearchButtonClick" />

        <br /> <br />
        
        <div runat="server" id="SearchResults" visible="false">
            <h2>Results:</h2>
        </div>
    </form>
</body>
</html>
