<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="_02.DisplayEmployees.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DetailsView runat="server" ID="EmployeesDetailsView" AutoGenerateRows="true" AllowPaging="True">

        </asp:DetailsView>

        <br />

        <asp:Button runat="server" Text="Back" OnClick="OnBackButtonClick" />
    </form>
</body>
</html>
