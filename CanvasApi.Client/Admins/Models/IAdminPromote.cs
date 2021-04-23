using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminPromote

    {
        [JsonProperty("name")] string Name { get; set; }
        [JsonProperty("role_id")] int? RoleId { get; set; }
        [JsonProperty("send_confirmation")] bool? SendConfirmation { get; set; }
    }
}