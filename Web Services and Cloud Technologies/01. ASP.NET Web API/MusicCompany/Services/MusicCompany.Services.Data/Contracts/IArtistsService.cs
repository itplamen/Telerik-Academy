namespace MusicCompany.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using MusicCompany.Models;

    public interface IArtistsService
    {
        IQueryable<Artist> All();

        int Add(string fullName, Country country, DateTime? dateOfBirth);

        int? Update(int id, string fullName, Country country, DateTime? dateOfBirth);

        int? Delete(int id);
    }
}
