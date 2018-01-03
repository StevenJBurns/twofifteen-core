using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.DataAccessLayer
{
  public class TwoFifteenContext : DbContext
    {
    public TwoFifteenContext(DbContextOptions<TwoFifteenContext> options) : base(options)
      {
      }

    public DbSet<Location> Locations { get; set}
    public DbSet<Franchise> Franchises { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Venue> Venues { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Player> Players { get; set; }
    }
}