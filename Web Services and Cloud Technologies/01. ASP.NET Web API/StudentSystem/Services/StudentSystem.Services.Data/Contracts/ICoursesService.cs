namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Model;

    public interface ICoursesService
    {
        IQueryable<Course> All();

        int Add(CourseType name, string description, DateTime? startDate, DateTime? endDate);

        int? Update(int id, CourseType name, string description, DateTime? startDate, DateTime? endDate);

        int? Delete(int id);
    }
}
