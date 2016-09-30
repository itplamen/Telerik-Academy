namespace MusicCompany.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using MusicCompany.Models;

    public interface IAlbumsService
    {
        IQueryable<Album> All();

        int Add(string title, DateTime? releaseDate, string producer);

        int? Update(int id, string title, DateTime? releaseDate, string producer);

        int? Delete(int id);
    }
}
