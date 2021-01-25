using System;
using System.Net;
using System.Net.Http;

namespace CanvasApi.Client.Exceptions
{
    public class CanvasApiException : Exception
    {
        public HttpResponseMessage Response { get; }
        public HttpStatusCode? StatusCode => this.Response?.StatusCode;
        public bool? IsSuccessful => this.Response.IsSuccessStatusCode;

        internal CanvasApiException(HttpResponseMessage response, string message = null, Exception innterException = null) : base(message, innterException)
        {
            this.Response = response;
        }
    }
}
