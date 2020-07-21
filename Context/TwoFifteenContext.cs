using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Context
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
  }
}