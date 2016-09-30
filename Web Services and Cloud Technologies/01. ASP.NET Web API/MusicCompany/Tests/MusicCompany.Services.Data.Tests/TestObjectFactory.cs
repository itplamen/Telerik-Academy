using MusicCompany.Models;
using System;

namespace MusicCompany.Services.Data.Tests
{
    public static class TestObjectFactory
    {
        public static InMemoryRepository<Album> GetAlbumsRepositoty()
        {
            var repo = new InMemoryRepository<Album>();

            for (int i = 0; i < 25; i++)
            {
                repo.Add(new Album
                {
                    Title = "Test Title " + i,
                    ReleaseDate = DateTime.Now,
                    Producer = "Test Producer " + i
                });
            }

            return repo;
        }

        public static InMemoryRepository<Artist> GetArtistsRepositoty()
        {
            var repo = new InMemoryRepository<Artist>();

            for (int i = 0; i < 25; i++)
            {
                repo.Add(new Artist
                {
                    FullName = "Test name",
                    Country = Country.Bulgaria,
                    DateOfBirth = null
                });
            }

            return repo;
        }
    }
}
