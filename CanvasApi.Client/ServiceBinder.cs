using CanvasApi.Client.OAuth2.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CanvasApi.Client
{
    public static class CanvasApiServiceBinder
    {
        public static void AddTiberCanvasApi(this IServiceCollection services)
        {
            services.TryAddTransient<IAuthCodeToken, AuthorizationCodeRequest>();
            services.TryAddTransient<IAuthRefreshToken, RefreshTokenRequest>();
            services.TryAddTransient<IAuthClientCredentials, ClientCredentialsRequest>();
        }
    }
}
