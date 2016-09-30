namespace MusicCompany.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MusicCompanyDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MusicCompanyDbContext context)
        {
            this.SeedAlbums(context);
            this.SeedArtist(context);
            this.SeedSongs(context);
        }

        private void SeedAlbums(MusicCompanyDbContext context)
        {
            if (!context.Albums.Any())
            {
                var firstAlbum = new Album
                {
                    Title = "Burn",
                    ReleaseDate = DateTime.Now,
                    Producer = "Deep Purple"
                };

                firstAlbum.Artists.Add(new Artist
                {
                    FullName = "Ritchie Blackmore",
                    Country = Country.UK,
                    DateOfBirth = new DateTime(1945, 4, 14)
                });

                firstAlbum.Artists.Add(new Artist
                {
                    FullName = "David Coverdale",
                    Country = Country.UK,
                    DateOfBirth = new DateTime(1951, 09, 22)
                });

                firstAlbum.Songs.Add(new Song
                {
                    Title = "Mistreated",
                    ReleaseDate = new DateTime(1974, 02, 15),
                    Genre = Genre.Rock
                });

                var secondAlbum = new Album
                {
                    Title = "Made in Japan",
                    ReleaseDate = null,
                    Producer = "Deep Purple"
                };

                secondAlbum.Artists.Add(new Artist
                {
                    FullName = "Ian Gillan",
                    Country = Country.UK,
                    DateOfBirth = null
                });

                secondAlbum.Songs.Add(new Song
                {
                    Title = "Lazy",
                    ReleaseDate = null,
                    Genre = Genre.Rock
                });

                var thirdAlbum = new Album
                {
                    Title = "ABC Ablum",
                    ReleaseDate = DateTime.Now,
                    Producer = "Ivan Petkov"
                };

                context.Albums.Add(firstAlbum);
                context.Albums.Add(secondAlbum);
                context.Albums.Add(thirdAlbum);
                context.SaveChanges();
            }
        }

        private void SeedArtist(MusicCompanyDbContext context)
        {
            if (!context.Artists.Any())
            {
                var firstArtist = new Artist
                {
                    FullName = "Maria Ilieva",
                    Country = Country.Bulgaria,
                    DateOfBirth = null
                };

                var secondArtist = new Artist
                {
                    FullName = "Jay Z",
                    Country = Country.USA,
                    DateOfBirth = null
                };

                secondArtist.Songs.Add(new Song
                {
                    Title = "Glory",
                    ReleaseDate = null,
                    Genre = Genre.HipHop
                });

                context.SaveChanges();
            }
        }

        private void SeedSongs(MusicCompanyDbContext context)
        {
            if (!context.Songs.Any())
            {
                var song = new Song
                {
                    Title = "Black hearth",
                    ReleaseDate = DateTime.Now,
                    Genre = Genre.Metal
                };

                context.SaveChanges();
            }
        }
    }
}
