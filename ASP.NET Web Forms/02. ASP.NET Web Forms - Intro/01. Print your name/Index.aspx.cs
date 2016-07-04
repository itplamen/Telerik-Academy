using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Print_your_name
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPrintName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxUserName.Text))
            {
                throw new ArgumentNullException("You must enter name!");
            }

            this.LabelMyNameIs.Text = "Hello " + this.TextBoxUserName.Text + "!";
        }
    }
}