namespace _04.Display_Employees__with_Repeater_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI;

    using Northwind.Data;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesRepeater.DataSource = Database.GetEmployees();
                this.EmployeesRepeater.DataBind();
            }
        }
    }
}