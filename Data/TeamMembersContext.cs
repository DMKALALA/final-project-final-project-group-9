using final-project-final-project-group-9.Models;
using Microsoft.EntityFrameworkCore;

namespace final-project-final-project-group-9.Data
{
    public class TeamMembersContext : DbContext
    {
        public TeamMembersContext(DbContextOptions<TeamMembersContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember {Id = 1, FullName = "Ying Orr", Birthdate = new DateTime(2004, 3, 31), CollegeProgram = "Information system", YearInProgram = "Junior" },
                new TeamMember { Id = 2, FullName = "Pranish Adhikari", Birthdate = new DateTime(2001, 6, 24), CollegeProgram = "IT software development", YearInProgram = "sophomore" }, 
                new TeamMember { Id = 3, FullName = "Denis Kalala ", Birthdate = new DateTime(2004, 12, 6), CollegeProgram = "IT software development", YearInProgram = "Sophomore" }
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
