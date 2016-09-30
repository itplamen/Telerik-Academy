namespace StudentSystem.Api.Models.Exams
{
    using System;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class ExamResponseModel
    {
        public static Expression<Func<Exam, ExamResponseModel>> FromExam
        {
            get
            {
                return exam => new ExamResponseModel
                {
                    Id = exam.Id,
                    Date = exam.Date,
                    Address = exam.Address,
                    CourseId = exam.CourseId
                };
            }
        }

        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public string Address { get; set; }

        public int CourseId { get; set; }
    }
}