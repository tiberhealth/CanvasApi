using System;
using System.Net.Http;

namespace CanvasApi.Client.Exceptions;

public class CanvasResourceNotFoundException(HttpResponseMessage response, string resourceUrl = null, Exception innterException = null) : CanvasApiException(response, $"Resource not found: {resourceUrl}", innterException)
{
    private string Resource { get; } = resourceUrl;
}
