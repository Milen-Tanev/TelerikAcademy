namespace SchoolSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SchoolSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SchoolSystem.Data.SchoolSystemDbContext";
        }

        protected override void Seed(SchoolSystemDbContext context)
        {
            context.Students.AddOrUpdate(s => s.Name,
                new Student { Name = "Petar Petrov", Number = "12345" },
                new Student { Name = "Georgi Georgiev", Number = "23145" },
                new Student { Name = "Stamat Stamatov", Number = "32312" });
            context.Courses.AddOrUpdate(c => c.Name,
                new Course { Name = "C# Fundamentals", Description = "Start learning C#" },
                new Course { Name = "JavaScript Fundamentals", Description = "Run while you can" });
        }
    }
}
