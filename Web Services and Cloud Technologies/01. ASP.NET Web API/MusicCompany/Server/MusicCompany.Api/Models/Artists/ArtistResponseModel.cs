using MusicCompany.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MusicCompany.Api.Models.Artists
{
    public class ArtistResponseModel
    {
        public static Expression<Func<Artist, ArtistResponseModel>> FromArtist
        {
            get
            {
                return artist => new ArtistResponseModel
                {
                    Id = artist.Id,
                    FullName = artist.FullName,
                    Country = artist.Country,
                    DateOfBirth = artist.DateOfBirth
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(80)]
        public string FullName { get; set; }

        [Required]
        public Country Country { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}