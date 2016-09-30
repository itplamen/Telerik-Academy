// 05. Write a program that retrieves the images for all
// categories in the Northwind database and stores
// them as JPG files in the file system. 

namespace _05.Retrieves_images
{ 
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Drawing;
    using System.Drawing.Imaging;

    public class Program
    {
        private const string PATH = @"E:\Pictures\";

        public static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection(Settings.Default.DBConnectionString);

            using (dbConnection)
            {
                dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var img = (byte[])reader["Picture"];
                        byte[] imgData = new byte[img.Length - 78];
                        Array.Copy(img, 78, imgData, 0, imgData.Length);
                        string fileNameAndDestination = string.Format(
                        "{0}{1}.jpg",
                        PATH,
                        ((string)(reader["CategoryName"])).Replace('/', ' '));
                        MemoryStream memoryStream = new MemoryStream(imgData);
                        Image image = Image.FromStream(memoryStream);
                        image.Save(new FileStream(fileNameAndDestination, FileMode.Create), ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}
