using System.Collections.Generic;

namespace TwoFifteen.Domain.Entity;

public sealed class Season
{
  public int Year { get; set; }
  public int WorldSeriesChampion { get; set; }
  public int AllStarGameWinnder { get; set; }
  public List<Game> Games { get; set; }
}
