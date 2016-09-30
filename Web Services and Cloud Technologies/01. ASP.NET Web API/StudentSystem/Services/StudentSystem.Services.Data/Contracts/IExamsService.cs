namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Model;

    public interface IExamsService
    {
        IQueryable<Exam> All();

        int Add(DateTime? date, string address, int courseId);

        int? Update(int id, DateTime? date, string address, int courseId);

        int? Delete(int id);
    }
}
