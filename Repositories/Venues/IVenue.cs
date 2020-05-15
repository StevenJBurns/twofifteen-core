using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{
  public interface IVenue
  {
    IEnumerable<Venue> GetAllVenues();
    IEnumerable<Venue> GetPaginatedVenues();
    Venue GetVenueById(Int32 id);
  };
};
