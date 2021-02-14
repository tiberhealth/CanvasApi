using Newtonsoft.Json;

namespace CanvasApi.Client.OAuth2.Models
{
    public interface ILogoutResponse
    {
        string ForwardUrl { get; }   
    }
    
    internal class LogoutResponse: ILogoutResponse
    {
        [JsonProperty("forward_url")] public string ForwardUrl { get; set; }
    }
}