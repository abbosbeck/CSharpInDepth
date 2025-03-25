using AspDotNetInDepth.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetInDepth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[TypeFilter(typeof(CustomExceptionFilter))]
    public class TestController : ControllerBase
    {
        [HttpGet("throw")]
        // [ServiceFilter(typeof(CustomExceptionFilter))]
        public IActionResult ThrowError()
        {
            throw new Exception("This is a test exception!");
        }

        [HttpPost]
        public IActionResult CreateGameFromBody([FromBody] Player game)
        {
            return Ok($"Game with a name {game.Name} is valid and {game.Level} costs.");
        }

        [HttpPost("/new/type")]
        public IActionResult CreateGameFromHeader([FromHeader] Player game)
        {
            return Ok($"Game with a name {game.Name} is valid and {game.Level} costs.");
        }
    }
}
