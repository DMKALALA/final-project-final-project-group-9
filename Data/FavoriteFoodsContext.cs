using final-project-final-project-group-9.Models;
using Microsoft.EntityFrameworkCore;

namespace final-project-final-project-group-9.Data
{
    public class FavoriteFoodsContext : DbContext
    {
        public FavoriteFoodsContext(DbContextOptions<FavoriteFoodsContext> options) : base(options) { }

        //seed table with info
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteFoods>().HasData(
                new FavoriteFoods { Id = 14969824, FavBreakfast = "sandwich", FavLunch = "ham", FavSnack = "pie", FavDinner = "egg" },
                new FavoriteFoods { Id = 12345678, FavBreakfast = "Toast", FavLunch = "sandwich", FavSnack = "Chips", FavDinner = "pasta" });
        }

        public DbSet<FavoriteFoods> FavoriteFoods { get; set; }
    }
}
