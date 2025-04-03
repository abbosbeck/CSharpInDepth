using Application.Members.Login;
using Application.Members.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    public class UsersController(ISender Sender) : ApiControllerBase(Sender)
    {
        [HttpPost]
        public async Task<IActionResult> Login(
            [FromBody] LoginCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);

            return Ok(tokenResult);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(
            [FromBody] RegisterCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);
            
            return Ok(tokenResult);
        }
    }
}
