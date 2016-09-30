//02.Define abstract class Human with first name and last name. Define new class Student which is derived from 
//Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and 
//WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper 
//constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending 
//order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per 
//hour in descending order. Merge the lists and sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    class Test
    {
        // Sort students by grade in ascending order, using LINQ
        static void SortStudentByGrade(List<Student> studentsList)
        {
            var sortedList =
                from stud in studentsList
                orderby stud.Grade ascending
                select stud;

            // Print sorted students
            Console.WriteLine("---------- STUDENTS ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}, Grade: {1}", element.FirstName + " " + element.LastName, element.Grade);
            }

            Console.WriteLine();
        }

        // Sort workers by money per hours in descending  order, using LINQ
        static void SortWorkersByMoneyPerHours(List<Worker> workersList)
        {
            var sortedList = workersList.OrderByDescending(x => x.MoneyPerHour());

            // Print workers
            Console.WriteLine("---------- WORKERS ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}", element.FirstName+ " " + element.LastName);
                Console.WriteLine("Week salary: " + element.WeekSalary);
                Console.WriteLine("Work hours per day: " + element.WorkHoursPerDay);
                Console.WriteLine("Money per hours: " + element.MoneyPerHour());
                Console.WriteLine();
            }
        }

        // Sort merged list by first name and last name
        static void SortMergedList(List<Human> mergedList)
        {
            var sortedList =
                from merge in mergedList
                orderby merge.FirstName, merge.LastName
                select merge;

            // Print merged list
            Console.WriteLine("---------- MERGED LIST ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("First name: {0}, Last name: {1}", element.FirstName, element.LastName);
            }
        }

        static void Main(string[] args)
        {
            // List of 10 students
            List<Student> studentsList = new List<Student>()
            {
                new Student("Plamen", "Georgiev", 12),
                new Student("Ivan", "Ivanov", 1),
                new Student("Gosho", "Goshov", 1),
                new Student("Katrin", "Dimitrova", 3),
                new Student("Pesho", "Peshov", 9),
                new Student("Maria", "Borisova", 5),
                new Student("Gabriela", "Marinova", 3),
                new Student("Petko", "Petkov", 8),
                new Student("Kiril", "Kirilov", 8),
                new Student("Dimitar", "Dimitrov", 4)
            };

            // List of 10 workers
            List<Worker> workersList = new List<Worker>()
            {
                new Worker("Kosta", "Kostov", 555, 4),
                new Worker("Krum", "Krumov", 900, 12),
                new Worker("Mira", "Stamenova", 100, 40),
                new Worker("Petka", "Petkanova", 1021, 50),
                new Worker("Stefan", "Stefanov", 200, 21),
                new Worker("Jordan", "Jordanov", 111, 10),
                new Worker("Nikolay", "Georgiev", 1000, 9),
                new Worker("Stamat", "Stamatov", 11, 11),
                new Worker("Goran", "Goranov", 88, 8),
                new Worker("Samuil", "Samuilov", 1111, 11)
            };

            // Call methods
            SortStudentByGrade(studentsList);
            SortWorkersByMoneyPerHours(workersList);

            // Merge studentsList and workersList
            List<Human> mergeList = new List<Human>();
            mergeList.AddRange(studentsList);
            mergeList.AddRange(workersList);

            // Call method
            SortMergedList(mergeList);
        }
    }
}
