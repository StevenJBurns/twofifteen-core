using System;
using System.ComponentModel.DataAnnotations.Schema;
using SJB.TwoFifteen.API.Enums;

namespace SJB.TwoFifteen.API.Models
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
    [Column("height", TypeName="smallint")]
    public UInt16 Height { get; set; }
    [Column("weight", TypeName="smallint")]
    public UInt16 Weight { get; set; }
    public Aptitude Throws { get; set; }
    public Aptitude Bats { get; set; }
    public String Remarks { get; set; }
  }
}