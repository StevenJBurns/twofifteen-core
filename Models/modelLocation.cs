using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SJB.TwoFifteen.Models
  {
  public class Location
    {
    public Int16 ID { get; set; }
    [Column("state_long", TypeName="nvarchar")]
    public string City { get; set; }
    [Column("state_long", TypeName="nvarchar")]
    public string StateLong { get; set; }
    [Column("state_short", TypeName="nvarchar")]
    public string StateShort { get; set; }
    [Column("country_long", TypeName="nvarchar")]
    public string CountryLong { get; set; }
    [Column("state_short", TypeName="nvarchar")]
    public String CountryShort { get; set; }
    }
  }