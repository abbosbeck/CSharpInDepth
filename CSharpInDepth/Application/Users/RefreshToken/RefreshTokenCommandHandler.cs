﻿using Application.Authentication;
using Application.Common.Interfaces;
using MediatR;

namespace Application.Users.RefreshToken;

public sealed record RefreshTokenCommand(string RefreshToken) : IRequest<RefreshTokenResponse>;

class RefreshTokenCommandHandler(
    IRefreshTokenRepository refreshTokenRepository,
    IUnitOfWork unitOfWork,
    TokenProvider tokenProvider)
    : IRequestHandler<RefreshTokenCommand, RefreshTokenResponse>
{
    public async Task<RefreshTokenResponse> Handle(
        RefreshTokenCommand request,
        CancellationToken cancellationToken)
    {
        var refreshToken = await refreshTokenRepository.GetRefreshTokenAsync(request.RefreshToken);

        if (refreshToken == null || refreshToken.ExpiresOnUtc < DateTime.UtcNow)
        {
            throw new Exception("Refresh token has expired");
        }

        string accessToken = await tokenProvider.Create(refreshToken.User);

        refreshToken.Token = tokenProvider.GenerateRefreshToken();
        refreshToken.ExpiresOnUtc = DateTime.UtcNow.AddDays(7);

        refreshTokenRepository.UpdateRefreshToken(refreshToken);
        await unitOfWork.SaveChangesAsync();

        return new RefreshTokenResponse
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken.Token
        };
    }
}
