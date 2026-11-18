using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingController : ControllerBase
    {


        private readonly IAddingServices _addingServices;

        public AddingController(IAddingServices addingServices)
        {
            _addingServices = addingServices;
        }




        [HttpGet("addition/{numOne}/{numTwo}")]
        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = _addingServices.Addition(numOne, numTwo);
            return Ok(new {numOne, numTwo, Result = sum});
        }
    }
}