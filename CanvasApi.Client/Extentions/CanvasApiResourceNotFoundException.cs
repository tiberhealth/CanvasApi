using System.Net.Http;
using CanvasApi.Client.Exceptions;

namespace CanvasApi.Client.Extentions;

public class CanvasApiResourceNotFoundException(HttpResponseMessage response) : CanvasApiException(response);

