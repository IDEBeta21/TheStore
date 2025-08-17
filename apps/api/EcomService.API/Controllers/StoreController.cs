using EcomService.API.Models.Dto;
using EcomService.API.Services.StoreServices;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpGet("get-all-store-types")]
        public async Task<IActionResult> GetAllStoreTypes()
        {
            ServiceResponse<List<string>> value = await _storeService.GetAllStoreType();
            if (value.success == false) return BadRequest(value); 
            return Ok(value);
        }

    }
}
