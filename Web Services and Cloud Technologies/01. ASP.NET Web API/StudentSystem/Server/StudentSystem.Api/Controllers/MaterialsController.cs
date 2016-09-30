using StudentSystem.Api.Models.Materials;
using StudentSystem.Services.Data;
using StudentSystem.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSystem.Api.Controllers
{
    public class MaterialsController : ApiController
    {
        private IMaterialsService materials;

        public MaterialsController(IMaterialsService materialsService)
        {
            this.materials = materialsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(MaterialResponseModel material)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newMaterialId = this.materials.Add(material.Type, material.LectureId);

            return this.Ok(newMaterialId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var allLecturers = this.materials.All()
                .Select(MaterialResponseModel.FromMaterial);

            return this.Ok(allLecturers);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var lecturer = this.materials.All()
                .Select(MaterialResponseModel.FromMaterial)
                .FirstOrDefault(s => s.Id == id);

            if (lecturer == null)
            {
                return this.NotFound();
            }

            return this.Ok(lecturer);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, MaterialResponseModel material)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedMaterialId = this.materials.Update(id, material.Type, material.LectureId);

            if (updatedMaterialId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedMaterialId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedMaterialId = this.materials.Delete(id);

            if (deletedMaterialId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedMaterialId);
        }
    }
}