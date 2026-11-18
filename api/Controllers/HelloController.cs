using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {


        private readonly IHelloServices _helloServices;

        public HelloController(IHelloServices helloServices)
        {
            _helloServices = helloServices;
        }




        [HttpGet("sayhello/{name}")]
        public IActionResult SayHello(string name)
        {
            string realName = _helloServices.SayHello(name);
            return Ok(new { Message = realName});
        } 
    }
}