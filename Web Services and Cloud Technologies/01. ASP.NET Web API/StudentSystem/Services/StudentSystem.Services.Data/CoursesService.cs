namespace StudentSystem.Services.Data
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Services.Data.Contracts;

    public class CoursesService : ICoursesService
    {
        private readonly IRepository<Course> courses;

        public CoursesService(IRepository<Course> coursesRepo)
        {
            this.courses = coursesRepo;
        }

        public IQueryable<Course> All()
        {
            return this.courses.All();
        }

        public int Add(CourseType name, string description, DateTime? startDate, DateTime? endDate)
        {
            var newCourse = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate
            };

            this.courses.Add(newCourse);
            this.courses.SaveChanges();

            return newCourse.Id;
        }

        public int? Update(int id, CourseType name, string description, DateTime? startDate, DateTime? endDate)
        {
            var courseForUpdate = this.All()
                .FirstOrDefault(c => c.Id == id);

            if (courseForUpdate != null)
            {
                courseForUpdate.Name = name;
                courseForUpdate.Description = description;
                courseForUpdate.StartDate = startDate;
                courseForUpdate.EndDate = endDate;
                this.courses.SaveChanges();

                return courseForUpdate.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var course = this.All()
                .FirstOrDefault(c => c.Id == id);

            if (course != null)
            {
                this.courses.Delete(course);
                this.courses.SaveChanges();
                return course.Id;
            }

            return null;
        }
    }
}
