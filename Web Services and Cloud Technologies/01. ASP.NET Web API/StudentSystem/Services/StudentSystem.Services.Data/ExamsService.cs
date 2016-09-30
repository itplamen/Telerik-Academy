namespace StudentSystem.Services.Data
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Services.Data.Contracts;

    public class ExamsService : IExamsService
    {
        private readonly IRepository<Exam> exams;

        public ExamsService(IRepository<Exam> examsRepo)
        {
            this.exams = examsRepo;
        }

        public IQueryable<Exam> All()
        {
            return this.exams.All();
        }

        public int Add(DateTime? date, string address, int courseId)
        {
            var newExam = new Exam
            {
                Date = date,
                Address = address,
                CourseId = courseId
            };

            this.exams.Add(newExam);
            this.exams.SaveChanges();

            return newExam.Id;
        }

        public int? Update(int id, DateTime? date, string address, int courseId)
        {
            var existingExam = this.All()
                .FirstOrDefault(e => e.Id == id);

            if (existingExam != null)
            {
                existingExam.Date = date;
                existingExam.Address = address;
                existingExam.CourseId = courseId;
                this.exams.SaveChanges();

                return existingExam.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var exam = this.All()
                .FirstOrDefault(e => e.Id == id);

            if (exam != null)
            {
                this.exams.Delete(exam);
                this.exams.SaveChanges();

                return exam.Id;
            }

            return null;
        }
    }
}
