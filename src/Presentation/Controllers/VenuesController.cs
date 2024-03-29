using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TwoFifteen.Infrastucture.Repositories;
using TwoFifteen.Domain.Entity;

namespace SJB.TwoFifteen.Controllers
{
  [ApiController]
  [Route("/api/venues")]
  public class VenuesController : ControllerBase
  {
    private readonly VenuesMockData _venues = new VenuesMockData();

    [HttpGet]
    public ActionResult<IEnumerable<Venue>> GetAllVenues()
    {
      System.Diagnostics.Trace.WriteLine(this.Request.GetType().ToString());
      return Ok(_venues.GetAllVenues());
    }

    // [HttpGet]
    // public ActionResult<IEnumerable<Venue>> GetPaginatedVenues()
    // {
    //   return Ok();
    // }

    [HttpGet("{id}")]
    public ActionResult<Venue> GetVenueById(Int32 id)
    {
      var venue = _venues.GetVenueById(id);
      return (venue == null) ? NotFound() : venue;
    }
  }
}
