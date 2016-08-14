<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_05.Web_Calculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Calculator</title>
    <link href="styles/style.css" rel="stylesheet"  type="text/css" />
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel ID="PanelHeader" ClientIDMode="Static" runat="server"> 
            <asp:TextBox ID="TextBoxNumberMemory" runat="server"  Visible="false" ></asp:TextBox>
            <asp:TextBox ID="TextBoxLastSelectedOperation" runat="server" Visible="false" ></asp:TextBox>
            <asp:TextBox ID="TextBoxNumberInput" ClientIDMode="Static" Text="0" runat="server" readonly="true" ></asp:TextBox>
        </asp:Panel>

        <asp:Panel ID="PanelSection" ClientIDMode="Static" runat="server">
            <asp:Button ID="ButtonOne" runat="server" Text="1" CssClass="button" OnClick="OnDigitButtonClicked" />
            <asp:Button ID="ButtonTwo" runat="server" Text="2" CssClass="button" OnClick="OnDigitButtonClicked" />
            <asp:Button ID="ButtonThree" runat="server" Text="3" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonAddition" runat="server" Text="+" CssClass="button" OnClick="OnMathematicsOperationButtonClicked" /> <br/>

            <asp:Button ID="ButtonFour" runat="server" Text="4" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonFive" runat="server" Text="5" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonSix" runat="server" Text="6" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonSubstraction" runat="server" Text="-" CssClass="button" OnClick="OnMathematicsOperationButtonClicked"  /> <br/>

            <asp:Button ID="ButtonSeven" runat="server" Text="7" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonEight" runat="server" Text="8" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonNine" runat="server" Text="9" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonMultiplication" runat="server" Text="*" CssClass="button" OnClick="OnMathematicsOperationButtonClicked"  /> <br/>

            <asp:Button ID="ButtonClear" runat="server" Text="Clear" CssClass="button" OnClick="OnClearButtonClicked"  />
            <asp:Button ID="ButtonZero" runat="server" Text="0" CssClass="button" OnClick="OnDigitButtonClicked"  />
            <asp:Button ID="ButtonDivision" runat="server" Text="/" CssClass="button" OnClick="OnMathematicsOperationButtonClicked"  />
            <asp:Button ID="ButtonSquareRoot" runat="server" Text="&#x0221A;" CssClass="button" OnClick="OnSquareRootButtonClicked"  />
        </asp:Panel>

        <asp:Panel ID="PanelFooter" ClientIDMode="Static" runat="server">
            <asp:Button ID="ButtonEquals" ClientIDMode="Static" runat="server" Text="=" OnClick="OnEqualsButtonClicked" />
        </asp:Panel>
    </form>
</body>
</html>
