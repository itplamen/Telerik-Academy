namespace StudentSystem.Api.Models.Homeworks
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class HomeworkResponseModel
    {
        public static Expression<Func<Homework, HomeworkResponseModel>> FromHomework
        {
            get
            {
                return homework => new HomeworkResponseModel
                {
                    Id = homework.Id,
                    Description = homework.Description,
                    TimeSent = homework.TimeSent,
                    StudentId = homework.StudentId,
                    CourseId = homework.CourseId
                };
            }
        }

        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime? TimeSent { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }
    }
}