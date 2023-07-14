using System;

namespace CanvasApi.Client._Base
{
    public abstract class ApiClientBase
    {
        protected CanvasApiClient ApiClient { get; set; }

        protected ApiClientBase(CanvasApiClient parent) => this.ApiClient = parent;

        protected string UrlEncode(string source) => Uri.EscapeDataString(source);
    }
}
