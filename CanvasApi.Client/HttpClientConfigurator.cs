using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;

namespace CanvasApi.Client
{
    public static class HttpClientConfigurator
    {
        public static HttpClient ConfigureCanvasApi(this HttpClient httpClient, string canvasDomain, string apiKey)
        {
            var assemblyName = Assembly.GetEntryAssembly().GetName();
            var version = assemblyName.Version is not null ? $"{assemblyName.Version.Revision}.{assemblyName.Version.Major}.{assemblyName.Version.Minor}" : "1.0.0";
            
            httpClient.ConfigureCanvasApi(canvasDomain);

            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey), "API key is a required element.");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            httpClient.DefaultRequestHeaders.Host = new Uri(canvasDomain).Host;
            
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(assemblyName.Name, version));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

            httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("identity", 1.0));
            
            return httpClient;
        }

        public static HttpClient ConfigureCanvasApi(this HttpClient httpClient, string canvasDomain)
        {
            if (string.IsNullOrWhiteSpace(canvasDomain)) throw new ArgumentNullException(nameof(canvasDomain), "Canvas domain is a required element.");
            httpClient.BaseAddress = new Uri(canvasDomain, UriKind.Absolute);

            return httpClient;
        }

    }
}
