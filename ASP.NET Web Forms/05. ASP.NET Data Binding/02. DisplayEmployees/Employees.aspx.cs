namespace _02.DisplayEmployees
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    using Northwind.Data;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesGridView.DataSource = Database.GetEmployees();
                this.EmployeesGridView.DataBind();
            }
        }        
    }
}