using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CanvasApi.Client.Exceptions;

namespace CanvasApi.Client.Extentions
{
    public static class ResponseExtensions
    {
        public static CanvasApiException ToEException(this HttpResponseMessage response)
        {
            return response.StatusCode switch
            {
                _ => new CanvasApiException(response)
            };
        }
    }
}
