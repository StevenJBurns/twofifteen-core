using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SJB.TwoFifteen.API.Models
{
  public class Franchise
  {
    public int ID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
  }
}