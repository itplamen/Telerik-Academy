namespace MusicCompany.Services.Data
{
    using System;
    using System.Linq;
    using MusicCompany.Data;
    using MusicCompany.Models;
    using MusicCompany.Services.Data.Contracts;

    public class SongsService : ISongsService
    {
        private readonly IRepository<Song> songs;

        public SongsService(IRepository<Song> songsRepo)
        {
            this.songs = songsRepo;
        }

        public IQueryable<Song> All()
        {
            return this.songs.All();
        }

        public int Add(string title, DateTime? releaseDate, Genre genre, int albumId)
        {
            var newSong = new Song
            {
                Title = title,
                ReleaseDate = releaseDate,
                Genre = genre,
                AlbumId = albumId
            };

            this.songs.Add(newSong);
            this.songs.SaveChanges();

            return newSong.Id;
        }

        public int? Update(int id, string title, DateTime? releaseDate, Genre genre, int albumId)
        {
            var existingSong = this.All()
                .FirstOrDefault(s => s.Id == id);

            if (existingSong != null)
            {
                existingSong.Title = title;
                existingSong.ReleaseDate = releaseDate;
                existingSong.Genre = genre;
                existingSong.AlbumId = albumId;
                this.songs.SaveChanges();

                return existingSong.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var song = this.All()
                .FirstOrDefault(s => s.Id == id);

            if (song != null)
            {
                this.songs.Delete(song);
                this.songs.SaveChanges();

                return song.Id;
            }

            return null;
        }
    }
}
