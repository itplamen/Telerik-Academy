namespace StudentSystem.Api.Models.Materials
{
    using System;
    using System.Linq.Expressions;

    using StudentSystem.Model;

    public class MaterialResponseModel
    {
        public static Expression<Func<Material, MaterialResponseModel>> FromMaterial
        {
            get
            {
                return material => new MaterialResponseModel
                {
                    Id = material.Id,
                    Type = material.Type,
                    LectureId = material.LectureId
                };  
            }
        }

        public int Id { get; set; }

        public MaterialType Type { get; set; }

        public int LectureId { get; set; }
    }
}