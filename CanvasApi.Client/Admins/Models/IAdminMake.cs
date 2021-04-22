using Newtonsoft.Json;

namespace CanvasApi.Client.Modules.Models
{
    public interface IAdminMake
    {
        [JsonProperty("name")] string Name { get; set; }
        [JsonProperty("role_id")] int? RoleId { get; set; }
        [JsonProperty("send_confirmation")] bool? SendConfirmation { get; set; }
    }
}