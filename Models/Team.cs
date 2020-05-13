using System;

namespace SJB.TwoFifteen.Models
{
  public class Team
  {
    public int ID { get; set; }
    public int FranchiseID { get; set; }
    public String Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeagueID { get; set; }
    public int DivisionID { get; set; }
  }
}