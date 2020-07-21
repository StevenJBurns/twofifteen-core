using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Models
{
  public class Season
  {
    public int Year { get; set; }
    public int WorldSeriesChampion { get; set; }
    public int AllStarGameWinnder { get; set; }
    public List<Game> Games { get; set; }
  };
};
