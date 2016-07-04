using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Simple_Sumator__ASP.NET_Web_Forms_
{
    public partial class SimpleSumator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            var firstNumber = this.FirstNumber.Text;
            var secondNumber = this.SecondNumber.Text;
            double result;

            if (double.TryParse(firstNumber, out result) && double.TryParse(secondNumber, out result))
            {
                result = double.Parse(firstNumber) + double.Parse(secondNumber);
                this.ResultLabel.Text = result.ToString();
            }
            else
            {
                this.ResultLabel.Text = "Invalid data!";
            }
        }
    }
}