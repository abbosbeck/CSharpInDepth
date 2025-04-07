﻿using Application.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Application.Users.RevokeRefreshToken;

public sealed record RevokeRefreshTokenCommand(Guid userId) : IRequest<bool>;

public class RevokeRefreshTokenCommandHandler(
    IRefreshTokenRepository refreshTokenRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<RevokeRefreshTokenCommand, bool>
{
    public async Task<bool> Handle(RevokeRefreshTokenCommand request, CancellationToken cancellationToken)
    {
        if (request.userId != GetCurrentUserId())
        {
            throw new ApplicationException("You cannot do this.");
        }

        await refreshTokenRepository.DeleteRefreshToken(request.userId);

        return true;
    }

    private Guid? GetCurrentUserId()
    {
        return Guid.TryParse(
            httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier),
            out Guid parsed)
            ? parsed : null;
    }
}
