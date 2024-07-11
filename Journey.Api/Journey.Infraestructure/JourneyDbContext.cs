using Journey.Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infraestructure
{
    public class JourneyDbContext : DbContext
    {
          public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
