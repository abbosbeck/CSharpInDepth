using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController(ISender Sender) : ControllerBase
    {
    }
}
