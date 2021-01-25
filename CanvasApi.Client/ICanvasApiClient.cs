using System;
using CanvasApi.Client.Acconts;

namespace CanvasApi.Client
{
    public interface ICanvasApiClient
    {
        PagingOptions DefaultPaginOptions { get; }

        /// <summary>
        /// API Calls for the Accounts subsystem in Canvas
        /// </summary>
        IAccountsApi Accounts { get; }

        /// <summary>
        /// Validates the CanvasApi Client configuration
        /// </summary>
        /// <returns>Boolean indicating if the validation was successful or not</returns>
        bool VerifyConfiguration();

    }
}
