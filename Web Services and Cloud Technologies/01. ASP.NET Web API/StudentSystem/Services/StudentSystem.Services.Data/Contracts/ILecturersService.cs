namespace StudentSystem.Services.Data.Contracts
{
    using System.Linq;

    using StudentSystem.Model;
    using System.Collections.Generic;
    public interface ILecturersService
    {
        IQueryable<Lecturer> All();

        int Add(string firstName, string lastName, ICollection<Course> courses);

        int? Update(int id, string firstName, string lastName, ICollection<Course> courses);

        int? Delete(int id);
    }
}
