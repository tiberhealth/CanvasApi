using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminRemove
    {
        [JsonProperty("role_id")] int? RoleId { get; set; }
    }
}