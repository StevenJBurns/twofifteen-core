using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{  
  public class LocationsMockData : ILocation {
    private List<Location> _locations = new List<Location> {
      { new Location{ ID = 0, City = "Boston", StateShort = "MA", CountryShort = "USA" }},
      { new Location{ ID = 1, City = "Queens", StateShort = "NY", CountryShort = "USA" }},
      { new Location{ ID = 2, City = "Bronx", StateShort = "NY", CountryShort = "USA" }},
      { new Location{ ID = 3, City = "Denver", StateShort = "CO", CountryShort = "USA" }},
    };

    public IEnumerable<Location> GetAllLocations() {
      return _locations;
    }

    public IEnumerable<Location> GetPaginatedLocations() {
      return _locations;
    }

    public Location GetLocationById(Int32 id) {
      return _locations.Find(location => location.ID == id);
    }
  };
};
