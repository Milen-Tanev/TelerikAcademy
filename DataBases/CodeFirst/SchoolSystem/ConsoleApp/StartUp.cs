using Models;
using SchoolSystem.Data;
using SchoolSystem.Data.Migrations;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Note - you may need to change in ConsoleApp/App.config
            // connectionString="Data Source=DESKTOP-SDB9NHO\SQLEXPRESS;
            // the DESKTOP-SDB9NHO\SQLEXPRESS part with the server name on your pc.
            // You can find it when you start Microsoft SQL Server Management Studio
            // under Server name
                
            SchoolSystemDbContext db = new SchoolSystemDbContext();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolSystemDbContext, Configuration>());

            var student = db.Students.Where(st => st.Name == "Todor Todorov").FirstOrDefault();


            db.SaveChanges();
        }
    }
}
