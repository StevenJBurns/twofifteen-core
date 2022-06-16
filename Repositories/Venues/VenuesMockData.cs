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
      { new Venue{ ID = 4, LocationID = 4, Remarks = "Wrigley Field" }},
      { new Venue{ ID = 5, LocationID = 5, Remarks = "Dodgers Stadium" }},
      { new Venue{ ID = 6, LocationID = 6, Remarks = "Camden Yards" }},
      { new Venue{ ID = 7, LocationID = 7, IsDomeRetractable = true, Remarks = "Miller Park" }},
      { new Venue{ ID = 8, LocationID = 9, IsDomeRetractable = true, Remarks = "Minute Maid Park" }},
      { new Venue{ ID = 9, LocationID = 9, IsDome = true, Remarks = "The Astrodome" }},
      { new Venue{ ID = 10, LocationID = 10, IsDomeRetractable = true, Remarks = "Rogers Centre" }},
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
