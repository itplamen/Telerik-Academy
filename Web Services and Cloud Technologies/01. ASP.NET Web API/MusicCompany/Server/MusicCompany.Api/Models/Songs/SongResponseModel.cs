using MusicCompany.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace MusicCompany.Api.Models.Songs
{
    public class SongResponseModel
    {
        public static Expression<Func<Song, SongResponseModel>> FromSong
        {
            get
            {
                return song => new SongResponseModel
                {
                    Id = song.Id,
                    Title = song.Title,
                    ReleaseDate = song.ReleaseDate,
                    AlbumId = song.AlbumId
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }
    }
}