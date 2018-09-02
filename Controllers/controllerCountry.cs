using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SJB.TwoFifteen.API.DataAccessLayer;
using SJB.TwoFifteen.API.Models;

namespace SJB.TwoFifteen.API.Controllers
{
  [Route("/[controller]")]
  public class CountryController : Controller
    {
    private readonly TwoFifteenContext _context;

    public CountryController(TwoFifteenContext context)
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