using final_project_final_project_group_9.Models;
using Microsoft.EntityFrameworkCore;

namespace final_project_final_project_group_9.Data
{
    public class TVShowsContext : DbContext
    {

        public TVShowsContext(DbContextOptions<TVShowsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVShow>().HasData(
                new TVShow { ID = 1, ShowName = "Breaking bad", Genre = "Drama", NumSeasons = 7, ReleaseDate = new DateOnly(2008, 1, 8) },
                new TVShow { ID = 2, ShowName = "Doremon", Genre = "Comedy", NumSeasons = 20, ReleaseDate = new DateOnly(1980, 7, 20) }
                );
        }

        public DbSet<TVShow> TVShows { get; set; }
    }
}
    