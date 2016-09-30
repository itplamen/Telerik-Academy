// 03. Write a program that retrieves from the Northwind
// database all product categories and the names of
// the products in each category. Can you do this with a
// single SQL query (with table join)? 

namespace _03.Get_product_categories_and_products
{
    using System;
    using System.Data.SqlClient;
 
    public class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection(Settings.Default.DBConnectionString);

            using (dbConnection)
            {
                dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    @"SELECT c.CategoryID, c.CategoryName, p.ProductName
                    FROM Categories c  
                        JOIN Products p
                        ON c.CategoryID = p.CategoryID
                    ORDER BY c.CategoryID", dbConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} -> {1} -> {2}", reader["CategoryID"], reader["CategoryName"], reader["ProductName"]);
                    }
                }
            }
        }
    }
}
