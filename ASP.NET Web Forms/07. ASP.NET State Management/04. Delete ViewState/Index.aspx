<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_04.Delete_ViewState.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-2.1.3.min.js"></script>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label runat="server" AssociatedControlID="TextBox">Enter text: </asp:Label>
        <asp:TextBox runat="server" ID="TextBox"></asp:TextBox>
        <br /> <br />
        
        <asp:Button runat="server" ID="ShowViewStateButton" Text="Show" OnClick="OnShowViewStateBtnClick" />
        <button id="DeleteBtn">Delete</button>
        <br /> <br />

        <h3>ViewState:</h3>
        <asp:Literal runat="server" ID="DisplayViewStateLiteral"></asp:Literal>
    </form>

    <script> 
        $(document).ready(
            $('#DeleteBtn').on('click', function () {
                $('#__VIEWSTATE').val('');
            }));
    </script>
</body>
</html>
