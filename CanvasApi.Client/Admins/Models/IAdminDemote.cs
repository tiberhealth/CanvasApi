using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminDemote
    {
        [JsonProperty("role_id")] int? RoleId { get; set; }
    }
}