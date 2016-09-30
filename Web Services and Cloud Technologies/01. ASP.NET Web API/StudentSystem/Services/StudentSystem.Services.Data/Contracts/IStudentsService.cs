namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Model;

    public interface IStudentsService
    {
        IQueryable<Student> All();

        int Add(string firstName, string lastName, string email);

        int? Update(int id, string firstName, string lastName, string email);

        int? Delete(int id);
    }
}
