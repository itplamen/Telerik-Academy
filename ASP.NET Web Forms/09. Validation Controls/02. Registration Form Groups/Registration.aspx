<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel runat="server" ID="AuthPanel" GroupingText="Login">
            <asp:Label runat="server" ID="UsernameLabel" AssociatedControlID="UsernameTextBoxt">Username:</asp:Label>
            <asp:TextBox runat="server" ID="UsernameTextBoxt"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="AuthValidationGroup" 
                ControlToValidate="UsernameTextBoxt" 
                ErrorMessage="Username field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br /> <br />

            <asp:Label runat="server" ID="PasswordLabel" AssociatedControlID="PasswordTextBox">Password:</asp:Label>
            <asp:TextBox runat="server" ID="PasswordTextBox" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="AuthValidationGroup" 
                ControlToValidate="PasswordTextBox" 
                ErrorMessage="Password field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br /> <br />

            <asp:Label runat="server" ID="RepeatPasswordLabel" AssociatedControlID="RepeatPasswordTextBox">Repeat Password:</asp:Label>
            <asp:TextBox runat="server" ID="RepeatPasswordTextBox" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="AuthValidationGroup" 
                ControlToValidate="RepeatPasswordTextBox" 
                ErrorMessage="Repeat Password field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red" 
                EnableClientScript="False">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator
                runat="server"
                ControlToCompare="PasswordTextBox"
                ControlToValidate="RepeatPasswordTextBox"
                ValueToCompare="Text"
                ForeColor="Red"
                ErrorMessage="Password doesn't match!"
                EnableClientScript="false">
            </asp:CompareValidator>
            <br /> <br />

            <asp:Button runat="server" Text="Submit" CausesValidation="true" ValidationGroup="AuthValidationGroup" />
        </asp:Panel>
        
        <asp:Panel runat="server" ID="PersonalInfoPanel" GroupingText="Personal Info">
            <asp:Label runat="server" AssociatedControlID="FirstNameTextBox">First name:</asp:Label>
            <asp:TextBox runat="server" ID="FirstNameTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="PersonalInfoValidationGroup" 
                ControlToValidate="FirstNameTextBox" 
                ErrorMessage="First name field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br /> <br />

            <asp:Label runat="server" AssociatedControlID="LastNameTextBox">Last name:</asp:Label>
            <asp:TextBox runat="server" ID="LastNameTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="PersonalInfoValidationGroup" 
                ControlToValidate="LastNameTextBox" 
                ErrorMessage="Last name field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br /> <br />

            <asp:Label runat="server" AssociatedControlID="AgeTextBox">Age:</asp:Label>
            <asp:TextBox runat="server" ID="AgeTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="PersonalInfoValidationGroup" 
                ControlToValidate="AgeTextBox" 
                ErrorMessage="Age field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator
                runat="server"
                ValidationGroup="PersonalInfoValidationGroup"
                ControlToValidate="AgeTextBox"
                Type="Integer"
                ErrorMessage="Age must be between 18 and 81!"
                MinimumValue="18"
                MaximumValue="81"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RangeValidator>
            <br /> <br />
            
            <asp:Button runat="server" Text="Submit" CausesValidation="true" ValidationGroup="PersonalInfoValidationGroup" />
        </asp:Panel>

        <asp:Panel runat="server" ID="AddressInfoPanel" GroupingText="Address Info">
            <asp:Label runat="server" AssociatedControlID="EmailTextBox">Email:</asp:Label>
            <asp:TextBox runat="server" ID="EmailTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server"
                ValidationGroup="AddressInfoValidationGroup" 
                ControlToValidate="EmailTextBox" 
                ErrorMessage="Email field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator 
                runat="server" 
                ValidationGroup="AddressInfoValidationGroup" 
                ForeColor="Red" 
                Display="Dynamic"
                ErrorMessage="Email is invalid!"
                ControlToValidate="EmailTextBox"
                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}" />
            <br /> <br />

            <asp:Label runat="server" AssociatedControlID="LocalAddressTextBox">Local address:</asp:Label>
            <asp:TextBox runat="server" ID="LocalAddressTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="AddressInfoValidationGroup" 
                ControlToValidate="LocalAddressTextBox" 
                ErrorMessage="Local address field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red" >
            </asp:RequiredFieldValidator>
            <br /> <br />

            <asp:Label runat="server" AssociatedControlID="PhoneTextBox">Phone:</asp:Label>
            <asp:TextBox runat="server" ID="PhoneTextBox"></asp:TextBox>
            <asp:RequiredFieldValidator 
                runat="server" 
                ValidationGroup="AddressInfoValidationGroup" 
                ControlToValidate="PhoneTextBox" 
                ErrorMessage="Phone field is required!"
                Text="*"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator 
                runat="server" 
                ValidationGroup="AddressInfoValidationGroup" 
                ForeColor="Red" 
                Display="Dynamic"
                ErrorMessage="Phone is invalid!"
                ControlToValidate="PhoneTextBox"
                ValidationExpression="^([0-9\(\)\/\+ \-]*)$" />
            <br /> <br />

            <asp:CheckBox ID="AcceptTermsCheckBox" runat="server" Text="I accept" />
            <asp:CustomValidator 
                runat="server" 
                ForeColor="Red" 
                ValidationGroup="ValidationGroupAddressInfo" 
                Display="Dynamic" 
                ErrorMessage="You must accept our terms!" 
                ClientValidationFunction="validateCheckBox">
            </asp:CustomValidator>
            <br /> <br />

            <asp:Button runat="server" Text="Submit" CausesValidation="true" ValidationGroup="AddressInfoValidationGroup" />
        </asp:Panel>

        <asp:ValidationSummary runat="server" ForeColor="Red" />
    </form>

     <script type="text/javascript">
        function validateCheckBox(sender, args) {
            if (document.getElementById("<%= AcceptTermsCheckBox.ClientID  %>").checked === true) {
                args.IsValid = true;
            }
            else {
                args.IsValid = false;
            }
        }
    </script>
</body>
</html>