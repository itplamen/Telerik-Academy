namespace _03.Display_Employees__with_FormView_
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
                this.EmployeesGridView.DataSource = Database.GetEmployees();
                this.EmployeesGridView.DataBind();
            }

            int employeeID;
            if (int.TryParse(this.Request.QueryString["id"], out employeeID))
            {

                var employee = Database.GetEmployees().FirstOrDefault(x => x.EmployeeID == employeeID);

                if (employee != null)
                {
                    this.EmployeeDetailsFormView.DataSource = new List<Employee>() { employee };
                    this.EmployeeDetailsFormView.DataBind();
                }
            }
        }
    }
}