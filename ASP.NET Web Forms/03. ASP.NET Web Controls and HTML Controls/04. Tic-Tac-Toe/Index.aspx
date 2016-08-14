<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_04.Tic_Tac_Toe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel ID="GameBoard" runat="server">
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonOne"  OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonTwo" OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonThree" OnClick="OnUserButtonClick" />

            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonFour" OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonFive" OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonSix" OnClick="OnUserButtonClick" />
        
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonSeven" OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonEight" OnClick="OnUserButtonClick" />
            <asp:Button Text=" " CssClass="button" runat="server" ID="ButtonNine" OnClick="OnUserButtonClick" />
        </asp:Panel>
            
        <asp:Panel ID="Scoreboard" runat="server">
            <asp:Label Text="X" CssClass="symbol" runat="server" />
            <asp:Label Text="Player: " runat="server" />
            <asp:Label Text="0" ID="PlayerScores"  runat="server" /> <br /> 

            <asp:Label Text="O" CssClass="symbol" runat="server" />
            <asp:Label Text="Computer:" runat="server" />
            <asp:Label Text="0" ID="ComputerScores" runat="server" /> <br /><br />

            <asp:Label ID="WhoWonTheGameLabel" Text="" runat="server" /> <br /><br />

            <asp:Button Text="New Game" ID="NewGameButton" runat="server" OnClick="OnNewGameClick" />
        </asp:Panel>
    </form>
</body>
</html>
