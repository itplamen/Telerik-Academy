namespace _02.DisplayEmployees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI;

    using Northwind.Data;
    
    public partial class EmployeeDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int employeeID;
            if (!int.TryParse(this.Request.QueryString["id"],  out employeeID))
            {
                this.RedirectToHomePage();
            }

            var employee = Database.GetEmployees().FirstOrDefault(x => x.EmployeeID == employeeID);

            if (employee == null)
            {
                this.RedirectToHomePage();
            }

            this.EmployeesDetailsView.DataSource = new List<Employee>() { employee };
            this.EmployeesDetailsView.DataBind();
        }

        protected void OnBackButtonClick(object sender, EventArgs e)
        {
            this.RedirectToHomePage();
        }

        private void RedirectToHomePage()
        {
            this.Response.Redirect("Employees.aspx");
        }
    }
}