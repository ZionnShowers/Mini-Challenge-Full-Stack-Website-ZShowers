using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MagicController : ControllerBase
    {


        private readonly IMagicServices _magicServices;

        public MagicController(IMagicServices magicServices)
        {
            _magicServices = magicServices;
        }

        [HttpGet("magicball")]
        public IActionResult MagicBall()
        {
            string magicAnswer = _magicServices.MagicBall();
            return Ok(new { Message = magicAnswer});
        }
    }
}