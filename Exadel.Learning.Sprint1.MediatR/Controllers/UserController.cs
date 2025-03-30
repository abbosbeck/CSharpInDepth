using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exadel.Learning.Sprint1.MediatR.Controllers
{
    public class UserController(ISender mediatr) : ApiControllerBase(mediatr)
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
