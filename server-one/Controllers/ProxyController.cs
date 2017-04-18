using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server_one.Controllers
{
    [Route("api/proxy")]
    public class ProxyController : Controller
    {
        private readonly FortunesService _fortunesService;

        public ProxyController(FortunesService fortunesService)
        {
            _fortunesService = fortunesService;
        }       

        [HttpGet("fortune")]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> GetRandomFortune()
        {
            return Ok(await _fortunesService.GetRandomFortune());
        }
    }
}
