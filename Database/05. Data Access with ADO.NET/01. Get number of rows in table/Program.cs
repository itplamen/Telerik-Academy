// 01. Write a program that retrieves from the Northwind
// sample database in MS SQL Server the number of
// rows in the Categories table. 

namespace _01.Get_number_of_rows_in_table
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
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(CategoryID) FROM Categories", dbConnection);
                int rows = (int)sqlCommand.ExecuteScalar();
                Console.WriteLine("Number of rows: " + rows);
            }  
        }
    }
}
