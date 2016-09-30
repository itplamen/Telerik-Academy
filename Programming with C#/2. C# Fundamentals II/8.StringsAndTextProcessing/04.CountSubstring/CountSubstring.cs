//04.Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:

//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9.

using System;
using System.IO;
using System.Security;
using System.Text;

class CountSubstring
{
    //The file text.txt is in directory bin/Debug
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                string keyword = "in";
                int index = line.IndexOf(keyword);
                int counter = 1;

                while (line != null)
                {
                    while (true)
                    {
                        index = line.ToLower().IndexOf(keyword, index + 1);

                        if (index == -1)
                        {
                            break;
                        }
                        counter++;
                    }
                    line = reader.ReadLine();
                }
                Console.WriteLine("The substring \"{0}\" is contained {1} times in the text!", keyword, counter);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        } 
    }
}

