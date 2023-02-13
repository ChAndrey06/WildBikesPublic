﻿using System.Security.Claims;

namespace WildBikesApi.Services.TokenService
{
    public interface ITokensService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
