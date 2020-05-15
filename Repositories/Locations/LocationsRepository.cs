using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{  
  public class LocationsRepository : ILocation {
    public IEnumerable<Location> GetAllLocations() {
      return Array.Empty<Location>();
    }

    public IEnumerable<Location> GetPaginatedLocations() {
      return Array.Empty<Location>();;
    }

    public Location GetLocationById(Int32 id) => new Location
    {
      ID = id,
      City = "Queens",
      StateLong = "New York",
      CountryShort = "USA",
    };
  };
};
