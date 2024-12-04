using final-project-final-project-group-9.Models;
using Microsoft.EntityFrameworkCore;

namespace final-project-final-project-group-9.Data
{
    public class CoursesContext : DbContext
    {

        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, CourseNumber = "IT3045C", CourseName = "Contemporary Programming c#", Track = "Software Application Development", CreditHours = 3 },
                new Course { ID = 2, CourseNumber = "IT3071C", CourseName = "Network Security", Track = "Cybersecurity", CreditHours = 3 }
                );
        }

        public DbSet<Course> Courses { get; set; }
    }
}
