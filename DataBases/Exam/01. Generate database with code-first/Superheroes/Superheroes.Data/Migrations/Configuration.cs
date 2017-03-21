namespace Superheroes.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SuperheroesDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Superheroes.Data.SuperheroesDbContext context)
        {

        }
    }
}
