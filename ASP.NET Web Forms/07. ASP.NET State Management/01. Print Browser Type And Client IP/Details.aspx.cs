namespace _01.Print_Browser_Type_And_Client_IP
{
    using System;
    using System.Web.UI;

    public partial class Details : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BrowserTypeLabel.Text += this.Request.Browser.Type;
            this.UserAgentLabel.Text += this.Request.UserAgent;
            this.ClientIPLabel.Text += this.Request.UserHostAddress;
        }
    }
}