namespace Superheroes.Data
{
    using Models;
    using System.Data.Entity;

    public class SuperheroesDbContext : DbContext
    {
        public SuperheroesDbContext()
            :base("Superheroes")
        {
        }

        public virtual IDbSet<Superhero> Superheroes { get; set; }

        public virtual IDbSet<Power> Powers { get; set; }

        public virtual IDbSet<Planet> Planets { get; set; }

        public virtual IDbSet<Fraction> Fractions { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<City> Cities { get; set; }

    }
}
