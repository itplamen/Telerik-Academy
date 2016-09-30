using MusicCompany.Data;
using MusicCompany.Data.Migrations;
using System.Data.Entity;

namespace MusicCompany.Api
{
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicCompanyDbContext, Configuration>());
            MusicCompanyDbContext.Create().Database.Initialize(true);
        }
    }
}