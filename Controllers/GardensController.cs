using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GardensApi.Models;
using Microsoft.EntityFrameworkCore;

//namespace based on folder structure (root then folder)
//inherits from controller base
//not static
//to show that it is actually a controller we need to decorate
//it with "apicontroller"
//Route is the path for where the action method is being called.
//the action method is telling the browser what to return
//in this case return the action of iterating through the array.
namespace GardensApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardensController : ControllerBase
    {
        //setting our controller up to use our db context class
        private readonly GardenContext _context;

        public GardensController(GardenContext context) => _context = context;

        //Get:      api/gardens
        [HttpGet]
        public ActionResult<IEnumerable<Garden>> GetGardens()
        {
            return _context.GardenItems;
        }


        //Get: specific line number  api/gardens/{#}
        [HttpGet("{id}")]
        public ActionResult<Garden> GetGardenItem(int id)
        {
            var gardenItem = _context.GardenItems.Find(id);

            if (gardenItem == null)
            {
                return NotFound();
            }

            return gardenItem;
        }

        //Post: add a new plant     api/gardens
        [HttpPost]
        public ActionResult<Garden> PostGardenItem(Garden garden)
        {
            _context.GardenItems.Add(garden);
            _context.SaveChanges();

            return CreatedAtAction("GetGardenItem", new Garden{Id = garden.Id}, garden);
        }

        //Put: updated a plant's detail     api/{#}
        [HttpPut("{id}")]
        public ActionResult<Garden> PutGardenItem(int id, Garden garden)
        {
            if (id != garden.Id)
            {
                return BadRequest();
            }

            _context.Entry(garden).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }
    }
}
