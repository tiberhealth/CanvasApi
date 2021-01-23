using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CanvasApi.Client.Test")]
namespace CanvasApi.Client
{
    public class CanvasApiClient
    {
        private HttpClient Client { get; set; }

        public CanvasApiClient(string canvasDomain)
        {

        }

    }
}
