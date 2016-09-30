namespace StudentSystem.Api.Models.Lectures
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class LectureResponseModel
    {
        public static Expression<Func<Lecture, LectureResponseModel>> FromLecture
        {
            get
            {
                return lecture => new LectureResponseModel
                {
                    Id = lecture.Id,
                    Name = lecture.Name,
                    CourseId = lecture.CourseId
                };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CourseId { get; set; }
    }
}