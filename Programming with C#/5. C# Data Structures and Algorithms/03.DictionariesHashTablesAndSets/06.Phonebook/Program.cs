//06.* A text file phones.txt holds information about people, their town and phone number:

//Mimi Shmatkata          | Plovdiv  | 0888 12 34 56
//Kireto                  | Varna    | 052 23 45 67
//Daniela Ivanova Petrova | Karnobat | 0899 999 888
//Bat Gancho              | Sofia    | 02 946 946 946

//Duplicates can occur in people names, towns and phone numbers. Write a program to read the phones file and execute a sequence of commands 
//given in the file commands.txt:

//find(name) – display all matching records by given name (first, middle, last or nickname)
//find(name, town) – display all matching records by given name and town

namespace _06.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Program
    {
        private static MultiDictionary<string, Person> byName = new MultiDictionary<string, Person>(true);
        private static MultiDictionary<Tuple<string, string>, Person> byNameAndCity = new MultiDictionary<Tuple<string, string>, Person>(true);
        
        public static void PrintRecordsByName(string name)
        {
            Console.WriteLine("---------- BY NAME ----------");

            var records = byName[name];

            foreach (var person in records)
            {
                Console.WriteLine(person);
            } 
        }

        public static void PrintRecordsByNameAndCity(string name, string city)
        {
            Console.WriteLine("---------- BY NAME AND CITY ----------");

            var records = byNameAndCity[new Tuple<string, string>(name, city)];
            
            foreach (var person in records)
            {
                Console.WriteLine(person);
            }
        }

        public static void GetCommand()
        {
            StreamReader commandsReader = new StreamReader("commands.txt");

            using (commandsReader)
            {
                string command = commandsReader.ReadLine();

                while (command != null)
                {
                    int startIndex = command.IndexOf('(') + 1;
                    int endIndex = command.IndexOf(')');
                    string parameter = command.Substring(startIndex, endIndex - startIndex);
                    int commaIndex = parameter.IndexOf(',');

                    if (commaIndex < 0)
                    {
                        PrintRecordsByName(parameter.Trim());
                    }
                    else
                    {
                        string personName = parameter.Substring(0, commaIndex);
                        string city = parameter.Substring(commaIndex + 1, personName.Length);
                        PrintRecordsByNameAndCity(personName.Trim(), city.Trim());
                    }

                    command = commandsReader.ReadLine();
                }
            }
        }

        public static void Add(string name, string city, string telephone)
        {
            byName.Add(name, new Person(name, city, telephone));
            byNameAndCity.Add(new Tuple<string, string>(name, city), new Person(name, city, telephone));
        }

        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("phones.txt");

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> personInfo = new List<string>(line.Split('|'));
                    Add(personInfo[0].Trim(), personInfo[1].Trim(), personInfo[2].Trim());
                    line = reader.ReadLine();
                }
            }

            GetCommand();
        }
    }
}
