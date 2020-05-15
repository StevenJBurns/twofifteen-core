using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{  
  public class VenuesMockData : IVenue {
    public IEnumerable<Venue> GetAllVenues() {
      return Array.Empty<Venue>();
    }

    public IEnumerable<Venue> GetPaginatedVenues() {
      return Array.Empty<Venue>();;
    }

    public Venue GetVenueById(Int32 id) => new Venue
    {
      ID = id,
    };
  };
};
