namespace StudentSystem.Api.App_Start
{
    using System.Data.Entity;

    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            StudentSystemDbContext.Create().Database.Initialize(true);
        }
    }
}