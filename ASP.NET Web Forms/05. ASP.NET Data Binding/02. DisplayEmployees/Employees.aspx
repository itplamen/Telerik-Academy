<%@ 
    Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="Employees.aspx.cs" 
    Inherits="_02.DisplayEmployees.Employees" 
    
%>

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
                    DataNavigateUrlFormatString="EmployeeDetails.aspx?id={0}" />
            </Columns>

        </asp:GridView>
    </form>
</body>
</html>
