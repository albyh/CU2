using CU2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CU2.DAL
{
    public class SchoolContext : DbContext
    {
        //the connection string (added to the Web.config file later) is passed in to the constructor.
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //prevents table names from being pluralized.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}