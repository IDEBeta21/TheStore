using Microsoft.AspNetCore.Mvc;

namespace EcomService.API.ProductController
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Hello world!!");
        }
    }
}
