using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GardensApi.Models;

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
    }
}
