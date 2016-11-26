using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Menu_Control
{
    public partial class Index : System.Web.UI.Page
    {
        private IList<MenuItem> menuItems = SeedMenuLinks();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.MenuOfLinks.DataSourse = menuItems;
                this.MenuOfLinks.DataBind();  
            }
        }

        private static IList<MenuItem> SeedMenuLinks()
        {
            return new List<MenuItem>()
            {
                new MenuItem() { Title = "Telerik Academy", URL = "https://telerikacademy.com/" },
                new MenuItem() { Title = "Google", URL = "https://www.google.bg/?gws_rd=ssl" },
                new MenuItem() { Title = "itplamen", URL = "https://github.com/itplamen" }
            };
        }
    }
}