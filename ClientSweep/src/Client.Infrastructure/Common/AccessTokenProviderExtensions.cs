﻿using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace ClientSweep.Client.Infrastructure.Common;

public static class AccessTokenProviderExtensions
{
    public static async Task<string?> GetAccessTokenAsync(this IAccessTokenProvider tokenProvider) =>
        (await tokenProvider.RequestAccessToken())
            .TryGetToken(out var token)
                ? token.Value
                : null;
}