using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SJB.TwoFifteen.API.DataAccessLayer;
using SJB.TwoFifteen.API.Models;

namespace SJB.TwoFifteen.API.Controllers
  {
  [Route("/[controller]")]
  public class LocationController : Controller
    {
    private readonly TwoFifteenContext _context;

    public LocationController(TwoFifteenContext context)
      {
      _context = context;
      
      if (_context.Locations.Count() == 0)
        {
        // _context.Countries.Add(new TodoItem { Name = "Item1" });
        // _context.SaveChanges();
        }
      }

    [HttpGet]
    public IEnumerable<Location> GetAll()
      { return _context.Locations.ToList(); }

    [HttpGet("{id}", Name = "GetLocation")]
    public IActionResult GetById(Int32 id)
      {
      var location = _context.Locations.FirstOrDefault(l => l.ID == id);

      if (location == null) return NotFound();
    
      return new ObjectResult(location);
      }
    }
  }