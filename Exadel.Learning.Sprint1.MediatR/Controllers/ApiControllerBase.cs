using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exadel.Learning.Sprint1.MediatR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
        protected ISender Mediator;
        public ApiControllerBase(ISender mediator)
        {
            Mediator = mediator;
        }
    }
}
