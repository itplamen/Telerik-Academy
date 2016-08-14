<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_03.Students_and_courses_registration.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>

    <style>
        div {
        
            background-color: #d4c2c2;
            width: 600px;
            margin: 0 auto;
            text-align: center; 
            padding: 10px;
            
        }
    </style>

</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel ID="PanelRegistration" runat="server">
            <asp:Label runat="server" Text="First name: "></asp:Label> <br />
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label runat="server" Text="Last name: "></asp:Label> <br />
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label runat="server" Text="Faculty number: "></asp:Label> <br />
            <asp:TextBox ID="TextBoxFacultyNumber" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label runat="server" Text="University: "></asp:Label> <br />
            <asp:DropDownList ID="DropDownListUniversity" runat="server">
                <asp:ListItem Selected="True">SoftUni</asp:ListItem>
                <asp:ListItem>University of Cambridge</asp:ListItem>
                <asp:ListItem>Yale University</asp:ListItem>
                <asp:ListItem>Princeton University</asp:ListItem>
                <asp:ListItem>Harvard University</asp:ListItem>
            </asp:DropDownList> <br /> <br />

            <asp:Label runat="server" Text="Speciality: "></asp:Label> <br />
            <asp:DropDownList ID="DropDownListSpeciality" runat="server">
                <asp:ListItem Selected="True">Computer systems</asp:ListItem>
                <asp:ListItem>Medicine</asp:ListItem>
                <asp:ListItem>Law</asp:ListItem>
                <asp:ListItem>Mathematics</asp:ListItem>
            </asp:DropDownList> <br /> <br />
         
            <asp:Label runat="server" Text="Courses: "></asp:Label> <br />
            <asp:ListBox ID="ListBoxCourses" SelectionMode="Multiple" runat="server">
                <asp:ListItem Selected="True">Programming with C#</asp:ListItem>
                <asp:ListItem>OOP</asp:ListItem>
                <asp:ListItem>Programming with Java</asp:ListItem>
                <asp:ListItem>Databases</asp:ListItem>
                <asp:ListItem>Web Design</asp:ListItem>
                <asp:ListItem>System Administration</asp:ListItem>
                <asp:ListItem>Web Programming wiht Php</asp:ListItem>
                <asp:ListItem>First steps with JavaScript</asp:ListItem>
            </asp:ListBox> <br /> <br />

            <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
        </asp:Panel>

        <asp:Panel ID="PanelRegistered" runat="server" Visible="False"></asp:Panel>
    </form>
</body>
</html>
