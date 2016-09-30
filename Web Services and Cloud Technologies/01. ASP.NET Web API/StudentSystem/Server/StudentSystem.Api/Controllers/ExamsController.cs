namespace StudentSystem.Api.Controllers
{
    using Models.Exams;
    using Services.Data;
    using Services.Data.Contracts;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;
    public class ExamsController : ApiController
    {
        private readonly IExamsService exams;

        public ExamsController(IExamsService examsService)
        {
            this.exams = examsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(ExamResponseModel exam)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var addedExamId = this.exams.Add(exam.Date, exam.Address, exam.CourseId);

            return this.Ok(addedExamId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var exams = this.exams.All()
                .Select(ExamResponseModel.FromExam);

            return this.Ok(exams);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var exam = this.exams.All()
                .Select(ExamResponseModel.FromExam)
                .FirstOrDefault(e => e.Id == id);

            if (exam == null)
            {
                return this.NotFound();
            }

            return this.Ok(exam);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult ByCourseId(int id)
        {
            var exams = this.exams.All()
                .Select(ExamResponseModel.FromExam)
                .Where(e => e.CourseId == id);

            if (exams == null)
            {
                return this.NotFound();
            }

            return this.Ok(exams);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, ExamResponseModel exam)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedExamId = this.exams.Update(id, exam.Date, exam.Address, exam.CourseId);

            if (updatedExamId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedExamId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedExamId = this.exams.Delete(id);

            if (deletedExamId == null)
            {
                return this.NotFound();
            }
            

            return this.Ok(id);
        }
    }
}