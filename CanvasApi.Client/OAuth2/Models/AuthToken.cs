using System.Runtime.CompilerServices;
using Newtonsoft.Json;

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
        [JsonProperty("access_token")] public string AccessToken { get; set; }
        [JsonProperty("token_type")] public string TokenType { get; set; }
        [JsonProperty("user")] public AuthUser TokenUser { get; set; }
        [JsonProperty("refresh_token")] public string RefreshToken { get; set; }
        [JsonProperty("expires_in")] public long ExpiresIn { get; set; }

        public IAuthUser User => this.TokenUser;
    }
}