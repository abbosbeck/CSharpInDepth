using Application.Users.GetUserByPhoneNumber;
using Application.Users.LoginUser;
using Application.Users.RefreshToken;
using Application.Users.Register;
using Application.Users.RevokeRefreshToken;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(
            [FromBody] RegisterCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);

            return Ok(tokenResult);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginUserCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);

            return Ok(tokenResult);
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> LoginWithRefreshToken(
            [FromBody] RefreshTokenCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);

            return Ok(tokenResult);
        }

        [HttpPost("RevokeRefreshToken")]
        public async Task<IActionResult> RevokeRefreshToken(
            [FromBody] RevokeRefreshTokenCommand request,
            CancellationToken cancellationToken)
        {
            var success = await Sender.Send(request, cancellationToken);

            return Ok(success);
        }
    }
}
