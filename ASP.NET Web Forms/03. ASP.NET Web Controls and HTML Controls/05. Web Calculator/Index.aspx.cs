namespace _05.Web_Calculator
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Index : Page
    {   
        protected void OnDigitButtonClicked(object sender, EventArgs e)
        {
            string enteredNumber = this.GetValueOfClickedButton(sender);

            if (this.TextBoxNumberInput.Text.Length == 1 && this.TextBoxNumberInput.Text == "0")
            {
                this.TextBoxNumberInput.Text = enteredNumber;
            }
            else
            {
                this.TextBoxNumberInput.Text += enteredNumber;
            }

            if (this.TextBoxLastSelectedOperation.Text.Length == 0)
            {
                this.TextBoxNumberMemory.Text = this.TextBoxNumberInput.Text;
            }
        }

        protected void OnMathematicsOperationButtonClicked(object sender, EventArgs e)
        {
            this.TextBoxLastSelectedOperation.Text = this.GetValueOfClickedButton(sender);
            this.TextBoxNumberInput.Text = string.Empty;
        }

        protected void OnClearButtonClicked(object sender, EventArgs e)
        {
            this.TextBoxNumberInput.Text = "0";
            this.TextBoxNumberMemory.Text = string.Empty;
            this.TextBoxLastSelectedOperation.Text = string.Empty;
        }

        protected void OnSquareRootButtonClicked(object sender, EventArgs e)
        {
            this.TextBoxNumberInput.Text = Math.Sqrt(double.Parse(this.TextBoxNumberInput.Text)).ToString();
        }

        protected void OnEqualsButtonClicked(object sender, EventArgs e)
        {
            double result = this.ApplySelectedMathematicsOperation(sender);
            this.TextBoxNumberInput.Text = result.ToString();
            this.TextBoxLastSelectedOperation.Text = string.Empty;
            this.TextBoxNumberMemory.Text = string.Empty;
        }

        private double ApplySelectedMathematicsOperation(object sender)
        {
            string selectedOperation = this.TextBoxLastSelectedOperation.Text;
            double firstNumber = double.Parse(this.TextBoxNumberMemory.Text);
            double secondNumber = double.Parse(this.TextBoxNumberInput.Text);

            switch (selectedOperation)
            {
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                default:
                    throw new InvalidOperationException("Invalid Mathematics Opeartion!");
            }
        }

        private double GetEnteredNumberFromTextBox(string numberFromTextBox)
        {
            double enteredNumber = 0;

            try
            {
                enteredNumber = double.Parse(numberFromTextBox);
            }
            catch (FormatException ex)
            {
                this.TextBoxNumberInput.Text = ex.Message;
            }

            return enteredNumber;
        }

        // Gets the value of the clicked button. Example: 2, 0, 9, -, + ...
        private string GetValueOfClickedButton(object sender)
        {
            //if (sender.GetType() == typeof(string))
            //{
            //    return sender.ToString();
            //}

            return (sender as Button).Text;
        }
    }
}