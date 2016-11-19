namespace _03.Exchange_User_Data_With_Cookies
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class UserDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         HttpCookie cookie = this.Request.Cookies["Username"];

            if (cookie != null)
            {
                string text = "Cookie was sent by the Web browser.";
                this.Response.Write(text);

                this.LoggedUserLabel.Text += cookie.Value;
            }
            else
            {
                this.Response.Redirect("Login.aspx");
            }    
        }
    }
}