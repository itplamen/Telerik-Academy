//05.You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to uppercase. The tags cannot be nested. Example:

//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result:

//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.IO;
using System.Text;

class ChangeTextSurroundedByTags
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("text.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            string startTag = "<upcase>";
            string closeTag = "</upcase>";

            while (line != null)
            {
                int firstIndex = line.IndexOf(startTag);
                int secondIndex = line.IndexOf(closeTag);

                string lowerLetters = line.Substring(firstIndex, secondIndex - firstIndex + 9);
                string capitalLetters = line.Substring(firstIndex + 8, secondIndex - firstIndex - 8).ToUpper();

                string text = line.Replace(lowerLetters, capitalLetters);
                Console.WriteLine(text);

                line = reader.ReadLine();
            }
        }
    }
}

