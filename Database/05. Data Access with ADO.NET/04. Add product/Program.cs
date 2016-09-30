// 04. Write a method that adds a new product in the
// products table in the Northwind database. Use a
// parameterized SQL command.

namespace _04.Add_product
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        public static SqlCommand AddProduct(string productName, int supplierID, int categoryID, string quantityPerUnit, 
            decimal price, int unitsInStock, int unitsOnOreder, int reorderLevel, bool discontinued, SqlConnection dbConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(
                @"INSERT INTO Products 
                (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @price, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbConnection);

            sqlCommand.Parameters.AddWithValue("@productName", productName);
            sqlCommand.Parameters.AddWithValue("@supplierID", supplierID);
            sqlCommand.Parameters.AddWithValue("@categoryID", categoryID);
            sqlCommand.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@price", price);
            sqlCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsOnOrder", unitsOnOreder);
            sqlCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            sqlCommand.Parameters.AddWithValue("@discontinued", discontinued);
            return sqlCommand;
        }

        public static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection(Settings.Default.DBConnectionString);

            using (dbConnection)
            {
                dbConnection.Open();
                var resultFromSqlCommand = AddProduct("Pork Meat", 20, 6, "200 kg", 2.79m, 20, 0, 0, true, dbConnection).ExecuteNonQuery();
                Console.WriteLine("{0} row(s) affected!", resultFromSqlCommand);
            }
        }
    }
}
