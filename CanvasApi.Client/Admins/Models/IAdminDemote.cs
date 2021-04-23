using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminDemote
    {
        /// <summary>
        /// The user's admin relationship with the account will be created with the given role. 
        /// 
        /// Defaults to the built-in role for 'AccountAdmin'.
        /// </summary>
        [JsonProperty("role_id")] int? RoleId { get; set; }
    }
}