namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Model;

    public interface ILecturesService
    {
        IQueryable<Lecture> All();

        int Add(string name, int courseId);

        int? Update(int id, string name, int courseId);

        int? Delete(int id);
    }
}
