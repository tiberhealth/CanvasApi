namespace CanvasApi.Client.OAuth2.Models
{ 
    public interface IAuthToken 
    {
        /// <summary>
        /// The OAuth2 Canvas API access token.
        /// </summary>
        string AccessToken { get; }
        /// <summary>
        /// The type of token that is returned.
        /// </summary>
        string TokenType { get; }
        /// <summary>
        /// A JSON object of canvas user id and user name.
        /// </summary>
        IAuthUser User { get; }
        /// <summary>
        /// Seconds until the access token expires.
        /// </summary>
        long ExpiresIn { get; }
    }
    
    internal class AuthToken: IAuthToken
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public AuthUser User { get; set; }
        public string RefreshToken { get; set; }
        public long ExpiresIn { get; set; }

        IAuthUser IAuthToken.User => this.User;
    }
}