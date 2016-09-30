using System;
using System.Linq;
using StudentSystem.Model;
using StudentSystem.Services.Data.Contracts;
using StudentSystem.Data;

namespace StudentSystem.Services.Data
{
    public class HomeworksService : IHomeworksService
    {
        private readonly IRepository<Homework> homeworks;

        public HomeworksService(IRepository<Homework> homeworksRepo)
        {
            this.homeworks = homeworksRepo;
        }

        public IQueryable<Homework> All()
        {
            return this.homeworks.All();
        }

        public int Add(string description, DateTime? timeSent, int studentId, int courseId)
        {
            var newHomework = new Homework
            {
                Description = description,
                TimeSent = timeSent,
                StudentId = studentId,
                CourseId = courseId
            };

            this.homeworks.Add(newHomework);
            this.homeworks.SaveChanges();

            return newHomework.Id;
        }

        public int? Update(int id, string description, DateTime? timeSent, int studentId, int courseId)
        {
            var existingHomework = this.homeworks.All()
                .FirstOrDefault(h => h.Id == id);

            if (existingHomework != null)
            {
                existingHomework.Description = description;
                existingHomework.TimeSent = timeSent;
                existingHomework.StudentId = studentId;
                existingHomework.CourseId = courseId;
                this.homeworks.SaveChanges();

                return existingHomework.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var homework = this.homeworks.All()
                .FirstOrDefault(h => h.Id == id);

            if (homework != null)
            {
                this.homeworks.Delete(homework);
                this.homeworks.SaveChanges();

                return homework.Id;
            }

            return null;
        }
    }
}
