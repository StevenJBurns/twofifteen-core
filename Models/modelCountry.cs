using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SJB.TwoFifteen.Models
{
  public class Country
  {
    public Int16 ID { get; set; }
    [Column("name_long", TypeName="nvarchar()")]
    public String Name { get; set; }
  }
}