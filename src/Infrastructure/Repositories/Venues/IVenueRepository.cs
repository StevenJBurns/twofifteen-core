using System;
using System.Collections.Generic;
using TwoFifteen.Domain.Entity;

namespace TwoFifteen.Infrastucture.Repositories;

public interface IVenueRepository
{
  void CreateNewVenue();
  IEnumerable<Venue> GetAllVenues();
  IEnumerable<Venue> GetPaginatedVenues();
  Venue GetVenueById(Int32 id);
}
