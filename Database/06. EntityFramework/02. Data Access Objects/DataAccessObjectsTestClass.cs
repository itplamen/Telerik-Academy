// 02. Create a DAO class with static methods which
// provide functionality for inserting, modifying and
// deleting customers. Write a testing class.

namespace EntityFramework
{
    using System;
    using System.Linq;
    using Northwind.Models;

    public class DataAccessObjectsTestClass
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                CustomerID = "ABC",
                CompanyName = "ABC App",
                ContactName = "Plamen Georgiev",
                ContactTitle = "Owner",
                Address = "Madrid 17d",
                City = "Madrid",
                Region = null,
                PostalCode = "3320DC",
                Country = "Spain",
                Phone = "663 912 0011 3232",
                Fax = null
            };

            DataAccessObjectsClass.InsertCustomer(customer);

            customer.ContactName = "Plamen Svetlozarov Georgiev";
            customer.Address = "calle V. Az. 203, Madrid ";
            customer.Fax = "912-000-11-23-13312";

            DataAccessObjectsClass.UpdateCustomer(customer);
            DataAccessObjectsClass.DeleteCustomer(customer.CustomerID);
        }
    }
}
