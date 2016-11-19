namespace _02.Session_Object
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["data"] == null)
            {
                this.Session.Add("data", new List<string>());
            }
        }

        protected void OnSessionAppendButtonClick(object sender, EventArgs e)
        {
            List<string> sessionData = (List<String>)this.Session["data"];
            sessionData.Add(this.InputTextBox.Text);
            this.Session.Add("data", sessionData);

            this.SessionResultLabel.Text = string.Empty;

            foreach (var data in sessionData)
            {
                this.SessionResultLabel.Text += "<br/>" + data;
            }

            this.InputTextBox.Text = string.Empty;
        }
    }
}