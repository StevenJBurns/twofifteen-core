using System;

namespace TwoFifteen.Domain.Entity;

public class Game
{
  public long ID { get; set; }
  public DateTime Date { get; set; }
  public int AwayTeam { get; set; }
  public int HomeTeam { get; set; }
}
