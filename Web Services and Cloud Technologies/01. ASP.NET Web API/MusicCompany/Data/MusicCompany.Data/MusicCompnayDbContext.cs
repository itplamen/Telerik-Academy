using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MusicCompany.Model;
using MusicCompany.Models;

namespace MusicCompany.Data
{
    public class MusicCompanyDbContext : IdentityDbContext<User>, IMusicCompanyDbContext
    {
        public MusicCompanyDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Album> Albums{ get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public static MusicCompanyDbContext Create()
        {
            return new MusicCompanyDbContext();
        }
    }
}
