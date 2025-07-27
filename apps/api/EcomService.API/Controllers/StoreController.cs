using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Index()
        {
            return Ok("Hello Store");
        }

    }
}
