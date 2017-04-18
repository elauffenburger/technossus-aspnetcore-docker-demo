using Microsoft.AspNetCore.Mvc;

namespace server_two.Controllers
{
    [Route("api/fortunes")]
    public class FortunesController : Controller
    {
        [HttpGet("random")]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult GetTodaysFortunes()
        {
            return Ok("Nothing is truly random");
        }
    }
}
