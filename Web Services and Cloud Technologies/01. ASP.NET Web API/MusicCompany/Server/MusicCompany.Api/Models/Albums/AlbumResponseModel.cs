using MusicCompany.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MusicCompany.Api.Models.Albums
{
    public class AlbumResponseModel
    {
        public static Expression<Func<Album, AlbumResponseModel>> FromAlbum
        {
            get
            {
                return album => new AlbumResponseModel
                {
                    Id = album.Id,
                    Title = album.Title,
                    Producer = album.Producer,
                    ReleaseDate = album.ReleaseDate
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public string Producer { get; set; }
    }
}