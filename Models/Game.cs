using System;

namespace SJB.TwoFifteen.Models
{
  public class Game
    {
      public Int64 ID { get; set; }
      public DateTime Date { get; set; }
      public int AwayTeam { get; set; }
      public int HomeTeam { get; set; }
    };
};
