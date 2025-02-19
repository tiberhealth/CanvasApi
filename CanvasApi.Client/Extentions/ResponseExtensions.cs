using System.Net;
using System.Net.Http;
using CanvasApi.Client.Exceptions;

namespace CanvasApi.Client.Extentions
{
    internal static class ResponseExtensions
    {
        public static CanvasApiException ToException(this HttpResponseMessage response, string resourceUrl)
        {
            return response.StatusCode switch
            {
                HttpStatusCode.NotFound => new CanvasResourceNotFoundException(response, resourceUrl),
                _ => new CanvasApiException(response)
            };
        }
    }
}
