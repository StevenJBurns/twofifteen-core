using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TwoFifteen.Infrastucture.Repositories;
using TwoFifteen.Domain.Entity;

namespace SJB.TwoFifteen.Controllers
{
  [ApiController]
  [Route("api/locations")]
  public class LocationsController : ControllerBase
  {
    private readonly LocationsMockData _locations = new LocationsMockData();

    [HttpGet]
    public ActionResult<IEnumerable<Location>> GetAllLocations()
    { return Ok(_locations.GetAllLocations()); }

    [HttpGet("{id}")]
    public ActionResult<Location> GetLocationById(Int32 id)
    {
      var location = _locations.GetLocationById(id);
      return (location == null) ? NotFound() : Ok(location);
    }
  }
}
