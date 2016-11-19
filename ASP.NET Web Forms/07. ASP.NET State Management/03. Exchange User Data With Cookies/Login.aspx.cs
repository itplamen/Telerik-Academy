namespace _03.Exchange_User_Data_With_Cookies
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void OnLoginButtonClick(object sender, EventArgs e)
        {
            string username = this.UsernameTextBox.Text;

            HttpCookie cookie = new HttpCookie("Username", username);
            cookie.Expires = DateTime.Now.AddMinutes(1);

            this.Response.Cookies.Add(cookie);
            this.Response.Redirect("UserDetails.aspx");
        }
    }
}