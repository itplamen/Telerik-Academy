//01.A text file students.txt holds information about students and their courses in the following format:

//Kiril  | Ivanov   | C#
//Stefka | Nikolova | SQL
//Stela  | Mineva   | Java
//Milena | Petrova  | C#
//Ivan   | Grigorov | C#
//Ivan   | Kolev    | SQL

//Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:

//C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
//Java: Stela Mineva
//SQL: Ivan Kolev, Stefka Nikolova

namespace _01.Academy
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
        public static void PrintCourses(OrderedMultiDictionary<Course, Student> dictionary)
        {
            foreach (var course in dictionary)
            {
                Console.WriteLine("Course: " + course.Key.CourseName);
                Console.Write("Students: ");

                foreach (var student in course.Value)
                {
                    Console.Write("{0} {1}", student.FirstName, student.LastName + new string(' ', 4));
                }

                Console.WriteLine("\n");
            }
        }

        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("students.txt");
            OrderedMultiDictionary<Course, Student> dictionary = new OrderedMultiDictionary<Course, Student>(true);

            using (reader)
            {    
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> elements = new List<string>(line.Split('|'));
                    dictionary.Add(new Course(elements[2].Trim()), new Student(elements[0].Trim(), elements[1].Trim()));
                    line = reader.ReadLine();
                } 
            }

            PrintCourses(dictionary);
        }
    }
}
