using System;

namespace CanvasApi.Client.OAuth2.Models
{
    public interface IOAuthTokenRequest
    {
        /// <summary>
        /// [INTERNAL] Grant Type Requested
        /// Values currently supported "authorization_code", "refresh_token", and "client_credentials"
        /// </summary>
        string GrantType { get; }
        /// <summary>
        /// The client id for your registered application.
        /// </summary>
        string ClientId { get; set; }
        /// <summary>
        /// The client secret for your registered application.
        /// </summary>
        string ClientSecret { get; set; }
        /// <summary>
        /// If a redirect_uri was passed to the initial request in step 1, the same redirect_uri must be given here.
        /// </summary>
        public string RedirectUri { get; set; }

        bool Validate();
    }

    public interface IAuthCodeToken: IOAuthTokenRequest
    {
        /// <summary>
        /// Required if grant_type is authorization_code. The code you received in a redirect response.
        /// </summary>
        string Code { get; set; }
    }

    public interface IAuthRefreshToken : IOAuthTokenRequest
    {
        /// <summary>
        /// Required if grant_type is refresh_token. The refresh_token you received in a redirect response.
        /// </summary>
        string RefreshToken { get; set; }
    }

    public interface IAuthClientCredentials : IOAuthTokenRequest
    {
        /// <summary>
        /// Currently the only supported value for this field is `urn:ietf:params:oauth:client-assertion-type:jwt-bearer`
        /// </summary>
        string ClientAssertionType => "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";
        /// <summary>
        /// The signed jwt used to request an access token. Includes the value of Developer Key id as the sub claim of the jwt body. Should be signed by the private key of the stored public key on the DeveloperKey.
        /// </summary>
        string ClientAssertion { get; set; }
        /// <summary>
        /// A list of scopes to be granted to the token. Currently only IMS defined scopes may be used.
        /// </summary>
        string Scope { get; }
    }
        
    internal abstract class TokenRequest: IOAuthTokenRequest
    {
        public abstract string GrantType { get; }
        public string ClientId { get; set; }
        public string ClientSecret  { get; set; }
        public string RedirectUri { get; set; }

        public virtual bool Validate()
        {
            this.RequiredField(nameof(this.GrantType), this.GrantType);
            this.RequiredField(nameof(this.ClientId), this.ClientId);
            this.RequiredField(nameof(this.ClientSecret), this.ClientSecret);
            this.RequiredField(nameof(this.RedirectUri), this.RedirectUri);

            return true;
        }

        protected bool RequiredField(string fieldName, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(fieldName, $"{fieldName} is required.");
            
            return true; 
        }
    }

    internal class AuthorizationCodeRequest : TokenRequest, IAuthCodeToken
    {
        public override string GrantType => "authorization_code";
        public override bool Validate()
        {
            this.RequiredField(nameof(this.Code), this.Code);
            return base.Validate();
        }

        public string Code { get; set; }
    }


    internal class RefreshTokenRequest: TokenRequest, IAuthRefreshToken
    {
        public override string GrantType => "refresh_token";
        public override bool Validate()
        {
            this.RequiredField(nameof(this.RefreshToken), this.RefreshToken);
            return base.Validate();
        }

        public string RefreshToken { get; set; }
    }

    internal class ClientCredentialsRequest : TokenRequest, IAuthClientCredentials
    {
        public override string GrantType => "client_credentials";
        public override bool Validate()
        {
            this.RequiredField(nameof(this.ClientAssertionType), this.ClientAssertionType);
            this.RequiredField(nameof(this.ClientAssertion), this.ClientAssertion);
            this.RequiredField(nameof(this.Scope), this.Scope);
            return base.Validate();
        }

        public string ClientAssertionType { get; set; }
        public string ClientAssertion { get; set; }
        public string Scope { get; set; }
    }
}
