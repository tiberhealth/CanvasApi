using System;
using CanvasApi.Client.Acconts;
using CanvasApi.Client.OAuth2;

namespace CanvasApi.Client
{
    public interface ICanvasApiClient
    {
        PagingOptions DefaultPagingOptions { get; }

        /// <summary>
        /// API Calls for the Accounts subsystem in Canvas
        /// </summary>
        IAccountsApi Accounts { get; }

        /// <summary>
        /// API Calls for OAuth Authentication in Canvas
        /// </summary>
        IOAuth2Api OAuth2 { get; }
        
        /// <summary>
        /// Validates the CanvasApi Client configuration
        /// </summary>
        /// <returns>Boolean indicating if the validation was successful or not</returns>
        bool VerifyConfiguration();

    }
}
