using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.Repositories;
using SJB.TwoFifteen.Models;

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
      return Ok(_venues.GetAllVenues());
      }

    [HttpGet("{id}")]
    public ActionResult<Venue> GetVenueById(Int32 id)
      {
      var venue = _venues.GetVenueById(id);

      if (venue == null) return NotFound();
    
      return venue;
      }
    }
  }
