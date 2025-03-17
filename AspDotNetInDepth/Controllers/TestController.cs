using AspDotNetInDepth.ExceptionFilters;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetInDepth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class TestController : ControllerBase
    {
        [HttpGet("throw")]
        [ServiceFilter(typeof(CustomExceptionFilter))]
        public IActionResult ThrowError()
        {
            throw new Exception("This is a test exception!");
        }
    }
}
