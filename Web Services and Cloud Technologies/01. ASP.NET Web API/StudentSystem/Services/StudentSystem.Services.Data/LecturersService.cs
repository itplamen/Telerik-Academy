namespace StudentSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Services.Data.Contracts;

    public class LecturersService : ILecturersService
    {
        private readonly IRepository<Lecturer> lecturers;

        public LecturersService(IRepository<Lecturer> lecturersRepo)
        {
            this.lecturers = lecturersRepo;
        }

        public IQueryable<Lecturer> All()
        {
            return this.lecturers.All();
        }

        public int Add(string firstName, string lastName, ICollection<Course> courses)
        {
            var newLecturer = new Lecturer
            {
                FirsName = firstName,
                LastName = lastName,
                Courses = courses
            };

            this.lecturers.Add(newLecturer);
            this.lecturers.SaveChanges();

            return newLecturer.Id;
        }

        public int? Update(int id, string firstName, string lastName, ICollection<Course> courses)
        {
            var lecturerToUpdate = this.All()
                .FirstOrDefault(l => l.Id == id);

            if (lecturerToUpdate != null)
            {
                lecturerToUpdate.FirsName = firstName;
                lecturerToUpdate.LastName = lastName;
                lecturerToUpdate.Courses = courses;
                this.lecturers.SaveChanges();

                return lecturerToUpdate.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var lecturerToDelete = this.All()
                .FirstOrDefault(l => l.Id == id);

            if (lecturerToDelete != null)
            {
                this.lecturers.Delete(lecturerToDelete);
                this.lecturers.SaveChanges();

                return lecturerToDelete.Id;
            }

            return null;
        }        
    }
}
