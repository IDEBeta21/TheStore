using Microsoft.AspNetCore.Mvc;

namespace EcomService.API.ProductController
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        // GET: ProductController
        // public IActionResult Index()
        // {
        //     return Ok();
        // }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Hello world!!");
        }
    }
}
