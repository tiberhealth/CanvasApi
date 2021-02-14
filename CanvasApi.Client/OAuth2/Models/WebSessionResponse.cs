using Newtonsoft.Json;

namespace CanvasApi.Client.OAuth2.Models
{
    public interface IWebSessionResponse
    {
        string SessionUrl { get; }    
    }
    
    internal class WebSessionResponse: IWebSessionResponse
    {
        [JsonProperty("session_url")] public string SessionUrl { get; set; }
    }
}
