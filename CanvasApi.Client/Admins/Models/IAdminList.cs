using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminList
    {
        [JsonProperty("user_id[]")] int[] UserId { get; set; }
    }
}