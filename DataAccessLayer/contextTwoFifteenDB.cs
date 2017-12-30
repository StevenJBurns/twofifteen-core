using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.DataAccessLayer
{
  public class TwoFifteenContext : DbContext
    {
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
      {
      }

    public DbSet<Franchise> Franchises { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Venue> Venues { get; set; }
    }
}