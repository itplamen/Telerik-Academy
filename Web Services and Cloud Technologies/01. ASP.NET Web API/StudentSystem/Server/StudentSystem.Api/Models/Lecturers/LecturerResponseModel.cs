namespace StudentSystem.Api.Models.Lecturers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class LecturerResponseModel
    {
        public static Expression<Func<Lecturer, LecturerResponseModel>> FromLecturer
        {
            get
            {
                return lecturer => new LecturerResponseModel
                {
                    Id = lecturer.Id,
                    FirstName = lecturer.FirsName,
                    LastName = lecturer.LastName,
                    Courses = lecturer.Courses
                };
            }
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}