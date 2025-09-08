using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwoFifteen.Domain.Entity;

[Table("locations")]
public class Location
{
  [Column("id", TypeName = "int")]
  public Int32 ID { get; set; }

  [Column("city", TypeName = "nvarchar()")]
  public string City { get; set; }

  [Column("state_long", TypeName = "nvarchar()")]
  public string StateLong { get; set; }

  [Column("state_short", TypeName = "nvarchar()")]
  public string StateShort { get; set; }

  [Column("country_long", TypeName = "nvarchar()")]
  public string CountryLong { get; set; }

  [Column("country_short", TypeName = "nvarchar()")]
  public string CountryShort { get; set; }
}
