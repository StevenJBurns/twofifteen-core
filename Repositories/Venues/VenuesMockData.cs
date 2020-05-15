using System;
using System.Collections.Generic;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Repositories
{  
  public class VenuesMockData : IVenue {
    private List<Venue> _venues = new List<Venue> {
      { new Venue{ ID = 0, LocationID = 0, Remarks = "Fenway Park" }},
      { new Venue{ ID = 1, LocationID = 1, Remarks = "Citi Field" }},
      { new Venue{ ID = 2, LocationID = 2, Remarks = "Yankees Stadium" }},
      { new Venue{ ID = 3, LocationID = 3, Remarks = "Coors Field" }},
    };

    public IEnumerable<Venue> GetAllVenues() {
      return _venues;
    }

    public IEnumerable<Venue> GetPaginatedVenues() {
      return _venues;
    }

    public Venue GetVenueById(Int32 id) {
      return _venues.Find(venue => venue.ID == id);
    }
  };
};
