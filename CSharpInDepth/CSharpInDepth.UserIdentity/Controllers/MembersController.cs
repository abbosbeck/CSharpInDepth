using Application.Members.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    public class MembersController(ISender Sender) : ApiControllerBase(Sender)
    {
        [HttpPost]
        public async Task<IActionResult> LoginMember(
            [FromBody] LoginCommand request,
            CancellationToken cancellationToken)
        {
            var tokenResult = await Sender.Send(request, cancellationToken);

            return Ok(tokenResult);
        }
    }
}
