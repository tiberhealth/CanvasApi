namespace CanvasApi.Client.OAuth2;

internal class OAuth2Client : ApiClientBase, IOAuth2Api
{
    public OAuth2Client(CanvasApiClient parent) : base(parent){ }

        
    internal async Task<IAuthToken> Token<TRequest>(Action<TRequest> optionsFactory) where TRequest: class, IOAuthTokenRequest, new()
    {
        const string url = "/login/oauth2/token";
        var request = new TRequest();
        optionsFactory?.Invoke(request);
            
        var results =
            await this.ApiClient.ApiOperation<AuthToken, TRequest>(HttpMethod.Post, url, request);

        return results;
    }

    public Task<IAuthToken> Token(Action<IAuthCodeToken> optionsFactory) => this.Token<AuthorizationCodeRequest>(optionsFactory);
    public Task<IAuthToken> Token(Action<IAuthRefreshToken> optionsFactory) => this.Token<RefreshTokenRequest>(optionsFactory);
    public Task<IAuthToken> Token(Action<IAuthClientCredentials> optionsFactory) => this.Token<ClientCredentialsRequest>(optionsFactory);
        
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