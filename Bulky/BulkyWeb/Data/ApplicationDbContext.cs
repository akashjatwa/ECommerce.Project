using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ActionData1", DisplayOrder=1},
                new Category { Id = 2, Name = "ActionData2", DisplayOrder=2},
                new Category { Id = 3, Name = "ActionData3", DisplayOrder=3}
                );
        }
    }
}
