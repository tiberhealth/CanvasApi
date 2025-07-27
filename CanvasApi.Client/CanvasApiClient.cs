// ReSharper disable InconsistentNaming
[assembly: InternalsVisibleTo("CanvasApi.Client.Test")]

namespace CanvasApi.Client;

public class CanvasApiClient : ICanvasApiClient, IDisposable
{
    private HttpClient Client { get; }
    private IServiceProvider ServiceProvider { get; }

    private readonly Lazy<OAuth2Client> OAuth2Client;

    private readonly Lazy<AccountsClient> AccountsClient;
    private readonly Lazy<AdminApiClient> AdminClient;
    private readonly Lazy<AssignmentGroupsApiClient> AssignmentGroupsClient;
    private readonly Lazy<AssignmentApiClient> AssignmentClient;
    private readonly Lazy<CourseApiClient> CoursesClient;
    private readonly Lazy<EnrollmentApiClient> EnrollmentClient;
    private readonly Lazy<EnrollmentTermsApiClient> EnrollmentTermsClient;
    private readonly Lazy<ModulesApiClient> ModulesClient;
    private readonly Lazy<PageApiClient> PagesClient;
    private readonly Lazy<RolesApiClient> RolesClient;
    private readonly Lazy<SectionApi> SectionClient;
    private readonly Lazy<SubmissionsApiClient> SubmissionsApiClient;
    private readonly Lazy<UsersClient> UsersClient;
    private readonly Lazy<WikisApiClient> WikisClient;

    public PagingOptions DefaultPagingOptions { get; private set; }

    /// <summary>
    /// Constructor - builds Http Client based on Domain and Key
    /// </summary>
    /// <param name="canvasDomain">The domain address to the Canvas Instance</param>
    /// <param name="apiKey">The API Key defined on the Canvas Instance for this application</param>
    public CanvasApiClient(string canvasDomain, string apiKey, IServiceProvider serviceProvider) :
        this(new HttpClient().ConfigureCanvasApi(canvasDomain, apiKey), serviceProvider)
    {
    }

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
    public CanvasApiClient(HttpClient client, IServiceProvider serviceProvider)
    {
        this.Client = client;
        this.ServiceProvider = serviceProvider;

        this.DefaultPagingOptions = new PagingOptions();

        // Build the Apis
        this.OAuth2Client = this.SetLazy<OAuth2Client>();

        this.AccountsClient = this.SetLazy<AccountsClient>();
        this.AdminClient = this.SetLazy<AdminApiClient>();
        this.AssignmentGroupsClient = this.SetLazy<AssignmentGroupsApiClient>();
        this.AssignmentClient = this.SetLazy<AssignmentApiClient>();
        this.CoursesClient = this.SetLazy<CourseApiClient>();

        this.EnrollmentClient = this.SetLazy<EnrollmentApiClient>();
        this.EnrollmentTermsClient = this.SetLazy<EnrollmentTermsApiClient>();
        this.ModulesClient = this.SetLazy<ModulesApiClient>();
        this.PagesClient = this.SetLazy<PageApiClient>();
        this.RolesClient = this.SetLazy<RolesApiClient>();
        this.SectionClient = this.SetLazy<SectionApi>();
        this.SubmissionsApiClient = this.SetLazy<SubmissionsApiClient>();
        this.UsersClient = this.SetLazy<Users.UsersClient>();
        this.WikisClient = this.SetLazy<WikisApiClient>();
    }

    private Lazy<TConcrete> SetLazy<TConcrete>() where TConcrete : ApiClientBase =>
        this.SetLazy(() =>
        {
            var concrete = (TConcrete)Activator.CreateInstance(typeof(TConcrete), this);
            return concrete;
        });

    private Lazy<TType> SetLazy<TType>(Func<TType> factory) => new Lazy<TType>(factory);

    #region ICanvasApi

    public IOAuth2Api OAuth2 => this.OAuth2Client.Value;

    public IAccountsApi Accounts => this.AccountsClient.Value;
    public IAdminApiClient Admin => this.AdminClient.Value;
    public IAssignmentGroupsApiClient AssignmentGroups => this.AssignmentGroupsClient.Value;
    public IAssignmentApiClient Assignments => this.AssignmentClient.Value;
    public ICourseApiClient Courses => this.CoursesClient.Value;
    public IEnrollmentApiClient Enrollments => this.EnrollmentClient.Value;
    public IEnrollmentTermsApiClient EnrollmentTerms => this.EnrollmentTermsClient.Value;
    public IModulesApiClient Modules => this.ModulesClient.Value;
    public IPageApiClient Pages => this.PagesClient.Value;
    public IRolesApiClient Roles => this.RolesClient.Value;
    public ISectionApi Sections => this.SectionClient.Value;
    public ISubmissionsApiClient Submissions => this.SubmissionsApiClient.Value;
    public IUsersApi Users => this.UsersClient.Value;
    public IWikisApiClient Wikis => this.WikisClient.Value;

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
        if (!this.disposedValue)
        {
            if (disposing)
            {
                this.Client.Dispose();
            }

            this.disposedValue = true;
        }
    }

    public void Dispose()
    {
        this.Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    #endregion

    internal Task<IEnumerable<TResult>> PagableApiOperation<TResult>(HttpMethod verb, string url, PagingOptions pagingOptions = null) =>
        this.PagableApiOperation<TResult, object>(verb, url, null, pagingOptions);

    internal Task<IEnumerable<TResult>> PagableApiOperation<TResult, TApiResult>(
        HttpMethod verb,
        string url,
        PagingOptions pagingOptions,
        Func<TApiResult, IEnumerable<TResult>> factory
    ) =>
        this.PagableApiOperation<TResult, TApiResult, object>(verb, url, null, factory, pagingOptions);

    internal async Task<IEnumerable<TResult>> PagableApiOperation<TResult, TBody>(
        HttpMethod verb,
        string url,
        TBody body,
        PagingOptions pagingOptions = null,
        CancellationToken cancellationToken = default)
        where TBody : class
    {
        var pageLinks = new PageLinks((pagingOptions ?? this.DefaultPagingOptions)?.AddPagingUrl(url) ?? url);
        var initialBuffer = await this.ApiOperation<IEnumerable<TResult>, TBody>(verb, pageLinks.OriginalUrl, body, pageLinks, cancellationToken);

        return new PageableResult<TResult>(initialBuffer, this, pageLinks);
    }

    internal async Task<IEnumerable<TResult>> PagableApiOperation<TResult, TApiResult, TBody>(
        HttpMethod verb,
        string url,
        TBody body,
        Func<TApiResult, IEnumerable<TResult>> factory,
        PagingOptions pagingOptions = null,
        CancellationToken cancellationToken = default)
        where TBody : class
    {
        var pageLinks = new PageLinks((pagingOptions ?? this.DefaultPagingOptions)?.AddPagingUrl(url) ?? url);
        var apiResults = await this.ApiOperation<TApiResult, TBody>(verb, pageLinks.OriginalUrl, body, pageLinks, cancellationToken);

        return new PageableResult<TResult, TApiResult>(apiResults, this, pageLinks, factory);
    }


    internal Task<TResult> ApiOperation<TResult>(HttpMethod verb, string url) => this.ApiOperation<TResult, object>(verb, url, null);

    internal async Task<TResult> ApiOperation<TResult, TBody>(
        HttpMethod verb,
        string url,
        TBody body,
        PageLinks pageLinks = null,
        CancellationToken cancellationToken = default)
        where TBody : class
    {
        var httpMessage = this.GenerateHttpRequest(verb, url, body);

        HttpResponseMessage result = null;
        try
        {
            result = await this.Client
                .SendAsync(httpMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new CanvasTransmissionException($"Canvas Transmission Exception: {ex.Message}. See Inner exception", ex);
        }

        if (result is null) throw new CanvasTransmissionException("Unknown Transmission Exception - no result provided");
        if (!result.IsSuccessStatusCode) throw result.ToException(url);

        pageLinks?.SetHeaders(result.Headers);

        var content = this.Decompress(await result.Content.ReadAsStringAsync(new CancellationToken()));

        using var contentStream = new System.IO.StringReader(content);
        await using var reader = new JsonTextReader(contentStream);

        var serializedCollection = new JsonSerializer()
        {
            ContractResolver = new DefaultNemesContractResolver()
        }.Deserialize<TResult>(reader);

        return serializedCollection ?? default(TResult);
    }

    private HttpRequestMessage GenerateHttpRequest(HttpMethod method, string url) => this.GenerateHttpRequest<object>(method, url, null);

    private HttpRequestMessage GenerateHttpRequest<TBody>(HttpMethod method, string url, TBody body)
        where TBody : class
    {
        HttpContent messageContent = null;
        var requestUrl = url;
        if (body != null)
        {
            messageContent = FormDataSerializer.Serialize(body, options =>
            {
                options.DefaultNameResolver = new PascalToSnakeResolver();
                options.EnumNameResolver = new PascalToSnakeResolver();
                options.DefaultDateFormat = "yyyy-MM-dd HH:mm:sszzz";
            });

            if (method == HttpMethod.Get && messageContent is MultipartFormDataContent multipartFormDataContent)
            {
                foreach (var content in multipartFormDataContent)
                {
                    var dataTask = content.ReadAsStringAsync();
                    dataTask.Wait();

                    if (!string.IsNullOrWhiteSpace(dataTask.Result))
                    {
                        var paramName = content.Headers.ContentDisposition.Name.Trim('"');
                        requestUrl += $"{(requestUrl.Contains('?') ? '&' : '?')}{paramName}={HttpUtility.UrlEncode(dataTask.Result)}";
                    }
                }
            }
        }

        var httpMessage = new HttpRequestMessage(method, requestUrl);
        if (!new [] {HttpMethod.Get, HttpMethod.Delete,}.Contains(method))  httpMessage.Content = messageContent;

        return httpMessage;
    }

    private string Decompress(string inbound)
    {
        if (string.IsNullOrEmpty(inbound) || inbound.Length < 2) return inbound;

        byte[] bytes = Encoding.Default.GetBytes(inbound);

        if (
            !(bytes[0] == 0x1F && bytes[1] == 0x8B) && // Check for gzip magic number
            !(bytes[0] == 0x78 && bytes[1] == 0x9C) && // Check for deflate magic number (default compression)
            !(bytes[0] == 0x78 && bytes[1] == 0xDA) // Check for deflate magic number (maximum compression)
        )
        {
            return inbound;
        }

        using var inputStream = new MemoryStream(bytes);
        using var outputStream = new MemoryStream();

        // Create decompression stream based on the compression format
        Stream decompressionStream = bytes[0] == 0x1F && bytes[1]  == 0x8B
            ? new GZipStream(inputStream, CompressionMode.Decompress)
            : new DeflateStream(inputStream, CompressionMode.Decompress);

        decompressionStream.CopyTo(outputStream);

        var decompressedBytes = outputStream.ToArray();
        return Encoding.Default.GetString(decompressedBytes);
    }

}
