using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComparingController : ControllerBase
    {

        private readonly IComparingServices _comparingServices;

        public ComparingController(IComparingServices comparingServices)
        {
            _comparingServices = comparingServices;
        }



        [HttpGet("comparison/{numOne}/{numTwo}")]
        public IActionResult Comparison(int numOne, int numTwo)
        {
            string comparison = _comparingServices.Comparison(numOne, numTwo);
            return Ok(new { Message = comparison});
        }
    }
}