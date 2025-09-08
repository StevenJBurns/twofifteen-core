using System;
using System.Collections.Generic;
using TwoFifteen.Domain.Entity;

namespace TwoFifteen.Infrastucture.Repositories;

public class LocationsRepository : ILocation
{
  public IEnumerable<Location> GetAllLocations()
  {
    return Array.Empty<Location>();
  }

  public IEnumerable<Location> GetPaginatedLocations()
  {
    return Array.Empty<Location>(); ;
  }

  public Location GetLocationById(int id) => new()
  {
    ID = id,
    City = "Queens",
    StateLong = "New York",
    CountryShort = "USA",
  };
}
