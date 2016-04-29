using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base() { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("school");
            var studentConfig = modelBuilder.Entity<Student>();
            studentConfig.ToTable("StudentTable");
            studentConfig.HasKey<int>(s => s.StudentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
