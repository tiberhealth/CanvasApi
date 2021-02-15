using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CanvasApi.Client.Acconts;
using CanvasApi.Client.Extentions;
using CanvasApi.Client.OAuth2;
using CanvasApi.Client.Users;
using Newtonsoft.Json;
using TiberHealth.Serializer;

[assembly: InternalsVisibleTo("CanvasApi.Client.Test")]
namespace CanvasApi.Client
{
    public class CanvasApiClient: ICanvasApiClient, IDisposable
    {
        private HttpClient Client { get; set; }
        private readonly Lazy<AccountsClient> AccountsClient;
        private readonly Lazy<OAuth2Client> OAuth2Client;
        private readonly Lazy<UsersClient> UsersClient;

        public PagingOptions DefaultPagingOptions { get; private set; }

        /// <summary>
        /// Constructor - builds Http Client based on Domain and Key
        /// </summary>
        /// <param name="canvasDomain">The domain address to the Canvas Instance</param>
        /// <param name="apiKey">The API Key defined on the Canvas Instance for this application</param>
        public CanvasApiClient(string canvasDomain, string apiKey): this(new HttpClient().ConfigureCanvasApi(canvasDomain, apiKey))
        {}

        /// <summary>
        /// Constructor for an already initialized HttpClient.
        /// Used for Dependency Injection (startup.cs)
        ///
        ///             this.Services.AddHttpClient<ICanvasApiClient, CanvasApiClient>(client =>
        ///                 client.ConfigureCanvasApi(CanvasDomain, ApiKey)
        ///             );
        /// 
        /// </summary>
        /// <param name="client">Http Client object already initialized to the Canvas API domain/root and headers preparred.</param>
        public CanvasApiClient(HttpClient client)
        {
            this.Client = client;
            this.DefaultPagingOptions = new PagingOptions();

            // Build the Apis            
            this.AccountsClient = this.SetLazy(() => new AccountsClient(this));
            this.OAuth2Client = this.SetLazy(() => new OAuth2Client(this));
            this.UsersClient = this.SetLazy(() => new Users.UsersClient(this));
        }

        private Lazy<TType> SetLazy<TType>(Func<TType> factory) => new Lazy<TType>(factory);

        #region ICanvasApi
        public IAccountsApi Accounts => this.AccountsClient.Value;
        public IOAuth2Api OAuth2 => this.OAuth2Client.Value;
        public IUsersApi Users => this.UsersClient.Value;

        public bool VerifyConfiguration()
        {
            return this.Client != null &&
                !string.IsNullOrWhiteSpace(this.Client.BaseAddress?.AbsolutePath) &&
                this.Client.DefaultRequestHeaders.Any(item => item.Key == "Authorization" && item.Value is string[] vals && vals[0].StartsWith("Bearer"));
        }
        #endregion

        #region IDisposable
        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Client.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

        internal Task<IEnumerable<TResult>> PagableApiOperation<TResult>(HttpMethod verb, string url, PagingOptions pagingOptions = null) =>
            this.PagableApiOperation<TResult, object>(verb, url, null, pagingOptions);

        internal async Task<IEnumerable<TResult>> PagableApiOperation<TResult, TBody>(
            HttpMethod verb,
            string url,
            TBody body,
            PagingOptions pagingOptions = null,
            CancellationToken cancellationToken = default) where TBody: class
        {
            var pageLinks = new PageLinks((pagingOptions ?? this.DefaultPagingOptions)?.AddPagingUrl(url) ?? url); 
            var initialBuffer = await this.ApiOperation<IEnumerable<TResult>, TBody>(verb, pageLinks.OriginalUrl, body, pageLinks, cancellationToken);
            return new PageableResult<TResult>(initialBuffer, this, pageLinks);
        }

        internal Task<TResult> ApiOperation<TResult>(HttpMethod verb, string url) => this.ApiOperation<TResult, object>(verb, url, null);
        
        internal async Task<TResult> ApiOperation<TResult, TBody>(
            HttpMethod verb,
            string url,
            TBody body,
            PageLinks pageLinks = null,
            CancellationToken cancellationToken = default) where TBody: class
        {
            var httpMessage = this.GenerateHttpRequest(verb, url, body);

            var result = await this.Client
                .SendAsync(httpMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            if (result.IsSuccessStatusCode)
            {
                if (pageLinks != null) pageLinks.SetHeaders(result.Headers);

                await using var contentStream = await result.Content.ReadAsStreamAsync();
                using var streamReader = new StreamReader(contentStream);
                using var reader = new JsonTextReader(streamReader);

                return new JsonSerializer().Deserialize<TResult>(reader) ?? default(TResult);
            }

            throw result.ToEException();
        }

        private HttpRequestMessage GenerateHttpRequest(HttpMethod method, string url) => this.GenerateHttpRequest<object>(method, url, null);

        private HttpRequestMessage GenerateHttpRequest<TBody>(HttpMethod method, string url, TBody body)
            where TBody: class
        {
            var httpMessage = new HttpRequestMessage(method, url);

            if (body != null)
            {
                httpMessage.Content = FormDataSerializer.Serialize(body);
            }

            return httpMessage;
        }

    }
}
