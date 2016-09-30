namespace MusicCompany.Services.Data
{
    using System;
    using System.Linq;
    using MusicCompany.Data;
    using MusicCompany.Models;
    using MusicCompany.Services.Data.Contracts;

    public class AlbumsService : IAlbumsService
    {
        private readonly IRepository<Album> albums;

        public AlbumsService(IRepository<Album> albumsRepo)
        {
            this.albums = albumsRepo;
        }

        public IQueryable<Album> All()
        {
            return this.albums.All();
        }

        public int Add(string title, DateTime? releaseDate, string producer)
        {
            var newAlbum = new Album
            {
                Title = title,
                ReleaseDate = releaseDate,
                Producer = producer
            };

            this.albums.Add(newAlbum);
            this.albums.SaveChanges();

            return newAlbum.Id;
        }

        public int? Update(int id, string title, DateTime? releaseDate, string producer)
        {
            var existingAlbum = this.All()
                .FirstOrDefault(a => a.Id == id);

            if (existingAlbum != null)
            {
                existingAlbum.Title = title;
                existingAlbum.ReleaseDate = releaseDate;
                existingAlbum.Producer = producer;
                this.albums.SaveChanges();

                return existingAlbum.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var album = this.All()
               .FirstOrDefault(a => a.Id == id);

            if (album != null)
            {
                this.albums.Delete(album);
                this.albums.SaveChanges();

                return album.Id;
            }

            return null;
        }
    }
}
