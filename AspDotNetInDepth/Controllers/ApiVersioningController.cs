using Microsoft.AspNetCore.Mvc;

namespace AspDotNetInDepth.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok("Products from version 1");
    }

    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok("Products from version 2");
    }
}
