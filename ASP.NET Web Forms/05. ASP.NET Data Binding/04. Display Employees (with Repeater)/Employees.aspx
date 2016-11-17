<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_04.Display_Employees__with_Repeater_.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater runat="server" ID="EmployeesRepeater" ItemType="Northwind.Data.Employee">
            <ItemTemplate>
                <h3><%#: Item.FirstName + " " + Item.LastName %></h3>
                <p>Birth: <%#: Item.BirthDate %></p>
                <p>City: <%#: Item.City %></p>
                <p>Address: <%#: Item.Address %></p>
                <hr />
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
