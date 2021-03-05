using System;
using System.Net.Http;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Extentions;
using CanvasApi.Client.OAuth2.Models;

namespace CanvasApi.Client.OAuth2
{
    internal class OAuth2Client : ApiClientBase, IOAuth2Api
    {
        internal OAuth2Client(CanvasApiClient parent) : base(parent)
        {
        }


        public async Task<IAuthToken> Token<TRequest>(Action<TRequest> request) where TRequest: class, IOAuthTokenRequest, new()
        {
            const string url = "/login/oauth2/token";
            var results =
                await this.ApiClient.ApiOperation<AuthToken, TRequest>(HttpMethod.Post, url,
                    request.GetOptions<TRequest, TRequest>()
            );

            return results;
        }

        public async Task<ILogoutResponse> Logout(bool expireSessions)
        {
            const string url = "/login/oauth2/token";

            var results = await this.ApiClient.ApiOperation<LogoutResponse, object>(
                HttpMethod.Delete,
                url,
                expireSessions ? new {expireSessions = 1} : null
            );

            return results;
        }

        public async Task<IWebSessionResponse> WebSession(string returnTo)
        {
            var url = "/login/session_token";
            if (!string.IsNullOrWhiteSpace(returnTo)) url += $"?return_to={this.UrlEncode(returnTo)}";
            
            var results = await this.ApiClient.ApiOperation<WebSessionResponse>(
                HttpMethod.Get,
                url);

            return results;
        }
    }
}