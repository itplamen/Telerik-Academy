using StudentSystem.Api.Models.Lecturers;
using StudentSystem.Services.Data;
using StudentSystem.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSystem.Api.Controllers
{
    public class LecturersController : ApiController
    {
        private ILecturersService lecturers;

        public LecturersController(ILecturersService lecturersService)
        {
            this.lecturers = lecturersService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(LecturerResponseModel lecturer)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newLecturerId = this.lecturers.Add(lecturer.FirstName, lecturer.LastName, lecturer.Courses);

            return this.Ok(newLecturerId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var allLecturers = this.lecturers.All()
                .Select(LecturerResponseModel.FromLecturer);

            return this.Ok(allLecturers);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var lecturer = this.lecturers.All()
                .Select(LecturerResponseModel.FromLecturer)
                .FirstOrDefault(s => s.Id == id);

            if (lecturer == null)
            {
                return this.NotFound();
            }

            return this.Ok(lecturer);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, LecturerResponseModel lecturer)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedLecturerId = this.lecturers.Update(id, lecturer.FirstName, lecturer.LastName, lecturer.Courses);

            if (updatedLecturerId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedLecturerId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedLecturerId = this.lecturers.Delete(id);

            if (deletedLecturerId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedLecturerId);
        }
    }
}