using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminPromote

    {
        /// <summary>
        /// The id of the user to promote.
        /// </summary>
        [JsonProperty("user_id")] int UserId { get; set; }
        /// <summary>
        /// The user's admin relationship with the account will be created with the given role.
        /// 
        /// Defaults to the built-in role for 'AccountAdmin'.
        /// </summary>
        [JsonProperty("role_id")] int? RoleId { get; set; }
        /// <summary>
        /// Send a notification email to the new admin if true. Default is true.
        /// </summary>
        [JsonProperty("send_confirmation")] bool? SendConfirmation { get; set; }
    }
}