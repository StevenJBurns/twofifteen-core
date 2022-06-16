using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{
  public interface ILocation
  {
    IEnumerable<Location> GetAllLocations();
    IEnumerable<Location> GetPaginatedLocations();
    Location GetLocationById(Int32 id);
  };
};