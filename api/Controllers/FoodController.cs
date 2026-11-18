using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {


        private readonly IFoodServices _foodServices;

        public FoodController(IFoodServices foodServices)
        {
            _foodServices = foodServices;
        }


        [HttpGet("restaurant/{restType}")]
        public IActionResult RestPick(int restType)
        {
            string restaurant = _foodServices.RestPick(restType);
            return Ok(new { Message = restaurant});
        }
    }
}