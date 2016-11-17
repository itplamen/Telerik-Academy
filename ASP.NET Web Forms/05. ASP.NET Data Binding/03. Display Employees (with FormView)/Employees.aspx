<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_03.Display_Employees__with_FormView_.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:GridView runat="server" ID="EmployeesGridView" AutoGenerateColumns="False" 
            AllowPaging="True" DataKeyNames="EmployeeID">

            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:HyperLinkField HeaderText="Check Details" Text="Details" DataNavigateUrlFields="EmployeeID" 
                    DataNavigateUrlFormatString="Employees.aspx?id={0}" />
            </Columns>

        </asp:GridView>

        <asp:FormView runat="server" ID="EmployeeDetailsFormView" DataKeyNames="EmployeeID" ItemType="Northwind.Data.Employee">
            <ItemTemplate>
                <h3><%#: Item.FirstName + " " + Item.LastName %></h3>
                <p>Birth: <%#: Item.BirthDate %></p>
                <p>City: <%#: Item.City %></p>
                <p>Address: <%#: Item.Address %></p>
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
