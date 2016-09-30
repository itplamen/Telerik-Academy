namespace MusicCompany.Services.Data
{
    using System;
    using System.Linq;
    using MusicCompany.Data;
    using MusicCompany.Models;
    using MusicCompany.Services.Data.Contracts;

    public class ArtistsService : IArtistsService
    {
        private readonly IRepository<Artist> artists;

        public ArtistsService(IRepository<Artist> artistsRepo)
        {
            this.artists = artistsRepo;
        }

        public IQueryable<Artist> All()
        {
            return this.artists.All();
        }

        public int Add(string fullName, Country country, DateTime? dateOfBirth)
        {
            var newArtist = new Artist
            {
                FullName = fullName,
                Country = country,
                DateOfBirth = dateOfBirth
            };

            this.artists.Add(newArtist);
            this.artists.SaveChanges();

            return newArtist.Id;
        }

        public int? Update(int id, string fullName, Country country, DateTime? dateOfBirth)
        {
            var existingArtist = this.All()
                .FirstOrDefault(a => a.Id == id);

            if (existingArtist != null)
            {
                existingArtist.FullName = fullName;
                existingArtist.Country = country;
                existingArtist.DateOfBirth = dateOfBirth;
                this.artists.SaveChanges();

                return existingArtist.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var artist = this.artists.All()
                .FirstOrDefault(a => a.Id == id);

            if (artist != null)
            {
                this.artists.Delete(artist);
                this.artists.SaveChanges();

                return artist.Id;
            }

            return null;
        }
    }
}
