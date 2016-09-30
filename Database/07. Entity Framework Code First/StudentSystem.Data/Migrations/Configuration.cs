namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using StudentSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            this.ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext context)
        {
            this.SeedCourses(context);
            this.SeedLecturers(context);
            this.SeedStudents(context);
            this.SeedLectures(context);
            this.SeedExams(context);
        }

        private void SeedCourses(StudentSystemContext context)
        {
            if (!context.Courses.Any())
            {
                var databaseCourse = new Course
                {
                    Name = CourseType.Databases,
                    Description = "Learn SQL Server, MySQL, MongoDB...",
                    StartDate = new DateTime(2015, 10, 1),
                    EndDate = new DateTime(2015, 11, 5)
                };

                var oopCourse = new Course
                {
                    Name = CourseType.OOP,
                    Description = "Learn Object Oriented Programming (OOP) with C#",
                    StartDate = null,
                    EndDate = null
                };

                context.Courses.Add(databaseCourse);
                context.Courses.Add(oopCourse);
                context.SaveChanges();
            }
        }

        private void SeedLecturers(StudentSystemContext context)
        {
            if (!context.Lecturers.Any())
            {
                var nikolayKostovLecturer = new Lecturer
                {
                    FirsName = "Nikolay",
                    LastName = "Kostov",
                    JobPosition = JobPosition.Manager,
                    Description = "..."
                };

                var donchoMinkovLecturer = new Lecturer
                {
                    FirsName = "Doncho",
                    LastName = "Minkov",
                    JobPosition = JobPosition.SeniorTechnicalTrainer,
                    Description = "..."
                };

                var ivayloKenovLecturer = new Lecturer
                {
                    FirsName = "Ivaylo",
                    LastName = "Kenov",
                    JobPosition = JobPosition.JuniorTechnicalTrainer,
                    Description = "..."
                };

                var databasesCourse = this.GetDatabasesCourse(context);
                nikolayKostovLecturer.Courses.Add(databasesCourse);
                donchoMinkovLecturer.Courses.Add(databasesCourse);
                ivayloKenovLecturer.Courses.Add(databasesCourse);

                var oopCourse = this.GetOOPCourse(context);
                nikolayKostovLecturer.Courses.Add(oopCourse);
                ivayloKenovLecturer.Courses.Add(oopCourse);

                context.Lecturers.Add(nikolayKostovLecturer);
                context.Lecturers.Add(donchoMinkovLecturer);
                context.Lecturers.Add(ivayloKenovLecturer);
                context.SaveChanges();
            }
        }
        
        private void SeedStudents(StudentSystemContext context)
        {
            if (!context.Students.Any())
            {
                var firstStudent = new Student
                {
                    FirstName = "Plamen",
                    LastName = "Georgiev",
                    Email = "itplamen@gmail.com",
                    RegistrationDate = DateTime.Now,
                    Age = 24,
                    Gender = Gender.Male,
                    City = City.Other
                };

                var secondStudent = new Student
                {
                    FirstName = "Maria",
                    LastName = "Marinova",
                    Email = "maria_marinova@abv.bg",
                    RegistrationDate = new DateTime(2014, 6, 14),
                    Age = null,
                    Gender = Gender.Female,
                    City = null
                };

                var thirdStudent = new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "ivan@ivanov.com",
                    RegistrationDate = DateTime.Now,
                    Age = null,
                    Gender = null,
                    City = null
                };

                var databasesCourse = this.GetDatabasesCourse(context);

                firstStudent.Homeworks.Add(new Homework
                {
                    Description = "Homework for databases course.",
                    TimeSent = DateTime.Now,
                    Course = databasesCourse
                });

                secondStudent.Homeworks.Add(new Homework
                {
                    Description = "Homework for databases course.",
                    TimeSent = DateTime.Now,
                    Course = databasesCourse
                });

                secondStudent.Homeworks.Add(new Homework
                {
                    Description = "Homework for oop course.",
                    TimeSent = DateTime.Now,
                    Course = this.GetOOPCourse(context)
                });
                
                firstStudent.Courses.Add(databasesCourse);
                secondStudent.Courses.Add(databasesCourse);
                thirdStudent.Courses.Add(databasesCourse);
                
                context.Students.Add(firstStudent);
                context.Students.Add(secondStudent);
                context.Students.Add(thirdStudent);
                context.SaveChanges();
            }          
        }

        private void SeedLectures(StudentSystemContext context)
        {
            if (!context.Lectures.Any())
            {
                var databaseCourse = this.GetDatabasesCourse(context);

                var entityFrameworkLecture = new Lecture
                {
                    Name = "Entity Framework Code First",
                    Course = databaseCourse
                };

                entityFrameworkLecture.Materials.Add(new Material
                {
                    Type = MaterialType.Presentation
                });

                entityFrameworkLecture.Materials.Add(new Material
                {
                    Type = MaterialType.Video
                });

                entityFrameworkLecture.Materials.Add(new Material
                {
                    Type = MaterialType.SourceCode
                });

                var sqlLecture = new Lecture
                {
                    Name = "SQL",
                    Course = databaseCourse
                };

                sqlLecture.Materials.Add(new Material
                {
                    Type = MaterialType.Video
                });

                var oopLecture = new Lecture
                {
                    Name = "Intro OOP",
                    Course = this.GetOOPCourse(context)
                };

                oopLecture.Materials.Add(new Material
                {
                    Type = MaterialType.Presentation
                });

                oopLecture.Materials.Add(new Material
                {
                    Type = MaterialType.Video
                });

                context.Lectures.Add(entityFrameworkLecture);
                context.Lectures.Add(sqlLecture);
                context.Lectures.Add(oopLecture);
                context.SaveChanges();
            }
        }

        private void SeedExams(StudentSystemContext context)
        {
            if (!context.Exams.Any())
            {
                var databasesExam = new Exam
                {
                    Date = new DateTime(2015, 12, 10),
                    Adress = "Sofia ul. Hristo Botev",
                    Course = this.GetDatabasesCourse(context)
                };

                var oopExam = new Exam
                {
                    Date = DateTime.Now,
                    Adress = "Sofia ul. Hristo Botev",
                    Course = this.GetOOPCourse(context)
                };

                if (!databasesExam.IsDateValid || !oopExam.IsDateValid)
                {
                    throw new ArgumentException("Invalid exam date!");
                }

                databasesExam.Students.Add(new Student
                {
                    FirstName = "Krasimir",
                    LastName = "Petkov",
                    Email = "krasen@petkov.com",
                    RegistrationDate = DateTime.Now,
                    Age = 21,
                    City = City.Pleven,
                    Gender = Gender.Male
                });

                databasesExam.Students.Add(new Student
                {
                    FirstName = "Gergana",
                    LastName = "Ivanova",
                    Email = "g_ivanova@abv.bg",
                    RegistrationDate = DateTime.Now,
                    Age = null,
                    City = null,
                    Gender = Gender.Female
                });

                databasesExam.Students.Add(new Student
                {
                    FirstName = "Alexander",
                    LastName = "Alexandrov",
                    Email = "aalexandrov@abv.bg",
                    RegistrationDate = DateTime.Now,
                    Age = null,
                    City = null,
                    Gender = null
                });

                oopExam.Students.Add(new Student
                {
                    FirstName = "Elena",
                    LastName = "Ivanova",
                    Email = "e_ivanova@abv.bg",
                    RegistrationDate = DateTime.Now,
                    Age = 32,
                    City = City.Varna,
                    Gender = Gender.Female
                });

                context.Exams.Add(databasesExam);
                context.Exams.Add(oopExam);
                context.SaveChanges();
            }
        }

        private Course GetDatabasesCourse(StudentSystemContext context)
        {
            return context.Courses
                .FirstOrDefault(dbc => dbc.Name == CourseType.Databases);
        }

        private Course GetOOPCourse(StudentSystemContext context)
        {
            return context.Courses
                .FirstOrDefault(c => c.Name == CourseType.OOP);
        }
    }
}
