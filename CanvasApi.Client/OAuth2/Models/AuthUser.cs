using Newtonsoft.Json;

namespace CanvasApi.Client.OAuth2.Models
{
    public interface IAuthUser
    {
        long Id { get; }
        string Name { get; }
    }
    
    internal class AuthUser: IAuthUser
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }
}