using StudentSystem.Services.Data;
using StudentSystem.Services.Data.Contracts;
using StudentSystem.Api.Models.Students;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSystem.Api.Controllers
{
    public class StudentsController : ApiController
    {
        private IStudentsService students;

        public StudentsController(IStudentsService studentsService)
        {
            this.students = studentsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(StudentResponseModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newStudentId = this.students.Add(student.FirstName, student.LastName, student.Email);

            return this.Ok(newStudentId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var allStudents = this.students.All()
                .Select(StudentResponseModel.FromStudent);

            return this.Ok(allStudents);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var student = this.students.All()
                .Select(StudentResponseModel.FromStudent)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return this.NotFound();
            }

            return this.Ok(student);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, StudentResponseModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedStudentId = this.students.Update(id, student.FirstName, student.LastName, student.Email);

            if (updatedStudentId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedStudentId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedStudentId = this.students.Delete(id);

            if (deletedStudentId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedStudentId);
        }
    }
}