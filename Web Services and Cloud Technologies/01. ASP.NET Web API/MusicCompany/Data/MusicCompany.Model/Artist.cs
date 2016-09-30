namespace MusicCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        private ICollection<Album> albums;
        private ICollection<Song> songs;

        public Artist()
        {
            this.albums = new HashSet<Album>();
            this.songs = new HashSet<Song>();
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

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }

        public virtual ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
