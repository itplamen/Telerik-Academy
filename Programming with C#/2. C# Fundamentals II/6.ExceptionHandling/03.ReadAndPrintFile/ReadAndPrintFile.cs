//03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents 
//and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible 
//exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

    class ReadAndPrintFile
    {
        static void Main()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
                Console.WriteLine("Paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is INCORRECT.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only. \n -or- This operation is not supported on the current platform.\n -or- Path specified a directory.\n -or- The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission to access this file.");
            }
        }    
    }

