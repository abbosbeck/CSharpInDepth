using Microsoft.AspNetCore.Mvc;

namespace AspDotNetInDepth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("throw")]
        public IActionResult ThrowError()
        {
            throw new Exception("This is a test exception!");
        }
    }
}
