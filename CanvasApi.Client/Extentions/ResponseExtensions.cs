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
                _ => new CanvasApiException(response)
            };
        }
    }
}
