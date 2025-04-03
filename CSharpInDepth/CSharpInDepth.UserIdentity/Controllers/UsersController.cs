using Application.Users.GetUserByPhoneNumber;
using Application.Users.LoginUser;
using Application.Users.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    public class UsersController(ISender Sender) : ApiControllerBase(Sender)
    {
        [HttpPost("GetUserByPhoneNumber")]
        public async Task<IActionResult> GetUserByPhoneNumber(
            [FromBody] GetUserByPhoneNumberCommand request,
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

        [HttpPost("login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginUserCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);
            
            return Ok(tokenResult);
        }
    }
}
