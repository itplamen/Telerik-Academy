//25.Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//Example:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>

using System;
using System.IO;

    class ExtractTitleAndBodyFromHTLM
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadToEnd();

                int indexClosingTag = line.IndexOf('>');
                while (indexClosingTag > -1)
                {
                    if (indexClosingTag < line.Length - 1 && line[indexClosingTag + 1] != '<')
                    {
                        int nextOpeningIndexTag = line.IndexOf('<', indexClosingTag);
                        int textLength = nextOpeningIndexTag - indexClosingTag - 1;

                        Console.WriteLine(line.Substring(indexClosingTag + 1, textLength));
                    }
                    indexClosingTag = line.IndexOf('>', indexClosingTag + 1);
                }
            }
        }
    }

