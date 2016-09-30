namespace MusicCompany.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using MusicCompany.Models;
    
    public interface ISongsService
    {
        IQueryable<Song> All();

        int Add(string title, DateTime? releaseDate, Genre genre, int albumId);

        int? Update(int id, string title, DateTime? releaseDate, Genre genre, int albumId);

        int? Delete(int id);
    }
}
