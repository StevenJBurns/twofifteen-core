using System.Collections.Generic;
using TwoFifteen.Domain.Entity;
using TwoFifteen.Infrastucture.Repositories;

namespace TwoFifteen.Infrastucture.GraphQL;

public class Query
{
  public IEnumerable<Venue> GetAllVenues(IVenueRepository venueRepository)
  {
    return (List<Venue>)venueRepository.GetAllVenues();
  }

  public Venue GetAuthorById(IVenueRepository venueRepository)
  {
    // return venueRepository.GetVenueById(id);
    return new Venue();
  }
}
