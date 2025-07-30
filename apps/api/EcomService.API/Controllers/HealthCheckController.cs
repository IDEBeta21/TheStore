using EcomService.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcomService.API.HealthCheckController
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : Controller
    {
        private readonly StoreDataContext _datacontext;
        public HealthCheckController(StoreDataContext datacontext)
        {
            _datacontext = datacontext;
        }

        [HttpGet("dbcheck")]
        public async Task<IActionResult> CheckDatabaseConnection()
        {
            var canConnect = await _datacontext.Database.CanConnectAsync();
            if (canConnect)
            {
                return Ok("Database connection is successful.");
            }
            else
            {
                return StatusCode(500, "Unable to connect to the database.");
            }
        }

    }
}
