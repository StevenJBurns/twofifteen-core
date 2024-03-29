using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwoFifteen.Domain.Entity;

[Table("venues")]
public class Venue
{
  [Column("id", TypeName = "int")]
  public int ID { get; set; }

  [Column("location_id", TypeName = "int")]
  public int LocationID { get; set; }

  [ForeignKey(name: "LocationID")]
  public Location Location { get; set; }

  public object[] Names { get; set; }

  [Column("date_open", TypeName = "date")]
  public DateTime? DateOpen { get; set; }

  [Column("date_closed", TypeName = "date")]
  public DateTime? DateClosed { get; set; }

  [Column("date_demolition", TypeName = "date")]
  public DateTime? DateDemolitioned { get; set; }

  [Column("date_lighting_installed", TypeName = "date")]
  public DateTime? DateLightingInstalled { get; set; }

  [Column("is_wooden", TypeName = "bit")]
  public Boolean IsWooden { get; set; }

  [Column("is_multipurpose", TypeName = "bit")]
  public Boolean IsMultiPurpose { get; set; }

  [Column("is_dome", TypeName = "bit")]
  public Boolean IsDome { get; set; }

  [Column("is_dome_retractable", TypeName = "bit")]
  public Boolean IsDomeRetractable { get; set; }

  [Column("remarks", TypeName = "nvarchar(1024)")]
  public String Remarks { get; set; }
}
