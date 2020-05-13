using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.API.Models;

namespace SJB.TwoFifteen.API.DataAccessLayer
  {
  public class TwoFifteenContext : DbContext
    {
    public DbSet<Location> Locations { get; set; }
    public DbSet<Venue> Venues { get; set; }
    public DbSet<Franchise> Franchises { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> People { get; set; }
    //public DbSet<Achievement> Achievements { get; set; }

    public TwoFifteenContext(DbContextOptions<TwoFifteenContext> options) : base(options)
      {
      }

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Venue>()
                  .HasOne(v => v.Location);
  }
  }