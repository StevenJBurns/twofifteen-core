using System.Collections.Generic;
using TwoFifteen.Domain.Entity;

namespace TwoFifteen.Infrastucture.Repositories;

public interface ILocation
{
  IEnumerable<Location> GetAllLocations();
  IEnumerable<Location> GetPaginatedLocations();
  Location GetLocationById(int id);
}
