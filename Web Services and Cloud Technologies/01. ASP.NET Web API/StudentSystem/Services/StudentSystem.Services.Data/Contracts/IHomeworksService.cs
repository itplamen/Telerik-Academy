namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Model;

    public interface IHomeworksService
    {
        IQueryable<Homework> All();

        int Add(string description, DateTime? timeSent, int studentId, int courseId);

        int? Update(int id, string description, DateTime? timeSent, int studentId, int courseId);

        int? Delete(int id);
    }
}
