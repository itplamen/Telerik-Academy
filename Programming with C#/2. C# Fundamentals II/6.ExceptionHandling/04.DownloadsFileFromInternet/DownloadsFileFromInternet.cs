//04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the 
//current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources 
//in the finally block.

using System;
using System.Net;

    class DownloadsFileFromInternet
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL of the file: ");
            string url = Console.ReadLine();

            Console.Write("Enter directory where you want to store the file: ");
            string directory = Console.ReadLine();
            
            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(url, directory);
                Console.WriteLine("Download complete!");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address -or- Empty file -or- The file does not exist.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid address. The address can not be null.");
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }

