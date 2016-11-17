using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Northwind.Data;

namespace _05.Display_Employees__with_ListView_
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesListView.DataSource = Database.GetEmployees().ToList();
                this.EmployeesListView.DataBind();
            }
        }
    }
}