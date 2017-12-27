using System;

namespace SJB.TwoFifteen.Models
{
  public class Player
  {
    public int ID { get; set; }
    public DateTime DateBorn { get; set; }
    public DateTime DateDeceased { get; set; }
    public int LocationBorn {get; set; }
    public int LocationDeceased { get; set; } 
    public String LastName { get; set; }
    public String FirstName { get; set; }
    public ushort Height { get; set; }
    public ushort Weight { get; set; }
    public char Throws { get; set; }
    public char Bats { get; set; }
    public String Remarks { get; set; }
  }
}