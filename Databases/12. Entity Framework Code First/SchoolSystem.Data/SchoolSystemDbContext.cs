namespace SchoolSystem.Data
{
    using System.Data.Entity;
    using SchoolSystem.Models;

    public class SchoolSystemDbContext : DbContext
    {
        public SchoolSystemDbContext()
            : base("SchoolSystem")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }

        public virtual DbSet<Material> Materials { get; set; }
    }
}
