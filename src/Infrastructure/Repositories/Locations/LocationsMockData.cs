using System;
using System.Collections.Generic;
using TwoFifteen.Domain.Entity;

namespace TwoFifteen.Infrastucture.Repositories;

public class LocationsMockData : ILocation
{
  private List<Location> _locations = new()
  {
    { new Location{ ID = 0, City = "Boston", StateShort = "MA", StateLong = "Massachusetts", CountryShort = "USA", CountryLong="United States" }},
    { new Location{ ID = 1, City = "Queens", StateShort = "NY", StateLong = "New York", CountryShort = "USA", CountryLong="United States" }},
    { new Location{ ID = 2, City = "Bronx", StateShort = "NY", StateLong = "New York", CountryShort = "USA", CountryLong="United States" }},
    { new Location{ ID = 3, City = "Denver", StateShort = "CO", StateLong = "Colorado", CountryShort = "USA", CountryLong="United States" }},
    { new Location{ ID = 9, City = "Houston", StateShort = "TX", StateLong = "Texas",  CountryShort = "USA", CountryLong="United States" }},
    { new Location{ ID = 10, City = "Toronto", StateShort = "ON", StateLong = "Ontario",  CountryShort = "CAN", CountryLong="Canada" }},
  };

  public IEnumerable<Location> GetAllLocations()
  {
    return _locations;
  }

  public IEnumerable<Location> GetPaginatedLocations()
  {
    return _locations;
  }

  public Location GetLocationById(Int32 id)
  {
    return _locations.Find(location => location.ID == id);
  }
}
