using System;
using System.Threading.Tasks;
using CanvasApi.Client.OAuth2.Models;

namespace CanvasApi.Client.OAuth2
{
    public interface IOAuth2Api
    {
        /// <summary>
        /// Gets API Token based on the authentication request
        /// </summary>
        /// <param name="request">The authentication request</param>
        /// <returns>Auth Token</returns>
        Task<IAuthToken> Token<TRequest>(Action<TRequest> request) where TRequest : class, IOAuthTokenRequest, new();
        /// <summary>
        /// If your application supports logout functionality, you can revoke your own access token. This is useful for security reasons, as well as removing your application from the list of tokens on the user's profile page.
        /// Simply make an authenticated request to the following endpoint by including an Authorization header or providing the access_token as a request parameter.
        /// </summary>
        /// <param name="expireSessions">Set this to '1' if you want to end all of the user's Canvas web sessions. Without this argument, the endpoint will leave web sessions intact.
        /// Additionally, if the user logged in to Canvas via a delegated authentication provider, and the provider supports Single Log Out functionality, the response will contain a forward_url key. If you are still in control of the user's browsing session, it is recommended to then redirect them to this URL, in order to also log them out from where their session originated.
        /// Beware that it is unlikely that control will be returned to your application after this redirect.
        /// </param>
        /// <returns></returns>
        Task<ILogoutResponse> Logout(bool expireSessions);
        /// <summary>
        /// If your application needs to begin a normal web session in order to access features not supported via API (such as quiz taking), you can use your API access token in order to get a time-limited URL that can be fed to a browser or web view to begin a new web session.
        /// </summary>
        /// <param name="returnTo">An optional URL to begin the web session at. Otherwise the user will be sent to the dashboard.</param>
        /// <returns></returns>
        Task<IWebSessionResponse> WebSession(string returnTo);
    }
}
