namespace EntityFramework
{
    using System;
    using System.Linq;
    using Northwind.Models;

    public static class DataAccessObjectsClass
    {
        private static Customer GetCustomer(string customerID)
        {
            using (var db = new NorthwindEntities())
            {
                if (customerID == null)
                {
                    throw new ArgumentNullException("Customer cannot be null!");
                }

                return db.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            }
        }

        public static void InsertCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                if (GetCustomer(customer.CustomerID) != null)
                {
                    throw new ArgumentException("Customer already exist!");
                }

                db.Customers.Add(customer);
                db.SaveChanges();
                Console.WriteLine("New customer was added successfully!");
            }
        }

        public static void UpdateCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customerToUpdate = GetCustomer(customer.CustomerID);

                if (customerToUpdate == null)
                {
                    throw new ArgumentNullException("Customer does not exist!");
                }

                customerToUpdate.CompanyName = customer.CompanyName;
                customerToUpdate.ContactName = customer.ContactName;
                customerToUpdate.ContactTitle = customer.ContactTitle;
                customerToUpdate.Address = customer.Address;
                customerToUpdate.City = customer.City;
                customerToUpdate.Region = customer.Region;
                customerToUpdate.PostalCode = customer.PostalCode;
                customerToUpdate.Country = customer.Country;
                customerToUpdate.Phone = customer.Phone;
                customerToUpdate.Fax = customer.Fax;
                db.SaveChanges();
                Console.WriteLine("Customer was updated successfully!");
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.Where(c => c.CustomerID == customerID);

                if (customers.Count() > 0)
                {
                    foreach (var customer in customers)
                    {
                        db.Customers.Remove(customer);
                    }

                    db.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Customer does not exist!");
                }

                Console.WriteLine("Customer wast deleted successfully!");
            }
        }

        public static void SpecificCustomer(int yearOfOrder, string shipCountry)
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Orders
                    .Where(o => o.ShipCountry == shipCountry && o.OrderDate.Value.Year == yearOfOrder)
                    .OrderBy(o => o.CustomerID)
                    .Select(o =>
                        new
                        {
                            CustomerID = o.CustomerID,
                            OrderDate = o.OrderDate.Value.Year,
                            ShipCountry = o.ShipCountry
                        });

                if (customers.Count() > 0)
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine("{0}, {1}, {2}", customer.CustomerID, customer.OrderDate, customer.ShipCountry);
                    }
                }
                else
                {
                    Console.WriteLine("There are no such records!");
                }
            }
        }

        public static void SpecificCustomerBySqlQuery(int yearOfOrder, string shipCountry)
        {
            using (var db = new NorthwindEntities())
            {
                string query =
                @"SELECT CustomerID, ShipCountry, OrderDate
                FROM Orders
                WHERE ShipCountry = " + shipCountry + " AND DATEPART(YEAR, OrderDate) = " + yearOfOrder +
                "ORDER BY CustomerID";

                var customers = db.Database.SqlQuery<Order>("SELECT * FROM Orders WHERE DATEPART(YEAR, OrderDate) = 1997");

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CustomerID);
                }
            }
        }

        public static void SalesByRegionAndPeriod(string shipRegion, DateTime shippedStartDate, DateTime shippedEndDate)
        {
            using (var db = new NorthwindEntities())
            {
                var sales = db.Orders
                    .Where(o => o.ShipRegion == shipRegion)
                    .OrderBy(o => o.OrderID)
                    .Select(o =>
                        new
                        {
                            OrderID = o.OrderID,
                            ShipRegion = o.ShipRegion,
                            ShippedDate = o.ShippedDate
                        });

                Console.WriteLine(sales.Count());

                foreach (var sale in sales)
                {
                    Console.WriteLine("{0} {1} {2}", sale.OrderID, sale.ShipRegion, sale.ShippedDate);
                }
            }
        }
    }
}
