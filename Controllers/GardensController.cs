using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

//namespace based on folder structure (root then folder)
namespace GardensApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardensController : ControllerBase
    {
        //action result will map to command action
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}
