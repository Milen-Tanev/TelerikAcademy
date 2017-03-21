namespace Superheroes.ConsoleApp
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SuperheroesDbContext,
                Configuration>());

            var db = new SuperheroesDbContext();

            db.Superheroes.Count();

            //var importer = new JsonImporter();
            //System.Console.WriteLine(importer.LoadJson());
        }
    }
}
