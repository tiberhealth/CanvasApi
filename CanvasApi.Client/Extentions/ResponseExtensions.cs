using System.IO;
using System.Net;
using System.Net.Http;
using CanvasApi.Client.Exceptions;

namespace CanvasApi.Client.Extentions
{
    internal static class ResponseExtensions
    {
        public static CanvasApiException ToException(this HttpResponseMessage response)
        {
            return response.StatusCode switch
            {
                HttpStatusCode.NotFound => new CanvasApiResourceNotFoundException(response),
                _ => new CanvasApiException(response)
            };
        }
    }
}
