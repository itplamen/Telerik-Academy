// 01. Using code first approach, create database for
// student system with the following tables:
//  - Students (with Id, Name, Number, etc.)
//  - Courses (Name, Description, Materials, etc.)
//  - StudentsInCourses (many-to-many relationship)
//  - Homework (one-to-many relationship with
//  students and courses), fields: Content, TimeSent
//  - Annotate the data models with the appropriate
//  attributes and enable code first migrations
// 02. Write a console application that uses the data
// 03. Seed the data with random values

namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Data.Repositories;
    using StudentSystem.Model;
    
    internal class Program
    {
        private static void PrintStudentsFromDatabasesCourse(IGenericRepository<Course> coursesDb)
        {
            var databasesCourse = coursesDb.All()
                .Where(c => c.Name == CourseType.Databases)
                .Select(c => new
                {
                    Name = c.Name,
                    Students = c.Students
                        .OrderBy(s => s.FirstName)
                        .Select(s => new
                        {
                            Name = s.FirstName + " " + s.LastName,
                            Email = s.Email
                        })
                });

            foreach (var course in databasesCourse)
            {
                Console.WriteLine("Students in " + course.Name + " course:");
                foreach (var student in course.Students)
                {
                    Console.WriteLine("{0}, {1} ", student.Name, student.Email);
                }
            }

            Console.WriteLine();
        }

        private static void PrintDatabasesLecturesAndMaterials(IGenericRepository<Lecture> lectures)
        {
            var databaseLectures = lectures.All()
                .Where(l => l.Course.Name == CourseType.Databases)
                .Select(l => new
                {
                    Name = l.Name,
                    Course = l.Course.Name,
                    Materials = l.Materials
                });

            foreach (var lecture in databaseLectures)
            {
                Console.WriteLine("Lecture: " + lecture.Name + " (" + lecture.Course + " course), materials:");
                foreach (var material in lecture.Materials)
                {
                    Console.WriteLine(material.Type);
                }

                Console.WriteLine("--------------");
            }

            Console.WriteLine();
        }

        private static void PrintCoursesAndHomeworks(IGenericRepository<Course> courses)
        {
            var allCourses = courses.All()
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    Name = c.Name,
                    Homeworks = c.Homeworks
                        .OrderBy(h => h.Description)
                        .ThenBy(h => h.Student.FirstName)
                        .Select(h => new
                        {
                            Description = h.Description,
                            Student = h.Student.FirstName + " " + h.Student.LastName,
                            TimeSent = h.TimeSent
                        })
                });

            foreach (var course in allCourses)
            {
                Console.WriteLine("Course: " + course.Name);
                foreach (var homework in course.Homeworks)
                {
                    Console.WriteLine("{0}, sended by {1} at {2}", homework.Description, homework.Student, homework.TimeSent);
                }

                Console.WriteLine("--------------");
            }
        }

        public static void Main()
        {
            var data = new StudentSystemData();
            PrintStudentsFromDatabasesCourse(data.Courses);
            PrintDatabasesLecturesAndMaterials(data.Lectures);
            PrintCoursesAndHomeworks(data.Courses);
        }
    }
}
