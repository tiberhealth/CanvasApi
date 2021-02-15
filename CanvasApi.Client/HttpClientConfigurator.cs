using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace CanvasApi.Client
{
    public static class HttpClientConfigurator
    {
        public static HttpClient ConfigureCanvasApi(this HttpClient httpClient, string canvasDomain, string apiKey)
        {
            httpClient.ConfigureCanvasApi(canvasDomain);

            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey), "API key is a required element.");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

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
