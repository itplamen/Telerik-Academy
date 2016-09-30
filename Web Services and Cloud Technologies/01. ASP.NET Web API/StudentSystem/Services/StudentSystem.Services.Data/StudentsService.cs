namespace StudentSystem.Services.Data
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Services.Data.Contracts;
    
    public class StudentsService : IStudentsService
    {
        private readonly IRepository<Student> students;

        public StudentsService(IRepository<Student> studentsRepo)
        {
            this.students = studentsRepo;
        }

        public IQueryable<Student> All()
        {
            return this.students.All();
        }

        public int Add(string firstName, string lastName, string email)
        {
            var newStudent = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            this.students.Add(newStudent);
            this.students.SaveChanges();

            return newStudent.Id;
        }

        public int? Update(int id, string firstName, string lastName, string email)
        {
            var existingStudent = this.students.All()
                .FirstOrDefault(s => s.Id == id);

            if (existingStudent != null)
            {
                existingStudent.FirstName = firstName;
                existingStudent.LastName = lastName;
                existingStudent.Email = email;
                this.students.SaveChanges();

                return existingStudent.Id;
            }

            return null;    
        }

        public int? Delete(int id)
        {
            var student = this.students.All()
                .FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                this.students.Delete(student);
                this.students.SaveChanges();

                return student.Id;
            }

            return null;
        }
    }
}
