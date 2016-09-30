using System;
using System.Linq;
using StudentSystem.Model;
using StudentSystem.Services.Data.Contracts;
using StudentSystem.Data;

namespace StudentSystem.Services.Data
{
    public class MaterialsService : IMaterialsService
    {
        private readonly IRepository<Material> materials;

        public MaterialsService(IRepository<Material> materialsRepo)
        {
            this.materials = materialsRepo;
        }

        public IQueryable<Material> All()
        {
            return this.materials.All();
        }

        public int Add(MaterialType type, int lectureId)
        {
            var newMaterial = new Material
            {
                Type = type,
                LectureId = lectureId
            };

            this.materials.Add(newMaterial);
            this.materials.SaveChanges();

            return newMaterial.Id;
        }

        public int? Update(int id, MaterialType type, int lectureId)
        {
            var materialToUpdate = this.All()
                .FirstOrDefault(m => m.Id == id);

            if (materialToUpdate != null)
            {
                materialToUpdate.Type = type;
                materialToUpdate.LectureId = lectureId;
                this.materials.SaveChanges();

                return materialToUpdate.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var material = this.materials.All()
                .FirstOrDefault(m => m.Id == id);

            if (material != null)
            {
                this.materials.Delete(material);
                this.materials.SaveChanges();

                return material.Id;
            }

            return null;
        }
    }
}
