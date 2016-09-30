//08.Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:

//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The expected result is:

//We are living in a yellow submarine.
//We will move out of it in 5 days.

//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExtractSentences
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                List<string> list = new List<string>(line.Split(' '));
                string keyword = "in";

                int index = list.IndexOf(keyword);
                int index2 = line.IndexOf(keyword);

                string word = line.Substring(index2);

                Console.WriteLine(word);
            }
        }
    }

