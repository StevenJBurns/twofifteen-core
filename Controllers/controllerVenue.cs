using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SJB.TwoFifteen.Context;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Controllers
  {
  [ApiController]
  [Route("[controller]")]
  public class VenueController : ControllerBase
    {
    private readonly TwoFifteenContext _context;

    public VenueController(TwoFifteenContext context)
      {
      
      _context = context;
      
      if (_context.Locations.Count() == 0)
        {
        // _context.Countries.Add(new TodoItem { Name = "Item1" });
        // _context.SaveChanges();
        }
      }

    [HttpGet]
    public IEnumerable<Venue> GetAll()
      {
      var venues = _context.Venues.Include(v => v.Location).ToList();

      return venues;
      }

    [HttpGet("{id}", Name = "GetVenue")]
    public IActionResult GetById(Int32 id)
      {
      var venue = _context.Venues.FirstOrDefault(v => v.ID == id);

      if (venue == null) return NotFound();
    
      return new ObjectResult(venue);
      }
    }
  }
