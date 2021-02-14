using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.OAuth2.Models;

namespace CanvasApi.Client.OAuth2
{
    internal class OAuth2Client : ApiClientBase, IOAuth2Api
    {
        internal OAuth2Client(CanvasApiClient parent) : base(parent)
        {
        }


        public async Task<IAuthToken> Token(IOAuthTokenRequest request)
        {
            const string url = "/login/oauth2/token";
            var results =
                await this.ApiClient.ApiOperation<AuthToken, IOAuthTokenRequest>(Client.Enums.ApiVerb.Post, url,
                    request);

            return results;
        }

        public async Task<ILogoutResponse> Logout(bool expireSessions)
        {
            const string url = "/login/oauth2/token";

            var results = await this.ApiClient.ApiOperation<LogoutResponse, object>(
                Client.Enums.ApiVerb.Delete,
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
                Client.Enums.ApiVerb.Get,
                url);

            return results;
        }
    }
}