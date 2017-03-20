namespace SchoolSystem.Data
{
    using Models;
    using System.Data.Entity;

    public class SchoolSystemDbContext : DbContext
    {
        public SchoolSystemDbContext()
            :base("SchoolSystemDb")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }
        public object SetInitializer { get; set; }
    }
}
