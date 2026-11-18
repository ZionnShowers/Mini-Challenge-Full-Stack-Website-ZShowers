using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {

        private readonly IMadLibServices _madlibServices;

        public MadLibController(IMadLibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }


        [HttpGet("madlib/{word1}/{word2}/{word3}/{word4}/{word5}/{word6}/{word7}/{word8}/{word9}/{word10}")]
        public IActionResult MadLib(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10)
        {
            string madlib = _madlibServices.MadLib(word1, word2, word3, word4, word5, word6, word7, word8, word9, word10);
            return Ok(new { Message = madlib});
        }
    }
}