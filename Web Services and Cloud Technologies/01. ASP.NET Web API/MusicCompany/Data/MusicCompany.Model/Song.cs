namespace MusicCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Song
    {
        private ICollection<Artist> artists;

        public Song()
        {
            this.artists = new HashSet<Artist>();
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

        public virtual Album Album { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}
