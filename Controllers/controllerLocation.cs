using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SJB.TwoFifteen.DataAccessLayer;
using SJB.TwoFifteen.Models;

namespace SJB.TwoFifteen.Controllers
  {
  [Route("/[controller]")]
  public class LocationController : Controller
    {
    private readonly TwoFifteenContext _context;

    public LocationController(TwoFifteenContext context)
      {
      _context = context;
      
      if (_context.Countries.Count() == 0)
        {
        // _context.Countries.Add(new TodoItem { Name = "Item1" });
        // _context.SaveChanges();
        }
      }

    [HttpGet]
    public IEnumerable<Country> GetAll()
      { return _context.Countries.ToList(); }

    [HttpGet("{id}", Name = "GetCountry")]
    public IActionResult GetById(Int16 id)
      {
      var country = _context.Countries.FirstOrDefault(c => c.ID == id);

      if (country == null) return NotFound();
    
      return new ObjectResult(country);
      }
    }
  }