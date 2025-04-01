using CSharpInDepth.UserIdentity.Application.Members.Login;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController(ISender Sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> LoginMember(
            [FromBody] LoginCommand request,
            CancellationToken cancellationToken)
        {
            var command = new LoginCommand(request.Email);

            string tokenResult = await Sender.Send(command, cancellationToken);

            return Ok(tokenResult);
        }
    }
}
