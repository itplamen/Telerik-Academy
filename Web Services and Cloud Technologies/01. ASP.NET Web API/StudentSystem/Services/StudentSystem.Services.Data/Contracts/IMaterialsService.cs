namespace StudentSystem.Services.Data.Contracts
{
    using System.Linq;

    using StudentSystem.Model;

    public interface IMaterialsService
    {
        IQueryable<Material> All();

        int Add(MaterialType type, int lectureId);

        int? Update(int id, MaterialType type, int lectureId);

        int? Delete(int id);
    }
}
