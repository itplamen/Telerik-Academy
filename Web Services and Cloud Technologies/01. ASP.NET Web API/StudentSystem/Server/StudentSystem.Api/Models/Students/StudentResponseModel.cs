namespace StudentSystem.Api.Models.Students
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class StudentResponseModel
    {
        public static Expression<Func<Student, StudentResponseModel>> FromStudent
        {
            get
            {
                return student => new StudentResponseModel
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email
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

        [Required]
        public string Email { get; set; }
    }
}