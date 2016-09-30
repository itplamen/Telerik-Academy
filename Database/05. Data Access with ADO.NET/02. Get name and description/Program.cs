// 02. Write a program that retrieves the name and
// description of all categories in the Northwind DB. 

namespace _02.Get_name_and_description
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
                SqlCommand sqlCommand = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Category: {0} -> Description: {1}", reader["CategoryName"], reader["Description"]);
                    }
                }
            }
        }
    }
}
