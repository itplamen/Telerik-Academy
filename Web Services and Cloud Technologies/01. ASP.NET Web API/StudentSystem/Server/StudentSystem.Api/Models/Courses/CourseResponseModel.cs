namespace StudentSystem.Api.Models.Courses
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Model;
    using System.Collections.Generic;

    public class CourseResponseModel
    {
        public static Expression<Func<Course, CourseResponseModel>> FromCourse
        {
            get
            {
                return course => new CourseResponseModel
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    StartDate = course.StartDate,
                    EndDate = course.EndDate
                };
            }
        }

        public int Id { get; set; }

        public CourseType Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }   
}